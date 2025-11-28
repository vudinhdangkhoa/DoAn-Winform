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
            // CẤU HÌNH CHẶN NHẬP LIỆU
            this.txtTenHV.KeyPress += TxtTenHV_KeyPress;    // Chặn phím số
            this.txtTenHV.KeyDown += BlockPaste_KeyDown;    // Chặn Paste (Ctrl+V)
        }

        // 1. Chặn nhập số (Im lặng)
        private void TxtTenHV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn phím
            }
        }

        // 2. Chặn Paste (Ctrl+V)
        private void BlockPaste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        // ... (Các phần còn lại giữ nguyên) ...
        public event EventHandler OnDeleteRequest;
        private List<int> _selectedLopIds = new List<int>();
        private decimal _currentTotalMoney = 0;

        public void LoadDanhSachLop(List<LopHocSimpleDTO> dsLop)
        {
            if (dsLop == null) return;
            cboLopHoc.DataSource = null;
            cboLopHoc.DataSource = dsLop;
            cboLopHoc.DisplayMember = "DisplayText";
            cboLopHoc.ValueMember = "IdLopHoc";
            cboLopHoc.SelectedIndex = -1;
        }

        private void BtnThemLop_Click(object sender, EventArgs e)
        {
            var selectedLop = cboLopHoc.SelectedItem as LopHocSimpleDTO;
            if (selectedLop == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp trước!");
                return;
            }
            if (_selectedLopIds.Contains(selectedLop.IdLopHoc))
            {
                MessageBox.Show("Học viên đã được thêm vào lớp này rồi!");
                return;
            }
            _selectedLopIds.Add(selectedLop.IdLopHoc);
            _currentTotalMoney += selectedLop.ThanhTien;
            UpdateGiaoDienHienThi(selectedLop.TenLop, selectedLop.ThanhTien);
        }

        private void UpdateGiaoDienHienThi(string tenLop, decimal giaTien)
        {
            string giaStr = giaTien.ToString("#,##0");
            if (string.IsNullOrEmpty(txtLopDaChon.Text))
                txtLopDaChon.Text = $"- {tenLop} ({giaStr}đ)";
            else
                txtLopDaChon.Text += $"\r\n- {tenLop} ({giaStr}đ)";

            txtTongTien.Text = _currentTotalMoney.ToString("#,##0") + " đ";
        }

        private void BtnResetLop_Click(object sender, EventArgs e)
        {
            _selectedLopIds.Clear();
            txtLopDaChon.Clear();
            _currentTotalMoney = 0;
            txtTongTien.Text = "0 đ";
            cboLopHoc.SelectedIndex = -1;
        }

        public HocVienDTO GetData()
        {
            return new HocVienDTO
            {
                tenHv = txtTenHV.Text.Trim(),
                NgaySinh_Raw = dtpNgaySinh.Value,
                gioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                dsLopId = _selectedLopIds
            };
        }

        private void BtnXoaHV_Click(object sender, EventArgs e)
        {
            OnDeleteRequest?.Invoke(this, EventArgs.Empty);
        }
    }
}