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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 81);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTenLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSiSo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTenGV, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 81);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTenLop
            // 
            this.lblTenLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLop.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTenLop.Location = new System.Drawing.Point(2, 0);
            this.lblTenLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(334, 25);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên Lớp Học";
            // 
            // lblSiSo
            // 
            this.lblSiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSiSo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiSo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSiSo.Location = new System.Drawing.Point(2, 25);
            this.lblSiSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(334, 28);
            this.lblSiSo.TabIndex = 0;
            this.lblSiSo.Text = "Sĩ Số:";
            this.lblSiSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenGV
            // 
            this.lblTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenGV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTenGV.Location = new System.Drawing.Point(2, 53);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(334, 33);
            this.lblTenGV.TabIndex = 0;
            this.lblTenGV.Text = "Tên Giáo Viên:";
            // 
            // LopHocItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LopHocItem";
            this.Size = new System.Drawing.Size(338, 81);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSiSo;
    }
}
