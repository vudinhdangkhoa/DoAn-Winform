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
    public partial class ucQuanLyLopHoc : UserControl
    {
        public class LopHocViewDTO
        {
            public int IdLopHoc { get; set; }
            public string TenLopHoc { get; set; }
            public int IdKhoaHoc { get; set; }
            public string KhoaHoc { get; set; } // Tên khóa học
            public string Phong { get; set; }
            public int SoLuongHv { get; set; }
            public int SoLuongToiDa { get; set; }
            public DateTime NgayKhaiGiang { get; set; }
            public bool DangDienRa { get; set; }

            // List object con để lấy tên GV
            public List<GiaoVienSimpleDTO> GiaoVien { get; set; }
            public string TenGiaoVien => GiaoVien != null && GiaoVien.Count > 0
                                          ? string.Join(", ", GiaoVien.Select(g => g.TenGV))
                                          : "Chưa có";
        }

        public class GiaoVienSimpleDTO { public string TenGV { get; set; } }
        public class KhoaHocSimpleDTO { public int IdKhoaHoc { get; set; } public string TenKhoaHoc { get; set; } }

        private List<LopHocViewDTO> _originalList;
        private List<KhoaHocSimpleDTO> _listKhoaHoc;

        public ucQuanLyLopHoc()
        {
            InitializeComponent();
            InitializeGrid();
            SetupEvents();

            // Load data khi form hiển thị
            this.Load += async (s, e) => await LoadData();
        }

        private void InitializeGrid()
        {
            dgvLopHoc.AutoGenerateColumns = false;
            dgvLopHoc.Columns.Clear();

            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "IdLopHoc", Visible = false });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ten", DataPropertyName = "TenLopHoc", HeaderText = "Tên Lớp", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "Khoa", DataPropertyName = "KhoaHoc", HeaderText = "Khóa Học", Width = 200 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "GV", DataPropertyName = "TenGiaoVien", HeaderText = "Giảng Viên", Width = 150 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "Phong", DataPropertyName = "Phong", HeaderText = "Phòng", Width = 100 });

            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "SiSo", HeaderText = "Sĩ Số", Width = 80 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayKG", DataPropertyName = "NgayKhaiGiang", HeaderText = "Khai Giảng", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });

            // Custom cột Sĩ Số (HV/Max)
            dgvLopHoc.CellFormatting += (s, e) =>
            {
                if (dgvLopHoc.Columns[e.ColumnIndex].Name == "SiSo" && e.RowIndex >= 0)
                {
                    var item = (LopHocViewDTO)dgvLopHoc.Rows[e.RowIndex].DataBoundItem;
                    if (item != null)
                        e.Value = $"{item.SoLuongHv}/{item.SoLuongToiDa}";
                }
            };

            // Nút Chi tiết
            var btnDetail = new DataGridViewButtonColumn();
            btnDetail.Name = "btnDetail";
            btnDetail.HeaderText = "";
            btnDetail.Text = "Chi tiết";
            btnDetail.UseColumnTextForButtonValue = true;
            btnDetail.Width = 80;
            dgvLopHoc.Columns.Add(btnDetail);
        }

        private void SetupEvents()
        {
            btnRefresh.Click += async (s, e) => await LoadData();
            btnThemLop.Click += BtnThemLop_Click;
            txtSearch.TextChanged += (s, e) => FilterData();
            cboLocKhoaHoc.SelectedIndexChanged += (s, e) => FilterData();
            dgvLopHoc.CellClick += DgvLopHoc_CellClick;
        }

        private async Task LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 1. Load Khoa Hoc for ComboBox
                    var resKH = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllKhoaHoc"));
                    if (resKH.IsSuccessStatusCode)
                    {
                        var jsonKH = await resKH.Content.ReadAsStringAsync();
                        _listKhoaHoc = JsonConvert.DeserializeObject<List<KhoaHocSimpleDTO>>(jsonKH);

                        // Lưu trạng thái chọn cũ nếu có
                        var oldSelection = cboLocKhoaHoc.SelectedValue;

                        cboLocKhoaHoc.DataSource = _listKhoaHoc;
                        cboLocKhoaHoc.DisplayMember = "TenKhoaHoc";
                        cboLocKhoaHoc.ValueMember = "IdKhoaHoc";

                        // Restore selection or reset
                        if (oldSelection != null) cboLocKhoaHoc.SelectedValue = oldSelection;
                        else cboLocKhoaHoc.SelectedIndex = -1;
                    }

                    // 2. Load Lop Hoc
                    var resLH = await client.GetAsync(DungChung.getUrl("QLLopHoc/GetAllLopHoc"));
                    if (resLH.IsSuccessStatusCode)
                    {
                        var jsonLH = await resLH.Content.ReadAsStringAsync();
                        _originalList = JsonConvert.DeserializeObject<List<LopHocViewDTO>>(jsonLH);
                        FilterData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void FilterData()
        {
            if (_originalList == null) return;
            var query = _originalList.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query = query.Where(x => x.TenLopHoc.ToLower().Contains(txtSearch.Text.ToLower()));
            }

            if (cboLocKhoaHoc.SelectedIndex != -1 && cboLocKhoaHoc.SelectedValue is int idKhoa)
            {
                query = query.Where(x => x.IdKhoaHoc == idKhoa);
            }

            dgvLopHoc.DataSource = query.ToList();
        }

        private void BtnThemLop_Click(object sender, EventArgs e)
        {
            // Mở form thêm mới (ID = -1)
            frmChiTietLopHoc f = new frmChiTietLopHoc(-1);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Nếu thêm thành công -> Reload dữ liệu
                _ = LoadData(); // Gọi bất đồng bộ mà không cần await ở event handler void
            }
        }

        private void DgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click vào nút Chi tiết
            if (e.RowIndex >= 0 && dgvLopHoc.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                int id = Convert.ToInt32(dgvLopHoc.Rows[e.RowIndex].Cells["Id"].Value);

                // Mở form chi tiết (ID > 0)
                frmChiTietLopHoc f = new frmChiTietLopHoc(id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _ = LoadData(); // Reload dữ liệu sau khi sửa
                }
            }
        }
    }
}
