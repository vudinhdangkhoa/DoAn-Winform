namespace winform
{
    partial class frmBanHangHoaCu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpLeftContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLocLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpRightContent = new System.Windows.Forms.TableLayoutPanel();
            this.grpCustomer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvGioHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.lblTongTienVal = new System.Windows.Forms.Label();
            this.lblGiamGiaLabel = new System.Windows.Forms.Label();
            this.lblGiamGiaVal = new System.Windows.Forms.Label();
            this.lblThanhToanLabel = new System.Windows.Forms.Label();
            this.lblThanhToanVal = new System.Windows.Forms.Label();
            this.btnXoaGioHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.tlpLeftContent.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.tlpRightContent.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlRight, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1600, 862);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.tlpLeftContent);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(4, 4);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlLeft.Size = new System.Drawing.Size(952, 854);
            this.pnlLeft.TabIndex = 0;
            // 
            // tlpLeftContent
            // 
            this.tlpLeftContent.ColumnCount = 1;
            this.tlpLeftContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftContent.Controls.Add(this.pnlFilter, 0, 0);
            this.tlpLeftContent.Controls.Add(this.dgvSanPham, 0, 1);
            this.tlpLeftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftContent.Location = new System.Drawing.Point(7, 6);
            this.tlpLeftContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpLeftContent.Name = "tlpLeftContent";
            this.tlpLeftContent.RowCount = 2;
            this.tlpLeftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpLeftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftContent.Size = new System.Drawing.Size(938, 842);
            this.tlpLeftContent.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.cboLocLoai);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(4, 4);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(930, 66);
            this.pnlFilter.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(7, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm sản phẩm...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1130, 49);
            this.txtSearch.TabIndex = 0;
            // 
            // cboLocLoai
            // 
            this.cboLocLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLocLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLocLoai.BorderRadius = 5;
            this.cboLocLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocLoai.ItemHeight = 30;
            this.cboLocLoai.Location = new System.Drawing.Point(1150, 12);
            this.cboLocLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLocLoai.Name = "cboLocLoai";
            this.cboLocLoai.Size = new System.Drawing.Size(265, 36);
            this.cboLocLoai.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvSanPham.ColumnHeadersHeight = 35;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.Location = new System.Drawing.Point(4, 78);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(930, 760);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSanPham.ThemeStyle.ReadOnly = true;
            this.dgvSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.tlpRightContent);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(964, 4);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlRight.Size = new System.Drawing.Size(632, 854);
            this.pnlRight.TabIndex = 1;
            // 
            // tlpRightContent
            // 
            this.tlpRightContent.ColumnCount = 1;
            this.tlpRightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightContent.Controls.Add(this.grpCustomer, 0, 0);
            this.tlpRightContent.Controls.Add(this.dgvGioHang, 0, 1);
            this.tlpRightContent.Controls.Add(this.pnlTotal, 0, 2);
            this.tlpRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightContent.Location = new System.Drawing.Point(7, 6);
            this.tlpRightContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpRightContent.Name = "tlpRightContent";
            this.tlpRightContent.RowCount = 3;
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tlpRightContent.Size = new System.Drawing.Size(618, 842);
            this.tlpRightContent.TabIndex = 0;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtSDT);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpCustomer.Location = new System.Drawing.Point(4, 4);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(610, 115);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderRadius = 5;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(13, 62);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "SĐT Khách (Mặc định 0000000000)";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(333, 44);
            this.txtSDT.TabIndex = 0;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvGioHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvGioHang.ColumnHeadersHeight = 35;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGioHang.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGioHang.Location = new System.Drawing.Point(4, 127);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.Size = new System.Drawing.Size(610, 440);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGioHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGioHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGioHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGioHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGioHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGioHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGioHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvGioHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGioHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGioHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGioHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGioHang.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvGioHang.ThemeStyle.ReadOnly = false;
            this.dgvGioHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGioHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGioHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGioHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGioHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGioHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGioHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTongTienLabel);
            this.pnlTotal.Controls.Add(this.lblTongTienVal);
            this.pnlTotal.Controls.Add(this.lblGiamGiaLabel);
            this.pnlTotal.Controls.Add(this.lblGiamGiaVal);
            this.pnlTotal.Controls.Add(this.lblThanhToanLabel);
            this.pnlTotal.Controls.Add(this.lblThanhToanVal);
            this.pnlTotal.Controls.Add(this.btnXoaGioHang);
            this.pnlTotal.Controls.Add(this.btnThanhToan);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotal.Location = new System.Drawing.Point(4, 575);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(610, 263);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblTongTienLabel
            // 
            this.lblTongTienLabel.Location = new System.Drawing.Point(20, 18);
            this.lblTongTienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienLabel.Name = "lblTongTienLabel";
            this.lblTongTienLabel.Size = new System.Drawing.Size(133, 28);
            this.lblTongTienLabel.TabIndex = 0;
            this.lblTongTienLabel.Text = "Tổng tiền hàng:";
            // 
            // lblTongTienVal
            // 
            this.lblTongTienVal.Location = new System.Drawing.Point(333, 18);
            this.lblTongTienVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienVal.Name = "lblTongTienVal";
            this.lblTongTienVal.Size = new System.Drawing.Size(240, 25);
            this.lblTongTienVal.TabIndex = 1;
            this.lblTongTienVal.Text = "0";
            this.lblTongTienVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGiamGiaLabel
            // 
            this.lblGiamGiaLabel.Location = new System.Drawing.Point(20, 55);
            this.lblGiamGiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiamGiaLabel.Name = "lblGiamGiaLabel";
            this.lblGiamGiaLabel.Size = new System.Drawing.Size(133, 28);
            this.lblGiamGiaLabel.TabIndex = 2;
            this.lblGiamGiaLabel.Text = "Giảm giá:";
            // 
            // lblGiamGiaVal
            // 
            this.lblGiamGiaVal.Location = new System.Drawing.Point(333, 55);
            this.lblGiamGiaVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiamGiaVal.Name = "lblGiamGiaVal";
            this.lblGiamGiaVal.Size = new System.Drawing.Size(240, 25);
            this.lblGiamGiaVal.TabIndex = 3;
            this.lblGiamGiaVal.Text = "0";
            this.lblGiamGiaVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThanhToanLabel
            // 
            this.lblThanhToanLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThanhToanLabel.Location = new System.Drawing.Point(20, 98);
            this.lblThanhToanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhToanLabel.Name = "lblThanhToanLabel";
            this.lblThanhToanLabel.Size = new System.Drawing.Size(133, 28);
            this.lblThanhToanLabel.TabIndex = 4;
            this.lblThanhToanLabel.Text = "KHÁCH CẦN TRẢ:";
            // 
            // lblThanhToanVal
            // 
            this.lblThanhToanVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblThanhToanVal.ForeColor = System.Drawing.Color.Red;
            this.lblThanhToanVal.Location = new System.Drawing.Point(240, 92);
            this.lblThanhToanVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhToanVal.Name = "lblThanhToanVal";
            this.lblThanhToanVal.Size = new System.Drawing.Size(333, 37);
            this.lblThanhToanVal.TabIndex = 5;
            this.lblThanhToanVal.Text = "0 VNĐ";
            this.lblThanhToanVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.BorderRadius = 5;
            this.btnXoaGioHang.FillColor = System.Drawing.Color.Gray;
            this.btnXoaGioHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaGioHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaGioHang.Location = new System.Drawing.Point(20, 160);
            this.btnXoaGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(133, 62);
            this.btnXoaGioHang.TabIndex = 6;
            this.btnXoaGioHang.Text = "Làm Mới";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BorderRadius = 5;
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(217, 160);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(393, 62);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "THANH TOÁN ";
            // 
            // frmBanHangHoaCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 862);
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBanHangHoaCu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng (POS)";
            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.tlpLeftContent.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.tlpRightContent.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;

        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private System.Windows.Forms.TableLayoutPanel tlpLeftContent;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocLoai;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSanPham;

        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private System.Windows.Forms.TableLayoutPanel tlpRightContent;
        private Guna.UI2.WinForms.Guna2GroupBox grpCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGioHang;
        private Guna.UI2.WinForms.Guna2Panel pnlTotal;

        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.Label lblTongTienVal;
        private System.Windows.Forms.Label lblGiamGiaLabel;
        private System.Windows.Forms.Label lblGiamGiaVal;
        private System.Windows.Forms.Label lblThanhToanLabel;
        private System.Windows.Forms.Label lblThanhToanVal;

        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnXoaGioHang;
    }
}