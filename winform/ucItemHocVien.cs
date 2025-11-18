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
       
        public void LoadDanhSachLop(List<LopHocSimpleDTO> dsLop)
        {
            cboLopHoc.DataSource = null; // Reset binding
            cboLopHoc.DataSource = dsLop;
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "IdLopHoc";
            cboLopHoc.SelectedIndex = -1; // Không chọn gì cả lúc đầu
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

            // Cập nhật giao diện Textbox
            UpdateGiaoDienLopDaChon(selectedLop.TenLop);
        }

        // 3. Cập nhật Textbox hiển thị
        private void UpdateGiaoDienLopDaChon(string newClassName)
        {
            if (string.IsNullOrEmpty(txtLopDaChon.Text))
            {
                txtLopDaChon.Text = "- " + newClassName;
            }
            else
            {
                txtLopDaChon.Text += "\r\n- " + newClassName; // Xuống dòng
            }
        }

        // 4. Nút Reset lớp (Xóa làm lại)
        private void BtnResetLop_Click(object sender, EventArgs e)
        {
            _selectedLopIds.Clear();
            txtLopDaChon.Clear();
        }

        // 5. Xuất dữ liệu ra ngoài (cho Form Cha)
        public HocVienDTO GetData()
        {
            return new HocVienDTO
            {
                tenHv = txtTenHV.Text.Trim(),
                ngaySinh = dtpNgaySinh.Value,
                gioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                dsLopId = _selectedLopIds // Trả về list ID đã chọn
            };
        }
    }
}
