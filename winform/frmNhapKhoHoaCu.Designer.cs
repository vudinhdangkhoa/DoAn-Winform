namespace winform
{
    partial class frmNhapKhoHoaCu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.grpInput = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblNguoiNhap = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNCC = new Guna.UI2.WinForms.Guna2Button();
            this.lblChonHang = new System.Windows.Forms.Label();
            this.cboHocCu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.numGiaNhap = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddToList = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvNhapKho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoaDong = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongTienValue = new System.Windows.Forms.Label();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlRight, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1467, 800);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grpInput);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(4, 4);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlLeft.Size = new System.Drawing.Size(505, 792);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.tlpInput);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpInput.Location = new System.Drawing.Point(7, 6);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(491, 780);
            this.grpInput.TabIndex = 0;
            this.grpInput.Text = "Thông Tin Nhập Kho";
            // 
            // tlpInput
            // 
            this.tlpInput.ColumnCount = 2;
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInput.Controls.Add(this.lblNguoiNhap, 0, 0);
            this.tlpInput.Controls.Add(this.lblNCC, 0, 1);
            this.tlpInput.Controls.Add(this.cboNhaCungCap, 0, 2);
            this.tlpInput.Controls.Add(this.btnAddNCC, 1, 2);
            this.tlpInput.Controls.Add(this.lblChonHang, 0, 4);
            this.tlpInput.Controls.Add(this.cboHocCu, 0, 5);
            this.tlpInput.Controls.Add(this.lblTonKho, 0, 6);
            this.tlpInput.Controls.Add(this.lblGiaNhap, 0, 7);
            this.tlpInput.Controls.Add(this.numGiaNhap, 0, 8);
            this.tlpInput.Controls.Add(this.lblSoLuong, 0, 9);
            this.tlpInput.Controls.Add(this.numSoLuong, 0, 10);
            this.tlpInput.Controls.Add(this.btnAddToList, 0, 11);
            this.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInput.Location = new System.Drawing.Point(0, 40);
            this.tlpInput.Margin = new System.Windows.Forms.Padding(4);
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpInput.Size = new System.Drawing.Size(491, 740);
            this.tlpInput.TabIndex = 0;
            // 
            // lblNguoiNhap
            // 
            this.tlpInput.SetColumnSpan(this.lblNguoiNhap, 2);
            this.lblNguoiNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNguoiNhap.ForeColor = System.Drawing.Color.Black;
            this.lblNguoiNhap.Location = new System.Drawing.Point(4, 0);
            this.lblNguoiNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNguoiNhap.Name = "lblNguoiNhap";
            this.lblNguoiNhap.Size = new System.Drawing.Size(483, 37);
            this.lblNguoiNhap.TabIndex = 0;
            this.lblNguoiNhap.Text = "Người nhập";
            // 
            // lblNCC
            // 
            this.lblNCC.Location = new System.Drawing.Point(4, 37);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(133, 28);
            this.lblNCC.TabIndex = 1;
            this.lblNCC.Text = "Nhà Cung Cấp:";
            this.lblNCC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cboNhaCungCap.BorderRadius = 5;
            this.cboNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhaCungCap.ItemHeight = 30;
            this.cboNhaCungCap.Location = new System.Drawing.Point(4, 78);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(384, 36);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // btnAddNCC
            // 
            this.btnAddNCC.BorderRadius = 5;
            this.btnAddNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNCC.ForeColor = System.Drawing.Color.White;
            this.btnAddNCC.Location = new System.Drawing.Point(396, 78);
            this.btnAddNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNCC.Name = "btnAddNCC";
            this.btnAddNCC.Size = new System.Drawing.Size(91, 47);
            this.btnAddNCC.TabIndex = 3;
            this.btnAddNCC.Text = "+";
            // 
            // lblChonHang
            // 
            this.lblChonHang.Location = new System.Drawing.Point(4, 154);
            this.lblChonHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonHang.Name = "lblChonHang";
            this.lblChonHang.Size = new System.Drawing.Size(133, 28);
            this.lblChonHang.TabIndex = 4;
            this.lblChonHang.Text = "Chọn Họa Cụ:";
            this.lblChonHang.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboHocCu
            // 
            this.cboHocCu.BackColor = System.Drawing.Color.Transparent;
            this.cboHocCu.BorderRadius = 5;
            this.tlpInput.SetColumnSpan(this.cboHocCu, 2);
            this.cboHocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocCu.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocCu.ItemHeight = 30;
            this.cboHocCu.Location = new System.Drawing.Point(4, 195);
            this.cboHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.cboHocCu.Name = "cboHocCu";
            this.cboHocCu.Size = new System.Drawing.Size(483, 36);
            this.cboHocCu.TabIndex = 5;
            // 
            // lblTonKho
            // 
            this.tlpInput.SetColumnSpan(this.lblTonKho, 2);
            this.lblTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTonKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTonKho.ForeColor = System.Drawing.Color.Gray;
            this.lblTonKho.Location = new System.Drawing.Point(4, 246);
            this.lblTonKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(483, 37);
            this.lblTonKho.TabIndex = 6;
            this.lblTonKho.Text = "Tồn kho hiện tại: ---";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.Location = new System.Drawing.Point(4, 283);
            this.lblGiaNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(133, 28);
            this.lblGiaNhap.TabIndex = 7;
            this.lblGiaNhap.Text = "Giá Nhập (VNĐ):";
            this.lblGiaNhap.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.numGiaNhap.BorderRadius = 5;
            this.tlpInput.SetColumnSpan(this.numGiaNhap, 2);
            this.numGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numGiaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numGiaNhap.Location = new System.Drawing.Point(4, 325);
            this.numGiaNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGiaNhap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(483, 45);
            this.numGiaNhap.TabIndex = 8;
            this.numGiaNhap.ThousandsSeparator = true;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(4, 375);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(133, 28);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "Số Lượng Nhập:";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.BorderRadius = 5;
            this.tlpInput.SetColumnSpan(this.numSoLuong, 2);
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuong.Location = new System.Drawing.Point(4, 417);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(483, 45);
            this.numSoLuong.TabIndex = 10;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToList
            // 
            this.btnAddToList.BorderRadius = 5;
            this.tlpInput.SetColumnSpan(this.btnAddToList, 2);
            this.btnAddToList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddToList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddToList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToList.ForeColor = System.Drawing.Color.White;
            this.btnAddToList.Location = new System.Drawing.Point(0, 685);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(491, 55);
            this.btnAddToList.TabIndex = 11;
            this.btnAddToList.Text = "THÊM VÀO PHIẾU";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvNhapKho);
            this.pnlRight.Controls.Add(this.pnlFooter);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(517, 4);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlRight.Size = new System.Drawing.Size(946, 792);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvNhapKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNhapKho.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapKho.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapKho.Location = new System.Drawing.Point(7, 6);
            this.dgvNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.ReadOnly = true;
            this.dgvNhapKho.RowHeadersVisible = false;
            this.dgvNhapKho.RowHeadersWidth = 51;
            this.dgvNhapKho.Size = new System.Drawing.Size(932, 682);
            this.dgvNhapKho.TabIndex = 0;
            this.dgvNhapKho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapKho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhapKho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhapKho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhapKho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhapKho.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapKho.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapKho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvNhapKho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhapKho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhapKho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhapKho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhapKho.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvNhapKho.ThemeStyle.ReadOnly = true;
            this.dgvNhapKho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapKho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapKho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhapKho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhapKho.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNhapKho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapKho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnXoaDong);
            this.pnlFooter.Controls.Add(this.btnHuy);
            this.pnlFooter.Controls.Add(this.btnLuuPhieu);
            this.pnlFooter.Controls.Add(this.lblTongTienValue);
            this.pnlFooter.Controls.Add(this.lblTongTienLabel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Location = new System.Drawing.Point(7, 688);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(932, 98);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnXoaDong
            // 
            this.btnXoaDong.BorderRadius = 5;
            this.btnXoaDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaDong.ForeColor = System.Drawing.Color.White;
            this.btnXoaDong.Location = new System.Drawing.Point(13, 25);
            this.btnXoaDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(160, 49);
            this.btnXoaDong.TabIndex = 0;
            this.btnXoaDong.Text = "Xóa Dòng Chọn";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(600, 25);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 49);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuPhieu.BorderRadius = 5;
            this.btnLuuPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieu.Location = new System.Drawing.Point(730, 25);
            this.btnLuuPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(213, 49);
            this.btnLuuPhieu.TabIndex = 2;
            this.btnLuuPhieu.Text = "LƯU PHIẾU NHẬP";
            // 
            // lblTongTienValue
            // 
            this.lblTongTienValue.AutoSize = true;
            this.lblTongTienValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTienValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongTienValue.Location = new System.Drawing.Point(200, 49);
            this.lblTongTienValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienValue.Name = "lblTongTienValue";
            this.lblTongTienValue.Size = new System.Drawing.Size(88, 32);
            this.lblTongTienValue.TabIndex = 3;
            this.lblTongTienValue.Text = "0 VNĐ";
            // 
            // lblTongTienLabel
            // 
            this.lblTongTienLabel.AutoSize = true;
            this.lblTongTienLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTienLabel.Location = new System.Drawing.Point(200, 25);
            this.lblTongTienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienLabel.Name = "lblTongTienLabel";
            this.lblTongTienLabel.Size = new System.Drawing.Size(115, 23);
            this.lblTongTienLabel.TabIndex = 4;
            this.lblTongTienLabel.Text = "TỔNG CỘNG:";
            // 
            // frmNhapKhoHoaCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 800);
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapKhoHoaCu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho Họa Cụ";
            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.tlpInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblNguoiNhap;
        private System.Windows.Forms.Label lblNCC;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhaCungCap;
        private Guna.UI2.WinForms.Guna2Button btnAddNCC;
        private System.Windows.Forms.Label lblChonHang;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocCu;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Label lblGiaNhap;
        private Guna.UI2.WinForms.Guna2NumericUpDown numGiaNhap;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnAddToList;

        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhapKho;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.Label lblTongTienValue;
        private Guna.UI2.WinForms.Guna2Button btnLuuPhieu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnXoaDong;
    }
}