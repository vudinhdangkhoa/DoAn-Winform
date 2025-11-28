using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class frmChiTietKhoaHoc : Form
    {
        public class KhoaHocChiTietDTO
        {
            public int IdKhoaHoc { get; set; }
            public string TenKhoaHoc { get; set; }
            public string MoTa { get; set; }
            public string MucTieu { get; set; }
            public double HocPhi { get; set; }
            public int SoLuongBuoi { get; set; }
            public string HinhAnh { get; set; } // URL ảnh
            public string LoTrinh { get; set; }
            public int IdChuyenMon { get; set; } // Để select combobox
        }

        private int _idKhoaHoc; // -1: Thêm, >0: Sửa
        private string _currentImagePath = null; // Lưu đường dẫn file ảnh mới chọn
        private KhoaHocChiTietDTO _currentData; // Lưu data cũ để binding

        public frmChiTietKhoaHoc(int idKhoaHoc = -1)
        {
            InitializeComponent();
            _idKhoaHoc = idKhoaHoc;

            if (_idKhoaHoc == -1) lblTitle.Text = "THÊM KHÓA HỌC MỚI";
            else lblTitle.Text = "CẬP NHẬT KHÓA HỌC";

            // Events
            this.Load += FrmChiTietKhoaHoc_Load;
            btnChonAnh.Click += BtnChonAnh_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();
        }

        private async void FrmChiTietKhoaHoc_Load(object sender, EventArgs e)
        {
            await LoadChuyenMon(); // Load combo trước

            if (_idKhoaHoc > 0)
            {
                await LoadDataDetail(); // Load dữ liệu khóa học nếu là sửa
            }
            else
            {
                // Khi thêm mới, load mã khóa học tiếp theo
                await LoadNextKhoaHocId();
                numSoBuoi.ResetText();
                numHocPhi.ResetText();
            }

        }

        private async System.Threading.Tasks.Task LoadChuyenMon()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllChuyenMon"));
                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        var listCM = JsonConvert.DeserializeObject<List<ucKhoaHoc.ChuyenMonDTO>>(json);
                        cboChuyenMon.DataSource = listCM;
                        cboChuyenMon.DisplayMember = "TenChuyenMon";
                        cboChuyenMon.ValueMember = "IdChuyenMon";
                    }
                }
            }
            catch { }
        }

        private async System.Threading.Tasks.Task LoadDataDetail()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(DungChung.getUrl($"KhoaHoc/GetKhoaHocById/{_idKhoaHoc}"));

                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        _currentData = JsonConvert.DeserializeObject<KhoaHocChiTietDTO>(json);

                        // Binding Data
                        txtMaKhoaHoc.Text = _currentData.IdKhoaHoc.ToString(); // Hiển thị mã khóa học
                        txtTenKhoaHoc.Text = _currentData.TenKhoaHoc;
                        numHocPhi.Value = (decimal)_currentData.HocPhi;
                        numSoBuoi.Value = _currentData.SoLuongBuoi;
                        cboChuyenMon.SelectedValue = _currentData.IdChuyenMon;

                        rtbMoTa.Text = _currentData.MoTa;
                        rtbMucTieu.Text = _currentData.MucTieu;
                        rtbLoTrinh.Text = _currentData.LoTrinh;

                        // Load ảnh
                        if (!string.IsNullOrEmpty(_currentData.HinhAnh))
                        {
                            string urlInfo = DungChung.BaseUrlImage + _currentData.HinhAnh;
                            try { picHinhAnh.Load(urlInfo); } catch { }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private async System.Threading.Tasks.Task LoadNextKhoaHocId()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetNextKhoaHocId"));
                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<dynamic>(json);
                        txtMaKhoaHoc.Text = result.nextId.ToString();
                    }
                }
            }
            catch
            {
                txtMaKhoaHoc.Text = "";
                txtMaKhoaHoc.PlaceholderText = "Mã sẽ được tạo tự động";
            }
        }
        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(op.FileName);
                _currentImagePath = op.FileName;
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtTenKhoaHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khóa học.");
                return;
            }

            using (var content = new MultipartFormDataContent())
            {
                // Add text fields
                content.Add(new StringContent(txtTenKhoaHoc.Text), "TenKhoaHoc");
                content.Add(new StringContent(numHocPhi.Value.ToString()), "HocPhi");
                content.Add(new StringContent(numSoBuoi.Value.ToString()), "SoLuongBuoi");
                content.Add(new StringContent(cboChuyenMon.SelectedValue.ToString()), "IdChuyenMon");
                content.Add(new StringContent(rtbMoTa.Text), "MoTa");
                content.Add(new StringContent(rtbMucTieu.Text), "MucTieu");
                content.Add(new StringContent(rtbLoTrinh.Text), "LoTrinh");

                // Add File
                if (_currentImagePath != null)
                {
                    var fs = File.OpenRead(_currentImagePath);
                    var streamContent = new StreamContent(fs);
                    streamContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                    content.Add(streamContent, "HinhAnh", Path.GetFileName(_currentImagePath));
                }

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response;
                        if (_idKhoaHoc == -1)
                        {
                            // Create
                            response = await client.PostAsync(DungChung.getUrl("KhoaHoc/CreateKhoaHoc"), content);
                        }
                        else
                        {
                            // Update
                            response = await client.PutAsync(DungChung.getUrl($"KhoaHoc/UpdateKhoaHoc/{_idKhoaHoc}"), content);
                        }

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Lưu thành công!");
                            this.DialogResult = DialogResult.OK; // Báo cho form cha biết để reload
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại: " + await response.Content.ReadAsStringAsync());
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
    }
}
