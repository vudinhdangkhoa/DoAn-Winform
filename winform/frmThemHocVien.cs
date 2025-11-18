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
        }

        private List<LopHocSimpleDTO> _danhSachLopHoc;
        private dynamic dataKhoaHoc;
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
                dataKhoaHoc = UCQuanLyHocVien.GetKhoaHoc();

                foreach (var kh in dataKhoaHoc)
                {
                    foreach (var lh in kh.lopHocs)
                    {
                        _danhSachLopHoc.Add(new LopHocSimpleDTO
                        {
                            IdLopHoc = (int)lh.idLopHoc,
                            TenLop = (string)lh.tenLopHoc
                        });
                    }
                }
                if (_danhSachLopHoc == null || _danhSachLopHoc.Count == 0)
                {
                    _danhSachLopHoc = new List<LopHocSimpleDTO>
                    {
                        new LopHocSimpleDTO { IdLopHoc = 1, TenLop = "Lớp Vẽ Cơ Bản (K1)" },
                        new LopHocSimpleDTO { IdLopHoc = 2, TenLop = "Lớp Màu Nước (K2)" },
                        new LopHocSimpleDTO { IdLopHoc = 3, TenLop = "Lớp Điêu Khắc" },
                        new LopHocSimpleDTO { IdLopHoc = 4, TenLop = "Lớp Sơn Dầu" }
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

            // Chỉnh độ rộng cho đẹp (trừ đi thanh cuộn của Panel)
            ucItem.Width = flowPanelHocViens.ClientSize.Width - 30;

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

            // B. Gom dữ liệu
            var requestData = new AddHocVienRequest
            {
                tenPH = txtTenPH.Text.Trim(),
                sdt = txtSdtPH.Text.Trim(),
                email = txtEmailPH.Text.Trim(),
                ngaySinhPH = dtpNgaySinhPH.Value
                // DSHocVien sẽ được add ở dưới
            };

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

                    requestData.DSHocVien.Add(hv);
                }
            }

            // D. Gửi lên Server
            await CallApiAddHocVien(requestData);
        }

        private async Task CallApiAddHocVien(AddHocVienRequest data)
        {
            btnLuu.Enabled = false;
            btnLuu.Text = "Đang lưu...";

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7000/"); // Đổi Port của bạn ở đây

                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("api/User/AddHocVien", content); // Endpoint

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        this.DialogResult = DialogResult.OK; // Báo cho form cha biết là OK
                        this.Close();
                    }
                    else
                    {
                        string err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Lỗi Server: " + err);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                btnLuu.Enabled = true;
                btnLuu.Text = "LƯU DỮ LIỆU";
            }
        }


    }
}
