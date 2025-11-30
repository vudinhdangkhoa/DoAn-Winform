using Guna.Charts.WinForms;
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
using ClosedXML.Excel; // Nhớ cài NuGet ClosedXML nếu chưa có
using System.IO;

namespace winform
{
    public partial class ucQLThongKe : UserControl
    {
        public class BaoCaoDoanhThuDTO
        {
            public double TongDoanhThuThuan { get; set; } // Tên mới
            public double TongChiPhiNhap { get; set; }    // Tên mới
            public double LoiNhuanRong { get; set; }      // Tên mới
            public List<DoanhThuTheoThangDTO> ChiTietTheoThang { get; set; }
        }

        public class DoanhThuTheoThangDTO
        {
            public string ThangNam { get; set; }
            public int Thang { get; set; }
            public int Nam { get; set; }
            public double TienHocPhi { get; set; }
            public double TienHoaCu { get; set; }
            public double TienNhapHang { get; set; } // Thêm trường này
            public double LoiNhuan { get; set; }     // Thêm trường này
        }

        public class BaoCaoHoaCuDTO
        {
            public List<TopBanChayDTO> TopBanChay { get; set; }
            public List<CanhBaoTonKhoDTO> SapHetHang { get; set; }
        }
        public class TopBanChayDTO { public string TenHocCu { get; set; } public int SoLuongBan { get; set; } }
        public class CanhBaoTonKhoDTO { public string TenHocCu { get; set; } public string DonViTinh { get; set; } public int TonKho { get; set; } }

        public class BaoCaoDaoTaoDTO
        {
            public int TongHocVien { get; set; }
            public int TongLopDangMo { get; set; }
            public List<HocVienTheoKhoaDTO> PhanBoHocVien { get; set; }
            public List<TyLeLapDayDTO> TyLeLapDay { get; set; }
        }
        public class HocVienTheoKhoaDTO { public string TenKhoaHoc { get; set; } public int SoLuongHocVien { get; set; } }
        public class TyLeLapDayDTO { public string TenLop { get; set; } public int SiSoHienTai { get; set; } public int SiSoToiDa { get; set; } public double PhanTram { get; set; } }


        public ucQLThongKe()
        {
            InitializeComponent();

            // Setup mặc định: Từ đầu năm đến nay
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpDenNgay.Value = DateTime.Now;

            btnXemBaoCao.Click += (s, e) => LoadAllData();
            // Sự kiện chuyển tab để load dữ liệu tab đó (tối ưu)
            tabMain.SelectedIndexChanged += (s, e) => LoadDataForCurrentTab();

            // Config Grid
            ConfigGridTonKho();
            ConfigGridLopHoc();
        }

        private void ConfigGridTonKho()
        {
            dgvTonKho.Columns.Clear();
            dgvTonKho.Columns.Add("TenHocCu", "Tên Họa Cụ");
            dgvTonKho.Columns.Add("DonViTinh", "ĐVT");
            dgvTonKho.Columns.Add("TonKho", "Tồn Kho");
            // Tô đỏ dòng nào < 5
            dgvTonKho.CellFormatting += (s, e) =>
            {
                if (dgvTonKho.Columns[e.ColumnIndex].Name == "TonKho" && e.Value != null)
                {
                    if (int.Parse(e.Value.ToString()) <= 5)
                        dgvTonKho.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                }
            };
        }

        private void ConfigGridLopHoc()
        {
            dgvLopHoc.Columns.Clear();
            dgvLopHoc.Columns.Add("TenLop", "Tên Lớp");
            dgvLopHoc.Columns.Add("SiSo", "Sĩ Số");
            dgvLopHoc.Columns.Add("PhanTram", "Lấp Đầy %");
        }

        private void LoadAllData() { LoadDataForCurrentTab(); }

        private void LoadDataForCurrentTab()
        {
            if (tabMain.SelectedTab == tabDoanhThu) LoadDoanhThu();
            else if (tabMain.SelectedTab == tabHoaCu) LoadHoaCu();
            else if (tabMain.SelectedTab == tabDaoTao) LoadDaoTao();
        }

