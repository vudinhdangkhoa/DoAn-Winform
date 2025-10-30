﻿namespace winform
{
    partial class Dashboard
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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_LichHoc = new System.Windows.Forms.Button();
            this.btn_QLLopHoc = new System.Windows.Forms.Button();
            this.btn_QL_ThuChi = new System.Windows.Forms.Button();
            this.btn_QLKhoaHoc = new System.Windows.Forms.Button();
            this.btn_QLHocVien = new System.Windows.Forms.Button();
            this.btn_TongQuan = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidebarPanel.Controls.Add(this.btn_ThongKe);
            this.sidebarPanel.Controls.Add(this.btn_LichHoc);
            this.sidebarPanel.Controls.Add(this.btn_QLLopHoc);
            this.sidebarPanel.Controls.Add(this.btn_QL_ThuChi);
            this.sidebarPanel.Controls.Add(this.btn_QLKhoaHoc);
            this.sidebarPanel.Controls.Add(this.btn_QLHocVien);
            this.sidebarPanel.Controls.Add(this.btn_TongQuan);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 70);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(250, 780);
            this.sidebarPanel.TabIndex = 0;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 336);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_ThongKe.Size = new System.Drawing.Size(250, 50);
            this.btn_ThongKe.TabIndex = 0;
            this.btn_ThongKe.Text = "📈 Báo cáo thống kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            // 
            // btn_LichHoc
            // 
            this.btn_LichHoc.FlatAppearance.BorderSize = 0;
            this.btn_LichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LichHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichHoc.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_LichHoc.Location = new System.Drawing.Point(3, 280);
            this.btn_LichHoc.Name = "btn_LichHoc";
            this.btn_LichHoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_LichHoc.Size = new System.Drawing.Size(250, 50);
            this.btn_LichHoc.TabIndex = 0;
            this.btn_LichHoc.Text = "📅 Lịch học";
            this.btn_LichHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LichHoc.UseVisualStyleBackColor = true;
            // 
            // btn_QLLopHoc
            // 
            this.btn_QLLopHoc.FlatAppearance.BorderSize = 0;
            this.btn_QLLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLLopHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLopHoc.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_QLLopHoc.Location = new System.Drawing.Point(3, 224);
            this.btn_QLLopHoc.Name = "btn_QLLopHoc";
            this.btn_QLLopHoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLLopHoc.Size = new System.Drawing.Size(250, 50);
            this.btn_QLLopHoc.TabIndex = 0;
            this.btn_QLLopHoc.Text = "📚 Quản lý lớp học";
            this.btn_QLLopHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLLopHoc.UseVisualStyleBackColor = true;
            // 
            // btn_QL_ThuChi
            // 
            this.btn_QL_ThuChi.FlatAppearance.BorderSize = 0;
            this.btn_QL_ThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QL_ThuChi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QL_ThuChi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_QL_ThuChi.Location = new System.Drawing.Point(3, 168);
            this.btn_QL_ThuChi.Name = "btn_QL_ThuChi";
            this.btn_QL_ThuChi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QL_ThuChi.Size = new System.Drawing.Size(250, 50);
            this.btn_QL_ThuChi.TabIndex = 0;
            this.btn_QL_ThuChi.Text = "💰 Quản lý thu chi";
            this.btn_QL_ThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QL_ThuChi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QL_ThuChi.UseVisualStyleBackColor = true;
            // 
            // btn_QLKhoaHoc
            // 
            this.btn_QLKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btn_QLKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLKhoaHoc.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_QLKhoaHoc.Location = new System.Drawing.Point(3, 112);
            this.btn_QLKhoaHoc.Name = "btn_QLKhoaHoc";
            this.btn_QLKhoaHoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLKhoaHoc.Size = new System.Drawing.Size(250, 50);
            this.btn_QLKhoaHoc.TabIndex = 0;
            this.btn_QLKhoaHoc.Text = "📚 Quản lý khóa học";
            this.btn_QLKhoaHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLKhoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLKhoaHoc.UseVisualStyleBackColor = true;
            // 
            // btn_QLHocVien
            // 
            this.btn_QLHocVien.FlatAppearance.BorderSize = 0;
            this.btn_QLHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLHocVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHocVien.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_QLHocVien.Location = new System.Drawing.Point(0, 56);
            this.btn_QLHocVien.Name = "btn_QLHocVien";
            this.btn_QLHocVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLHocVien.Size = new System.Drawing.Size(250, 50);
            this.btn_QLHocVien.TabIndex = 0;
            this.btn_QLHocVien.Text = "👥 Quản lý học viên";
            this.btn_QLHocVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLHocVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLHocVien.UseVisualStyleBackColor = true;
            this.btn_QLHocVien.Click += new System.EventHandler(this.btn_QLHocVien_Click);
            // 
            // btn_TongQuan
            // 
            this.btn_TongQuan.FlatAppearance.BorderSize = 0;
            this.btn_TongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TongQuan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TongQuan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_TongQuan.Location = new System.Drawing.Point(0, 0);
            this.btn_TongQuan.Name = "btn_TongQuan";
            this.btn_TongQuan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TongQuan.Size = new System.Drawing.Size(250, 50);
            this.btn_TongQuan.TabIndex = 0;
            this.btn_TongQuan.Text = "📊 Tổng quan";
            this.btn_TongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TongQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TongQuan.UseVisualStyleBackColor = true;
            this.btn_TongQuan.Click += new System.EventHandler(this.btn_TongQuan_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.btnLogout);
            this.headerPanel.Controls.Add(this.lblUserRole);
            this.headerPanel.Controls.Add(this.lblWelcome);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblLogo);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1400, 70);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(211, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 43);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🚪 Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblUserRole.Location = new System.Drawing.Point(1, 35);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(200, 20);
            this.lblUserRole.TabIndex = 3;
            this.lblUserRole.Text = "👤 Quản trị viên";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblWelcome.Location = new System.Drawing.Point(1, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Xin chào, Admin";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(668, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TRUNG TÂM MỸ THUẬT SÁNG TẠO";
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(585, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(67, 51);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎨";
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Location = new System.Drawing.Point(250, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1150, 780);
            this.contentPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trung tâm Mỹ thuật Sáng tạo - Quản lý";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btn_TongQuan;
        private System.Windows.Forms.Button btn_QLKhoaHoc;
        private System.Windows.Forms.Button btn_QLHocVien;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_LichHoc;
        private System.Windows.Forms.Button btn_QLLopHoc;
        private System.Windows.Forms.Button btn_QL_ThuChi;
        private System.Windows.Forms.Panel contentPanel;
    }
}