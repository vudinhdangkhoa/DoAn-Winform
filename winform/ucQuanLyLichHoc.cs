using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{

    public partial class ucQuanLyLichHoc : UserControl
    {
        

        // DTO Classes (Đặt trong file riêng hoặc lồng trong UC)
        public class KhoaHocDTO
        {
            public int IdKhoaHoc { get; set; }
            public string TenKhoaHoc { get; set; }
            public List<LopHocDTO> LopHocs { get; set; }
        }

        public class LopHocDTO
        {
            public int IdLopHoc { get; set; }
            public string TenLopHoc { get; set; }
            public List<LichHocDTO> LichHocs { get; set; }
            public List<GiaoVienDTO> GiaoVien { get; set; } // Danh sách GV dạy lớp này
        }

        public class GiaoVienDTO
        {
            public int IdGiaoVien { get; set; }
            public string TenGiaoVien { get; set; }
        }

        public class LichHocDTO
        {
            public int IdLichHoc { get; set; }
            public DateTime NgayHoc { get; set; } // API trả về DateOnly nhưng Newtonsoft tự map sang DateTime đc
            public TimeSpan ThoiGianBatDau { get; set; }
            public TimeSpan ThoiGianKetThuc { get; set; }
            public PhongHocDTO PhongHoc { get; set; }
        }

        public class PhongHocDTO
        {
            public int IdPhong { get; set; }
            public string TenPhong { get; set; }
        }

        private List<KhoaHocDTO> _originalData;

        // Biến lưu trạng thái đang chọn
        private int _selectedLichHocId = -1;
        private int _selectedLopHocId = -1;
        private string _selectedInfo = ""; // Thông tin hiển thị lên form con

        public ucQuanLyLichHoc()
        {
            InitializeComponent();
            InitializeGrid();

            // Gán sự kiện
            this.Load += async (s, e) => await LoadData();
            cboKhoaHoc.SelectedIndexChanged += CboKhoaHoc_SelectedIndexChanged;
            cboLopHoc.SelectedIndexChanged += CboLopHoc_SelectedIndexChanged; // Quan trọng: Chọn lớp -> Load lịch

            dgvLichHoc.CellClick += DgvLichHoc_CellClick;
            btnBaoNghi.Click += BtnBaoNghi_Click;
            btnXemLich.Click += (s, e) => CboLopHoc_SelectedIndexChanged(null, null); // Reload thủ công nếu cần
            btn_refesh.Click += async (s, e) => await LoadData();
        }

        private void InitializeGrid()
        {
            dgvLichHoc.AutoGenerateColumns = false;
            dgvLichHoc.Columns.Clear();

            // Cột ID (Ẩn)
            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdLichHoc", DataPropertyName = "IdLichHoc", Visible = false });

            // Cột Ngày
            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayHoc",
                HeaderText = "Ngày Học",
                DataPropertyName = "NgayHoc",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // Cột Giờ
            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "CaHoc", HeaderText = "Ca Học" }); // Cột này sẽ tự fill bằng code

            // Cột Phòng
            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenPhong", HeaderText = "Phòng" });

            // Cột Giáo Viên (Lấy từ Lớp)
            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "GiaoVien", HeaderText = "Giáo Viên" });
        }

        // --- LOAD DATA TỪ API ---
        private async System.Threading.Tasks.Task LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl("QLLichHoc/GetAllKhoaLopLichHoc"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        _originalData = JsonConvert.DeserializeObject<List<KhoaHocDTO>>(json);

                        // Load ComboBox Khóa Học
                        cboKhoaHoc.DataSource = _originalData;
                        cboKhoaHoc.DisplayMember = "TenKhoaHoc";
                        cboKhoaHoc.ValueMember = "IdKhoaHoc";
                        cboKhoaHoc.SelectedIndex = -1; // Reset
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- SỰ KIỆN COMBOBOX ---
        private void CboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLopHoc.DataSource = null;
            dgvLichHoc.Rows.Clear();

            if (cboKhoaHoc.SelectedIndex != -1)
            {
                var selectedKhoa = (KhoaHocDTO)cboKhoaHoc.SelectedItem;

                cboLopHoc.DataSource = selectedKhoa.LopHocs;
                cboLopHoc.DisplayMember = "TenLopHoc";
                cboLopHoc.ValueMember = "IdLopHoc";
                cboLopHoc.SelectedIndex = -1;
            }
        }

        private void CboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLichHoc.Rows.Clear();
            _selectedLichHocId = -1;
            btnBaoNghi.Enabled = false;

            if (cboLopHoc.SelectedIndex != -1)
            {
                var selectedLop = (LopHocDTO)cboLopHoc.SelectedItem;
                _selectedLopHocId = selectedLop.IdLopHoc;

                // Lấy tên các giáo viên của lớp này
                string tenGVs = selectedLop.GiaoVien != null
                    ? string.Join(", ", selectedLop.GiaoVien.Select(g => g.TenGiaoVien))
                    : "Chưa phân công";

                // Đổ dữ liệu vào Grid
                foreach (var lich in selectedLop.LichHocs.OrderBy(l => l.NgayHoc))
                {
                    string caHoc = $"{lich.ThoiGianBatDau:hh\\:mm} - {lich.ThoiGianKetThuc:hh\\:mm}";
                    string phong = lich.PhongHoc != null ? lich.PhongHoc.TenPhong : "Chưa xếp";

                    // Add dòng
                    int index = dgvLichHoc.Rows.Add();
                    var row = dgvLichHoc.Rows[index];

                    row.Cells["IdLichHoc"].Value = lich.IdLichHoc;
                    row.Cells["NgayHoc"].Value = lich.NgayHoc;
                    row.Cells["CaHoc"].Value = caHoc;
                    row.Cells["TenPhong"].Value = phong;
                    row.Cells["GiaoVien"].Value = tenGVs;

                    // Style: Nếu lịch đã qua thì xám, sắp tới thì xanh
                    if (lich.NgayHoc < DateTime.Today)
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                    else
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        // --- SỰ KIỆN CHỌN DÒNG ---
        private void DgvLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvLichHoc.Rows[e.RowIndex];

            _selectedLichHocId = Convert.ToInt32(row.Cells["IdLichHoc"].Value);
            DateTime ngayHoc = Convert.ToDateTime(row.Cells["NgayHoc"].Value);
            string caHoc = row.Cells["CaHoc"].Value.ToString();
            string phong = row.Cells["TenPhong"].Value.ToString();
            string gv = row.Cells["GiaoVien"].Value.ToString();

            // Hiển thị sang Panel phải
            txtDetailDate.Text = $"{ngayHoc:dd/MM/yyyy} | {caHoc}";
            txtDetailPhong.Text = phong;
            txtDetailGV.Text = gv;

            // Logic trạng thái
            if (ngayHoc < DateTime.Today)
            {
                txtStatus.Text = "Đã kết thúc";
                btnBaoNghi.Enabled = false; // Không thể báo nghỉ lịch quá khứ
            }
            else
            {
                txtStatus.Text = "Sắp diễn ra";
                btnBaoNghi.Enabled = true; // Cho phép báo nghỉ
            }

            _selectedInfo = $"Lớp {cboLopHoc.Text} - Ngày {ngayHoc:dd/MM}";
        }

        // --- MỞ FORM XỬ LÝ ---
        private void BtnBaoNghi_Click(object sender, EventArgs e)
        {
            if (_selectedLichHocId == -1) return;

            // Lấy thông tin hiển thị (Ngày, Giờ...) từ các TextBox Detail để truyền vào cho đẹp
            string info = $"{txtDetailDate.Text} - {txtDetailPhong.Text}";

            frmXuLyHocBu f = new frmXuLyHocBu(_selectedLopHocId, _selectedLichHocId, info);
            f.ShowDialog();

            // Sau khi form đóng, reload lại dữ liệu
            LoadData();
        }
    }
}
