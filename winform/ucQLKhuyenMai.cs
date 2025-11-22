using Newtonsoft.Json.Linq;
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
    public partial class ucQLKhuyenMai : UserControl
    {
        private class SimpleItem { public int Id { get; set; } public string Ten { get; set; } }

        private List<SimpleItem> _listKhoaHoc = new List<SimpleItem>();


        private List<SimpleItem> _listHocCu = new List<SimpleItem>();

        private int _selectedKhuyenMaiId = -1;

        public dynamic KhuyenMaiData { get; set; }
        public ucQLKhuyenMai()
        {
            InitializeComponent();
            SetupEvents();
            InitializeGridColumns();
             LoadData();
        }

        private async void LoadData()
        {
            // Gọi API load danh sách khuyến mãi vào dgvKhuyenMai

            try
            {

                KhuyenMaiData = await UCQuanLyKhuyenMai.GetChuongTrinhKhuyenMai();
                if(KhuyenMaiData != null)
                {
                    // Giả sử KhuyenMaiData là danh sách các khuyến mãi
                    dgvKhuyenMai.Rows.Clear();
                    foreach (var km in KhuyenMaiData)
                    {
                        dgvKhuyenMai.Rows.Add(km.idKhuyenMai, km.tenKhuyenMai, km.phanTramKhuyenMai*100);
                    }
                }

                var resourceData = await UCQuanLyKhuyenMai.GetKhoaHocVaHoaCu();
                if (resourceData != null)
                {
                    _listKhoaHoc.Clear();
                    _listHocCu.Clear();

                    // Parse dynamic data sang SimpleItem
                    foreach (var item in resourceData.khoaHocs)
                    {
                        _listKhoaHoc.Add(new SimpleItem { Id = (int)item.idKhoaHoc, Ten = (string)item.tenKhoaHoc });
                    }

                    foreach (var item in resourceData.hocCus)
                    {
                        _listHocCu.Add(new SimpleItem { Id = (int)item.idHocCu, Ten = (string)item.tenHocCu });
                    }

                    // Refresh lại combobox sau khi có data
                    CboTargetType_SelectedIndexChanged(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khuyen mai: " + ex.Message);
            }


        }

        private void SetupEvents()
        {
            // 1. XỬ LÝ COMBOBOX
            // Gỡ bỏ trước khi gán để tránh lặp nếu hàm SetupEvents bị gọi nhiều lần
            cboTargetType.SelectedIndexChanged -= CboTargetType_SelectedIndexChanged;
            cboTargetType.SelectedIndexChanged += CboTargetType_SelectedIndexChanged;

            // 2. XỬ LÝ NÚT THÊM ÁP DỤNG (Nguyên nhân lỗi của bạn nằm ở đây)
            // Dòng này sẽ cắt bỏ mọi sự kiện "ma" do Designer tự sinh ra
            btnAddTarget.Click -= BtnAddTarget_Click;
            // Nếu bạn từng có hàm cũ tên btnAddTarget_Click_1, hãy uncomment dòng dưới để gỡ nó luôn
            // btnAddTarget.Click -= btnAddTarget_Click_1; 

            // Gán sự kiện chuẩn (đã có validate ngày tháng)
            btnAddTarget.Click += BtnAddTarget_Click;

            // 3. XỬ LÝ NÚT THÊM NHANH (Bên trái)
            btnQuickAdd.Click -= BtnQuickAdd_Click;
            btnQuickAdd.Click += BtnQuickAdd_Click;

            // 4. XỬ LÝ GRIDVIEW (Bạn đang bị lặp ở đây)
            dgvKhuyenMai.CellClick -= DgvKhuyenMai_CellClick;
            dgvKhuyenMai.CellClick -= dgvKhuyenMai_CellClick_1; // Gỡ bỏ hàm cũ do Designer sinh ra
            dgvKhuyenMai.CellClick += DgvKhuyenMai_CellClick;   // Chỉ dùng hàm mới chuẩn

            // 5. XỬ LÝ NÚT XÓA
            // Lưu logic xóa vào biến delegate để có thể gỡ bỏ được (Lambda expression không gỡ được bằng -=)
            // Tuy nhiên với lambda đơn giản như này, ta chấp nhận gán đè nếu không gọi SetupEvents nhiều lần.
            // Để an toàn nhất, ta tách hàm xóa ra:
            btnDeleteApplied.Click -= btnDeleteApplied_Click;
            btnDeleteApplied.Click += btnDeleteApplied_Click;

            // 6. XỬ LÝ NÚT LƯU
            // Lưu ý: Trong Designer bạn đang gán cho btnLuu, nhưng ở đây lại gán btnSaveAll?
            // Hãy thống nhất dùng 1 nút. Tôi giả sử bạn dùng btnSaveAll cho logic API.
            btnSaveAll.Click -= btnLuu_Click;
            btnSaveAll.Click += btnLuu_Click;
        }

        private void InitializeGridColumns()
        {
            // Cấu hình cột cho Grid Danh Sách Áp Dụng (Bên phải)
            dgvAppliedList.Columns.Clear();
            dgvAppliedList.Columns.Add("Type", "Loại");
            dgvAppliedList.Columns.Add("SL", "Số Lượng");
            dgvAppliedList.Columns.Add("Name", "Tên Đối Tượng");
            dgvAppliedList.Columns.Add("StartDate", "Bắt Đầu");
            dgvAppliedList.Columns.Add("EndDate", "Kết Thúc");
            // Cột ẩn chứa ID để gửi API
            dgvAppliedList.Columns.Add("ObjId", "ID");
            dgvAppliedList.Columns["ObjId"].Visible = false;

            dgvKhuyenMai.Columns.Clear();
            dgvKhuyenMai.Columns.Add("Id", "ID");
            dgvKhuyenMai.Columns.Add("Ten", "Tên Khuyến Mãi");
            dgvKhuyenMai.Columns.Add("Percent", "Phần Trăm Giảm");
            dgvKhuyenMai.Columns["Id"].Visible = false;
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

        private async void BtnQuickAdd_Click(object sender, EventArgs e)
        {
            var AddKM = new
            {
                tenKhuyenMai = txtQuickName.Text,
                phanTramKhuyenMai = numQuickPercent.Value / 100
            };
            using (HttpClient client = new HttpClient())
            {
                string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(AddKM);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                string url = DungChung.getUrl("XacThuc/DangNhap");

                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(responseString) || responseString.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Lỗi kết nối Server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var jObject = JObject.Parse(responseString);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string errorMessage = jObject["message"]?.ToString() ?? "Đã xảy ra lỗi.";
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddTarget_Click(object sender, EventArgs e)
        {
            if (cboTargetItem.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Khóa học hoặc Họa cụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtSL.Text.Trim() == "" || !int.TryParse(txtSL.Text.Trim(), out int slValue) || slValue <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 2. Lấy dữ liệu từ Controls
            string type = cboTargetType.SelectedIndex == 0 ? "KhoaHoc" : "HocCu"; // Đánh dấu để tý phân loại
            string typeDisplay = cboTargetType.Text;
            var selectedItem = (SimpleItem)cboTargetItem.SelectedItem;
            string name = selectedItem.Ten;
            int id = selectedItem.Id;
            string start = dtpStart.Value.ToString("yyyy-MM-dd"); // Format chuẩn
            string end = dtpEnd.Value.ToString("yyyy-MM-dd");
            int sl= txtSL.Text != "" ? int.Parse( txtSL.Text) : 10;
            // 3. Kiểm tra trùng lặp trên lưới (UX)
            foreach (DataGridViewRow row in dgvAppliedList.Rows)
            {
                if (row.IsNewRow) continue;
                int rowId = Convert.ToInt32(row.Cells["ObjId"].Value);
                string rowType = row.Cells["Type"].Value.ToString();

                // Lưu ý: Cần so sánh cả Type (để tránh trùng ID giữa Khóa học và Họa cụ nếu DB int)
                // Ở đây ta so sánh tên hiển thị Loại cho đơn giản, hoặc bạn có thể lưu Type ẩn
                if (rowId == id && row.Cells["Type"].Value.ToString() == typeDisplay)
                {
                    MessageBox.Show($"Mục '{name}' đã có trong danh sách chờ!", "Thông báo");
                    return;
                }
            }

            // 4. Thêm vào Grid (Lưu Type gốc vào Tag hoặc cột ẩn nếu cần, ở đây tôi dùng cột Type hiển thị)
            // Cột cấu hình: Type, Name, StartDate, EndDate, ObjId
            int index = dgvAppliedList.Rows.Add(typeDisplay,sl, name, start, end, id);

            // Lưu thêm thông tin loại (KhoaHoc/HocCu) vào Tag của dòng để lúc Lưu dễ xử lý
            dgvAppliedList.Rows[index].Tag = type;
        }

        private void DgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID từ cột 0 (Cột Id ẩn đã cấu hình ở InitializeGridColumns)
                var cellId = dgvKhuyenMai.Rows[e.RowIndex].Cells["Id"].Value;
                var cellTen = dgvKhuyenMai.Rows[e.RowIndex].Cells["Ten"].Value;
                var cellPercent = dgvKhuyenMai.Rows[e.RowIndex].Cells["Percent"].Value;

                if (cellId != null)
                {
                    _selectedKhuyenMaiId = Convert.ToInt32(cellId);

                    // Hiển thị thông tin lên Header bên phải (Optional)
                    txtTenKM.Text = cellTen.ToString();
                    lblInfoPercent.Text = (Convert.ToDouble(cellPercent)).ToString() + "%";

                    // TODO: Nếu muốn hiện các item ĐÃ áp dụng trước đó, cần gọi 1 API GetDetails tại đây
                    // Hiện tại ta clear lưới bên phải để chuẩn bị thêm mới
                    dgvAppliedList.Rows.Clear();
                }
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (_selectedKhuyenMaiId <= 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi bên trái trước!", "Cảnh báo");
                return;
            }

            if (dgvAppliedList.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách áp dụng trống!", "Cảnh báo");
                return;
            }

            btnSaveAll.Enabled = false;

            try
            {
                // 1. Gom nhóm dữ liệu theo: Ngày Bắt Đầu - Ngày Kết Thúc - Số Lượng
                // Key format: "yyyy-MM-dd|yyyy-MM-dd|SoLuong"
                var groups = new Dictionary<string, List<DataGridViewRow>>();

                foreach (DataGridViewRow row in dgvAppliedList.Rows)
                {
                    if (row.IsNewRow) continue;

                    string sDate = row.Cells["StartDate"].Value.ToString();
                    string eDate = row.Cells["EndDate"].Value.ToString();
                    // Lấy thêm số lượng để tạo Key
                    string sQty = row.Cells["SL"].Value.ToString();

                    // Tạo Key bao gồm cả số lượng
                    string key = $"{sDate}|{eDate}|{sQty}";

                    if (!groups.ContainsKey(key)) groups[key] = new List<DataGridViewRow>();
                    groups[key].Add(row);
                }

                using (HttpClient client = new HttpClient())
                {
                    string url = DungChung.getUrl("QLKhuyenMai/ApDungKhuyenMai");
                    int successCount = 0;

                    // 2. Duyệt qua từng nhóm để gọi API
                    foreach (var group in groups)
                    {
                        // Tách Key để lấy lại dữ liệu
                        var parts = group.Key.Split('|');
                        DateTime dtStart = DateTime.Parse(parts[0]);
                        DateTime dtEnd = DateTime.Parse(parts[1]);
                        int qtyGroup = int.Parse(parts[2]); // Lấy số lượng của nhóm này

                        // Chuẩn bị List ID
                        List<int> lstKhoaHocIds = new List<int>();
                        List<int> lstHoaCuIds = new List<int>();

                        foreach (var row in group.Value)
                        {
                            int id = Convert.ToInt32(row.Cells["ObjId"].Value);
                            string typeCode = row.Tag?.ToString();

                            if (typeCode == "KhoaHoc") lstKhoaHocIds.Add(id);
                            else if (typeCode == "HocCu") lstHoaCuIds.Add(id);
                        }

                        // Tạo Payload gửi đi (Bổ sung soLuong)
                        var payload = new
                        {
                            idKhuyenMai = _selectedKhuyenMaiId,
                            lstIdKhoaHoc = lstKhoaHocIds,
                            lstIdHoaCu = lstHoaCuIds,
                            ngayBatDau = dtStart,
                            ngayKetThuc = dtEnd,
                            soLuong = qtyGroup // Gán số lượng vào payload
                        };

                        string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
                        var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                        var response = await client.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            successCount++;
                        }
                    }

                    if (successCount == groups.Count)
                    {
                        MessageBox.Show("Lưu thành công toàn bộ danh sách!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAppliedList.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Lưu hoàn tất nhưng có lỗi ở một số nhóm. ({successCount}/{groups.Count} thành công)", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi Fatal");
            }
            finally
            {
                btnSaveAll.Enabled = true;
            }
        }

        private void btnDeleteApplied_Click(object sender, EventArgs e)
        {
            if (dgvAppliedList.CurrentRow != null && !dgvAppliedList.CurrentRow.IsNewRow)
            {
                dgvAppliedList.Rows.Remove(dgvAppliedList.CurrentRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo");
            }
        }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {

            try
            {
                if(_selectedKhuyenMaiId <= 0)
                {
                    MessageBox.Show("Vui lòng chọn chương trình khuyến mãi bên trái trước!", "Cảnh báo");
                    return;
                }
                if(txtTenKM.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khuyến mãi không được để trống!", "Cảnh báo");
                    return;
                }
                if(lblInfoPercent.Text.Trim() == "")
                {
                    MessageBox.Show("Phần trăm khuyến mãi không được để trống!", "Cảnh báo");
                    return;
                }
                var updateKM= new
                {
                    tenKhuyenMai = txtTenKM.Text,
                    phanTramKhuyenMai = (float)Math.Round(double.Parse(lblInfoPercent.Text.Replace("%", "")) / 100.0, 2)
                };
                string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(updateKM);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                string url = DungChung.getUrl("QLKhuyenMai/updateKhuyenMai/" + _selectedKhuyenMaiId);
                using(HttpClient client = new HttpClient())
                {
                    var response =  client.PutAsync(url, content).Result;
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Chỉnh sửa khuyến mãi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi chỉnh sửa khuyến mãi: " + responseString, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu chỉnh sửa: " + ex.Message, "Lỗi Fatal");
            }

        }

        private void btnHuyChinhSua_Click(object sender, EventArgs e)
        {

            txtTenKM.Text="";
            lblInfoPercent.Text = "";
            _selectedKhuyenMaiId = -1;
        }

        private void dgvKhuyenMai_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID từ cột 0 (Cột Id ẩn đã cấu hình ở InitializeGridColumns)
                var cellId = dgvKhuyenMai.Rows[e.RowIndex].Cells["Id"].Value;
                var cellTen = dgvKhuyenMai.Rows[e.RowIndex].Cells["Ten"].Value;
                var cellPercent = dgvKhuyenMai.Rows[e.RowIndex].Cells["Percent"].Value;

                if (cellId != null)
                {
                    _selectedKhuyenMaiId = Convert.ToInt32(cellId);

                    // Hiển thị thông tin lên Header bên phải (Optional)
                    txtTenKM.Text = cellTen.ToString();
                    lblInfoPercent.Text = (Convert.ToDouble(cellPercent) * 100).ToString() + "%";

                    // TODO: Nếu muốn hiện các item ĐÃ áp dụng trước đó, cần gọi 1 API GetDetails tại đây
                    // Hiện tại ta clear lưới bên phải để chuẩn bị thêm mới
                    dgvAppliedList.Rows.Clear();
                }
            }
        }

        private void btnQLKMApDung_Click(object sender, EventArgs e)
        {
            frmQLCacApDungKM f= new frmQLCacApDungKM();
            f.ShowDialog();
        }
    }
}
