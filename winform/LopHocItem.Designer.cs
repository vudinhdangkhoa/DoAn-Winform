using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;
namespace winform
{
    partial class LopHocItem
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSiSo = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitleGV = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.pnlStatusStrip = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 12;
            this.pnlMain.Controls.Add(this.lblSiSo);
            this.pnlMain.Controls.Add(this.lblTitleGV);
            this.pnlMain.Controls.Add(this.lblTenGV);
            this.pnlMain.Controls.Add(this.lblTenLop);
            this.pnlMain.Controls.Add(this.pnlStatusStrip);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlMain.ShadowDecoration.Depth = 10;
            this.pnlMain.ShadowDecoration.Enabled = true;
            this.pnlMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.pnlMain.Size = new System.Drawing.Size(360, 110);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblSiSo
            // 
            this.lblSiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSiSo.BorderRadius = 10;
            this.lblSiSo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblSiSo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblSiSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblSiSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblSiSo.Enabled = false;
            this.lblSiSo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblSiSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSiSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.lblSiSo.Location = new System.Drawing.Point(270, 15);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(80, 25);
            this.lblSiSo.TabIndex = 4;
            this.lblSiSo.Text = "30 HV";
            // 
            // lblTitleGV
            // 
            this.lblTitleGV.AutoSize = true;
            this.lblTitleGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitleGV.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleGV.Location = new System.Drawing.Point(28, 50);
            this.lblTitleGV.Name = "lblTitleGV";
            this.lblTitleGV.Size = new System.Drawing.Size(59, 15);
            this.lblTitleGV.TabIndex = 2;
            this.lblTitleGV.Text = "Giáo viên:";
            this.lblTitleGV.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenGV.Location = new System.Drawing.Point(28, 70);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(103, 19);
            this.lblTenGV.TabIndex = 3;
            this.lblTenGV.Text = "Nguyễn Văn A";
            this.lblTenGV.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblTenLop
            // 
            this.lblTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenLop.AutoEllipsis = true;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTenLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTenLop.Location = new System.Drawing.Point(25, 12);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(250, 30);
            this.lblTenLop.TabIndex = 1;
            this.lblTenLop.Text = "Lớp Vẽ Màu Nước K1";
            this.lblTenLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenLop.Click += new System.EventHandler(this.Item_Click);
            // 
            // pnlStatusStrip
            // 
            this.pnlStatusStrip.BorderRadius = 6;
            this.pnlStatusStrip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pnlStatusStrip.Location = new System.Drawing.Point(10, 15);
            this.pnlStatusStrip.Name = "pnlStatusStrip";
            this.pnlStatusStrip.Size = new System.Drawing.Size(6, 80);
            this.pnlStatusStrip.TabIndex = 0;
            // 
            // LopHocItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "LopHocItem";
            this.Size = new System.Drawing.Size(360, 110);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo biến
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlStatusStrip;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblTitleGV;
        private Guna.UI2.WinForms.Guna2Button lblSiSo;
    }
}
