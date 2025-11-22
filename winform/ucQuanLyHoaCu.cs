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
    public partial class ucQuanLyHoaCu : UserControl
    {
        int userId;
        string username;

        private List<ViewHocCuDTO> _originalList = new List<ViewHocCuDTO>();

        public ucQuanLyHoaCu(int userId,string username)
        {
            InitializeComponent();
            InitializeGrid();
            SetupEvents();
            LoadData(); // Load khi khởi tạo
            this.userId = userId;
            this.username = username;
        }

        private void InitializeGrid()
        {
            dgvHocCu.Columns.Clear();
            dgvHocCu.Columns.Add("IdHocCu", "ID");
            dgvHocCu.Columns["IdHocCu"].Visible = false;

            dgvHocCu.Columns.Add("TenHocCu", "Tên Họa Cụ");
            dgvHocCu.Columns.Add("TenLoai", "Loại"); // Cần join hoặc lấy từ ID nếu có
            dgvHocCu.Columns.Add("GiaBan", "Giá Bán");
            dgvHocCu.Columns["GiaBan"].DefaultCellStyle.Format = "N0";

            dgvHocCu.Columns.Add("SoLuong", "Tồn Kho");
           
        }

        private void SetupEvents()
        {
            // Sự kiện Search
            txtSearch.TextChanged += (s, e) => FilterData();
            cboLocLoai.SelectedIndexChanged += (s, e) => FilterData();
            btnRefresh.Click += (s, e) => LoadData();

            // Sự kiện mở 4 Form con
            btnAddHocCu.Click += (s, e) => OpenForm(new frmAddHoaCu());
            btnAddLoai.Click += (s, e) => OpenForm(new frmAddLoaiHocCu());
            btnNhapKho.Click += (s, e) => OpenForm(new frmNhapKhoHoaCu(userId,username));
            btnBanHang.Click += (s, e) => OpenForm(new frmBanHangHoaCu(userId));
        }

        // Hàm tiện ích mở form và reload data khi đóng
        private void OpenForm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            LoadData(); // Refresh lại dữ liệu sau khi form con đóng (có thể đã thêm/sửa/xóa)
        }

        private async void LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl("QLHocCu/GetAllHocCu"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<dynamic>(json);

                        // 1. Load ComboBox Loại
                        var listLoai = JsonConvert.DeserializeObject<List<ViewLoaiHocCuDTO>>(data.loaiHocCus.ToString());
                        cboLocLoai.DataSource = listLoai;
                        cboLocLoai.DisplayMember = "TenLoai";
                        cboLocLoai.ValueMember = "IdLoaiHocCu";
                        cboLocLoai.SelectedIndex = -1; // Mặc định không chọn

                        // 2. Load Grid Họa Cụ
                        _originalList = JsonConvert.DeserializeObject<List<ViewHocCuDTO>>(data.hocCus.ToString());
                        FilterData(); // Hiển thị lên lưới
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
            var query = _originalList.AsQueryable();

            // Filter Text
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string keyword = txtSearch.Text.ToLower();
                query = query.Where(x => x.tenHocCu.ToLower().Contains(keyword));
            }

            // Filter ComboBox
            if (cboLocLoai.SelectedIndex != -1 && cboLocLoai.SelectedValue is int idLoai)
            {
                query = query.Where(x => x.idLoaiHocCu == idLoai);
            }

            var resultList = query.ToList();

            dgvHocCu.Rows.Clear();
            foreach (var item in resultList)
            {
                // Lấy tên loại từ combobox (hoặc map từ trước)
                string tenLoai = "";
                // Logic map tên loại ở đây nếu DTO Họa Cụ không có sẵn Tên Loại
                // (Trong API GetAllHocCu của bạn trả về IDLoaiHocCu, ta có thể map thủ công hoặc sửa API trả về Tên Loại)

                dgvHocCu.Rows.Add(item.idHocCu, item.tenHocCu, item.tenLoai, item.giaBan, item.soLuong);
            }
        }


    }
}
