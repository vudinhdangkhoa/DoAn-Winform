using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
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

            // QUAN TRỌNG: Ngăn Grid tự động tạo cột thừa, giữ nguyên cột đẹp đã thiết kế
            dgvNhanVien.AutoGenerateColumns = false;

            this.Load += UcQlNhanVien_Load;
            btnRefresh.Click += (s, e) => LoadData();
            txtSearch.TextChanged += (s, e) => FilterData();
            dgvNhanVien.CellClick += DgvNhanVien_CellClick;

            btnThem.Click += BtnThem_Click;
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
            btnBoQua.Click += (s, e) => ResetForm();

            // Ràng buộc nhập liệu
            txtSdt.KeyPress += TxtSdt_KeyPress;
            txtTen.KeyPress += TxtTen_KeyPress;
        }

        // Đã xóa hàm InitializeGrid() vì Designer đã làm việc này rồi

        private async void UcQlNhanVien_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            await LoadData();
        }

        // ================= VALIDATION HELPERS =================

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch { return false; }
        }

        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            // Kiểm tra chính xác 10 số và bắt đầu bằng 0
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }

        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            // Chỉ cho phép chữ cái và khoảng trắng
            return Regex.IsMatch(name, @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵýỷỹ\s]+$");
        }

        private void TxtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chặn chữ ngay khi nhập, chỉ cho nhập số và nút xóa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chặn số và ký tự đặc biệt ngay khi nhập
            // Chỉ cho phép chữ và khoảng trắng
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txtMatKhau.PlaceholderText = "Tối thiểu 6 ký tự";

            if (cboQuyen.Items.Count > 0) cboQuyen.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtEmail.ReadOnly = false; // Khi thêm mới được nhập email

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
            txtMatKhau.PlaceholderText = "Để trống nếu không đổi";

            if (item.IdQuyen > 0)
                cboQuyen.SelectedValue = item.IdQuyen;
            else
                cboQuyen.SelectedIndex = cboQuyen.FindStringExact(item.TenQuyen);

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            // Logic cũ: txtEmail.ReadOnly = false; 
            // Tuy nhiên, thường khi update người ta hạn chế cho sửa Email để tránh lỗi hệ thống, 
            // nếu bạn muốn cho sửa thì để false, không thì để true.
            txtEmail.ReadOnly = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            // Nút "Thêm Mới" chỉ reset form để người dùng nhập
            ResetForm();
            btnLuu.Enabled = true;     // Sáng nút Lưu
            btnThem.Enabled = false;   // Ẩn nút Thêm
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu và Trim
            string ten = txtTen.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            int idQuyen = Convert.ToInt32(cboQuyen.SelectedValue);

            // 2. VALIDATION

            if (string.IsNullOrEmpty(ten)) { ShowWarning("Vui lòng nhập họ tên nhân viên.", txtTen); return; }
            if (!IsValidName(ten)) { ShowWarning("Họ tên không hợp lệ (không chứa số/kí tự lạ).", txtTen); return; }

            if (string.IsNullOrEmpty(sdt)) { ShowWarning("Vui lòng nhập số điện thoại.", txtSdt); return; }
            if (!IsValidPhone(sdt)) { ShowWarning("Số điện thoại phải đủ 10 số và bắt đầu bằng 0.", txtSdt); return; }

            if (string.IsNullOrEmpty(email)) { ShowWarning("Vui lòng nhập email.", txtEmail); return; }
            if (!IsValidEmail(email)) { ShowWarning("Định dạng Email không hợp lệ.", txtEmail); return; }

            // Logic check mật khẩu
            if (_selectedId == -1) // Đang thêm mới
            {
                if (string.IsNullOrEmpty(matKhau)) { ShowWarning("Vui lòng nhập mật khẩu cho nhân viên mới.", txtMatKhau); return; }
                if (matKhau.Length < 6) { ShowWarning("Mật khẩu phải có ít nhất 6 ký tự.", txtMatKhau); return; }
            }
            else // Đang cập nhật
            {
                // Nếu có nhập mật khẩu thì mới check độ dài
                if (!string.IsNullOrEmpty(matKhau) && matKhau.Length < 6)
                {
                    ShowWarning("Mật khẩu mới phải có ít nhất 6 ký tự.", txtMatKhau); return;
                }
            }

            // 3. GỌI API
            var payload = new AddNhanVienPayload
            {
                TenNv = ten,
                Sdt = sdt,
                Mail = email,
                IdQuyen = idQuyen,
                MatKhau = matKhau
            };

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;
                string json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                try
                {
                    if (_selectedId == -1) // THÊM MỚI
                    {
                        response = await client.PostAsync(DungChung.getUrl("QLNhanVien/CreateNhanVien"), content);
                    }
                    else // CẬP NHẬT
                    {
                        response = await client.PutAsync(DungChung.getUrl($"QLNhanVien/UpdateNhanVien/{_selectedId}"), content);
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(_selectedId == -1 ? "Thêm mới thành công!" : "Cập nhật thành công!", "Thông báo");
                        await LoadData();
                        ResetForm();
                    }
                    else
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        // Parse JSON error message if possible
                        try
                        {
                            dynamic errObj = JsonConvert.DeserializeObject(err);
                            MessageBox.Show("Lỗi: " + errObj.message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBox.Show("Có lỗi xảy ra: " + err, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == -1) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.DeleteAsync(DungChung.getUrl($"QLNhanVien/DeleteNhanVien/{_selectedId}"));
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xóa thành công!");
                            await LoadData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại. Vui lòng thử lại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Helper rút gọn thông báo
        private void ShowWarning(string msg, Control controlToFocus)
        {
            MessageBox.Show(msg, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            controlToFocus.Focus();
        }
    }
}