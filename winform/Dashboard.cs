using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Dashboard : Form
    {
        private string userRole = "Admin"; // Có thể thay đổi thành "Nhân viên"
        private string username = "Admin";
        private string userId;
        private Panel activeMenu;
        private Button currentButton;

        public Dashboard()
        {
            InitializeComponent();

        }

        public Dashboard(string userId)
        {
            InitializeComponent();
           this.userId = userId;
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            // Cập nhật thông tin user
            var InforUser = await DungChung.GetInfoStaff(int.Parse(userId));
            //
            //this.Invoke((MethodInvoker)delegate
            //{
            //    lblWelcome.Text = $"Xin chào, {InforUser.tenNv}";
            //    lblUserRole.Text = userRole == InforUser.quyen;
            //});
            if (InforUser != null)
            {
                Console.WriteLine(InforUser);
                this.Invoke((MethodInvoker)delegate {
                    lblWelcome.Text = $"Xin chào, {InforUser.tenNv}";
                    lblUserRole.Text = InforUser.quyen.ToString(); // Dùng InforUser.quyen
                });
            }
            else
            {
                MessageBox.Show("Không thể tải thông tin người dùng từ máy chủ.");
            }
            // Chúng ta sẽ xử lý việc hiển thị nội dung mặc định ở đây sau
            btn_TongQuan.PerformClick();
        }

      

        private void LoadUserControl(UserControl uc)
        {
            if (contentPanel != null)
            {
                contentPanel.Controls.Clear();
            } // Xóa control cũ
            uc.Dock = DockStyle.Fill;      // Lấp đầy contentPanel
            contentPanel.Controls.Add(uc); // Thêm user control mới vào
        }

        // Đặt hàm này vào trong Dashboard.cs
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                // Hủy kích hoạt button cũ
                if (currentButton != null && currentButton != (Button)senderBtn)
                {
                    currentButton.BackColor = Color.FromArgb(44, 62, 80); // Màu nền mặc định của sidebar
                    currentButton.ForeColor = Color.White;
                    // Bạn có thể thêm các style khác ở đây
                    currentButton.Enabled = true;
                }

                // Kích hoạt button mới được nhấn
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(52, 152, 219); // Màu xanh làm điểm nhấn
                currentButton.ForeColor = Color.White;
                currentButton.Enabled = false;
                
            }
        }

       

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw header shadow
            Rectangle rect = new Rectangle(0, headerPanel.Height - 2, headerPanel.Width, 2);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                Color.FromArgb(30, 0, 0, 0), Color.Transparent, 90f))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Quay về form đăng nhập (thay Form1 bằng form login của bạn)
                // Form1 loginForm = new Form1();
                // loginForm.Show();
                this.Close();
            }
        }

        private void btn_TongQuan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            tongQuan tongQuan = new tongQuan();
            LoadUserControl(tongQuan);
        }

        private void btn_QLHocVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQuanLyHocVien ucQuanLyHocVien = new ucQuanLyHocVien();
            LoadUserControl(ucQuanLyHocVien);
        }
    }
}