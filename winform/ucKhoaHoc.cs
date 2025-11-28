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
            // GiamGia giờ là giá trị tiền (VND)
            public double GiamGia { get; set; }
            public string HinhAnh { get; set; }
            public int? IdChuyenMon { get; set; }

            // Thuộc tính phụ để hiển thị trên Grid (Học phí)
            public string HocPhiHienThi => HocPhi.ToString("N0");

            // ĐÃ SỬA: Hiển thị Giảm Giá dưới dạng tiền (VND)
            public string GiamGiaHienThi => GiamGia.ToString("N0");
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

            // 1. Cột ID (HIỂN THỊ)
            dgvKhoaHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdKhoaHoc",
                DataPropertyName = "IdKhoaHoc",
                HeaderText = "ID",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // 2. Cột Tên Khóa Học
            dgvKhoaHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenKhoaHoc",
                DataPropertyName = "TenKhoaHoc",
                HeaderText = "Tên Khóa Học",
                // Giữ AutoSizeMode.Fill để lấp đầy không gian
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // 3. Cột Học Phí
            var colGia = new DataGridViewTextBoxColumn
            {
                Name = "HocPhi",
                DataPropertyName = "HocPhi",
                HeaderText = "Học Phí (VNĐ)",
                Width = 140
            };
            // Định dạng tiền tệ và căn phải
            colGia.DefaultCellStyle.Format = "N0";
            colGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKhoaHoc.Columns.Add(colGia);

            // 4. Cột Giảm Giá (ĐÃ SỬA để hiển thị tiền)
            var colGiamGia = new DataGridViewTextBoxColumn
            {
                Name = "GiamGia",
                DataPropertyName = "GiamGiaHienThi", // Sử dụng GiamGiaHienThi đã sửa
                HeaderText = "Giảm Giá (VNĐ)",
                Width = 120 // Tăng chiều rộng
            };
            colGiamGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải cho giá trị tiền
            dgvKhoaHoc.Columns.Add(colGiamGia);

            // 5. Cột Số Buổi
            dgvKhoaHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuongBuoi",
                DataPropertyName = "SoLuongBuoi",
                HeaderText = "Số Buổi",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // 6. Cột Thao Tác (Button Image hoặc Text)
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
                        // API hiện trả về giá trị tiền giảm
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

            // 1. Lọc theo tên HOẶC ID (Search Text)
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string key = txtSearch.Text.ToLower();
                query = query.Where(x =>
                    x.TenKhoaHoc.ToLower().Contains(key) ||           // Tìm theo tên
                    x.IdKhoaHoc.ToString().Contains(key)              // Tìm theo ID
                );
            }

            // 2. Lọc theo Chuyên môn (ComboBox)
            if (cboChuyenMon.SelectedIndex != -1 && cboChuyenMon.SelectedValue is int idCM)
            {
                query = query.Where(x => x.IdChuyenMon == idCM);
            }

            dgvKhoaHoc.DataSource = query.ToList();
        }

        // --- ACTIONS ---

        private void BtnThem_Click(object sender, EventArgs e)
        {
            //Mở form chi tiết với ID = -1(Chế độ Thêm mới)
            frmChiTietKhoaHoc f = new frmChiTietKhoaHoc(-1);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadAllData();
            }
            //MessageBox.Show("Chức năng thêm khóa học đang được phát triển.");
        }

        private void DgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào nút "Sửa" (hoặc "Chi tiết")
            if (e.RowIndex >= 0 && dgvKhoaHoc.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                // Lấy ID khóa học
                int idKhoaHoc = Convert.ToInt32(dgvKhoaHoc.Rows[e.RowIndex].Cells["IdKhoaHoc"].Value);

                //Mở form sửa
                frmChiTietKhoaHoc f = new frmChiTietKhoaHoc(idKhoaHoc);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadAllData(); // Reload nếu có sửa đổi
                }
                //MessageBox.Show($"Mở chi tiết khóa học ID: {idKhoaHoc}");
            }
        }


        private void btnQLChuyenMon_Click_1(object sender, EventArgs e)
        {
            frmQLChuyenMon f = new frmQLChuyenMon();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadAllData(); // Reload nếu có sửa đổi
            }
        }
    }
}