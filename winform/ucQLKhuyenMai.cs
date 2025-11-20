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
    public partial class ucQLKhuyenMai : UserControl
    {
        private class SimpleItem { public int Id { get; set; } public string Ten { get; set; } }

        private List<SimpleItem> _listKhoaHoc = new List<SimpleItem>
        {
            new SimpleItem { Id = 1, Ten = "Mỹ thuật căn bản" },
            new SimpleItem { Id = 2, Ten = "Sơn dầu nâng cao" }
        };

        private List<SimpleItem> _listHocCu = new List<SimpleItem>
        {
            new SimpleItem { Id = 1, Ten = "Bộ cọ vẽ" },
            new SimpleItem { Id = 2, Ten = "Màu Acrylic" }
        };

        public ucQLKhuyenMai()
        {
            InitializeComponent();
            SetupEvents();
            InitializeGridColumns();
        }

        private void SetupEvents()
        {
            // Sự kiện khi thay đổi Loại (Khóa học <-> Họa cụ)
            cboTargetType.SelectedIndexChanged += CboTargetType_SelectedIndexChanged;

            // Sự kiện thêm dòng vào danh sách áp dụng
            btnAddTarget.Click += BtnAddTarget_Click;

            // Sự kiện thêm mới khuyến mãi bên trái
            btnQuickAdd.Click += BtnQuickAdd_Click;

            // Sự kiện chọn dòng lưới bên trái
            dgvKhuyenMai.CellClick += DgvKhuyenMai_CellClick;

            // Sự kiện xóa dòng áp dụng
            btnDeleteApplied.Click += (s, e) =>
            {
                if (dgvAppliedList.CurrentRow != null)
                    dgvAppliedList.Rows.Remove(dgvAppliedList.CurrentRow);
            };

            // Sự kiện Lưu API
            btnSaveAll.Click += BtnSaveAll_Click;
        }

        private void InitializeGridColumns()
        {
            // Cấu hình cột cho Grid Danh Sách Áp Dụng (Bên phải)
            dgvAppliedList.Columns.Clear();
            dgvAppliedList.Columns.Add("Type", "Loại");
            dgvAppliedList.Columns.Add("Name", "Tên Đối Tượng");
            dgvAppliedList.Columns.Add("StartDate", "Bắt Đầu");
            dgvAppliedList.Columns.Add("EndDate", "Kết Thúc");
            // Cột ẩn chứa ID để gửi API
            dgvAppliedList.Columns.Add("ObjId", "ID");
            dgvAppliedList.Columns["ObjId"].Visible = false;
        }

        private void CboTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic load combobox thứ 2 dựa vào combobox 1
            cboTargetItem.DataSource = null;

            if (cboTargetType.SelectedIndex == 0) // Khóa học
            {
                cboTargetItem.DataSource = _listKhoaHoc;
                cboTargetItem.DisplayMember = "Ten";
                cboTargetItem.ValueMember = "Id";
            }
            else // Họa cụ
            {
                cboTargetItem.DataSource = _listHocCu;
                cboTargetItem.DisplayMember = "Ten";
                cboTargetItem.ValueMember = "Id";
            }
        }

        private void BtnQuickAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuickName.Text)) return;

            // 1. Gọi API tạo KhuyenMai mới
            // 2. Refresh lại dgvKhuyenMai
            MessageBox.Show($"Đã tạo khuyến mãi: {txtQuickName.Text} giảm {numQuickPercent.Value}%");

            // Clear input
            txtQuickName.Clear();
            numQuickPercent.Value = 0;
        }

        private void BtnAddTarget_Click(object sender, EventArgs e)
        {
            if (cboTargetItem.SelectedItem == null) return;

            // Thêm vào lưới hiển thị bên dưới
            string type = cboTargetType.SelectedItem.ToString();
            string name = ((SimpleItem)cboTargetItem.SelectedItem).Ten;
            int id = (int)cboTargetItem.SelectedValue;
            string start = dtpStart.Value.ToString("dd/MM/yyyy");
            string end = dtpEnd.Value.ToString("dd/MM/yyyy");

            dgvAppliedList.Rows.Add(type, name, start, end, id);
        }

        private void DgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng chọn đổ vào phần Header bên phải
                // txtTenKM.Text = ...
                // lblInfoPercent.Text = ...

                // Gọi API lấy danh sách chi tiết đã áp dụng và đổ vào dgvAppliedList
            }
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            // Duyệt qua GridView dgvAppliedList để lấy list ID và gửi về API
            foreach (DataGridViewRow row in dgvAppliedList.Rows)
            {
                if (row.IsNewRow) continue;

                int id = Convert.ToInt32(row.Cells["ObjId"].Value);
                string type = row.Cells["Type"].Value.ToString();
                // Call API update...
            }
            MessageBox.Show("Đã lưu thay đổi thành công!");
        }

        private void grpInfo_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void tlpQuickAdd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
