using System.Windows.Forms;

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
            this.pnlLeftHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitleList = new System.Windows.Forms.Label();
            this.grpQuickAdd = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpQuickAdd = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuickName = new System.Windows.Forms.Label();
            this.txtQuickName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuickPercent = new System.Windows.Forms.Label();
            this.btnQuickAdd = new Guna.UI2.WinForms.Guna2Button();
            this.numQuickPercent = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvKhuyenMai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlRightContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenKM = new System.Windows.Forms.Label();
            this.txtTenKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhanTram = new System.Windows.Forms.Label();
            this.lblInfoPercent = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlInfoButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuyChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.grpApply = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpApply = new System.Windows.Forms.TableLayoutPanel();
            this.pnlApplyInputs = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpApplyControls = new System.Windows.Forms.TableLayoutPanel();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboTargetType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.cboTargetItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddTarget = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAppliedList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlBottomActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSaveAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKMApDung = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteApplied = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.pnlLeftContainer.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.grpQuickAdd.SuspendLayout();
            this.tlpQuickAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.pnlRightContainer.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.pnlInfoButtons.SuspendLayout();
            this.grpApply.SuspendLayout();
            this.tlpApply.SuspendLayout();
            this.pnlApplyInputs.SuspendLayout();
            this.tlpApplyControls.SuspendLayout();
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
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 700);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeftContainer
            // 
            this.pnlLeftContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlLeftContainer.BorderRadius = 10;
            this.pnlLeftContainer.BorderThickness = 1;
            this.pnlLeftContainer.Controls.Add(this.tlpLeft);
            this.pnlLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftContainer.FillColor = System.Drawing.Color.White;
            this.pnlLeftContainer.Location = new System.Drawing.Point(13, 13);
            this.pnlLeftContainer.Name = "pnlLeftContainer";
            this.pnlLeftContainer.ShadowDecoration.BorderRadius = 10;
            this.pnlLeftContainer.ShadowDecoration.Depth = 5;
            this.pnlLeftContainer.ShadowDecoration.Enabled = true;
            this.pnlLeftContainer.Size = new System.Drawing.Size(407, 674);
            this.pnlLeftContainer.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.pnlLeftHeader, 0, 0);
            this.tlpLeft.Controls.Add(this.grpQuickAdd, 0, 1);
            this.tlpLeft.Controls.Add(this.dgvKhuyenMai, 0, 2);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.Padding = new System.Windows.Forms.Padding(15);
            this.tlpLeft.RowCount = 3;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(407, 674);
            this.tlpLeft.TabIndex = 0;
            // 
            // pnlLeftHeader
            // 
            this.pnlLeftHeader.Controls.Add(this.txtSearch);
            this.pnlLeftHeader.Controls.Add(this.lblTitleList);
            this.pnlLeftHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftHeader.Location = new System.Drawing.Point(18, 18);
            this.pnlLeftHeader.Name = "pnlLeftHeader";
            this.pnlLeftHeader.Size = new System.Drawing.Size(371, 94);
            this.pnlLeftHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(0, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm khuyến mãi...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(371, 46);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lblTitleList
            // 
            this.lblTitleList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitleList.Location = new System.Drawing.Point(0, 0);
            this.lblTitleList.Name = "lblTitleList";
            this.lblTitleList.Size = new System.Drawing.Size(371, 35);
            this.lblTitleList.TabIndex = 0;
            this.lblTitleList.Text = "DANH SÁCH KHUYẾN MÃI";
            this.lblTitleList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpQuickAdd
            // 
            this.grpQuickAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpQuickAdd.BorderRadius = 10;
            this.grpQuickAdd.Controls.Add(this.tlpQuickAdd);
            this.grpQuickAdd.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grpQuickAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQuickAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpQuickAdd.ForeColor = System.Drawing.Color.White;
            this.grpQuickAdd.Location = new System.Drawing.Point(18, 118);
            this.grpQuickAdd.Name = "grpQuickAdd";
            this.grpQuickAdd.Size = new System.Drawing.Size(371, 174);
            this.grpQuickAdd.TabIndex = 1;
            this.grpQuickAdd.Text = "THÊM MỚI NHANH";
            this.grpQuickAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpQuickAdd
            // 
            this.tlpQuickAdd.ColumnCount = 2;
            this.tlpQuickAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpQuickAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuickAdd.Controls.Add(this.lblQuickName, 0, 0);
            this.tlpQuickAdd.Controls.Add(this.txtQuickName, 1, 0);
            this.tlpQuickAdd.Controls.Add(this.lblQuickPercent, 0, 1);
            this.tlpQuickAdd.Controls.Add(this.btnQuickAdd, 0, 2);
            this.tlpQuickAdd.Controls.Add(this.numQuickPercent, 1, 1);
            this.tlpQuickAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuickAdd.Location = new System.Drawing.Point(0, 40);
            this.tlpQuickAdd.Name = "tlpQuickAdd";
            this.tlpQuickAdd.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.tlpQuickAdd.RowCount = 3;
            this.tlpQuickAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpQuickAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpQuickAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpQuickAdd.Size = new System.Drawing.Size(371, 134);
            this.tlpQuickAdd.TabIndex = 0;
            // 
            // lblQuickName
            // 
            this.lblQuickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuickName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuickName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuickName.Location = new System.Drawing.Point(18, 10);
            this.lblQuickName.Name = "lblQuickName";
            this.lblQuickName.Size = new System.Drawing.Size(114, 40);
            this.lblQuickName.TabIndex = 0;
            this.lblQuickName.Text = "Tên KM:";
            this.lblQuickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuickName
            // 
            this.txtQuickName.BorderRadius = 8;
            this.txtQuickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuickName.DefaultText = "";
            this.txtQuickName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuickName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuickName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuickName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuickName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuickName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuickName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuickName.Location = new System.Drawing.Point(138, 14);
            this.txtQuickName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuickName.Name = "txtQuickName";
            this.txtQuickName.PlaceholderText = "Nhập tên chương trình...";
            this.txtQuickName.SelectedText = "";
            this.txtQuickName.Size = new System.Drawing.Size(215, 32);
            this.txtQuickName.TabIndex = 1;
            // 
            // lblQuickPercent
            // 
            this.lblQuickPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuickPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuickPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuickPercent.Location = new System.Drawing.Point(18, 50);
            this.lblQuickPercent.Name = "lblQuickPercent";
            this.lblQuickPercent.Size = new System.Drawing.Size(114, 40);
            this.lblQuickPercent.TabIndex = 2;
            this.lblQuickPercent.Text = "% Giảm giá:";
            this.lblQuickPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuickAdd
            // 
            this.btnQuickAdd.BorderRadius = 6;
            this.tlpQuickAdd.SetColumnSpan(this.btnQuickAdd, 2);
            this.btnQuickAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuickAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuickAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuickAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuickAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuickAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnQuickAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickAdd.ForeColor = System.Drawing.Color.White;
            this.btnQuickAdd.Location = new System.Drawing.Point(18, 93);
            this.btnQuickAdd.Name = "btnQuickAdd";
            this.btnQuickAdd.Size = new System.Drawing.Size(335, 39);
            this.btnQuickAdd.TabIndex = 4;
            this.btnQuickAdd.Text = "✓ THÊM KHUYẾN MÃI";
            // 
            // numQuickPercent
            // 
            this.numQuickPercent.BorderRadius = 8;
            this.numQuickPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuickPercent.DefaultText = "";
            this.numQuickPercent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numQuickPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numQuickPercent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numQuickPercent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numQuickPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuickPercent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numQuickPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuickPercent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numQuickPercent.Location = new System.Drawing.Point(138, 54);
            this.numQuickPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuickPercent.Name = "numQuickPercent";
            this.numQuickPercent.PlaceholderText = "";
            this.numQuickPercent.SelectedText = "";
            this.numQuickPercent.Size = new System.Drawing.Size(215, 32);
            this.numQuickPercent.TabIndex = 5;
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            this.dgvKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvKhuyenMai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhuyenMai.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuyenMai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.Location = new System.Drawing.Point(18, 298);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 35;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(371, 358);
            this.dgvKhuyenMai.TabIndex = 2;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvKhuyenMai.ThemeStyle.ReadOnly = true;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.Height = 35;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlRightContainer
            // 
            this.pnlRightContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlRightContainer.BorderRadius = 10;
            this.pnlRightContainer.BorderThickness = 1;
            this.pnlRightContainer.Controls.Add(this.tlpRight);
            this.pnlRightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContainer.FillColor = System.Drawing.Color.White;
            this.pnlRightContainer.Location = new System.Drawing.Point(433, 13);
            this.pnlRightContainer.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pnlRightContainer.Name = "pnlRightContainer";
            this.pnlRightContainer.ShadowDecoration.BorderRadius = 10;
            this.pnlRightContainer.ShadowDecoration.Depth = 5;
            this.pnlRightContainer.ShadowDecoration.Enabled = true;
            this.pnlRightContainer.Size = new System.Drawing.Size(754, 674);
            this.pnlRightContainer.TabIndex = 1;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.grpInfo, 0, 0);
            this.tlpRight.Controls.Add(this.grpApply, 0, 1);
            this.tlpRight.Controls.Add(this.pnlBottomActions, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.Padding = new System.Windows.Forms.Padding(15);
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpRight.Size = new System.Drawing.Size(754, 674);
            this.tlpRight.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpInfo.BorderRadius = 10;
            this.grpInfo.Controls.Add(this.tlpInfo);
            this.grpInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(18, 18);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(718, 134);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.Text = "THÔNG TIN KHUYẾN MÃI";
            this.grpInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 3;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.Controls.Add(this.lblTenKM, 0, 0);
            this.tlpInfo.Controls.Add(this.txtTenKM, 0, 1);
            this.tlpInfo.Controls.Add(this.lblPhanTram, 1, 0);
            this.tlpInfo.Controls.Add(this.lblInfoPercent, 1, 1);
            this.tlpInfo.Controls.Add(this.pnlInfoButtons, 2, 0);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(0, 40);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.Padding = new System.Windows.Forms.Padding(15, 5, 15, 10);
            this.tlpInfo.RowCount = 2;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Size = new System.Drawing.Size(718, 94);
            this.tlpInfo.TabIndex = 0;
            // 
            // lblTenKM
            // 
            this.lblTenKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenKM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenKM.Location = new System.Drawing.Point(18, 5);
            this.lblTenKM.Name = "lblTenKM";
            this.lblTenKM.Size = new System.Drawing.Size(338, 30);
            this.lblTenKM.TabIndex = 0;
            this.lblTenKM.Text = "Tên khuyến mãi:";
            this.lblTenKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenKM
            // 
            this.txtTenKM.BorderRadius = 8;
            this.txtTenKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKM.DefaultText = "";
            this.txtTenKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKM.Location = new System.Drawing.Point(18, 39);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.PlaceholderText = "Nhập tên khuyến mãi";
            this.txtTenKM.SelectedText = "";
            this.txtTenKM.Size = new System.Drawing.Size(338, 41);
            this.txtTenKM.TabIndex = 1;
            // 
            // lblPhanTram
            // 
            this.lblPhanTram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhanTram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhanTram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhanTram.Location = new System.Drawing.Point(362, 5);
            this.lblPhanTram.Name = "lblPhanTram";
            this.lblPhanTram.Size = new System.Drawing.Size(166, 30);
            this.lblPhanTram.TabIndex = 2;
            this.lblPhanTram.Text = "% Giảm giá:";
            this.lblPhanTram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoPercent
            // 
            this.lblInfoPercent.BorderRadius = 8;
            this.lblInfoPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInfoPercent.DefaultText = "";
            this.lblInfoPercent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblInfoPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblInfoPercent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblInfoPercent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblInfoPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoPercent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblInfoPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoPercent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblInfoPercent.Location = new System.Drawing.Point(362, 39);
            this.lblInfoPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblInfoPercent.Name = "lblInfoPercent";
            this.lblInfoPercent.PlaceholderText = "%";
            this.lblInfoPercent.SelectedText = "";
            this.lblInfoPercent.Size = new System.Drawing.Size(166, 41);
            this.lblInfoPercent.TabIndex = 3;
            // 
            // pnlInfoButtons
            // 
            this.pnlInfoButtons.Controls.Add(this.btnHuyChinhSua);
            this.pnlInfoButtons.Controls.Add(this.btnLuuChinhSua);
            this.pnlInfoButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoButtons.Location = new System.Drawing.Point(534, 8);
            this.pnlInfoButtons.Name = "pnlInfoButtons";
            this.tlpInfo.SetRowSpan(this.pnlInfoButtons, 2);
            this.pnlInfoButtons.Size = new System.Drawing.Size(166, 73);
            this.pnlInfoButtons.TabIndex = 4;
            // 
            // btnHuyChinhSua
            // 
            this.btnHuyChinhSua.BorderRadius = 8;
            this.btnHuyChinhSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyChinhSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyChinhSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyChinhSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyChinhSua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHuyChinhSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuyChinhSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnHuyChinhSua.Location = new System.Drawing.Point(0, 41);
            this.btnHuyChinhSua.Name = "btnHuyChinhSua";
            this.btnHuyChinhSua.Size = new System.Drawing.Size(166, 32);
            this.btnHuyChinhSua.TabIndex = 1;
            this.btnHuyChinhSua.Text = "✖ HỦY";
            this.btnHuyChinhSua.Click += new System.EventHandler(this.btnHuyChinhSua_Click);
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.BorderRadius = 8;
            this.btnLuuChinhSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuChinhSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuChinhSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuChinhSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuChinhSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuuChinhSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuuChinhSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnLuuChinhSua.Location = new System.Drawing.Point(0, 0);
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.Size = new System.Drawing.Size(166, 32);
            this.btnLuuChinhSua.TabIndex = 0;
            this.btnLuuChinhSua.Text = "✓ LƯU";
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btnLuuChinhSua_Click);
            // 
            // grpApply
            // 
            this.grpApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpApply.BorderRadius = 10;
            this.grpApply.Controls.Add(this.tlpApply);
            this.grpApply.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grpApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpApply.ForeColor = System.Drawing.Color.White;
            this.grpApply.Location = new System.Drawing.Point(18, 158);
            this.grpApply.Name = "grpApply";
            this.grpApply.Size = new System.Drawing.Size(718, 428);
            this.grpApply.TabIndex = 1;
            this.grpApply.Text = "ÁP DỤNG KHUYẾN MÃI";
            this.grpApply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpApply
            // 
            this.tlpApply.ColumnCount = 1;
            this.tlpApply.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApply.Controls.Add(this.pnlApplyInputs, 0, 0);
            this.tlpApply.Controls.Add(this.dgvAppliedList, 0, 1);
            this.tlpApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApply.Location = new System.Drawing.Point(0, 40);
            this.tlpApply.Name = "tlpApply";
            this.tlpApply.Padding = new System.Windows.Forms.Padding(15, 5, 15, 10);
            this.tlpApply.RowCount = 2;
            this.tlpApply.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpApply.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApply.Size = new System.Drawing.Size(718, 388);
            this.tlpApply.TabIndex = 0;
            // 
            // pnlApplyInputs
            // 
            this.pnlApplyInputs.Controls.Add(this.tlpApplyControls);
            this.pnlApplyInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApplyInputs.Location = new System.Drawing.Point(18, 8);
            this.pnlApplyInputs.Name = "pnlApplyInputs";
            this.pnlApplyInputs.Size = new System.Drawing.Size(682, 114);
            this.pnlApplyInputs.TabIndex = 0;
            // 
            // tlpApplyControls
            // 
            this.tlpApplyControls.ColumnCount = 6;
            this.tlpApplyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpApplyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpApplyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpApplyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpApplyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpApplyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tlpApplyControls.Controls.Add(this.lblLoai, 0, 0);
            this.tlpApplyControls.Controls.Add(this.cboTargetType, 0, 1);
            this.tlpApplyControls.Controls.Add(this.lblDoiTuong, 1, 0);
            this.tlpApplyControls.Controls.Add(this.cboTargetItem, 1, 1);
            this.tlpApplyControls.Controls.Add(this.lblNgayBD, 2, 0);
            this.tlpApplyControls.Controls.Add(this.dtpStart, 2, 1);
            this.tlpApplyControls.Controls.Add(this.lblNgayKT, 3, 0);
            this.tlpApplyControls.Controls.Add(this.dtpEnd, 3, 1);
            this.tlpApplyControls.Controls.Add(this.lblSoLuong, 4, 0);
            this.tlpApplyControls.Controls.Add(this.txtSL, 4, 1);
            this.tlpApplyControls.Controls.Add(this.btnAddTarget, 5, 0);
            this.tlpApplyControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApplyControls.Location = new System.Drawing.Point(0, 0);
            this.tlpApplyControls.Name = "tlpApplyControls";
            this.tlpApplyControls.RowCount = 2;
            this.tlpApplyControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpApplyControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApplyControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tlpApplyControls.Size = new System.Drawing.Size(682, 114);
            this.tlpApplyControls.TabIndex = 0;
            // 
            // lblLoai
            // 
            this.lblLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoai.Location = new System.Drawing.Point(3, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(124, 35);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại:";
            this.lblLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTargetType
            // 
            this.cboTargetType.BackColor = System.Drawing.Color.Transparent;
            this.cboTargetType.BorderRadius = 8;
            this.cboTargetType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTargetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTargetType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTargetType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTargetType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTargetType.ItemHeight = 35;
            this.cboTargetType.Items.AddRange(new object[] {
            "Khóa Học",
            "Họa Cụ"});
            this.cboTargetType.Location = new System.Drawing.Point(3, 38);
            this.cboTargetType.Name = "cboTargetType";
            this.tlpApplyControls.SetRowSpan(this.cboTargetType, 2);
            this.cboTargetType.Size = new System.Drawing.Size(124, 41);
            this.cboTargetType.StartIndex = 0;
            this.cboTargetType.TabIndex = 1;
            // 
            // lblDoiTuong
            // 
            this.lblDoiTuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoiTuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoiTuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDoiTuong.Location = new System.Drawing.Point(133, 0);
            this.lblDoiTuong.Name = "lblDoiTuong";
            this.lblDoiTuong.Size = new System.Drawing.Size(138, 35);
            this.lblDoiTuong.TabIndex = 2;
            this.lblDoiTuong.Text = "Đối tượng áp dụng:";
            this.lblDoiTuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTargetItem
            // 
            this.cboTargetItem.BackColor = System.Drawing.Color.Transparent;
            this.cboTargetItem.BorderRadius = 8;
            this.cboTargetItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTargetItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTargetItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTargetItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTargetItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTargetItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTargetItem.ItemHeight = 30;
            this.cboTargetItem.Location = new System.Drawing.Point(133, 38);
            this.cboTargetItem.Name = "cboTargetItem";
            this.tlpApplyControls.SetRowSpan(this.cboTargetItem, 2);
            this.cboTargetItem.Size = new System.Drawing.Size(138, 36);
            this.cboTargetItem.TabIndex = 3;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayBD.Location = new System.Drawing.Point(277, 0);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(85, 35);
            this.lblNgayBD.TabIndex = 4;
            this.lblNgayBD.Text = "Từ ngày:";
            this.lblNgayBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStart
            // 
            this.dtpStart.BorderRadius = 8;
            this.dtpStart.Checked = true;
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(277, 38);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.tlpApplyControls.SetRowSpan(this.dtpStart, 2);
            this.dtpStart.Size = new System.Drawing.Size(85, 73);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.Value = new System.DateTime(2025, 11, 28, 0, 0, 0, 0);
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayKT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayKT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayKT.Location = new System.Drawing.Point(368, 0);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(85, 35);
            this.lblNgayKT.TabIndex = 6;
            this.lblNgayKT.Text = "Đến ngày:";
            this.lblNgayKT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEnd
            // 
            this.dtpEnd.BorderRadius = 8;
            this.dtpEnd.Checked = true;
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEnd.ForeColor = System.Drawing.Color.Black;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(368, 38);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.tlpApplyControls.SetRowSpan(this.dtpEnd, 2);
            this.dtpEnd.Size = new System.Drawing.Size(85, 73);
            this.dtpEnd.TabIndex = 7;
            this.dtpEnd.Value = new System.DateTime(2025, 11, 28, 0, 0, 0, 0);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoLuong.Location = new System.Drawing.Point(459, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 35);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSL
            // 
            this.txtSL.BorderRadius = 8;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.Location = new System.Drawing.Point(459, 38);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.PlaceholderText = "SL";
            this.tlpApplyControls.SetRowSpan(this.txtSL, 2);
            this.txtSL.SelectedText = "";
            this.txtSL.Size = new System.Drawing.Size(80, 72);
            this.txtSL.TabIndex = 9;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddTarget
            // 
            this.btnAddTarget.BorderRadius = 10;
            this.btnAddTarget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTarget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTarget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddTarget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddTarget.ForeColor = System.Drawing.Color.White;
            this.btnAddTarget.Location = new System.Drawing.Point(545, 3);
            this.btnAddTarget.Name = "btnAddTarget";
            this.tlpApplyControls.SetRowSpan(this.btnAddTarget, 2);
            this.btnAddTarget.Size = new System.Drawing.Size(134, 108);
            this.btnAddTarget.TabIndex = 10;
            this.btnAddTarget.Text = "+";
            // 
            // dgvAppliedList
            // 
            this.dgvAppliedList.AllowUserToAddRows = false;
            this.dgvAppliedList.AllowUserToDeleteRows = false;
            this.dgvAppliedList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvAppliedList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppliedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppliedList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppliedList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppliedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppliedList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppliedList.Location = new System.Drawing.Point(18, 128);
            this.dgvAppliedList.Name = "dgvAppliedList";
            this.dgvAppliedList.ReadOnly = true;
            this.dgvAppliedList.RowHeadersVisible = false;
            this.dgvAppliedList.RowHeadersWidth = 51;
            this.dgvAppliedList.RowTemplate.Height = 35;
            this.dgvAppliedList.Size = new System.Drawing.Size(682, 247);
            this.dgvAppliedList.TabIndex = 1;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppliedList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppliedList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppliedList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvAppliedList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppliedList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAppliedList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppliedList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAppliedList.ThemeStyle.ReadOnly = true;
            this.dgvAppliedList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppliedList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppliedList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvAppliedList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppliedList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvAppliedList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppliedList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlBottomActions
            // 
            this.pnlBottomActions.Controls.Add(this.btnSaveAll);
            this.pnlBottomActions.Controls.Add(this.btnQLKMApDung);
            this.pnlBottomActions.Controls.Add(this.btnDeleteApplied);
            this.pnlBottomActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomActions.Location = new System.Drawing.Point(18, 592);
            this.pnlBottomActions.Name = "pnlBottomActions";
            this.pnlBottomActions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.pnlBottomActions.Size = new System.Drawing.Size(718, 64);
            this.pnlBottomActions.TabIndex = 2;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BorderRadius = 10;
            this.btnSaveAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Location = new System.Drawing.Point(388, 10);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(150, 49);
            this.btnSaveAll.TabIndex = 2;
            this.btnSaveAll.Text = "💾 LƯU ";
            // 
            // btnQLKMApDung
            // 
            this.btnQLKMApDung.BorderRadius = 10;
            this.btnQLKMApDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKMApDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKMApDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLKMApDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLKMApDung.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQLKMApDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLKMApDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQLKMApDung.ForeColor = System.Drawing.Color.White;
            this.btnQLKMApDung.Location = new System.Drawing.Point(538, 10);
            this.btnQLKMApDung.Name = "btnQLKMApDung";
            this.btnQLKMApDung.Size = new System.Drawing.Size(180, 49);
            this.btnQLKMApDung.TabIndex = 1;
            this.btnQLKMApDung.Text = "📋 ÁP DỤNG";
            this.btnQLKMApDung.Click += new System.EventHandler(this.btnQLKMApDung_Click);
            // 
            // btnDeleteApplied
            // 
            this.btnDeleteApplied.BorderRadius = 10;
            this.btnDeleteApplied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteApplied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteApplied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteApplied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteApplied.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteApplied.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteApplied.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteApplied.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApplied.Location = new System.Drawing.Point(0, 10);
            this.btnDeleteApplied.Name = "btnDeleteApplied";
            this.btnDeleteApplied.Size = new System.Drawing.Size(160, 49);
            this.btnDeleteApplied.TabIndex = 0;
            this.btnDeleteApplied.Text = "✖ XÓA DÒNG";
            this.btnDeleteApplied.Click += new System.EventHandler(this.btnDeleteApplied_Click);
            // 
            // ucQLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQLKhuyenMai";
            this.Size = new System.Drawing.Size(1200, 700);
            this.tlpMain.ResumeLayout(false);
            this.pnlLeftContainer.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.grpQuickAdd.ResumeLayout(false);
            this.tlpQuickAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.pnlRightContainer.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            this.pnlInfoButtons.ResumeLayout(false);
            this.grpApply.ResumeLayout(false);
            this.tlpApply.ResumeLayout(false);
            this.pnlApplyInputs.ResumeLayout(false);
            this.tlpApplyControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedList)).EndInit();
            this.pnlBottomActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlLeftContainer;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlLeftHeader;
        private System.Windows.Forms.Label lblTitleList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GroupBox grpQuickAdd;
        private System.Windows.Forms.TableLayoutPanel tlpQuickAdd;
        private System.Windows.Forms.Label lblQuickName;
        private Guna.UI2.WinForms.Guna2TextBox txtQuickName;
        private System.Windows.Forms.Label lblQuickPercent;
        private Guna.UI2.WinForms.Guna2Button btnQuickAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhuyenMai;
        private Guna.UI2.WinForms.Guna2Panel pnlRightContainer;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblTenKM;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKM;
        private System.Windows.Forms.Label lblPhanTram;
        private Guna.UI2.WinForms.Guna2TextBox lblInfoPercent;
        private Guna.UI2.WinForms.Guna2Panel pnlInfoButtons;
        private Guna.UI2.WinForms.Guna2Button btnLuuChinhSua;
        private Guna.UI2.WinForms.Guna2Button btnHuyChinhSua;
        private Guna.UI2.WinForms.Guna2GroupBox grpApply;
        private System.Windows.Forms.TableLayoutPanel tlpApply;
        private Guna.UI2.WinForms.Guna2Panel pnlApplyInputs;
        private System.Windows.Forms.TableLayoutPanel tlpApplyControls;
        private System.Windows.Forms.Label lblLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cboTargetType;
        private System.Windows.Forms.Label lblDoiTuong;
        private Guna.UI2.WinForms.Guna2ComboBox cboTargetItem;
        private System.Windows.Forms.Label lblNgayBD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblNgayKT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private Guna.UI2.WinForms.Guna2Button btnAddTarget;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppliedList;
        private Guna.UI2.WinForms.Guna2Panel pnlBottomActions;
        private Guna.UI2.WinForms.Guna2Button btnDeleteApplied;
        private Guna.UI2.WinForms.Guna2Button btnQLKMApDung;
        private Guna.UI2.WinForms.Guna2Button btnSaveAll;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2TextBox numQuickPercent;
    }
}