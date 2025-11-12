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
    public partial class ucQuanLyHocVien : UserControl
    {
        // global variables
        public dynamic dataHocVien;
        public dynamic dataKhoaHoc;

        private List<object> originalKhoaHocList;
        private List<object> originalLopHocList;

        private bool checkInit=false;
        public ucQuanLyHocVien()
        {
            InitializeComponent();
            LoadData();
            checkInit = true;
        }
       
        public async void LoadData()
        { 
             dataHocVien = await UCQuanLyHocVien.GetHocVien();
            if (dataHocVien != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        dgv_DanhSachHV.Rows.Clear();
                        foreach (var hv in dataHocVien)
                        {
                            dgv_DanhSachHV.Rows.Add(hv.tenHv, hv.ngaySinh.ToString("dd/MM/yyyy"),hv.gioiTinh, hv.phuHuynh);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải dữ liệu học viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }

            dataKhoaHoc = await UCQuanLyHocVien.GetKhoaHoc();
            if (dataKhoaHoc != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        comboBox_KhoaHoc.SelectedIndexChanged -= comboBox_KhoaHoc_SelectedIndexChanged;
                        var khoaHocList = new List<object>();

                        foreach (var kh in dataKhoaHoc)
                        {
                            // Chỉ thêm khóa học vào ComboBox đầu tiên
                            khoaHocList.Add(new { Text = (string)kh.tenKhoaHoc, Value = (int)kh.idKhoaHoc });
                        }

                        originalKhoaHocList = new List<object>(khoaHocList);

                        comboBox_KhoaHoc.DataSource = khoaHocList;
                        comboBox_KhoaHoc.DisplayMember = "Text";
                        comboBox_KhoaHoc.ValueMember = "Value";
                        comboBox_KhoaHoc.SelectedIndex = -1;

                        // ComboBox lớp học sẽ được cập nhật khi chọn khóa học
                        comboBox_LopHoc.DataSource = null;
                        comboBox_LopHoc.SelectedIndex = -1;


                        comboBox_KhoaHoc.SelectedIndexChanged += comboBox_KhoaHoc_SelectedIndexChanged;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải dữ liệu khóa học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                });
            }


        }

        

        private void LoadLopHocByKhoaHoc(int khoaHocId)
        {
            var lopHocList = new List<object>();

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
                                Console.WriteLine("Added class: " + (string)lopHoc.tenLopHoc);
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("dataKhoaHoc is null");
            }
            if(lopHocList.Count == 0)
            {
                Console.WriteLine("No classes found for the selected course ID: " + khoaHocId);
                comboBox_LopHoc.DisplayMember = "Text";
                comboBox_LopHoc.ValueMember = "Value";
                
                comboBox_LopHoc.DataSource = null;

                comboBox_LopHoc.SelectedIndex = -1;
            }
            else
            {
                comboBox_LopHoc.DisplayMember = "Text";
                comboBox_LopHoc.ValueMember = "Value";
                originalLopHocList = new List<object>(lopHocList);
                comboBox_LopHoc.DataSource = lopHocList;

                comboBox_LopHoc.SelectedIndex = -1;
            }
               
        }

        // Thêm event handler cho SelectedIndexChanged
        private void comboBox_KhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkInit) return; // Bỏ qua sự kiện trong quá trình khởi tạo
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null && cb.SelectedValue != null&& cb.SelectedIndex!=-1)
            {
                int selectedKhoaHocId = Convert.ToInt32(cb.SelectedValue);
                LoadLopHocByKhoaHoc(selectedKhoaHocId);

                Console.WriteLine($"Đã chọn khóa học: {cb.Text} (ID: {selectedKhoaHocId})");
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (!checkInit) return;
            if (comboBox_LopHoc.SelectedItem == null || comboBox_LopHoc.SelectedIndex == -1) return;
            int selectedLopHocId = Convert.ToInt32(comboBox_LopHoc.SelectedValue);




        }

        private void FilterByLopHoc(int lopHocId)
        {
            var filteredHocVien = new List<dynamic>();
            
            this.Invoke((MethodInvoker)delegate
            {
                dgv_DanhSachHV.Rows.Clear();
                foreach (var hv in dataHocVien)
                {
                    foreach (var lh in hv.hoaDonKhoaHocs)
                    {
                        if ((int)lh.idLopHoc == lopHocId)
                        {
                            dgv_DanhSachHV.Rows.Add(hv.tenHv, hv.ngaySinh.ToString("dd/MM/yyyy"), hv.gioiTinh, hv.phuHuynh);
                            break;
                        }
                    }
                }
                
            });
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (!checkInit) return;
            comboBox_KhoaHoc.SelectedIndexChanged -= comboBox_KhoaHoc_SelectedIndexChanged;
            comboBox_KhoaHoc.DataSource = originalKhoaHocList;
            comboBox_KhoaHoc.DisplayMember = "Text";
            comboBox_KhoaHoc.ValueMember = "Value";
            comboBox_KhoaHoc.SelectedIndex = -1;

            comboBox_LopHoc.DataSource = null;
            comboBox_LopHoc.SelectedIndex = -1;
            comboBox_KhoaHoc.SelectedIndexChanged += comboBox_KhoaHoc_SelectedIndexChanged;

            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    dgv_DanhSachHV.Rows.Clear();
                    foreach (var hv in dataHocVien)
                    {
                        dgv_DanhSachHV.Rows.Add(hv.tenHv, hv.ngaySinh.ToString("dd/MM/yyyy"), hv.gioiTinh, hv.phuHuynh);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu học viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
    }
}
