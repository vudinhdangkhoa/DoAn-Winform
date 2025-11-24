namespace winform
{
    partial class frmChiTietLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.grpInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgayKG = new System.Windows.Forms.Label();
            this.dtpNgayKG = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.numSiSoMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelSiSo = new System.Windows.Forms.Label();
            this.numSiSoMax = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.grpLichHoc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblGio = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblThu = new System.Windows.Forms.Label();
            this.chkListNgayHoc = new System.Windows.Forms.CheckedListBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpHocCu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboChonHocCu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numSLHocCu = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddHocCu = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHocCu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpGiaoVien = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLocGV = new Guna.UI2.WinForms.Guna2Button();
            this.chkListGiaoVien = new System.Windows.Forms.CheckedListBox();
            this.pnlMain.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSiSoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSiSoMax)).BeginInit();
            this.grpLichHoc.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpHocCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLHocCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocCu)).BeginInit();
            this.grpGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlActions);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.tlpContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1489, 923);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActions.Location = new System.Drawing.Point(0, 837);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1489, 86);
            this.pnlActions.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(822, 18);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(160, 49);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "HỦY";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1022, 18);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(213, 49);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU LỚP HỌC";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1489, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN LỚP HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1041F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8959F));
            this.tlpContent.Controls.Add(this.grpInfo, 0, 0);
            this.tlpContent.Controls.Add(this.pnlRight, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 0);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(4);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1489, 923);
            this.tlpContent.TabIndex = 1;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblTenLop);
            this.grpInfo.Controls.Add(this.txtTenLop);
            this.grpInfo.Controls.Add(this.lblKhoaHoc);
            this.grpInfo.Controls.Add(this.cboKhoaHoc);
            this.grpInfo.Controls.Add(this.lblPhong);
            this.grpInfo.Controls.Add(this.cboPhong);
            this.grpInfo.Controls.Add(this.lblNgayKG);
            this.grpInfo.Controls.Add(this.dtpNgayKG);
            this.grpInfo.Controls.Add(this.lblSiSo);
            this.grpInfo.Controls.Add(this.numSiSoMin);
            this.grpInfo.Controls.Add(this.labelSiSo);
            this.grpInfo.Controls.Add(this.numSiSoMax);
            this.grpInfo.Controls.Add(this.grpLichHoc);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpInfo.Location = new System.Drawing.Point(17, 16);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpInfo.Size = new System.Drawing.Size(725, 891);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.Text = "Thông Tin Chung";
            // 
            // lblTenLop
            // 
            this.lblTenLop.Location = new System.Drawing.Point(27, 62);
            this.lblTenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(133, 28);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.BorderRadius = 5;
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLop.Location = new System.Drawing.Point(27, 86);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PlaceholderText = "";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.Size = new System.Drawing.Size(587, 37);
            this.txtTenLop.TabIndex = 1;
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.Location = new System.Drawing.Point(27, 135);
            this.lblKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(133, 28);
            this.lblKhoaHoc.TabIndex = 2;
            this.lblKhoaHoc.Text = "Khóa Học:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoaHoc.BorderRadius = 5;
            this.cboKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhoaHoc.ItemHeight = 30;
            this.cboKhoaHoc.Location = new System.Drawing.Point(27, 160);
            this.cboKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(585, 36);
            this.cboKhoaHoc.TabIndex = 3;
            // 
            // lblPhong
            // 
            this.lblPhong.Location = new System.Drawing.Point(27, 209);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(133, 28);
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng Học:";
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.Color.Transparent;
            this.cboPhong.BorderRadius = 5;
            this.cboPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhong.ItemHeight = 30;
            this.cboPhong.Location = new System.Drawing.Point(27, 234);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(585, 36);
            this.cboPhong.TabIndex = 5;
            // 
            // lblNgayKG
            // 
            this.lblNgayKG.Location = new System.Drawing.Point(27, 283);
            this.lblNgayKG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKG.Name = "lblNgayKG";
            this.lblNgayKG.Size = new System.Drawing.Size(133, 28);
            this.lblNgayKG.TabIndex = 6;
            this.lblNgayKG.Text = "Ngày Khai Giảng:";
            // 
            // dtpNgayKG
            // 
            this.dtpNgayKG.Checked = true;
            this.dtpNgayKG.FillColor = System.Drawing.Color.White;
            this.dtpNgayKG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKG.Location = new System.Drawing.Point(27, 308);
            this.dtpNgayKG.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKG.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKG.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKG.Name = "dtpNgayKG";
            this.dtpNgayKG.Size = new System.Drawing.Size(587, 37);
            this.dtpNgayKG.TabIndex = 7;
            this.dtpNgayKG.Value = new System.DateTime(2025, 11, 23, 18, 44, 19, 491);
            // 
            // lblSiSo
            // 
            this.lblSiSo.Location = new System.Drawing.Point(27, 357);
            this.lblSiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(133, 28);
            this.lblSiSo.TabIndex = 8;
            this.lblSiSo.Text = "Sĩ Số (Min - Max):";
            // 
            // numSiSoMin
            // 
            this.numSiSoMin.BackColor = System.Drawing.Color.Transparent;
            this.numSiSoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSiSoMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSiSoMin.Location = new System.Drawing.Point(27, 382);
            this.numSiSoMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSiSoMin.Name = "numSiSoMin";
            this.numSiSoMin.Size = new System.Drawing.Size(133, 37);
            this.numSiSoMin.TabIndex = 9;
            // 
            // labelSiSo
            // 
            this.labelSiSo.AutoSize = true;
            this.labelSiSo.Location = new System.Drawing.Point(173, 388);
            this.labelSiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiSo.Name = "labelSiSo";
            this.labelSiSo.Size = new System.Drawing.Size(15, 20);
            this.labelSiSo.TabIndex = 10;
            this.labelSiSo.Text = "-";
            // 
            // numSiSoMax
            // 
            this.numSiSoMax.BackColor = System.Drawing.Color.Transparent;
            this.numSiSoMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSiSoMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSiSoMax.Location = new System.Drawing.Point(200, 382);
            this.numSiSoMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSiSoMax.Name = "numSiSoMax";
            this.numSiSoMax.Size = new System.Drawing.Size(133, 37);
            this.numSiSoMax.TabIndex = 11;
            // 
            // grpLichHoc
            // 
            this.grpLichHoc.Controls.Add(this.lblGio);
            this.grpLichHoc.Controls.Add(this.dtpGioBatDau);
            this.grpLichHoc.Controls.Add(this.lblDen);
            this.grpLichHoc.Controls.Add(this.dtpGioKetThuc);
            this.grpLichHoc.Controls.Add(this.lblThu);
            this.grpLichHoc.Controls.Add(this.chkListNgayHoc);
            this.grpLichHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpLichHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpLichHoc.Location = new System.Drawing.Point(27, 443);
            this.grpLichHoc.Margin = new System.Windows.Forms.Padding(4);
            this.grpLichHoc.Name = "grpLichHoc";
            this.grpLichHoc.Size = new System.Drawing.Size(587, 246);
            this.grpLichHoc.TabIndex = 12;
            this.grpLichHoc.Text = "Lịch Học";
            // 
            // lblGio
            // 
            this.lblGio.Location = new System.Drawing.Point(13, 62);
            this.lblGio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(133, 28);
            this.lblGio.TabIndex = 0;
            this.lblGio.Text = "Giờ Học:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(170, 64);
            this.dtpGioBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(132, 27);
            this.dtpGioBatDau.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(310, 70);
            this.lblDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(34, 20);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "đến";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(365, 65);
            this.dtpGioKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(132, 27);
            this.dtpGioKetThuc.TabIndex = 3;
            // 
            // lblThu
            // 
            this.lblThu.Location = new System.Drawing.Point(13, 98);
            this.lblThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(133, 28);
            this.lblThu.TabIndex = 4;
            this.lblThu.Text = "Chọn Ngày Học Trong Tuần:";
            // 
            // chkListNgayHoc
            // 
            this.chkListNgayHoc.CheckOnClick = true;
            this.chkListNgayHoc.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ Nhật"});
            this.chkListNgayHoc.Location = new System.Drawing.Point(13, 123);
            this.chkListNgayHoc.Margin = new System.Windows.Forms.Padding(4);
            this.chkListNgayHoc.Name = "chkListNgayHoc";
            this.chkListNgayHoc.Size = new System.Drawing.Size(559, 92);
            this.chkListNgayHoc.TabIndex = 5;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpHocCu);
            this.pnlRight.Controls.Add(this.grpGiaoVien);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(750, 16);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlRight.Size = new System.Drawing.Size(722, 891);
            this.pnlRight.TabIndex = 1;
            // 
            // grpHocCu
            // 
            this.grpHocCu.Controls.Add(this.cboChonHocCu);
            this.grpHocCu.Controls.Add(this.numSLHocCu);
            this.grpHocCu.Controls.Add(this.btnAddHocCu);
            this.grpHocCu.Controls.Add(this.dgvHocCu);
            this.grpHocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpHocCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpHocCu.Location = new System.Drawing.Point(7, 314);
            this.grpHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.grpHocCu.Name = "grpHocCu";
            this.grpHocCu.Padding = new System.Windows.Forms.Padding(13, 49, 13, 12);
            this.grpHocCu.Size = new System.Drawing.Size(708, 571);
            this.grpHocCu.TabIndex = 0;
            this.grpHocCu.Text = "Học Cụ Cần Thiết";
            // 
            // cboChonHocCu
            // 
            this.cboChonHocCu.BackColor = System.Drawing.Color.Transparent;
            this.cboChonHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChonHocCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonHocCu.FocusedColor = System.Drawing.Color.Empty;
            this.cboChonHocCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChonHocCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChonHocCu.ItemHeight = 30;
            this.cboChonHocCu.Location = new System.Drawing.Point(13, 62);
            this.cboChonHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChonHocCu.Name = "cboChonHocCu";
            this.cboChonHocCu.Size = new System.Drawing.Size(332, 36);
            this.cboChonHocCu.TabIndex = 0;
            // 
            // numSLHocCu
            // 
            this.numSLHocCu.BackColor = System.Drawing.Color.Transparent;
            this.numSLHocCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSLHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSLHocCu.Location = new System.Drawing.Point(360, 62);
            this.numSLHocCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSLHocCu.Name = "numSLHocCu";
            this.numSLHocCu.Size = new System.Drawing.Size(107, 44);
            this.numSLHocCu.TabIndex = 1;
            // 
            // btnAddHocCu
            // 
            this.btnAddHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddHocCu.ForeColor = System.Drawing.Color.White;
            this.btnAddHocCu.Location = new System.Drawing.Point(480, 62);
            this.btnAddHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHocCu.Name = "btnAddHocCu";
            this.btnAddHocCu.Size = new System.Drawing.Size(67, 44);
            this.btnAddHocCu.TabIndex = 2;
            this.btnAddHocCu.Text = "+";
            // 
            // dgvHocCu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocCu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocCu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocCu.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocCu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocCu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocCu.Location = new System.Drawing.Point(13, 123);
            this.dgvHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocCu.Name = "dgvHocCu";
            this.dgvHocCu.RowHeadersVisible = false;
            this.dgvHocCu.RowHeadersWidth = 51;
            this.dgvHocCu.Size = new System.Drawing.Size(682, 463);
            this.dgvHocCu.TabIndex = 3;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHocCu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocCu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHocCu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHocCu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHocCu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocCu.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvHocCu.ThemeStyle.ReadOnly = false;
            this.dgvHocCu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHocCu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHocCu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocCu.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHocCu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocCu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grpGiaoVien
            // 
            this.grpGiaoVien.Controls.Add(this.btnLocGV);
            this.grpGiaoVien.Controls.Add(this.chkListGiaoVien);
            this.grpGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpGiaoVien.Location = new System.Drawing.Point(7, 6);
            this.grpGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.grpGiaoVien.Name = "grpGiaoVien";
            this.grpGiaoVien.Padding = new System.Windows.Forms.Padding(13, 49, 13, 12);
            this.grpGiaoVien.Size = new System.Drawing.Size(708, 308);
            this.grpGiaoVien.TabIndex = 1;
            this.grpGiaoVien.Text = "Phân Công Giáo Viên";
            // 
            // btnLocGV
            // 
            this.btnLocGV.BorderRadius = 5;
            this.btnLocGV.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLocGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocGV.ForeColor = System.Drawing.Color.White;
            this.btnLocGV.Location = new System.Drawing.Point(13, 55);
            this.btnLocGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocGV.Name = "btnLocGV";
            this.btnLocGV.Size = new System.Drawing.Size(160, 37);
            this.btnLocGV.TabIndex = 0;
            this.btnLocGV.Text = "Lọc GV Trống";
            // 
            // chkListGiaoVien
            // 
            this.chkListGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkListGiaoVien.CheckOnClick = true;
            this.chkListGiaoVien.Location = new System.Drawing.Point(13, 98);
            this.chkListGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.chkListGiaoVien.Name = "chkListGiaoVien";
            this.chkListGiaoVien.Size = new System.Drawing.Size(973, 180);
            this.chkListGiaoVien.TabIndex = 1;
            // 
            // frmChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 923);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Lớp Học";
            this.pnlMain.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSiSoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSiSoMax)).EndInit();
            this.grpLichHoc.ResumeLayout(false);
            this.grpLichHoc.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.grpHocCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSLHocCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocCu)).EndInit();
            this.grpGiaoVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContent;

        // Left Side
        private Guna.UI2.WinForms.Guna2GroupBox grpInfo;
        private System.Windows.Forms.Label lblTenLop; private Guna.UI2.WinForms.Guna2TextBox txtTenLop;
        private System.Windows.Forms.Label lblKhoaHoc; private Guna.UI2.WinForms.Guna2ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblPhong; private Guna.UI2.WinForms.Guna2ComboBox cboPhong;
        private System.Windows.Forms.Label lblNgayKG; private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKG;
        private System.Windows.Forms.Label lblSiSo; private Guna.UI2.WinForms.Guna2NumericUpDown numSiSoMin;
        private System.Windows.Forms.Label labelSiSo; private Guna.UI2.WinForms.Guna2NumericUpDown numSiSoMax;

        private Guna.UI2.WinForms.Guna2GroupBox grpLichHoc;
        private System.Windows.Forms.Label lblGio; private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblDen; private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblThu; private System.Windows.Forms.CheckedListBox chkListNgayHoc;

        // Right Side
        private System.Windows.Forms.Panel pnlRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpGiaoVien;
        private System.Windows.Forms.CheckedListBox chkListGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnLocGV;

        private Guna.UI2.WinForms.Guna2GroupBox grpHocCu;
        private Guna.UI2.WinForms.Guna2ComboBox cboChonHocCu;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSLHocCu;
        private Guna.UI2.WinForms.Guna2Button btnAddHocCu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHocCu;

        // Bottom
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}