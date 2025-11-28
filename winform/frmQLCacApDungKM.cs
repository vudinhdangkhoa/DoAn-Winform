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
    public partial class frmQLCacApDungKM : Form
    {
        public class KhoaHocApDungDTO
        {
            public int Id { get; set; } // ID của bảng trung gian
            public int IdKhoaHoc { get; set; }
            public string TenKhoaHoc { get; set; }
            public int IdKhuyenMai { get; set; }
            public string TenKhuyenMai { get; set; }
            public double PhanTramKhuyenMai { get; set; }
            public DateTime NgayBatDau { get; set; }
            public DateTime NgayKetThuc { get; set; }
            public int SoLuong { get; set; }
        }

        public class HoaCuApDungDTO
        {
            public int Id { get; set; } // ID của bảng trung gian
            public int IdHocCu { get; set; }
            public string TenHocCu { get; set; }
            public int IdKhuyenMai { get; set; }
            public string TenKhuyenMai { get; set; }
            public double PhanTramKhuyenMai { get; set; }
            public DateTime NgayBatDau { get; set; }
            public DateTime NgayKetThuc { get; set; }
            public int SoLuong { get; set; }
        }


        private int _currentSelectedId = -1;
        private string _currentType = "";
        private void SetupDateTimePickerConstraints()
        {
            // Đặt ngày tối thiểu là hôm nay (không được chọn ngày trong quá khứ)
            dtpEndDate.MinDate = DateTime.Now.Date;

            // Đặt giá trị mặc định
            dtpEndDate.Value = DateTime.Now.Date;

            // Gắn sự kiện kiểm tra khi thay đổi giá trị
            dtpEndDate.ValueChanged += DtpEndDate_ValueChanged;
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra ngày kết thúc không được nhỏ hơn ngày hiện tại
            if (dtpEndDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày hiện tại!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Value = DateTime.Now.Date;
            }
        }
        public frmQLCacApDungKM()
        {
            InitializeComponent();
            SetupEvents();
            InitializeGrids();
            LoadData();
            SetupDateTimePickerConstraints();
        }

        private void InitializeGrids()
        {
            // Setup cột cho Grid Khóa Học
            dgvKhoaHoc.Columns.Add("Id", "ID");
            dgvKhoaHoc.Columns["Id"].Visible = false;
            dgvKhoaHoc.Columns.Add("TenKhoaHoc", "Tên Khóa Học");
            dgvKhoaHoc.Columns.Add("TenKhuyenMai", "Chương Trình KM");
            dgvKhoaHoc.Columns.Add("PhanTram", "% Giảm");
            dgvKhoaHoc.Columns.Add("NgayKetThuc", "Kết Thúc");
            dgvKhoaHoc.Columns.Add("SoLuong", "Số Lượng");

            // Setup cột cho Grid Họa Cụ
            dgvHoaCu.Columns.Add("Id", "ID");
            dgvHoaCu.Columns["Id"].Visible = false;
            dgvHoaCu.Columns.Add("TenHoaCu", "Tên Họa Cụ");
            dgvHoaCu.Columns.Add("TenKhuyenMai", "Chương Trình KM");
            dgvHoaCu.Columns.Add("PhanTram", "% Giảm");
            dgvHoaCu.Columns.Add("NgayKetThuc", "Kết Thúc");
            dgvHoaCu.Columns.Add("SoLuong", "Số Lượng");
        }

        private void SetupEvents()
        {
            dgvKhoaHoc.CellClick += (s, e) => LoadToEditPanel(dgvKhoaHoc, "KhoaHoc", e.RowIndex);
            dgvHoaCu.CellClick += (s, e) => LoadToEditPanel(dgvHoaCu, "HoaCu", e.RowIndex);
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private async void LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Gọi API Get
                    var response = await client.GetAsync(DungChung.getUrl("QLKhuyenMai/GetCacApDungKhuyenMai"));

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<dynamic>(json);

                        // 1. Load Tab Khóa Học
                        var listKH = JsonConvert.DeserializeObject<List<KhoaHocApDungDTO>>(data.khoaHocApDungKhuyenMais.ToString());
                        dgvKhoaHoc.Rows.Clear();
                        foreach (var item in listKH)
                        {
                            dgvKhoaHoc.Rows.Add(item.Id, item.TenKhoaHoc, item.TenKhuyenMai,
                                $"{item.PhanTramKhuyenMai * 100}%",
                                item.NgayKetThuc.ToString("dd/MM/yyyy"), item.SoLuong);
                        }

                        // 2. Load Tab Họa Cụ
                        var listHC = JsonConvert.DeserializeObject<List<HoaCuApDungDTO>>(data.hoaCuApDungKhuyenMais.ToString());
                        dgvHoaCu.Rows.Clear();
                        foreach (var item in listHC)
                        {
                            dgvHoaCu.Rows.Add(item.Id, item.TenHocCu, item.TenKhuyenMai,
                                $"{item.PhanTramKhuyenMai * 100}%",
                                item.NgayKetThuc.ToString("dd/MM/yyyy"), item.SoLuong);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadToEditPanel(DataGridView dgv, string type, int rowIndex)
        {
            if (rowIndex < 0) return;

            _currentType = type;
            _currentSelectedId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["Id"].Value);

            // Đổ dữ liệu vào Panel chỉnh sửa
            txtTenItem.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString(); // Tên KH hoặc HC
            txtTenKM.Text = dgv.Rows[rowIndex].Cells["TenKhuyenMai"].Value.ToString();

            // Parse ngày tháng từ Grid
            string dateStr = dgv.Rows[rowIndex].Cells["NgayKetThuc"].Value.ToString();
            if (DateTime.TryParseExact(dateStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime endDate))
            {
                dtpEndDate.Value = endDate;
            }

            numSoLuong.Value = Convert.ToDecimal(dgv.Rows[rowIndex].Cells["SoLuong"].Value);
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentSelectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn mục cần sửa trước.");
                return;
            }

            // Kiểm tra ngày kết thúc
            if (dtpEndDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày hiện tại!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo object gửi đi update
            var updateData = new
            {
                id = _currentSelectedId,
                type = _currentType,
                ngayKetThuc = dtpEndDate.Value,
                soLuong = (int)numSoLuong.Value
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(updateData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync(DungChung.getUrl("QLKhuyenMai/UpdateApDung"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadData();
                        _currentSelectedId = -1;
                        txtTenItem.Clear();
                        txtTenKM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 1. Reset biến logic quan trọng
            _currentSelectedId = -1;
            _currentType = "";

            // 2. Xóa thông tin hiển thị
            txtTenItem.Clear();
            txtTenKM.Clear();

            // 3. Reset các control nhập liệu về mặc định
            numSoLuong.Value = 0;
            dtpEndDate.Value = DateTime.Now.Date;
        }
    }
}
