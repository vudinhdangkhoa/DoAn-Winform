namespace winform
{
    partial class frmChiTietKhoaHoc
    {
        private System.ComponentModel.IContainer components = null;

        // KHAI BÁO CÁC CONTROL MỚI
        private System.Windows.Forms.Label lblMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKhoaHoc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.grpBasic = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKhoaHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.picHinhAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKhoaHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblChuyenMon = new System.Windows.Forms.Label();
            this.cboChuyenMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHocPhi = new System.Windows.Forms.Label();
            this.numHocPhi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblSoBuoi = new System.Windows.Forms.Label();
            this.numSoBuoi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tabChiTiet = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabMoTa = new System.Windows.Forms.TabPage();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.tabMucTieu = new System.Windows.Forms.TabPage();
            this.rtbMucTieu = new System.Windows.Forms.RichTextBox();
            this.tabLoTrinh = new System.Windows.Forms.TabPage();
            this.rtbLoTrinh = new System.Windows.Forms.RichTextBox();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.grpBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoi)).BeginInit();
            this.tabChiTiet.SuspendLayout();
            this.tabMoTa.SuspendLayout();
            this.tabMucTieu.SuspendLayout();
            this.tabLoTrinh.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.tlpContent);
            this.pnlMain.Controls.Add(this.pnlActions);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContent.Controls.Add(this.grpBasic, 0, 0);
            this.tlpContent.Controls.Add(this.tabChiTiet, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 70);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(4);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1200, 650);
            this.tlpContent.TabIndex = 1;
            // 
            // grpBasic
            // 
            this.grpBasic.BorderRadius = 10;
            this.grpBasic.Controls.Add(this.picHinhAnh);
            this.grpBasic.Controls.Add(this.btnChonAnh);
            this.grpBasic.Controls.Add(this.lblMaKH);
            this.grpBasic.Controls.Add(this.txtMaKhoaHoc);
            this.grpBasic.Controls.Add(this.lblTenKH);
            this.grpBasic.Controls.Add(this.txtTenKhoaHoc);
            this.grpBasic.Controls.Add(this.lblChuyenMon);
            this.grpBasic.Controls.Add(this.cboChuyenMon);
            this.grpBasic.Controls.Add(this.lblSoBuoi);
            this.grpBasic.Controls.Add(this.numSoBuoi);
            this.grpBasic.Controls.Add(this.lblHocPhi);
            this.grpBasic.Controls.Add(this.numHocPhi);
            this.grpBasic.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grpBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBasic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBasic.ForeColor = System.Drawing.Color.White;
            this.grpBasic.Location = new System.Drawing.Point(24, 19);
            this.grpBasic.Margin = new System.Windows.Forms.Padding(4);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Size = new System.Drawing.Size(456, 612);
            this.grpBasic.TabIndex = 0;
            this.grpBasic.Text = "Thông tin cơ bản";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderRadius = 8;
            this.picHinhAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picHinhAnh.ImageRotate = 0F;
            this.picHinhAnh.Location = new System.Drawing.Point(103, 55);
            this.picHinhAnh.Margin = new System.Windows.Forms.Padding(4);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(250, 160);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 0;
            this.picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BorderRadius = 8;
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(148, 225);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(160, 40);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "📷 Chọn Ảnh";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaKH.Location = new System.Drawing.Point(25, 280);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(96, 20);
            this.lblMaKH.TabIndex = 10;
            this.lblMaKH.Text = "Mã Khóa Học";
            // 
            // txtMaKhoaHoc
            // 
            this.txtMaKhoaHoc.BorderRadius = 8;
            this.txtMaKhoaHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhoaHoc.DefaultText = "";
            this.txtMaKhoaHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtMaKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtMaKhoaHoc.Location = new System.Drawing.Point(25, 305);
            this.txtMaKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            this.txtMaKhoaHoc.PasswordChar = '\0';
            this.txtMaKhoaHoc.PlaceholderText = "Mã tự động";
            this.txtMaKhoaHoc.ReadOnly = true;
            this.txtMaKhoaHoc.SelectedText = "";
            this.txtMaKhoaHoc.Size = new System.Drawing.Size(406, 40);
            this.txtMaKhoaHoc.TabIndex = 11;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenKH.Location = new System.Drawing.Point(25, 360);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(99, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên Khóa Học";
            // 
            // txtTenKhoaHoc
            // 
            this.txtTenKhoaHoc.BorderRadius = 8;
            this.txtTenKhoaHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhoaHoc.DefaultText = "";
            this.txtTenKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenKhoaHoc.Location = new System.Drawing.Point(25, 385);
            this.txtTenKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            this.txtTenKhoaHoc.PasswordChar = '\0';
            this.txtTenKhoaHoc.PlaceholderText = "Nhập tên khóa học";
            this.txtTenKhoaHoc.SelectedText = "";
            this.txtTenKhoaHoc.Size = new System.Drawing.Size(406, 40);
            this.txtTenKhoaHoc.TabIndex = 3;
            // 
            // lblChuyenMon
            // 
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.BackColor = System.Drawing.Color.Transparent;
            this.lblChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChuyenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChuyenMon.Location = new System.Drawing.Point(25, 440);
            this.lblChuyenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.Size = new System.Drawing.Size(92, 20);
            this.lblChuyenMon.TabIndex = 4;
            this.lblChuyenMon.Text = "Chuyên Môn";
            // 
            // cboChuyenMon
            // 
            this.cboChuyenMon.BackColor = System.Drawing.Color.Transparent;
            this.cboChuyenMon.BorderRadius = 8;
            this.cboChuyenMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenMon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboChuyenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboChuyenMon.ItemHeight = 30;
            this.cboChuyenMon.Location = new System.Drawing.Point(25, 465);
            this.cboChuyenMon.Margin = new System.Windows.Forms.Padding(4);
            this.cboChuyenMon.Name = "cboChuyenMon";
            this.cboChuyenMon.Size = new System.Drawing.Size(406, 36);
            this.cboChuyenMon.TabIndex = 5;
            // 
            // lblSoBuoi
            // 
            this.lblSoBuoi.AutoSize = true;
            this.lblSoBuoi.BackColor = System.Drawing.Color.Transparent;
            this.lblSoBuoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoBuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoBuoi.Location = new System.Drawing.Point(25, 516);
            this.lblSoBuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoBuoi.Name = "lblSoBuoi";
            this.lblSoBuoi.Size = new System.Drawing.Size(62, 20);
            this.lblSoBuoi.TabIndex = 8;
            this.lblSoBuoi.Text = "Số Buổi";
            // 
            // numSoBuoi
            // 
            this.numSoBuoi.BackColor = System.Drawing.Color.Transparent;
            this.numSoBuoi.BorderRadius = 8;
            this.numSoBuoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoBuoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoBuoi.Location = new System.Drawing.Point(25, 541);
            this.numSoBuoi.Margin = new System.Windows.Forms.Padding(4);
            this.numSoBuoi.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numSoBuoi.Name = "numSoBuoi";
            this.numSoBuoi.Size = new System.Drawing.Size(195, 40);
            this.numSoBuoi.TabIndex = 9;
            this.numSoBuoi.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.numSoBuoi.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            // 
            // lblHocPhi
            // 
            this.lblHocPhi.AutoSize = true;
            this.lblHocPhi.BackColor = System.Drawing.Color.Transparent;
            this.lblHocPhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHocPhi.Location = new System.Drawing.Point(236, 516);
            this.lblHocPhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(103, 20);
            this.lblHocPhi.TabIndex = 6;
            this.lblHocPhi.Text = "Học Phí (VNĐ)";
            // 
            // numHocPhi
            // 
            this.numHocPhi.BackColor = System.Drawing.Color.Transparent;
            this.numHocPhi.BorderRadius = 8;
            this.numHocPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numHocPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numHocPhi.Location = new System.Drawing.Point(236, 541);
            this.numHocPhi.Margin = new System.Windows.Forms.Padding(4);
            this.numHocPhi.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numHocPhi.Name = "numHocPhi";
            this.numHocPhi.Size = new System.Drawing.Size(195, 40);
            this.numHocPhi.TabIndex = 7;
            this.numHocPhi.ThousandsSeparator = true;
            this.numHocPhi.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.numHocPhi.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabChiTiet.Controls.Add(this.tabMoTa);
            this.tabChiTiet.Controls.Add(this.tabMucTieu);
            this.tabChiTiet.Controls.Add(this.tabLoTrinh);
            this.tabChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChiTiet.ItemSize = new System.Drawing.Size(180, 45);
            this.tabChiTiet.Location = new System.Drawing.Point(488, 19);
            this.tabChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.SelectedIndex = 0;
            this.tabChiTiet.Size = new System.Drawing.Size(688, 612);
            this.tabChiTiet.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabChiTiet.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabChiTiet.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabChiTiet.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabChiTiet.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabChiTiet.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabChiTiet.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabChiTiet.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabChiTiet.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tabChiTiet.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tabChiTiet.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabChiTiet.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tabChiTiet.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabChiTiet.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabChiTiet.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabChiTiet.TabButtonSize = new System.Drawing.Size(180, 45);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.TabMenuBackColor = System.Drawing.Color.White;
            this.tabChiTiet.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalLeft;
            // 
            // tabMoTa
            // 
            this.tabMoTa.BackColor = System.Drawing.Color.White;
            this.tabMoTa.Controls.Add(this.rtbMoTa);
            this.tabMoTa.Location = new System.Drawing.Point(184, 4);
            this.tabMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.tabMoTa.Name = "tabMoTa";
            this.tabMoTa.Padding = new System.Windows.Forms.Padding(15);
            this.tabMoTa.Size = new System.Drawing.Size(500, 604);
            this.tabMoTa.TabIndex = 0;
            this.tabMoTa.Text = "Mô Tả";
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbMoTa.Location = new System.Drawing.Point(15, 15);
            this.rtbMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(470, 574);
            this.rtbMoTa.TabIndex = 0;
            this.rtbMoTa.Text = "";
            // 
            // tabMucTieu
            // 
            this.tabMucTieu.BackColor = System.Drawing.Color.White;
            this.tabMucTieu.Controls.Add(this.rtbMucTieu);
            this.tabMucTieu.Location = new System.Drawing.Point(184, 4);
            this.tabMucTieu.Margin = new System.Windows.Forms.Padding(4);
            this.tabMucTieu.Name = "tabMucTieu";
            this.tabMucTieu.Padding = new System.Windows.Forms.Padding(15);
            this.tabMucTieu.Size = new System.Drawing.Size(500, 604);
            this.tabMucTieu.TabIndex = 1;
            this.tabMucTieu.Text = "Mục Tiêu";
            // 
            // rtbMucTieu
            // 
            this.rtbMucTieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMucTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMucTieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbMucTieu.Location = new System.Drawing.Point(15, 15);
            this.rtbMucTieu.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMucTieu.Name = "rtbMucTieu";
            this.rtbMucTieu.Size = new System.Drawing.Size(470, 574);
            this.rtbMucTieu.TabIndex = 0;
            this.rtbMucTieu.Text = "";
            // 
            // tabLoTrinh
            // 
            this.tabLoTrinh.BackColor = System.Drawing.Color.White;
            this.tabLoTrinh.Controls.Add(this.rtbLoTrinh);
            this.tabLoTrinh.Location = new System.Drawing.Point(184, 4);
            this.tabLoTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.tabLoTrinh.Name = "tabLoTrinh";
            this.tabLoTrinh.Padding = new System.Windows.Forms.Padding(15);
            this.tabLoTrinh.Size = new System.Drawing.Size(500, 604);
            this.tabLoTrinh.TabIndex = 2;
            this.tabLoTrinh.Text = "Lộ Trình";
            // 
            // rtbLoTrinh
            // 
            this.rtbLoTrinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLoTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLoTrinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbLoTrinh.Location = new System.Drawing.Point(15, 15);
            this.rtbLoTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLoTrinh.Name = "rtbLoTrinh";
            this.rtbLoTrinh.Size = new System.Drawing.Size(470, 574);
            this.rtbLoTrinh.TabIndex = 0;
            this.rtbLoTrinh.Text = "";
            //
            // pnlActions
            //
            this.pnlActions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlActions.Location = new System.Drawing.Point(0, 720);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1200, 80);
            this.pnlActions.TabIndex = 2;
            //
            // btnHuy
            //
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(890, 16);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 48);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "✖ HỦY";
            //
            // btnLuu
            //
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1040, 16);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 48);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "💾 LƯU";
            //
            // lblTitle
            //
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẬP NHẬT KHÓA HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // frmChiTietKhoaHoc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Khóa Học";
            this.pnlMain.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoi)).EndInit();
            this.tabChiTiet.ResumeLayout(false);
            this.tabMoTa.ResumeLayout(false);
            this.tabMucTieu.ResumeLayout(false);
            this.tabLoTrinh.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private Guna.UI2.WinForms.Guna2GroupBox grpBasic;
        private Guna.UI2.WinForms.Guna2PictureBox picHinhAnh;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private System.Windows.Forms.Label lblTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhoaHoc;
        private System.Windows.Forms.Label lblChuyenMon;
        private Guna.UI2.WinForms.Guna2ComboBox cboChuyenMon;
        private Guna.UI2.WinForms.Guna2NumericUpDown numHocPhi;
        private System.Windows.Forms.Label lblSoBuoi;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoBuoi;
        private System.Windows.Forms.Label lblHocPhi;
        private Guna.UI2.WinForms.Guna2TabControl tabChiTiet;
        private System.Windows.Forms.TabPage tabMoTa;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.TabPage tabMucTieu;
        private System.Windows.Forms.RichTextBox rtbMucTieu;
        private System.Windows.Forms.TabPage tabLoTrinh;
        private System.Windows.Forms.RichTextBox rtbLoTrinh;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}