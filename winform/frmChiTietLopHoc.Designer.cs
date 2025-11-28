namespace winform
{
    partial class frmChiTietLopHoc
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
            this.txtSiSoMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelSiSo = new System.Windows.Forms.Label();
            this.txtSiSoMax = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpLichHoc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblGio = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblSoBuoiTuan = new System.Windows.Forms.Label();
            this.numSoBuoiTuan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblThu = new System.Windows.Forms.Label();
            this.chkListNgayHoc = new System.Windows.Forms.CheckedListBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpHocCu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboChonHocCu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSLHocCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddHocCu = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHocCu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpGiaoVien = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLocGV = new Guna.UI2.WinForms.Guna2Button();
            this.chkListGiaoVien = new System.Windows.Forms.CheckedListBox();
            this.pnlMain.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpLichHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpHocCu.SuspendLayout();
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
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1600, 862);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActions.Location = new System.Drawing.Point(0, 764);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1600, 98);
            this.pnlActions.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1173, 22);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(187, 55);
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
            this.btnLuu.Location = new System.Drawing.Point(1387, 22);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(187, 55);
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
            this.lblTitle.Size = new System.Drawing.Size(1600, 74);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "THÔNG TIN LỚP HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.grpInfo, 0, 0);
            this.tlpContent.Controls.Add(this.pnlRight, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 0);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1600, 862);
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
            this.grpInfo.Controls.Add(this.txtSiSoMin);
            this.grpInfo.Controls.Add(this.labelSiSo);
            this.grpInfo.Controls.Add(this.txtSiSoMax);
            this.grpInfo.Controls.Add(this.grpLichHoc);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpInfo.Location = new System.Drawing.Point(31, 29);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(765, 804);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.Text = "Thông Tin Chung";
            // 
            // lblTenLop
            // 
            this.lblTenLop.BackColor = System.Drawing.Color.Transparent;
            this.lblTenLop.Location = new System.Drawing.Point(27, 62);
            this.lblTenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(133, 25);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLop.BorderRadius = 5;
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLop.Location = new System.Drawing.Point(27, 92);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PlaceholderText = "";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.Size = new System.Drawing.Size(707, 49);
            this.txtTenLop.TabIndex = 1;
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblKhoaHoc.Location = new System.Drawing.Point(27, 154);
            this.lblKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(133, 28);
            this.lblKhoaHoc.TabIndex = 2;
            this.lblKhoaHoc.Text = "Khóa Học:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoaHoc.BorderRadius = 5;
            this.cboKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhoaHoc.ItemHeight = 30;
            this.cboKhoaHoc.Location = new System.Drawing.Point(27, 185);
            this.cboKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(705, 36);
            this.cboKhoaHoc.TabIndex = 3;
            // 
            // lblPhong
            // 
            this.lblPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblPhong.Location = new System.Drawing.Point(27, 246);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(133, 28);
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng Học:";
            // 
            // cboPhong
            // 
            this.cboPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhong.BackColor = System.Drawing.Color.Transparent;
            this.cboPhong.BorderRadius = 5;
            this.cboPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhong.ItemHeight = 30;
            this.cboPhong.Location = new System.Drawing.Point(27, 277);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(705, 36);
            this.cboPhong.TabIndex = 5;
            // 
            // lblNgayKG
            // 
            this.lblNgayKG.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayKG.Location = new System.Drawing.Point(27, 338);
            this.lblNgayKG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKG.Name = "lblNgayKG";
            this.lblNgayKG.Size = new System.Drawing.Size(133, 28);
            this.lblNgayKG.TabIndex = 6;
            this.lblNgayKG.Text = "Ngày Khai Giảng:";
            // 
            // dtpNgayKG
            // 
            this.dtpNgayKG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKG.BorderRadius = 5;
            this.dtpNgayKG.Checked = true;
            this.dtpNgayKG.FillColor = System.Drawing.Color.White;
            this.dtpNgayKG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKG.Location = new System.Drawing.Point(27, 369);
            this.dtpNgayKG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayKG.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKG.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKG.Name = "dtpNgayKG";
            this.dtpNgayKG.Size = new System.Drawing.Size(707, 49);
            this.dtpNgayKG.TabIndex = 7;
            this.dtpNgayKG.Value = new System.DateTime(2025, 11, 28, 14, 46, 11, 930);
            // 
            // lblSiSo
            // 
            this.lblSiSo.BackColor = System.Drawing.Color.Transparent;
            this.lblSiSo.Location = new System.Drawing.Point(27, 431);
            this.lblSiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(267, 25);
            this.lblSiSo.TabIndex = 8;
            this.lblSiSo.Text = "Sĩ Số (Min - Max):";
            // 
            // txtSiSoMin
            // 
            this.txtSiSoMin.BorderRadius = 5;
            this.txtSiSoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSiSoMin.DefaultText = "";
            this.txtSiSoMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSiSoMin.Location = new System.Drawing.Point(27, 462);
            this.txtSiSoMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSiSoMin.Name = "txtSiSoMin";
            this.txtSiSoMin.PlaceholderText = "Min";
            this.txtSiSoMin.SelectedText = "";
            this.txtSiSoMin.Size = new System.Drawing.Size(133, 49);
            this.txtSiSoMin.TabIndex = 9;
            this.txtSiSoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSiSo
            // 
            this.labelSiSo.AutoSize = true;
            this.labelSiSo.BackColor = System.Drawing.Color.Transparent;
            this.labelSiSo.Location = new System.Drawing.Point(173, 474);
            this.labelSiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiSo.Name = "labelSiSo";
            this.labelSiSo.Size = new System.Drawing.Size(15, 20);
            this.labelSiSo.TabIndex = 10;
            this.labelSiSo.Text = "-";
            // 
            // txtSiSoMax
            // 
            this.txtSiSoMax.BorderRadius = 5;
            this.txtSiSoMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSiSoMax.DefaultText = "";
            this.txtSiSoMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSiSoMax.Location = new System.Drawing.Point(200, 462);
            this.txtSiSoMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSiSoMax.Name = "txtSiSoMax";
            this.txtSiSoMax.PlaceholderText = "Max";
            this.txtSiSoMax.SelectedText = "";
            this.txtSiSoMax.Size = new System.Drawing.Size(133, 49);
            this.txtSiSoMax.TabIndex = 11;
            this.txtSiSoMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpLichHoc
            // 
            this.grpLichHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLichHoc.Controls.Add(this.lblGio);
            this.grpLichHoc.Controls.Add(this.dtpGioBatDau);
            this.grpLichHoc.Controls.Add(this.lblDen);
            this.grpLichHoc.Controls.Add(this.dtpGioKetThuc);
            this.grpLichHoc.Controls.Add(this.lblSoBuoiTuan);
            this.grpLichHoc.Controls.Add(this.numSoBuoiTuan);
            this.grpLichHoc.Controls.Add(this.lblThu);
            this.grpLichHoc.Controls.Add(this.chkListNgayHoc);
            this.grpLichHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpLichHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpLichHoc.Location = new System.Drawing.Point(27, 529);
            this.grpLichHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLichHoc.Name = "grpLichHoc";
            this.grpLichHoc.Size = new System.Drawing.Size(707, 257);
            this.grpLichHoc.TabIndex = 12;
            this.grpLichHoc.Text = "Lịch Học";
            // 
            // lblGio
            // 
            this.lblGio.BackColor = System.Drawing.Color.Transparent;
            this.lblGio.Location = new System.Drawing.Point(13, 62);
            this.lblGio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(80, 25);
            this.lblGio.TabIndex = 0;
            this.lblGio.Text = "Giờ Học:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(107, 59);
            this.dtpGioBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(132, 27);
            this.dtpGioBatDau.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.BackColor = System.Drawing.Color.Transparent;
            this.lblDen.Location = new System.Drawing.Point(253, 62);
            this.lblDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(34, 20);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "đến";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(293, 59);
            this.dtpGioKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(132, 27);
            this.dtpGioKetThuc.TabIndex = 3;
            // 
            // lblSoBuoiTuan
            // 
            this.lblSoBuoiTuan.AutoSize = true;
            this.lblSoBuoiTuan.BackColor = System.Drawing.Color.Transparent;
            this.lblSoBuoiTuan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoBuoiTuan.Location = new System.Drawing.Point(453, 62);
            this.lblSoBuoiTuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoBuoiTuan.Name = "lblSoBuoiTuan";
            this.lblSoBuoiTuan.Size = new System.Drawing.Size(104, 20);
            this.lblSoBuoiTuan.TabIndex = 4;
            this.lblSoBuoiTuan.Text = "Số buổi/tuần:";
            // 
            // numSoBuoiTuan
            // 
            this.numSoBuoiTuan.BackColor = System.Drawing.Color.Transparent;
            this.numSoBuoiTuan.BorderRadius = 3;
            this.numSoBuoiTuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoBuoiTuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoBuoiTuan.Location = new System.Drawing.Point(573, 55);
            this.numSoBuoiTuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoBuoiTuan.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numSoBuoiTuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoBuoiTuan.Name = "numSoBuoiTuan";
            this.numSoBuoiTuan.Size = new System.Drawing.Size(80, 37);
            this.numSoBuoiTuan.TabIndex = 5;
            this.numSoBuoiTuan.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblThu
            // 
            this.lblThu.BackColor = System.Drawing.Color.Transparent;
            this.lblThu.Location = new System.Drawing.Point(13, 105);
            this.lblThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(107, 25);
            this.lblThu.TabIndex = 6;
            this.lblThu.Text = "Chọn Ngày:";
            // 
            // chkListNgayHoc
            // 
            this.chkListNgayHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkListNgayHoc.CheckOnClick = true;
            this.chkListNgayHoc.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ Nhật"});
            this.chkListNgayHoc.Location = new System.Drawing.Point(13, 129);
            this.chkListNgayHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkListNgayHoc.MultiColumn = true;
            this.chkListNgayHoc.Name = "chkListNgayHoc";
            this.chkListNgayHoc.Size = new System.Drawing.Size(679, 92);
            this.chkListNgayHoc.TabIndex = 7;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpHocCu);
            this.pnlRight.Controls.Add(this.grpGiaoVien);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(804, 29);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(765, 804);
            this.pnlRight.TabIndex = 1;
            // 
            // grpHocCu
            // 
            this.grpHocCu.Controls.Add(this.cboChonHocCu);
            this.grpHocCu.Controls.Add(this.txtSLHocCu);
            this.grpHocCu.Controls.Add(this.btnAddHocCu);
            this.grpHocCu.Controls.Add(this.dgvHocCu);
            this.grpHocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpHocCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpHocCu.Location = new System.Drawing.Point(0, 308);
            this.grpHocCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpHocCu.Name = "grpHocCu";
            this.grpHocCu.Padding = new System.Windows.Forms.Padding(0, 49, 0, 0);
            this.grpHocCu.Size = new System.Drawing.Size(765, 496);
            this.grpHocCu.TabIndex = 0;
            this.grpHocCu.Text = "Học Cụ Cần Thiết";
            // 
            // cboChonHocCu
            // 
            this.cboChonHocCu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChonHocCu.BackColor = System.Drawing.Color.Transparent;
            this.cboChonHocCu.BorderRadius = 5;
            this.cboChonHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChonHocCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonHocCu.FocusedColor = System.Drawing.Color.Empty;
            this.cboChonHocCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChonHocCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChonHocCu.ItemHeight = 30;
            this.cboChonHocCu.Location = new System.Drawing.Point(13, 62);
            this.cboChonHocCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChonHocCu.Name = "cboChonHocCu";
            this.cboChonHocCu.Size = new System.Drawing.Size(465, 36);
            this.cboChonHocCu.TabIndex = 0;
            // 
            // txtSLHocCu
            // 
            this.txtSLHocCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSLHocCu.BorderRadius = 5;
            this.txtSLHocCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLHocCu.DefaultText = "";
            this.txtSLHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSLHocCu.Location = new System.Drawing.Point(493, 62);
            this.txtSLHocCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSLHocCu.Name = "txtSLHocCu";
            this.txtSLHocCu.PlaceholderText = "SL";
            this.txtSLHocCu.SelectedText = "";
            this.txtSLHocCu.Size = new System.Drawing.Size(107, 44);
            this.txtSLHocCu.TabIndex = 1;
            this.txtSLHocCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddHocCu
            // 
            this.btnAddHocCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHocCu.BorderRadius = 5;
            this.btnAddHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddHocCu.ForeColor = System.Drawing.Color.White;
            this.btnAddHocCu.Location = new System.Drawing.Point(613, 62);
            this.btnAddHocCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddHocCu.Name = "btnAddHocCu";
            this.btnAddHocCu.Size = new System.Drawing.Size(133, 44);
            this.btnAddHocCu.TabIndex = 2;
            this.btnAddHocCu.Text = "+ Thêm";
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
            this.dgvHocCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHocCu.Name = "dgvHocCu";
            this.dgvHocCu.RowHeadersVisible = false;
            this.dgvHocCu.RowHeadersWidth = 51;
            this.dgvHocCu.Size = new System.Drawing.Size(733, 355);
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
            this.grpGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.grpGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGiaoVien.Name = "grpGiaoVien";
            this.grpGiaoVien.Size = new System.Drawing.Size(765, 308);
            this.grpGiaoVien.TabIndex = 1;
            this.grpGiaoVien.Text = "Phân Công Giáo Viên";
            // 
            // btnLocGV
            // 
            this.btnLocGV.BorderRadius = 5;
            this.btnLocGV.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLocGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocGV.ForeColor = System.Drawing.Color.White;
            this.btnLocGV.Location = new System.Drawing.Point(13, 62);
            this.btnLocGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocGV.Name = "btnLocGV";
            this.btnLocGV.Size = new System.Drawing.Size(200, 43);
            this.btnLocGV.TabIndex = 0;
            this.btnLocGV.Text = "Lọc GV Trống";
            // 
            // chkListGiaoVien
            // 
            this.chkListGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkListGiaoVien.CheckOnClick = true;
            this.chkListGiaoVien.Location = new System.Drawing.Point(13, 117);
            this.chkListGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkListGiaoVien.Name = "chkListGiaoVien";
            this.chkListGiaoVien.Size = new System.Drawing.Size(732, 158);
            this.chkListGiaoVien.TabIndex = 1;
            // 
            // frmChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 862);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChiTietLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Lớp Học";
            this.pnlMain.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpLichHoc.ResumeLayout(false);
            this.grpLichHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpHocCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocCu)).EndInit();
            this.grpGiaoVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContent;

        private Guna.UI2.WinForms.Guna2GroupBox grpInfo;
        private System.Windows.Forms.Label lblTenLop; private Guna.UI2.WinForms.Guna2TextBox txtTenLop;
        private System.Windows.Forms.Label lblKhoaHoc; private Guna.UI2.WinForms.Guna2ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblPhong; private Guna.UI2.WinForms.Guna2ComboBox cboPhong;
        private System.Windows.Forms.Label lblNgayKG; private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKG;
        private System.Windows.Forms.Label lblSiSo;

        // CONTROL THAY ĐỔI
        private Guna.UI2.WinForms.Guna2TextBox txtSiSoMin;
        private System.Windows.Forms.Label labelSiSo;
        private Guna.UI2.WinForms.Guna2TextBox txtSiSoMax;

        private Guna.UI2.WinForms.Guna2GroupBox grpLichHoc;
        private System.Windows.Forms.Label lblGio; private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblDen; private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblThu; private System.Windows.Forms.CheckedListBox chkListNgayHoc;
        private System.Windows.Forms.Label lblSoBuoiTuan; private Guna.UI2.WinForms.Guna2NumericUpDown numSoBuoiTuan;

        private System.Windows.Forms.Panel pnlRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpGiaoVien;
        private System.Windows.Forms.CheckedListBox chkListGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnLocGV;

        private Guna.UI2.WinForms.Guna2GroupBox grpHocCu;
        private Guna.UI2.WinForms.Guna2ComboBox cboChonHocCu;

        // CONTROL THAY ĐỔI
        private Guna.UI2.WinForms.Guna2TextBox txtSLHocCu;

        private Guna.UI2.WinForms.Guna2Button btnAddHocCu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHocCu;

        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}