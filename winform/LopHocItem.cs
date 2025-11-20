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

        public event EventHandler OnItemClick;

        public int IdLopHoc { get; set; }

        public LopHocItem()
        {
            InitializeComponent();
        }
        public LopHocItem(string tenLop, string tenKH, string giaoVien, int soHocVien, int SLToiDa)
        {
            InitializeComponent();
            lblTenLop.Text = tenLop ;
            lblTenGV.Text +=" " + giaoVien;
            lblSiSo.Text ="Sỉ Số"+ soHocVien.ToString() + "/" + SLToiDa.ToString();

            if (soHocVien ==SLToiDa) // Giả sử 30 là full
            {
                pnlStatusStrip.FillColor = System.Drawing.Color.Red;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            OnItemClick?.Invoke(this, e);
        }
    }
}
