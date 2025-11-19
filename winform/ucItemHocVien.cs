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
    public partial class ucItemHocVien : UserControl
    {
        public ucItemHocVien()
        {
            InitializeComponent();
        }

        public event EventHandler OnDeleteRequest;

        private List<int> _selectedLopIds = new List<int>(); // Lưu ID các lớp đã chọn
        
        // Biến lưu tổng tiền hiện tại của học viên này
        private decimal _currentTotalMoney = 0;

        public void LoadDanhSachLop(List<LopHocSimpleDTO> dsLop)
        {
            if (dsLop == null) return;
            cboLopHoc.DataSource = null;
            cboLopHoc.DataSource = dsLop;

            // Hiển thị tên kèm giá tiền: "Lớp Vẽ - 1.500.000 đ"
            cboLopHoc.DisplayMember = "DisplayText";
            cboLopHoc.ValueMember = "IdLopHoc";
            cboLopHoc.SelectedIndex = -1;
        }

        // 2. Xử lý nút Thêm Lớp (+)
        private void BtnThemLop_Click(object sender, EventArgs e)
        {
            var selectedLop = cboLopHoc.SelectedItem as LopHocSimpleDTO;

            if (selectedLop == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp trước!");
                return;
            }

            // Kiểm tra trùng lặp
            if (_selectedLopIds.Contains(selectedLop.IdLopHoc))
            {
                MessageBox.Show("Học viên đã được thêm vào lớp này rồi!");
                return;
            }

            // Thêm vào danh sách ID
            _selectedLopIds.Add(selectedLop.IdLopHoc);
            _currentTotalMoney += selectedLop.ThanhTien;
            // Cập nhật giao diện Textbox
            UpdateGiaoDienHienThi(selectedLop.TenLop, selectedLop.ThanhTien);
        }

        // 3. Cập nhật Textbox hiển thị
        private void UpdateGiaoDienHienThi(string tenLop, decimal giaTien)
        {
            // Format tiền Việt Nam
            string giaStr = giaTien.ToString("#,##0");

            // Cập nhật List lớp
            if (string.IsNullOrEmpty(txtLopDaChon.Text))
                txtLopDaChon.Text = $"- {tenLop} ({giaStr}đ)";
            else
                txtLopDaChon.Text += $"\r\n- {tenLop} ({giaStr}đ)";

            // Cập nhật Tổng tiền (Chữ Đậm, Đỏ)
            txtTongTien.Text = _currentTotalMoney.ToString("#,##0") + " đ";
        }

        // 4. Nút Reset lớp (Xóa làm lại)
        private void BtnResetLop_Click(object sender, EventArgs e)
        {
            _selectedLopIds.Clear();
            txtLopDaChon.Clear();
            txtTenHV.Clear();
            _currentTotalMoney = 0;
            txtTongTien.Text = "0 đ";

            cboLopHoc.SelectedIndex = -1;
        }

        // 5. Xuất dữ liệu ra ngoài (cho Form Cha)
        public HocVienDTO GetData()
        {
            return new HocVienDTO
            {
                tenHv = txtTenHV.Text.Trim(),
                NgaySinh_Raw = dtpNgaySinh.Value,
                gioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                dsLopId = _selectedLopIds // Trả về list ID đã chọn
            };
        }

        // 6. Xử lý nút Xóa dòng học viên
        private void BtnXoaHV_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện OnDeleteRequest để báo cho Form cha biết
            OnDeleteRequest?.Invoke(this, EventArgs.Empty);
        }
    }
}
