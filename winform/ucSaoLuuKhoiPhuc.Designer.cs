namespace winform
{
    partial class ucSaoLuuKhoiPhuc
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();

            // Panel Backup
            this.pnlBackup = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.lblBackupDesc = new System.Windows.Forms.Label();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.picBackup = new Guna.UI2.WinForms.Guna2PictureBox();

            // Panel Restore
            this.pnlRestore = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRestoreTitle = new System.Windows.Forms.Label();
            this.lblRestoreDesc = new System.Windows.Forms.Label();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.picRestore = new Guna.UI2.WinForms.Guna2PictureBox();

            this.tlpMain.SuspendLayout();
            this.pnlBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).BeginInit();
            this.pnlRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F)); // Cột Backup
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F)); // Khoảng cách giữa
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F)); // Cột Restore

            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.SetColumnSpan(this.lblTitle, 3);

            this.tlpMain.Controls.Add(this.pnlBackup, 0, 1);
            this.tlpMain.Controls.Add(this.pnlRestore, 2, 1);

            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Padding = new System.Windows.Forms.Padding(50); // Padding tổng thể
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F)); // Header
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(940, 639);
            this.tlpMain.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.lblTitle.Location = new System.Drawing.Point(53, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(834, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SAO LƯU VÀ KHÔI PHỤC DỮ LIỆU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // === PANEL BACKUP ===
            // 
            this.pnlBackup.Controls.Add(this.btnBackup);
            this.pnlBackup.Controls.Add(this.lblBackupDesc);
            this.pnlBackup.Controls.Add(this.lblBackupTitle);
            this.pnlBackup.Controls.Add(this.picBackup);
            this.pnlBackup.Dock = System.Windows.Forms.DockStyle.Top; // Để nó co gọn lại đẹp
            this.pnlBackup.Height = 400;
            this.pnlBackup.BorderRadius = 20;
            this.pnlBackup.FillColor = System.Drawing.Color.White;
            this.pnlBackup.ShadowDecoration.Enabled = true;
            this.pnlBackup.ShadowDecoration.Depth = 5;

            // Icon Backup (Giả lập hình tròn)
            this.picBackup.FillColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.picBackup.Location = new System.Drawing.Point(120, 40); // Căn giữa tương đối
            this.picBackup.Size = new System.Drawing.Size(120, 120);
            this.picBackup.BorderRadius = 60;
            // Bạn có thể set Image ở đây nếu có icon

            // Title Backup
            this.lblBackupTitle.Text = "SAO LƯU DỮ LIỆU";
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBackupTitle.ForeColor = System.Drawing.Color.FromArgb(0, 57, 115);
            this.lblBackupTitle.AutoSize = false;
            this.lblBackupTitle.Location = new System.Drawing.Point(0, 180);
            this.lblBackupTitle.Size = new System.Drawing.Size(360, 30);
            this.lblBackupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Desc Backup
            this.lblBackupDesc.Text = "Tạo bản sao an toàn cho toàn bộ dữ liệu hệ thống.\nFile sao lưu có định dạng .bak";
            this.lblBackupDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBackupDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblBackupDesc.AutoSize = false;
            this.lblBackupDesc.Location = new System.Drawing.Point(20, 220);
            this.lblBackupDesc.Size = new System.Drawing.Size(320, 60);
            this.lblBackupDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // Button Backup
            this.btnBackup.Text = "SAO LƯU NGAY";
            this.btnBackup.BorderRadius = 10;
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(0, 192, 0); // Xanh lá
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(80, 300);
            this.btnBackup.Size = new System.Drawing.Size(200, 50);
            // Gán sự kiện Click
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);


            // 
            // === PANEL RESTORE ===
            // 
            this.pnlRestore.Controls.Add(this.btnRestore);
            this.pnlRestore.Controls.Add(this.lblRestoreDesc);
            this.pnlRestore.Controls.Add(this.lblRestoreTitle);
            this.pnlRestore.Controls.Add(this.picRestore);
            this.pnlRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRestore.Height = 400;
            this.pnlRestore.BorderRadius = 20;
            this.pnlRestore.FillColor = System.Drawing.Color.White;
            this.pnlRestore.ShadowDecoration.Enabled = true;
            this.pnlRestore.ShadowDecoration.Depth = 5;

            // Icon Restore
            this.picRestore.FillColor = System.Drawing.Color.FromArgb(255, 235, 230); // Màu cam nhạt
            this.picRestore.Location = new System.Drawing.Point(120, 40);
            this.picRestore.Size = new System.Drawing.Size(120, 120);
            this.picRestore.BorderRadius = 60;

            // Title Restore
            this.lblRestoreTitle.Text = "KHÔI PHỤC DỮ LIỆU";
            this.lblRestoreTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRestoreTitle.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblRestoreTitle.AutoSize = false;
            this.lblRestoreTitle.Location = new System.Drawing.Point(0, 180);
            this.lblRestoreTitle.Size = new System.Drawing.Size(360, 30);
            this.lblRestoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Desc Restore
            this.lblRestoreDesc.Text = "Khôi phục hệ thống từ file .bak đã có.\nCẢNH BÁO: Dữ liệu hiện tại sẽ bị ghi đè.";
            this.lblRestoreDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRestoreDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblRestoreDesc.AutoSize = false;
            this.lblRestoreDesc.Location = new System.Drawing.Point(20, 220);
            this.lblRestoreDesc.Size = new System.Drawing.Size(320, 60);
            this.lblRestoreDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // Button Restore
            this.btnRestore.Text = "KHÔI PHỤC";
            this.btnRestore.BorderRadius = 10;
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(231, 76, 60); // Đỏ
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(80, 300);
            this.btnRestore.Size = new System.Drawing.Size(200, 50);
            // Gán sự kiện Click
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);

            // 
            // ucSaoLuuKhoiPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ucSaoLuuKhoiPhuc";
            this.Size = new System.Drawing.Size(940, 639);

            this.tlpMain.ResumeLayout(false);
            this.pnlBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).EndInit();
            this.pnlRestore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblTitle;

        // Backup
        private Guna.UI2.WinForms.Guna2Panel pnlBackup;
        private Guna.UI2.WinForms.Guna2PictureBox picBackup;
        private System.Windows.Forms.Label lblBackupTitle;
        private System.Windows.Forms.Label lblBackupDesc;
        private Guna.UI2.WinForms.Guna2Button btnBackup;

        // Restore
        private Guna.UI2.WinForms.Guna2Panel pnlRestore;
        private Guna.UI2.WinForms.Guna2PictureBox picRestore;
        private System.Windows.Forms.Label lblRestoreTitle;
        private System.Windows.Forms.Label lblRestoreDesc;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
    }
}
