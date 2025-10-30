namespace winform
{
    partial class tongQuan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.lblSoLuongHocVien = new System.Windows.Forms.Label();
            this.lblHocVienTitle = new System.Windows.Forms.Label();
            this.panel_HocVien = new System.Windows.Forms.Panel();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoLuongKhoaHoc = new System.Windows.Forms.Label();
            this.lblKhoaHocTitle = new System.Windows.Forms.Label();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.panelGiaoVien = new System.Windows.Forms.Panel();
            this.lblSoLuongGiaoVien = new System.Windows.Forms.Label();
            this.lblGiaoVienTitle = new System.Windows.Forms.Label();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.panel_DoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.lblDoanhThuTitle = new System.Windows.Forms.Label();
            this.chart_HocVienMoi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpLopHocSapKhaiGiang = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.panel_3.SuspendLayout();
            this.panel_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_HocVienMoi)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel_1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.chart_HocVienMoi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 461);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel_1
            // 
            this.panel_1.Controls.Add(this.lblSoLuongHocVien);
            this.panel_1.Controls.Add(this.lblHocVienTitle);
            this.panel_1.Controls.Add(this.panel_HocVien);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_1.Location = new System.Drawing.Point(8, 8);
            this.panel_1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(197, 114);
            this.panel_1.TabIndex = 1;
            // 
            // lblSoLuongHocVien
            // 
            this.lblSoLuongHocVien.AutoSize = true;
            this.lblSoLuongHocVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongHocVien.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongHocVien.Location = new System.Drawing.Point(15, 45);
            this.lblSoLuongHocVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongHocVien.Name = "lblSoLuongHocVien";
            this.lblSoLuongHocVien.Size = new System.Drawing.Size(28, 32);
            this.lblSoLuongHocVien.TabIndex = 0;
            this.lblSoLuongHocVien.Text = "0";
            // 
            // lblHocVienTitle
            // 
            this.lblHocVienTitle.AutoSize = true;
            this.lblHocVienTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocVienTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblHocVienTitle.Location = new System.Drawing.Point(15, 20);
            this.lblHocVienTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHocVienTitle.Name = "lblHocVienTitle";
            this.lblHocVienTitle.Size = new System.Drawing.Size(160, 21);
            this.lblHocVienTitle.TabIndex = 0;
            this.lblHocVienTitle.Text = "TỔNG SỐ HỌC VIÊN";
            // 
            // panel_HocVien
            // 
            this.panel_HocVien.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_HocVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_HocVien.Location = new System.Drawing.Point(0, 0);
            this.panel_HocVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_HocVien.Name = "panel_HocVien";
            this.panel_HocVien.Size = new System.Drawing.Size(6, 114);
            this.panel_HocVien.TabIndex = 0;
            // 
            // panel_2
            // 
            this.panel_2.Controls.Add(this.panel1);
            this.panel_2.Controls.Add(this.lblSoLuongKhoaHoc);
            this.panel_2.Controls.Add(this.lblKhoaHocTitle);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2.Location = new System.Drawing.Point(221, 8);
            this.panel_2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(197, 114);
            this.panel_2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 114);
            this.panel1.TabIndex = 1;
            // 
            // lblSoLuongKhoaHoc
            // 
            this.lblSoLuongKhoaHoc.AutoSize = true;
            this.lblSoLuongKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKhoaHoc.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongKhoaHoc.Location = new System.Drawing.Point(15, 45);
            this.lblSoLuongKhoaHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongKhoaHoc.Name = "lblSoLuongKhoaHoc";
            this.lblSoLuongKhoaHoc.Size = new System.Drawing.Size(28, 32);
            this.lblSoLuongKhoaHoc.TabIndex = 0;
            this.lblSoLuongKhoaHoc.Text = "0";
            // 
            // lblKhoaHocTitle
            // 
            this.lblKhoaHocTitle.AutoSize = true;
            this.lblKhoaHocTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoaHocTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblKhoaHocTitle.Location = new System.Drawing.Point(15, 20);
            this.lblKhoaHocTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoaHocTitle.Name = "lblKhoaHocTitle";
            this.lblKhoaHocTitle.Size = new System.Drawing.Size(167, 21);
            this.lblKhoaHocTitle.TabIndex = 0;
            this.lblKhoaHocTitle.Text = "TỔNG SỐ KHÓA HỌC";
            // 
            // panel_3
            // 
            this.panel_3.Controls.Add(this.panelGiaoVien);
            this.panel_3.Controls.Add(this.lblSoLuongGiaoVien);
            this.panel_3.Controls.Add(this.lblGiaoVienTitle);
            this.panel_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_3.Location = new System.Drawing.Point(434, 8);
            this.panel_3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(197, 114);
            this.panel_3.TabIndex = 2;
            // 
            // panelGiaoVien
            // 
            this.panelGiaoVien.BackColor = System.Drawing.Color.Blue;
            this.panelGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.panelGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGiaoVien.Name = "panelGiaoVien";
            this.panelGiaoVien.Size = new System.Drawing.Size(6, 114);
            this.panelGiaoVien.TabIndex = 1;
            // 
            // lblSoLuongGiaoVien
            // 
            this.lblSoLuongGiaoVien.AutoSize = true;
            this.lblSoLuongGiaoVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongGiaoVien.Location = new System.Drawing.Point(15, 45);
            this.lblSoLuongGiaoVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongGiaoVien.Name = "lblSoLuongGiaoVien";
            this.lblSoLuongGiaoVien.Size = new System.Drawing.Size(28, 32);
            this.lblSoLuongGiaoVien.TabIndex = 0;
            this.lblSoLuongGiaoVien.Text = "0";
            // 
            // lblGiaoVienTitle
            // 
            this.lblGiaoVienTitle.AutoSize = true;
            this.lblGiaoVienTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaoVienTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblGiaoVienTitle.Location = new System.Drawing.Point(15, 20);
            this.lblGiaoVienTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaoVienTitle.Name = "lblGiaoVienTitle";
            this.lblGiaoVienTitle.Size = new System.Drawing.Size(165, 21);
            this.lblGiaoVienTitle.TabIndex = 0;
            this.lblGiaoVienTitle.Text = "TỔNG SỐ GIÁO VIÊN";
            // 
            // panel_4
            // 
            this.panel_4.Controls.Add(this.panel_DoanhThu);
            this.panel_4.Controls.Add(this.lblDoanhThuThang);
            this.panel_4.Controls.Add(this.lblDoanhThuTitle);
            this.panel_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_4.Location = new System.Drawing.Point(647, 8);
            this.panel_4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(197, 114);
            this.panel_4.TabIndex = 3;
            // 
            // panel_DoanhThu
            // 
            this.panel_DoanhThu.BackColor = System.Drawing.Color.Purple;
            this.panel_DoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_DoanhThu.Location = new System.Drawing.Point(0, 0);
            this.panel_DoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_DoanhThu.Name = "panel_DoanhThu";
            this.panel_DoanhThu.Size = new System.Drawing.Size(6, 114);
            this.panel_DoanhThu.TabIndex = 1;
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.Black;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(15, 45);
            this.lblDoanhThuThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(28, 32);
            this.lblDoanhThuThang.TabIndex = 0;
            this.lblDoanhThuThang.Text = "0";
            // 
            // lblDoanhThuTitle
            // 
            this.lblDoanhThuTitle.AutoSize = true;
            this.lblDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblDoanhThuTitle.Location = new System.Drawing.Point(15, 20);
            this.lblDoanhThuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            this.lblDoanhThuTitle.Size = new System.Drawing.Size(167, 21);
            this.lblDoanhThuTitle.TabIndex = 0;
            this.lblDoanhThuTitle.Text = "DOANH THU THÁNG";
            // 
            // chart_HocVienMoi
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart_HocVienMoi.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel2.SetColumnSpan(this.chart_HocVienMoi, 2);
            this.chart_HocVienMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_HocVienMoi.Legends.Add(legend1);
            this.chart_HocVienMoi.Location = new System.Drawing.Point(2, 132);
            this.chart_HocVienMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart_HocVienMoi.Name = "chart_HocVienMoi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "HocVienMoi";
            this.chart_HocVienMoi.Series.Add(series1);
            this.chart_HocVienMoi.Size = new System.Drawing.Size(422, 161);
            this.chart_HocVienMoi.TabIndex = 4;
            this.chart_HocVienMoi.Text = "chart1";
            // 
            // panel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(428, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 161);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 297);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(848, 162);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoạt động gần đây";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpLopHocSapKhaiGiang, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 161);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flpLopHocSapKhaiGiang
            // 
            this.flpLopHocSapKhaiGiang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLopHocSapKhaiGiang.Location = new System.Drawing.Point(3, 24);
            this.flpLopHocSapKhaiGiang.Name = "flpLopHocSapKhaiGiang";
            this.flpLopHocSapKhaiGiang.Size = new System.Drawing.Size(416, 134);
            this.flpLopHocSapKhaiGiang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỚP HỌC SÁP KHAI GIẢNG";
            // 
            // tongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tongQuan";
            this.Size = new System.Drawing.Size(852, 461);
            this.Load += new System.EventHandler(this.tongQuan_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            this.panel_4.ResumeLayout(false);
            this.panel_4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_HocVienMoi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Panel panel_HocVien;
        private System.Windows.Forms.Label lblHocVienTitle;
        private System.Windows.Forms.Panel panel_DoanhThu;
        private System.Windows.Forms.Label lblDoanhThuTitle;
        private System.Windows.Forms.Panel panelGiaoVien;
        private System.Windows.Forms.Label lblGiaoVienTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKhoaHocTitle;
        private System.Windows.Forms.Label lblSoLuongKhoaHoc;
        private System.Windows.Forms.Label lblSoLuongHocVien;
        private System.Windows.Forms.Label lblSoLuongGiaoVien;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_HocVienMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpLopHocSapKhaiGiang;
    }
}
