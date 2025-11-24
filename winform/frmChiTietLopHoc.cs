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
    public partial class frmChiTietLopHoc : Form
    {
        public class LopHocDetailDTO
        {
            public int IdLopHoc { get; set; }
            public int IdKhoaHoc { get; set; }
            public string TenLopHoc { get; set; }
            public DateTime NgayKhaiGiang { get; set; }
            public int IdPhong { get; set; } // Đã sửa API trả về IdPhong (chữ thường idPhong cũng map đc)
            public string SoBuoiTrenTuan { get; set; }
            public int SoLuongToiThieu { get; set; }
            public int SoLuongToiDa { get; set; }
            public TimeSpan ThoiGianBatDau { get; set; }
            public TimeSpan ThoiGianKetThuc { get; set; }

            // List object GiaoVien (API trả về { TenGv, GiaoVienId })
            public List<GiaoVienDTO> GiaoVien { get; set; }

            // List object HocCu (API trả về list object { IdHocCu, TenHocCu, SoLuong... })
            public List<HocCuLocal> HocCu { get; set; }
        }

        // 2. Các DTO phụ
        public class GiaoVienDTO { public int GiaoVienId { get; set; } public string TenGv { get; set; } }
        public class PhongHocDTO { public int IdPhong { get; set; } public string TenPhong { get; set; } }
        public class KhoaHocDTO { public int IdKhoaHoc { get; set; } public string TenKhoaHoc { get; set; } }
        public class HocCuSimpleDTO { public int IdHocCu { get; set; } public string TenHocCu { get; set; } }

        // 3. DTO hiển thị GridView Học Cụ
        public class HocCuLocal { public int IdHocCu { get; set; } public string TenHocCu { get; set; } public int SoLuong { get; set; } }

        // 4. Payload Gửi đi (POST/PUT)
        public class AddLopHocPayload
        {
            public string TenLopHoc { get; set; }
            public int IdKhoaHoc { get; set; }
            public int IdPhong { get; set; }
            public DateTime NgayKhaiGiang { get; set; }
            public string SoBuoiTrenTuan { get; set; }
            public int SoLuongToiThieu { get; set; }
            public int SoLuongToiDa { get; set; }
            public TimeSpan ThoiGianBatDau { get; set; }
            public TimeSpan ThoiGianKetThuc { get; set; }
            public List<int> GiaoVienId { get; set; }
            public Dictionary<string, int> DShocCu { get; set; }
        }

        // DTO Response của API GetGiaoVienKhongTrunglich
        public class GiaoVienAvailableResponse
        {
            public List<string> tenGV { get; set; }
            public List<int> idGV { get; set; }
        }

        // ================== LOGIC FORM ==================

        private int _idLopHoc;
        private BindingList<HocCuLocal> _listHocCuLocal;
        private bool _isStarted = false; // Cờ đánh dấu lớp đã học

        public frmChiTietLopHoc(int idLopHoc = -1)
        {
            InitializeComponent();
            _idLopHoc = idLopHoc;

            // Setup GridView Học Cụ
            _listHocCuLocal = new BindingList<HocCuLocal>();
            dgvHocCu.AutoGenerateColumns = false;
            dgvHocCu.AllowUserToAddRows = false;
            dgvHocCu.DataSource = _listHocCuLocal;

            if (dgvHocCu.Columns.Count == 0)
            {
                dgvHocCu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenHocCu", HeaderText = "Tên HC", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                dgvHocCu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Width = 60 });

                // --- THÊM CỘT XÓA ---
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.Name = "btnXoaHocCu";
                btnXoa.HeaderText = "Thao tác";
                btnXoa.Text = "Xóa";
                btnXoa.UseColumnTextForButtonValue = true;
                btnXoa.Width = 70;
                // Style cho nút Xóa (Màu đỏ nhạt cho dễ nhìn)
                btnXoa.DefaultCellStyle.ForeColor = Color.Red;
                btnXoa.DefaultCellStyle.SelectionForeColor = Color.Red;

                dgvHocCu.Columns.Add(btnXoa);
            }

            // Gán sự kiện
            this.Load += FrmChiTietLopHoc_Load;
            btnAddHocCu.Click += BtnAddHocCu_Click;
            btnLuu.Click += BtnLuu_Click;
            dgvHocCu.CellClick += DgvHocCu_CellClick;
            btnHuy.Click += (s, e) => this.Close();

            // Sự kiện nút Lọc GV (Bạn đã thêm nút này ở bước Designer trước đó chưa? Nếu chưa thì code sẽ lỗi dòng này)
            // Giả sử bạn ĐÃ thêm nút btnLocGV vào Designer như tôi hướng dẫn
            if (btnLocGV != null) btnLocGV.Click += BtnLocGV_Click;
        }

        private async void FrmChiTietLopHoc_Load(object sender, EventArgs e)
        {
            await LoadDataSources(); // Load ComboBox trước

            if (_idLopHoc > 0)
            {
                lblTitle.Text = "CẬP NHẬT LỚP HỌC";
                await LoadClassDetail();
            }
            else
            {
                lblTitle.Text = "THÊM LỚP HỌC MỚI";
                // Mặc định
                dtpNgayKG.Value = DateTime.Today.AddDays(1);
                dtpGioBatDau.Value = DateTime.Today.AddHours(8);
                dtpGioKetThuc.Value = DateTime.Today.AddHours(10);

                // Mặc định load toàn bộ GV khi thêm mới (hoặc để trống chờ lọc)
                // await LoadAllTeachers(); 
            }
        }

        private async Task LoadDataSources()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var t1 = client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllKhoaHoc"));
                    var t2 = client.GetAsync(DungChung.getUrl("QLLopHoc/GetAllPhongHoc"));
                    var t3 = client.GetAsync(DungChung.getUrl("QLLopHoc/GetAllHocCu"));
                    // Không load GV ở đây vì cần lọc theo giờ, hoặc load all để backup

                    await Task.WhenAll(t1, t2, t3);

                    if (t1.Result.IsSuccessStatusCode)
                    {
                        var listKH = JsonConvert.DeserializeObject<List<KhoaHocDTO>>(await t1.Result.Content.ReadAsStringAsync());
                        cboKhoaHoc.DataSource = listKH;
                        cboKhoaHoc.DisplayMember = "TenKhoaHoc"; cboKhoaHoc.ValueMember = "IdKhoaHoc";
                    }

                    if (t2.Result.IsSuccessStatusCode)
                    {
                        var listP = JsonConvert.DeserializeObject<List<PhongHocDTO>>(await t2.Result.Content.ReadAsStringAsync());
                        cboPhong.DataSource = listP;
                        cboPhong.DisplayMember = "TenPhong"; cboPhong.ValueMember = "IdPhong";
                    }

                    if (t3.Result.IsSuccessStatusCode)
                    {
                        var listHC = JsonConvert.DeserializeObject<List<HocCuSimpleDTO>>(await t3.Result.Content.ReadAsStringAsync());
                        cboChonHocCu.DataSource = listHC;
                        cboChonHocCu.DisplayMember = "TenHocCu"; cboChonHocCu.ValueMember = "IdHocCu";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối: " + ex.Message); }
        }

        private async Task LoadClassDetail()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl($"QLLopHoc/GetLopHocById/{_idLopHoc}"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<LopHocDetailDTO>(json);

                        // 1. Bind Info
                        txtTenLop.Text = data.TenLopHoc;
                        cboKhoaHoc.SelectedValue = data.IdKhoaHoc;
                        cboPhong.SelectedValue = data.IdPhong; // OK vì API mới đã trả về idPhong
                        dtpNgayKG.Value = data.NgayKhaiGiang;

                        numSiSoMin.Value = data.SoLuongToiThieu;
                        numSiSoMax.Value = data.SoLuongToiDa;

                        // 2. Bind Lịch
                        dtpGioBatDau.Value = DateTime.Today.Add(data.ThoiGianBatDau);
                        dtpGioKetThuc.Value = DateTime.Today.Add(data.ThoiGianKetThuc);
                        ParseStringToDays(data.SoBuoiTrenTuan);

                        // 3. Bind Học Cụ
                        _listHocCuLocal.Clear();
                        if (data.HocCu != null)
                        {
                            foreach (var hc in data.HocCu) _listHocCuLocal.Add(hc);
                        }

                        // 4. Bind Giáo Viên (Lấy danh sách GV hiện tại của lớp đưa vào CheckedListBox)
                        // Lưu ý: Vì danh sách GV khả dụng phụ thuộc vào giờ học, nên ta sẽ set DataSource là danh sách GV đang dạy lớp này trước
                        if (data.GiaoVien != null && data.GiaoVien.Count > 0)
                        {
                            chkListGiaoVien.DataSource = data.GiaoVien;
                            chkListGiaoVien.DisplayMember = "TenGv";
                            chkListGiaoVien.ValueMember = "GiaoVienId";

                            // Tick all (vì đây là những người đang dạy)
                            for (int i = 0; i < chkListGiaoVien.Items.Count; i++)
                                chkListGiaoVien.SetItemChecked(i, true);
                        }

                        // Check khóa sửa
                        if (data.NgayKhaiGiang <= DateTime.Now)
                        {
                            _isStarted = true;
                            // MessageBox.Show("Lớp đã khai giảng...");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load chi tiết: " + ex.Message); }
        }

        // --- Helper xử lý ngày ---
        private string ConvertDaysToString()
        {
            List<int> selected = new List<int>();
            for (int i = 0; i < chkListNgayHoc.Items.Count; i++)
            {
                if (chkListNgayHoc.GetItemChecked(i)) selected.Add(i + 1); // 1=Thứ 2
            }
            return string.Join(",", selected);
        }

        private void ParseStringToDays(string s)
        {
            if (string.IsNullOrEmpty(s)) return;
            var arr = s.Split(',');
            foreach (var d in arr)
            {
                if (int.TryParse(d, out int idx) && idx >= 1 && idx <= 7)
                    chkListNgayHoc.SetItemChecked(idx - 1, true);
            }
        }

        // --- SỰ KIỆN ---

        // API: Lọc Giáo viên trống lịch (POST)
        private async void BtnLocGV_Click(object sender, EventArgs e)
        {
            if (dtpGioBatDau.Value >= dtpGioKetThuc.Value) { MessageBox.Show("Giờ lỗi!"); return; }
            string ngayHocStr = ConvertDaysToString();
            if (string.IsNullOrEmpty(ngayHocStr)) { MessageBox.Show("Chọn ngày học trước!"); return; }

            var payload = new
            {
                ThoiGianBatDau = dtpGioBatDau.Value.TimeOfDay,
                ThoiGianKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                SoBuoiTrenTuan = ngayHocStr
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Gọi API POST
                    var response = await client.PostAsync(DungChung.getUrl("QLLopHoc/GetGiaoVienKhongTrunglich"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        var resJson = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<GiaoVienAvailableResponse>(resJson);

                        // Map sang list DTO để hiển thị
                        List<GiaoVienDTO> listAvailable = new List<GiaoVienDTO>();
                        if (data.idGV != null && data.tenGV != null)
                        {
                            for (int i = 0; i < data.idGV.Count; i++)
                            {
                                listAvailable.Add(new GiaoVienDTO { GiaoVienId = data.idGV[i], TenGv = data.tenGV[i] });
                            }
                        }

                        chkListGiaoVien.DataSource = listAvailable;
                        chkListGiaoVien.DisplayMember = "TenGv";
                        chkListGiaoVien.ValueMember = "GiaoVienId";
                        MessageBox.Show($"Tìm thấy {listAvailable.Count} giáo viên rảnh.");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lọc GV: " + ex.Message); }
        }

        private void BtnAddHocCu_Click(object sender, EventArgs e)
        {
            if (cboChonHocCu.SelectedItem is HocCuSimpleDTO item)
            {
                var exist = _listHocCuLocal.FirstOrDefault(x => x.IdHocCu == item.IdHocCu);
                if (exist != null) exist.SoLuong += (int)numSLHocCu.Value;
                else _listHocCuLocal.Add(new HocCuLocal { IdHocCu = item.IdHocCu, TenHocCu = item.TenHocCu, SoLuong = (int)numSLHocCu.Value });
                dgvHocCu.Refresh();
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtTenLop.Text)) { MessageBox.Show("Nhập tên lớp!"); return; }
            if (cboKhoaHoc.SelectedIndex == -1 || cboPhong.SelectedIndex == -1) { MessageBox.Show("Chọn khóa/phòng!"); return; }
            if (chkListNgayHoc.CheckedItems.Count == 0) { MessageBox.Show("Chọn lịch học!"); return; }

            // Payload
            var listGVIds = new List<int>();
            foreach (GiaoVienDTO gv in chkListGiaoVien.CheckedItems) listGVIds.Add(gv.GiaoVienId);

            var dictHocCu = new Dictionary<string, int>();
            foreach (var hc in _listHocCuLocal) dictHocCu.Add(hc.IdHocCu.ToString(), hc.SoLuong);

            var payload = new AddLopHocPayload
            {
                TenLopHoc = txtTenLop.Text,
                IdKhoaHoc = (int)cboKhoaHoc.SelectedValue,
                IdPhong = (int)cboPhong.SelectedValue,
                NgayKhaiGiang = dtpNgayKG.Value,
                SoBuoiTrenTuan = ConvertDaysToString(),
                ThoiGianBatDau = dtpGioBatDau.Value.TimeOfDay,
                ThoiGianKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                SoLuongToiThieu = (int)numSiSoMin.Value,
                SoLuongToiDa = (int)numSiSoMax.Value,
                GiaoVienId = listGVIds,
                DShocCu = dictHocCu
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage res;
                    if (_idLopHoc == -1)
                        res = await client.PostAsync(DungChung.getUrl("QLLopHoc/CreateLopHoc"), content);
                    else
                        res = await client.PutAsync(DungChung.getUrl($"QLLopHoc/UpdateLopHoc/{_idLopHoc}"), content);

                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thành công!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        var err = await res.Content.ReadAsStringAsync();
                        // Hiển thị lỗi đẹp (bỏ bớt ký tự JSON nếu cần)
                        MessageBox.Show("Lỗi: " + err);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void DgvHocCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click đúng vào nút Xóa và không phải header
            if (e.RowIndex >= 0 && dgvHocCu.Columns[e.ColumnIndex].Name == "btnXoaHocCu")
            {
                // Lấy item đang chọn
                var item = _listHocCuLocal[e.RowIndex];

                // Xác nhận xóa (Optional)
                 if (MessageBox.Show($"Xóa {item.TenHocCu}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _listHocCuLocal.RemoveAt(e.RowIndex);
                    // Không cần gọi Refresh vì BindingList tự cập nhật UI
                }
            }
        }
    }
}
