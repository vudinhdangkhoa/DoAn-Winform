using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace winform
{
    partial class ucKhoaHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboChuyenMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLChuyenMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKhoaHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tlpMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlTop, 0, 0);
            this.tlpMain.Controls.Add(this.dgvKhoaHoc, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20, 15, 20, 10);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1350, 800);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderRadius = 26;
            this.pnlTop.Controls.Add(this.tlpHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(23, 18);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.Depth = 40;
            this.pnlTop.ShadowDecoration.Enabled = true;
            this.pnlTop.Size = new System.Drawing.Size(1304, 104);
            this.pnlTop.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 5;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpHeader.Controls.Add(this.txtSearch, 0, 0);
            this.tlpHeader.Controls.Add(this.cboChuyenMon, 1, 0);
            this.tlpHeader.Controls.Add(this.btnRefresh, 2, 0);
            this.tlpHeader.Controls.Add(this.btnQLChuyenMon, 3, 0);
            this.tlpHeader.Controls.Add(this.btnThem, 4, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpHeader.Size = new System.Drawing.Size(1304, 104);
            this.tlpHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 26;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(26, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm khóa học...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(386, 60);
            this.txtSearch.TabIndex = 0;
            // 
            // cboChuyenMon
            // 
            this.cboChuyenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChuyenMon.BackColor = System.Drawing.Color.Transparent;
            this.cboChuyenMon.BorderRadius = 26;
            this.cboChuyenMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenMon.FocusedColor = System.Drawing.Color.Empty;
            this.cboChuyenMon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboChuyenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChuyenMon.ItemHeight = 54;
            this.cboChuyenMon.Location = new System.Drawing.Point(426, 22);
            this.cboChuyenMon.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.cboChuyenMon.Name = "cboChuyenMon";
            this.cboChuyenMon.Size = new System.Drawing.Size(273, 60);
            this.cboChuyenMon.Sorted = true;
            this.cboChuyenMon.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderRadius = 26;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(713, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 60);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            // 
            // btnQLChuyenMon
            // 
            this.btnQLChuyenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLChuyenMon.BorderRadius = 26;
            this.btnQLChuyenMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnQLChuyenMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLChuyenMon.ForeColor = System.Drawing.Color.White;
            this.btnQLChuyenMon.Location = new System.Drawing.Point(900, 22);
            this.btnQLChuyenMon.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.btnQLChuyenMon.Name = "btnQLChuyenMon";
            this.btnQLChuyenMon.Size = new System.Drawing.Size(173, 60);
            this.btnQLChuyenMon.TabIndex = 3;
            this.btnQLChuyenMon.Text = "QL Loại khóa học";
            this.btnQLChuyenMon.Click += new System.EventHandler(this.btnQLChuyenMon_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 26;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1087, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 60);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "+ Thêm";
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoaHoc.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoaHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoaHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.Location = new System.Drawing.Point(23, 128);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.ReadOnly = true;
            this.dgvKhoaHoc.RowHeadersVisible = false;
            this.dgvKhoaHoc.RowHeadersWidth = 51;
            this.dgvKhoaHoc.RowTemplate.Height = 70;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(1304, 659);
            this.dgvKhoaHoc.TabIndex = 1;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhoaHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhoaHoc.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvKhoaHoc.ThemeStyle.ReadOnly = true;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.Height = 70;
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvKhoaHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ucKhoaHoc
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.tlpMain);
            this.Name = "ucKhoaHoc";
            this.Size = new System.Drawing.Size(1350, 800);
            this.tlpMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.ResumeLayout(false);

        }

        private TableLayoutPanel tlpMain;
        private Guna2Panel pnlTop;
        private TableLayoutPanel tlpHeader;
        private Guna2TextBox txtSearch;
        private Guna2ComboBox cboChuyenMon;
        private Guna2Button btnRefresh;
        private Guna2Button btnQLChuyenMon;
        private Guna2Button btnThem;
        private Guna2DataGridView dgvKhoaHoc;
    }
}