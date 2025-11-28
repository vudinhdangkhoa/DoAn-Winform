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
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace winform
{
    public partial class frmThemHocVien : Form
    {
        public frmThemHocVien()
        {
            InitializeComponent();

            // =======================================================
            // 1. CẤU HÌNH CHẶN NHẬP LIỆU (TUYỆT ĐỐI)
            // Code này đảm bảo sự kiện chạy dù giao diện có bị lỗi link
            // =======================================================

            // --- A. Cấu hình ô TÊN PHỤ HUYNH (txtTenPH) ---
            // Gỡ bỏ sự kiện cũ (để tránh trùng lặp) rồi gán mới
            this.txtTenPH.KeyPress -= TxtTen_KeyPress;
            this.txtTenPH.KeyPress += TxtTen_KeyPress;       // Chặn gõ phím số
            this.txtTenPH.TextChanged -= TxtTen_TextChanged;
            this.txtTenPH.TextChanged += TxtTen_TextChanged; // Chống Paste số

            // --- B. Cấu hình ô SỐ ĐIỆN THOẠI (txtSdtPH) ---
            this.txtSdtPH.MaxLength = 10;                    // Giới hạn 10 ký tự
            this.txtSdtPH.KeyPress -= TxtSdtPH_KeyPress;
            this.txtSdtPH.KeyPress += TxtSdtPH_KeyPress;     // Chặn gõ phím chữ
            this.txtSdtPH.TextChanged -= TxtSdtPH_TextChanged;
            this.txtSdtPH.TextChanged += TxtSdtPH_TextChanged; // Chống Paste chữ

            // 2. Gán các sự kiện nút bấm
            this.Load += FrmThemHocVien_Load;
            this.btnThemDong.Click += BtnThemDong_Click;
            this.btnLuu.Click += BtnLuu_Click;
            this.btnHuy.Click += (s, e) => this.Close();
        }

        // =======================================================
        // KHU VỰC XỬ LÝ LOGIC CHẶN (CORE)
        // =======================================================

        // 1. TÊN PHỤ HUYNH: Cấm Tuyệt Đối Số
        private void TxtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự gõ vào LÀ SỐ -> Chặn ngay lập tức (e.Handled = true)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTen_TextChanged(object sender, EventArgs e)
        {
            // Nếu lỡ Paste số vào -> Xóa sạch số ngay lập tức
            if (txtTenPH.Text.Any(char.IsDigit))
            {
                int cursorIndex = txtTenPH.SelectionStart;
                // Chỉ giữ lại các ký tự KHÔNG phải là số
                txtTenPH.Text = new string(txtTenPH.Text.Where(c => !char.IsDigit(c)).ToArray());
                // Đặt lại con trỏ chuột để không bị nhảy về đầu
                if (cursorIndex > 0 && cursorIndex <= txtTenPH.Text.Length)
                    txtTenPH.SelectionStart = cursorIndex - 1;
                else
                    txtTenPH.SelectionStart = txtTenPH.Text.Length;
            }
        }

        // 2. SỐ ĐIỆN THOẠI: Cấm Tuyệt Đối Chữ
        private void TxtSdtPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự KHÔNG phải số VÀ KHÔNG phải phím xóa (Backspace) -> Chặn
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSdtPH_TextChanged(object sender, EventArgs e)
        {
            // Nếu lỡ Paste chữ vào -> Xóa sạch chữ
            if (Regex.IsMatch(txtSdtPH.Text, "[^0-9]"))
            {
                int cursorIndex = txtSdtPH.SelectionStart;
                txtSdtPH.Text = Regex.Replace(txtSdtPH.Text, "[^0-9]", "");

                if (cursorIndex > 0 && cursorIndex <= txtSdtPH.Text.Length)
                    txtSdtPH.SelectionStart = cursorIndex - 1;
                else
                    txtSdtPH.SelectionStart = txtSdtPH.Text.Length;
            }
        }
        // =======================================================


        private List<LopHocSimpleDTO> _danhSachLopHoc = new List<LopHocSimpleDTO>();
        public dynamic dataKhoaHoc;
        private AddHocVienRequest _dataToPrint;
        private decimal _totalAmountToPrint;

        private async void FrmThemHocVien_Load(object sender, EventArgs e)
        {
            await LoadDataLopHoc();
            ThemDongHocVien();
        }

        private async Task LoadDataLopHoc()
        {
            try
            {
                dataKhoaHoc = await UCQuanLyHocVien.GetKhoaHoc();
                if (dataKhoaHoc != null)
                {
                    foreach (var kh in dataKhoaHoc)
                    {
                        if (kh.lopHocs == null || kh.lopHocs.Count == 0) continue;
                        decimal hocPhi = (decimal)(kh.hocPhi ?? 0);
                        decimal giamGia = (decimal)(kh.giamGia ?? 0);
                        foreach (var lh in kh.lopHocs)
                        {
                            _danhSachLopHoc.Add(new LopHocSimpleDTO
                            {
                                IdLopHoc = (int)lh.idLopHoc,
                                TenLop = (string)lh.tenLopHoc,
                                HocPhi = hocPhi,
                                GiamGia = giamGia
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message); }
        }

        private void BtnThemDong_Click(object sender, EventArgs e) { ThemDongHocVien(); }

        private void ThemDongHocVien()
        {
            var ucItem = new ucItemHocVien();
            if (_danhSachLopHoc != null) ucItem.LoadDanhSachLop(_danhSachLopHoc);
            ucItem.Width = flowPanelHocViens.ClientSize.Width - 25;
            ucItem.OnDeleteRequest += (s, a) =>
            {
                if (flowPanelHocViens.Controls.Count > 1) { flowPanelHocViens.Controls.Remove(ucItem); ucItem.Dispose(); }
                else MessageBox.Show("Cần ít nhất 1 học viên!");
            };
            flowPanelHocViens.Controls.Add(ucItem);
            flowPanelHocViens.ScrollControlIntoView(ucItem);
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            string tenPH = txtTenPH.Text.Trim();
            string sdtPH = txtSdtPH.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenPH) || string.IsNullOrWhiteSpace(sdtPH))
            {
                MessageBox.Show("Vui lòng nhập tên và SĐT Phụ huynh!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdtPH.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdtPH.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtEmailPH.Text) && !Helper.IsValidEmail(txtEmailPH.Text))
            {
                MessageBox.Show("Email sai định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailPH.Focus();
                return;
            }
            if (dtpNgaySinhPH.Value.AddYears(18) > DateTime.Now)
            {
                MessageBox.Show("Phụ huynh phải trên 18 tuổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var requestData = new AddHocVienRequest
            {
                tenPH = tenPH,
                sdt = sdtPH,
                email = txtEmailPH.Text.Trim(),
                NgaySinhPH_Raw = dtpNgaySinhPH.Value,
                gioiTinh = cboGioiTinhPH.SelectedItem?.ToString(),
            };

            foreach (Control c in flowPanelHocViens.Controls)
            {
                if (c is ucItemHocVien item)
                {
                    HocVienDTO hv = item.GetData();
                    if (string.IsNullOrWhiteSpace(hv.tenHv)) { MessageBox.Show("Thiếu tên học viên!"); return; }

                    // Dù đã chặn nhập, vẫn kiểm tra lại lần cuối cho chắc chắn
                    if (hv.tenHv.Any(char.IsDigit))
                    {
                        MessageBox.Show($"Tên học viên '{hv.tenHv}' không hợp lệ (chứa số)!", "Lỗi");
                        return;
                    }

                    if (hv.NgaySinh_Raw.Value.Date >= DateTime.Now.Date) { MessageBox.Show("Ngày sinh học viên không hợp lệ!", "Lỗi"); return; }
                    requestData.dsHocVien.Add(hv);
                }
            }

            _dataToPrint = requestData;
            await CallApiAddHocVien(requestData);
        }

        private async Task CallApiAddHocVien(AddHocVienRequest data)
        {
            btnLuu.Enabled = false; btnLuu.Text = "Đang lưu...";
            try
            {
                dynamic result = await UCQuanLyHocVien.AddHocVien(data);
                if (result != null)
                {
                    if (MessageBox.Show("Thêm thành công! In hóa đơn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) InHoaDon();
                    this.DialogResult = DialogResult.OK; this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { btnLuu.Enabled = true; btnLuu.Text = "LƯU DỮ LIỆU"; }
        }

        private void flowPanelHocViens_SizeChanged(object sender, EventArgs e)
        {
            flowPanelHocViens.SuspendLayout();
            foreach (Control c in flowPanelHocViens.Controls) c.Width = flowPanelHocViens.ClientSize.Width - 25;
            flowPanelHocViens.ResumeLayout();
        }

        private void InHoaDon()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
            PrintPreviewDialog pvd = new PrintPreviewDialog();
            pvd.Document = pd;
            pvd.Width = 800; pvd.Height = 600;
            pvd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Font và cấu hình in
            Font fontHeader = new Font("Arial", 16, FontStyle.Bold);
            Font fontSubHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            float margin = 50, y = margin, w = e.PageBounds.Width;

            e.Graphics.DrawString("TRUNG TÂM MỸ THUẬT", fontHeader, Brushes.Blue, (w - e.Graphics.MeasureString("TRUNG TÂM MỸ THUẬT", fontHeader).Width) / 2, y);
            y += 30;
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", fontSubHeader, Brushes.Black, (w - e.Graphics.MeasureString("HÓA ĐƠN THANH TOÁN", fontSubHeader).Width) / 2, y);
            y += 40;

            e.Graphics.DrawString($"Phụ huynh: {_dataToPrint.tenPH}", fontBold, Brushes.Black, margin, y);
            y += 25;
            e.Graphics.DrawString($"SĐT: {_dataToPrint.sdt}", fontRegular, Brushes.Black, margin, y);
            y += 35;

            // Bảng chi tiết
            float col1 = margin, col2 = margin + 200, col3 = w - margin - 100;
            e.Graphics.DrawString("Học viên", fontBold, Brushes.Black, col1, y);
            e.Graphics.DrawString("Lớp học", fontBold, Brushes.Black, col2, y);
            e.Graphics.DrawString("Thành tiền", fontBold, Brushes.Black, col3, y);
            y += 25;
            e.Graphics.DrawLine(Pens.Black, margin, y, w - margin, y);
            y += 10;

            decimal total = 0;
            foreach (var hv in _dataToPrint.dsHocVien)
            {
                e.Graphics.DrawString($"- {hv.tenHv}", fontBold, Brushes.Black, col1, y);
                foreach (var lopId in hv.dsLopId)
                {
                    var lop = _danhSachLopHoc.FirstOrDefault(l => l.IdLopHoc == lopId);
                    if (lop != null)
                    {
                        e.Graphics.DrawString(lop.TenLop, fontRegular, Brushes.Black, col2, y);
                        e.Graphics.DrawString(lop.ThanhTien.ToString("#,##0"), fontRegular, Brushes.Black, col3, y);
                        total += lop.ThanhTien;
                        y += 20;
                    }
                }
                y += 10;
            }

            y += 10;
            e.Graphics.DrawLine(Pens.Black, margin, y, w - margin, y);
            y += 10;
            e.Graphics.DrawString($"TỔNG CỘNG: {total.ToString("#,##0")} VNĐ", fontHeader, Brushes.Red, w - margin - e.Graphics.MeasureString($"TỔNG CỘNG: {total.ToString("#,##0")} VNĐ", fontHeader).Width, y);
        }
    }
}