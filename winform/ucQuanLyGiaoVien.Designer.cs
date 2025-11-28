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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddGV = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGiaoVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlMiddle = new Guna.UI2.WinForms.Guna2Panel();
            this.grpDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUploadImg = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.txtTenGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.numKinhNghiem = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grpSchedule = new Guna.UI2.WinForms.Guna2GroupBox();
            this.treeLichDay = new System.Windows.Forms.TreeView();
            this.pnlRightHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ResetFrm = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnlRightHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlMiddle, 1, 0);
            this.tlpMain.Controls.Add(this.pnlRight, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1467, 800);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.tlpLeft);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(4, 4);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlLeft.Size = new System.Drawing.Size(432, 792);
            this.pnlLeft.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.pnlSearch, 0, 0);
            this.tlpLeft.Controls.Add(this.dgvGiaoVien, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(7, 6);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(418, 780);
            this.tlpLeft.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnAddGV);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(410, 66);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(4, -16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm giáo viên...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(410, 49);
            this.txtSearch.TabIndex = 0;
            // 
            // btnAddGV
            // 
            this.btnAddGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGV.BorderRadius = 5;
            this.btnAddGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGV.ForeColor = System.Drawing.Color.White;
            this.btnAddGV.Location = new System.Drawing.Point(424, 12);
            this.btnAddGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(67, 49);
            this.btnAddGV.TabIndex = 1;
            this.btnAddGV.Text = "+";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGiaoVien.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.Location = new System.Drawing.Point(4, 78);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersVisible = false;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.Size = new System.Drawing.Size(410, 698);
            this.dgvGiaoVien.TabIndex = 1;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvGiaoVien.ThemeStyle.ReadOnly = true;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.grpDetail);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(444, 4);
            this.pnlMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlMiddle.Size = new System.Drawing.Size(432, 792);
            this.pnlMiddle.TabIndex = 1;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.picAvatar);
            this.grpDetail.Controls.Add(this.btnUploadImg);
            this.grpDetail.Controls.Add(this.lblTenGV);
            this.grpDetail.Controls.Add(this.txtTenGV);
            this.grpDetail.Controls.Add(this.lblNgaySinh);
            this.grpDetail.Controls.Add(this.dtpNgaySinh);
            this.grpDetail.Controls.Add(this.lblSDT);
            this.grpDetail.Controls.Add(this.txtSDT);
            this.grpDetail.Controls.Add(this.lblKinhNghiem);
            this.grpDetail.Controls.Add(this.numKinhNghiem);
            this.grpDetail.Controls.Add(this.btnLuu);
            this.grpDetail.Controls.Add(this.btnXoa);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpDetail.Location = new System.Drawing.Point(7, 6);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(418, 780);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.Text = "Thông Tin Chi Tiết";
            // 
            // picAvatar
            // 
            this.picAvatar.FillColor = System.Drawing.Color.Gainsboro;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(133, 62);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(160, 148);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.BorderRadius = 15;
            this.btnUploadImg.FillColor = System.Drawing.Color.Gray;
            this.btnUploadImg.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUploadImg.ForeColor = System.Drawing.Color.White;
            this.btnUploadImg.Location = new System.Drawing.Point(147, 222);
            this.btnUploadImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(133, 37);
            this.btnUploadImg.TabIndex = 1;
            this.btnUploadImg.Text = "Chọn Ảnh";
            // 
            // lblTenGV
            // 
            this.lblTenGV.Location = new System.Drawing.Point(27, 283);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(133, 28);
            this.lblTenGV.TabIndex = 2;
            this.lblTenGV.Text = "Họ Tên:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.BorderRadius = 5;
            this.txtTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGV.DefaultText = "";
            this.txtTenGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenGV.Location = new System.Drawing.Point(27, 308);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.PlaceholderText = "";
            this.txtTenGV.SelectedText = "";
            this.txtTenGV.Size = new System.Drawing.Size(373, 44);
            this.txtTenGV.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(27, 369);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(133, 28);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(27, 394);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(373, 44);
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 11, 27, 15, 51, 28, 389);
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(27, 455);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(133, 28);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderRadius = 5;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(27, 480);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(373, 44);
            this.txtSDT.TabIndex = 7;
            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.Location = new System.Drawing.Point(27, 542);
            this.lblKinhNghiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(133, 28);
            this.lblKinhNghiem.TabIndex = 8;
            this.lblKinhNghiem.Text = "Kinh Nghiệm (Năm):";
            // 
            // numKinhNghiem
            // 
            this.numKinhNghiem.BackColor = System.Drawing.Color.Transparent;
            this.numKinhNghiem.BorderRadius = 5;
            this.numKinhNghiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numKinhNghiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numKinhNghiem.Location = new System.Drawing.Point(27, 566);
            this.numKinhNghiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numKinhNghiem.Name = "numKinhNghiem";
            this.numKinhNghiem.Size = new System.Drawing.Size(373, 44);
            this.numKinhNghiem.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(213, 640);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(187, 55);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu Thay Đổi";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(27, 640);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 55);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa GV";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpSchedule);
            this.pnlRight.Controls.Add(this.pnlRightHeader);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(884, 4);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlRight.Size = new System.Drawing.Size(579, 792);
            this.pnlRight.TabIndex = 2;
            // 
            // grpSchedule
            // 
            this.grpSchedule.Controls.Add(this.treeLichDay);
            this.grpSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpSchedule.Location = new System.Drawing.Point(7, 68);
            this.grpSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(565, 718);
            this.grpSchedule.TabIndex = 0;
            this.grpSchedule.Text = "Lịch Dạy Sắp Tới";
            // 
            // treeLichDay
            // 
            this.treeLichDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeLichDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLichDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeLichDay.Location = new System.Drawing.Point(0, 40);
            this.treeLichDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeLichDay.Name = "treeLichDay";
            this.treeLichDay.Size = new System.Drawing.Size(565, 678);
            this.treeLichDay.TabIndex = 0;
            // 
            // pnlRightHeader
            // 
            this.pnlRightHeader.Controls.Add(this.btn_ResetFrm);
            this.pnlRightHeader.Controls.Add(this.btnXuatExcel);
            this.pnlRightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightHeader.Location = new System.Drawing.Point(7, 6);
            this.pnlRightHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRightHeader.Name = "pnlRightHeader";
            this.pnlRightHeader.Size = new System.Drawing.Size(565, 62);
            this.pnlRightHeader.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.BorderRadius = 5;
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(298, 6);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(133, 43);
            this.btnXuatExcel.TabIndex = 0;
            this.btnXuatExcel.Text = "Xuất Excel";
            // 
            // btn_ResetFrm
            // 
            this.btn_ResetFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ResetFrm.BorderRadius = 5;
            this.btn_ResetFrm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_ResetFrm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ResetFrm.ForeColor = System.Drawing.Color.White;
            this.btn_ResetFrm.Location = new System.Drawing.Point(148, 6);
            this.btn_ResetFrm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ResetFrm.Name = "btn_ResetFrm";
            this.btn_ResetFrm.Size = new System.Drawing.Size(133, 43);
            this.btn_ResetFrm.TabIndex = 0;
            this.btn_ResetFrm.Text = "Reset form";
            this.btn_ResetFrm.Click += new System.EventHandler(this.btn_ResetFrm_Click);
            // 
            // ucQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucQuanLyGiaoVien";
            this.Size = new System.Drawing.Size(1467, 800);
            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKinhNghiem)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpSchedule.ResumeLayout(false);
            this.pnlRightHeader.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btn_ResetFrm;
    }
}