        // --- TAB 1: DOANH THU ---
        private async void LoadDoanhThu()
        {
            string url = DungChung.getUrl($"QLThongKe/DoanhThu?tuNgay={dtpTuNgay.Value:yyyy-MM-dd}&denNgay={dtpDenNgay.Value:yyyy-MM-dd}");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(url);
                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<BaoCaoDoanhThuDTO>(json);

                        // --- 1. CẬP NHẬT CARDS ---
                        pnlCards.Controls.Clear();

                        // Card 1: Doanh Thu Thuần (Tổng thu - Giảm giá)
                        pnlCards.Controls.Add(CreateCard("DOANH THU THUẦN", data.TongDoanhThuThuan, Color.Navy, Color.Blue, "💰"));

                        // Card 2: Chi Phí Nhập
                        pnlCards.Controls.Add(CreateCard("CHI PHÍ NHẬP", data.TongChiPhiNhap, Color.DarkRed, Color.Red, "📉"));

                        // Card 3: Lợi Nhuận Ròng
                        Color colorProfit = data.LoiNhuanRong >= 0 ? Color.Green : Color.Red;
                        pnlCards.Controls.Add(CreateCard("LỢI NHUẬN RÒNG", data.LoiNhuanRong, colorProfit, ControlPaint.Light(colorProfit), "📈"));


                        // --- 2. CẬP NHẬT BIỂU ĐỒ LINE (THU vs CHI) ---
                        chartDoanhThu.Datasets.Clear();

                        // Dataset: Tổng Thu
                        var dsThu = new GunaSplineDataset();
                        dsThu.Label = "Tổng Thu";
                        dsThu.PointRadius = 3;
                        dsThu.BorderColor = Color.Green; // Màu xanh lá cho thu

                        // Dataset: Tổng Chi (Nhập hàng)
                        var dsChi = new GunaSplineDataset();
                        dsChi.Label = "Chi Phí Nhập";
                        dsChi.PointRadius = 3;
                        dsChi.BorderColor = Color.Red;   // Màu đỏ cho chi

                        foreach (var item in data.ChiTietTheoThang)
                        {
                            // Tổng thu tháng = Học phí + Họa cụ
                            dsThu.DataPoints.Add(item.ThangNam, item.TienHocPhi + item.TienHoaCu);
                            // Tổng chi tháng = Tiền nhập hàng
                            dsChi.DataPoints.Add(item.ThangNam, item.TienNhapHang);
                        }

                        chartDoanhThu.Datasets.Add(dsThu);
                        chartDoanhThu.Datasets.Add(dsChi);
                        chartDoanhThu.Update();


                        // --- 3. CẬP NHẬT BIỂU ĐỒ PIE (CƠ CẤU NGUỒN THU) ---
                        // Vẫn giữ nguyên cơ cấu thu từ đâu (Học phí vs Họa cụ)
                        chartCoCau.Datasets.Clear();
                        var dsPie = new GunaDoughnutDataset();

                        // Tính tổng lại từ chi tiết tháng để vẽ Pie (vì API trả về tổng đã trừ chi phí, ở đây ta muốn xem tỷ trọng nguồn thu)
                        double sumHocPhi = data.ChiTietTheoThang.Sum(x => x.TienHocPhi);
                        double sumHoaCu = data.ChiTietTheoThang.Sum(x => x.TienHoaCu);

                        dsPie.DataPoints.Add("Học Phí", sumHocPhi);
                        dsPie.DataPoints.Add("Bán Họa Cụ", sumHoaCu);

                        chartCoCau.Datasets.Add(dsPie);
                        chartCoCau.Update();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load doanh thu: " + ex.Message); }
        }

