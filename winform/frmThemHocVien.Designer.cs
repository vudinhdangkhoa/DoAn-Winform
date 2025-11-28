namespace winform
{
    partial class frmThemHocVien
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
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPhuHuynh = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblInputPH = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenPH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdtPH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailPH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboGioiTinhPH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgaySinhPH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemDong = new Guna.UI2.WinForms.Guna2Button();
            this.flowPanelHocViens = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.grpPhuHuynh.SuspendLayout();
            this.tblInputPH.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlTop.ShadowDecoration.Enabled = true;
            this.pnlTop.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlTop.Size = new System.Drawing.Size(1200, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM MỚI HỒ SƠ ĐĂNG KÝ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPhuHuynh
            // 
            this.grpPhuHuynh.BackColor = System.Drawing.Color.Transparent;
            this.grpPhuHuynh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.grpPhuHuynh.BorderRadius = 10;
            this.grpPhuHuynh.Controls.Add(this.tblInputPH);
            this.grpPhuHuynh.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.grpPhuHuynh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPhuHuynh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhuHuynh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpPhuHuynh.Location = new System.Drawing.Point(0, 60);
            this.grpPhuHuynh.Name = "grpPhuHuynh";
            this.grpPhuHuynh.Padding = new System.Windows.Forms.Padding(10);
            this.grpPhuHuynh.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.grpPhuHuynh.ShadowDecoration.Enabled = true;
            this.grpPhuHuynh.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.grpPhuHuynh.Size = new System.Drawing.Size(1200, 120);
            this.grpPhuHuynh.TabIndex = 1;
            this.grpPhuHuynh.Text = "Thông tin Phụ Huynh";
            // 
            // tblInputPH
            // 
            this.tblInputPH.BackColor = System.Drawing.Color.White;
            this.tblInputPH.ColumnCount = 5;
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.915255F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.08475F));
            this.tblInputPH.Controls.Add(this.txtTenPH, 0, 0);
            this.tblInputPH.Controls.Add(this.txtSdtPH, 1, 0);
            this.tblInputPH.Controls.Add(this.txtEmailPH, 2, 0);
            this.tblInputPH.Controls.Add(this.cboGioiTinhPH, 3, 0);
            this.tblInputPH.Controls.Add(this.dtpNgaySinhPH, 4, 0);
            this.tblInputPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInputPH.Location = new System.Drawing.Point(10, 50);
            this.tblInputPH.Name = "tblInputPH";
            this.tblInputPH.RowCount = 1;
            this.tblInputPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInputPH.Size = new System.Drawing.Size(1180, 60);
            this.tblInputPH.TabIndex = 0;
            // 
            // txtTenPH
            // 
            this.txtTenPH.BorderRadius = 5;
            this.txtTenPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPH.DefaultText = "";
            this.txtTenPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenPH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenPH.Location = new System.Drawing.Point(5, 5);
            this.txtTenPH.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.PlaceholderText = "Họ tên phụ huynh";
            this.txtTenPH.SelectedText = "";
            this.txtTenPH.Size = new System.Drawing.Size(344, 40);
            this.txtTenPH.TabIndex = 0;
            this.txtTenPH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTen_KeyPress);
            // 
            // txtSdtPH
            // 
            this.txtSdtPH.BorderRadius = 5;
            this.txtSdtPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdtPH.DefaultText = "";
            this.txtSdtPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSdtPH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSdtPH.Location = new System.Drawing.Point(359, 5);
            this.txtSdtPH.Margin = new System.Windows.Forms.Padding(5);
            this.txtSdtPH.Name = "txtSdtPH";
            this.txtSdtPH.PlaceholderText = "Số điện thoại";
            this.txtSdtPH.SelectedText = "";
            this.txtSdtPH.Size = new System.Drawing.Size(226, 40);
            this.txtSdtPH.TabIndex = 1;
            // 
            // txtEmailPH
            // 
            this.txtEmailPH.BorderRadius = 5;
            this.txtEmailPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailPH.DefaultText = "";
            this.txtEmailPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmailPH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmailPH.Location = new System.Drawing.Point(595, 5);
            this.txtEmailPH.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmailPH.Name = "txtEmailPH";
            this.txtEmailPH.PlaceholderText = "Email";
            this.txtEmailPH.SelectedText = "";
            this.txtEmailPH.Size = new System.Drawing.Size(285, 40);
            this.txtEmailPH.TabIndex = 2;
            // 
            // cboGioiTinhPH
            // 
            this.cboGioiTinhPH.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinhPH.BorderRadius = 5;
            this.cboGioiTinhPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboGioiTinhPH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinhPH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhPH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinhPH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinhPH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinhPH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinhPH.ItemHeight = 34;
            this.cboGioiTinhPH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhPH.Location = new System.Drawing.Point(890, 5);
            this.cboGioiTinhPH.Margin = new System.Windows.Forms.Padding(5);
            this.cboGioiTinhPH.Name = "cboGioiTinhPH";
            this.cboGioiTinhPH.Size = new System.Drawing.Size(107, 40);
            this.cboGioiTinhPH.StartIndex = 0;
            this.cboGioiTinhPH.TabIndex = 3;
            // 
            // dtpNgaySinhPH
            // 
            this.dtpNgaySinhPH.BorderRadius = 5;
            this.dtpNgaySinhPH.BorderThickness = 1;
            this.dtpNgaySinhPH.Checked = true;
            this.dtpNgaySinhPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgaySinhPH.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinhPH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgaySinhPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhPH.Location = new System.Drawing.Point(1007, 5);
            this.dtpNgaySinhPH.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgaySinhPH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhPH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhPH.Name = "dtpNgaySinhPH";
            this.dtpNgaySinhPH.Size = new System.Drawing.Size(168, 40);
            this.dtpNgaySinhPH.TabIndex = 4;
            this.dtpNgaySinhPH.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnThemDong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.FillColor = System.Drawing.Color.White;
            this.pnlBottom.Location = new System.Drawing.Point(0, 782);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlBottom.ShadowDecoration.Enabled = true;
            this.pnlBottom.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlBottom.Size = new System.Drawing.Size(1200, 80);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 6;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1034, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 45);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "HỦY BỎ";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 6;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(848, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 45);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU DỮ LIỆU";
            // 
            // btnThemDong
            // 
            this.btnThemDong.BorderRadius = 6;
            this.btnThemDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThemDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemDong.ForeColor = System.Drawing.Color.White;
            this.btnThemDong.Location = new System.Drawing.Point(25, 18);
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.Size = new System.Drawing.Size(220, 45);
            this.btnThemDong.TabIndex = 0;
            this.btnThemDong.Text = "+ THÊM HỌC VIÊN";
            // 
            // flowPanelHocViens
            // 
            this.flowPanelHocViens.AutoScroll = true;
            this.flowPanelHocViens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.flowPanelHocViens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelHocViens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelHocViens.Location = new System.Drawing.Point(0, 180);
            this.flowPanelHocViens.Name = "flowPanelHocViens";
            this.flowPanelHocViens.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.flowPanelHocViens.Size = new System.Drawing.Size(1200, 602);
            this.flowPanelHocViens.TabIndex = 2;
            this.flowPanelHocViens.WrapContents = false;
            this.flowPanelHocViens.SizeChanged += new System.EventHandler(this.flowPanelHocViens_SizeChanged);
            // 
            // frmThemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1200, 862);
            this.Controls.Add(this.flowPanelHocViens);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpPhuHuynh);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmThemHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Học Viên";
            this.pnlTop.ResumeLayout(false);
            this.grpPhuHuynh.ResumeLayout(false);
            this.tblInputPH.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox grpPhuHuynh;
        private System.Windows.Forms.TableLayoutPanel tblInputPH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPH;
        private Guna.UI2.WinForms.Guna2TextBox txtSdtPH;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailPH;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinhPH;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhPH;
        private System.Windows.Forms.FlowLayoutPanel flowPanelHocViens;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThemDong;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}