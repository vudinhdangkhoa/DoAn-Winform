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
        // ... (Giữ nguyên các DTO Class như cũ) ...
        public class LopHocDetailDTO
        {
            public int IdLopHoc { get; set; }
            public int IdKhoaHoc { get; set; }
            public string TenLopHoc { get; set; }
            public DateTime NgayKhaiGiang { get; set; }
            public int IdPhong { get; set; }
            public string SoBuoiTrenTuan { get; set; }
            public int SoLuongToiThieu { get; set; }
            public int SoLuongToiDa { get; set; }
            public TimeSpan ThoiGianBatDau { get; set; }
            public TimeSpan ThoiGianKetThuc { get; set; }
            public List<GiaoVienDTO> GiaoVien { get; set; }
            public List<HocCuLocal> HocCu { get; set; }
        }
        public class GiaoVienDTO { public int GiaoVienId { get; set; } public string TenGv { get; set; } public string DisplayText => $"{GiaoVienId} - {TenGv}"; }
        public class PhongHocDTO { public int IdPhong { get; set; } public string TenPhong { get; set; } }
        public class KhoaHocDTO { public int IdKhoaHoc { get; set; } public string TenKhoaHoc { get; set; } }
        public class HocCuSimpleDTO { public int IdHocCu { get; set; } public string TenHocCu { get; set; } }
        public class HocCuLocal { public int IdHocCu { get; set; } public string TenHocCu { get; set; } public int SoLuong { get; set; } }
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
        public class GiaoVienAvailableResponse
        {
            public List<string> tenGV { get; set; }
            public List<int> idGV { get; set; }
        }

        private int _idLopHoc;
        private BindingList<HocCuLocal> _listHocCuLocal;
        private bool _isStarted = false;

        public frmChiTietLopHoc(int idLopHoc = -1)
        {
            InitializeComponent();
            numSoBuoiTuan.ResetText();
            _idLopHoc = idLopHoc;

            _listHocCuLocal = new BindingList<HocCuLocal>();
            dgvHocCu.AutoGenerateColumns = false;
            dgvHocCu.AllowUserToAddRows = false;
            dgvHocCu.DataSource = _listHocCuLocal;

            if (dgvHocCu.Columns.Count == 0)
            {
                dgvHocCu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenHocCu", HeaderText = "Tên HC", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                dgvHocCu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Width = 60 });
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn { Name = "btnXoaHocCu", HeaderText = "Thao tác", Text = "Xóa", UseColumnTextForButtonValue = true, Width = 70 };
                btnXoa.DefaultCellStyle.ForeColor = Color.Red;
                dgvHocCu.Columns.Add(btnXoa);
            }

            this.Load += FrmChiTietLopHoc_Load;
            btnAddHocCu.Click += BtnAddHocCu_Click;
            btnLuu.Click += BtnLuu_Click;
            dgvHocCu.CellClick += DgvHocCu_CellClick;
            btnHuy.Click += (s, e) => this.Close();
            if (btnLocGV != null) btnLocGV.Click += BtnLocGV_Click;

            // Ràng buộc nhập số cho 3 TextBox
            txtSiSoMin.KeyPress += OnlyNumbers_KeyPress;
            txtSiSoMax.KeyPress += OnlyNumbers_KeyPress;
            txtSLHocCu.KeyPress += OnlyNumbers_KeyPress;

            numSoBuoiTuan.ValueChanged += (s, e) =>
            {
                for (int i = 0; i < chkListNgayHoc.Items.Count; i++) chkListNgayHoc.SetItemChecked(i, false);
            };
            chkListNgayHoc.ItemCheck += ChkListNgayHoc_ItemCheck;
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void ChkListNgayHoc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                int maxAllowed = (int)numSoBuoiTuan.Value;
                int currentCheckedCount = chkListNgayHoc.CheckedItems.Count;
                if (currentCheckedCount >= maxAllowed)
                {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show($"Bạn chỉ được chọn tối đa {maxAllowed} buổi/tuần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void FrmChiTietLopHoc_Load(object sender, EventArgs e)
        {
            await LoadDataSources();
            if (_idLopHoc > 0)
            {
                lblTitle.Text = "CẬP NHẬT LỚP HỌC";
                await LoadClassDetail();
            }
            else
            {
                lblTitle.Text = "THÊM LỚP HỌC MỚI";
                dtpNgayKG.Value = DateTime.Today.AddDays(1);
                dtpGioBatDau.Value = DateTime.Today.AddHours(8);
                dtpGioKetThuc.Value = DateTime.Today.AddHours(10);

                // Mặc định Min=5, Max=12
                txtSiSoMin.Text = "5";
                txtSiSoMax.Text = "12";
                txtSLHocCu.Text = "1";
            }
        }

        // ... (LoadDataSources giữ nguyên) ...
        private async Task LoadDataSources()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var t1 = client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllKhoaHoc"));
                    var t2 = client.GetAsync(DungChung.getUrl("QLLopHoc/GetAllPhongHoc"));
                    var t3 = client.GetAsync(DungChung.getUrl("QLLopHoc/GetAllHocCu"));
                    await Task.WhenAll(t1, t2, t3);

                    if (t1.Result.IsSuccessStatusCode)
                    {
                        var listKH = JsonConvert.DeserializeObject<List<KhoaHocDTO>>(await t1.Result.Content.ReadAsStringAsync());
                        cboKhoaHoc.DataSource = listKH; cboKhoaHoc.DisplayMember = "TenKhoaHoc"; cboKhoaHoc.ValueMember = "IdKhoaHoc";
                    }
                    if (t2.Result.IsSuccessStatusCode)
                    {
                        var listP = JsonConvert.DeserializeObject<List<PhongHocDTO>>(await t2.Result.Content.ReadAsStringAsync());
                        cboPhong.DataSource = listP; cboPhong.DisplayMember = "TenPhong"; cboPhong.ValueMember = "IdPhong";
                    }
                    if (t3.Result.IsSuccessStatusCode)
                    {
                        var listHC = JsonConvert.DeserializeObject<List<HocCuSimpleDTO>>(await t3.Result.Content.ReadAsStringAsync());
                        cboChonHocCu.DataSource = listHC; cboChonHocCu.DisplayMember = "TenHocCu"; cboChonHocCu.ValueMember = "IdHocCu";
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

                        txtTenLop.Text = data.TenLopHoc;
                        cboKhoaHoc.SelectedValue = data.IdKhoaHoc;
                        cboPhong.SelectedValue = data.IdPhong;
                        dtpNgayKG.Value = data.NgayKhaiGiang;

                        // Load Textbox Sĩ Số
                        txtSiSoMin.Text = data.SoLuongToiThieu.ToString();
                        txtSiSoMax.Text = data.SoLuongToiDa.ToString();

                        dtpGioBatDau.Value = DateTime.Today.Add(data.ThoiGianBatDau);
                        dtpGioKetThuc.Value = DateTime.Today.Add(data.ThoiGianKetThuc);
                        ParseStringToDays(data.SoBuoiTrenTuan);

                        _listHocCuLocal.Clear();
                        if (data.HocCu != null) foreach (var hc in data.HocCu) _listHocCuLocal.Add(hc);

                        if (data.GiaoVien != null && data.GiaoVien.Count > 0)
                        {
                            chkListGiaoVien.DataSource = data.GiaoVien;
                            chkListGiaoVien.DisplayMember = "DisplayText";
                            chkListGiaoVien.ValueMember = "GiaoVienId";
                            for (int i = 0; i < chkListGiaoVien.Items.Count; i++) chkListGiaoVien.SetItemChecked(i, true);
                        }

                        if (data.NgayKhaiGiang <= DateTime.Now) _isStarted = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load chi tiết: " + ex.Message); }
        }

        private string ConvertDaysToString()
        {
            List<int> selected = new List<int>();
            for (int i = 0; i < chkListNgayHoc.Items.Count; i++)
            {
                if (chkListNgayHoc.GetItemChecked(i)) selected.Add(i + 1);
            }
            return string.Join(",", selected);
        }

        private void ParseStringToDays(string s)
        {
            if (string.IsNullOrEmpty(s)) return;
            var arr = s.Split(',');
            if (arr.Length > 0) numSoBuoiTuan.Value = arr.Length;
            foreach (var d in arr)
            {
                if (int.TryParse(d, out int idx) && idx >= 1 && idx <= 7)
                    chkListNgayHoc.SetItemChecked(idx - 1, true);
            }
        }

        private async void BtnLocGV_Click(object sender, EventArgs e)
        {
            if (dtpGioBatDau.Value >= dtpGioKetThuc.Value) { MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!"); return; }
            string ngayHocStr = ConvertDaysToString();
            if (string.IsNullOrEmpty(ngayHocStr)) { MessageBox.Show("Chọn ngày học trước!"); return; }
            if (chkListNgayHoc.CheckedItems.Count != (int)numSoBuoiTuan.Value)
            {
                MessageBox.Show($"Vui lòng chọn đủ {(int)numSoBuoiTuan.Value} ngày học trước khi lọc GV!");
                return;
            }

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
                    var response = await client.PostAsync(DungChung.getUrl("QLLopHoc/GetGiaoVienKhongTrunglich"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        var resJson = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<GiaoVienAvailableResponse>(resJson);
                        List<GiaoVienDTO> listAvailable = new List<GiaoVienDTO>();
                        if (data.idGV != null && data.tenGV != null)
                        {
                            for (int i = 0; i < data.idGV.Count; i++)
                                listAvailable.Add(new GiaoVienDTO { GiaoVienId = data.idGV[i], TenGv = data.tenGV[i] });
                        }
                        chkListGiaoVien.DataSource = listAvailable;
                        chkListGiaoVien.DisplayMember = "DisplayText";
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
                // Parse SL từ TextBox
                if (!int.TryParse(txtSLHocCu.Text, out int sl) || sl <= 0)
                {
                    MessageBox.Show("Số lượng phải là số > 0");
                    return;
                }

                var exist = _listHocCuLocal.FirstOrDefault(x => x.IdHocCu == item.IdHocCu);
                if (exist != null) exist.SoLuong += sl;
                else _listHocCuLocal.Add(new HocCuLocal { IdHocCu = item.IdHocCu, TenHocCu = item.TenHocCu, SoLuong = sl });
                dgvHocCu.Refresh();
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLop.Text)) { MessageBox.Show("Nhập tên lớp!"); return; }
            if (cboKhoaHoc.SelectedIndex == -1 || cboPhong.SelectedIndex == -1) { MessageBox.Show("Chọn khóa/phòng!"); return; }
            if (dtpNgayKG.Value.Date < DateTime.Now.Date) { MessageBox.Show("Ngày khai giảng không được nhỏ hơn ngày hiện tại!"); return; }
            if (dtpGioBatDau.Value.TimeOfDay >= dtpGioKetThuc.Value.TimeOfDay) { MessageBox.Show("Giờ học không hợp lệ!"); return; }

            if (chkListNgayHoc.CheckedItems.Count != (int)numSoBuoiTuan.Value)
            {
                MessageBox.Show("Số ngày chọn chưa khớp với số buổi/tuần!");
                return;
            }

            // --- VALIDATE SĨ SỐ ---
            if (!int.TryParse(txtSiSoMin.Text, out int siSoMin) || siSoMin < 5)
            {
                MessageBox.Show("Sĩ số tối thiểu phải >= 5 (Yêu cầu hệ thống).", "Lỗi Sĩ Số");
                return;
            }
            if (!int.TryParse(txtSiSoMax.Text, out int siSoMax) || siSoMax > 12)
            {
                MessageBox.Show("Sĩ số tối đa phải <= 12 (Yêu cầu hệ thống).", "Lỗi Sĩ Số");
                return;
            }
            if (siSoMin > siSoMax)
            {
                MessageBox.Show("Sĩ số tối thiểu không được lớn hơn tối đa!", "Lỗi Sĩ Số");
                return;
            }
            // ---------------------

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
                SoLuongToiThieu = siSoMin,
                SoLuongToiDa = siSoMax,
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
                        MessageBox.Show("Lỗi: " + err);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
        private void DgvHocCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHocCu.Columns[e.ColumnIndex].Name == "btnXoaHocCu")
            {
                _listHocCuLocal.RemoveAt(e.RowIndex);
            }
        }
    }
}