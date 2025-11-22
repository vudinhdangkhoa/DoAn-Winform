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
    public partial class frmAddLoaiHocCu : Form
    {
        public frmAddLoaiHocCu()
        {
            InitializeComponent();
            // Gán sự kiện
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();

            // Focus vào ô nhập liệu ngay khi mở
            this.Load += (s, e) => txtTenLoai.Focus();
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // 1. Validate
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại họa cụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            // 2. Tạo payload gửi đi
            // API yêu cầu class AddLoaiHocCu { public string tenLoai { get; set; } }
            var newLoai = new
            {
                tenLoai = txtTenLoai.Text.Trim()
            };

            // 3. Gọi API
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(newLoai);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // URL: QLHoaCu/AddLoaiHocCu
                    var response = await client.PostAsync(DungChung.getUrl("QLHocCu/AddLoaiHocCu"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm loại họa cụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng form để quay lại màn hình chính
                    }
                    else
                    {
                        var errorMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Thêm thất bại: " + errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hệ thống: " + ex.Message, "Lỗi Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
