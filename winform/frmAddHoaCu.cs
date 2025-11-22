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
    public partial class frmAddHoaCu : Form
    {
        // DTO dùng để hứng danh sách Loại từ API Get
        private class LoaiHocCuDTO
        {
            public int idLoaiHocCu { get; set; }
            public string tenLoai { get; set; }
        }

        // DTO dùng để gửi dữ liệu Add đi
        private class AddHoaCuDTO
        {
            public int idLoaiHocCu { get; set; }
            public string tenHocCu { get; set; }
            public int soLuong { get; set; }
            public string donViTinh { get; set; }
            public double giaBan { get; set; }
        }

        public frmAddHoaCu()
        {
            InitializeComponent();
            LoadLoaiHocCu(); // Load dữ liệu ngay khi khởi tạo

            // Gán sự kiện
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();
        }

        private async void LoadLoaiHocCu()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Gọi API lấy tất cả (vì API GetAllHocCu của bạn trả về cả danh sách loại)
                    var response = await client.GetAsync(DungChung.getUrl("QLHocCu/GetAllHocCu"));

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<dynamic>(json);

                        // Lấy phần 'loaiHocCus' từ JSON trả về
                        var listLoai = JsonConvert.DeserializeObject<List<LoaiHocCuDTO>>(data.loaiHocCus.ToString());

                        // Đổ vào ComboBox
                        cboLoaiHocCu.DataSource = listLoai;
                        cboLoaiHocCu.DisplayMember = "TenLoai";
                        cboLoaiHocCu.ValueMember = "IdLoaiHocCu";
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải danh sách loại họa cụ.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // 1. Validate dữ liệu
            if (string.IsNullOrWhiteSpace(txtTenHocCu.Text))
            {
                MessageBox.Show("Vui lòng nhập tên họa cụ!", "Cảnh báo");
                txtTenHocCu.Focus();
                return;
            }

            if (cboLoaiHocCu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại họa cụ!", "Cảnh báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính!", "Cảnh báo");
                return;
            }

            if (numGiaBan.Value <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0!", "Cảnh báo");
                return;
            }

            // 2. Tạo object DTO
            var newItem = new AddHoaCuDTO
            {
                tenHocCu = txtTenHocCu.Text.Trim(),
                idLoaiHocCu = (int)cboLoaiHocCu.SelectedValue,
                soLuong = (int)numSoLuong.Value,
                donViTinh = txtDonViTinh.Text.Trim(),
                giaBan = (double)numGiaBan.Value
            };

            // 3. Gọi API
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(newItem);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(DungChung.getUrl("QLHocCu/AddHoaCu"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm họa cụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng form sau khi thêm thành công
                    }
                    else
                    {
                        var errContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Thêm thất bại: " + errContent, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}
