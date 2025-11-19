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

            // Gán sự kiện
            this.Load += FrmThemHocVien_Load;
            this.btnThemDong.Click += BtnThemDong_Click;
            this.btnLuu.Click += BtnLuu_Click;
            this.btnHuy.Click += (s, e) => this.Close();
            this.txtSdtPH.KeyPress += TxtSdtPH_KeyPress;
        }

        private List<LopHocSimpleDTO> _danhSachLopHoc=new List<LopHocSimpleDTO>();
        public dynamic dataKhoaHoc;

        // Biến lưu dữ liệu để in (Được gán khi bấm nút Lưu)
        private AddHocVienRequest _dataToPrint;
        private decimal _totalAmountToPrint;

        // 1. KHI FORM LOAD: Tải danh sách lớp
        private async void FrmThemHocVien_Load(object sender, EventArgs e)
        {
            await LoadDataLopHoc();
            // Thêm sẵn 1 dòng đầu tiên cho người dùng nhập luôn
            ThemDongHocVien();
        }

        private async Task LoadDataLopHoc()
        {
            try
            {

                // --------------------------------------------------------
                dataKhoaHoc =await UCQuanLyHocVien.GetKhoaHoc();

                if (dataKhoaHoc != null)
                {

                    foreach (var kh in dataKhoaHoc)
                    {
                        // Kiểm tra null và count an toàn
                        if (kh.lopHocs == null || kh.lopHocs.Count == 0) continue;

                        // Lấy thông tin tài chính từ KHÓA HỌC
                        decimal hocPhi = (decimal)(kh.hocPhi ?? 0);
                        decimal giamGia = (decimal)(kh.giamGia ?? 0);

                        foreach (var lh in kh.lopHocs)
                        {
                            _danhSachLopHoc.Add(new LopHocSimpleDTO
                            {
                                IdLopHoc = (int)lh.idLopHoc,
                                TenLop = (string)lh.tenLopHoc,
                                // Gán học phí của khóa cho lớp
                                HocPhi = hocPhi,
                                GiamGia = giamGia
                            });
                        }
                    }


                }
                else
                {
                    _danhSachLopHoc = new List<LopHocSimpleDTO>
                    {
                        new LopHocSimpleDTO { IdLopHoc = 1, TenLop = "Lớp Vẽ Cơ Bản (K1)",HocPhi=1600000,GiamGia=0 },
                        new LopHocSimpleDTO { IdLopHoc = 2, TenLop = "Lớp Màu Nước (K2)",HocPhi=1600000,GiamGia=0 },
                        new LopHocSimpleDTO { IdLopHoc = 3, TenLop = "Lớp Điêu Khắc",HocPhi=1600000,GiamGia=0 },
                        new LopHocSimpleDTO {IdLopHoc = 4, TenLop = "Lớp Sơn Dầu", HocPhi = 1600000, GiamGia = 0}
                    };
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        // 2. CHỨC NĂNG: THÊM DÒNG HỌC VIÊN MỚI
        private void BtnThemDong_Click(object sender, EventArgs e)
        {
            ThemDongHocVien();
        }

        private void ThemDongHocVien()
        {
            // Tạo mới 1 UserControl
            var ucItem = new ucItemHocVien();

            // Nạp danh sách lớp vào cho nó
            if (_danhSachLopHoc != null)
            {
                ucItem.LoadDanhSachLop(_danhSachLopHoc);
            }

            // 1. Set chiều rộng ban đầu cho khớp
            ucItem.Width = flowPanelHocViens.ClientSize.Width - 25;

            // 2. Quan trọng: Anchor Left và Right để khi Panel cha co giãn, nó cố gắng bám theo
            // (Tuy nhiên trong FlowLayout, Anchor đôi khi không nhạy bằng code Resize ở bước 2, nên ta dùng cả hai cho chắc)
            //ucItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            // Xử lý sự kiện khi nút Xóa trên UserControl được bấm
            ucItem.OnDeleteRequest += (source, args) =>
            {
                // Chỉ cho xóa nếu còn nhiều hơn 1 dòng (tùy chọn)
                if (flowPanelHocViens.Controls.Count > 1)
                {
                    flowPanelHocViens.Controls.Remove(ucItem);
                    ucItem.Dispose(); // Giải phóng bộ nhớ
                }
                else
                {
                    MessageBox.Show("Cần ít nhất 1 học viên trong danh sách!");
                }
            };

            // Thêm vào Panel
            flowPanelHocViens.Controls.Add(ucItem);

            // Cuộn xuống cuối cùng để thấy dòng mới
            flowPanelHocViens.ScrollControlIntoView(ucItem);
        }

        // 3. CHỨC NĂNG: LƯU (GỬI API)
        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // A. Validate Phụ Huynh
            if (string.IsNullOrWhiteSpace(txtTenPH.Text) || string.IsNullOrWhiteSpace(txtSdtPH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và SĐT Phụ huynh!");
                return;
            }
          

            // A.1. VALIDATE SỐ ĐIỆN THOẠI
            if (!Helper.IsValidPhoneNumber(txtSdtPH.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! (Phải bắt đầu bằng 0 và có 10 chữ số)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdtPH.Focus();
                txtSdtPH.SelectAll(); // Bôi đen để người dùng sửa nhanh
                return;
            }

            // A.2. VALIDATE EMAIL
            // (Nếu email không bắt buộc thì thêm điều kiện: !string.IsNullOrEmpty(...) && !IsValidEmail(...))
            if (!Helper.IsValidEmail(txtEmailPH.Text))
            {
                MessageBox.Show("Email không đúng định dạng! (Ví dụ: example@gmail.com)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailPH.Focus();
                txtEmailPH.SelectAll();
                return;
            }

            // B. Gom dữ liệu
            var requestData = new AddHocVienRequest
            {
                tenPH = txtTenPH.Text.Trim(),
                sdt = txtSdtPH.Text.Trim(),
                email = txtEmailPH.Text.Trim(),
                NgaySinhPH_Raw = dtpNgaySinhPH.Value,
                gioiTinh= cboGioiTinhPH.SelectedItem?.ToString(),

                // DSHocVien sẽ được add ở dưới
            };
            decimal grandTotal = 0;
            // C. Duyệt qua danh sách UserControl để lấy dữ liệu từng bé
            foreach (Control c in flowPanelHocViens.Controls)
            {
                if (c is ucItemHocVien item)
                {
                    HocVienDTO hv = item.GetData();

                    // Validate học viên
                    if (string.IsNullOrWhiteSpace(hv.tenHv))
                    {
                        MessageBox.Show("Tên học viên không được để trống!");
                        return; // Dừng lại ngay
                    }
                    // Tính tổng tiền
                    foreach (var idLop in hv.dsLopId)
                    {
                        var lop = _danhSachLopHoc.FirstOrDefault(x => x.IdLopHoc == idLop);
                        if (lop != null) grandTotal += lop.ThanhTien;
                    }
                    requestData.dsHocVien.Add(hv);
                }
            }

            _dataToPrint = requestData;
            _totalAmountToPrint = grandTotal;

            // D. Gửi lên Server
            await CallApiAddHocVien(requestData);
        }

        private async Task CallApiAddHocVien(AddHocVienRequest data)
        {
            btnLuu.Enabled = false;
            btnLuu.Text = "Đang lưu...";

            try
            {
                dynamic result = await UCQuanLyHocVien.AddHocVien(data);
                if (result != null) {
                
                    Console.WriteLine("Thêm học viên thành công");
                    InHoaDon();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                btnLuu.Enabled = true;
                btnLuu.Text = "LƯU DỮ LIỆU";
                this.Close();
            }
        }

        private void flowPanelHocViens_SizeChanged(object sender, EventArgs e)
        {
            flowPanelHocViens.SuspendLayout();

            foreach (Control c in flowPanelHocViens.Controls)
            {
                // ClientSize.Width: Là chiều rộng bên trong (trừ đi viền)
                // Trừ đi 25: Để chừa chỗ cho thanh cuộn dọc (Scrollbar) không bị che mất nội dung
                c.Width = flowPanelHocViens.ClientSize.Width - 25;
            }

            // Cho phép vẽ lại giao diện
            flowPanelHocViens.ResumeLayout();
        }

        private void TxtSdtPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số (IsDigit) và phím điều khiển (như Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn không cho nhập
            }
        }

        //heler in report
        private void InHoaDon()
        {
            // 1. Khởi tạo đối tượng in
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);

            // 2. Mở hộp thoại xem trước (Print Preview)
            PrintPreviewDialog pvd = new PrintPreviewDialog();
            pvd.Document = pd;

            // Phóng to form xem trước cho dễ nhìn
            pvd.Width = 800;
            pvd.Height = 600;
            pvd.ShowDialog();

            // Nếu muốn in thẳng ra máy in mặc định không cần xem trước thì dùng:
            // pd.Print(); 
        }

        // Hàm này đóng vai trò "Vẽ" nội dung lên tờ giấy
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // A. CẤU HÌNH FONT VÀ LỀ
            Font fontHeader = new Font("Arial", 16, FontStyle.Bold);
            Font fontSubHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);

            float margin = 50;
            float y = margin; // Tọa độ Y bắt đầu vẽ (từ trên xuống)
            float pageWidth = e.PageBounds.Width;
            float contentWidth = pageWidth - 2 * margin;

            // B. VẼ HEADER (Tên trung tâm)
            string centerName = "TRUNG TÂM MỸ THUẬT SÁNG TẠO";
            string title = "HÓA ĐƠN THANH TOÁN";
            string date = $"Ngày: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";

            // Vẽ căn giữa
            SizeF sizeCenter = e.Graphics.MeasureString(centerName, fontHeader);
            e.Graphics.DrawString(centerName, fontHeader, Brushes.Blue, (pageWidth - sizeCenter.Width) / 2, y);
            y += 30;

            SizeF sizeTitle = e.Graphics.MeasureString(title, fontSubHeader);
            e.Graphics.DrawString(title, fontSubHeader, Brushes.Black, (pageWidth - sizeTitle.Width) / 2, y);
            y += 25;

            e.Graphics.DrawString(date, fontRegular, Brushes.Black, margin, y);
            y += 30;

            // Kẻ đường gạch ngang
            e.Graphics.DrawLine(Pens.Black, margin, y, pageWidth - margin, y);
            y += 10;

            // C. THÔNG TIN PHỤ HUYNH
            e.Graphics.DrawString($"Phụ huynh: {_dataToPrint.tenPH}", fontBold, Brushes.Black, margin, y);
            y += 20;
            e.Graphics.DrawString($"SĐT: {_dataToPrint.sdt}", fontRegular, Brushes.Black, margin, y);
            y += 20;
            e.Graphics.DrawString($"Email: {_dataToPrint.email}", fontRegular, Brushes.Black, margin, y);
            y += 30;

            // D. BẢNG CHI TIẾT
            // Header bảng
            float col1 = margin;             // Cột Tên HV
            float col2 = margin + 200;       // Cột Lớp
            float col3 = pageWidth - margin - 100; // Cột Thành Tiền (Căn phải)

            e.Graphics.DrawString("Học viên", fontBold, Brushes.Black, col1, y);
            e.Graphics.DrawString("Lớp học", fontBold, Brushes.Black, col2, y);
            e.Graphics.DrawString("Thành tiền", fontBold, Brushes.Black, col3, y);
            y += 20;
            e.Graphics.DrawLine(Pens.Black, margin, y, pageWidth - margin, y); // Gạch chân header
            y += 10;

            // Duyệt danh sách để in từng dòng
            decimal totalCheck = 0;

            foreach (var hv in _dataToPrint.dsHocVien)
            {
                e.Graphics.DrawString($"- {hv.tenHv}", fontBold, Brushes.Black, col1, y);
                float startY = y; // Lưu vị trí Y của tên học viên

                foreach (var lopId in hv.dsLopId)
                {
                    // Tìm thông tin lớp trong danh sách _danhSachLopHoc đã load từ đầu form
                    // Lưu ý: _danhSachLopHoc là biến toàn cục chứa List<LopHocSimpleDTO>
                    var lopInfo = _danhSachLopHoc.FirstOrDefault(l => l.IdLopHoc == lopId);

                    if (lopInfo != null)
                    {
                        string tenLop = lopInfo.TenLop;
                        // Nếu tên lớp quá dài, có thể cần xử lý cắt chuỗi (đơn giản ở đây mình in thẳng)
                        if (tenLop.Length > 30) tenLop = tenLop.Substring(0, 27) + "...";

                        decimal thanhTien = lopInfo.ThanhTien;
                        totalCheck += thanhTien;

                        e.Graphics.DrawString(tenLop, fontRegular, Brushes.Black, col2, y);
                        e.Graphics.DrawString(thanhTien.ToString("#,##0"), fontRegular, Brushes.Black, col3, y);
                        y += 20;
                    }
                }
                // Nếu học viên đăng ký nhiều lớp, cộng thêm khoảng cách để tách biệt các học viên
                y += 5;
            }

            y += 10;
            e.Graphics.DrawLine(Pens.Black, margin, y, pageWidth - margin, y); // Kẻ kết thúc bảng
            y += 10;

            // E. TỔNG TIỀN
            string tongTienStr = $"TỔNG CỘNG: {_totalAmountToPrint.ToString("#,##0")} VNĐ";
            SizeF sizeTong = e.Graphics.MeasureString(tongTienStr, fontHeader);

            // In căn phải
            e.Graphics.DrawString(tongTienStr, fontHeader, Brushes.Red, pageWidth - margin - sizeTong.Width, y);
            y += 40;

            // F. FOOTER
            string footer = "Cảm ơn quý khách và hẹn gặp lại!";
            SizeF sizeFooter = e.Graphics.MeasureString(footer, fontRegular);
            e.Graphics.DrawString(footer, fontRegular, Brushes.Gray, (pageWidth - sizeFooter.Width) / 2, y);
        }
    }
}
