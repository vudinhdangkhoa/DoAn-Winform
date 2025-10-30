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
    public partial class LopHocItem : UserControl
    {
        public LopHocItem()
        {
            InitializeComponent();
        }
        public LopHocItem(string tenLop,string tenKH,string giaoVien, int soHocVien, int SLToiDa)
        {
            InitializeComponent();
            lblTenLop.Text += tenLop+ "Khóa: "+ tenKH;
            lblTenGV.Text+= giaoVien;
            lblSiSo.Text += soHocVien.ToString() + "/" + SLToiDa.ToString();
            progressBar1.Value = (int)((soHocVien / (float)SLToiDa) * 100);
            progressBar1.Maximum = SLToiDa;
        }
    }
}
