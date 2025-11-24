using ClosedXML.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class ucQuanLyGiaoVien : UserControl
    {
        public class GiaoVienDTO
        {
            public int Id { get; set; } // Map với "id"
            public string TenGV { get; set; }
            public int? SoNamKinhNghiem { get; set; }
            public string Sdt { get; set; }
            public DateTime? NgaySinh { get; set; }
            public bool TrangThai { get; set; }
            public string Avatar { get; set; } // Đường dẫn ảnh relative
        }

        // DTO cho Lịch dạy (Cấu trúc lồng nhau trả về từ API GroupBy)
        public class LichDayGroupDTO
        {
            public DateTime NgayDay { get; set; }
            public List<ChiTietLopDTO> DanhSachLop { get; set; }
        }

        public class ChiTietLopDTO
        {
            public int IdLopHoc { get; set; }
            public string TenLopHoc { get; set; }
            public string PhongHoc { get; set; }
            public TimeSpan ThoiGianBatDau { get; set; }
            public TimeSpan ThoiGianKetThuc { get; set; }
        }

        // --- VARIABLES ---
        private List<GiaoVienDTO> _originalList;
        private int _selectedTeacherId = -1;
        private string _currentAvatarPath = null; // Lưu đường dẫn file ảnh mới chọn (nếu có)

        public ucQuanLyGiaoVien()
        {
            InitializeComponent();
            InitializeGrid();
            SetupEvents();
            LoadData();
        }

        private void InitializeGrid()
        {
            dgvGiaoVien.Columns.Clear();
            dgvGiaoVien.AutoGenerateColumns = false;

            // Cột ID (Ẩn)
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });

            // Cột Tên
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenGV", DataPropertyName = "TenGV", HeaderText = "Họ Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // Cột SĐT
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sdt", DataPropertyName = "Sdt", HeaderText = "SĐT", Width = 100 });
        }

        private void SetupEvents()
        {
            btnAddGV.Click += (s, e) =>
            {
                // Mở form thêm mới (Bạn cần tạo form này tương tự form chi tiết hoặc dùng chung logic)
                // Ở đây demo refresh lại
                LoadData();
            };

            txtSearch.TextChanged += (s, e) => FilterList();
            dgvGiaoVien.CellClick += DgvGiaoVien_CellClick;

            btnUploadImg.Click += BtnUploadImg_Click;
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;

            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        // --- KHU VỰC 1: DANH SÁCH (LEFT) ---

        private async void LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl("QLGiaoVien/GetAllTeacher"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        _originalList = JsonConvert.DeserializeObject<List<GiaoVienDTO>>(json);
                        FilterList();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void FilterList()
        {
            if (_originalList == null) return;
            string key = txtSearch.Text.ToLower();
            var list = _originalList.Where(x => x.TenGV.ToLower().Contains(key) || x.Sdt.Contains(key)).ToList();
            dgvGiaoVien.DataSource = list;
        }

        private void DgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy object từ dòng chọn
            var item = (GiaoVienDTO)dgvGiaoVien.Rows[e.RowIndex].DataBoundItem;
            _selectedTeacherId = item.Id;

            // 1. Đổ dữ liệu vào Panel Giữa (Chi tiết)
            txtTenGV.Text = item.TenGV;
            txtSDT.Text = item.Sdt;
            dtpNgaySinh.Value = item.NgaySinh ?? DateTime.Now;
            numKinhNghiem.Value = item.SoNamKinhNghiem ?? 0;

            // Load Ảnh
            if (!string.IsNullOrEmpty(item.Avatar))
            {
                // Giả sử API trả về đường dẫn relative "/image/teacher/abc.jpg"
                // Cần ghép với BaseURL (VD: http://localhost:5000)
                // Bạn cần đảm bảo biến DungChung.ApiBaseUrl chứa domain server
                string fullUrl = DungChung.BaseUrlImage + item.Avatar;
                try { picAvatar.Load(fullUrl); }
                catch { picAvatar.Image = null; } // Nếu lỗi link thì để trống
            }
            else
            {
                picAvatar.Image = null; // Hoặc set ảnh mặc định
            }
            _currentAvatarPath = null; // Reset biến chọn ảnh mới

            // 2. Load dữ liệu vào Panel Phải (Lịch dạy)
            LoadLichDay(_selectedTeacherId);
            btnLuu.Text = "Lưu Thay Đổi";
            btnXoa.Enabled = true;
        }

        // --- KHU VỰC 2: CHI TIẾT & UPDATE (MIDDLE) ---

        private void BtnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(op.FileName);
                _currentAvatarPath = op.FileName; // Lưu đường dẫn để tý gửi lên server
            }
        }

        
        

        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == -1) return;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.DeleteAsync(DungChung.getUrl($"QLGiaoVien/deleteTeacher/{_selectedTeacherId}"));
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Đã xóa thành công.");
                            LoadData();
                            // Reset form
                            txtTenGV.Clear(); txtSDT.Clear(); picAvatar.Image = null;
                            _selectedTeacherId = -1;
                            treeLichDay.Nodes.Clear();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // --- KHU VỰC 3: LỊCH DẠY (RIGHT) ---

        private async void LoadLichDay(int giaoVienId)
        {
            treeLichDay.Nodes.Clear();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl($"QLGiaoVien/GetLichDay/{giaoVienId}"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var lichDayData = JsonConvert.DeserializeObject<List<LichDayGroupDTO>>(json);

                        // Populate TreeView
                        foreach (var ngay in lichDayData)
                        {
                            // Tạo Node cha: Ngày tháng
                            TreeNode dayNode = new TreeNode($"Ngày {ngay.NgayDay.ToString("dd/MM/yyyy")}");
                            dayNode.NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);
                            dayNode.ForeColor = Color.DarkBlue;

                            // Tạo Node con: Các lớp trong ngày
                            foreach (var lop in ngay.DanhSachLop)
                            {
                                string timeInfo = $"{lop.ThoiGianBatDau.ToString(@"hh\:mm")} - {lop.ThoiGianKetThuc.ToString(@"hh\:mm")}";
                                string content = $"{timeInfo} | {lop.TenLopHoc} ({lop.PhongHoc})";
                                dayNode.Nodes.Add(content);
                            }

                            treeLichDay.Nodes.Add(dayNode);
                        }
                        treeLichDay.ExpandAll(); // Mở rộng hết để xem
                    }
                }
            }
            catch { /* Xử lý lỗi thầm lặng hoặc log */ }
        }

        private async void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == -1 || treeLichDay.Nodes.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên có lịch dạy để xuất Excel.");
                return;
            }

            // Gọi lại API lấy dữ liệu (hoặc lưu biến toàn cục khi LoadLichDay để tái sử dụng)
            // Ở đây gọi lại cho chắc chắn dữ liệu mới nhất
            try
            {
                List<LichDayGroupDTO> dataExport = null;
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl($"QLGiaoVien/GetLichDay/{_selectedTeacherId}"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        dataExport = JsonConvert.DeserializeObject<List<LichDayGroupDTO>>(json);
                    }
                }

                if (dataExport == null || dataExport.Count == 0) return;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = $"LichDay_{txtTenGV.Text}_{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add("Lịch Dạy");

                        // Header
                        ws.Cell(1, 1).Value = "Ngày Dạy";
                        ws.Cell(1, 2).Value = "Giờ Bắt Đầu";
                        ws.Cell(1, 3).Value = "Giờ Kết Thúc";
                        ws.Cell(1, 4).Value = "Tên Lớp";
                        ws.Cell(1, 5).Value = "Phòng Học";

                        // Style Header
                        var rngHead = ws.Range("A1:E1");
                        rngHead.Style.Font.Bold = true;
                        rngHead.Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                        rngHead.Style.Font.FontColor = XLColor.White;

                        int row = 2;
                        foreach (var group in dataExport)
                        {
                            foreach (var lop in group.DanhSachLop)
                            {
                                ws.Cell(row, 1).Value = group.NgayDay;
                                ws.Cell(row, 2).Value = lop.ThoiGianBatDau.ToString(@"hh\:mm");
                                ws.Cell(row, 3).Value = lop.ThoiGianKetThuc.ToString(@"hh\:mm");
                                ws.Cell(row, 4).Value = lop.TenLopHoc;
                                ws.Cell(row, 5).Value = lop.PhongHoc;
                                row++;
                            }
                        }

                        ws.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất Excel thành công!");
                        //System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xuất Excel: " + ex.Message); }
        }
        private void ResetForm()
        {
            _selectedTeacherId = -1;
            _currentAvatarPath = null;

            txtTenGV.Clear();
            txtSDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            numKinhNghiem.Value = 0;
            picAvatar.Image = null; // Hoặc ảnh mặc định

            btnLuu.Text = "Thêm Mới"; // Đổi text nút
            btnXoa.Enabled = false;   // Ẩn nút xóa khi đang thêm mới

            treeLichDay.Nodes.Clear(); // Xóa lịch dạy
            txtTenGV.Focus();
        }
        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // Validate chung
            if (string.IsNullOrWhiteSpace(txtTenGV.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Tên và SĐT.");
                return;
            }

            // Chuẩn bị dữ liệu Multipart
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StringContent(txtTenGV.Text), "TenGv");
                content.Add(new StringContent(txtSDT.Text), "Sdt");
                content.Add(new StringContent(dtpNgaySinh.Value.ToString("yyyy-MM-dd")), "NgaySinh");
                content.Add(new StringContent(numKinhNghiem.Value.ToString()), "SoNamKinhNghiem");

                if (_currentAvatarPath != null)
                {
                    var fileStream = File.OpenRead(_currentAvatarPath);
                    var fileContent = new StreamContent(fileStream);
                    fileContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                    content.Add(fileContent, "Avatar", Path.GetFileName(_currentAvatarPath));
                }

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response;

                        // LOGIC QUAN TRỌNG: Kiểm tra xem là THÊM hay SỬA
                        if (_selectedTeacherId == -1)
                        {
                            // --- THÊM MỚI ---
                            response = await client.PostAsync(DungChung.getUrl("QLGiaoVien/AddTeacher"), content);
                        }
                        else
                        {
                            // --- CẬP NHẬT ---
                            response = await client.PutAsync(DungChung.getUrl($"QLGiaoVien/updateTeacher/{_selectedTeacherId}"), content);
                        }

                        // Xử lý kết quả chung
                        if (response.IsSuccessStatusCode)
                        {
                            string action = (_selectedTeacherId == -1) ? "Thêm mới" : "Cập nhật";
                            MessageBox.Show($"{action} thành công!");

                            LoadData(); // Reload danh sách bên trái
                            ResetForm(); // Reset để sẵn sàng thêm người tiếp theo
                        }
                        else
                        {
                            MessageBox.Show("Thất bại: " + await response.Content.ReadAsStringAsync());
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
    }
}
