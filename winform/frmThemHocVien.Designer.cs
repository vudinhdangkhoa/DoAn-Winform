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
            this.dtpNgaySinhPH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtEmailPH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdtPH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenPH = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemDong = new Guna.UI2.WinForms.Guna2Button();
            this.flowPanelHocViens = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.grpPhuHuynh.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // --- 1. HEADER ---
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(850, 50);
            this.pnlTop.TabIndex = 0;

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(850, 50);
            this.lblTitle.Text = "THÊM MỚI HỒ SƠ ĐĂNG KÝ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- 2. GROUP BOX PHỤ HUYNH ---
            this.grpPhuHuynh.Controls.Add(this.dtpNgaySinhPH);
            this.grpPhuHuynh.Controls.Add(this.txtEmailPH);
            this.grpPhuHuynh.Controls.Add(this.txtSdtPH);
            this.grpPhuHuynh.Controls.Add(this.txtTenPH);
            this.grpPhuHuynh.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpPhuHuynh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPhuHuynh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPhuHuynh.ForeColor = System.Drawing.Color.Black;
            this.grpPhuHuynh.Location = new System.Drawing.Point(0, 50);
            this.grpPhuHuynh.Name = "grpPhuHuynh";
            this.grpPhuHuynh.Size = new System.Drawing.Size(850, 110);
            this.grpPhuHuynh.TabIndex = 1;
            this.grpPhuHuynh.Text = "Thông tin Phụ Huynh";

            // txtTenPH
            this.txtTenPH.BorderRadius = 5;
            this.txtTenPH.Location = new System.Drawing.Point(20, 55);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.PlaceholderText = "Họ tên phụ huynh";
            this.txtTenPH.Size = new System.Drawing.Size(250, 36);

            // txtSdtPH
            this.txtSdtPH.BorderRadius = 5;
            this.txtSdtPH.Location = new System.Drawing.Point(290, 55);
            this.txtSdtPH.Name = "txtSdtPH";
            this.txtSdtPH.PlaceholderText = "Số điện thoại";
            this.txtSdtPH.Size = new System.Drawing.Size(150, 36);

            // txtEmailPH
            this.txtEmailPH.BorderRadius = 5;
            this.txtEmailPH.Location = new System.Drawing.Point(460, 55);
            this.txtEmailPH.Name = "txtEmailPH";
            this.txtEmailPH.PlaceholderText = "Email";
            this.txtEmailPH.Size = new System.Drawing.Size(200, 36);

            // dtpNgaySinhPH
            this.dtpNgaySinhPH.BorderRadius = 5;
            this.dtpNgaySinhPH.BorderThickness = 1;
            this.dtpNgaySinhPH.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinhPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhPH.Location = new System.Drawing.Point(680, 55);
            this.dtpNgaySinhPH.Name = "dtpNgaySinhPH";
            this.dtpNgaySinhPH.Size = new System.Drawing.Size(140, 36);
            this.dtpNgaySinhPH.Font = new System.Drawing.Font("Segoe UI", 9F);

            // --- 3. BOTTOM PANEL (BUTTONS) ---
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnThemDong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Location = new System.Drawing.Point(0, 630);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(850, 70);
            this.pnlBottom.TabIndex = 3;

            // btnThemDong
            this.btnThemDong.BorderRadius = 5;
            this.btnThemDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemDong.ForeColor = System.Drawing.Color.White;
            this.btnThemDong.Location = new System.Drawing.Point(20, 15);
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.Size = new System.Drawing.Size(150, 40);
            this.btnThemDong.Text = "+ Thêm học viên";

            // btnLuu
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(580, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.Text = "LƯU DỮ LIỆU";

            // btnHuy
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(720, 15);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.Text = "Đóng";

            // --- 4. FLOW LAYOUT PANEL (DANH SÁCH) ---
            this.flowPanelHocViens.AutoScroll = true;
            this.flowPanelHocViens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.flowPanelHocViens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelHocViens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelHocViens.Location = new System.Drawing.Point(0, 160);
            this.flowPanelHocViens.Name = "flowPanelHocViens";
            this.flowPanelHocViens.WrapContents = false;
            this.flowPanelHocViens.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowPanelHocViens.Size = new System.Drawing.Size(850, 470);
            this.flowPanelHocViens.TabIndex = 2;

            // --- FORM SETTINGS ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.Controls.Add(this.flowPanelHocViens);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpPhuHuynh);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmThemHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Học Viên";

            this.pnlTop.ResumeLayout(false);
            this.grpPhuHuynh.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        // KHAI BÁO BIẾN
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox grpPhuHuynh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPH;
        private Guna.UI2.WinForms.Guna2TextBox txtSdtPH;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailPH;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhPH;
        private System.Windows.Forms.FlowLayoutPanel flowPanelHocViens;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThemDong;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    } 
}