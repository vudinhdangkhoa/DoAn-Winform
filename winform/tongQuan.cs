using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class tongQuan : UserControl
    {
        public tongQuan()
        {
            InitializeComponent();
            this.flpLopHocSapKhaiGiang.SizeChanged += FlpLopHocSapKhaiGiang_SizeChanged;
        }

        // Helper để setup giao diện cho 4 cái Card giống nhau
        private void SetupCard(Guna2Panel pnl, Label lblTitle, Label lblValue, Guna2Button btnIcon, string title, string value, Color themeColor)
        {
            pnl.BorderRadius = 15;
            pnl.FillColor = System.Drawing.Color.White;
            pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl.Margin = new System.Windows.Forms.Padding(5);
            // Đổ bóng
            pnl.ShadowDecoration.Color = System.Drawing.Color.Silver;
            pnl.ShadowDecoration.Enabled = true;
            pnl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);

            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(lblValue);
            pnl.Controls.Add(btnIcon);

            // Icon tròn (Dùng Button làm giả icon nếu chưa có ảnh)
            btnIcon.BorderRadius = 20; // Tròn
            btnIcon.DisabledState.FillColor = themeColor;
            btnIcon.Enabled = false; // Chỉ để hiển thị
            btnIcon.FillColor = themeColor;
            btnIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnIcon.ForeColor = System.Drawing.Color.White;
            btnIcon.Location = new System.Drawing.Point(140, 30); // Căn phải
            btnIcon.Size = new System.Drawing.Size(40, 40);
            // Nếu bạn có ảnh, thêm dòng: btnIcon.Image = ...; 

            // Title
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.Gray;
            lblTitle.Location = new System.Drawing.Point(15, 25);
            lblTitle.Text = title;

            // Value
            lblValue.AutoSize = true;
            lblValue.BackColor = System.Drawing.Color.Transparent;
            lblValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblValue.Location = new System.Drawing.Point(12, 50);
            lblValue.Text = value;
        }

        private async void tongQuan_Load(object sender, EventArgs e)
        {
            lblSoLuongKhoaHoc.Text = "...";
            lblSoLuongHocVien.Text = "...";
            lblSoLuongGiaoVien.Text = "...";
            lblDoanhThuThang.Text = "...";
            var data = await DungChung.GetDataTongQuan("Dashboard/GetThongTinDashBoard");
            if (data != null)
            {
                Console.WriteLine(data);
                this.Invoke((MethodInvoker)delegate
                {
                    lblSoLuongGiaoVien.Text = data.soLuongGiaoVien.ToString();
                    lblSoLuongHocVien.Text = data.soLuongHocVien.ToString();
                    lblSoLuongKhoaHoc.Text = data.soLuongKhoaHoc.ToString();
                    lblDoanhThuThang.Text = String.Format("{0:0,0}", data.doanhThuThang) + " VND";
                });

            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblSoLuongKhoaHoc.Text = "0";
                    lblSoLuongHocVien.Text = "0";
                    lblSoLuongGiaoVien.Text = "0";
                    lblDoanhThuThang.Text = "0 VND";
                });

            }

            GetSoLuongHocVienMoiTrong6Thang();
            GetLopHocItem();
        }

        private async void GetSoLuongHocVienMoiTrong6Thang()
        {
            try
            {
                var data = await DungChung.GetSoLuongHocVienMoiTrong6Thang();

                if (data != null)
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        chart_HocVienMoi.Series["HocVienMoi"].Points.Clear();
                        chart_HocVienMoi.Titles.Clear();
                        chart_HocVienMoi.Titles.Add("Số lượng học viên mới trong 6 tháng gần nhất");
                        foreach (var item in data)
                        {
                            string month = item.month.ToString();
                            int count = (int)item.count;

                            chart_HocVienMoi.Series["HocVienMoi"].Points.AddXY(month, count);
                        }
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private async void GetLopHocItem()
        {

            try
            {
                var data= await DungChung.GetLopHocItem();
                if(data != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        flpLopHocSapKhaiGiang.Controls.Clear();
                        foreach(var lop in data)
                        {
                            string tenLopHoc = Convert.ToString(lop.tenLopHoc) ?? "N/A";
                            string khoaHoc = Convert.ToString(lop.khoaHoc) ?? "N/A";
                            string giaoVien = "N/A";
                            if (lop.giaoVien != null)
                            {
                                try
                                {
                                    // Nếu giaoVien là mảng, nối các phần tử bằng dấu phẩy
                                    var giaoVienArray = ((Newtonsoft.Json.Linq.JArray)lop.giaoVien).ToObject<string[]>();
                                    giaoVien = string.Join(", ", giaoVienArray);
                                }
                                catch
                                {
                                    // Fallback nếu không parse được
                                    giaoVien = Convert.ToString(lop.giaoVien) ?? "N/A";
                                }
                            }
                            int soLuongHv = Convert.ToInt32(lop.soLuongHv);
                            int soLuongToiDa = Convert.ToInt32(lop.soLuongToiDa);
                           
                            var item = new LopHocItem(tenLopHoc, khoaHoc, giaoVien, soLuongHv, soLuongToiDa);
                            item.Width = flpLopHocSapKhaiGiang.ClientSize.Width - 25;
                            flpLopHocSapKhaiGiang.Controls.Add(item);

                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }

        }

        // Hàm này sẽ tự động chỉnh lại độ rộng của tất cả các item bên trong
        private void FlpLopHocSapKhaiGiang_SizeChanged(object sender, EventArgs e)
        {
            // Tạm dừng vẽ để tránh bị nháy hình (Flicker)
            flpLopHocSapKhaiGiang.SuspendLayout();

            // Tính toán chiều rộng mới
            // ClientSize.Width: Chiều rộng lọt lòng (không tính viền)
            // Trừ đi 25: Để chừa chỗ cho thanh cuộn dọc (Scrollbar) không bị che mất nội dung
            int newWidth = flpLopHocSapKhaiGiang.ClientSize.Width - 25;

            foreach (Control c in flpLopHocSapKhaiGiang.Controls)
            {
                c.Width = newWidth;
            }

            // Cho phép vẽ lại giao diện
            flpLopHocSapKhaiGiang.ResumeLayout();
        }
    }
}
