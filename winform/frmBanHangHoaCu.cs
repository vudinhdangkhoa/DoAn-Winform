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
using System.Drawing;
using System.Drawing.Printing;

namespace winform
{
    public partial class frmBanHangHoaCu : Form
    {
        public class SanPhamHienThiDTO
        {
            public int IdHocCu { get; set; }
            public string TenHocCu { get; set; }
            public string DonViTinh { get; set; }
            public double GiaBan { get; set; }
            public int SoLuong { get; set; }
            public double GiamGia { get; set; } // Số tiền giảm (VD: 2000)
            public int IdLoaiHocCu { get; set; }
        }

        // Item trong giỏ hàng (Local)
        public class CartItem
        {
            public int IdHocCu { get; set; }
            public string TenHocCu { get; set; }
            public double DonGia { get; set; } // Giá gốc (niêm yết)
            public double TienGiam { get; set; } // Tiền giảm trên 1 SP
            public int SoLuong { get; set; }

            public double ThanhTien => (DonGia - TienGiam) * SoLuong;
        }

        // Payload gửi đi API
        public class BanHoaCuPayload
        {
            public string sdt { get; set; }
            public double TongTien { get; set; } // Tổng tiền gốc
            public double GiamGia { get; set; }  // Tổng tiền giảm
            public int IdNhanVien { get; set; }
            // List các Dictionary <Key=Id, Value=SL>
            public List<Dictionary<string, int>> dsHoaCu { get; set; }
        }

        // --- Biến toàn cục ---
        private List<SanPhamHienThiDTO> _sourceProducts;
        private BindingList<CartItem> _cart;
        private int _currentUserId;
        private List<CartItem> _listInHoaDon; // Lưu danh sách hàng để in
        private string _sdtKhachIn;           // Lưu SĐT khách
        private double _tongTienGocIn;        // Lưu tổng tiền gốc
        private double _tienGiamIn;           // Lưu tiền giảm
        private double _khachCanTraIn;        // Lưu tiền khách trả
        public frmBanHangHoaCu(int userId) // Nhận ID nhân viên khi mở form
        {
            InitializeComponent();
            _currentUserId = userId;

            // 1. CẤU HÌNH QUAN TRỌNG CHO GRID GIỎ HÀNG
            dgvGioHang.AutoGenerateColumns = false; // Tắt tự động tạo cột (Chỉ dùng cột mình định nghĩa)
            dgvGioHang.AllowUserToAddRows = false;  // Không cho thêm dòng trống ở cuối

            // 2. Khởi tạo BindingList
            _cart = new BindingList<CartItem>();

            // 3. Gọi hàm tạo cột TRƯỚC khi gán DataSource
            InitializeGrids();

            // 4. Gán DataSource SAU khi đã cấu hình cột
            dgvGioHang.DataSource = _cart;

            InitializeGrids();
            SetupEvents();
            LoadData();
        }

        // Constructor mặc định để designer không lỗi
        public frmBanHangHoaCu() : this(1) { }

