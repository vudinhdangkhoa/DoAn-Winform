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
            public int Id { get; set; }
            public string TenGV { get; set; }
            public int? SoNamKinhNghiem { get; set; }
            public string Sdt { get; set; }
            public DateTime? NgaySinh { get; set; }
            public bool TrangThai { get; set; }
            public string Avatar { get; set; }
        }

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

        private List<GiaoVienDTO> _originalList;
        private int _selectedTeacherId = -1;
        private string _currentAvatarPath = null;

        public ucQuanLyGiaoVien()
        {
            InitializeComponent();
            InitializeGrid();
            SetupEvents();
            SetupValidation();
            LoadData();
        }

        private void InitializeGrid()
        {
            dgvGiaoVien.Columns.Clear();
            dgvGiaoVien.AutoGenerateColumns = false;

            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "Mã GV", Width = 80 });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenGV", DataPropertyName = "TenGV", HeaderText = "Họ Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sdt", DataPropertyName = "Sdt", HeaderText = "SĐT", Width = 100 });
        }

        private void SetupEvents()
        {
            btnAddGV.Click += (s, e) => { ResetForm(); };
            txtSearch.TextChanged += (s, e) => FilterList();
            dgvGiaoVien.CellClick += DgvGiaoVien_CellClick;
            btnUploadImg.Click += BtnUploadImg_Click;
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        private void SetupValidation()
        {
            // Tên chỉ cho phép chữ và khoảng trắng
            txtTenGV.KeyPress += (s, e) =>
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Tên chỉ được nhập chữ cái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // SĐT chỉ cho phép số
            txtSDT.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Số điện thoại chỉ được nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Kinh nghiệm chỉ cho phép số
            txtKinhNghiem.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Kinh nghiệm chỉ được nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Giới hạn độ dài SĐT
            txtSDT.MaxLength = 10;
        }

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
            string key = txtSearch.Text.ToLower().Trim();
            var list = _originalList.Where(x =>
                x.TenGV.ToLower().Contains(key) ||
                x.Sdt.Contains(key) ||
                x.Id.ToString().Contains(key) // Tìm theo ID
            ).ToList();
            dgvGiaoVien.DataSource = list;
        }

        private void DgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (GiaoVienDTO)dgvGiaoVien.Rows[e.RowIndex].DataBoundItem;
            _selectedTeacherId = item.Id;

            txtMaGV.Text = item.Id.ToString();
            txtTenGV.Text = item.TenGV;
            txtSDT.Text = item.Sdt;
            dtpNgaySinh.Value = item.NgaySinh ?? DateTime.Now;
            txtKinhNghiem.Text = (item.SoNamKinhNghiem ?? 0).ToString();

            if (!string.IsNullOrEmpty(item.Avatar))
            {
                string fullUrl = DungChung.BaseUrlImage + item.Avatar;
                try { picAvatar.Load(fullUrl); }
                catch { picAvatar.Image = null; }
            }
            else
            {
                picAvatar.Image = null;
            }
            _currentAvatarPath = null;

            LoadLichDay(_selectedTeacherId);
            btnLuu.Text = "Cập Nhật";
            btnXoa.Enabled = true;
            txtMaGV.Enabled = false;
        }

        private void BtnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(op.FileName);
                _currentAvatarPath = op.FileName;
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtTenGV.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (txtSDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Kiểm tra tuổi >= 18
            var age = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("Giáo viên phải từ 18 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StringContent(txtTenGV.Text), "TenGv");
                content.Add(new StringContent(txtSDT.Text), "Sdt");
                content.Add(new StringContent(dtpNgaySinh.Value.ToString("yyyy-MM-dd")), "NgaySinh");

                int kinhNghiem = 0;
                int.TryParse(txtKinhNghiem.Text, out kinhNghiem);
                content.Add(new StringContent(kinhNghiem.ToString()), "SoNamKinhNghiem");

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

                        if (_selectedTeacherId == -1)
                        {
                            response = await client.PostAsync(DungChung.getUrl("QLGiaoVien/AddTeacher"), content);
                        }
                        else
                        {
                            response = await client.PutAsync(DungChung.getUrl($"QLGiaoVien/updateTeacher/{_selectedTeacherId}"), content);
                        }

                        if (response.IsSuccessStatusCode)
                        {
                            string action = (_selectedTeacherId == -1) ? "Thêm mới" : "Cập nhật";
                            MessageBox.Show($"{action} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ResetForm();
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

        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == -1) return;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.DeleteAsync(DungChung.getUrl($"QLGiaoVien/deleteTeacher/{_selectedTeacherId}"));
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ResetForm();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private async void LoadLichDay(int giaoVienId)
        {
            treeLichDay.Nodes.Clear();

            // Tùy chỉnh style cho TreeView
            treeLichDay.Font = new Font("Segoe UI", 10);
            treeLichDay.ItemHeight = 35;
            treeLichDay.Indent = 20;
            treeLichDay.ShowLines = false;
            treeLichDay.ShowPlusMinus = false;
            treeLichDay.FullRowSelect = true;
            treeLichDay.BackColor = Color.FromArgb(250, 251, 252);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl($"QLGiaoVien/GetLichDay/{giaoVienId}"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var lichDayData = JsonConvert.DeserializeObject<List<LichDayGroupDTO>>(json);

                        if (lichDayData == null || lichDayData.Count == 0)
                        {
                            TreeNode emptyNode = new TreeNode("Chưa có lịch dạy nào");
                            emptyNode.ForeColor = Color.FromArgb(149, 165, 166);
                            emptyNode.NodeFont = new Font("Segoe UI", 10, FontStyle.Italic);
                            treeLichDay.Nodes.Add(emptyNode);
                            return;
                        }

                        foreach (var ngay in lichDayData)
                        {
                            // Node ngày với style đẹp hơn
                            string thuText = GetThuText(ngay.NgayDay.DayOfWeek);
                            TreeNode dayNode = new TreeNode($"{thuText}, {ngay.NgayDay.ToString("dd/MM/yyyy")} ({ngay.DanhSachLop.Count} lớp)");
                            dayNode.NodeFont = new Font("Segoe UI", 11, FontStyle.Bold);
                            dayNode.ForeColor = Color.FromArgb(41, 128, 185);
                            dayNode.BackColor = Color.FromArgb(236, 240, 241);

                            foreach (var lop in ngay.DanhSachLop)
                            {
                                // Node chi tiết lớp học
                                string timeInfo = $"{lop.ThoiGianBatDau.ToString(@"hh\:mm")} - {lop.ThoiGianKetThuc.ToString(@"hh\:mm")}";
                                string content = $"     {timeInfo}  |  {lop.TenLopHoc}  |  {lop.PhongHoc}";

                                TreeNode classNode = new TreeNode(content);
                                classNode.ForeColor = Color.FromArgb(52, 73, 94);
                                classNode.NodeFont = new Font("Segoe UI", 9);

                                dayNode.Nodes.Add(classNode);
                            }

                            treeLichDay.Nodes.Add(dayNode);
                        }

                        treeLichDay.ExpandAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch dạy: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetThuText(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday: return "Thứ Hai";
                case DayOfWeek.Tuesday: return "Thứ Ba";
                case DayOfWeek.Wednesday: return "Thứ Tư";
                case DayOfWeek.Thursday: return "Thứ Năm";
                case DayOfWeek.Friday: return "Thứ Sáu";
                case DayOfWeek.Saturday: return "Thứ Bảy";
                case DayOfWeek.Sunday: return "Chủ Nhật";
                default: return "";
            }
        }

        private async void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == -1 || treeLichDay.Nodes.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên có lịch dạy để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                sfd.FileName = $"LichDay_GV{txtMaGV.Text}_{DateTime.Now:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add("Lịch Dạy");

                        ws.Cell(1, 1).Value = "Ngày Dạy";
                        ws.Cell(1, 2).Value = "Giờ Bắt Đầu";
                        ws.Cell(1, 3).Value = "Giờ Kết Thúc";
                        ws.Cell(1, 4).Value = "Tên Lớp";
                        ws.Cell(1, 5).Value = "Phòng Học";

                        var rngHead = ws.Range("A1:E1");
                        rngHead.Style.Font.Bold = true;
                        rngHead.Style.Fill.BackgroundColor = XLColor.FromArgb(52, 152, 219);
                        rngHead.Style.Font.FontColor = XLColor.White;
                        rngHead.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int row = 2;
                        foreach (var group in dataExport)
                        {
                            foreach (var lop in group.DanhSachLop)
                            {
                                ws.Cell(row, 1).Value = group.NgayDay.ToString("dd/MM/yyyy");
                                ws.Cell(row, 2).Value = lop.ThoiGianBatDau.ToString(@"hh\:mm");
                                ws.Cell(row, 3).Value = lop.ThoiGianKetThuc.ToString(@"hh\:mm");
                                ws.Cell(row, 4).Value = lop.TenLopHoc;
                                ws.Cell(row, 5).Value = lop.PhongHoc;
                                row++;
                            }
                        }

                        ws.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xuất Excel: " + ex.Message); }
        }

        private void ResetForm()
        {
            _selectedTeacherId = -1;
            _currentAvatarPath = null;

            txtMaGV.Clear();
            txtTenGV.Clear();
            txtSDT.Clear();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
            txtKinhNghiem.Text = "0";
            picAvatar.Image = null;

            btnLuu.Text = "Thêm Mới";
            btnXoa.Enabled = false;
            txtMaGV.Enabled = false;

            treeLichDay.Nodes.Clear();
            txtTenGV.Focus();
        }
    }
}