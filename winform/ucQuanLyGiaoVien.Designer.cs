namespace winform
{
    partial class ucQuanLyGiaoVien
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
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLeftContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvGiaoVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSearchHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddGV = new Guna.UI2.WinForms.Guna2Button();
            this.lblListTitle = new System.Windows.Forms.Label();

            this.pnlMiddle = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMiddleContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.grpDetail = new Guna.UI2.WinForms.Guna2GroupBox();

            this.pnlAvatar = new Guna.UI2.WinForms.Guna2Panel();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUploadImg = new Guna.UI2.WinForms.Guna2Button();

            this.pnlFormInputs = new Guna.UI2.WinForms.Guna2Panel();

            this.lblMaGV = new System.Windows.Forms.Label();
            this.txtMaGV = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblTenGV = new System.Windows.Forms.Label();
            this.txtTenGV = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();

            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.txtKinhNghiem = new Guna.UI2.WinForms.Guna2TextBox();

            this.pnlButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();

            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRightContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.grpSchedule = new Guna.UI2.WinForms.Guna2GroupBox();
            this.treeLichDay = new System.Windows.Forms.TreeView();
            this.pnlRightHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.lblScheduleTitle = new System.Windows.Forms.Label();

            this.tlpMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.pnlSearchHeader.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlMiddleContainer.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlFormInputs.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightContainer.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.pnlRightHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlMiddle, 1, 0);
            this.tlpMain.Controls.Add(this.pnlRight, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1300, 750);
            this.tlpMain.TabIndex = 0;

            // 
            // === LEFT PANEL (DANH SÁCH) ===
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlLeftContainer);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(13, 13);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlLeft.Size = new System.Drawing.Size(378, 724);
            this.pnlLeft.TabIndex = 0;

            // 
            // pnlLeftContainer
            // 
            this.pnlLeftContainer.BackColor = System.Drawing.Color.White;
            this.pnlLeftContainer.BorderRadius = 15;
            this.pnlLeftContainer.Controls.Add(this.dgvGiaoVien);
            this.pnlLeftContainer.Controls.Add(this.pnlSearchHeader);
            this.pnlLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftContainer.Name = "pnlLeftContainer";
            this.pnlLeftContainer.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLeftContainer.ShadowDecoration.BorderRadius = 15;
            this.pnlLeftContainer.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlLeftContainer.ShadowDecoration.Depth = 10;
            this.pnlLeftContainer.ShadowDecoration.Enabled = true;
            this.pnlLeftContainer.Size = new System.Drawing.Size(373, 724);
            this.pnlLeftContainer.TabIndex = 0;

            // 
            // pnlSearchHeader
            // 
            this.pnlSearchHeader.Controls.Add(this.lblListTitle);
            this.pnlSearchHeader.Controls.Add(this.txtSearch);
            this.pnlSearchHeader.Controls.Add(this.btnAddGV);
            this.pnlSearchHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchHeader.Location = new System.Drawing.Point(15, 15);
            this.pnlSearchHeader.Name = "pnlSearchHeader";
            this.pnlSearchHeader.Size = new System.Drawing.Size(343, 120);
            this.pnlSearchHeader.TabIndex = 0;

            // 
            // lblListTitle
            // 
            this.lblListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(343, 35);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "📋 Danh Sách Giáo Viên";
            this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            //this.txtSearch.IconLeft = global::winform.Properties.Resources.search_icon;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(0, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm theo tên, SĐT, ID...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(268, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);

            // 
            // btnAddGV
            // 
            this.btnAddGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGV.BorderRadius = 8;
            this.btnAddGV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddGV.ForeColor = System.Drawing.Color.White;
            this.btnAddGV.Location = new System.Drawing.Point(278, 45);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(65, 40);
            this.btnAddGV.TabIndex = 2;
            this.btnAddGV.Text = "+";

            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgvGiaoVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiaoVien.ColumnHeadersHeight = 45;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.dgvGiaoVien.Location = new System.Drawing.Point(15, 135);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersVisible = false;
            this.dgvGiaoVien.RowTemplate.Height = 40;
            this.dgvGiaoVien.Size = new System.Drawing.Size(343, 574);
            this.dgvGiaoVien.TabIndex = 1;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGiaoVien.ThemeStyle.ReadOnly = true;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvGiaoVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.Height = 40;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));

            // 
            // === MIDDLE PANEL (CHI TIẾT) ===
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Transparent;
            this.pnlMiddle.Controls.Add(this.pnlMiddleContainer);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(397, 13);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlMiddle.Size = new System.Drawing.Size(441, 724);
            this.pnlMiddle.TabIndex = 1;

            // 
            // pnlMiddleContainer
            // 
            this.pnlMiddleContainer.BackColor = System.Drawing.Color.White;
            this.pnlMiddleContainer.BorderRadius = 15;
            this.pnlMiddleContainer.Controls.Add(this.grpDetail);
            this.pnlMiddleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddleContainer.Location = new System.Drawing.Point(5, 0);
            this.pnlMiddleContainer.Name = "pnlMiddleContainer";
            this.pnlMiddleContainer.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMiddleContainer.ShadowDecoration.BorderRadius = 15;
            this.pnlMiddleContainer.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlMiddleContainer.ShadowDecoration.Depth = 10;
            this.pnlMiddleContainer.ShadowDecoration.Enabled = true;
            this.pnlMiddleContainer.Size = new System.Drawing.Size(431, 724);
            this.pnlMiddleContainer.TabIndex = 0;

            // 
            // grpDetail
            // 
            this.grpDetail.BorderColor = System.Drawing.Color.Transparent;
            this.grpDetail.BorderRadius = 10;
            this.grpDetail.Controls.Add(this.pnlButtons);
            this.grpDetail.Controls.Add(this.pnlFormInputs);
            this.grpDetail.Controls.Add(this.pnlAvatar);
            this.grpDetail.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grpDetail.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.White;
            this.grpDetail.Location = new System.Drawing.Point(15, 15);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(401, 694);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.Text = "👤 Thông Tin Chi Tiết";
            this.grpDetail.TextOffset = new System.Drawing.Point(10, 5);

            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Controls.Add(this.picAvatar);
            this.pnlAvatar.Controls.Add(this.btnUploadImg);
            this.pnlAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvatar.Location = new System.Drawing.Point(0, 50);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.pnlAvatar.Size = new System.Drawing.Size(401, 170);
            this.pnlAvatar.TabIndex = 0;

            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            //this.picAvatar.Image = global::winform.Properties.Resources.default_avatar;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(140, 20);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.picAvatar.ShadowDecoration.Depth = 15;
            this.picAvatar.ShadowDecoration.Enabled = true;
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;

            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadImg.BorderRadius = 8;
            this.btnUploadImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnUploadImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadImg.ForeColor = System.Drawing.Color.White;
            this.btnUploadImg.Location = new System.Drawing.Point(125, 140);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(150, 35);
            this.btnUploadImg.TabIndex = 1;
            this.btnUploadImg.Text = "📷 Chọn Ảnh";

            // 
            // pnlFormInputs
            // 
            this.pnlFormInputs.AutoScroll = true;
            this.pnlFormInputs.Controls.Add(this.lblMaGV);
            this.pnlFormInputs.Controls.Add(this.txtMaGV);
            this.pnlFormInputs.Controls.Add(this.lblTenGV);
            this.pnlFormInputs.Controls.Add(this.txtTenGV);
            this.pnlFormInputs.Controls.Add(this.lblNgaySinh);
            this.pnlFormInputs.Controls.Add(this.dtpNgaySinh);
            this.pnlFormInputs.Controls.Add(this.lblSDT);
            this.pnlFormInputs.Controls.Add(this.txtSDT);
            this.pnlFormInputs.Controls.Add(this.lblKinhNghiem);
            this.pnlFormInputs.Controls.Add(this.txtKinhNghiem);
            this.pnlFormInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormInputs.Location = new System.Drawing.Point(0, 220);
            this.pnlFormInputs.Name = "pnlFormInputs";
            this.pnlFormInputs.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlFormInputs.Size = new System.Drawing.Size(401, 394);
            this.pnlFormInputs.TabIndex = 1;

            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMaGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMaGV.Location = new System.Drawing.Point(20, 15);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(95, 17);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã Giáo Viên:";

            //// 
            // txtMaGV
            // 
            this.txtMaGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaGV.BorderRadius = 8;
            this.txtMaGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaGV.DefaultText = "";
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaGV.Location = new System.Drawing.Point(20, 35);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.PasswordChar = '\0';
            this.txtMaGV.PlaceholderText = "Tự động tạo";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.SelectedText = "";
            this.txtMaGV.Size = new System.Drawing.Size(341, 36);
            this.txtMaGV.TabIndex = 1;

            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTenGV.Location = new System.Drawing.Point(20, 80);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(99, 17);
            this.lblTenGV.TabIndex = 2;
            this.lblTenGV.Text = "Tên Giáo Viên:";

            // 
            // txtTenGV
            // 
            this.txtTenGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenGV.BorderRadius = 8;
            this.txtTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGV.DefaultText = "";
            this.txtTenGV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenGV.Location = new System.Drawing.Point(20, 100);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.PasswordChar = '\0';
            this.txtTenGV.PlaceholderText = "Nhập họ tên đầy đủ...";
            this.txtTenGV.SelectedText = "";
            this.txtTenGV.Size = new System.Drawing.Size(341, 36);
            this.txtTenGV.TabIndex = 3;

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 145);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(74, 17);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh:";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.BorderRadius = 8;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 165);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(341, 36);
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);

            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSDT.Location = new System.Drawing.Point(20, 210);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(100, 17);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "Số Điện Thoại:";

            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.BorderRadius = 8;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSDT.Location = new System.Drawing.Point(20, 230);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Nhập số điện thoại...";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(341, 36);
            this.txtSDT.TabIndex = 7;

            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.AutoSize = true;
            this.lblKinhNghiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKinhNghiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKinhNghiem.Location = new System.Drawing.Point(20, 275);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(138, 17);
            this.lblKinhNghiem.TabIndex = 8;
            this.lblKinhNghiem.Text = "Kinh Nghiệm (năm):";

            // 
            // txtKinhNghiem
            // 
            this.txtKinhNghiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKinhNghiem.BorderRadius = 8;
            this.txtKinhNghiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKinhNghiem.DefaultText = "";
            this.txtKinhNghiem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtKinhNghiem.Location = new System.Drawing.Point(20, 295);
            this.txtKinhNghiem.Name = "txtKinhNghiem";
            this.txtKinhNghiem.PasswordChar = '\0';
            this.txtKinhNghiem.PlaceholderText = "Nhập số năm kinh nghiệm...";
            this.txtKinhNghiem.SelectedText = "";
            this.txtKinhNghiem.Size = new System.Drawing.Size(341, 36);
            this.txtKinhNghiem.TabIndex = 9;

            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 614);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.pnlButtons.Size = new System.Drawing.Size(401, 80);
            this.pnlButtons.TabIndex = 2;

            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(20, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 45);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "💾 Lưu";

            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Enabled = false;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(211, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 45);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "🗑️ Xóa";

            // 
            // === RIGHT PANEL (LỊCH DẠY) ===
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlRightContainer);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(845, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(442, 724);
            this.pnlRight.TabIndex = 2;

            // 
            // pnlRightContainer
            // 
            this.pnlRightContainer.BackColor = System.Drawing.Color.White;
            this.pnlRightContainer.BorderRadius = 15;
            this.pnlRightContainer.Controls.Add(this.grpSchedule);
            this.pnlRightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContainer.Location = new System.Drawing.Point(5, 0);
            this.pnlRightContainer.Name = "pnlRightContainer";
            this.pnlRightContainer.Padding = new System.Windows.Forms.Padding(15);
            this.pnlRightContainer.ShadowDecoration.BorderRadius = 15;
            this.pnlRightContainer.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlRightContainer.ShadowDecoration.Depth = 10;
            this.pnlRightContainer.ShadowDecoration.Enabled = true;
            this.pnlRightContainer.Size = new System.Drawing.Size(437, 724);
            this.pnlRightContainer.TabIndex = 0;

            // 
            // grpSchedule
            // 
            this.grpSchedule.BorderColor = System.Drawing.Color.Transparent;
            this.grpSchedule.BorderRadius = 10;
            this.grpSchedule.Controls.Add(this.treeLichDay);
            this.grpSchedule.Controls.Add(this.pnlRightHeader);
            this.grpSchedule.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grpSchedule.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpSchedule.ForeColor = System.Drawing.Color.White;
            this.grpSchedule.Location = new System.Drawing.Point(15, 15);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(407, 694);
            this.grpSchedule.TabIndex = 0;
            this.grpSchedule.Text = "📅 Lịch Dạy";
            this.grpSchedule.TextOffset = new System.Drawing.Point(10, 5);

            // 
            // pnlRightHeader
            // 
            this.pnlRightHeader.Controls.Add(this.btnXuatExcel);
            this.pnlRightHeader.Controls.Add(this.lblScheduleTitle);
            this.pnlRightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightHeader.Location = new System.Drawing.Point(0, 50);
            this.pnlRightHeader.Name = "pnlRightHeader";
            this.pnlRightHeader.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.pnlRightHeader.Size = new System.Drawing.Size(407, 60);
            this.pnlRightHeader.TabIndex = 0;

            // 
            // lblScheduleTitle
            // 
            this.lblScheduleTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblScheduleTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblScheduleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblScheduleTitle.Location = new System.Drawing.Point(10, 10);
            this.lblScheduleTitle.Name = "lblScheduleTitle";
            this.lblScheduleTitle.Size = new System.Drawing.Size(200, 45);
            this.lblScheduleTitle.TabIndex = 0;
            this.lblScheduleTitle.Text = "Lịch dạy sắp tới";
            this.lblScheduleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.BorderRadius = 8;
            this.btnXuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(260, 15);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(135, 35);
            this.btnXuatExcel.TabIndex = 1;
            this.btnXuatExcel.Text = "📊 Xuất Excel";

            // 
            // treeLichDay
            // 
            this.treeLichDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeLichDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLichDay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.treeLichDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.treeLichDay.Location = new System.Drawing.Point(0, 110);
            this.treeLichDay.Name = "treeLichDay";
            this.treeLichDay.Size = new System.Drawing.Size(407, 584);
            this.treeLichDay.TabIndex = 1;

            // 
            // ucQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQuanLyGiaoVien";
            this.Size = new System.Drawing.Size(1300, 750);
            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.pnlSearchHeader.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddleContainer.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            this.pnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlFormInputs.ResumeLayout(false);
            this.pnlFormInputs.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRightContainer.ResumeLayout(false);
            this.grpSchedule.ResumeLayout(false);
            this.pnlRightHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlLeftContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiaoVien;
        private Guna.UI2.WinForms.Guna2Panel pnlSearchHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddGV;
        private System.Windows.Forms.Label lblListTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlMiddle;
        private Guna.UI2.WinForms.Guna2Panel pnlMiddleContainer;
        private Guna.UI2.WinForms.Guna2GroupBox grpDetail;
        private Guna.UI2.WinForms.Guna2Panel pnlAvatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Button btnUploadImg;
        private Guna.UI2.WinForms.Guna2Panel pnlFormInputs;
        private System.Windows.Forms.Label lblMaGV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaGV;
        private System.Windows.Forms.Label lblTenGV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenGV;
        private System.Windows.Forms.Label lblNgaySinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label lblKinhNghiem;
        private Guna.UI2.WinForms.Guna2TextBox txtKinhNghiem;
        private Guna.UI2.WinForms.Guna2Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2Panel pnlRightContainer;
        private Guna.UI2.WinForms.Guna2GroupBox grpSchedule;
        private System.Windows.Forms.TreeView treeLichDay;
        private Guna.UI2.WinForms.Guna2Panel pnlRightHeader;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private System.Windows.Forms.Label lblScheduleTitle;
    }
}