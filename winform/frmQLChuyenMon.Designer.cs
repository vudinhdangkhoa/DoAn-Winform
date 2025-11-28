using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace winform
{
    partial class frmQLChuyenMon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.grpList = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvChuyenMon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.picHinhAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenChuyenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).BeginInit();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.tlpContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.BorderRadius = 20;
            this.pnlMain.ShadowDecoration.Depth = 15;
            this.pnlMain.ShadowDecoration.Enabled = true;
            this.pnlMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlMain.Size = new System.Drawing.Size(1200, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(1150, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblTitle.Size = new System.Drawing.Size(1200, 95);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ LOẠI KHÓA HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpContent.Controls.Add(this.grpList, 0, 0);
            this.tlpContent.Controls.Add(this.grpDetail, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(30, 100, 30, 40);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1200, 800);
            this.tlpContent.TabIndex = 1;
            // 
            // grpList
            // 
            this.grpList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpList.BorderRadius = 15;
            this.grpList.Controls.Add(this.dgvChuyenMon);
            this.grpList.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpList.ForeColor = System.Drawing.Color.White;
            this.grpList.Location = new System.Drawing.Point(33, 103);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.grpList.Size = new System.Drawing.Size(507, 654);
            this.grpList.TabIndex = 0;
            this.grpList.Text = "DANH SÁCH LOẠI KHÓA HỌC";
            this.grpList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvChuyenMon
            // 
            this.dgvChuyenMon.AllowUserToAddRows = false;
            this.dgvChuyenMon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dgvChuyenMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuyenMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChuyenMon.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChuyenMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.Location = new System.Drawing.Point(10, 90);
            this.dgvChuyenMon.Margin = new System.Windows.Forms.Padding(0);
            this.dgvChuyenMon.Name = "dgvChuyenMon";
            this.dgvChuyenMon.ReadOnly = true;
            this.dgvChuyenMon.RowHeadersVisible = false;
            this.dgvChuyenMon.RowHeadersWidth = 51;
            this.dgvChuyenMon.RowTemplate.Height = 50;
            this.dgvChuyenMon.Size = new System.Drawing.Size(487, 554);
            this.dgvChuyenMon.TabIndex = 0;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChuyenMon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvChuyenMon.ThemeStyle.ReadOnly = true;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvChuyenMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChuyenMon.ThemeStyle.RowsStyle.Height = 50;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            // 
            // grpDetail
            // 
            this.grpDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpDetail.BorderRadius = 15;
            this.grpDetail.Controls.Add(this.picHinhAnh);
            this.grpDetail.Controls.Add(this.btnChonAnh);
            this.grpDetail.Controls.Add(this.lblTen);
            this.grpDetail.Controls.Add(this.txtTenChuyenMon);
            this.grpDetail.Controls.Add(this.lblMoTa);
            this.grpDetail.Controls.Add(this.txtMoTa);
            this.grpDetail.Controls.Add(this.btnThem);
            this.grpDetail.Controls.Add(this.btnLuu);
            this.grpDetail.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.White;
            this.grpDetail.Location = new System.Drawing.Point(546, 103);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(0, 50, 0, 15);
            this.grpDetail.Size = new System.Drawing.Size(621, 654);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.Text = "THÔNG TIN CHI TIẾT";
            this.grpDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.picHinhAnh.BorderRadius = 12;
            this.picHinhAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.picHinhAnh.ImageRotate = 0F;
            this.picHinhAnh.Location = new System.Drawing.Point(160, 70);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(300, 200);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 0;
            this.picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Animated = true;
            this.btnChonAnh.BorderRadius = 10;
            this.btnChonAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChonAnh.Location = new System.Drawing.Point(230, 285);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(160, 40);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "📷 CHỌN ẢNH";
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTen.Location = new System.Drawing.Point(40, 350);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(180, 25);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên loại";
            // 
            // txtTenChuyenMon
            // 
            this.txtTenChuyenMon.Animated = true;
            this.txtTenChuyenMon.BorderRadius = 10;
            this.txtTenChuyenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChuyenMon.DefaultText = "";
            this.txtTenChuyenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtTenChuyenMon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenChuyenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtTenChuyenMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtTenChuyenMon.Location = new System.Drawing.Point(40, 378);
            this.txtTenChuyenMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenChuyenMon.Name = "txtTenChuyenMon";
            this.txtTenChuyenMon.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.txtTenChuyenMon.PlaceholderText = "Nhập tên loại...";
            this.txtTenChuyenMon.SelectedText = "";
            this.txtTenChuyenMon.Size = new System.Drawing.Size(540, 45);
            this.txtTenChuyenMon.TabIndex = 3;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblMoTa.Location = new System.Drawing.Point(40, 441);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(122, 25);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Animated = true;
            this.txtMoTa.BorderRadius = 10;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtMoTa.Location = new System.Drawing.Point(40, 469);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.txtMoTa.PlaceholderText = "Nhập mô tả...";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(540, 100);
            this.txtMoTa.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 12;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnThem.Location = new System.Drawing.Point(40, 587);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "🔄 LÀM MỚI";
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.BorderRadius = 12;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.btnLuu.Location = new System.Drawing.Point(220, 587);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(360, 50);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "💾 LƯU THÔNG TIN";
            // 
            // frmQLChuyenMon
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLChuyenMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chuyên Môn";
            this.pnlMain.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).EndInit();
            this.grpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna2ControlBox btnClose; // ĐÃ THÊM: Khai báo nút đóng form
        private Guna2Panel pnlMain;
        private Label lblTitle;
        private TableLayoutPanel tlpContent;
        private Guna2GroupBox grpList;
        private Guna2DataGridView dgvChuyenMon;
        private Guna2GroupBox grpDetail;
        private Guna2PictureBox picHinhAnh;
        private Guna2Button btnChonAnh;
        private Label lblTen;
        private Guna2TextBox txtTenChuyenMon;
        private Label lblMoTa;
        private Guna2TextBox txtMoTa;
        private Guna2Button btnThem;
        private Guna2Button btnLuu;
    }
}