        private Panel CreateCard(string title, double value, Color colorStart, Color colorEnd, string iconSymbol = "$")
        {
            // 1. Panel chính (Dùng Gradient)
            Guna.UI2.WinForms.Guna2GradientPanel p = new Guna.UI2.WinForms.Guna2GradientPanel();
            p.Size = new Size(280, 80); // Tăng kích thước cho thoáng
            p.FillColor = colorStart;
            p.FillColor2 = colorEnd;
            p.BorderRadius = 15;
            p.Margin = new Padding(10); // Cách xa nhau ra chút
            p.ShadowDecoration.Enabled = true;
            p.ShadowDecoration.Depth = 10;

            // 2. Icon (Dùng GunaButton tròn làm nền icon)
            Guna.UI2.WinForms.Guna2Button btnIcon = new Guna.UI2.WinForms.Guna2Button();
            btnIcon.Size = new Size(50, 50);
            btnIcon.Location = new Point(15, 25);
            btnIcon.BorderRadius = 25; // Hình tròn
            btnIcon.FillColor = Color.FromArgb(80, 255, 255, 255); // Màu trắng trong suốt
            btnIcon.Text = iconSymbol; // Ký hiệu ($, %, #...)
            btnIcon.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            btnIcon.ForeColor = Color.White;

            // 3. Label Tiêu đề (Nhỏ, phía trên)
            Label lblTitle = new Label();
            lblTitle.Text = title.ToUpper();
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblTitle.Location = new Point(80, 20);
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;

            // 4. Label Giá trị (To, Đậm, Chính giữa)
            Label lblValue = new Label();
            lblValue.Text = value.ToString("N0") + " đ"; // Format phân cách hàng nghìn
            lblValue.ForeColor = Color.White;
            lblValue.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblValue.Location = new Point(80, 45);
            lblValue.AutoSize = true;
            lblValue.BackColor = Color.Transparent;

            // Add vào Panel
            p.Controls.Add(btnIcon);
            p.Controls.Add(lblTitle);
            p.Controls.Add(lblValue);

            return p;
        }

        // --- TAB 2: HỌA CỤ ---
        private async void LoadHoaCu()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(DungChung.getUrl("QLThongKe/HoaCu"));
                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<BaoCaoHoaCuDTO>(json);

                        // 1. Chart Top Ban Chay
                        chartTopBanChay.Datasets.Clear();
                        var dsBar = new GunaHorizontalBarDataset();
                        dsBar.Label = "Số lượng đã bán";
                        foreach (var item in data.TopBanChay)
                        {
                            dsBar.DataPoints.Add(item.TenHocCu, item.SoLuongBan);
                        }
                        chartTopBanChay.Datasets.Add(dsBar);
                        chartTopBanChay.Update();

