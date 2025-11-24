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
            this.lblTitle = new System.Windows.Forms.Label();

            // Phần thông tin cũ
            this.grpThongTinCu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblLichCu = new System.Windows.Forms.Label();
            this.txtLichCu = new Guna.UI2.WinForms.Guna2TextBox();

            // Phần nhập liệu mới
            this.grpLichMoi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkCoLichBu = new Guna.UI2.WinForms.Guna2CheckBox();

            this.lblNgayBu = new System.Windows.Forms.Label();
            this.dtpNgayBu = new Guna.UI2.WinForms.Guna2DateTimePicker();

            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker(); // Dùng chuẩn Winform cho TimePicker dễ chỉnh

            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();

            this.lblPhongBu = new System.Windows.Forms.Label();
            this.cboPhongBu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnKiemTraPhong = new Guna.UI2.WinForms.Guna2Button(); // Nút check phòng trống

            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();

            this.pnlMain.SuspendLayout();
            this.grpThongTinCu.SuspendLayout();
            this.grpLichMoi.SuspendLayout();
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
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(600, 550);
            this.pnlMain.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XỬ LÝ NGHỈ & DẠY BÙ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpThongTinCu
            // 
            this.grpThongTinCu.Controls.Add(this.txtLichCu);
            this.grpThongTinCu.Controls.Add(this.lblLichCu);
            this.grpThongTinCu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTinCu.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
            this.grpThongTinCu.Location = new System.Drawing.Point(20, 60);
            this.grpThongTinCu.Name = "grpThongTinCu";
            this.grpThongTinCu.Size = new System.Drawing.Size(560, 100);
            this.grpThongTinCu.Text = "Thông tin buổi nghỉ";

            this.lblLichCu.AutoSize = true;
            this.lblLichCu.Location = new System.Drawing.Point(15, 50);
            this.lblLichCu.Text = "Buổi học cũ:";

            this.txtLichCu.Location = new System.Drawing.Point(100, 45);
            this.txtLichCu.Size = new System.Drawing.Size(440, 36);
            this.txtLichCu.ReadOnly = true;
            this.txtLichCu.BorderRadius = 5;

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
            this.grpLichMoi.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
            this.grpLichMoi.Location = new System.Drawing.Point(20, 180);
            this.grpLichMoi.Name = "grpLichMoi";
            this.grpLichMoi.Size = new System.Drawing.Size(560, 280);
            this.grpLichMoi.Text = "Sắp xếp lịch bù";

            this.chkCoLichBu.AutoSize = true;
            this.chkCoLichBu.Checked = true;
            this.chkCoLichBu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoLichBu.Location = new System.Drawing.Point(20, 50);
            this.chkCoLichBu.Name = "chkCoLichBu";
            this.chkCoLichBu.Size = new System.Drawing.Size(150, 19);
            this.chkCoLichBu.Text = "Có sắp xếp lịch bù ngay";

            // Date
            this.lblNgayBu.AutoSize = true;
            this.lblNgayBu.Location = new System.Drawing.Point(20, 90);
            this.lblNgayBu.Text = "Ngày Dạy Bù:";

            this.dtpNgayBu.Location = new System.Drawing.Point(20, 110);
            this.dtpNgayBu.Size = new System.Drawing.Size(250, 36);
            this.dtpNgayBu.BorderRadius = 5;
            this.dtpNgayBu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBu.FillColor = System.Drawing.Color.White;

            // Time Start
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Location = new System.Drawing.Point(290, 90);
            this.lblGioBatDau.Text = "Bắt Đầu:";

            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Location = new System.Drawing.Point(290, 115);
            this.dtpGioBatDau.Size = new System.Drawing.Size(110, 23);

            // Time End
            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.Location = new System.Drawing.Point(420, 90);
            this.lblGioKetThuc.Text = "Kết Thúc:";

            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(420, 115);
            this.dtpGioKetThuc.Size = new System.Drawing.Size(110, 23);

            // Room
            this.lblPhongBu.AutoSize = true;
            this.lblPhongBu.Location = new System.Drawing.Point(20, 170);
            this.lblPhongBu.Text = "Phòng Trống (Chọn ngày giờ để lọc):";

            this.cboPhongBu.Location = new System.Drawing.Point(20, 190);
            this.cboPhongBu.Size = new System.Drawing.Size(350, 36);
            this.cboPhongBu.BorderRadius = 5;
            this.cboPhongBu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Button Check Room
            this.btnKiemTraPhong.Text = "Lấy DS Phòng";
            this.btnKiemTraPhong.Location = new System.Drawing.Point(390, 190);
            this.btnKiemTraPhong.Size = new System.Drawing.Size(140, 36);
            this.btnKiemTraPhong.BorderRadius = 5;
            this.btnKiemTraPhong.FillColor = System.Drawing.Color.Gray;

            // 
            // Buttons
            // 
            this.btnLuu.Text = "XÁC NHẬN ĐỔI LỊCH";
            this.btnLuu.Location = new System.Drawing.Point(300, 480);
            this.btnLuu.Size = new System.Drawing.Size(200, 45);
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(46, 204, 113);

            this.btnHuy.Text = "HỦY BỎ";
            this.btnHuy.Location = new System.Drawing.Point(80, 480);
            this.btnHuy.Size = new System.Drawing.Size(150, 45);
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(231, 76, 60);

            // Form Config
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuLyHocBu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xử Lý Học Bù";

            this.pnlMain.ResumeLayout(false);
            this.grpThongTinCu.ResumeLayout(false);
            this.grpThongTinCu.PerformLayout();
            this.grpLichMoi.ResumeLayout(false);
            this.grpLichMoi.PerformLayout();
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