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
    public partial class frmQLChuyenMon : Form
    {
        public class ChuyenMonDTO
        {
            public int IdChuyenMon { get; set; }
            public string TenChuyenMon { get; set; }
            public string MoTa { get; set; }
            public string HinhAnh { get; set; }
        }

        private int _selectedId = -1;
        private string _currentImagePath = null;

        public frmQLChuyenMon()
        {
            InitializeComponent();
            InitializeGrid();

            this.Load += (s, e) => LoadData();
            btnThem.Click += BtnThem_Click;
            btnLuu.Click += BtnLuu_Click;
            btnChonAnh.Click += BtnChonAnh_Click;
            dgvChuyenMon.CellClick += DgvChuyenMon_CellClick;
        }

        private void InitializeGrid()
        {
            dgvChuyenMon.AutoGenerateColumns = false;
            dgvChuyenMon.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "IdChuyenMon", Visible = false });
            dgvChuyenMon.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ten", DataPropertyName = "TenChuyenMon", HeaderText = "Tên Chuyên Môn", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }

        private async void LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllChuyenMon"));
                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<List<ChuyenMonDTO>>(json);
                        dgvChuyenMon.DataSource = list;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load dữ liệu: " + ex.Message); }
        }

        private void DgvChuyenMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (ChuyenMonDTO)dgvChuyenMon.Rows[e.RowIndex].DataBoundItem;
            _selectedId = item.IdChuyenMon;

            // Fill data
            txtTenChuyenMon.Text = item.TenChuyenMon;
            txtMoTa.Text = item.MoTa;

            // Load Image
            if (!string.IsNullOrEmpty(item.HinhAnh))
            {
                string url = DungChung.BaseUrlImage + item.HinhAnh; // Lưu ý chỉnh BaseURL cho đúng thư mục ảnh
                try { picHinhAnh.Load(url); } catch { picHinhAnh.Image = null; }
            }
            else picHinhAnh.Image = null;

            _currentImagePath = null;
            btnLuu.Text = "CẬP NHẬT";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            _selectedId = -1;
            _currentImagePath = null;
            txtTenChuyenMon.Clear();
            txtMoTa.Clear();
            picHinhAnh.Image = null;
            btnLuu.Text = "LƯU MỚI";
            txtTenChuyenMon.Focus();
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" };
            if (op.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(op.FileName);
                _currentImagePath = op.FileName;
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenChuyenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chuyên môn.");
                return;
            }

            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StringContent(txtTenChuyenMon.Text), "tenChuyenMon");
                content.Add(new StringContent(txtMoTa.Text), "moTa");

                if (_currentImagePath != null)
                {
                    var fs = File.OpenRead(_currentImagePath);
                    var streamContent = new StreamContent(fs);
                    streamContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                    content.Add(streamContent, "hinhAnh", Path.GetFileName(_currentImagePath));
                }

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response;
                        if (_selectedId == -1)
                        {
                            response = await client.PostAsync(DungChung.getUrl("KhoaHoc/CreateChuyenMon"), content);
                        }
                        else
                        {
                            response = await client.PutAsync(DungChung.getUrl($"KhoaHoc/UpdateChuyenMon/{_selectedId}"), content);
                        }

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Thành công!");
                            LoadData();
                            BtnThem_Click(null, null); // Reset form
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
