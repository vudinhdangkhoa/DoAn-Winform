namespace winform
{
    partial class ucQuanLyLichHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.grpFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLopHoc = new System.Windows.Forms.Label();
            this.cboLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlDateFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpDateFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnResetFilter = new Guna.UI2.WinForms.Guna2Button();
            this.grpLichHoc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvLichHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grpDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpDetail = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInfoCard = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblNgayGioTitle = new System.Windows.Forms.Label();
            this.txtNgayGio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhongTitle = new System.Windows.Forms.Label();
            this.txtPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaoVienTitle = new System.Windows.Forms.Label();
            this.txtGiaoVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThaiTitle = new System.Windows.Forms.Label();
            this.pnlStatusBadge = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBaoNghi = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.pnlDateFilter.SuspendLayout();
            this.tlpDateFilter.SuspendLayout();
            this.grpLichHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.tlpDetail.SuspendLayout();
            this.pnlInfoCard.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlStatusBadge.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.pnlContent, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(15);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1400, 850);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 12;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(18, 18);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.ShadowDecoration.BorderRadius = 12;
            this.pnlHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.pnlHeader.ShadowDecoration.Depth = 10;
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.Size = new System.Drawing.Size(1364, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 QUẢN LÝ LỊCH HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1225, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 54);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 Tải lại";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.tlpContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(18, 98);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1364, 734);
            this.pnlContent.TabIndex = 1;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContent.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpContent.Controls.Add(this.pnlRight, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1364, 734);
            this.tlpContent.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grpFilter);
            this.pnlLeft.Controls.Add(this.grpLichHoc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlLeft.Size = new System.Drawing.Size(948, 728);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.Transparent;
            this.grpFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpFilter.BorderRadius = 12;
            this.grpFilter.Controls.Add(this.tlpFilter);
            this.grpFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grpFilter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpFilter.ForeColor = System.Drawing.Color.White;
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.ShadowDecoration.BorderRadius = 12;
            this.grpFilter.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.grpFilter.ShadowDecoration.Depth = 10;
            this.grpFilter.ShadowDecoration.Enabled = true;
            this.grpFilter.Size = new System.Drawing.Size(938, 220);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.Text = "🔍 BỘ LỌC TÌM KIẾM";
            this.grpFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 2;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFilter.Controls.Add(this.lblKhoaHoc, 0, 0);
            this.tlpFilter.Controls.Add(this.cboKhoaHoc, 0, 1);
            this.tlpFilter.Controls.Add(this.lblLopHoc, 1, 0);
            this.tlpFilter.Controls.Add(this.cboLopHoc, 1, 1);
            this.tlpFilter.Controls.Add(this.pnlDateFilter, 0, 2);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(0, 50);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 15);
            this.tlpFilter.RowCount = 3;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(938, 170);
            this.tlpFilter.TabIndex = 0;
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKhoaHoc.Location = new System.Drawing.Point(23, 10);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(443, 30);
            this.lblKhoaHoc.TabIndex = 0;
            this.lblKhoaHoc.Text = "Khóa học";
            this.lblKhoaHoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoaHoc.BorderRadius = 8;
            this.cboKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.cboKhoaHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboKhoaHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhoaHoc.ItemHeight = 35;
            this.cboKhoaHoc.Location = new System.Drawing.Point(23, 43);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(443, 41);
            this.cboKhoaHoc.TabIndex = 1;
            // 
            // lblLopHoc
            // 
            this.lblLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLopHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLopHoc.Location = new System.Drawing.Point(472, 10);
            this.lblLopHoc.Name = "lblLopHoc";
            this.lblLopHoc.Size = new System.Drawing.Size(443, 30);
            this.lblLopHoc.TabIndex = 2;
            this.lblLopHoc.Text = "Lớp học";
            this.lblLopHoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHoc.BorderRadius = 8;
            this.cboLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.cboLopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboLopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHoc.ItemHeight = 35;
            this.cboLopHoc.Location = new System.Drawing.Point(472, 43);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(443, 41);
            this.cboLopHoc.TabIndex = 3;
            // 
            // pnlDateFilter
            // 
            this.tlpFilter.SetColumnSpan(this.pnlDateFilter, 2);
            this.pnlDateFilter.Controls.Add(this.tlpDateFilter);
            this.pnlDateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDateFilter.Location = new System.Drawing.Point(23, 93);
            this.pnlDateFilter.Name = "pnlDateFilter";
            this.pnlDateFilter.Size = new System.Drawing.Size(892, 59);
            this.pnlDateFilter.TabIndex = 4;
            // 
            // tlpDateFilter
            // 
            this.tlpDateFilter.ColumnCount = 5;
            this.tlpDateFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpDateFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDateFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpDateFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDateFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDateFilter.Controls.Add(this.lblTuNgay, 0, 0);
            this.tlpDateFilter.Controls.Add(this.dtpFrom, 1, 0);
            this.tlpDateFilter.Controls.Add(this.lblDenNgay, 2, 0);
            this.tlpDateFilter.Controls.Add(this.dtpTo, 3, 0);
            this.tlpDateFilter.Controls.Add(this.btnResetFilter, 4, 0);
            this.tlpDateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDateFilter.Location = new System.Drawing.Point(0, 0);
            this.tlpDateFilter.Name = "tlpDateFilter";
            this.tlpDateFilter.RowCount = 1;
            this.tlpDateFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateFilter.Size = new System.Drawing.Size(892, 59);
            this.tlpDateFilter.TabIndex = 0;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTuNgay.Location = new System.Drawing.Point(3, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(104, 59);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            this.lblTuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.BorderRadius = 8;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(113, 9);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(262, 40);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Value = new System.DateTime(2025, 11, 28, 0, 0, 0, 0);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDenNgay.Location = new System.Drawing.Point(381, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(104, 59);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            this.lblDenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.BorderRadius = 8;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(491, 9);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(262, 40);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2025, 11, 28, 0, 0, 0, 0);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.BorderRadius = 8;
            this.btnResetFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(759, 9);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(130, 40);
            this.btnResetFilter.TabIndex = 4;
            this.btnResetFilter.Text = "🔄 Đặt lại";
            // 
            // grpLichHoc
            // 
            this.grpLichHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLichHoc.BackColor = System.Drawing.Color.Transparent;
            this.grpLichHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpLichHoc.BorderRadius = 12;
            this.grpLichHoc.Controls.Add(this.dgvLichHoc);
            this.grpLichHoc.Controls.Add(this.pnlFooter);
            this.grpLichHoc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpLichHoc.CustomBorderThickness = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.grpLichHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpLichHoc.ForeColor = System.Drawing.Color.White;
            this.grpLichHoc.Location = new System.Drawing.Point(0, 230);
            this.grpLichHoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.grpLichHoc.Name = "grpLichHoc";
            this.grpLichHoc.ShadowDecoration.BorderRadius = 12;
            this.grpLichHoc.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.grpLichHoc.ShadowDecoration.Depth = 10;
            this.grpLichHoc.ShadowDecoration.Enabled = true;
            this.grpLichHoc.Size = new System.Drawing.Size(938, 498);
            this.grpLichHoc.TabIndex = 1;
            this.grpLichHoc.Text = "📚 DANH SÁCH LỊCH HỌC";
            this.grpLichHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.AllowUserToAddRows = false;
            this.dgvLichHoc.AllowUserToDeleteRows = false;
            this.dgvLichHoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvLichHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichHoc.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.Location = new System.Drawing.Point(0, 45);
            this.dgvLichHoc.MultiSelect = false;
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.ReadOnly = true;
            this.dgvLichHoc.RowHeadersVisible = false;
            this.dgvLichHoc.RowHeadersWidth = 51;
            this.dgvLichHoc.RowTemplate.Height = 45;
            this.dgvLichHoc.Size = new System.Drawing.Size(938, 403);
            this.dgvLichHoc.TabIndex = 0;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLichHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvLichHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLichHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvLichHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichHoc.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvLichHoc.ThemeStyle.ReadOnly = true;
            this.dgvLichHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvLichHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichHoc.ThemeStyle.RowsStyle.Height = 45;
            this.dgvLichHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblKetQua);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlFooter.Location = new System.Drawing.Point(0, 448);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.pnlFooter.Size = new System.Drawing.Size(938, 50);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblKetQua.Location = new System.Drawing.Point(15, 8);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(908, 34);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = "📊 Tìm thấy: 0 buổi học";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpDetail);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(957, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(404, 728);
            this.pnlRight.TabIndex = 1;
            // 
            // grpDetail
            // 
            this.grpDetail.BackColor = System.Drawing.Color.Transparent;
            this.grpDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpDetail.BorderRadius = 12;
            this.grpDetail.Controls.Add(this.tlpDetail);
            this.grpDetail.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.grpDetail.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.White;
            this.grpDetail.Location = new System.Drawing.Point(5, 0);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.ShadowDecoration.BorderRadius = 12;
            this.grpDetail.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.grpDetail.ShadowDecoration.Depth = 10;
            this.grpDetail.ShadowDecoration.Enabled = true;
            this.grpDetail.Size = new System.Drawing.Size(399, 728);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.Text = "CHI TIẾT BUỔI HỌC";
            this.grpDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpDetail
            // 
            this.tlpDetail.ColumnCount = 1;
            this.tlpDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetail.Controls.Add(this.pnlInfoCard, 0, 0);
            this.tlpDetail.Controls.Add(this.pnlStatus, 0, 1);
            this.tlpDetail.Controls.Add(this.pnlActions, 0, 2);
            this.tlpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetail.Location = new System.Drawing.Point(0, 50);
            this.tlpDetail.Name = "tlpDetail";
            this.tlpDetail.Padding = new System.Windows.Forms.Padding(15);
            this.tlpDetail.RowCount = 3;
            this.tlpDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDetail.Size = new System.Drawing.Size(399, 678);
            this.tlpDetail.TabIndex = 0;
            // 
            // pnlInfoCard
            // 
            this.pnlInfoCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlInfoCard.BorderRadius = 10;
            this.pnlInfoCard.BorderThickness = 1;
            this.pnlInfoCard.Controls.Add(this.tlpInfo);
            this.pnlInfoCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlInfoCard.Location = new System.Drawing.Point(18, 18);
            this.pnlInfoCard.Name = "pnlInfoCard";
            this.pnlInfoCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInfoCard.Size = new System.Drawing.Size(363, 382);
            this.pnlInfoCard.TabIndex = 0;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.lblNgayGioTitle, 0, 0);
            this.tlpInfo.Controls.Add(this.txtNgayGio, 0, 1);
            this.tlpInfo.Controls.Add(this.lblPhongTitle, 0, 2);
            this.tlpInfo.Controls.Add(this.txtPhong, 0, 3);
            this.tlpInfo.Controls.Add(this.lblGiaoVienTitle, 0, 4);
            this.tlpInfo.Controls.Add(this.txtGiaoVien, 0, 5);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(20, 20);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 6;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Size = new System.Drawing.Size(323, 342);
            this.tlpInfo.TabIndex = 0;
            // 
            // lblNgayGioTitle
            // 
            this.lblNgayGioTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayGioTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayGioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNgayGioTitle.Location = new System.Drawing.Point(3, 0);
            this.lblNgayGioTitle.Name = "lblNgayGioTitle";
            this.lblNgayGioTitle.Size = new System.Drawing.Size(317, 35);
            this.lblNgayGioTitle.TabIndex = 0;
            this.lblNgayGioTitle.Text = "Ngày giờ học";
            this.lblNgayGioTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgayGio
            // 
            this.txtNgayGio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNgayGio.BorderRadius = 8;
            this.txtNgayGio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayGio.DefaultText = "";
            this.txtNgayGio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayGio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayGio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayGio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayGio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNgayGio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNgayGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtNgayGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNgayGio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNgayGio.Location = new System.Drawing.Point(4, 39);
            this.txtNgayGio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.txtNgayGio.Name = "txtNgayGio";
            this.txtNgayGio.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtNgayGio.PlaceholderText = "Chưa chọn buổi học";
            this.txtNgayGio.ReadOnly = true;
            this.txtNgayGio.SelectedText = "";
            this.txtNgayGio.Size = new System.Drawing.Size(315, 43);
            this.txtNgayGio.TabIndex = 1;
            // 
            // lblPhongTitle
            // 
            this.lblPhongTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhongTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhongTitle.Location = new System.Drawing.Point(3, 90);
            this.lblPhongTitle.Name = "lblPhongTitle";
            this.lblPhongTitle.Size = new System.Drawing.Size(317, 35);
            this.lblPhongTitle.TabIndex = 2;
            this.lblPhongTitle.Text = "Phòng học";
            this.lblPhongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhong
            // 
            this.txtPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhong.BorderRadius = 8;
            this.txtPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhong.DefaultText = "";
            this.txtPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtPhong.Location = new System.Drawing.Point(4, 129);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtPhong.PlaceholderText = "Chưa xếp phòng";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.SelectedText = "";
            this.txtPhong.Size = new System.Drawing.Size(315, 43);
            this.txtPhong.TabIndex = 3;
            // 
            // lblGiaoVienTitle
            // 
            this.lblGiaoVienTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGiaoVienTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGiaoVienTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblGiaoVienTitle.Location = new System.Drawing.Point(3, 180);
            this.lblGiaoVienTitle.Name = "lblGiaoVienTitle";
            this.lblGiaoVienTitle.Size = new System.Drawing.Size(317, 35);
            this.lblGiaoVienTitle.TabIndex = 4;
            this.lblGiaoVienTitle.Text = "Giảng viên";
            this.lblGiaoVienTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaoVien
            // 
            this.txtGiaoVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGiaoVien.BorderRadius = 8;
            this.txtGiaoVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaoVien.DefaultText = "";
            this.txtGiaoVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaoVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtGiaoVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtGiaoVien.Location = new System.Drawing.Point(4, 219);
            this.txtGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.txtGiaoVien.Multiline = true;
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtGiaoVien.PlaceholderText = "Chưa phân công";
            this.txtGiaoVien.ReadOnly = true;
            this.txtGiaoVien.SelectedText = "";
            this.txtGiaoVien.Size = new System.Drawing.Size(315, 110);
            this.txtGiaoVien.TabIndex = 5;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblTrangThaiTitle);
            this.pnlStatus.Controls.Add(this.pnlStatusBadge);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(18, 406);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlStatus.Size = new System.Drawing.Size(363, 123);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblTrangThaiTitle
            // 
            this.lblTrangThaiTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrangThaiTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThaiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTrangThaiTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTrangThaiTitle.Name = "lblTrangThaiTitle";
            this.lblTrangThaiTitle.Size = new System.Drawing.Size(363, 30);
            this.lblTrangThaiTitle.TabIndex = 0;
            this.lblTrangThaiTitle.Text = "Trạng thái";
            this.lblTrangThaiTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatusBadge
            // 
            this.pnlStatusBadge.BorderRadius = 10;
            this.pnlStatusBadge.Controls.Add(this.lblTrangThai);
            this.pnlStatusBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatusBadge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.pnlStatusBadge.Location = new System.Drawing.Point(0, 10);
            this.pnlStatusBadge.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlStatusBadge.Name = "pnlStatusBadge";
            this.pnlStatusBadge.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlStatusBadge.Size = new System.Drawing.Size(363, 103);
            this.pnlStatusBadge.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(15, 10);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(333, 83);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Chưa chọn buổi học";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnBaoNghi);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(18, 535);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlActions.Size = new System.Drawing.Size(363, 125);
            this.pnlActions.TabIndex = 2;
            // 
            // btnBaoNghi
            // 
            this.btnBaoNghi.BorderRadius = 10;
            this.btnBaoNghi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoNghi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoNghi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnBaoNghi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoNghi.Enabled = false;
            this.btnBaoNghi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBaoNghi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBaoNghi.ForeColor = System.Drawing.Color.White;
            this.btnBaoNghi.Location = new System.Drawing.Point(0, 15);
            this.btnBaoNghi.Name = "btnBaoNghi";
            this.btnBaoNghi.Size = new System.Drawing.Size(363, 55);
            this.btnBaoNghi.TabIndex = 0;
            this.btnBaoNghi.Text = "📝 BÁO NGHỈ / HỌC BÙ";
            // 
            // ucQuanLyLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQuanLyLichHoc";
            this.Size = new System.Drawing.Size(1400, 850);
            this.tlpMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.pnlDateFilter.ResumeLayout(false);
            this.tlpDateFilter.ResumeLayout(false);
            this.grpLichHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            this.tlpDetail.ResumeLayout(false);
            this.pnlInfoCard.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatusBadge.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2GroupBox grpFilter;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.Label lblKhoaHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblLopHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHoc;
        private Guna.UI2.WinForms.Guna2Panel pnlDateFilter;
        private System.Windows.Forms.TableLayoutPanel tlpDateFilter;
        private System.Windows.Forms.Label lblTuNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2Button btnResetFilter;
        private Guna.UI2.WinForms.Guna2GroupBox grpLichHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichHoc;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private System.Windows.Forms.Label lblKetQua;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpDetail;
        private System.Windows.Forms.TableLayoutPanel tlpDetail;
        private Guna.UI2.WinForms.Guna2Panel pnlInfoCard;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblNgayGioTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayGio;
        private System.Windows.Forms.Label lblPhongTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtPhong;
        private System.Windows.Forms.Label lblGiaoVienTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaoVien;
        private Guna.UI2.WinForms.Guna2Panel pnlStatus;
        private System.Windows.Forms.Label lblTrangThaiTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlStatusBadge;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnBaoNghi;
    }
}