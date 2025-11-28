namespace winform
{
    partial class frmQLCacApDungKM
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabKhoaHoc = new System.Windows.Forms.TabPage();
            this.dgvKhoaHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabHoaCu = new System.Windows.Forms.TabPage();
            this.dgvHoaCu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpEdit = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpEdit = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenItem = new System.Windows.Forms.Label();
            this.txtTenItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenKM = new System.Windows.Forms.Label();
            this.txtTenKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.tabHoaCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaCu)).BeginInit();
            this.grpEdit.SuspendLayout();
            this.tlpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tabControl, 0, 0);
            this.tlpMain.Controls.Add(this.grpEdit, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.Size = new System.Drawing.Size(1600, 862);
            this.tlpMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhoaHoc);
            this.tabControl.Controls.Add(this.tabHoaCu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(200, 45);
            this.tabControl.Location = new System.Drawing.Point(17, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1566, 536);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(200, 45);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabKhoaHoc
            // 
            this.tabKhoaHoc.BackColor = System.Drawing.Color.White;
            this.tabKhoaHoc.Controls.Add(this.dgvKhoaHoc);
            this.tabKhoaHoc.Location = new System.Drawing.Point(4, 49);
            this.tabKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabKhoaHoc.Name = "tabKhoaHoc";
            this.tabKhoaHoc.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tabKhoaHoc.Size = new System.Drawing.Size(1558, 483);
            this.tabKhoaHoc.TabIndex = 0;
            this.tabKhoaHoc.Text = "Khóa Học Đang Khuyến Mãi";
            // 
            // dgvKhoaHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoaHoc.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoaHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoaHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.Location = new System.Drawing.Point(13, 12);
            this.dgvKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.ReadOnly = true;
            this.dgvKhoaHoc.RowHeadersVisible = false;
            this.dgvKhoaHoc.RowHeadersWidth = 51;
            this.dgvKhoaHoc.RowTemplate.Height = 35;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(1532, 459);
            this.dgvKhoaHoc.TabIndex = 0;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvKhoaHoc.ThemeStyle.ReadOnly = true;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.Height = 35;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabHoaCu
            // 
            this.tabHoaCu.BackColor = System.Drawing.Color.White;
            this.tabHoaCu.Controls.Add(this.dgvHoaCu);
            this.tabHoaCu.Location = new System.Drawing.Point(4, 49);
            this.tabHoaCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHoaCu.Name = "tabHoaCu";
            this.tabHoaCu.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tabHoaCu.Size = new System.Drawing.Size(1558, 483);
            this.tabHoaCu.TabIndex = 1;
            this.tabHoaCu.Text = "Họa Cụ Đang Khuyến Mãi";
            // 
            // dgvHoaCu
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaCu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaCu.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaCu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaCu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaCu.Location = new System.Drawing.Point(13, 12);
            this.dgvHoaCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHoaCu.Name = "dgvHoaCu";
            this.dgvHoaCu.ReadOnly = true;
            this.dgvHoaCu.RowHeadersVisible = false;
            this.dgvHoaCu.RowHeadersWidth = 51;
            this.dgvHoaCu.RowTemplate.Height = 35;
            this.dgvHoaCu.Size = new System.Drawing.Size(1532, 459);
            this.dgvHoaCu.TabIndex = 0;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaCu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaCu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvHoaCu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaCu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvHoaCu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaCu.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHoaCu.ThemeStyle.ReadOnly = true;
            this.dgvHoaCu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaCu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvHoaCu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaCu.ThemeStyle.RowsStyle.Height = 35;
            this.dgvHoaCu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvHoaCu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grpEdit
            // 
            this.grpEdit.BorderRadius = 5;
            this.grpEdit.Controls.Add(this.tlpEdit);
            this.grpEdit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.grpEdit.ForeColor = System.Drawing.Color.White;
            this.grpEdit.Location = new System.Drawing.Point(17, 560);
            this.grpEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.grpEdit.Size = new System.Drawing.Size(1566, 286);
            this.grpEdit.TabIndex = 1;
            this.grpEdit.Text = "Thông Tin Chỉnh Sửa";
            // 
            // tlpEdit
            // 
            this.tlpEdit.ColumnCount = 4;
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEdit.Controls.Add(this.lblTenItem, 0, 0);
            this.tlpEdit.Controls.Add(this.txtTenItem, 0, 1);
            this.tlpEdit.Controls.Add(this.lblTenKM, 1, 0);
            this.tlpEdit.Controls.Add(this.txtTenKM, 1, 1);
            this.tlpEdit.Controls.Add(this.lblNgayKT, 2, 0);
            this.tlpEdit.Controls.Add(this.dtpEndDate, 2, 1);
            this.tlpEdit.Controls.Add(this.lblSoLuong, 3, 0);
            this.tlpEdit.Controls.Add(this.numSoLuong, 3, 1);
            this.tlpEdit.Controls.Add(this.pnlButtons, 0, 2);
            this.tlpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEdit.Location = new System.Drawing.Point(13, 52);
            this.tlpEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpEdit.Name = "tlpEdit";
            this.tlpEdit.RowCount = 3;
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpEdit.Size = new System.Drawing.Size(1540, 222);
            this.tlpEdit.TabIndex = 0;
            // 
            // lblTenItem
            // 
            this.lblTenItem.AutoSize = true;
            this.lblTenItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenItem.Location = new System.Drawing.Point(4, 0);
            this.lblTenItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenItem.Name = "lblTenItem";
            this.lblTenItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTenItem.Size = new System.Drawing.Size(377, 37);
            this.lblTenItem.TabIndex = 0;
            this.lblTenItem.Text = "Tên Đối Tượng";
            // 
            // txtTenItem
            // 
            this.txtTenItem.BorderRadius = 5;
            this.txtTenItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenItem.DefaultText = "";
            this.txtTenItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenItem.Location = new System.Drawing.Point(4, 41);
            this.txtTenItem.Margin = new System.Windows.Forms.Padding(4, 4, 11, 4);
            this.txtTenItem.Name = "txtTenItem";
            this.txtTenItem.PlaceholderText = "Tên đối tượng áp dụng";
            this.txtTenItem.ReadOnly = true;
            this.txtTenItem.SelectedText = "";
            this.txtTenItem.Size = new System.Drawing.Size(370, 103);
            this.txtTenItem.TabIndex = 1;
            // 
            // lblTenKM
            // 
            this.lblTenKM.AutoSize = true;
            this.lblTenKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenKM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenKM.Location = new System.Drawing.Point(389, 0);
            this.lblTenKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKM.Name = "lblTenKM";
            this.lblTenKM.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTenKM.Size = new System.Drawing.Size(377, 37);
            this.lblTenKM.TabIndex = 2;
            this.lblTenKM.Text = "Chương Trình Khuyến Mãi";
            // 
            // txtTenKM
            // 
            this.txtTenKM.BorderRadius = 5;
            this.txtTenKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKM.DefaultText = "";
            this.txtTenKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenKM.Location = new System.Drawing.Point(389, 41);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(4, 4, 11, 4);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.PlaceholderText = "Tên khuyến mãi";
            this.txtTenKM.ReadOnly = true;
            this.txtTenKM.SelectedText = "";
            this.txtTenKM.Size = new System.Drawing.Size(370, 103);
            this.txtTenKM.TabIndex = 3;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayKT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayKT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayKT.Location = new System.Drawing.Point(774, 0);
            this.lblNgayKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNgayKT.Size = new System.Drawing.Size(377, 37);
            this.lblNgayKT.TabIndex = 4;
            this.lblNgayKT.Text = "Ngày Kết Thúc";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 5;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(774, 41);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 11, 4);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(370, 103);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.Value = new System.DateTime(2025, 11, 28, 0, 0, 0, 0);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoLuong.Location = new System.Drawing.Point(1159, 0);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblSoLuong.Size = new System.Drawing.Size(377, 37);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.BorderRadius = 5;
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numSoLuong.Location = new System.Drawing.Point(1159, 41);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 11, 4);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(370, 103);
            this.numSoLuong.TabIndex = 7;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.tlpEdit.SetColumnSpan(this.pnlButtons, 4);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(4, 152);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlButtons.Size = new System.Drawing.Size(1532, 66);
            this.pnlButtons.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(467, 6);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(267, 55);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "💾 Lưu Cập Nhật";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(800, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 55);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "🗑️ Hủy";
            // 
            // frmQLCacApDungKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1600, 862);
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1327, 728);
            this.Name = "frmQLCacApDungKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Áp Dụng Khuyến Mãi";
            this.tlpMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabKhoaHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.tabHoaCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaCu)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.tlpEdit.ResumeLayout(false);
            this.tlpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage tabKhoaHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhoaHoc;
        private System.Windows.Forms.TabPage tabHoaCu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaCu;
        private Guna.UI2.WinForms.Guna2GroupBox grpEdit;
        private System.Windows.Forms.TableLayoutPanel tlpEdit;
        private System.Windows.Forms.Label lblTenItem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenItem;
        private System.Windows.Forms.Label lblTenKM;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKM;
        private System.Windows.Forms.Label lblNgayKT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private System.Windows.Forms.Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}
