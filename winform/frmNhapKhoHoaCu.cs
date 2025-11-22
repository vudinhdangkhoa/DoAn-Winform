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
    public partial class frmNhapKhoHoaCu : Form
    {
        // Model hứng danh sách Họa Cụ từ API GetAllHocCu
        public class HocCuDTO
        {
            public int IdHocCu { get; set; }      // Map với "idHocCu"
            public string TenHocCu { get; set; }  // Map với "tenHocCu" -> Hiển thị lên Combo
            public int SoLuong { get; set; }      // Map với "soLuong" -> Hiển thị tồn kho
            public string DonViTinh { get; set; } // Map với "donViTinh" -> Hiển thị ĐVT
            public double GiaBan { get; set; }
        }

        // Model hứng danh sách NCC
        public class NhaCungCapDTO
        {
            public int idNhaCungCap { get; set; }
            public string tenNhaCungCap { get; set; }
            public string sdt { get; set; }
        }

        // Model hiển thị trên GridView (Danh sách tạm)
        public class ChiTietNhapLocal
        {
            public int IdHocCu { get; set; }
            public string TenHocCu { get; set; }
            public string DonViTinh { get; set; }
            public double GiaNhap { get; set; }
            public int SoLuong { get; set; }
            public double ThanhTien => GiaNhap * SoLuong; // Tự động tính
        }

        // --- 2. Payload Models (Gửi đi API NhapKho) ---
        public class DSNhapKhoHocCuPayload
        {
            public List<NhapKhoHocCuItem> danhSachNhapKhoHocCu { get; set; }
            public int idNhaCungCap { get; set; }
            public int userId { get; set; }
        }

        public class NhapKhoHocCuItem
        {
            public int idHocCu { get; set; }
            public int soLuong { get; set; }
            public double giaNhap { get; set; }
        }

        // --- Biến toàn cục trong Form ---
        private BindingList<ChiTietNhapLocal> _gioHangNhap; // Dùng BindingList để Grid tự cập nhật
        private List<HocCuDTO> _listHocCuSource; // Lưu source gốc để tra cứu tồn kho
        public int userId;
        public string username;
        public frmNhapKhoHoaCu(int userId,string username)
        {
            InitializeComponent();

            // Khởi tạo danh sách
            _gioHangNhap = new BindingList<ChiTietNhapLocal>();
            dgvNhapKho.DataSource = _gioHangNhap;
            InitializeGridColumns();

            // Gán sự kiện
            this.Load += FrmNhapKhoHoaCu_Load;
            cboHocCu.SelectedIndexChanged += CboHocCu_SelectedIndexChanged;
            btnAddToList.Click += BtnAddToList_Click;
            btnXoaDong.Click += BtnXoaDong_Click;
            btnLuuPhieu.Click += BtnLuuPhieu_Click;
            btnHuy.Click += (s, e) => this.Close();
            btnAddNCC.Click += BtnAddNCC_Click;

            // Gán userId và username
            this.userId = userId;
            this.username = username;
            lblNguoiNhap.Text = $"Người nhập: {username}";
        }

        private void InitializeGridColumns()
        {
            // Định dạng hiển thị tiền tệ và header
            dgvNhapKho.Columns["IdHocCu"].Visible = false;

            dgvNhapKho.Columns["TenHocCu"].HeaderText = "Tên Họa Cụ";
            dgvNhapKho.Columns["TenHocCu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvNhapKho.Columns["DonViTinh"].HeaderText = "ĐVT";
            dgvNhapKho.Columns["DonViTinh"].Width = 80;

            dgvNhapKho.Columns["GiaNhap"].HeaderText = "Giá Nhập";
            dgvNhapKho.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";

            dgvNhapKho.Columns["SoLuong"].HeaderText = "SL";
            dgvNhapKho.Columns["SoLuong"].Width = 60;

            dgvNhapKho.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvNhapKho.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgvNhapKho.Columns["ThanhTien"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        }

        private async void FrmNhapKhoHoaCu_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 1. Load Nhà Cung Cấp
                    var resNCC = await client.GetAsync(DungChung.getUrl("QLHocCu/GetAllNhaCungCap"));
                    if (resNCC.IsSuccessStatusCode)
                    {
                        var jsonNCC = await resNCC.Content.ReadAsStringAsync();
                        var listNCC = JsonConvert.DeserializeObject<List<NhaCungCapDTO>>(jsonNCC);

                        cboNhaCungCap.DataSource = listNCC;
                        cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                        cboNhaCungCap.ValueMember = "IdNhaCungCap";
                    }

                    // 2. Load Họa Cụ
                    var resHC = await client.GetAsync(DungChung.getUrl("QLHocCu/GetAllHocCu"));
                    if (resHC.IsSuccessStatusCode)
                    {
                        var jsonHC = await resHC.Content.ReadAsStringAsync();
                        var dataHC = JsonConvert.DeserializeObject<dynamic>(jsonHC);

                        // API trả về { hocCus: [...], loaiHocCus: [...] } -> Lấy phần hocCus
                        _listHocCuSource = JsonConvert.DeserializeObject<List<HocCuDTO>>(dataHC.hocCus.ToString());

                        cboHocCu.DisplayMember = "TenHocCu"; // Quan trọng: Phải trùng tên biến trong HocCuDTO
                        cboHocCu.ValueMember = "IdHocCu";    // Quan trọng: Phải trùng tên biến trong HocCuDTO
                        cboHocCu.DataSource = _listHocCuSource;
                        cboHocCu.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Hiển thị tồn kho khi chọn Họa cụ
        private void CboHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHocCu.SelectedIndex != -1 && cboHocCu.SelectedItem is HocCuDTO selectedItem)
            {
                Console.WriteLine($"Selected HocCu: {selectedItem.TenHocCu}, SoLuong: {selectedItem.SoLuong}");
                lblTonKho.Text = $"Tồn kho hiện tại: {selectedItem.SoLuong} {selectedItem.DonViTinh}";
                // Gợi ý giá nhập = giá bán (để tham khảo) hoặc 0
                // numGiaNhap.Value = (decimal)selectedItem.GiaBan; 
            }
            else
            {
                lblTonKho.Text = "Tồn kho hiện tại: ---";
            }
        }

        // Thêm vào danh sách tạm (Grid)
        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            // Validate
            if (cboHocCu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn họa cụ!", "Cảnh báo");
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Cảnh báo");
                return;
            }
            if (numGiaNhap.Value <= 0)
            {
                MessageBox.Show("Giá nhập nên lớn hơn 0!", "Cảnh báo");
                // Có thể return hoặc chỉ cảnh báo tùy nghiệp vụ
            }

            var selectedHocCu = (HocCuDTO)cboHocCu.SelectedItem;

            // Kiểm tra xem sản phẩm đã có trong lưới chưa
            var existingItem = _gioHangNhap.FirstOrDefault(x => x.IdHocCu == selectedHocCu.IdHocCu);

            if (existingItem != null)
            {
                // Nếu có rồi -> Cộng dồn số lượng (và cập nhật giá nhập mới nhất nếu muốn)
                existingItem.SoLuong += (int)numSoLuong.Value;
                existingItem.GiaNhap = (double)numGiaNhap.Value; // Update giá mới nhất

                // Hack: Reset binding để Grid cập nhật lại hiển thị thành tiền
                _gioHangNhap.ResetBindings();
            }
            else
            {
                // Chưa có -> Thêm mới
                _gioHangNhap.Add(new ChiTietNhapLocal
                {
                    IdHocCu = selectedHocCu.IdHocCu,
                    TenHocCu = selectedHocCu.TenHocCu,
                    DonViTinh = selectedHocCu.DonViTinh,
                    SoLuong = (int)numSoLuong.Value,
                    GiaNhap = (double)numGiaNhap.Value
                });
            }

            CalculateTotal();
        }

        private void BtnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvNhapKho.CurrentRow != null)
            {
                var item = (ChiTietNhapLocal)dgvNhapKho.CurrentRow.DataBoundItem;
                _gioHangNhap.Remove(item);
                CalculateTotal();
            }
        }

        private void CalculateTotal()
        {
            double total = _gioHangNhap.Sum(x => x.ThanhTien);
            lblTongTienValue.Text = string.Format("{0:N0} VNĐ", total);
        }

        // Lưu phiếu nhập xuống Server
        private async void BtnLuuPhieu_Click(object sender, EventArgs e)
        {
            // 1. Validate tổng thể
            if (_gioHangNhap.Count == 0)
            {
                MessageBox.Show("Danh sách nhập kho đang trống!", "Cảnh báo");
                return;
            }
            if (cboNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp!", "Cảnh báo");
                return;
            }

            // 2. Chuẩn bị dữ liệu Payload
            // LƯU Ý: Bạn cần thay thế '1' bằng biến ID người dùng đăng nhập thực tế (VD: DungChung.CurrentUser.Id)
            int currentUserId = userId;
           

            var payload = new DSNhapKhoHocCuPayload
            {
                userId = currentUserId,
                idNhaCungCap = (int)cboNhaCungCap.SelectedValue,
                danhSachNhapKhoHocCu = _gioHangNhap.Select(x => new NhapKhoHocCuItem
                {
                    idHocCu = x.IdHocCu,
                    soLuong = x.SoLuong,
                    giaNhap = x.GiaNhap
                }).ToList()
            };

            // 3. Gọi API
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(DungChung.getUrl("QLHocCu/NhapKhoHocCu"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form để nhập tiếp
                        _gioHangNhap.Clear();
                        CalculateTotal();
                        numSoLuong.Value = 1;
                        numGiaNhap.Value = 0;
                        cboHocCu.SelectedIndex = -1;

                        // Reload lại dữ liệu Họa Cụ để cập nhật số lượng tồn kho mới
                        await LoadData();
                    }
                    else
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Lỗi nhập kho: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void BtnAddNCC_Click(object sender, EventArgs e)
        {
            // Mở form thêm NCC nhỏ (Nếu bạn chưa làm thì có thể để trống hoặc messagebox)
            // frmAddNhaCungCap f = new frmAddNhaCungCap();
            // f.ShowDialog();
            // LoadData(); // Reload lại CBO sau khi thêm
            MessageBox.Show("Tính năng thêm NCC nhanh đang phát triển.");
        }
    }
}