        private void InitializeGrids()
        {
            // 1. Grid Sản Phẩm (Bên trái)
            dgvSanPham.Columns.Clear();
            dgvSanPham.Columns.Add("IdHocCu", "ID");
            dgvSanPham.Columns["IdHocCu"].Visible = false;
            dgvSanPham.Columns.Add("TenHocCu", "Tên Sản Phẩm");
            dgvSanPham.Columns.Add("DonViTinh", "ĐVT");
            dgvSanPham.Columns.Add("GiaBan", "Giá Bán");
            dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns.Add("GiamGia", "Giảm Giá"); // Hiển thị số tiền giảm
            dgvSanPham.Columns["GiamGia"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns.Add("SoLuong", "Tồn");

            dgvGioHang.Columns.Clear();

            // Cột ID (Ẩn)
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdHocCu";
            colId.DataPropertyName = "IdHocCu"; // Map với thuộc tính IdHocCu trong CartItem
            colId.Visible = false;
            dgvGioHang.Columns.Add(colId);

            // Cột Tên
            var colTen = new DataGridViewTextBoxColumn();
            colTen.Name = "TenHocCu";
            colTen.HeaderText = "Tên SP";
            colTen.DataPropertyName = "TenHocCu"; // Map với thuộc tính TenHocCu
            colTen.ReadOnly = true; // Chỉ đọc
            colTen.Width = 150;
            dgvGioHang.Columns.Add(colTen);

            // Cột Số Lượng (CHO PHÉP SỬA)
            var colSL = new DataGridViewTextBoxColumn();
            colSL.Name = "SoLuong";
            colSL.HeaderText = "SL";
            colSL.DataPropertyName = "SoLuong"; // Map với thuộc tính SoLuong
            colSL.Width = 60;
            colSL.ReadOnly = false; // QUAN TRỌNG: Cho phép sửa
                                    // Màu nền hơi khác để biết là sửa được
            colSL.DefaultCellStyle.BackColor = Color.LightYellow;
            dgvGioHang.Columns.Add(colSL);

            // Cột Giá Gốc
            var colGia = new DataGridViewTextBoxColumn();
            colGia.Name = "DonGia";
            colGia.HeaderText = "Giá Gốc";
            colGia.DataPropertyName = "DonGia";
            colGia.DefaultCellStyle.Format = "N0";
            colGia.ReadOnly = true;
            dgvGioHang.Columns.Add(colGia);

            // Cột Thành Tiền
            var colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.Name = "ThanhTien";
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.DataPropertyName = "ThanhTien"; // Map với property ThanhTien (chỉ get)
            colThanhTien.DefaultCellStyle.Format = "N0";
            colThanhTien.ReadOnly = true;
            dgvGioHang.Columns.Add(colThanhTien);
        }

        private void SetupEvents()
        {
            txtSearch.TextChanged += (s, e) => FilterProducts();

            // Double click bên trái để thêm vào giỏ
            dgvSanPham.CellDoubleClick += DgvSanPham_CellDoubleClick;

            // Sửa số lượng bên phải để cập nhật tiền
            dgvGioHang.CellEndEdit += DgvGioHang_CellEndEdit;

            // Nút chức năng
            btnThanhToan.Click += BtnThanhToan_Click;
            btnXoaGioHang.Click += (s, e) => { _cart.Clear(); UpdateTotals(); };
            
        }

        private async void LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(DungChung.getUrl("QLHocCu/GetAllHocCu"));
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<dynamic>(json);

                        // Lấy list hocCus từ JSON
                        _sourceProducts = JsonConvert.DeserializeObject<List<SanPhamHienThiDTO>>(data.hocCus.ToString());

                        FilterProducts(); // Hiển thị lên lưới
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load hàng: " + ex.Message); }
        }

        private void FilterProducts()
        {
            if (_sourceProducts == null) return;

            var filterText = txtSearch.Text.ToLower();
            var displayList = _sourceProducts.Where(p => p.TenHocCu.ToLower().Contains(filterText)).ToList();

            dgvSanPham.Rows.Clear();
            foreach (var item in displayList)
            {
                dgvSanPham.Rows.Add(item.IdHocCu, item.TenHocCu, item.DonViTinh, item.GiaBan, item.GiamGia, item.SoLuong);
            }
        }

        // --- LOGIC GIỎ HÀNG ---

        private void DgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy ID sản phẩm đang chọn
            int id = Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells["IdHocCu"].Value);

            // Tìm trong source gốc để lấy đầy đủ thông tin (bao gồm giá giảm)
            var product = _sourceProducts.FirstOrDefault(p => p.IdHocCu == id);
            if (product == null || product.SoLuong <= 0)
            {
                MessageBox.Show("Sản phẩm này đã hết hàng!");
                return;
            }

