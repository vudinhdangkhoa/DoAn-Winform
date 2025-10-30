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
    public partial class tongQuan : UserControl
    {
        public tongQuan()
        {
            InitializeComponent();
        }
        private async void tongQuan_Load(object sender, EventArgs e)
        {
            lblSoLuongKhoaHoc.Text = "...";
            lblSoLuongHocVien.Text = "...";
            lblSoLuongGiaoVien.Text = "...";
            lblDoanhThuThang.Text = "...";
            var data = await DungChung.GetDataTongQuan("Dashboard/GetThongTinDashBoard");
            if (data != null)
            {
                Console.WriteLine(data);
                this.Invoke((MethodInvoker)delegate
                {
                    lblSoLuongGiaoVien.Text = data.soLuongGiaoVien.ToString();
                    lblSoLuongHocVien.Text = data.soLuongHocVien.ToString();
                    lblSoLuongKhoaHoc.Text = data.soLuongKhoaHoc.ToString();
                    lblDoanhThuThang.Text = String.Format("{0:0,0}", data.doanhThuThang) + " VND";
                });

            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblSoLuongKhoaHoc.Text = "0";
                    lblSoLuongHocVien.Text = "0";
                    lblSoLuongGiaoVien.Text = "0";
                    lblDoanhThuThang.Text = "0 VND";
                });

            }

            GetSoLuongHocVienMoiTrong6Thang();

        }

        private async void GetSoLuongHocVienMoiTrong6Thang()
        {
            try
            {
                var data = await DungChung.GetSoLuongHocVienMoiTrong6Thang();

                if (data != null)
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        chart_HocVienMoi.Series["HocVienMoi"].Points.Clear();
                        chart_HocVienMoi.Titles.Clear();
                        chart_HocVienMoi.Titles.Add("Số lượng học viên mới trong 6 tháng gần nhất");
                        foreach (var item in data)
                        {
                            chart_HocVienMoi.Series["HocVienMoi"].Points.AddXY(item.month, item.count);
                        }
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private async void GetLopHocItem()
        {

            try
            {
                var data= await DungChung.GetLopHocItem();
                if(data != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        flpLopHocSapKhaiGiang.Controls.Clear();
                        foreach(var lop in data)
                        {
                            var item = new LopHocItem(lop.tenLopHoc,lop.khoaHoc, lop.giaoVien,lop.soLuongHv,lop.SoLuongToiDa);
                            flpLopHocSapKhaiGiang.Controls.Add(item);
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }

        }
    }
}
