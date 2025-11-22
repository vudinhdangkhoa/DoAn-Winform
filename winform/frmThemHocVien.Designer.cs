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
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM MỚI HỒ SƠ ĐĂNG KÝ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPhuHuynh
            // 
            this.grpPhuHuynh.Controls.Add(this.tblInputPH);
            this.grpPhuHuynh.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpPhuHuynh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPhuHuynh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPhuHuynh.ForeColor = System.Drawing.Color.Black;
            this.grpPhuHuynh.Location = new System.Drawing.Point(0, 62);
            this.grpPhuHuynh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPhuHuynh.Name = "grpPhuHuynh";
            this.grpPhuHuynh.Size = new System.Drawing.Size(1200, 135);
            this.grpPhuHuynh.TabIndex = 1;
            this.grpPhuHuynh.Text = "Thông tin Phụ Huynh";
            // 
            // tblInputPH
            // 
            this.tblInputPH.BackColor = System.Drawing.Color.Transparent;
            this.tblInputPH.ColumnCount = 5;
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblInputPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInputPH.Controls.Add(this.txtTenPH, 0, 0);
            this.tblInputPH.Controls.Add(this.txtSdtPH, 1, 0);
            this.tblInputPH.Controls.Add(this.txtEmailPH, 2, 0);
            this.tblInputPH.Controls.Add(this.cboGioiTinhPH, 3, 0);
            this.tblInputPH.Controls.Add(this.dtpNgaySinhPH, 4, 0);
            this.tblInputPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInputPH.Location = new System.Drawing.Point(0, 40);
            this.tblInputPH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblInputPH.Name = "tblInputPH";
            this.tblInputPH.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tblInputPH.RowCount = 1;
            this.tblInputPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInputPH.Size = new System.Drawing.Size(1200, 95);
            this.tblInputPH.TabIndex = 0;
            // 
            // txtTenPH
            // 
            this.txtTenPH.BorderRadius = 5;
            this.txtTenPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPH.DefaultText = "";
            this.txtTenPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenPH.Location = new System.Drawing.Point(20, 18);
            this.txtTenPH.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.PlaceholderText = "Họ tên phụ huynh";
            this.txtTenPH.SelectedText = "";
            this.txtTenPH.Size = new System.Drawing.Size(279, 44);
            this.txtTenPH.TabIndex = 0;
            // 
            // txtSdtPH
            // 
            this.txtSdtPH.BorderRadius = 5;
            this.txtSdtPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdtPH.DefaultText = "";
            this.txtSdtPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSdtPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSdtPH.Location = new System.Drawing.Point(313, 18);
            this.txtSdtPH.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSdtPH.Name = "txtSdtPH";
            this.txtSdtPH.PlaceholderText = "Số điện thoại";
            this.txtSdtPH.SelectedText = "";
            this.txtSdtPH.Size = new System.Drawing.Size(162, 44);
            this.txtSdtPH.TabIndex = 1;
            // 
            // txtEmailPH
            // 
            this.txtEmailPH.BorderRadius = 5;
            this.txtEmailPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailPH.DefaultText = "";
            this.txtEmailPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmailPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailPH.Location = new System.Drawing.Point(489, 18);
            this.txtEmailPH.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEmailPH.Name = "txtEmailPH";
            this.txtEmailPH.PlaceholderText = "Email";
            this.txtEmailPH.SelectedText = "";
            this.txtEmailPH.Size = new System.Drawing.Size(279, 44);
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
            this.cboGioiTinhPH.ItemHeight = 30;
            this.cboGioiTinhPH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhPH.Location = new System.Drawing.Point(782, 18);
            this.cboGioiTinhPH.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboGioiTinhPH.Name = "cboGioiTinhPH";
            this.cboGioiTinhPH.Size = new System.Drawing.Size(162, 36);
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
            this.dtpNgaySinhPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinhPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhPH.Location = new System.Drawing.Point(958, 18);
            this.dtpNgaySinhPH.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtpNgaySinhPH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhPH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhPH.Name = "dtpNgaySinhPH";
            this.dtpNgaySinhPH.Size = new System.Drawing.Size(222, 44);
            this.dtpNgaySinhPH.TabIndex = 4;
            this.dtpNgaySinhPH.Value = new System.DateTime(2025, 11, 20, 0, 16, 40, 559);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnThemDong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Location = new System.Drawing.Point(0, 776);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1200, 86);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1027, 18);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 49);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Đóng";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(840, 18);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 49);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU DỮ LIỆU";
            // 
            // btnThemDong
            // 
            this.btnThemDong.BorderRadius = 5;
            this.btnThemDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemDong.ForeColor = System.Drawing.Color.White;
            this.btnThemDong.Location = new System.Drawing.Point(27, 18);
            this.btnThemDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.Size = new System.Drawing.Size(200, 49);
            this.btnThemDong.TabIndex = 0;
            this.btnThemDong.Text = "+ Thêm học viên";
            // 
            // flowPanelHocViens
            // 
            this.flowPanelHocViens.AutoScroll = true;
            this.flowPanelHocViens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.flowPanelHocViens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelHocViens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelHocViens.Location = new System.Drawing.Point(0, 197);
            this.flowPanelHocViens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowPanelHocViens.Name = "flowPanelHocViens";
            this.flowPanelHocViens.Padding = new System.Windows.Forms.Padding(27, 12, 0, 0);
            this.flowPanelHocViens.Size = new System.Drawing.Size(1200, 579);
            this.flowPanelHocViens.TabIndex = 2;
            this.flowPanelHocViens.WrapContents = false;
            this.flowPanelHocViens.SizeChanged += new System.EventHandler(this.flowPanelHocViens_SizeChanged);
            // 
            // frmThemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 862);
            this.Controls.Add(this.flowPanelHocViens);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpPhuHuynh);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        // THÊM BIẾN NÀY
        private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinhPH;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhPH;
        private System.Windows.Forms.FlowLayoutPanel flowPanelHocViens;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThemDong;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    } 
}