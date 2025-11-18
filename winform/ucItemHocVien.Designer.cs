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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenHV = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXoaHV = new Guna.UI2.WinForms.Guna2Button();
            this.cboLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.txtLopDaChon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetLop = new Guna.UI2.WinForms.Guna2Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Black;
            this.tblMain.ColumnCount = 5;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.Controls.Add(this.txtTenHV, 0, 0);
            this.tblMain.Controls.Add(this.dtpNgaySinh, 2, 0);
            this.tblMain.Controls.Add(this.cboGioiTinh, 3, 0);
            this.tblMain.Controls.Add(this.btnXoaHV, 4, 0);
            this.tblMain.Controls.Add(this.cboLopHoc, 0, 1);
            this.tblMain.Controls.Add(this.btnThemLop, 1, 1);
            this.tblMain.Controls.Add(this.txtLopDaChon, 2, 1);
            this.tblMain.Controls.Add(this.btnResetLop, 4, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(5);
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(800, 120);
            this.tblMain.TabIndex = 0;
            // 
            // txtTenHV
            // 
            this.txtTenHV.BorderRadius = 5;
            this.tblMain.SetColumnSpan(this.txtTenHV, 2);
            this.txtTenHV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHV.DefaultText = "";
            this.txtTenHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenHV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHV.Location = new System.Drawing.Point(8, 8);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.PlaceholderText = "Họ tên học viên";
            this.txtTenHV.SelectedText = "";
            this.txtTenHV.Size = new System.Drawing.Size(282, 44);
            this.txtTenHV.TabIndex = 0;
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
            this.dtpNgaySinh.Location = new System.Drawing.Point(296, 8);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(272, 44);
            this.dtpNgaySinh.TabIndex = 1;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
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
            this.cboGioiTinh.Location = new System.Drawing.Point(574, 8);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(167, 36);
            this.cboGioiTinh.StartIndex = 0;
            this.cboGioiTinh.TabIndex = 2;
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.BorderRadius = 5;
            this.btnXoaHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaHV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnXoaHV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaHV.ForeColor = System.Drawing.Color.White;
            this.btnXoaHV.Location = new System.Drawing.Point(747, 8);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(45, 44);
            this.btnXoaHV.TabIndex = 3;
            this.btnXoaHV.Text = "X";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHoc.BorderRadius = 5;
            this.cboLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHoc.ItemHeight = 30;
            this.cboLopHoc.Location = new System.Drawing.Point(8, 58);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(237, 36);
            this.cboLopHoc.TabIndex = 4;
            // 
            // btnThemLop
            // 
            this.btnThemLop.BorderRadius = 5;
            this.btnThemLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(251, 58);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(39, 36);
            this.btnThemLop.TabIndex = 5;
            this.btnThemLop.Text = "+";
            // 
            // txtLopDaChon
            // 
            this.txtLopDaChon.BorderRadius = 5;
            this.tblMain.SetColumnSpan(this.txtLopDaChon, 2);
            this.txtLopDaChon.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLopDaChon.DefaultText = "";
            this.txtLopDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLopDaChon.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtLopDaChon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLopDaChon.ForeColor = System.Drawing.Color.Black;
            this.txtLopDaChon.Location = new System.Drawing.Point(296, 58);
            this.txtLopDaChon.Multiline = true;
            this.txtLopDaChon.Name = "txtLopDaChon";
            this.txtLopDaChon.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLopDaChon.PlaceholderText = "Danh sách lớp đã đăng ký...";
            this.txtLopDaChon.ReadOnly = true;
            this.txtLopDaChon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLopDaChon.SelectedText = "";
            this.txtLopDaChon.Size = new System.Drawing.Size(445, 54);
            this.txtLopDaChon.TabIndex = 6;
            // 
            // btnResetLop
            // 
            this.btnResetLop.BorderRadius = 5;
            this.btnResetLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetLop.FillColor = System.Drawing.Color.Gray;
            this.btnResetLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetLop.ForeColor = System.Drawing.Color.White;
            this.btnResetLop.Location = new System.Drawing.Point(747, 58);
            this.btnResetLop.Name = "btnResetLop";
            this.btnResetLop.Size = new System.Drawing.Size(45, 36);
            this.btnResetLop.TabIndex = 7;
            this.btnResetLop.Text = "↺";
            // 
            // ucItemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblMain);
            this.Name = "ucItemHocVien";
            this.Size = new System.Drawing.Size(800, 120);
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

}

#endregion

// Khai báo biến ở cuối file Designer
private System.Windows.Forms.TableLayoutPanel tblMain;
private Guna.UI2.WinForms.Guna2TextBox txtTenHV;
private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinh;
private Guna.UI2.WinForms.Guna2Button btnXoaHV;
private Guna.UI2.WinForms.Guna2ComboBox cboLopHoc;
private Guna.UI2.WinForms.Guna2Button btnThemLop;
private Guna.UI2.WinForms.Guna2TextBox txtLopDaChon;
private Guna.UI2.WinForms.Guna2Button btnResetLop;
    }
}
