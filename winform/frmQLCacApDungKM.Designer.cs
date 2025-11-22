namespace winform
{
    partial class frmQLCacApDungKM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabKhoaHoc = new System.Windows.Forms.TabPage();
            this.dgvKhoaHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabHoaCu = new System.Windows.Forms.TabPage();
            this.dgvHoaCu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpEdit = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpEdit = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitleEdit = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.tabHoaCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaCu)).BeginInit();
            this.grpEdit.SuspendLayout();
            this.tlpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
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
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 738);
            this.tlpMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabKhoaHoc);
            this.tabControl.Controls.Add(this.tabHoaCu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1192, 508);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabKhoaHoc
            // 
            this.tabKhoaHoc.Controls.Add(this.dgvKhoaHoc);
            this.tabKhoaHoc.Location = new System.Drawing.Point(184, 4);
            this.tabKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabKhoaHoc.Name = "tabKhoaHoc";
            this.tabKhoaHoc.Size = new System.Drawing.Size(1004, 500);
            this.tabKhoaHoc.TabIndex = 0;
            this.tabKhoaHoc.Text = "Khóa Học Đang KM";
            // 
            // dgvKhoaHoc
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvKhoaHoc.ColumnHeadersHeight = 29;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoaHoc.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoaHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.ReadOnly = true;
            this.dgvKhoaHoc.RowHeadersVisible = false;
            this.dgvKhoaHoc.RowHeadersWidth = 51;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(1004, 500);
            this.dgvKhoaHoc.TabIndex = 0;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvKhoaHoc.ThemeStyle.ReadOnly = true;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabHoaCu
            // 
            this.tabHoaCu.Controls.Add(this.dgvHoaCu);
            this.tabHoaCu.Location = new System.Drawing.Point(184, 4);
            this.tabHoaCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHoaCu.Name = "tabHoaCu";
            this.tabHoaCu.Size = new System.Drawing.Size(1004, 500);
            this.tabHoaCu.TabIndex = 1;
            this.tabHoaCu.Text = "Họa Cụ Đang KM";
            // 
            // dgvHoaCu
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaCu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvHoaCu.ColumnHeadersHeight = 29;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaCu.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvHoaCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaCu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaCu.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHoaCu.Name = "dgvHoaCu";
            this.dgvHoaCu.ReadOnly = true;
            this.dgvHoaCu.RowHeadersVisible = false;
            this.dgvHoaCu.RowHeadersWidth = 51;
            this.dgvHoaCu.Size = new System.Drawing.Size(1004, 500);
            this.dgvHoaCu.TabIndex = 0;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaCu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaCu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaCu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.dgvHoaCu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaCu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaCu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaCu.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvHoaCu.ThemeStyle.ReadOnly = true;
            this.dgvHoaCu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaCu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaCu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaCu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaCu.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHoaCu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaCu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.tlpEdit);
            this.grpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpEdit.Location = new System.Drawing.Point(4, 520);
            this.grpEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(1192, 214);
            this.grpEdit.TabIndex = 1;
            this.grpEdit.Text = "Cập Nhật Thông Tin Áp Dụng";
            // 
            // tlpEdit
            // 
            this.tlpEdit.ColumnCount = 4;
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEdit.Controls.Add(this.txtTenItem, 0, 0);
            this.tlpEdit.Controls.Add(this.txtTenKM, 0, 1);
            this.tlpEdit.Controls.Add(this.dtpEndDate, 1, 1);
            this.tlpEdit.Controls.Add(this.numSoLuong, 2, 1);
            this.tlpEdit.Controls.Add(this.btnUpdate, 3, 0);
            this.tlpEdit.Controls.Add(this.btnDelete, 3, 1);
            this.tlpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEdit.Location = new System.Drawing.Point(0, 40);
            this.tlpEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpEdit.Name = "tlpEdit";
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEdit.Size = new System.Drawing.Size(1192, 174);
            this.tlpEdit.TabIndex = 0;
            // 
            // txtTenItem
            // 
            this.txtTenItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenItem.DefaultText = "";
            this.txtTenItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenItem.Location = new System.Drawing.Point(4, 5);
            this.txtTenItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenItem.Name = "txtTenItem";
            this.txtTenItem.PlaceholderText = "Tên đối tượng";
            this.txtTenItem.ReadOnly = true;
            this.txtTenItem.SelectedText = "";
            this.txtTenItem.Size = new System.Drawing.Size(349, 77);
            this.txtTenItem.TabIndex = 0;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKM.DefaultText = "";
            this.txtTenKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKM.Location = new System.Drawing.Point(4, 92);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.PlaceholderText = "Chương trình khuyến mãi";
            this.txtTenKM.ReadOnly = true;
            this.txtTenKM.SelectedText = "";
            this.txtTenKM.Size = new System.Drawing.Size(349, 77);
            this.txtTenKM.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(361, 91);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(290, 79);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.Value = new System.DateTime(2025, 11, 22, 12, 31, 38, 507);
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuong.Location = new System.Drawing.Point(659, 92);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(170, 77);
            this.numSoLuong.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FillColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(837, 4);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(351, 79);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Lưu Cập Nhật";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(837, 91);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(351, 79);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Hủy";
            // 
            // lblTitleEdit
            // 
            this.lblTitleEdit.Location = new System.Drawing.Point(0, 0);
            this.lblTitleEdit.Name = "lblTitleEdit";
            this.lblTitleEdit.Size = new System.Drawing.Size(100, 23);
            this.lblTitleEdit.TabIndex = 0;
            // 
            // frmQLCacApDungKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtTenItem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKM;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label lblTitleEdit;
    }
}