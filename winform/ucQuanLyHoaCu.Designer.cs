namespace winform
{
    partial class ucQuanLyHoaCu
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
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLocLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddHocCu = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapKho = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHocCu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tlpMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tlpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocCu)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlTop, 0, 0);
            this.tlpMain.Controls.Add(this.dgvHocCu, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1100, 600);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tlpActions);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1094, 64);
            this.pnlTop.TabIndex = 0;
            // 
            // tlpActions
            // 
            this.tlpActions.ColumnCount = 8;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpActions.Controls.Add(this.txtSearch, 0, 0);
            this.tlpActions.Controls.Add(this.cboLocLoai, 1, 0);
            this.tlpActions.Controls.Add(this.btnRefresh, 2, 0);
            this.tlpActions.Controls.Add(this.btnAddLoai, 4, 0);
            this.tlpActions.Controls.Add(this.btnAddHocCu, 5, 0);
            this.tlpActions.Controls.Add(this.btnNhapKho, 6, 0);
            this.tlpActions.Controls.Add(this.btnBanHang, 7, 0);
            this.tlpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActions.Location = new System.Drawing.Point(0, 0);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.Size = new System.Drawing.Size(1094, 64);
            this.tlpActions.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(8, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm tên họa cụ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(294, 44);
            this.txtSearch.TabIndex = 0;
            // 
            // cboLocLoai
            // 
            this.cboLocLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLocLoai.BorderRadius = 5;
            this.cboLocLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLocLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocLoai.ItemHeight = 30;
            this.cboLocLoai.Location = new System.Drawing.Point(308, 10);
            this.cboLocLoai.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cboLocLoai.Name = "cboLocLoai";
            this.cboLocLoai.Size = new System.Drawing.Size(194, 36);
            this.cboLocLoai.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 5;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(508, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "⟳";
            // 
            // btnAddLoai
            // 
            this.btnAddLoai.BorderRadius = 5;
            this.btnAddLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddLoai.ForeColor = System.Drawing.Color.White;
            this.btnAddLoai.Location = new System.Drawing.Point(610, 10);
            this.btnAddLoai.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddLoai.Name = "btnAddLoai";
            this.btnAddLoai.Size = new System.Drawing.Size(96, 44);
            this.btnAddLoai.TabIndex = 3;
            this.btnAddLoai.Text = "+ Loại";
            // 
            // btnAddHocCu
            // 
            this.btnAddHocCu.BorderRadius = 5;
            this.btnAddHocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddHocCu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddHocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddHocCu.ForeColor = System.Drawing.Color.White;
            this.btnAddHocCu.Location = new System.Drawing.Point(712, 10);
            this.btnAddHocCu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddHocCu.Name = "btnAddHocCu";
            this.btnAddHocCu.Size = new System.Drawing.Size(114, 44);
            this.btnAddHocCu.TabIndex = 4;
            this.btnAddHocCu.Text = "+ Họa Cụ";
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BorderRadius = 5;
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNhapKho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(832, 10);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(114, 44);
            this.btnNhapKho.TabIndex = 5;
            this.btnNhapKho.Text = "Nhập Kho";
            // 
            // btnBanHang
            // 
            this.btnBanHang.BorderRadius = 5;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(952, 10);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(134, 44);
            this.btnBanHang.TabIndex = 6;
            this.btnBanHang.Text = "BÁN HÀNG";
            // 
            // dgvHocCu
            // 
            this.dgvHocCu.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocCu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocCu.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocCu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocCu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocCu.Location = new System.Drawing.Point(3, 73);
            this.dgvHocCu.Name = "dgvHocCu";
            this.dgvHocCu.ReadOnly = true;
            this.dgvHocCu.RowHeadersVisible = false;
            this.dgvHocCu.RowHeadersWidth = 51;
            this.dgvHocCu.Size = new System.Drawing.Size(1094, 524);
            this.dgvHocCu.TabIndex = 1;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHocCu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHocCu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocCu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHocCu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHocCu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocCu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocCu.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvHocCu.ThemeStyle.ReadOnly = true;
            this.dgvHocCu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocCu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHocCu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocCu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocCu.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHocCu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocCu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ucQuanLyHoaCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ucQuanLyHoaCu";
            this.Size = new System.Drawing.Size(1100, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tlpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocCu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tlpActions; // Khai báo thêm biến này

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocLoai;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;

        private Guna.UI2.WinForms.Guna2Button btnAddLoai;
        private Guna.UI2.WinForms.Guna2Button btnNhapKho;
        private Guna.UI2.WinForms.Guna2Button btnBanHang;
        private Guna.UI2.WinForms.Guna2Button btnAddHocCu;

        private Guna.UI2.WinForms.Guna2DataGridView dgvHocCu;
    }
}
