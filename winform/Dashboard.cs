using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Dashboard : Form
    {
        private string userRole; // Có thể thay đổi thành "Nhân viên"
        private string username;
        private string userId;
        private Panel activeMenu;
        private Button currentButton;
        private bool _isLogout = false;

        public Dashboard()
        {
            InitializeComponent();

        }

        public Dashboard(string userId, string username, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            this.userRole = userRole;
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
                this.Invoke((MethodInvoker)delegate
                {
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

            loadRoleBasedUI();
        }

        private void loadRoleBasedUI()
        {
            // Ẩn hoặc hiển thị các nút dựa trên vai trò người dùng
            if (userRole == DungChung.adminRole)
            {
                btn_QuanLyHoaCu.Enabled = true;
                btn_QuanLyGiaoVien.Enabled = true;
                btn_QLHocVien.Enabled = true;
                btn_QLKhoaHoc.Enabled = true;
                btn_QLLopHoc.Enabled = true;
                btn_QL_ThuChi.Enabled = true;
                btn_LichHoc.Enabled = true;
                btn_TongQuan.Enabled = true;
            }
            else
            {
                if (userRole == DungChung.nhanVienHocVuRole)
                {
                    btn_QuanLyHoaCu.Enabled = false;
                    btn_QuanLyGiaoVien.Enabled = true;
                    btn_QLHocVien.Enabled = true;
                    btn_QLKhoaHoc.Enabled = true;
                    btn_QLLopHoc.Enabled = true;
                    btn_QL_ThuChi.Enabled = false;
                    btn_LichHoc.Enabled = true;
                    btn_TongQuan.Enabled = true;
                    btn_SaoLuu.Enabled = false;
                    btn_QLNhanVien.Enabled = false;
                    btn_QL_ThuChi.Enabled = false;
                }
                else if (userRole == DungChung.nhanVienKhoRole)
                {
                    btn_QuanLyHoaCu.Enabled = true;
                    btn_QuanLyGiaoVien.Enabled = false;
                    btn_QLHocVien.Enabled = false;
                    btn_QLKhoaHoc.Enabled = false;
                    btn_QLLopHoc.Enabled = false;
                    btn_QL_ThuChi.Enabled = false;
                    btn_LichHoc.Enabled = false;
                    btn_TongQuan.Enabled = true;
                    btn_SaoLuu.Enabled = false;
                    btn_QLNhanVien.Enabled = false;
                    btn_QL_ThuChi.Enabled = false;
                }
            }
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
                _isLogout = true;
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

        private void btn_QLKhoaHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucKhoaHoc ucKhoaHoc = new ucKhoaHoc();
            LoadUserControl(ucKhoaHoc);
        }

        private void btn_QLLopHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQuanLyLopHoc ucLopHoc = new ucQuanLyLopHoc();
            LoadUserControl(ucLopHoc);
        }

        private void btn_QL_ThuChi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQLKhuyenMai ucQLKhuyenMai = new ucQLKhuyenMai();
            LoadUserControl(ucQLKhuyenMai);
        }



        private void btn_QuanLyHoaCu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQuanLyHoaCu ucQLHoaCu = new ucQuanLyHoaCu(int.Parse(userId), username);
            LoadUserControl(ucQLHoaCu);
        }

        private void btn_QuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQuanLyGiaoVien ucQLGiaoVien = new ucQuanLyGiaoVien();
            LoadUserControl(ucQLGiaoVien);
        }

        private void btn_LichHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQuanLyLichHoc ucLichHoc = new ucQuanLyLichHoc();
            LoadUserControl(ucLichHoc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQLThongKe ucThongKe = new ucQLThongKe();
            LoadUserControl(ucThongKe);
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucSaoLuuKhoiPhuc ucSaoLuu = new ucSaoLuuKhoiPhuc();
            LoadUserControl(ucSaoLuu);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogout)
            {
                Application.Exit();
            }
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ucQlNhanVien ucQlNhanVien = new ucQlNhanVien();
            LoadUserControl(ucQlNhanVien);
        }
    }
}