                        // 2. Grid Canh Bao Ton Kho
                        dgvTonKho.Rows.Clear();
                        foreach (var item in data.SapHetHang)
                        {
                            dgvTonKho.Rows.Add(item.TenHocCu, item.DonViTinh, item.TonKho);
                        }
                    }
                }
            }
            catch { }
        }

        // --- TAB 3: ĐÀO TẠO ---
        private async void LoadDaoTao()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.GetAsync(DungChung.getUrl("QLThongKe/DaoTao"));
                    if (res.IsSuccessStatusCode)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<BaoCaoDaoTaoDTO>(json);

                        // 1. Chart Hoc Vien
                        chartHocVien.Datasets.Clear();
                        var dsCol = new GunaBarDataset();
                        dsCol.Label = "Học viên đang học";
                        foreach (var item in data.PhanBoHocVien)
                        {
                            dsCol.DataPoints.Add(item.TenKhoaHoc, item.SoLuongHocVien);
                        }
                        chartHocVien.Datasets.Add(dsCol);
                        chartHocVien.Update();

                        // 2. Grid Lop Hoc
                        dgvLopHoc.Rows.Clear();
                        foreach (var item in data.TyLeLapDay)
                        {
                            dgvLopHoc.Rows.Add(item.TenLop, $"{item.SiSoHienTai}/{item.SiSoToiDa}", item.PhanTram + "%");
                        }
                    }
                }
            }
            catch { }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Logic điều hướng dựa trên Tab đang chọn
            if (tabMain.SelectedTab == tabDoanhThu)
            {
                ExportDoanhThu();
            }
            else if (tabMain.SelectedTab == tabHoaCu)
            {
                ExportHoaCu();
            }
            else if (tabMain.SelectedTab == tabDaoTao)
            {
                ExportDaoTao();
            }
        }

        private async void ExportDoanhThu()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string url = DungChung.getUrl($"QLThongKe/DoanhThu?tuNgay={dtpTuNgay.Value:yyyy-MM-dd}&denNgay={dtpDenNgay.Value:yyyy-MM-dd}");

                    using (HttpClient client = new HttpClient())
                    {
                        var res = await client.GetAsync(url);
                        if (res.IsSuccessStatusCode)
                        {
                            var json = await res.Content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<BaoCaoDoanhThuDTO>(json);

                            using (var wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add("Doanh Thu & Lợi Nhuận");

                                // --- Header Tổng quan ---
                                ws.Cell(1, 1).Value = "BÁO CÁO TÀI CHÍNH TỔNG HỢP";
                                ws.Range("A1:E1").Merge().Style.Font.FontSize = 14;
                                ws.Range("A1:E1").Style.Font.Bold = true;

                                ws.Cell(2, 1).Value = $"Giai đoạn: {dtpTuNgay.Value:dd/MM/yyyy} - {dtpDenNgay.Value:dd/MM/yyyy}";

                                // Block Tổng hợp
                                ws.Cell(4, 1).Value = "Doanh Thu Thuần:";
                                ws.Cell(4, 2).Value = data.TongDoanhThuThuan;

                                ws.Cell(5, 1).Value = "Chi Phí Nhập Hàng:";
                                ws.Cell(5, 2).Value = data.TongChiPhiNhap;

                                ws.Cell(6, 1).Value = "LỢI NHUẬN RÒNG:";
                                ws.Cell(6, 2).Value = data.LoiNhuanRong;
                                ws.Cell(6, 2).Style.Font.Bold = true;
                                if (data.LoiNhuanRong < 0) ws.Cell(6, 2).Style.Font.FontColor = XLColor.Red;

                                ws.Range("B4:B6").Style.NumberFormat.Format = "#,##0";

                                // --- Bảng chi tiết ---
                                int row = 8;
                                // Header Bảng
                                ws.Cell(row, 1).Value = "Tháng/Năm";
                                ws.Cell(row, 2).Value = "Thu Học Phí";
                                ws.Cell(row, 3).Value = "Thu Họa Cụ";
                                ws.Cell(row, 4).Value = "Chi Nhập Hàng";
                                ws.Cell(row, 5).Value = "Lợi Nhuận";

                                // Style Header
                                var rngHead = ws.Range(row, 1, row, 5);
                                rngHead.Style.Fill.BackgroundColor = XLColor.Navy;
                                rngHead.Style.Font.FontColor = XLColor.White;
                                rngHead.Style.Font.Bold = true;

                                row++;
                                foreach (var item in data.ChiTietTheoThang)
                                {
                                    ws.Cell(row, 1).Value = item.ThangNam;
                                    ws.Cell(row, 2).Value = item.TienHocPhi;
                                    ws.Cell(row, 3).Value = item.TienHoaCu;
                                    ws.Cell(row, 4).Value = item.TienNhapHang;
                                    ws.Cell(row, 5).Value = item.LoiNhuan;

                                    // Tô đỏ nếu lỗ
                                    if (item.LoiNhuan < 0) ws.Cell(row, 5).Style.Font.FontColor = XLColor.Red;

                                    row++;
                                }

                                // Format cột tiền
                                ws.Range(9, 2, row - 1, 5).Style.NumberFormat.Format = "#,##0";
                                ws.Columns().AdjustToContents();

                                wb.SaveAs(sfd.FileName);
                                MessageBox.Show("Xuất Excel thành công!");
                                System.Diagnostics.Process.Start(sfd.FileName);
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xuất file: " + ex.Message); }
            }
        }

        private async void ExportHoaCu()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.FileName = $"BaoCaoKhoHoaCu_{DateTime.Now:yyyyMMdd}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var res = await client.GetAsync(DungChung.getUrl("QLThongKe/HoaCu"));
                        if (res.IsSuccessStatusCode)
                        {
                            var json = await res.Content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<BaoCaoHoaCuDTO>(json);

                            using (var wb = new XLWorkbook())
                            {
                                // --- SHEET 1: SẮP HẾT HÀNG ---
                                var ws1 = wb.Worksheets.Add("Cảnh Báo Tồn Kho");
                                ws1.Cell(1, 1).Value = "DANH SÁCH HỌA CỤ SẮP HẾT HÀNG (<10)";
                                ws1.Range("A1:C1").Merge().Style.Font.Bold = true;

                                ws1.Cell(3, 1).Value = "Tên Họa Cụ";
                                ws1.Cell(3, 2).Value = "ĐVT";
                                ws1.Cell(3, 3).Value = "Tồn Kho";
                                ws1.Range("A3:C3").Style.Fill.BackgroundColor = XLColor.Red; // Màu đỏ cảnh báo
                                ws1.Range("A3:C3").Style.Font.FontColor = XLColor.White;

                                int r1 = 4;
                                foreach (var item in data.SapHetHang)
                                {
                                    ws1.Cell(r1, 1).Value = item.TenHocCu;
                                    ws1.Cell(r1, 2).Value = item.DonViTinh;
                                    ws1.Cell(r1, 3).Value = item.TonKho;
                                    r1++;
                                }
                                ws1.Columns().AdjustToContents();

                                // --- SHEET 2: BÁN CHẠY ---
                                var ws2 = wb.Worksheets.Add("Top Bán Chạy");
                                ws2.Cell(1, 1).Value = "TOP 5 HỌA CỤ BÁN CHẠY NHẤT";
                                ws2.Range("A1:B1").Merge().Style.Font.Bold = true;

                                ws2.Cell(3, 1).Value = "Tên Họa Cụ";
                                ws2.Cell(3, 2).Value = "Số Lượng Đã Bán";
                                ws2.Range("A3:B3").Style.Fill.BackgroundColor = XLColor.Green;
                                ws2.Range("A3:B3").Style.Font.FontColor = XLColor.White;

                                int r2 = 4;
                                foreach (var item in data.TopBanChay)
                                {
                                    ws2.Cell(r2, 1).Value = item.TenHocCu;
                                    ws2.Cell(r2, 2).Value = item.SoLuongBan;
                                    r2++;
                                }
                                ws2.Columns().AdjustToContents();

                                wb.SaveAs(sfd.FileName);
                                MessageBox.Show("Xuất Excel thành công!");

                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private async void ExportDaoTao()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.FileName = $"BaoCaoDaoTao_{DateTime.Now:yyyyMMdd}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var res = await client.GetAsync(DungChung.getUrl("QLThongKe/DaoTao"));
                        if (res.IsSuccessStatusCode)
                        {
                            var json = await res.Content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<BaoCaoDaoTaoDTO>(json);

                            using (var wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add("Tình Trạng Lớp Học");

                                // Tổng quan
                                ws.Cell(1, 1).Value = "Tổng số học viên:";
                                ws.Cell(1, 2).Value = data.TongHocVien;
                                ws.Cell(2, 1).Value = "Số lớp đang mở:";
                                ws.Cell(2, 2).Value = data.TongLopDangMo;

                                // Bảng chi tiết
                                int row = 4;
                                ws.Cell(row, 1).Value = "Tên Lớp";
                                ws.Cell(row, 2).Value = "Sĩ Số Hiện Tại";
                                ws.Cell(row, 3).Value = "Sĩ Số Tối Đa";
                                ws.Cell(row, 4).Value = "Tỷ Lệ Lấp Đầy (%)";

                                ws.Range(row, 1, row, 4).Style.Fill.BackgroundColor = XLColor.MediumSeaGreen;
                                ws.Range(row, 1, row, 4).Style.Font.FontColor = XLColor.White;

                                row++;
                                foreach (var lop in data.TyLeLapDay)
                                {
                                    ws.Cell(row, 1).Value = lop.TenLop;
                                    ws.Cell(row, 2).Value = lop.SiSoHienTai;
                                    ws.Cell(row, 3).Value = lop.SiSoToiDa;
                                    ws.Cell(row, 4).Value = lop.PhanTram;

                                    // Highlight nếu lớp vắng (< 30%)
                                    if (lop.PhanTram < 30)
                                        ws.Cell(row, 4).Style.Font.FontColor = XLColor.Red;

                                    row++;
                                }

                                ws.Columns().AdjustToContents();
                                wb.SaveAs(sfd.FileName);
                                MessageBox.Show("Xuất Excel thành công!");

                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
    }
}
