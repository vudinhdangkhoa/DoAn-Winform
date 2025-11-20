using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class DanhNhap : Form
    {
        public DanhNhap()
        {
            InitializeComponent();
            // Không cần gọi các hàm Setup... cũ nữa vì Guna đã lo hết rồi
        }

        // Giữ nguyên logic đăng nhập của bạn, chỉ chỉnh sửa thuộc tính màu sắc cho đúng với Guna
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validate đầu vào
            // Guna tự xử lý placeholder, text sẽ rỗng khi chưa nhập gì
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 2. Xử lý UI khi đang gọi API
            btnLogin.Enabled = false;
            btnLogin.Text = "ĐANG XỬ LÝ...";
            btnLogin.FillColor = Color.FromArgb(149, 165, 166); // Guna dùng FillColor thay vì BackColor

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Bypass DevTunnels warning
                    client.DefaultRequestHeaders.Add("ngrok-skip-browser-warning", "true");
                    client.DefaultRequestHeaders.Add("X-Tunnel-Skip-Anti-Phishing-Page", "true");

                    var loginData = new
                    {
                        mail = txtUsername.Text.Trim(),
                        matkhau = txtPassword.Text.Trim()
                    };

                    string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(loginData);
                    var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                    string url = DungChung.getUrl("XacThuc/DangNhap");

                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (string.IsNullOrWhiteSpace(responseString) || responseString.Trim().StartsWith("<"))
                    {
                        MessageBox.Show("Lỗi kết nối Server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var jObject = JObject.Parse(responseString);

                    if (response.IsSuccessStatusCode)
                    {
                        string status = jObject["status"]?.ToString();
                        string userId = jObject["userId"]?.ToString();

                        if (status == "staff")
                        {
                            this.Hide();
                            Dashboard dashboard = new Dashboard(userId);
                            dashboard.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không có quyền truy cập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        string msg = jObject["message"]?.ToString() ?? "Đăng nhập thất bại";
                        MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "ĐĂNG NHẬP";
                btnLogin.FillColor = Color.FromArgb(52, 152, 219); // Trả về màu xanh gốc
            }
        }
    }
}
