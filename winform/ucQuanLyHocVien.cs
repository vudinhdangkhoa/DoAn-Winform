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
        public ucQuanLyHocVien()
        {
            InitializeComponent();
            LoadData();
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

            var dataKhoaHoc = await UCQuanLyHocVien.GetKhoaHoc();
            if (dataKhoaHoc != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        
                        var khoaHocList = new List<object>();
                        foreach (var kh in dataKhoaHoc)
                        {
                            khoaHocList.Add(new { Text = (string)kh.tenKhoaHoc, Value = (int)kh.idKhoaHoc });
                        }

                        comboBox_KhoaHoc.DataSource = khoaHocList;

                        comboBox_KhoaHoc.DisplayMember = "Text";   
                        comboBox_KhoaHoc.ValueMember = "Value";
                        comboBox_KhoaHoc.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải dữ liệu khóa học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }


        }
    }
}
