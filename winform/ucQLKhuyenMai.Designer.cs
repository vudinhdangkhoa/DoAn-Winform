namespace winform
{
    partial class ucQLKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleList = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpQuickAdd = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpQuickAdd = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuickName = new Guna.UI2.WinForms.Guna2TextBox();
            this.numQuickPercent = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnQuickAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKhuyenMai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlRightContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpInfoInputs = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInfoPercent = new System.Windows.Forms.Label();
            this.grpApply = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpApply = new System.Windows.Forms.TableLayoutPanel();
            this.cboTargetType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTargetItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddTarget = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAppliedList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlBottomActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSaveAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteApplied = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.pnlLeftContainer.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.grpQuickAdd.SuspendLayout();
            this.tlpQuickAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuickPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.pnlRightContainer.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.tlpInfoInputs.SuspendLayout();
            this.grpApply.SuspendLayout();
            this.tlpApply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedList)).BeginInit();
            this.pnlBottomActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.Controls.Add(this.pnlLeftContainer, 0, 0);
            this.tlpMain.Controls.Add(this.pnlRightContainer, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(5);
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1000, 600);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeftContainer
            // 
            this.pnlLeftContainer.BorderRadius = 8;
            this.pnlLeftContainer.Controls.Add(this.tlpLeft);
            this.pnlLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftContainer.FillColor = System.Drawing.Color.White;
            this.pnlLeftContainer.Location = new System.Drawing.Point(8, 8);
            this.pnlLeftContainer.Name = "pnlLeftContainer";
            this.pnlLeftContainer.Size = new System.Drawing.Size(340, 584);
            this.pnlLeftContainer.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.lblTitleList, 0, 0);
            this.tlpLeft.Controls.Add(this.txtSearch, 0, 1);
            this.tlpLeft.Controls.Add(this.grpQuickAdd, 0, 2);
            this.tlpLeft.Controls.Add(this.dgvKhuyenMai, 0, 3);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.Padding = new System.Windows.Forms.Padding(10);
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(340, 584);
            this.tlpLeft.TabIndex = 0;
            // 
            // lblTitleList
            // 
            this.lblTitleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitleList.Location = new System.Drawing.Point(13, 10);
            this.lblTitleList.Name = "lblTitleList";
            this.lblTitleList.Size = new System.Drawing.Size(314, 40);
            this.lblTitleList.TabIndex = 0;
            this.lblTitleList.Text = "DANH SÁCH KHUYẾN MÃI";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(13, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(314, 44);
            this.txtSearch.TabIndex = 1;
            // 
            // grpQuickAdd
            // 
            this.grpQuickAdd.Controls.Add(this.tlpQuickAdd);
            this.grpQuickAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQuickAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpQuickAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpQuickAdd.Location = new System.Drawing.Point(13, 103);
            this.grpQuickAdd.Name = "grpQuickAdd";
            this.grpQuickAdd.Size = new System.Drawing.Size(314, 124);
            this.grpQuickAdd.TabIndex = 2;
            this.grpQuickAdd.Text = "Thêm Mới Nhanh";
            // 
            // tlpQuickAdd
            // 
            this.tlpQuickAdd.ColumnCount = 2;
            this.tlpQuickAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.76316F));
            this.tlpQuickAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.23684F));
            this.tlpQuickAdd.Controls.Add(this.txtQuickName, 0, 0);
            this.tlpQuickAdd.Controls.Add(this.numQuickPercent, 1, 0);
            this.tlpQuickAdd.Controls.Add(this.btnQuickAdd, 0, 1);
            this.tlpQuickAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuickAdd.Location = new System.Drawing.Point(0, 40);
            this.tlpQuickAdd.Name = "tlpQuickAdd";
            this.tlpQuickAdd.Padding = new System.Windows.Forms.Padding(5);
            this.tlpQuickAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpQuickAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpQuickAdd.Size = new System.Drawing.Size(314, 84);
            this.tlpQuickAdd.TabIndex = 0;
            this.tlpQuickAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpQuickAdd_Paint);
            // 
            // txtQuickName
            // 
            this.txtQuickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuickName.DefaultText = "";
            this.txtQuickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuickName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuickName.Location = new System.Drawing.Point(8, 8);
            this.txtQuickName.Name = "txtQuickName";
            this.txtQuickName.PlaceholderText = "Tên chương trình...";
            this.txtQuickName.SelectedText = "";
            this.txtQuickName.Size = new System.Drawing.Size(200, 34);
            this.txtQuickName.TabIndex = 0;
            // 
            // numQuickPercent
            // 
            this.numQuickPercent.BackColor = System.Drawing.Color.Transparent;
            this.numQuickPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuickPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuickPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuickPercent.Location = new System.Drawing.Point(214, 8);
            this.numQuickPercent.Name = "numQuickPercent";
            this.numQuickPercent.Size = new System.Drawing.Size(92, 34);
            this.numQuickPercent.TabIndex = 1;
            // 
            // btnQuickAdd
            // 
            this.tlpQuickAdd.SetColumnSpan(this.btnQuickAdd, 2);
            this.btnQuickAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuickAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnQuickAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuickAdd.ForeColor = System.Drawing.Color.White;
            this.btnQuickAdd.Location = new System.Drawing.Point(8, 48);
            this.btnQuickAdd.Name = "btnQuickAdd";
            this.btnQuickAdd.Size = new System.Drawing.Size(298, 34);
            this.btnQuickAdd.TabIndex = 2;
            this.btnQuickAdd.Text = "Thêm Mới";
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuyenMai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.Location = new System.Drawing.Point(13, 233);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(314, 338);
            this.dgvKhuyenMai.TabIndex = 3;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvKhuyenMai.ThemeStyle.ReadOnly = true;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlRightContainer
            // 
            this.pnlRightContainer.Controls.Add(this.tlpRight);
            this.pnlRightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContainer.Location = new System.Drawing.Point(356, 5);
            this.pnlRightContainer.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlRightContainer.Name = "pnlRightContainer";
            this.pnlRightContainer.Size = new System.Drawing.Size(639, 590);
            this.pnlRightContainer.TabIndex = 1;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.Controls.Add(this.grpInfo, 0, 0);
            this.tlpRight.Controls.Add(this.grpApply, 0, 1);
            this.tlpRight.Controls.Add(this.pnlBottomActions, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpRight.Size = new System.Drawing.Size(639, 590);
            this.tlpRight.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.tlpInfoInputs);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(633, 84);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.Text = "THÔNG TIN CHI TIẾT";
            // 
            // tlpInfoInputs
            // 
            this.tlpInfoInputs.ColumnCount = 2;
            this.tlpInfoInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpInfoInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInfoInputs.Controls.Add(this.txtTenKM, 0, 0);
            this.tlpInfoInputs.Controls.Add(this.lblInfoPercent, 1, 0);
            this.tlpInfoInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfoInputs.Location = new System.Drawing.Point(0, 40);
            this.tlpInfoInputs.Name = "tlpInfoInputs";
            this.tlpInfoInputs.Padding = new System.Windows.Forms.Padding(10, 45, 10, 5);
            this.tlpInfoInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfoInputs.Size = new System.Drawing.Size(633, 44);
            this.tlpInfoInputs.TabIndex = 0;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKM.DefaultText = "";
            this.txtTenKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKM.Location = new System.Drawing.Point(13, 48);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.PlaceholderText = "";
            this.txtTenKM.ReadOnly = true;
            this.txtTenKM.SelectedText = "";
            this.txtTenKM.Size = new System.Drawing.Size(423, 14);
            this.txtTenKM.TabIndex = 0;
            // 
            // lblInfoPercent
            // 
            this.lblInfoPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoPercent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInfoPercent.Location = new System.Drawing.Point(442, 45);
            this.lblInfoPercent.Name = "lblInfoPercent";
            this.lblInfoPercent.Size = new System.Drawing.Size(178, 20);
            this.lblInfoPercent.TabIndex = 1;
            this.lblInfoPercent.Text = "0%";
            this.lblInfoPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpApply
            // 
            this.grpApply.Controls.Add(this.tlpApply);
            this.grpApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpApply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpApply.Location = new System.Drawing.Point(3, 93);
            this.grpApply.Name = "grpApply";
            this.grpApply.Size = new System.Drawing.Size(633, 434);
            this.grpApply.TabIndex = 1;
            this.grpApply.Text = "ÁP DỤNG KHUYẾN MÃI";
            // 
            // tlpApply
            // 
            this.tlpApply.ColumnCount = 5;
            this.tlpApply.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.42215F));
            this.tlpApply.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.33708F));
            this.tlpApply.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpApply.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpApply.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpApply.Controls.Add(this.cboTargetType, 0, 0);
            this.tlpApply.Controls.Add(this.cboTargetItem, 1, 0);
            this.tlpApply.Controls.Add(this.dtpStart, 2, 0);
            this.tlpApply.Controls.Add(this.dtpEnd, 3, 0);
            this.tlpApply.Controls.Add(this.btnAddTarget, 4, 0);
            this.tlpApply.Controls.Add(this.dgvAppliedList, 0, 1);
            this.tlpApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApply.Location = new System.Drawing.Point(0, 40);
            this.tlpApply.Name = "tlpApply";
            this.tlpApply.Padding = new System.Windows.Forms.Padding(5);
            this.tlpApply.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpApply.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApply.Size = new System.Drawing.Size(633, 394);
            this.tlpApply.TabIndex = 0;
            // 
            // cboTargetType
            // 
            this.cboTargetType.BackColor = System.Drawing.Color.Transparent;
            this.cboTargetType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTargetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetType.FocusedColor = System.Drawing.Color.Empty;
            this.cboTargetType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTargetType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTargetType.ItemHeight = 30;
            this.cboTargetType.Items.AddRange(new object[] {
            "Khóa Học",
            "Họa Cụ"});
            this.cboTargetType.Location = new System.Drawing.Point(8, 8);
            this.cboTargetType.Name = "cboTargetType";
            this.cboTargetType.Size = new System.Drawing.Size(115, 36);
            this.cboTargetType.StartIndex = 0;
            this.cboTargetType.TabIndex = 0;
            // 
            // cboTargetItem
            // 
            this.cboTargetItem.BackColor = System.Drawing.Color.Transparent;
            this.cboTargetItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTargetItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTargetItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetItem.FocusedColor = System.Drawing.Color.Empty;
            this.cboTargetItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTargetItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTargetItem.ItemHeight = 30;
            this.cboTargetItem.Location = new System.Drawing.Point(129, 8);
            this.cboTargetItem.Name = "cboTargetItem";
            this.cboTargetItem.Size = new System.Drawing.Size(183, 36);
            this.cboTargetItem.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = true;
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(318, 8);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(118, 44);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.Value = new System.DateTime(2025, 11, 21, 0, 51, 24, 722);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = true;
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.Location = new System.Drawing.Point(442, 8);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(118, 44);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.Value = new System.DateTime(2025, 11, 21, 0, 51, 24, 749);
            // 
            // btnAddTarget
            // 
            this.btnAddTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTarget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTarget.ForeColor = System.Drawing.Color.White;
            this.btnAddTarget.Location = new System.Drawing.Point(566, 8);
            this.btnAddTarget.Name = "btnAddTarget";
            this.btnAddTarget.Size = new System.Drawing.Size(59, 44);
            this.btnAddTarget.TabIndex = 4;
            this.btnAddTarget.Text = "+";
            // 
            // dgvAppliedList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppliedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tlpApply.SetColumnSpan(this.dgvAppliedList, 5);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppliedList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppliedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppliedList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppliedList.Location = new System.Drawing.Point(8, 58);
            this.dgvAppliedList.Name = "dgvAppliedList";
            this.dgvAppliedList.ReadOnly = true;
            this.dgvAppliedList.RowHeadersVisible = false;
            this.dgvAppliedList.Size = new System.Drawing.Size(617, 328);
            this.dgvAppliedList.TabIndex = 5;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppliedList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppliedList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvAppliedList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppliedList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvAppliedList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppliedList.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvAppliedList.ThemeStyle.ReadOnly = true;
            this.dgvAppliedList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppliedList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvAppliedList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppliedList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAppliedList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppliedList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlBottomActions
            // 
            this.pnlBottomActions.Controls.Add(this.btnSaveAll);
            this.pnlBottomActions.Controls.Add(this.btnDeleteApplied);
            this.pnlBottomActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomActions.Location = new System.Drawing.Point(3, 533);
            this.pnlBottomActions.Name = "pnlBottomActions";
            this.pnlBottomActions.Size = new System.Drawing.Size(633, 54);
            this.pnlBottomActions.TabIndex = 2;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAll.BorderRadius = 5;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Location = new System.Drawing.Point(933, 10);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(180, 40);
            this.btnSaveAll.TabIndex = 0;
            this.btnSaveAll.Text = "LƯU THAY ĐỔI (API)";
            // 
            // btnDeleteApplied
            // 
            this.btnDeleteApplied.BorderRadius = 5;
            this.btnDeleteApplied.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteApplied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteApplied.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApplied.Location = new System.Drawing.Point(10, 10);
            this.btnDeleteApplied.Name = "btnDeleteApplied";
            this.btnDeleteApplied.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteApplied.TabIndex = 1;
            this.btnDeleteApplied.Text = "Xóa Dòng Chọn";
            // 
            // ucQLKhuyenMai
            // 
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQLKhuyenMai";
            this.Size = new System.Drawing.Size(1000, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlLeftContainer.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.grpQuickAdd.ResumeLayout(false);
            this.tlpQuickAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuickPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.pnlRightContainer.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.tlpInfoInputs.ResumeLayout(false);
            this.grpApply.ResumeLayout(false);
            this.tlpApply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedList)).EndInit();
            this.pnlBottomActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlLeftContainer;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.Label lblTitleList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GroupBox grpQuickAdd;
        private System.Windows.Forms.TableLayoutPanel tlpQuickAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtQuickName;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuickPercent;
        private Guna.UI2.WinForms.Guna2Button btnQuickAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhuyenMai;

        private Guna.UI2.WinForms.Guna2Panel pnlRightContainer;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInfoInputs;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKM;
        private System.Windows.Forms.Label lblInfoPercent;

        private Guna.UI2.WinForms.Guna2GroupBox grpApply;
        private System.Windows.Forms.TableLayoutPanel tlpApply;
        private Guna.UI2.WinForms.Guna2ComboBox cboTargetType;
        private Guna.UI2.WinForms.Guna2ComboBox cboTargetItem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2Button btnAddTarget;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppliedList;

        private Guna.UI2.WinForms.Guna2Panel pnlBottomActions;
        private Guna.UI2.WinForms.Guna2Button btnSaveAll;
        private Guna.UI2.WinForms.Guna2Button btnDeleteApplied;
    }
}