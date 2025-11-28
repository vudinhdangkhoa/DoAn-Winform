using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions; // Cần thêm cái này để check SĐT
using System.Threading.Tasks;
using System.Windows.Forms;


namespace winform
{
    public partial class ucQlNhanVien : UserControl
    {
        // ================= DTO CLASSES =================
        public class NhanVienViewDTO
        {
            public int UserId { get; set; }
            public string TenNv { get; set; }
            public string Sdt { get; set; }
            public string TenQuyen { get; set; }
            public string Mail { get; set; }
            public string MatKhau { get; set; }
            public int IdQuyen { get; set; }
        }

        public class QuyenDTO
        {
            public int IdQuyen { get; set; }
            public string TenQuyen { get; set; }
        }

        public class AddNhanVienPayload
        {
            public string TenNv { get; set; }
            public string Sdt { get; set; }
            public int IdQuyen { get; set; }
            public string Mail { get; set; }
            public string MatKhau { get; set; }
        }

        // ================= VARIABLES =================
        private List<NhanVienViewDTO> _originalList;
        private int _selectedId = -1;

        public ucQlNhanVien()
        {
            InitializeComponent();
            InitializeGrid();

            this.Load += UcQlNhanVien_Load;
            btnRefresh.Click += (s, e) => LoadData();
            txtSearch.TextChanged += (s, e) => FilterData();
            dgvNhanVien.CellClick += DgvNhanVien_CellClick;

            btnThem.Click += BtnThem_Click;
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
            btnBoQua.Click += (s, e) => ResetForm();

            // Thêm sự kiện chỉ cho nhập số vào ô SĐT
            txtSdt.KeyPress += TxtSdt_KeyPress;
        }

