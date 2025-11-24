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
    public partial class ucKhoaHoc : UserControl
    {
        public class KhoaHocViewDTO
        {
            public int IdKhoaHoc { get; set; }
            public string TenKhoaHoc { get; set; }
            public string MoTa { get; set; }
            public double HocPhi { get; set; }
            public int SoLuongBuoi { get; set; }
            public double GiamGia { get; set; } // Số tiền giảm (nếu có logic KM)
            public string HinhAnh { get; set; } // Tên file ảnh
            public int? IdChuyenMon { get; set; } // Cần bổ sung vào API nếu chưa có để lọc

            // Thuộc tính phụ để hiển thị trên Grid (nếu cần)
            public string HocPhiHienThi => HocPhi.ToString("N0");
        }

        public class ChuyenMonDTO
        {
            public int IdChuyenMon { get; set; }
            public string TenChuyenMon { get; set; }
        }

        // --- VARIABLES ---
        private List<KhoaHocViewDTO> _originalList; // Danh sách gốc từ API
        private List<ChuyenMonDTO> _listChuyenMon;  // Danh sách chuyên môn để map tên

        public ucKhoaHoc()
        {
            InitializeComponent();
            InitializeGrid();
            SetupEvents();

            // Load dữ liệu khi khởi tạo
            this.Load += async (s, e) => await LoadAllData();
        }

        private void InitializeGrid()
        {
            dgvKhoaHoc.AutoGenerateColumns = false;
            dgvKhoaHoc.Columns.Clear();

            // 1. Cột ID (Ẩn)
            dgvKhoaHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdKhoaHoc", DataPropertyName = "IdKhoaHoc", Visible = false });

            // 2. Cột Tên Khóa Học
            dgvKhoaHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenKhoaHoc",
                DataPropertyName = "TenKhoaHoc",
                HeaderText = "Tên Khóa Học",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // 3. Cột Học Phí
            var colGia = new DataGridViewTextBoxColumn
            {
                Name = "HocPhi",
                DataPropertyName = "HocPhi",
                HeaderText = "Học Phí (VNĐ)",
                Width = 120
            };
            colGia.DefaultCellStyle.Format = "N0";
            colGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKhoaHoc.Columns.Add(colGia);

            // 4. Cột Số Buổi
            dgvKhoaHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuongBuoi",
                DataPropertyName = "SoLuongBuoi",
                HeaderText = "Số Buổi",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // 5. Cột Sửa (Button Image hoặc Text)
            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Thao tác";
            btnEdit.Text = "Chi tiết";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 80;
            dgvKhoaHoc.Columns.Add(btnEdit);
        }

        private void SetupEvents()
        {
            // Search & Filter
            txtSearch.TextChanged += (s, e) => FilterData();
            cboChuyenMon.SelectedIndexChanged += (s, e) => FilterData();

            // Buttons
            btnRefresh.Click += async (s, e) => await LoadAllData();
            btnThem.Click += BtnThem_Click;

            // Grid Actions
            dgvKhoaHoc.CellClick += DgvKhoaHoc_CellClick;

           
        }

        // --- LOAD DATA ---
        private async Task LoadAllData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 1. Load Chuyên Môn (Để đổ vào ComboBox)
                    var resCM = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllChuyenMon"));
                    if (resCM.IsSuccessStatusCode)
                    {
                        var jsonCM = await resCM.Content.ReadAsStringAsync();
                        _listChuyenMon = JsonConvert.DeserializeObject<List<ChuyenMonDTO>>(jsonCM);

                        // Gán datasource cho combo
                        cboChuyenMon.DataSource = _listChuyenMon;
                        cboChuyenMon.DisplayMember = "TenChuyenMon";
                        cboChuyenMon.ValueMember = "IdChuyenMon";
                        cboChuyenMon.SelectedIndex = -1; // Mặc định không chọn gì (để hiện tất cả)
                    }

                    // 2. Load Khóa Học
                    var resKH = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllKhoaHoc"));
                    if (resKH.IsSuccessStatusCode)
                    {
                        var jsonKH = await resKH.Content.ReadAsStringAsync();
                        _originalList = JsonConvert.DeserializeObject<List<KhoaHocViewDTO>>(jsonKH);

                        // Hiển thị lên lưới
                        FilterData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void FilterData()
        {
            if (_originalList == null) return;

            var query = _originalList.AsQueryable();

            // 1. Lọc theo tên (Search Text)
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string key = txtSearch.Text.ToLower();
                query = query.Where(x => x.TenKhoaHoc.ToLower().Contains(key));
            }

            // 2. Lọc theo Chuyên môn (ComboBox)
            // Lưu ý: Hiện tại API GetAllKhoaHoc chưa trả về IdChuyenMon ở lớp ngoài cùng
            // Nếu API của bạn trả về IdChuyenMon trong object con hoặc chưa có, bạn cần bổ sung vào API
            // Giả sử bạn ĐÃ CÓ IdChuyenMon trong DTO:
            
            if (cboChuyenMon.SelectedIndex != -1 && cboChuyenMon.SelectedValue is int idCM)
            {
                query = query.Where(x => x.IdChuyenMon == idCM);
            }
            

            dgvKhoaHoc.DataSource = query.ToList();
        }

        // --- ACTIONS ---

        private void BtnThem_Click(object sender, EventArgs e)
        {
            // Mở form chi tiết với ID = -1 (Chế độ Thêm mới)
            frmChiTietKhoaHoc f = new frmChiTietKhoaHoc(-1);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Nếu thêm thành công (Form con trả về OK) -> Reload lại danh sách
                LoadAllData();
            }
        }

        private void DgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào nút "Sửa" (hoặc "Chi tiết")
            if (e.RowIndex >= 0 && dgvKhoaHoc.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                // Lấy ID khóa học
                int idKhoaHoc = Convert.ToInt32(dgvKhoaHoc.Rows[e.RowIndex].Cells["IdKhoaHoc"].Value);

                // Mở form sửa
                frmChiTietKhoaHoc f = new frmChiTietKhoaHoc(idKhoaHoc);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadAllData(); // Reload nếu có sửa đổi
                }
            }
        }

        

        private void btnQLChuyenMon_Click(object sender, EventArgs e)
        {
            frmQLChuyenMon f= new frmQLChuyenMon();
            if(f.ShowDialog() == DialogResult.OK)
            {
                LoadAllData(); // Reload nếu có sửa đổi
            }
        }
    }
}
