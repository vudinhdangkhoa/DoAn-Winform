namespace winform
{
    partial class ucQuanLyHocVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_KhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_LopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Loc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemHocVien = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDataGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_DanhSachHV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHV)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlTop, 0, 0);
            this.tlpMain.Controls.Add(this.pnlDataGrid, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(15);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1100, 600);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderRadius = 12;
            this.pnlTop.Controls.Add(this.tlpHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(15, 15);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.BorderRadius = 12;
            this.pnlTop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.pnlTop.ShadowDecoration.Depth = 10;
            this.pnlTop.ShadowDecoration.Enabled = true;
            this.pnlTop.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 6, 6);
            this.pnlTop.Size = new System.Drawing.Size(1070, 78);
            this.pnlTop.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 7;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpHeader.Controls.Add(this.txt_TimKiem, 0, 0);
            this.tlpHeader.Controls.Add(this.comboBox_KhoaHoc, 1, 0);
            this.tlpHeader.Controls.Add(this.comboBox_LopHoc, 2, 0);
            this.tlpHeader.Controls.Add(this.btn_Loc, 3, 0);
            this.tlpHeader.Controls.Add(this.btn_Reset, 4, 0);
            this.tlpHeader.Controls.Add(this.btn_XuatExcel, 5, 0);
            this.tlpHeader.Controls.Add(this.btn_ThemHocVien, 6, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1070, 78);
            this.tlpHeader.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Animated = true;
            this.txt_TimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.txt_TimKiem.BorderRadius = 8;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Location = new System.Drawing.Point(18, 23);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txt_TimKiem.PlaceholderText = "🔍 Tìm kiếm học viên...";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(232, 32);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // comboBox_KhoaHoc
            // 
            this.comboBox_KhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_KhoaHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.comboBox_KhoaHoc.BorderRadius = 8;
            this.comboBox_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_KhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_KhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_KhoaHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_KhoaHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_KhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_KhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.comboBox_KhoaHoc.ItemHeight = 23;
            this.comboBox_KhoaHoc.Location = new System.Drawing.Point(261, 23);
            this.comboBox_KhoaHoc.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.comboBox_KhoaHoc.Name = "comboBox_KhoaHoc";
            this.comboBox_KhoaHoc.Size = new System.Drawing.Size(163, 29);
            this.comboBox_KhoaHoc.TabIndex = 1;
            this.comboBox_KhoaHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_KhoaHoc_SelectedIndexChanged);
            // 
            // comboBox_LopHoc
            // 
            this.comboBox_LopHoc.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_LopHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.comboBox_LopHoc.BorderRadius = 8;
            this.comboBox_LopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_LopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_LopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_LopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_LopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_LopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.comboBox_LopHoc.ItemHeight = 23;
            this.comboBox_LopHoc.Location = new System.Drawing.Point(435, 23);
            this.comboBox_LopHoc.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.comboBox_LopHoc.Name = "comboBox_LopHoc";
            this.comboBox_LopHoc.Size = new System.Drawing.Size(163, 29);
            this.comboBox_LopHoc.TabIndex = 2;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Animated = true;
            this.btn_Loc.BorderRadius = 8;
            this.btn_Loc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Loc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Loc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Loc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Loc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Loc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_Loc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Loc.ForeColor = System.Drawing.Color.White;
            this.btn_Loc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_Loc.Location = new System.Drawing.Point(609, 23);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(89, 32);
            this.btn_Loc.TabIndex = 3;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Animated = true;
            this.btn_Reset.BorderRadius = 8;
            this.btn_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_Reset.Location = new System.Drawing.Point(709, 23);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(55, 32);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "⟳";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Animated = true;
            this.btn_XuatExcel.BorderRadius = 8;
            this.btn_XuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XuatExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XuatExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btn_XuatExcel.Location = new System.Drawing.Point(779, 23);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(128, 32);
            this.btn_XuatExcel.TabIndex = 5;
            this.btn_XuatExcel.Text = "Excel";
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // btn_ThemHocVien
            // 
            this.btn_ThemHocVien.Animated = true;
            this.btn_ThemHocVien.BorderRadius = 8;
            this.btn_ThemHocVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemHocVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemHocVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemHocVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThemHocVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btn_ThemHocVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ThemHocVien.ForeColor = System.Drawing.Color.White;
            this.btn_ThemHocVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btn_ThemHocVien.Location = new System.Drawing.Point(918, 23);
            this.btn_ThemHocVien.Name = "btn_ThemHocVien";
            this.btn_ThemHocVien.Size = new System.Drawing.Size(134, 32);
            this.btn_ThemHocVien.TabIndex = 6;
            this.btn_ThemHocVien.Text = "Thêm mới";
            this.btn_ThemHocVien.Click += new System.EventHandler(this.btn_ThemHocVien_Click);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlDataGrid.BorderRadius = 12;
            this.pnlDataGrid.Controls.Add(this.dgv_DanhSachHV);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.FillColor = System.Drawing.Color.White;
            this.pnlDataGrid.Location = new System.Drawing.Point(15, 105);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDataGrid.ShadowDecoration.BorderRadius = 12;
            this.pnlDataGrid.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.pnlDataGrid.ShadowDecoration.Depth = 10;
            this.pnlDataGrid.ShadowDecoration.Enabled = true;
            this.pnlDataGrid.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 6, 6);
            this.pnlDataGrid.Size = new System.Drawing.Size(1070, 480);
            this.pnlDataGrid.TabIndex = 1;
            // 
            // dgv_DanhSachHV
            // 
            this.dgv_DanhSachHV.AllowUserToAddRows = false;
            this.dgv_DanhSachHV.AllowUserToDeleteRows = false;
            this.dgv_DanhSachHV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.dgv_DanhSachHV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachHV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSachHV.ColumnHeadersHeight = 48;
            this.dgv_DanhSachHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DanhSachHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHV,
            this.tenHV,
            this.ngaySinh,
            this.gioiTinh,
            this.tenPH});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachHV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSachHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachHV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_DanhSachHV.Location = new System.Drawing.Point(15, 15);
            this.dgv_DanhSachHV.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_DanhSachHV.MultiSelect = false;
            this.dgv_DanhSachHV.Name = "dgv_DanhSachHV";
            this.dgv_DanhSachHV.ReadOnly = true;
            this.dgv_DanhSachHV.RowHeadersVisible = false;
            this.dgv_DanhSachHV.RowHeadersWidth = 51;
            this.dgv_DanhSachHV.RowTemplate.Height = 42;
            this.dgv_DanhSachHV.Size = new System.Drawing.Size(1040, 450);
            this.dgv_DanhSachHV.TabIndex = 0;
            this.dgv_DanhSachHV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgv_DanhSachHV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgv_DanhSachHV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgv_DanhSachHV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgv_DanhSachHV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.dgv_DanhSachHV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachHV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_DanhSachHV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dgv_DanhSachHV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DanhSachHV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgv_DanhSachHV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachHV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DanhSachHV.ThemeStyle.HeaderStyle.Height = 48;
            this.dgv_DanhSachHV.ThemeStyle.ReadOnly = true;
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.Height = 42;
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgv_DanhSachHV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            // 
            // idHV
            // 
            this.idHV.FillWeight = 20F;
            this.idHV.HeaderText = "ID";
            this.idHV.MinimumWidth = 60;
            this.idHV.Name = "idHV";
            this.idHV.ReadOnly = true;
            // 
            // tenHV
            // 
            this.tenHV.FillWeight = 25F;
            this.tenHV.HeaderText = "Tên Học Viên";
            this.tenHV.MinimumWidth = 6;
            this.tenHV.Name = "tenHV";
            this.tenHV.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.FillWeight = 20F;
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.FillWeight = 15F;
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // tenPH
            // 
            this.tenPH.FillWeight = 25F;
            this.tenPH.HeaderText = "Tên phụ huynh";
            this.tenPH.MinimumWidth = 6;
            this.tenPH.Name = "tenPH";
            this.tenPH.ReadOnly = true;
            // 
            // ucQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucQuanLyHocVien";
            this.Size = new System.Drawing.Size(1100, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel pnlDataGrid;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;

        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_KhoaHoc;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_LopHoc;
        private Guna.UI2.WinForms.Guna2Button btn_Loc;
        private Guna.UI2.WinForms.Guna2Button btn_Reset;
        private Guna.UI2.WinForms.Guna2Button btn_XuatExcel;
        private Guna.UI2.WinForms.Guna2Button btn_ThemHocVien;

        private Guna.UI2.WinForms.Guna2DataGridView dgv_DanhSachHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPH;
    }
}