        private void InitializeGrid()
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.Columns.Clear();

            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UserId", Name = "UserId", Visible = false });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenNv", HeaderText = "Họ Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Sdt", HeaderText = "Số Điện Thoại", Width = 120 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Mail", HeaderText = "Email", Width = 180 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenQuyen", HeaderText = "Quyền Hạn", Width = 120 });
        }

        private async void UcQlNhanVien_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            await LoadData();
        }

        // ================= VALIDATION HELPERS =================

        // Hàm kiểm tra định dạng Email
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                // Pattern check email cơ bản
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        // Hàm kiểm tra SĐT (VN: 10 số, bắt đầu bằng 0)
        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            // Regex: Bắt đầu bằng 0, theo sau là 9 chữ số
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }

        // Chặn nhập chữ vào ô SĐT ngay khi gõ
        private void TxtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        // ================= DATA LOADING =================

        private async Task LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var taskQuyen = client.GetAsync(DungChung.getUrl("QLNhanVien/GetAllQuyen"));
                    var taskNV = client.GetAsync(DungChung.getUrl("QLNhanVien/GetAllNhanVien"));

                    await Task.WhenAll(taskQuyen, taskNV);

                    if (taskQuyen.Result.IsSuccessStatusCode)
                    {
                        var json = await taskQuyen.Result.Content.ReadAsStringAsync();
                        var listQuyen = JsonConvert.DeserializeObject<List<QuyenDTO>>(json);
                        cboQuyen.DataSource = listQuyen;
                        cboQuyen.DisplayMember = "TenQuyen";
                        cboQuyen.ValueMember = "IdQuyen";
                    }

                    if (taskNV.Result.IsSuccessStatusCode)
                    {
                        var json = await taskNV.Result.Content.ReadAsStringAsync();
                        _originalList = JsonConvert.DeserializeObject<List<NhanVienViewDTO>>(json);
                        FilterData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void FilterData()
        {
            if (_originalList == null) return;
            string key = txtSearch.Text.ToLower();

            var list = _originalList.Where(x =>
                (x.TenNv != null && x.TenNv.ToLower().Contains(key)) ||
                (x.Mail != null && x.Mail.ToLower().Contains(key)) ||
                (x.Sdt != null && x.Sdt.Contains(key))
            ).ToList();

            dgvNhanVien.DataSource = list;
        }

        private void ResetForm()
        {
            _selectedId = -1;
            txtTen.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtMatKhau.PlaceholderText = "";

            if (cboQuyen.Items.Count > 0) cboQuyen.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtEmail.ReadOnly = false; // Mở khóa email để nhập mới

            txtTen.Focus();
        }

        // ================= EVENTS =================

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (NhanVienViewDTO)dgvNhanVien.Rows[e.RowIndex].DataBoundItem;
            _selectedId = item.UserId;

            txtTen.Text = item.TenNv;
            txtSdt.Text = item.Sdt;
            txtEmail.Text = item.Mail;
            txtMatKhau.Text = "";
            txtMatKhau.PlaceholderText = "Nhập nếu muốn đổi mật khẩu";

            // Chọn quyền chính xác theo ID (nếu API trả về IdQuyen)
            // Nếu API chưa trả IdQuyen, bạn cần map thủ công qua TenQuyen hoặc sửa API
            // Giả sử NhanVienViewDTO có IdQuyen (như bạn đã thêm trong API GetAllNhanVien)
            if (item.IdQuyen > 0)
                cboQuyen.SelectedValue = item.IdQuyen;
            else
                cboQuyen.SelectedIndex = cboQuyen.FindStringExact(item.TenQuyen);

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            // Khi sửa, có thể cho phép sửa email nhưng server sẽ check trùng
            txtEmail.ReadOnly = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu và Trim() khoảng trắng thừa
            string ten = txtTen.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            int idQuyen = Convert.ToInt32(cboQuyen.SelectedValue);

            // 2. VALIDATION (RÀNG BUỘC DỮ LIỆU)

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus(); return;
            }

            // Kiểm tra SĐT
            if (!IsValidPhone(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (Phải là 10 số, bắt đầu bằng số 0).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus(); return;
            }

            // Kiểm tra Email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Định dạng Email không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); return;
            }

            // Kiểm tra Mật khẩu (Chỉ bắt buộc khi Thêm Mới)
            if (_selectedId == -1)
            {
                if (string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cho nhân viên mới.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus(); return;
                }
                if (matKhau.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Bảo mật yếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus(); return;
                }
            }

            // 3. Prepare Payload
            var payload = new AddNhanVienPayload
            {
                TenNv = ten,
                Sdt = sdt,
                Mail = email,
                IdQuyen = idQuyen,
                // Nếu đang update và ô mật khẩu trống -> Gửi null để Server giữ nguyên pass cũ
                MatKhau = string.IsNullOrEmpty(matKhau) ? null : matKhau
            };

            // 4. Call API
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage res;

                    if (_selectedId == -1) // Create
                    {
                        res = await client.PostAsync(DungChung.getUrl("QLNhanVien/CreateNhanVien"), content);
                    }
                    else // Update
                    {
                        res = await client.PutAsync(DungChung.getUrl($"QLNhanVien/UpdateNhanVien/{_selectedId}"), content);
                    }

                    if (res.IsSuccessStatusCode)
                    {
                        string msg = _selectedId == -1 ? "Thêm mới thành công!" : "Cập nhật thành công!";
                        MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        ResetForm();
                    }
                    else
                    {
                        var err = await res.Content.ReadAsStringAsync();
                        // Hiển thị lỗi cụ thể từ Server (VD: Email trùng)
                        // Parse JSON error nếu server trả về { "message": "..." }
                        try
                        {
                            var errObj = JsonConvert.DeserializeObject<dynamic>(err);
                            MessageBox.Show("Lỗi: " + errObj.message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi: " + err, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
        }

        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == -1) return;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?\nTài khoản sẽ bị vô hiệu hóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var res = await client.DeleteAsync(DungChung.getUrl($"QLNhanVien/DeleteNhanVien/{_selectedId}"));

                        if (res.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Đã xóa nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi xóa: " + await res.Content.ReadAsStringAsync());
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
    }
}