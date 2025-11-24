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
        public class PhongHocDTO
        {
            public int IdPhong { get; set; }
            public string TenPhong { get; set; }
        }

        public frmXuLyHocBu(int idLopHoc, int idLichHocCu, string infoBuoiCu = "")
        {
            InitializeComponent();
            _idLopHoc = idLopHoc;
            _idLichHocCu = idLichHocCu;
            txtLichCu.Text = infoBuoiCu;

            // Setup Events
            chkCoLichBu.CheckedChanged += (s, e) =>
            {
                dtpNgayBu.Enabled = chkCoLichBu.Checked;
                dtpGioBatDau.Enabled = chkCoLichBu.Checked;
                dtpGioKetThuc.Enabled = chkCoLichBu.Checked;
                cboPhongBu.Enabled = chkCoLichBu.Checked;
                btnKiemTraPhong.Enabled = chkCoLichBu.Checked;
            };

            btnKiemTraPhong.Click += BtnKiemTraPhong_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();

            // Mặc định thêm 1 tuần cho ngày bù
            dtpNgayBu.Value = DateTime.Now.AddDays(7);
        }

        // API 1: Lấy danh sách phòng trống
        private async void BtnKiemTraPhong_Click(object sender, EventArgs e)
        {
            string date = dtpNgayBu.Value.ToString("yyyy-MM-dd");
            string start = dtpGioBatDau.Value.ToString("HH:mm:ss");
            string end = dtpGioKetThuc.Value.ToString("HH:mm:ss");

            // Validate giờ
            if (dtpGioBatDau.Value >= dtpGioKetThuc.Value)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // URL: QLLichHoc/GetPhongTrong?ngay=...&batDau=...&ketThuc=...
                    string url = DungChung.getUrl($"QLLichHoc/GetPhongTrong?ngay={date}&batDau={start}&ketThuc={end}");
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var listPhong = JsonConvert.DeserializeObject<List<PhongHocDTO>>(json);

                        if (listPhong.Count == 0)
                        {
                            MessageBox.Show("Không có phòng nào trống vào giờ này!", "Hết phòng");
                            cboPhongBu.DataSource = null;
                        }
                        else
                        {
                            cboPhongBu.DataSource = listPhong;
                            cboPhongBu.DisplayMember = "TenPhong";
                            cboPhongBu.ValueMember = "IdPhong";
                            MessageBox.Show($"Đã tìm thấy {listPhong.Count} phòng trống.");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // API 2: Xác nhận đổi lịch
        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // Nếu chỉ hủy mà không bù -> Cần logic API khác hoặc chỉnh API BaoNghiVaDayBu để chấp nhận null
            // Ở đây giả định là luôn có dạy bù theo form của bạn
            if (chkCoLichBu.Checked)
            {
                if (cboPhongBu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng học (Nhấn 'Lấy DS Phòng' trước)");
                    return;
                }

                var payload = new
                {
                    idLopHoc = _idLopHoc,
                    idLichHoc = _idLichHocCu, // ID buổi cũ để hủy
                    ngayHoc = dtpNgayBu.Value,
                    thoiGianBatDau = dtpGioBatDau.Value.TimeOfDay,
                    thoiGianKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                    idPhong = (int)cboPhongBu.SelectedValue
                };

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string json = JsonConvert.SerializeObject(payload);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        var response = await client.PutAsync(DungChung.getUrl("QLLichHoc/BaoNghiVaDayBu"), content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Đổi lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            var err = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Thất bại: " + err, "Lỗi trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
            else
            {
                // Trường hợp chỉ báo nghỉ (không bù) -> Bạn có thể gọi API UpdateLichHoc (set TrangThai=false) đơn giản
                MessageBox.Show("Chức năng chỉ báo nghỉ (không bù) cần gọi API UpdateLichHoc cũ.");
            }
        }
    }
}
