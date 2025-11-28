namespace winform
{
    partial class ucQuanLyLopHoc
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLocKhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLopHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.dgvLopHoc, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1229, 582);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.tlpHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1223, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 5;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.11863F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.82414F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tlpHeader.Controls.Add(this.txtSearch, 0, 0);
            this.tlpHeader.Controls.Add(this.cboLocKhoaHoc, 1, 0);
            this.tlpHeader.Controls.Add(this.btnRefresh, 2, 0);
            this.tlpHeader.Controls.Add(this.btnThemLop, 4, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1223, 74);
            this.tlpHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(13, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Tìm kiếm lớp học...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(242, 36);
            this.txtSearch.TabIndex = 0;
            // 
            // cboLocKhoaHoc
            // 
            this.cboLocKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLocKhoaHoc.BorderRadius = 5;
            this.cboLocKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLocKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocKhoaHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocKhoaHoc.ItemHeight = 30;
            this.cboLocKhoaHoc.Location = new System.Drawing.Point(261, 18);
            this.cboLocKhoaHoc.Name = "cboLocKhoaHoc";
            this.cboLocKhoaHoc.Size = new System.Drawing.Size(268, 36);
            this.cboLocKhoaHoc.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 5;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FillColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(535, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "⟳";
            // 
            // btnThemLop
            // 
            this.btnThemLop.BorderRadius = 5;
            this.btnThemLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThemLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(1033, 18);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(177, 38);
            this.btnThemLop.TabIndex = 3;
            this.btnThemLop.Text = "+ Thêm Lớp Học";
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLopHoc.ColumnHeadersHeight = 40;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLop,
            this.tenLop,
            this.khoaHoc,
            this.giaoVien,
            this.phong,
            this.siSo,
            this.ngayKG,
            this.btnDetail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.Location = new System.Drawing.Point(3, 83);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.RowTemplate.Height = 35;
            this.dgvLopHoc.Size = new System.Drawing.Size(1223, 496);
            this.dgvLopHoc.TabIndex = 1;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLopHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLopHoc.ThemeStyle.ReadOnly = true;
            this.dgvLopHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLopHoc.ThemeStyle.RowsStyle.Height = 35;
            this.dgvLopHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idLop
            // 
            this.idLop.DataPropertyName = "IdLopHoc";
            this.idLop.FillWeight = 40F;
            this.idLop.HeaderText = "ID";
            this.idLop.MinimumWidth = 6;
            this.idLop.Name = "idLop";
            this.idLop.ReadOnly = true;
            // 
            // tenLop
            // 
            this.tenLop.DataPropertyName = "TenLopHoc";
            this.tenLop.HeaderText = "Tên Lớp";
            this.tenLop.MinimumWidth = 6;
            this.tenLop.Name = "tenLop";
            this.tenLop.ReadOnly = true;
            // 
            // khoaHoc
            // 
            this.khoaHoc.DataPropertyName = "KhoaHoc";
            this.khoaHoc.HeaderText = "Khóa Học";
            this.khoaHoc.MinimumWidth = 6;
            this.khoaHoc.Name = "khoaHoc";
            this.khoaHoc.ReadOnly = true;
            // 
            // giaoVien
            // 
            this.giaoVien.DataPropertyName = "TenGiaoVien";
            this.giaoVien.HeaderText = "Giảng Viên";
            this.giaoVien.MinimumWidth = 6;
            this.giaoVien.Name = "giaoVien";
            this.giaoVien.ReadOnly = true;
            // 
            // phong
            // 
            this.phong.DataPropertyName = "Phong";
            this.phong.HeaderText = "Phòng";
            this.phong.MinimumWidth = 6;
            this.phong.Name = "phong";
            this.phong.ReadOnly = true;
            // 
            // siSo
            // 
            this.siSo.HeaderText = "Sĩ Số";
            this.siSo.MinimumWidth = 6;
            this.siSo.Name = "siSo";
            this.siSo.ReadOnly = true;
            // 
            // ngayKG
            // 
            this.ngayKG.DataPropertyName = "NgayKhaiGiang";
            this.ngayKG.HeaderText = "Khai Giảng";
            this.ngayKG.MinimumWidth = 6;
            this.ngayKG.Name = "ngayKG";
            this.ngayKG.ReadOnly = true;
            // 
            // btnDetail
            // 
            this.btnDetail.HeaderText = "";
            this.btnDetail.MinimumWidth = 6;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ReadOnly = true;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.UseColumnTextForButtonValue = true;
            // 
            // ucQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQuanLyLopHoc";
            this.Size = new System.Drawing.Size(1229, 582);
            this.tlpMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocKhoaHoc;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnThemLop;

        private Guna.UI2.WinForms.Guna2DataGridView dgvLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKG;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetail;
    }
}