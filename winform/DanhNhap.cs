using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace winform
{
    public partial class DanhNhap : Form
    {
        // Import cho hiệu ứng shadow
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public DanhNhap()
        {
            InitializeComponent();
            
            // Thiết lập placeholder text
            SetupPlaceholders();
            
            // Thiết lập hiệu ứng bo tròn
            SetupRoundedCorners();
            
            // Thiết lập hiệu ứng hover cho button
            SetupButtonEffects();
            
            // Thiết lập border cho textbox
            SetupTextBoxBorders();
        }

        private void SetupPlaceholders()
        {
            // Thiết lập placeholder cho username
            txtUsername.Text = "Nhập email của bạn";
            txtUsername.ForeColor = Color.Silver;
            txtUsername.Enter += txt_Enter;
            txtUsername.Leave += txt_Leave;

            // Thiết lập placeholder cho password
            txtPassword.Text = "Nhập mật khẩu";
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Enter += txt_Enter;
            txtPassword.Leave += txt_Leave;
        }

        private void SetupRoundedCorners()
        {
            // Bo tròn các góc cho textbox và button
            txtUsername.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUsername.Width, txtUsername.Height, 10, 10));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 10, 10));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 15, 15));
        }

        private void SetupButtonEffects()
        {
            // Hiệu ứng hover cho button
            btnLogin.MouseEnter += (sender, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(46, 134, 193);
                btnLogin.Cursor = Cursors.Hand;
            };

            btnLogin.MouseLeave += (sender, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            };

            btnLogin.MouseDown += (sender, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            };

            btnLogin.MouseUp += (sender, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(46, 134, 193);
            };
        }

        private void SetupTextBoxBorders()
        {
            // Thêm border và shadow cho textbox
            txtUsername.Paint += TextBox_Paint;
            txtPassword.Paint += TextBox_Paint;
            
            txtUsername.MouseEnter += TextBox_MouseEnter;
            txtUsername.MouseLeave += TextBox_MouseLeave;
            txtPassword.MouseEnter += TextBox_MouseEnter;
            txtPassword.MouseLeave += TextBox_MouseLeave;
        }

        private void TextBox_Paint(object sender, PaintEventArgs e)
        {
            TextBox txt = sender as TextBox;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ border với màu nhạt
            using (Pen borderPen = new Pen(Color.FromArgb(189, 195, 199), 2))
            {
                Rectangle rect = new Rectangle(0, 0, txt.Width - 1, txt.Height - 1);
                using (GraphicsPath path = GetRoundedPath(rect, 10))
                {
                    g.DrawPath(borderPen, path);
                }
            }
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Invalidate(); // Vẽ lại để thay đổi màu border
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Invalidate(); // Vẽ lại để trở về màu border ban đầu
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Vẽ gradient background cho panel login
            Rectangle gradientRect = new Rectangle(450, 0, 450, 600);
            using (LinearGradientBrush brush = new LinearGradientBrush(gradientRect, 
                Color.FromArgb(248, 249, 250), Color.FromArgb(236, 240, 241), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, gradientRect);
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            // Nếu text là placeholder
            if (txt.Text == "Nhập email của bạn" || txt.Text == "Nhập mật khẩu")
            {
                txt.Text = "";
                txt.ForeColor = Color.FromArgb(74, 74, 74); // Đổi chữ thành màu đen
                if (txt == txtPassword)
                {
                    txt.PasswordChar = '●'; // Hiện dấu ● cho ô mật khẩu
                }
            }

            // Hiệu ứng focus - thay đổi màu border
            txt.BackColor = Color.White;
            txt.Invalidate();
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt == txtUsername)
                {
                    txt.Text = "Nhập email của bạn";
                }
                if (txt == txtPassword)
                {
                    txt.Text = "Nhập mật khẩu";
                    txt.PasswordChar = '\0'; // Bỏ dấu ● để thấy chữ placeholder
                }
                txt.ForeColor = Color.Silver; // Đổi chữ thành màu xám mờ
            }

            // Trở về màu background bình thường
            txt.BackColor = Color.White;
            txt.Invalidate();
        }

        // Thêm "async" vào chữ ký của hàm
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // --- BƯỚC 1: VALIDATE DỮ LIỆU ĐẦU VÀO ---
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Nhập email của bạn")
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus(); // Đưa con trỏ chuột vào ô username
                return; // Dừng thực thi
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus(); // Đưa con trỏ chuột vào ô password
                return; // Dừng thực thi
            }

            // --- BƯỚC 2: GỌI API BẰNG ASYNC/AWAIT (Không làm treo UI) ---
            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "ĐANG XỬ LÝ...";
                btnLogin.BackColor = Color.FromArgb(149, 165, 166); // Màu xám khi disabled

                HttpClient client = new HttpClient();
                var values = new
                {
                    mail = txtUsername.Text,
                    matkhau = txtPassword.Text
                };

                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(values), System.Text.Encoding.UTF8, "application/json");
                string url = DungChung.getUrl("XacThuc/DangNhap");

                // Sử dụng await để chờ kết quả mà không block UI
                var response = await client.PostAsync(url, content);
                var contentString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var ketqua = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(contentString);

                    // API trả về status "staff" chứ không phải "Admin"
                    if (ketqua.status == "staff")
                    {
                        // --- BƯỚC 3: XỬ LÝ KHI ĐĂNG NHẬP THÀNH CÔNG ---
                        this.Hide(); // Ẩn form hiện tại đi
                        Console.WriteLine(ketqua.userId);
                        string userId= ketqua.userId;
                        Dashboard dashboard = new Dashboard(userId);
                        dashboard.ShowDialog(); // Hiển thị form mới, code sẽ dừng ở đây
                        this.Close(); // Sau khi dashboard đóng, form đăng nhập sẽ tự đóng theo
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không có quyền truy cập vào hệ thống này.", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Cố gắng đọc message lỗi từ API để hiển thị cho thân thiện
                    var errorResult = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(contentString);
                    string errorMessage = errorResult.message ?? contentString;
                    MessageBox.Show("Đăng nhập thất bại! " + errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Bắt các lỗi khác như không có mạng, server không phản hồi...
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "ĐĂNG NHẬP";
                btnLogin.BackColor = Color.FromArgb(52, 152, 219); // Trở về màu ban đầu
            }
        }
    }
}
