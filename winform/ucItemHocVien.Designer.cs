namespace winform
{
    partial class ucItemHocVien
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
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenHV = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXoaHV = new Guna.UI2.WinForms.Guna2Button();
            this.cboLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.txtLopDaChon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetLop = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCard.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderColor = System.Drawing.Color.Silver;
            this.pnlCard.BorderRadius = 10;
            this.pnlCard.BorderThickness = 1;
            this.pnlCard.Controls.Add(this.tlpMain);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 5, 5);
            this.pnlCard.Size = new System.Drawing.Size(1533, 135);
            this.pnlCard.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.Controls.Add(this.txtTenHV, 0, 0);
            this.tlpMain.Controls.Add(this.dtpNgaySinh, 2, 0);
            this.tlpMain.Controls.Add(this.cboGioiTinh, 3, 0);
            this.tlpMain.Controls.Add(this.btnXoaHV, 4, 0);
            this.tlpMain.Controls.Add(this.cboLopHoc, 0, 1);
            this.tlpMain.Controls.Add(this.btnThemLop, 1, 1);
            this.tlpMain.Controls.Add(this.txtLopDaChon, 2, 1);
            this.tlpMain.Controls.Add(this.txtTongTien, 3, 1);
            this.tlpMain.Controls.Add(this.btnResetLop, 4, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(13, 12);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1507, 111);
            this.tlpMain.TabIndex = 0;
            // 
            // txtTenHV
            // 
            this.txtTenHV.BorderRadius = 5;
            this.tlpMain.SetColumnSpan(this.txtTenHV, 2);
            this.txtTenHV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHV.DefaultText = "";
            this.txtTenHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenHV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHV.Location = new System.Drawing.Point(7, 6);
            this.txtTenHV.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.PlaceholderText = "Họ tên học viên";
            this.txtTenHV.SelectedText = "";
            this.txtTenHV.Size = new System.Drawing.Size(494, 43);
            this.txtTenHV.TabIndex = 0;
            this.txtTenHV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTenHV_KeyPress);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.BorderThickness = 1;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(515, 6);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(485, 43);
            this.dtpNgaySinh.TabIndex = 1;
            this.dtpNgaySinh.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinh.BorderRadius = 5;
            this.cboGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinh.ItemHeight = 30;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(1014, 6);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(342, 36);
            this.cboGioiTinh.StartIndex = 0;
            this.cboGioiTinh.TabIndex = 2;
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.BorderRadius = 5;
            this.btnXoaHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaHV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaHV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaHV.ForeColor = System.Drawing.Color.White;
            this.btnXoaHV.Location = new System.Drawing.Point(1370, 6);
            this.btnXoaHV.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(130, 43);
            this.btnXoaHV.TabIndex = 3;
            this.btnXoaHV.Text = "Xóa";
            this.btnXoaHV.Click += new System.EventHandler(this.BtnXoaHV_Click);
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHoc.BorderRadius = 5;
            this.cboLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHoc.ItemHeight = 30;
            this.cboLopHoc.Location = new System.Drawing.Point(7, 61);
            this.cboLopHoc.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(414, 36);
            this.cboLopHoc.TabIndex = 4;
            // 
            // btnThemLop
            // 
            this.btnThemLop.BorderRadius = 5;
            this.btnThemLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThemLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(435, 61);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(66, 44);
            this.btnThemLop.TabIndex = 5;
            this.btnThemLop.Text = "+";
            this.btnThemLop.Click += new System.EventHandler(this.BtnThemLop_Click);
            // 
            // txtLopDaChon
            // 
            this.txtLopDaChon.BorderRadius = 5;
            this.txtLopDaChon.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLopDaChon.DefaultText = "";
            this.txtLopDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLopDaChon.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtLopDaChon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLopDaChon.ForeColor = System.Drawing.Color.Black;
            this.txtLopDaChon.Location = new System.Drawing.Point(515, 61);
            this.txtLopDaChon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtLopDaChon.Multiline = true;
            this.txtLopDaChon.Name = "txtLopDaChon";
            this.txtLopDaChon.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLopDaChon.PlaceholderText = "Các lớp đã chọn...";
            this.txtLopDaChon.ReadOnly = true;
            this.txtLopDaChon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLopDaChon.SelectedText = "";
            this.txtLopDaChon.Size = new System.Drawing.Size(485, 44);
            this.txtLopDaChon.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderRadius = 5;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(1014, 61);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PlaceholderText = "0 đ";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(342, 44);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResetLop
            // 
            this.btnResetLop.BorderRadius = 5;
            this.btnResetLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetLop.FillColor = System.Drawing.Color.Gray;
            this.btnResetLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetLop.ForeColor = System.Drawing.Color.White;
            this.btnResetLop.Location = new System.Drawing.Point(1370, 61);
            this.btnResetLop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnResetLop.Name = "btnResetLop";
            this.btnResetLop.Size = new System.Drawing.Size(130, 44);
            this.btnResetLop.TabIndex = 7;
            this.btnResetLop.Text = "↺";
            this.btnResetLop.Click += new System.EventHandler(this.BtnResetLop_Click);
            // 
            // ucItemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.Name = "ucItemHocVien";
            this.Size = new System.Drawing.Size(1533, 135);
            this.pnlCard.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHV;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinh;
        private Guna.UI2.WinForms.Guna2Button btnXoaHV;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHoc;
        private Guna.UI2.WinForms.Guna2Button btnThemLop;
        private Guna.UI2.WinForms.Guna2TextBox txtLopDaChon;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2Button btnResetLop;
    }
}