            // Kiểm tra đã có trong giỏ chưa
            var itemInCart = _cart.FirstOrDefault(x => x.IdHocCu == id);
            if (itemInCart != null)
            {
                // Có rồi -> Tăng số lượng
                if (itemInCart.SoLuong < product.SoLuong)
                {
                    itemInCart.SoLuong++;
                    dgvGioHang.Refresh(); // Refresh để cập nhật Thành Tiền
                }
                else MessageBox.Show("Không đủ tồn kho!");
            }
            else
            {
                // Chưa có -> Thêm mới
                _cart.Add(new CartItem
                {
                    IdHocCu = product.IdHocCu,
                    TenHocCu = product.TenHocCu,
                    DonGia = product.GiaBan,
                    TienGiam = product.GiamGia, // Lưu ý: Đây là số tiền giảm (VD: 2000)
                    SoLuong = 1
                });
            }
            UpdateTotals();
        }

        private void DgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột đang sửa là cột "SoLuong"
            if (dgvGioHang.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                var row = dgvGioHang.Rows[e.RowIndex];

                // Lấy giá trị mới nhập
                int newSL = 0;
                if (row.Cells["SoLuong"].Value != null)
                {
                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out newSL);
                }

                // Logic kiểm tra tồn kho (nếu cần kỹ hơn)
                // var item = (CartItem)row.DataBoundItem;
                // if (newSL > tonKho) { ... }

                if (newSL <= 0)
                {
                    // Nếu nhập <= 0 thì xóa dòng đó luôn
                    _cart.RemoveAt(e.RowIndex);
                }
                else
                {
                    // Cập nhật lại giao diện để cột Thành Tiền nhảy số mới
                    dgvGioHang.InvalidateRow(e.RowIndex);
                }

                UpdateTotals(); // Tính lại tổng tiền bên dưới
            }
        }

        private void UpdateTotals()
        {
            double tongTienHang = 0; // Tổng giá gốc
            double tongGiamGia = 0;  // Tổng tiền giảm

            foreach (var item in _cart)
            {
                tongTienHang += item.DonGia * item.SoLuong;
                tongGiamGia += item.TienGiam * item.SoLuong;
            }

            double khachCanTra = tongTienHang - tongGiamGia;

            lblTongTienVal.Text = tongTienHang.ToString("N0");
            lblGiamGiaVal.Text = tongGiamGia.ToString("N0");
            lblThanhToanVal.Text = khachCanTra.ToString("N0") + " VNĐ";
        }

        // --- LOGIC THANH TOÁN ---

        private async void BtnThanhToan_Click(object sender, EventArgs e)
        {
            // Validate
            if (_cart.Count == 0) { MessageBox.Show("Giỏ hàng trống!"); return; }
            string sdtKhach = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdtKhach))
            {
                sdtKhach = "0000000000"; // SĐT mặc định cho khách lẻ
            }

            // Chuẩn bị Payload
            var listChiTiet = new List<Dictionary<string, int>>();
            foreach (var item in _cart)
            {
                var dict = new Dictionary<string, int>();
                dict.Add(item.IdHocCu.ToString(), item.SoLuong);
                listChiTiet.Add(dict);
            }

            // Lấy giá trị tiền từ Label (loại bỏ dấu phẩy/chấm)
            double tongTienRaw = double.Parse(lblTongTienVal.Text.Replace(".", "").Replace(",", ""));
            double giamGiaRaw = double.Parse(lblGiamGiaVal.Text.Replace(".", "").Replace(",", ""));

            var payload = new BanHoaCuPayload
            {
                sdt = sdtKhach,
                TongTien = tongTienRaw,
                GiamGia = giamGiaRaw,
                IdNhanVien = _currentUserId,
                dsHoaCu = listChiTiet
            };

            // Gọi API
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(DungChung.getUrl("QLHocCu/BanHoaCu"), content);

                    if (response.IsSuccessStatusCode)
                    {
                        if (MessageBox.Show("Thanh toán thành công! Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // --- CHUẨN BỊ DỮ LIỆU IN ---
                            _listInHoaDon = new List<CartItem>(_cart); // Copy danh sách hiện tại
                            _sdtKhachIn = sdtKhach;
                            _tongTienGocIn = tongTienRaw;
                            _tienGiamIn = giamGiaRaw;
                            _khachCanTraIn = tongTienRaw - giamGiaRaw;

                            // --- GỌI HÀM IN ---
                            InHoaDon();
                        }

                        // Reset Form
                        _cart.Clear();
                        UpdateTotals();
                        txtSDT.Clear();

                        // Reload lại kho
                        LoadData();
                    }
                    else
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Lỗi thanh toán: " + err);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
        }

        private void InHoaDon()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);

                // Tùy chọn: Mở hộp thoại xem trước (Preview)
                PrintPreviewDialog pvd = new PrintPreviewDialog();
                pvd.Document = pd;
                pvd.Width = 600;
                pvd.Height = 800;
                pvd.ShowDialog();

                // Nếu muốn in luôn ra máy in mặc định thì bỏ 3 dòng trên và dùng:
                // pd.Print(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in hóa đơn: " + ex.Message);
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // 1. CẤU HÌNH FONT & LỀ
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);
            Font fontItalic = new Font("Arial", 9, FontStyle.Italic);

            float margin = 20;
            float y = margin;
            float w = e.PageBounds.Width;
            float contentW = w - 2 * margin;

            // 2. VẼ HEADER
            string storeName = "CỬA HÀNG HỌA CỤ KSL";
            string title = "HÓA ĐƠN BÁN LẺ";
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Tên cửa hàng (Căn giữa)
            SizeF sizeStore = e.Graphics.MeasureString(storeName, fontTitle);
            e.Graphics.DrawString(storeName, fontTitle, Brushes.DarkBlue, (w - sizeStore.Width) / 2, y);
            y += 30;

            // Tiêu đề (Căn giữa)
            SizeF sizeTitle = e.Graphics.MeasureString(title, fontHeader);
            e.Graphics.DrawString(title, fontHeader, Brushes.Black, (w - sizeTitle.Width) / 2, y);
            y += 25;

            // Ngày & Khách hàng
            e.Graphics.DrawString($"Ngày: {date}", fontItalic, Brushes.Black, margin, y);
            y += 20;
            e.Graphics.DrawString($"Khách hàng: {_sdtKhachIn}", fontRegular, Brushes.Black, margin, y);
            y += 20;

            // Kẻ dòng ngăn cách
            e.Graphics.DrawLine(Pens.Black, margin, y, w - margin, y);
            y += 5;

            // 3. VẼ TIÊU ĐỀ BẢNG
            // Định nghĩa vị trí các cột (Tương đối)
            float colTen = margin;
            float colSL = margin + 250;
            float colGia = margin + 320;
            float colThanhTien = w - margin - 100; // Căn phải cột tiền

            e.Graphics.DrawString("Tên Hàng", fontHeader, Brushes.Black, colTen, y);
            e.Graphics.DrawString("SL", fontHeader, Brushes.Black, colSL, y);
            e.Graphics.DrawString("Đơn Giá", fontHeader, Brushes.Black, colGia, y);
            e.Graphics.DrawString("Thành Tiền", fontHeader, Brushes.Black, colThanhTien, y);
            y += 20;

            // 4. VẼ DANH SÁCH SẢN PHẨM
            foreach (var item in _listInHoaDon)
            {
                // Tên hàng (nếu dài quá thì cắt bớt)
                string tenHang = item.TenHocCu;
                if (tenHang.Length > 30) tenHang = tenHang.Substring(0, 27) + "...";

                e.Graphics.DrawString(tenHang, fontRegular, Brushes.Black, colTen, y);
                e.Graphics.DrawString(item.SoLuong.ToString(), fontRegular, Brushes.Black, colSL, y);
                e.Graphics.DrawString((item.DonGia - item.TienGiam).ToString("N0"), fontRegular, Brushes.Black, colGia, y);
                e.Graphics.DrawString(item.ThanhTien.ToString("N0"), fontRegular, Brushes.Black, colThanhTien, y);

                y += 25; // Xuống dòng
            }

            y += 10;
            e.Graphics.DrawLine(Pens.Black, margin, y, w - margin, y);
            y += 10;

            // 5. VẼ TỔNG KẾT TIỀN (Căn phải)
            string strTongGoc = $"Tổng tiền hàng: {_tongTienGocIn:N0}";
            string strGiam = $"Giảm giá: -{_tienGiamIn:N0}";
            string strThanhToan = $"THANH TOÁN: {_khachCanTraIn:N0} VNĐ";

            // Vẽ Tổng tiền hàng
            SizeF s1 = e.Graphics.MeasureString(strTongGoc, fontRegular);
            e.Graphics.DrawString(strTongGoc, fontRegular, Brushes.Black, w - margin - s1.Width, y);
            y += 20;

            // Vẽ Giảm giá
            SizeF s2 = e.Graphics.MeasureString(strGiam, fontRegular);
            e.Graphics.DrawString(strGiam, fontRegular, Brushes.Black, w - margin - s2.Width, y);
            y += 25;

            // Vẽ Thanh Toán (To, Đậm)
            SizeF s3 = e.Graphics.MeasureString(strThanhToan, fontTitle);
            e.Graphics.DrawString(strThanhToan, fontTitle, Brushes.Red, w - margin - s3.Width, y);
            y += 40;

            // 6. FOOTER
            string footer = "Cảm ơn quý khách - Hẹn gặp lại!";
            SizeF sF = e.Graphics.MeasureString(footer, fontItalic);
            e.Graphics.DrawString(footer, fontItalic, Brushes.Gray, (w - sF.Width) / 2, y);
        }

    }
}
