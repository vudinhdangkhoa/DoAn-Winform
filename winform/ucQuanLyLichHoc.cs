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
        // DTO Classes
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
            public List<GiaoVienDTO> GiaoVien { get; set; }
            public DateTime NgayKhaiGiang { get; set; }
        }

        public class GiaoVienDTO
        {
            public int IdGiaoVien { get; set; }
            public string TenGiaoVien { get; set; }
        }

        public class LichHocDTO
        {
            public int IdLichHoc { get; set; }
            public DateTime NgayHoc { get; set; }
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
        private int _selectedLichHocId = -1;
        private int _selectedLopHocId = -1;
        private string _selectedInfo = "";
        private List<LichHocDTO> _currentLichHocList = new List<LichHocDTO>();
        private bool _isDateFilterActive = false;
        private bool _isInitializing = true;

        public ucQuanLyLichHoc()
        {
            InitializeComponent();
            InitializeGrid();

            // Set giá trị mặc định TRƯỚC KHI gán event
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today.AddMonths(1);

            // SAU ĐÓ mới gán event
            dtpFrom.ValueChanged += DtpFrom_ValueChanged;
            dtpTo.ValueChanged += DtpTo_ValueChanged;

            // Gán các sự kiện khác
            this.Load += UcQuanLyLichHoc_Load;
            cboKhoaHoc.SelectedIndexChanged += CboKhoaHoc_SelectedIndexChanged;
            cboLopHoc.SelectedIndexChanged += CboLopHoc_SelectedIndexChanged;
            dgvLichHoc.CellClick += DgvLichHoc_CellClick;
            btnBaoNghi.Click += BtnBaoNghi_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnResetFilter.Click += BtnResetFilter_Click;
        }

        private async void UcQuanLyLichHoc_Load(object sender, EventArgs e)
        {
            await LoadData();
            _isInitializing = false;
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;

            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show(this, "Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFrom.Value = dtpTo.Value;
                return;
            }

            _isDateFilterActive = true;
            FilterByDate();
        }

        private void DtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;

            if (dtpTo.Value < dtpFrom.Value)
            {
                MessageBox.Show(this, "Ngày kết thúc không được nhỏ hơn ngày bắt đầu!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTo.Value = dtpFrom.Value;
                return;
            }

            _isDateFilterActive = true;
            FilterByDate();
        }

        private void InitializeGrid()
        {
            dgvLichHoc.AutoGenerateColumns = false;
            dgvLichHoc.Columns.Clear();

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT",
                Width = 60,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
                }
            });

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdLichHoc",
                DataPropertyName = "IdLichHoc",
                Visible = false
            });

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayHoc",
                HeaderText = "Ngày Học",
                DataPropertyName = "NgayHoc",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 130
            });

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CaHoc",
                HeaderText = "Ca Học",
                Width = 150
            });

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhong",
                HeaderText = "Phòng",
                Width = 120
            });

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GiaoVien",
                HeaderText = "Giáo Viên",
                Width = 200
            });

            dgvLichHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                HeaderText = "Trạng Thái",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold)
                }
            });

            dgvLichHoc.RowTemplate.Height = 45;
            dgvLichHoc.AllowUserToResizeRows = false;
            dgvLichHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichHoc.MultiSelect = false;
            dgvLichHoc.EnableHeadersVisualStyles = false;
        }

        private async Task LoadData()
        {
            try
            {
                btnRefresh.Enabled = false;
                btnRefresh.Text = "⏳ Đang tải...";

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl("QLLichHoc/GetAllKhoaLopLichHoc"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        _originalData = JsonConvert.DeserializeObject<List<KhoaHocDTO>>(json);

                        cboKhoaHoc.DataSource = _originalData;
                        cboKhoaHoc.DisplayMember = "TenKhoaHoc";
                        cboKhoaHoc.ValueMember = "IdKhoaHoc";
                        cboKhoaHoc.SelectedIndex = -1;
                    }
                }

                btnRefresh.Text = "🔄 Tải lại";
                btnRefresh.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefresh.Text = "🔄 Tải lại";
                btnRefresh.Enabled = true;
            }
        }

        private void CboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLopHoc.DataSource = null;
            dgvLichHoc.Rows.Clear();
            ClearDetailPanel();
            _isDateFilterActive = false;

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
            ClearDetailPanel();

            if (cboLopHoc.SelectedIndex != -1)
            {
                var selectedLop = (LopHocDTO)cboLopHoc.SelectedItem;
                _selectedLopHocId = selectedLop.IdLopHoc;
                _currentLichHocList = selectedLop.LichHocs;

                if (!_isDateFilterActive)
                {
                    DisplayAllLichHoc();
                }
                else
                {
                    FilterByDate();
                }
            }
        }

        private void DisplayAllLichHoc()
        {
            if (cboLopHoc.SelectedIndex == -1) return;

            dgvLichHoc.Rows.Clear();

            var selectedLop = (LopHocDTO)cboLopHoc.SelectedItem;
            string tenGVs = selectedLop.GiaoVien != null && selectedLop.GiaoVien.Count > 0
                ? string.Join(", ", selectedLop.GiaoVien.Select(g => g.TenGiaoVien))
                : "Chưa phân công";

            var allLichHoc = _currentLichHocList
                .OrderBy(l => l.NgayHoc)
                .ThenBy(l => l.ThoiGianBatDau)
                .ToList();

            int stt = 1;
            foreach (var lich in allLichHoc)
            {
                AddRowToGrid(lich, stt++, tenGVs);
            }

            if (allLichHoc.Count > 0)
            {
                var ngaySomNhat = allLichHoc.Min(l => l.NgayHoc);
                var ngayMuonNhat = allLichHoc.Max(l => l.NgayHoc);
                lblKetQua.Text = $"Tổng số: {allLichHoc.Count} buổi học ({ngaySomNhat:dd/MM/yyyy} - {ngayMuonNhat:dd/MM/yyyy})";
            }
            else
            {
                lblKetQua.Text = $"Tổng số: 0 buổi học";
            }

            // Scroll về dòng đầu tiên
            if (dgvLichHoc.Rows.Count > 0)
            {
                dgvLichHoc.FirstDisplayedScrollingRowIndex = 0;
                dgvLichHoc.ClearSelection();
            }
        }

        private void FilterByDate()
        {
            if (cboLopHoc.SelectedIndex == -1) return;

            dgvLichHoc.Rows.Clear();

            var selectedLop = (LopHocDTO)cboLopHoc.SelectedItem;
            string tenGVs = selectedLop.GiaoVien != null && selectedLop.GiaoVien.Count > 0
                ? string.Join(", ", selectedLop.GiaoVien.Select(g => g.TenGiaoVien))
                : "Chưa phân công";

            var filteredList = _currentLichHocList
                .Where(l => l.NgayHoc.Date >= dtpFrom.Value.Date
                         && l.NgayHoc.Date <= dtpTo.Value.Date)
                .OrderBy(l => l.NgayHoc)
                .ThenBy(l => l.ThoiGianBatDau)
                .ToList();

            int stt = 1;
            foreach (var lich in filteredList)
            {
                AddRowToGrid(lich, stt++, tenGVs);
            }

            lblKetQua.Text = $"Tìm thấy: {filteredList.Count} buổi học ({dtpFrom.Value:dd/MM/yyyy} - {dtpTo.Value:dd/MM/yyyy})";
        }

        private void AddRowToGrid(LichHocDTO lich, int stt, string tenGVs)
        {
            string caHoc = $"{lich.ThoiGianBatDau:hh\\:mm} - {lich.ThoiGianKetThuc:hh\\:mm}";
            string phong = lich.PhongHoc != null ? lich.PhongHoc.TenPhong : "Chưa xếp";
            string trangThai = lich.NgayHoc.Date < DateTime.Today ? "✓ Đã kết thúc"
                : lich.NgayHoc.Date == DateTime.Today ? "● Đang diễn ra"
                : "○ Sắp diễn ra";

            int index = dgvLichHoc.Rows.Add();
            var row = dgvLichHoc.Rows[index];

            row.Cells["STT"].Value = stt;
            row.Cells["IdLichHoc"].Value = lich.IdLichHoc;
            row.Cells["NgayHoc"].Value = lich.NgayHoc;
            row.Cells["CaHoc"].Value = caHoc;
            row.Cells["TenPhong"].Value = phong;
            row.Cells["GiaoVien"].Value = tenGVs;
            row.Cells["TrangThai"].Value = trangThai;

            if (lich.NgayHoc.Date < DateTime.Today)
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(127, 140, 141);
                row.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                row.Cells["TrangThai"].Style.ForeColor = Color.FromArgb(149, 165, 166);
            }
            else if (lich.NgayHoc.Date == DateTime.Today)
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(39, 174, 96);
                row.DefaultCellStyle.Font = new Font(dgvLichHoc.Font, FontStyle.Bold);
                row.DefaultCellStyle.BackColor = Color.FromArgb(236, 252, 243);
                row.Cells["TrangThai"].Style.ForeColor = Color.FromArgb(46, 204, 113);
            }
            else
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
                row.Cells["TrangThai"].Style.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            _isDateFilterActive = false;
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today.AddMonths(1);

            if (cboLopHoc.SelectedIndex != -1)
            {
                DisplayAllLichHoc();
            }
        }

        private void DgvLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvLichHoc.Rows[e.RowIndex];

            _selectedLichHocId = Convert.ToInt32(row.Cells["IdLichHoc"].Value);
            DateTime ngayHoc = Convert.ToDateTime(row.Cells["NgayHoc"].Value);
            string caHoc = row.Cells["CaHoc"].Value.ToString();
            string phong = row.Cells["TenPhong"].Value.ToString();
            string gv = row.Cells["GiaoVien"].Value.ToString();

            txtNgayGio.Text = $"{ngayHoc:dd/MM/yyyy} | {caHoc}";
            txtPhong.Text = phong;
            txtGiaoVien.Text = gv;

            if (ngayHoc.Date < DateTime.Today)
            {
                lblTrangThai.Text = "✓ Đã kết thúc";
                pnlStatusBadge.FillColor = Color.FromArgb(149, 165, 166);
                btnBaoNghi.Enabled = false;
            }
            else if (ngayHoc.Date == DateTime.Today)
            {
                lblTrangThai.Text = "● Đang diễn ra";
                pnlStatusBadge.FillColor = Color.FromArgb(46, 204, 113);
                btnBaoNghi.Enabled = true;
            }
            else
            {
                lblTrangThai.Text = "○ Sắp diễn ra";
                pnlStatusBadge.FillColor = Color.FromArgb(52, 152, 219);
                btnBaoNghi.Enabled = true;
            }

            _selectedInfo = $"Lớp {cboLopHoc.Text} - Ngày {ngayHoc:dd/MM/yyyy}";
        }

        private void ClearDetailPanel()
        {
            txtNgayGio.Clear();
            txtPhong.Clear();
            txtGiaoVien.Clear();
            lblTrangThai.Text = "Chưa chọn buổi học";
            pnlStatusBadge.FillColor = Color.FromArgb(189, 195, 199);
            btnBaoNghi.Enabled = false;
        }

        private async void BtnBaoNghi_Click(object sender, EventArgs e)
        {
            if (_selectedLichHocId == -1)
            {
                MessageBox.Show("Vui lòng chọn buổi học cần báo nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ngày khai giảng từ lớp đã chọn
            DateTime ngayKhaiGiang = DateTime.MinValue;
            if (cboLopHoc.SelectedIndex != -1)
            {
                var selectedLop = (LopHocDTO)cboLopHoc.SelectedItem;
                ngayKhaiGiang = selectedLop.NgayKhaiGiang;
            }

            string info = $"{txtNgayGio.Text} - {txtPhong.Text}";

            // TRUYỀN THÊM THAM SỐ ngayKhaiGiang
            frmXuLyHocBu f = new frmXuLyHocBu(_selectedLopHocId, _selectedLichHocId, ngayKhaiGiang, info);
            f.ShowDialog();

            await LoadData();

            if (_selectedLopHocId > 0)
            {
                cboLopHoc.SelectedValue = _selectedLopHocId;
            }
        }

        private void btnBaoNghi_Click_1(object sender, EventArgs e)
        {

        }
    }
}