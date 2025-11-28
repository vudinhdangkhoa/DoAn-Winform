namespace winform
{
    partial class DanhNhap
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLoginContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.controlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelArt = new Guna.UI2.WinForms.Guna2Panel();
            this.lblArtTitle = new System.Windows.Forms.Label();
            this.picArtwork = new System.Windows.Forms.PictureBox();
            this.panelLoginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelLoginContainer
            // 
            this.panelLoginContainer.BackColor = System.Drawing.Color.White;
            this.panelLoginContainer.Controls.Add(this.controlBoxMinimize);
            this.panelLoginContainer.Controls.Add(this.controlBoxClose);
            this.panelLoginContainer.Controls.Add(this.picLogo);
            this.panelLoginContainer.Controls.Add(this.lblTitle);
            this.panelLoginContainer.Controls.Add(this.lblSubtitle);
            this.panelLoginContainer.Controls.Add(this.txtUsername);
            this.panelLoginContainer.Controls.Add(this.txtPassword);
            this.panelLoginContainer.Controls.Add(this.btnLogin);
            this.panelLoginContainer.Controls.Add(this.lblFooter);
            this.panelLoginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginContainer.Location = new System.Drawing.Point(667, 0);
            this.panelLoginContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelLoginContainer.Name = "panelLoginContainer";
            this.panelLoginContainer.Size = new System.Drawing.Size(666, 800);
            this.panelLoginContainer.TabIndex = 1;
            // 
            // controlBoxMinimize
            // 
            this.controlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxMinimize.BorderRadius = 5;
            this.controlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlBoxMinimize.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.controlBoxMinimize.Location = new System.Drawing.Point(530, 12);
            this.controlBoxMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.controlBoxMinimize.Name = "controlBoxMinimize";
            this.controlBoxMinimize.Size = new System.Drawing.Size(60, 43);
            this.controlBoxMinimize.TabIndex = 0;
            // 
            // controlBoxClose
            // 
            this.controlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxClose.BorderRadius = 5;
            this.controlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.controlBoxClose.HoverState.IconColor = System.Drawing.Color.White;
            this.controlBoxClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.controlBoxClose.Location = new System.Drawing.Point(592, 12);
            this.controlBoxClose.Margin = new System.Windows.Forms.Padding(4);
            this.controlBoxClose.Name = "controlBoxClose";
            this.controlBoxClose.Size = new System.Drawing.Size(60, 43);
            this.controlBoxClose.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.FillColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::winform.Properties.Resources.logo_foo1;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(253, 98);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.picLogo.ShadowDecoration.Depth = 20;
            this.picLogo.ShadowDecoration.Enabled = true;
            this.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLogo.Size = new System.Drawing.Size(160, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(173, 265);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 60);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Đăng Nhập";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSubtitle.Location = new System.Drawing.Point(80, 332);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(507, 28);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "Vui lòng nhập thông tin để truy cập hệ thống";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtUsername.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtUsername.Location = new System.Drawing.Point(80, 406);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtUsername.PlaceholderText = "Email tài khoản";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(507, 62);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtPassword.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtPassword.Location = new System.Drawing.Point(80, 492);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(507, 62);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 12;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLogin.Location = new System.Drawing.Point(80, 603);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 12;
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.ShadowDecoration.Depth = 20;
            this.btnLogin.ShadowDecoration.Enabled = true;
            this.btnLogin.Size = new System.Drawing.Size(507, 68);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "🔐 ĐĂNG NHẬP";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblFooter.Location = new System.Drawing.Point(80, 738);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(507, 25);
            this.lblFooter.TabIndex = 8;
            this.lblFooter.Text = "© 2025 - Hệ Thống Quản Lý. All rights reserved.";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // panelArt
            // 
            this.panelArt.BackColor = System.Drawing.Color.LightGray;
            this.panelArt.Controls.Add(this.lblArtTitle);
            this.panelArt.Controls.Add(this.picArtwork);
            this.panelArt.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelArt.Location = new System.Drawing.Point(0, 0);
            this.panelArt.Margin = new System.Windows.Forms.Padding(4);
            this.panelArt.Name = "panelArt";
            this.panelArt.Size = new System.Drawing.Size(667, 800);
            this.panelArt.TabIndex = 0;
            // 
            // lblArtTitle
            // 
            this.lblArtTitle.AutoSize = true;
            this.lblArtTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblArtTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblArtTitle.ForeColor = System.Drawing.Color.Black;
            this.lblArtTitle.Location = new System.Drawing.Point(115, 513);
            this.lblArtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtTitle.Name = "lblArtTitle";
            this.lblArtTitle.Size = new System.Drawing.Size(434, 62);
            this.lblArtTitle.TabIndex = 1;
            this.lblArtTitle.Text = "Hệ Thống Quản Lý";
            this.lblArtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picArtwork
            // 
            this.picArtwork.BackColor = System.Drawing.Color.Transparent;
            this.picArtwork.Image = global::winform.Properties.Resources.logo_foo1;
            this.picArtwork.Location = new System.Drawing.Point(100, 185);
            this.picArtwork.Margin = new System.Windows.Forms.Padding(4);
            this.picArtwork.Name = "picArtwork";
            this.picArtwork.Size = new System.Drawing.Size(467, 308);
            this.picArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtwork.TabIndex = 0;
            this.picArtwork.TabStop = false;
            // 
            // DanhNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 800);
            this.Controls.Add(this.panelLoginContainer);
            this.Controls.Add(this.panelArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập - Hệ Thống Quản Lý";
            this.panelLoginContainer.ResumeLayout(false);
            this.panelLoginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelArt.ResumeLayout(false);
            this.panelArt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelArt;
        private System.Windows.Forms.PictureBox picArtwork;
        private System.Windows.Forms.Label lblArtTitle;
        private Guna.UI2.WinForms.Guna2Panel panelLoginContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFooter;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picLogo;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxMinimize;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}