namespace winform
{
    partial class frmAddHoaCu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenHocCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoaiHocCu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtDonViTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.numGiaBan = new Guna.UI2.WinForms.Guna2NumericUpDown();

            this.lblTen = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();

            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();

            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.btnHuy);
            this.pnlMain.Controls.Add(this.btnLuu);
            this.pnlMain.Controls.Add(this.lblGia);
            this.pnlMain.Controls.Add(this.lblDVT);
            this.pnlMain.Controls.Add(this.lblSoLuong);
            this.pnlMain.Controls.Add(this.lblLoai);
            this.pnlMain.Controls.Add(this.lblTen);
            this.pnlMain.Controls.Add(this.numGiaBan);
            this.pnlMain.Controls.Add(this.txtDonViTinh);
            this.pnlMain.Controls.Add(this.numSoLuong);
            this.pnlMain.Controls.Add(this.cboLoaiHocCu);
            this.pnlMain.Controls.Add(this.txtTenHocCu);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 500);
            this.pnlMain.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM HỌA CỤ MỚI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTen.Location = new System.Drawing.Point(40, 80);
            this.lblTen.Text = "Tên Họa Cụ:";
            // 
            // txtTenHocCu
            // 
            this.txtTenHocCu.BorderRadius = 5;
            this.txtTenHocCu.Location = new System.Drawing.Point(40, 100);
            this.txtTenHocCu.Size = new System.Drawing.Size(420, 36);
            this.txtTenHocCu.PlaceholderText = "Nhập tên họa cụ...";

            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoai.Location = new System.Drawing.Point(40, 150);
            this.lblLoai.Text = "Loại Họa Cụ:";
            // 
            // cboLoaiHocCu
            // 
            this.cboLoaiHocCu.BorderRadius = 5;
            this.cboLoaiHocCu.Location = new System.Drawing.Point(40, 170);
            this.cboLoaiHocCu.Size = new System.Drawing.Size(420, 36);
            this.cboLoaiHocCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.Location = new System.Drawing.Point(40, 220);
            this.lblSoLuong.Text = "Số Lượng Ban Đầu:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.BorderRadius = 5;
            this.numSoLuong.Location = new System.Drawing.Point(40, 240);
            this.numSoLuong.Size = new System.Drawing.Size(200, 36);
            this.numSoLuong.Maximum = 10000;

            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDVT.Location = new System.Drawing.Point(260, 220);
            this.lblDVT.Text = "Đơn Vị Tính:";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BorderRadius = 5;
            this.txtDonViTinh.Location = new System.Drawing.Point(260, 240);
            this.txtDonViTinh.Size = new System.Drawing.Size(200, 36);
            this.txtDonViTinh.PlaceholderText = "Ví dụ: Cái, Hộp...";

            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGia.Location = new System.Drawing.Point(40, 290);
            this.lblGia.Text = "Giá Bán (VNĐ):";
            // 
            // numGiaBan
            // 
            this.numGiaBan.BorderRadius = 5;
            this.numGiaBan.Location = new System.Drawing.Point(40, 310);
            this.numGiaBan.Size = new System.Drawing.Size(420, 36);
            this.numGiaBan.Maximum = 1000000000;
            this.numGiaBan.ThousandsSeparator = true;

            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(260, 380);
            this.btnLuu.Size = new System.Drawing.Size(200, 45);
            this.btnLuu.Text = "LƯU LẠI";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(40, 380);
            this.btnHuy.Size = new System.Drawing.Size(200, 45);
            this.btnHuy.Text = "HỦY BỎ";

            // 
            // frmAddHoaCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddHoaCu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Họa Cụ";

            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHocCu;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiHocCu;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtDonViTinh;
        private Guna.UI2.WinForms.Guna2NumericUpDown numGiaBan;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblGia;
    }
}