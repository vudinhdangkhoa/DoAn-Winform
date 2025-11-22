namespace winform
{
    partial class ucQuanLyGiaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();

            // --- LEFT PANEL (LIST) ---
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddGV = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGiaoVien = new Guna.UI2.WinForms.Guna2DataGridView();

            // --- MIDDLE PANEL (DETAIL) ---
            this.pnlMiddle = new Guna.UI2.WinForms.Guna2Panel();
            this.grpDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUploadImg = new Guna.UI2.WinForms.Guna2Button();

            this.lblTenGV = new System.Windows.Forms.Label();
            this.txtTenGV = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();

            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.numKinhNghiem = new Guna.UI2.WinForms.Guna2NumericUpDown();

            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();

            // --- RIGHT PANEL (SCHEDULE) ---
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grpSchedule = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.treeLichDay = new System.Windows.Forms.TreeView();
            this.pnlRightHeader = new Guna.UI2.WinForms.Guna2Panel();

            this.tlpMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKinhNghiem)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F)); // Trái
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F)); // Giữa
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F)); // Phải
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlMiddle, 1, 0);
            this.tlpMain.Controls.Add(this.pnlRight, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1100, 650);
            this.tlpMain.TabIndex = 0;

            // 
            // === LEFT PANEL ===
            // 
            this.pnlLeft.Controls.Add(this.tlpLeft);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(5);

            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.pnlSearch, 0, 0);
            this.tlpLeft.Controls.Add(this.dgvGiaoVien, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // Search Box Area
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnAddGV);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtSearch.PlaceholderText = "Tìm giáo viên...";
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Location = new System.Drawing.Point(3, 10);
            this.txtSearch.Size = new System.Drawing.Size(200, 40);
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            this.btnAddGV.Text = "+";
            this.btnAddGV.BorderRadius = 5;
            this.btnAddGV.FillColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAddGV.Location = new System.Drawing.Point(210, 10);
            this.btnAddGV.Size = new System.Drawing.Size(50, 40);
            this.btnAddGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            // DataGridView
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersVisible = false;
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;

            // Basic DGV Style
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiaoVien.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle3;

            // 
            // === MIDDLE PANEL (DETAIL) ===
            // 
            this.pnlMiddle.Controls.Add(this.grpDetail);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Padding = new System.Windows.Forms.Padding(5);

            this.grpDetail.Text = "Thông Tin Chi Tiết";
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);

            // Avatar & Upload
            this.grpDetail.Controls.Add(this.picAvatar);
            this.grpDetail.Controls.Add(this.btnUploadImg);

            // Inputs
            this.grpDetail.Controls.Add(this.lblTenGV);
            this.grpDetail.Controls.Add(this.txtTenGV);
            this.grpDetail.Controls.Add(this.lblNgaySinh);
            this.grpDetail.Controls.Add(this.dtpNgaySinh);
            this.grpDetail.Controls.Add(this.lblSDT);
            this.grpDetail.Controls.Add(this.txtSDT);
            this.grpDetail.Controls.Add(this.lblKinhNghiem);
            this.grpDetail.Controls.Add(this.numKinhNghiem);

            // Action Buttons
            this.grpDetail.Controls.Add(this.btnLuu);
            this.grpDetail.Controls.Add(this.btnXoa);

            // -- Config Controls Middle --
            this.picAvatar.Location = new System.Drawing.Point(100, 50);
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.FillColor = System.Drawing.Color.Gainsboro;
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;

            this.btnUploadImg.Text = "Chọn Ảnh";
            this.btnUploadImg.Location = new System.Drawing.Point(110, 180);
            this.btnUploadImg.Size = new System.Drawing.Size(100, 30);
            this.btnUploadImg.BorderRadius = 15;
            this.btnUploadImg.FillColor = System.Drawing.Color.Gray;
            this.btnUploadImg.Font = new System.Drawing.Font("Segoe UI", 8F);

            this.lblTenGV.Text = "Họ Tên:";
            this.lblTenGV.Location = new System.Drawing.Point(20, 230);
            this.txtTenGV.Location = new System.Drawing.Point(20, 250);
            this.txtTenGV.Size = new System.Drawing.Size(280, 36);
            this.txtTenGV.BorderRadius = 5;

            this.lblNgaySinh.Text = "Ngày Sinh:";
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 300);
            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 320);
            this.dtpNgaySinh.Size = new System.Drawing.Size(280, 36);
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;

            this.lblSDT.Text = "Số Điện Thoại:";
            this.lblSDT.Location = new System.Drawing.Point(20, 370);
            this.txtSDT.Location = new System.Drawing.Point(20, 390);
            this.txtSDT.Size = new System.Drawing.Size(280, 36);
            this.txtSDT.BorderRadius = 5;

            this.lblKinhNghiem.Text = "Kinh Nghiệm (Năm):";
            this.lblKinhNghiem.Location = new System.Drawing.Point(20, 440);
            this.numKinhNghiem.Location = new System.Drawing.Point(20, 460);
            this.numKinhNghiem.Size = new System.Drawing.Size(280, 36);
            this.numKinhNghiem.BorderRadius = 5;

            this.btnLuu.Text = "Lưu Thay Đổi";
            this.btnLuu.Location = new System.Drawing.Point(160, 520);
            this.btnLuu.Size = new System.Drawing.Size(140, 45);
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(52, 152, 219);

            this.btnXoa.Text = "Xóa GV";
            this.btnXoa.Location = new System.Drawing.Point(20, 520);
            this.btnXoa.Size = new System.Drawing.Size(120, 45);
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(231, 76, 60);

            // 
            // === RIGHT PANEL (SCHEDULE) ===
            // 
            // Sửa lại cấu trúc: Panel Right chứa TableLayoutPanel 2 dòng (Header chưa nút - Body chứa TreeView)
            this.pnlRight.Controls.Add(this.grpSchedule); // Groupbox sẽ chứa TreeView
            this.pnlRight.Controls.Add(this.pnlRightHeader); // Panel mới chứa nút Xuất Excel
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Padding = new System.Windows.Forms.Padding(5);

            // 1. Panel Header (Chứa nút Xuất Excel) - Đặt lên trên cùng
            this.pnlRightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightHeader.Height = 50;
            this.pnlRightHeader.Controls.Add(this.btnXuatExcel);

            // Nút Xuất Excel
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Location = new System.Drawing.Point(0, 5);
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 35);
            this.btnXuatExcel.BorderRadius = 5;
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(39, 174, 96);
            // Neo bên phải của Panel Header
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           

            // 2. GroupBox (Chứa TreeView) - Dock Fill phần còn lại
            this.grpSchedule.Text = "Lịch Dạy Sắp Tới";
            this.grpSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSchedule.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
            this.grpSchedule.Controls.Add(this.treeLichDay);
            // Đẩy GroupBox xuống dưới Panel Header
            this.grpSchedule.BringToFront();

            // TreeView
            this.treeLichDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLichDay.Padding = new System.Windows.Forms.Padding(5);
            this.treeLichDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeLichDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeLichDay.ShowLines = true;
            this.treeLichDay.ShowPlusMinus = true;

            // 
            // ucQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQuanLyGiaoVien";
            this.Size = new System.Drawing.Size(1100, 650);

            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKinhNghiem)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpSchedule.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;

        // Left
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddGV;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiaoVien;

        // Middle
        private Guna.UI2.WinForms.Guna2Panel pnlMiddle;
        private Guna.UI2.WinForms.Guna2GroupBox grpDetail;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Button btnUploadImg;
        private System.Windows.Forms.Label lblTenGV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenGV;
        private System.Windows.Forms.Label lblNgaySinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label lblKinhNghiem;
        private Guna.UI2.WinForms.Guna2NumericUpDown numKinhNghiem;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnXoa;

        // Right
        private Guna.UI2.WinForms.Guna2Panel pnlRightHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpSchedule;
        private System.Windows.Forms.TreeView treeLichDay;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
    }
}
