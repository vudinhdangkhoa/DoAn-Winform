namespace winform
{
    partial class frmQLChuyenMon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.pnlMain.Controls.Add(this.tlpContent);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 615);
            this.pnlMain.TabIndex = 0;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContent.Controls.Add(this.grpList, 0, 0);
            this.tlpContent.Controls.Add(this.grpDetail, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 62);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContent.Size = new System.Drawing.Size(1067, 553);
            this.tlpContent.TabIndex = 0;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvChuyenMon);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpList.Location = new System.Drawing.Point(17, 16);
            this.grpList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(408, 521);
            this.grpList.TabIndex = 0;
            this.grpList.Text = "Danh sách";
            // 
            // dgvChuyenMon
            // 
            this.dgvChuyenMon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChuyenMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvChuyenMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChuyenMon.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChuyenMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.Location = new System.Drawing.Point(0, 40);
            this.dgvChuyenMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChuyenMon.Name = "dgvChuyenMon";
            this.dgvChuyenMon.ReadOnly = true;
            this.dgvChuyenMon.RowHeadersVisible = false;
            this.dgvChuyenMon.RowHeadersWidth = 51;
            this.dgvChuyenMon.Size = new System.Drawing.Size(408, 481);
            this.dgvChuyenMon.TabIndex = 0;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChuyenMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChuyenMon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChuyenMon.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvChuyenMon.ThemeStyle.ReadOnly = true;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvChuyenMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChuyenMon.ThemeStyle.RowsStyle.Height = 22;
            this.dgvChuyenMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChuyenMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.picHinhAnh);
            this.grpDetail.Controls.Add(this.btnChonAnh);
            this.grpDetail.Controls.Add(this.lblTen);
            this.grpDetail.Controls.Add(this.txtTenChuyenMon);
            this.grpDetail.Controls.Add(this.lblMoTa);
            this.grpDetail.Controls.Add(this.txtMoTa);
            this.grpDetail.Controls.Add(this.btnThem);
            this.grpDetail.Controls.Add(this.btnLuu);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpDetail.Location = new System.Drawing.Point(433, 16);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(617, 521);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.Text = "Thông tin chi tiết";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderRadius = 5;
            this.picHinhAnh.FillColor = System.Drawing.Color.WhiteSmoke;
            this.picHinhAnh.ImageRotate = 0F;
            this.picHinhAnh.Location = new System.Drawing.Point(187, 62);
            this.picHinhAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(240, 148);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 0;
            this.picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BorderRadius = 15;
            this.btnChonAnh.FillColor = System.Drawing.Color.Gray;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(240, 222);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(133, 37);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn Ảnh";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(27, 283);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(130, 20);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên Chuyên Môn:";
            // 
            // txtTenChuyenMon
            // 
            this.txtTenChuyenMon.BorderRadius = 5;
            this.txtTenChuyenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChuyenMon.DefaultText = "";
            this.txtTenChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenChuyenMon.Location = new System.Drawing.Point(27, 308);
            this.txtTenChuyenMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenChuyenMon.Name = "txtTenChuyenMon";
            this.txtTenChuyenMon.PlaceholderText = "";
            this.txtTenChuyenMon.SelectedText = "";
            this.txtTenChuyenMon.Size = new System.Drawing.Size(560, 44);
            this.txtTenChuyenMon.TabIndex = 3;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(27, 369);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 20);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô Tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderRadius = 5;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(27, 394);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(560, 74);
            this.txtMoTa.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 5;
            this.btnThem.FillColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(27, 492);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(173, 49);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Làm Mới / Thêm";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(213, 492);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(373, 49);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "LƯU";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1067, 62);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ CHUYÊN MÔN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQLChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLChuyenMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Chuyên Môn";
            this.pnlMain.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private Guna.UI2.WinForms.Guna2GroupBox grpList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChuyenMon;
        private Guna.UI2.WinForms.Guna2GroupBox grpDetail;

        private Guna.UI2.WinForms.Guna2PictureBox picHinhAnh;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private System.Windows.Forms.Label lblTen;
        private Guna.UI2.WinForms.Guna2TextBox txtTenChuyenMon;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
    }
}