namespace winform
{
    partial class ucSaoLuuKhoiPhuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBackup = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.lblBackupDesc = new System.Windows.Forms.Label();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.picBackup = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlRestore = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.lblRestoreWarning = new System.Windows.Forms.Label();
            this.lblRestoreDesc = new System.Windows.Forms.Label();
            this.lblRestoreTitle = new System.Windows.Forms.Label();
            this.picRestore = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).BeginInit();
            this.pnlRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMain.Controls.Add(this.tlpContent);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(60, 30, 60, 40);
            this.pnlMain.Size = new System.Drawing.Size(940, 639);
            this.pnlMain.TabIndex = 0;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.pnlBackup, 0, 0);
            this.tlpContent.Controls.Add(this.pnlRestore, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(60, 130);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(820, 469);
            this.tlpContent.TabIndex = 2;
            // 
            // pnlBackup
            // 
            this.pnlBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBackup.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackup.BorderRadius = 20;
            this.pnlBackup.Controls.Add(this.btnBackup);
            this.pnlBackup.Controls.Add(this.lblBackupDesc);
            this.pnlBackup.Controls.Add(this.lblBackupTitle);
            this.pnlBackup.Controls.Add(this.picBackup);
            this.pnlBackup.FillColor = System.Drawing.Color.White;
            this.pnlBackup.Location = new System.Drawing.Point(35, 50);
            this.pnlBackup.Margin = new System.Windows.Forms.Padding(30, 20, 15, 20);
            this.pnlBackup.Name = "pnlBackup";
            this.pnlBackup.ShadowDecoration.BorderRadius = 20;
            this.pnlBackup.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBackup.ShadowDecoration.Depth = 20;
            this.pnlBackup.ShadowDecoration.Enabled = true;
            this.pnlBackup.Size = new System.Drawing.Size(355, 389);
            this.pnlBackup.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.BorderRadius = 10;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnBackup.Location = new System.Drawing.Point(52, 305);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(250, 50);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "SAO LƯU NGAY";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblBackupDesc
            // 
            this.lblBackupDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBackupDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblBackupDesc.Location = new System.Drawing.Point(20, 225);
            this.lblBackupDesc.Name = "lblBackupDesc";
            this.lblBackupDesc.Size = new System.Drawing.Size(315, 65);
            this.lblBackupDesc.TabIndex = 2;
            this.lblBackupDesc.Text = "Tạo bản sao lưu an toàn cho toàn bộ\ndữ liệu hệ thống với định dạng .bak";
            this.lblBackupDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBackupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblBackupTitle.Location = new System.Drawing.Point(20, 175);
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(315, 40);
            this.lblBackupTitle.TabIndex = 1;
            this.lblBackupTitle.Text = "SAO LƯU DỮ LIỆU";
            this.lblBackupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBackup
            // 
            this.picBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.picBackup.ImageRotate = 0F;
            this.picBackup.Location = new System.Drawing.Point(117, 40);
            this.picBackup.Name = "picBackup";
            this.picBackup.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picBackup.Size = new System.Drawing.Size(120, 120);
            this.picBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackup.TabIndex = 0;
            this.picBackup.TabStop = false;
            // 
            // pnlRestore
            // 
            this.pnlRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRestore.BackColor = System.Drawing.Color.Transparent;
            this.pnlRestore.BorderRadius = 20;
            this.pnlRestore.Controls.Add(this.btnRestore);
            this.pnlRestore.Controls.Add(this.lblRestoreWarning);
            this.pnlRestore.Controls.Add(this.lblRestoreDesc);
            this.pnlRestore.Controls.Add(this.lblRestoreTitle);
            this.pnlRestore.Controls.Add(this.picRestore);
            this.pnlRestore.FillColor = System.Drawing.Color.White;
            this.pnlRestore.Location = new System.Drawing.Point(430, 50);
            this.pnlRestore.Margin = new System.Windows.Forms.Padding(15, 20, 30, 20);
            this.pnlRestore.Name = "pnlRestore";
            this.pnlRestore.ShadowDecoration.BorderRadius = 20;
            this.pnlRestore.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlRestore.ShadowDecoration.Depth = 20;
            this.pnlRestore.ShadowDecoration.Enabled = true;
            this.pnlRestore.Size = new System.Drawing.Size(355, 389);
            this.pnlRestore.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.BorderRadius = 10;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRestore.Location = new System.Drawing.Point(52, 305);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(250, 50);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "KHÔI PHỤC";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestoreWarning
            // 
            this.lblRestoreWarning.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRestoreWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lblRestoreWarning.Location = new System.Drawing.Point(20, 255);
            this.lblRestoreWarning.Name = "lblRestoreWarning";
            this.lblRestoreWarning.Size = new System.Drawing.Size(315, 35);
            this.lblRestoreWarning.TabIndex = 3;
            this.lblRestoreWarning.Text = "⚠ Dữ liệu hiện tại sẽ bị ghi đè hoàn toàn";
            this.lblRestoreWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRestoreDesc
            // 
            this.lblRestoreDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRestoreDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblRestoreDesc.Location = new System.Drawing.Point(20, 225);
            this.lblRestoreDesc.Name = "lblRestoreDesc";
            this.lblRestoreDesc.Size = new System.Drawing.Size(315, 30);
            this.lblRestoreDesc.TabIndex = 2;
            this.lblRestoreDesc.Text = "Khôi phục hệ thống từ file .bak";
            this.lblRestoreDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRestoreTitle
            // 
            this.lblRestoreTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRestoreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRestoreTitle.Location = new System.Drawing.Point(17, 175);
            this.lblRestoreTitle.Name = "lblRestoreTitle";
            this.lblRestoreTitle.Size = new System.Drawing.Size(335, 40);
            this.lblRestoreTitle.TabIndex = 1;
            this.lblRestoreTitle.Text = "KHÔI PHỤC DỮ LIỆU";
            this.lblRestoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picRestore
            // 
            this.picRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.picRestore.ImageRotate = 0F;
            this.picRestore.Location = new System.Drawing.Point(117, 40);
            this.picRestore.Name = "picRestore";
            this.picRestore.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picRestore.Size = new System.Drawing.Size(120, 120);
            this.picRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRestore.TabIndex = 0;
            this.picRestore.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(60, 100);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(820, 30);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Quản lý dữ liệu hệ thống một cách an toàn và hiệu quả";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblTitle.Location = new System.Drawing.Point(60, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(820, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SAO LƯU & KHÔI PHỤC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSaoLuuKhoiPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucSaoLuuKhoiPhuc";
            this.Size = new System.Drawing.Size(940, 639);
            this.pnlMain.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pnlBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).EndInit();
            this.pnlRestore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        // Backup
        private Guna.UI2.WinForms.Guna2Panel pnlBackup;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picBackup;
        private System.Windows.Forms.Label lblBackupTitle;
        private System.Windows.Forms.Label lblBackupDesc;
        private Guna.UI2.WinForms.Guna2Button btnBackup;

        // Restore
        private Guna.UI2.WinForms.Guna2Panel pnlRestore;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picRestore;
        private System.Windows.Forms.Label lblRestoreTitle;
        private System.Windows.Forms.Label lblRestoreDesc;
        private System.Windows.Forms.Label lblRestoreWarning;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
    }
}