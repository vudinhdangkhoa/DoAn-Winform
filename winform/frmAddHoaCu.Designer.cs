namespace winform
{
    partial class frmAddHoaCu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.numGiaBan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cboDonViTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cboLoaiHocCu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenHocCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
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
            this.pnlMain.Controls.Add(this.cboDonViTinh);
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
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(40, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(200, 45);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "HỦY BỎ";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(260, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(200, 45);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU LẠI";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGia.Location = new System.Drawing.Point(40, 290);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(116, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá Bán (VNĐ):";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDVT.Location = new System.Drawing.Point(260, 220);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(95, 20);
            this.lblDVT.TabIndex = 3;
            this.lblDVT.Text = "Đơn Vị Tính:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.Location = new System.Drawing.Point(40, 220);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(142, 20);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số Lượng Ban Đầu:";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoai.Location = new System.Drawing.Point(40, 150);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(96, 20);
            this.lblLoai.TabIndex = 5;
            this.lblLoai.Text = "Loại Họa Cụ:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTen.Location = new System.Drawing.Point(40, 80);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(92, 20);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên Họa Cụ:";
            // 
            // numGiaBan
            // 
            this.numGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.numGiaBan.BorderRadius = 5;
            this.numGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numGiaBan.Location = new System.Drawing.Point(40, 310);
            this.numGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numGiaBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(420, 36);
            this.numGiaBan.TabIndex = 7;
            this.numGiaBan.ThousandsSeparator = true;
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboDonViTinh.BorderRadius = 5;
            this.cboDonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboDonViTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDonViTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.ItemHeight = 30;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Hộp",
            "Tờ"});
            this.cboDonViTinh.Location = new System.Drawing.Point(260, 240);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(200, 36);
            this.cboDonViTinh.StartIndex = 0;
            this.cboDonViTinh.TabIndex = 8;
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.BorderRadius = 5;
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuong.Location = new System.Drawing.Point(40, 240);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(200, 36);
            this.numSoLuong.TabIndex = 9;
            // 
            // cboLoaiHocCu
            // 
            this.cboLoaiHocCu.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiHocCu.BorderRadius = 5;
            this.cboLoaiHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiHocCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHocCu.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoaiHocCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiHocCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiHocCu.ItemHeight = 30;
            this.cboLoaiHocCu.Location = new System.Drawing.Point(40, 170);
            this.cboLoaiHocCu.Name = "cboLoaiHocCu";
            this.cboLoaiHocCu.Size = new System.Drawing.Size(420, 36);
            this.cboLoaiHocCu.TabIndex = 10;
            // 
            // txtTenHocCu
            // 
            this.txtTenHocCu.BorderRadius = 5;
            this.txtTenHocCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHocCu.DefaultText = "";
            this.txtTenHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHocCu.Location = new System.Drawing.Point(40, 100);
            this.txtTenHocCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHocCu.Name = "txtTenHocCu";
            this.txtTenHocCu.PlaceholderText = "Nhập tên họa cụ...";
            this.txtTenHocCu.SelectedText = "";
            this.txtTenHocCu.Size = new System.Drawing.Size(420, 36);
            this.txtTenHocCu.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "THÊM HỌA CỤ MỚI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHocCu;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiHocCu;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;

        // --- BIẾN MỚI ---
        private Guna.UI2.WinForms.Guna2ComboBox cboDonViTinh;
        // ----------------

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