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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ThemHocVien = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_KhoaHoc = new System.Windows.Forms.Label();
            this.lbl_LopHoc = new System.Windows.Forms.Label();
            this.comboBox_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.comboBox_LopHoc = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.dgv_DanhSachHV = new System.Windows.Forms.DataGridView();
            this.tenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_DanhSachHV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.61049F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.38951F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_ThemHocVien, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_ThemHocVien
            // 
            this.btn_ThemHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_ThemHocVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThemHocVien.FlatAppearance.BorderSize = 0;
            this.btn_ThemHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHocVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_ThemHocVien.ForeColor = System.Drawing.Color.White;
            this.btn_ThemHocVien.Location = new System.Drawing.Point(2, 2);
            this.btn_ThemHocVien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemHocVien.Name = "btn_ThemHocVien";
            this.btn_ThemHocVien.Size = new System.Drawing.Size(90, 81);
            this.btn_ThemHocVien.TabIndex = 1;
            this.btn_ThemHocVien.Text = "➕ Thêm";
            this.btn_ThemHocVien.UseVisualStyleBackColor = false;
            this.btn_ThemHocVien.Click += new System.EventHandler(this.btn_ThemHocVien_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.46154F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.53846F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(96, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(325, 81);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txt_TimKiem, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_TimKiem, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(251, 77);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_TimKiem.Location = new System.Drawing.Point(2, 21);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(247, 29);
            this.txt_TimKiem.TabIndex = 1;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_TimKiem.Location = new System.Drawing.Point(2, 0);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(247, 19);
            this.lbl_TimKiem.TabIndex = 0;
            this.lbl_TimKiem.Text = "Tìm kiếm học viên";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.btn_TimKiem, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_Reset, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(258, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(64, 75);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_TimKiem.Location = new System.Drawing.Point(2, 2);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(60, 33);
            this.btn_TimKiem.TabIndex = 0;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Reset.Location = new System.Drawing.Point(2, 39);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(60, 34);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Xóa lọc";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_KhoaHoc, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_LopHoc, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_KhoaHoc, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_LopHoc, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(425, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(201, 81);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lbl_KhoaHoc
            // 
            this.lbl_KhoaHoc.BackColor = System.Drawing.Color.Silver;
            this.lbl_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_KhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhoaHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_KhoaHoc.Location = new System.Drawing.Point(2, 0);
            this.lbl_KhoaHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_KhoaHoc.Name = "lbl_KhoaHoc";
            this.lbl_KhoaHoc.Size = new System.Drawing.Size(197, 20);
            this.lbl_KhoaHoc.TabIndex = 0;
            this.lbl_KhoaHoc.Text = "Tên khóa học";
            // 
            // lbl_LopHoc
            // 
            this.lbl_LopHoc.BackColor = System.Drawing.Color.Silver;
            this.lbl_LopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LopHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LopHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LopHoc.Location = new System.Drawing.Point(2, 40);
            this.lbl_LopHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LopHoc.Name = "lbl_LopHoc";
            this.lbl_LopHoc.Size = new System.Drawing.Size(197, 20);
            this.lbl_LopHoc.TabIndex = 1;
            this.lbl_LopHoc.Text = "Tên lớp học";
            // 
            // comboBox_KhoaHoc
            // 
            this.comboBox_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_KhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_KhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_KhoaHoc.FormattingEnabled = true;
            this.comboBox_KhoaHoc.Location = new System.Drawing.Point(2, 22);
            this.comboBox_KhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_KhoaHoc.Name = "comboBox_KhoaHoc";
            this.comboBox_KhoaHoc.Size = new System.Drawing.Size(197, 23);
            this.comboBox_KhoaHoc.TabIndex = 2;
            this.comboBox_KhoaHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_KhoaHoc_SelectedIndexChanged);
            // 
            // comboBox_LopHoc
            // 
            this.comboBox_LopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_LopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_LopHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_LopHoc.FormattingEnabled = true;
            this.comboBox_LopHoc.Location = new System.Drawing.Point(2, 62);
            this.comboBox_LopHoc.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_LopHoc.Name = "comboBox_LopHoc";
            this.comboBox_LopHoc.Size = new System.Drawing.Size(197, 23);
            this.comboBox_LopHoc.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Loc, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_XuatExcel, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(630, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(52, 80);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // btn_Loc
            // 
            this.btn_Loc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Loc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Loc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Loc.FlatAppearance.BorderSize = 0;
            this.btn_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Loc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Loc.Location = new System.Drawing.Point(2, 2);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(48, 36);
            this.btn_Loc.TabIndex = 0;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_XuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XuatExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XuatExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_XuatExcel.Location = new System.Drawing.Point(2, 42);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(48, 36);
            this.btn_XuatExcel.TabIndex = 1;
            this.btn_XuatExcel.Text = "Excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachHV
            // 
            this.dgv_DanhSachHV.AllowUserToAddRows = false;
            this.dgv_DanhSachHV.AllowUserToDeleteRows = false;
            this.dgv_DanhSachHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachHV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachHV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachHV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHV,
            this.ngaySinh,
            this.gioiTinh,
            this.tenPH});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachHV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSachHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachHV.EnableHeadersVisualStyles = false;
            this.dgv_DanhSachHV.Location = new System.Drawing.Point(10, 99);
            this.dgv_DanhSachHV.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DanhSachHV.Name = "dgv_DanhSachHV";
            this.dgv_DanhSachHV.ReadOnly = true;
            this.dgv_DanhSachHV.RowHeadersVisible = false;
            this.dgv_DanhSachHV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgv_DanhSachHV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSachHV.RowTemplate.Height = 40;
            this.dgv_DanhSachHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachHV.Size = new System.Drawing.Size(685, 346);
            this.dgv_DanhSachHV.TabIndex = 1;
            // 
            // tenHV
            // 
            this.tenHV.HeaderText = "Tên Học Viên";
            this.tenHV.MinimumWidth = 6;
            this.tenHV.Name = "tenHV";
            this.tenHV.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // tenPH
            // 
            this.tenPH.HeaderText = "Tên phụ huynh";
            this.tenPH.MinimumWidth = 6;
            this.tenPH.Name = "tenPH";
            this.tenPH.ReadOnly = true;
            // 
            // ucQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucQuanLyHocVien";
            this.Size = new System.Drawing.Size(705, 455);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_DanhSachHV;
        private System.Windows.Forms.Button btn_ThemHocVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_KhoaHoc;
        private System.Windows.Forms.Label lbl_LopHoc;
        private System.Windows.Forms.ComboBox comboBox_KhoaHoc;
        private System.Windows.Forms.ComboBox comboBox_LopHoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Reset;
    }
}
