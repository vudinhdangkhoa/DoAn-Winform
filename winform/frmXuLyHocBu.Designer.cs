namespace winform
{
    partial class frmXuLyHocBu
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
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.grpLichMoi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnKiemTraPhong = new Guna.UI2.WinForms.Guna2Button();
            this.cboPhongBu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPhongBu = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayBu = new System.Windows.Forms.Label();
            this.chkCoLichBu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grpThongTinCu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtLichCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLichCu = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpLichMoi.SuspendLayout();
            this.grpThongTinCu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.Black;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.btnHuy);
            this.pnlMain.Controls.Add(this.btnLuu);
            this.pnlMain.Controls.Add(this.grpLichMoi);
            this.pnlMain.Controls.Add(this.grpThongTinCu);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 677);
            this.pnlMain.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(107, 591);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(200, 55);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "HỦY BỎ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(400, 591);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(267, 55);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "XÁC NHẬN ĐỔI LỊCH";
            // 
            // grpLichMoi
            // 
            this.grpLichMoi.Controls.Add(this.btnKiemTraPhong);
            this.grpLichMoi.Controls.Add(this.cboPhongBu);
            this.grpLichMoi.Controls.Add(this.lblPhongBu);
            this.grpLichMoi.Controls.Add(this.dtpGioKetThuc);
            this.grpLichMoi.Controls.Add(this.lblGioKetThuc);
            this.grpLichMoi.Controls.Add(this.dtpGioBatDau);
            this.grpLichMoi.Controls.Add(this.lblGioBatDau);
            this.grpLichMoi.Controls.Add(this.dtpNgayBu);
            this.grpLichMoi.Controls.Add(this.lblNgayBu);
            this.grpLichMoi.Controls.Add(this.chkCoLichBu);
            this.grpLichMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpLichMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpLichMoi.Location = new System.Drawing.Point(27, 222);
            this.grpLichMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLichMoi.Name = "grpLichMoi";
            this.grpLichMoi.Size = new System.Drawing.Size(747, 345);
            this.grpLichMoi.TabIndex = 2;
            this.grpLichMoi.Text = "Sắp xếp lịch bù";
            // 
            // btnKiemTraPhong
            // 
            this.btnKiemTraPhong.BorderRadius = 5;
            this.btnKiemTraPhong.FillColor = System.Drawing.Color.Gray;
            this.btnKiemTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKiemTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraPhong.Location = new System.Drawing.Point(520, 234);
            this.btnKiemTraPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKiemTraPhong.Name = "btnKiemTraPhong";
            this.btnKiemTraPhong.Size = new System.Drawing.Size(187, 44);
            this.btnKiemTraPhong.TabIndex = 0;
            this.btnKiemTraPhong.Text = "Lấy DS Phòng";
            // 
            // cboPhongBu
            // 
            this.cboPhongBu.BackColor = System.Drawing.Color.Transparent;
            this.cboPhongBu.BorderRadius = 5;
            this.cboPhongBu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhongBu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBu.FocusedColor = System.Drawing.Color.Empty;
            this.cboPhongBu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhongBu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhongBu.ItemHeight = 30;
            this.cboPhongBu.Location = new System.Drawing.Point(27, 234);
            this.cboPhongBu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPhongBu.Name = "cboPhongBu";
            this.cboPhongBu.Size = new System.Drawing.Size(465, 36);
            this.cboPhongBu.TabIndex = 1;
            // 
            // lblPhongBu
            // 
            this.lblPhongBu.AutoSize = true;
            this.lblPhongBu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhongBu.Location = new System.Drawing.Point(27, 209);
            this.lblPhongBu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongBu.Name = "lblPhongBu";
            this.lblPhongBu.Size = new System.Drawing.Size(264, 20);
            this.lblPhongBu.TabIndex = 2;
            this.lblPhongBu.Text = "Phòng Trống (Chọn ngày giờ để lọc):";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(560, 142);
            this.dtpGioKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(145, 27);
            this.dtpGioKetThuc.TabIndex = 3;
            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGioKetThuc.Location = new System.Drawing.Point(560, 111);
            this.lblGioKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(75, 20);
            this.lblGioKetThuc.TabIndex = 4;
            this.lblGioKetThuc.Text = "Kết Thúc:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(387, 142);
            this.dtpGioBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(145, 27);
            this.dtpGioBatDau.TabIndex = 5;
            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGioBatDau.Location = new System.Drawing.Point(387, 111);
            this.lblGioBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(69, 20);
            this.lblGioBatDau.TabIndex = 6;
            this.lblGioBatDau.Text = "Bắt Đầu:";
            // 
            // dtpNgayBu
            // 
            this.dtpNgayBu.BorderRadius = 5;
            this.dtpNgayBu.Checked = true;
            this.dtpNgayBu.FillColor = System.Drawing.Color.White;
            this.dtpNgayBu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBu.Location = new System.Drawing.Point(27, 135);
            this.dtpNgayBu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayBu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBu.Name = "dtpNgayBu";
            this.dtpNgayBu.Size = new System.Drawing.Size(333, 44);
            this.dtpNgayBu.TabIndex = 7;
            this.dtpNgayBu.Value = new System.DateTime(2025, 11, 28, 13, 31, 32, 707);
            // 
            // lblNgayBu
            // 
            this.lblNgayBu.AutoSize = true;
            this.lblNgayBu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNgayBu.Location = new System.Drawing.Point(27, 111);
            this.lblNgayBu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayBu.Name = "lblNgayBu";
            this.lblNgayBu.Size = new System.Drawing.Size(104, 20);
            this.lblNgayBu.TabIndex = 8;
            this.lblNgayBu.Text = "Ngày Dạy Bù:";
            // 
            // chkCoLichBu
            // 
            this.chkCoLichBu.AutoSize = true;
            this.chkCoLichBu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkCoLichBu.Checked = true;
            this.chkCoLichBu.CheckedState.BorderRadius = 0;
            this.chkCoLichBu.CheckedState.BorderThickness = 0;
            this.chkCoLichBu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoLichBu.Location = new System.Drawing.Point(27, 62);
            this.chkCoLichBu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCoLichBu.Name = "chkCoLichBu";
            this.chkCoLichBu.Size = new System.Drawing.Size(194, 24);
            this.chkCoLichBu.TabIndex = 9;
            this.chkCoLichBu.Text = "Có sắp xếp lịch bù ngay";
            this.chkCoLichBu.UncheckedState.BorderRadius = 0;
            this.chkCoLichBu.UncheckedState.BorderThickness = 0;
            this.chkCoLichBu.UseVisualStyleBackColor = false;
            // 
            // grpThongTinCu
            // 
            this.grpThongTinCu.Controls.Add(this.txtLichCu);
            this.grpThongTinCu.Controls.Add(this.lblLichCu);
            this.grpThongTinCu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTinCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpThongTinCu.Location = new System.Drawing.Point(27, 74);
            this.grpThongTinCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinCu.Name = "grpThongTinCu";
            this.grpThongTinCu.Size = new System.Drawing.Size(747, 123);
            this.grpThongTinCu.TabIndex = 3;
            this.grpThongTinCu.Text = "Thông tin buổi nghỉ";
            // 
            // txtLichCu
            // 
            this.txtLichCu.BorderRadius = 5;
            this.txtLichCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLichCu.DefaultText = "";
            this.txtLichCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLichCu.Location = new System.Drawing.Point(133, 55);
            this.txtLichCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLichCu.Name = "txtLichCu";
            this.txtLichCu.PlaceholderText = "";
            this.txtLichCu.ReadOnly = true;
            this.txtLichCu.SelectedText = "";
            this.txtLichCu.Size = new System.Drawing.Size(587, 44);
            this.txtLichCu.TabIndex = 0;
            // 
            // lblLichCu
            // 
            this.lblLichCu.AutoSize = true;
            this.lblLichCu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLichCu.ForeColor = System.Drawing.Color.Gray;
            this.lblLichCu.Location = new System.Drawing.Point(20, 62);
            this.lblLichCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLichCu.Name = "lblLichCu";
            this.lblLichCu.Size = new System.Drawing.Size(94, 20);
            this.lblLichCu.TabIndex = 1;
            this.lblLichCu.Text = "Buổi học cũ:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XỬ LÝ NGHỈ & DẠY BÙ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmXuLyHocBu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXuLyHocBu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xử Lý Học Bù";
            this.pnlMain.ResumeLayout(false);
            this.grpLichMoi.ResumeLayout(false);
            this.grpLichMoi.PerformLayout();
            this.grpThongTinCu.ResumeLayout(false);
            this.grpThongTinCu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox grpThongTinCu;
        private System.Windows.Forms.Label lblLichCu;
        private Guna.UI2.WinForms.Guna2TextBox txtLichCu;

        private Guna.UI2.WinForms.Guna2GroupBox grpLichMoi;
        private Guna.UI2.WinForms.Guna2CheckBox chkCoLichBu;
        private System.Windows.Forms.Label lblNgayBu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBu;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblPhongBu;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhongBu;
        private Guna.UI2.WinForms.Guna2Button btnKiemTraPhong;

        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}