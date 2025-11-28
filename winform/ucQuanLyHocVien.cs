using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace winform
{
    public partial class ucQuanLyHocVien : UserControl
    {
        // Global variables
        public dynamic dataHocVien;
        public dynamic dataKhoaHoc;

        private List<object> originalKhoaHocList;
        private List<object> originalLopHocList;

        private bool checkInit = false;

        public ucQuanLyHocVien()
        {
            InitializeComponent();

            // Kích hoạt tính năng tìm kiếm ngay khi gõ
            txt_TimKiem.TextChanged += (s, e) => ApplyFilters();

            LoadData();
            checkInit = true;
        }

        public async void LoadData()
        {
            dataHocVien = await UCQuanLyHocVien.GetHocVien();
            // Load danh sách ban đầu (Đã cập nhật để bao gồm ID)
            ApplyFilters();

            dataKhoaHoc = await UCQuanLyHocVien.GetKhoaHoc();
            if (dataKhoaHoc != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        comboBox_KhoaHoc.SelectedIndexChanged -= comboBox_KhoaHoc_SelectedIndexChanged;
                        var khoaHocList = new List<object>();

                        // Tạo mục mặc định
                        khoaHocList.Add(new { Text = "--- Chọn Khóa Học ---", Value = -1 });

                        foreach (var kh in dataKhoaHoc)
                        {
                            khoaHocList.Add(new { Text = (string)kh.tenKhoaHoc, Value = (int)kh.idKhoaHoc });
                        }

                        originalKhoaHocList = new List<object>(khoaHocList);

                        comboBox_KhoaHoc.DataSource = khoaHocList;
                        comboBox_KhoaHoc.DisplayMember = "Text";
                        comboBox_KhoaHoc.ValueMember = "Value";

                        comboBox_KhoaHoc.SelectedIndex = 0;

                        comboBox_LopHoc.DataSource = null;

                        comboBox_KhoaHoc.SelectedIndexChanged += comboBox_KhoaHoc_SelectedIndexChanged;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu khóa học: " + ex.Message);
                    }
                });
            }
        }

        private void LoadLopHocByKhoaHoc(int khoaHocId)
        {
            if (khoaHocId == -1)
            {
                comboBox_LopHoc.DataSource = null;
                return;
            }

            var lopHocList = new List<object>();

            lopHocList.Add(new { Text = "--- Chọn Lớp Học ---", Value = -1 });

            if (dataKhoaHoc != null)
            {
                foreach (var kh in dataKhoaHoc)
                {
                    if ((int)kh.idKhoaHoc == khoaHocId)
                    {
                        if (kh.lopHocs != null && kh.lopHocs.Count > 0)
                        {
                            foreach (var lopHoc in kh.lopHocs)
                            {
                                lopHocList.Add(new
                                {
                                    Text = (string)lopHoc.tenLopHoc,
                                    Value = (int)lopHoc.idLopHoc
                                });
                            }
                        }
                        break;
                    }
                }
            }

            if (lopHocList.Count == 1)
            {
                comboBox_LopHoc.DataSource = null;
            }
            else
            {
                comboBox_LopHoc.DisplayMember = "Text";
                comboBox_LopHoc.ValueMember = "Value";
                originalLopHocList = new List<object>(lopHocList);
                comboBox_LopHoc.DataSource = lopHocList;

                comboBox_LopHoc.SelectedIndex = 0;
            }
        }

        private void comboBox_KhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkInit) return;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem != null && cb.SelectedValue != null && (int)cb.SelectedValue != -1)
            {
                int selectedKhoaHocId = Convert.ToInt32(cb.SelectedValue);
                LoadLopHocByKhoaHoc(selectedKhoaHocId);
            }
            else
            {
                comboBox_LopHoc.DataSource = null;
                ApplyFilters();
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // --- CẬP NHẬT HÀM LỌC ĐỂ THÊM ID VÀO GRID ---
        private void ApplyFilters()
        {
            if (dataHocVien == null) return;

            string keyword = txt_TimKiem.Text.ToLower().Trim();
            int? selectedLopId = null;

            if (checkInit
                && comboBox_LopHoc.SelectedIndex != -1
                && comboBox_LopHoc.SelectedValue != null
                && (int)comboBox_LopHoc.SelectedValue != -1)
            {
                selectedLopId = Convert.ToInt32(comboBox_LopHoc.SelectedValue);
            }

            this.Invoke((MethodInvoker)delegate
            {
                dgv_DanhSachHV.Rows.Clear();
                foreach (var hv in dataHocVien)
                {
                    bool matchName = true;
                    bool matchClass = true;

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        string ten = (string)hv.tenHv;
                        if (string.IsNullOrEmpty(ten) || !ten.ToLower().Contains(keyword))
                        {
                            matchName = false;
                        }
                    }

                    if (selectedLopId.HasValue)
                    {
                        bool foundClass = false;
                        if (hv.hoaDonKhoaHocs != null)
                        {
                            foreach (var lh in hv.hoaDonKhoaHocs)
                            {
                                if ((int)lh.idLopHoc == selectedLopId.Value)
                                {
                                    foundClass = true;
                                    break;
                                }
                            }
                        }
                        if (!foundClass) matchClass = false;
                    }

                    if (matchName && matchClass)
                    {
                        // --- ĐÃ THÊM: hv.idHocVien VÀO ĐẦU ---
                        dgv_DanhSachHV.Rows.Add(hv.idHocVien, hv.tenHv, hv.ngaySinh.ToString("dd/MM/yyyy"), hv.gioiTinh, hv.phuHuynh);
                    }
                }
            });
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (!checkInit) return;

            txt_TimKiem.Text = "";
            comboBox_KhoaHoc.SelectedIndexChanged -= comboBox_KhoaHoc_SelectedIndexChanged;

            if (originalKhoaHocList != null)
            {
                comboBox_KhoaHoc.DataSource = originalKhoaHocList;
                comboBox_KhoaHoc.DisplayMember = "Text";
                comboBox_KhoaHoc.ValueMember = "Value";
            }
            comboBox_KhoaHoc.SelectedIndex = 0;

            comboBox_LopHoc.DataSource = null;

            comboBox_KhoaHoc.SelectedIndexChanged += comboBox_KhoaHoc_SelectedIndexChanged;

            ApplyFilters();
        }

        private void btn_ThemHocVien_Click(object sender, EventArgs e)
        {
            frmThemHocVien frm = new frmThemHocVien();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachHV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "DanhSachHocVien.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XuatRaExcel(dgv_DanhSachHV, sfd.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void XuatRaExcel(DataGridView dgv, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DanhSachHocVien");

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                    var headerCell = worksheet.Cell(1, i + 1);
                    headerCell.Style.Font.Bold = true;
                    headerCell.Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                    headerCell.Style.Font.FontColor = XLColor.White;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        var cellValue = dgv.Rows[i].Cells[j].Value;
                        string valueStr = cellValue != null ? cellValue.ToString() : "";
                        worksheet.Cell(i + 2, j + 1).Value = valueStr;
                    }
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(filePath);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}