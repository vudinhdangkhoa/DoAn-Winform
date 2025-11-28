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
    public partial class frmXuLyHocBu : Form
    {
        private int _idLopHoc;
        private int _idLichHocCu;
        private DateTime _ngayHocCu;
        private DateTime _ngayKhaiGiang; // THÊM BIẾN LƯU NGÀY KHAI GIẢNG

        public class PhongHocDTO
        {
            public int IdPhong { get; set; }
            public string TenPhong { get; set; }
        }

        // SỬA CONSTRUCTOR: THÊM THAM SỐ ngayKhaiGiang
        public frmXuLyHocBu(int idLopHoc, int idLichHocCu, DateTime ngayKhaiGiang, string infoBuoiCu = "")
        {
            InitializeComponent();
            _idLopHoc = idLopHoc;
            _idLichHocCu = idLichHocCu;
            _ngayKhaiGiang = ngayKhaiGiang; // LƯU NGÀY KHAI GIẢNG
            txtLichCu.Text = infoBuoiCu;

            // Lấy ngày học cũ từ info
            try
            {
                if (!string.IsNullOrEmpty(infoBuoiCu))
                {
                    var parts = infoBuoiCu.Split('|');
                    if (parts.Length > 0)
                    {
                        _ngayHocCu = DateTime.ParseExact(parts[0].Trim(), "dd/MM/yyyy", null);
                    }
                    else
                    {
                        _ngayHocCu = DateTime.Now;
                    }
                }
                else
                {
                    _ngayHocCu = DateTime.Now;
                }
            }
            catch
            {
                _ngayHocCu = DateTime.Now;
            }

            // Setup Events
            chkCoLichBu.CheckedChanged += (s, e) =>
            {
                dtpNgayBu.Enabled = chkCoLichBu.Checked;
                dtpGioBatDau.Enabled = chkCoLichBu.Checked;
                dtpGioKetThuc.Enabled = chkCoLichBu.Checked;
                cboPhongBu.Enabled = chkCoLichBu.Checked;
                btnKiemTraPhong.Enabled = chkCoLichBu.Checked;
            };

            // SỬA: Validate ngày bù phải lớn hơn ngày khai giảng
            dtpNgayBu.ValueChanged += (s, e) =>
            {
                if (dtpNgayBu.Value.Date < _ngayKhaiGiang.Date)
                {
                    MessageBox.Show(this,
                        $"Ngày dạy bù không được nhỏ hơn ngày khai giảng ({_ngayKhaiGiang:dd/MM/yyyy})!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayBu.Value = _ngayKhaiGiang.Date; // Set về ngày khai giảng
                }

                // Thêm kiểm tra không được nhỏ hơn ngày hiện tại
                if (dtpNgayBu.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show(this, "Ngày dạy bù không được nhỏ hơn ngày hiện tại!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayBu.Value = DateTime.Now.Date;
                }
            };

            btnKiemTraPhong.Click += BtnKiemTraPhong_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();

            // SỬA: Set giá trị tối thiểu = MAX(ngày khai giảng, ngày hiện tại)
            DateTime minDate = _ngayKhaiGiang.Date > DateTime.Now.Date
                ? _ngayKhaiGiang.Date
                : DateTime.Now.Date;

            dtpNgayBu.MinDate = minDate;
            dtpNgayBu.Value = minDate.AddDays(1); // Mặc định = min + 1 ngày

            // Set giờ mặc định
            dtpGioBatDau.Value = DateTime.Today.AddHours(15); // 15:00
            dtpGioKetThuc.Value = DateTime.Today.AddHours(17); // 17:00

            // Validate giờ
            dtpGioBatDau.ValueChanged += ValidateTime;
            dtpGioKetThuc.ValueChanged += ValidateTime;
        }

        private void ValidateTime(object sender, EventArgs e)
        {
            if (dtpGioBatDau.Value >= dtpGioKetThuc.Value)
            {
                MessageBox.Show(this, "Giờ bắt đầu phải nhỏ hơn giờ kết thúc!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (sender == dtpGioBatDau)
                {
                    dtpGioKetThuc.Value = dtpGioBatDau.Value.AddHours(2);
                }
                else
                {
                    dtpGioBatDau.Value = dtpGioKetThuc.Value.AddHours(-2);
                }
            }
        }

        private async void BtnKiemTraPhong_Click(object sender, EventArgs e)
        {
            // SỬA: Validate ngày bù >= ngày khai giảng
            if (dtpNgayBu.Value.Date < _ngayKhaiGiang.Date)
            {
                MessageBox.Show(this,
                    $"Ngày dạy bù không được nhỏ hơn ngày khai giảng ({_ngayKhaiGiang:dd/MM/yyyy})!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayBu.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show(this, "Ngày dạy bù không được nhỏ hơn ngày hiện tại!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpGioBatDau.Value >= dtpGioKetThuc.Value)
            {
                MessageBox.Show(this, "Giờ bắt đầu phải nhỏ hơn giờ kết thúc!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string date = dtpNgayBu.Value.ToString("yyyy-MM-dd");
            string start = dtpGioBatDau.Value.ToString("HH:mm:ss");
            string end = dtpGioKetThuc.Value.ToString("HH:mm:ss");

            try
            {
                btnKiemTraPhong.Enabled = false;
                btnKiemTraPhong.Text = "⏳ Đang tìm...";

                using (HttpClient client = new HttpClient())
                {
                    string url = DungChung.getUrl($"QLLichHoc/GetPhongTrong?ngay={date}&batDau={start}&ketThuc={end}");
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var listPhong = JsonConvert.DeserializeObject<List<PhongHocDTO>>(json);

                        if (listPhong == null || listPhong.Count == 0)
                        {
                            MessageBox.Show(this, "Không có phòng nào trống vào giờ này!",
                                "Hết phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboPhongBu.DataSource = null;
                        }
                        else
                        {
                            cboPhongBu.DataSource = listPhong;
                            cboPhongBu.DisplayMember = "TenPhong";
                            cboPhongBu.ValueMember = "IdPhong";
                            MessageBox.Show(this, $"Đã tìm thấy {listPhong.Count} phòng trống.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(this, "Lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnKiemTraPhong.Text = "🔍 Lấy DS Phòng";
                btnKiemTraPhong.Enabled = true;
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            if (chkCoLichBu.Checked)
            {
                // SỬA: Validate ngày bù >= ngày khai giảng
                if (dtpNgayBu.Value.Date < _ngayKhaiGiang.Date)
                {
                    MessageBox.Show(this,
                        $"Ngày dạy bù không được nhỏ hơn ngày khai giảng ({_ngayKhaiGiang:dd/MM/yyyy})!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayBu.Focus();
                    return;
                }

                if (dtpNgayBu.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show(this, "Ngày dạy bù không được nhỏ hơn ngày hiện tại!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayBu.Focus();
                    return;
                }

                if (dtpGioBatDau.Value >= dtpGioKetThuc.Value)
                {
                    MessageBox.Show(this, "Giờ bắt đầu phải nhỏ hơn giờ kết thúc!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpGioBatDau.Focus();
                    return;
                }

                if (cboPhongBu.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Vui lòng chọn phòng học!\n(Nhấn 'Lấy DS Phòng' để tìm phòng trống)",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnKiemTraPhong.Focus();
                    return;
                }

                var payload = new
                {
                    idLopHoc = _idLopHoc,
                    idLichHoc = _idLichHocCu,
                    ngayHoc = dtpNgayBu.Value,
                    thoiGianBatDau = dtpGioBatDau.Value.TimeOfDay,
                    thoiGianKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                    idPhong = (int)cboPhongBu.SelectedValue
                };

                try
                {
                    btnLuu.Enabled = false;
                    btnLuu.Text = "⏳ Đang lưu...";

                    using (HttpClient client = new HttpClient())
                    {
                        string json = JsonConvert.SerializeObject(payload);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        var response = await client.PutAsync(DungChung.getUrl("QLLichHoc/BaoNghiVaDayBu"), content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(this, "Đổi lịch thành công!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            var err = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(this, "Thất bại: " + err,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Lỗi: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnLuu.Text = "💾 Lưu";
                    btnLuu.Enabled = true;
                }
            }
            else
            {
                var result = MessageBox.Show(this,
                    "Bạn chỉ muốn báo nghỉ mà không dạy bù?\nBuổi học này sẽ bị hủy!",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(this, "Chức năng chỉ báo nghỉ (không bù) cần gọi API UpdateLichHoc.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}