namespace winform
{
    partial class ucQuanLyLichHoc
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
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXemLich = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_refesh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLichHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grpDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDetailDate = new System.Windows.Forms.Label();
            this.txtDetailDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDetailPhong = new System.Windows.Forms.Label();
            this.txtDetailPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDetailGV = new System.Windows.Forms.Label();
            this.txtDetailGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBaoNghi = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.Controls.Add(this.pnlTop, 0, 0);
            this.tlpMain.Controls.Add(this.dgvLichHoc, 0, 1);
            this.tlpMain.Controls.Add(this.pnlRight, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1467, 800);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.tlpMain.SetColumnSpan(this.pnlTop, 2);
            this.pnlTop.Controls.Add(this.tlpHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(4, 4);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1459, 90);
            this.pnlTop.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 7;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tlpHeader.Controls.Add(this.lblKhoa, 0, 0);
            this.tlpHeader.Controls.Add(this.cboKhoaHoc, 1, 0);
            this.tlpHeader.Controls.Add(this.lblLop, 3, 0);
            this.tlpHeader.Controls.Add(this.cboLopHoc, 4, 0);
            this.tlpHeader.Controls.Add(this.pnlBtns, 6, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1459, 90);
            this.tlpHeader.TabIndex = 0;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(13, 37);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(69, 16);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khóa Học:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoaHoc.BorderRadius = 5;
            this.cboKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhoaHoc.ItemHeight = 30;
            this.cboKhoaHoc.Location = new System.Drawing.Point(93, 27);
            this.cboKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(270, 36);
            this.cboKhoaHoc.TabIndex = 1;
            // 
            // lblLop
            // 
            this.lblLop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(394, 37);
            this.lblLop.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(61, 16);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp Học:";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHoc.BorderRadius = 5;
            this.cboLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHoc.ItemHeight = 30;
            this.cboLopHoc.Location = new System.Drawing.Point(466, 27);
            this.cboLopHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(270, 36);
            this.cboLopHoc.TabIndex = 3;
            // 
            // btnXemLich
            // 
            this.btnXemLich.BorderRadius = 5;
            this.btnXemLich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXemLich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemLich.ForeColor = System.Drawing.Color.White;
            this.btnXemLich.Location = new System.Drawing.Point(107, 6);
            this.btnXemLich.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnXemLich.Name = "btnXemLich";
            this.btnXemLich.Size = new System.Drawing.Size(133, 49);
            this.btnXemLich.TabIndex = 4;
            this.btnXemLich.Text = "Xem Lịch";
            // 
            // pnlBtns
            // 
            this.pnlBtns.Controls.Add(this.btn_refesh);
            this.pnlBtns.Controls.Add(this.btnXemLich);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtns.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBtns.Location = new System.Drawing.Point(1114, 16);
            this.pnlBtns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(328, 58);
            this.pnlBtns.TabIndex = 4;
            // 
            // btn_refesh
            // 
            this.btn_refesh.BorderRadius = 5;
            this.btn_refesh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_refesh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refesh.ForeColor = System.Drawing.Color.White;
            this.btn_refesh.Location = new System.Drawing.Point(254, 6);
            this.btn_refesh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(67, 49);
            this.btn_refesh.TabIndex = 0;
            this.btn_refesh.Text = "⟳";
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichHoc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.Location = new System.Drawing.Point(4, 102);
            this.dgvLichHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.ReadOnly = true;
            this.dgvLichHoc.RowHeadersVisible = false;
            this.dgvLichHoc.RowHeadersWidth = 51;
            this.dgvLichHoc.Size = new System.Drawing.Size(945, 694);
            this.dgvLichHoc.TabIndex = 1;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLichHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLichHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLichHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLichHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichHoc.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvLichHoc.ThemeStyle.ReadOnly = true;
            this.dgvLichHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLichHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichHoc.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLichHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpDetail);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(957, 102);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlRight.Size = new System.Drawing.Size(506, 694);
            this.pnlRight.TabIndex = 2;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.lblDetailDate);
            this.grpDetail.Controls.Add(this.txtDetailDate);
            this.grpDetail.Controls.Add(this.lblDetailPhong);
            this.grpDetail.Controls.Add(this.txtDetailPhong);
            this.grpDetail.Controls.Add(this.lblDetailGV);
            this.grpDetail.Controls.Add(this.txtDetailGV);
            this.grpDetail.Controls.Add(this.lblStatus);
            this.grpDetail.Controls.Add(this.txtStatus);
            this.grpDetail.Controls.Add(this.btnBaoNghi);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpDetail.Location = new System.Drawing.Point(13, 12);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(480, 670);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.Text = "Chi Tiết Buổi Học";
            // 
            // lblDetailDate
            // 
            this.lblDetailDate.Location = new System.Drawing.Point(20, 62);
            this.lblDetailDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailDate.Name = "lblDetailDate";
            this.lblDetailDate.Size = new System.Drawing.Size(133, 28);
            this.lblDetailDate.TabIndex = 0;
            this.lblDetailDate.Text = "Ngày / Giờ:";
            // 
            // txtDetailDate
            // 
            this.txtDetailDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetailDate.DefaultText = "";
            this.txtDetailDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDetailDate.Location = new System.Drawing.Point(24, 95);
            this.txtDetailDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetailDate.Name = "txtDetailDate";
            this.txtDetailDate.PlaceholderText = "";
            this.txtDetailDate.ReadOnly = true;
            this.txtDetailDate.SelectedText = "";
            this.txtDetailDate.Size = new System.Drawing.Size(507, 44);
            this.txtDetailDate.TabIndex = 1;
            // 
            // lblDetailPhong
            // 
            this.lblDetailPhong.Location = new System.Drawing.Point(20, 148);
            this.lblDetailPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailPhong.Name = "lblDetailPhong";
            this.lblDetailPhong.Size = new System.Drawing.Size(133, 28);
            this.lblDetailPhong.TabIndex = 2;
            this.lblDetailPhong.Text = "Phòng Học:";
            // 
            // txtDetailPhong
            // 
            this.txtDetailPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetailPhong.DefaultText = "";
            this.txtDetailPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDetailPhong.Location = new System.Drawing.Point(20, 181);
            this.txtDetailPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetailPhong.Name = "txtDetailPhong";
            this.txtDetailPhong.PlaceholderText = "";
            this.txtDetailPhong.ReadOnly = true;
            this.txtDetailPhong.SelectedText = "";
            this.txtDetailPhong.Size = new System.Drawing.Size(507, 44);
            this.txtDetailPhong.TabIndex = 3;
            // 
            // lblDetailGV
            // 
            this.lblDetailGV.Location = new System.Drawing.Point(20, 234);
            this.lblDetailGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailGV.Name = "lblDetailGV";
            this.lblDetailGV.Size = new System.Drawing.Size(133, 28);
            this.lblDetailGV.TabIndex = 4;
            this.lblDetailGV.Text = "Giảng Viên:";
            // 
            // txtDetailGV
            // 
            this.txtDetailGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetailGV.DefaultText = "";
            this.txtDetailGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDetailGV.Location = new System.Drawing.Point(24, 271);
            this.txtDetailGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetailGV.Name = "txtDetailGV";
            this.txtDetailGV.PlaceholderText = "";
            this.txtDetailGV.ReadOnly = true;
            this.txtDetailGV.SelectedText = "";
            this.txtDetailGV.Size = new System.Drawing.Size(507, 44);
            this.txtDetailGV.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 320);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(133, 28);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Trạng Thái:";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.Location = new System.Drawing.Point(24, 353);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(507, 44);
            this.txtStatus.TabIndex = 7;
            // 
            // btnBaoNghi
            // 
            this.btnBaoNghi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoNghi.BorderRadius = 5;
            this.btnBaoNghi.Enabled = false;
            this.btnBaoNghi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBaoNghi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaoNghi.ForeColor = System.Drawing.Color.White;
            this.btnBaoNghi.Location = new System.Drawing.Point(4, 567);
            this.btnBaoNghi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoNghi.Name = "btnBaoNghi";
            this.btnBaoNghi.Size = new System.Drawing.Size(472, 55);
            this.btnBaoNghi.TabIndex = 8;
            this.btnBaoNghi.Text = "Báo Nghỉ / Dạy Bù";
            // 
            // ucQuanLyLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucQuanLyLichHoc";
            this.Size = new System.Drawing.Size(1467, 800);
            this.tlpMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tlpHeader; // Panel mới

        private System.Windows.Forms.Label lblKhoa;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHoc;
        private Guna.UI2.WinForms.Guna2Button btnXemLich;
        private Guna.UI2.WinForms.Guna2Button btn_refesh;

        private Guna.UI2.WinForms.Guna2DataGridView dgvLichHoc;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2GroupBox grpDetail;

        private System.Windows.Forms.Label lblDetailDate;
        private Guna.UI2.WinForms.Guna2TextBox txtDetailDate;
        private System.Windows.Forms.Label lblDetailPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtDetailPhong;
        private System.Windows.Forms.Label lblDetailGV;
        private Guna.UI2.WinForms.Guna2TextBox txtDetailGV;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2Button btnBaoNghi;
        private System.Windows.Forms.FlowLayoutPanel pnlBtns;
    }
}
