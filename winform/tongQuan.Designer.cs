using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
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

            // --- KHỞI TẠO CÁC CONTROL ---
            this.pnlCardHocVien = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHocVienTitle = new System.Windows.Forms.Label();
            this.lblSoLuongHocVien = new System.Windows.Forms.Label();
            this.btnIconHocVien = new Guna.UI2.WinForms.Guna2Button();

            this.pnlCardKhoaHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.lblKhoaHocTitle = new System.Windows.Forms.Label();
            this.lblSoLuongKhoaHoc = new System.Windows.Forms.Label();
            this.btnIconKhoaHoc = new Guna.UI2.WinForms.Guna2Button();

            this.pnlCardGiaoVien = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGiaoVienTitle = new System.Windows.Forms.Label();
            this.lblSoLuongGiaoVien = new System.Windows.Forms.Label();
            this.btnIconGiaoVien = new Guna.UI2.WinForms.Guna2Button();

            this.pnlCardDoanhThu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDoanhThuTitle = new System.Windows.Forms.Label();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.btnIconDoanhThu = new Guna.UI2.WinForms.Guna2Button();

            this.pnlChartContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.chart_HocVienMoi = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.pnlListLopHocContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpLopHocSapKhaiGiang = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlActivityContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();

            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCardHocVien.SuspendLayout();
            this.pnlCardKhoaHoc.SuspendLayout();
            this.pnlCardGiaoVien.SuspendLayout();
            this.pnlCardDoanhThu.SuspendLayout();
            this.pnlChartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_HocVienMoi)).BeginInit();
            this.pnlListLopHocContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlActivityContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.pnlCardHocVien, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlCardKhoaHoc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlCardGiaoVien, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlCardDoanhThu, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlChartContainer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnlListLopHocContainer, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnlActivityContainer, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 461);
            this.tableLayoutPanel2.TabIndex = 1;

            // 
            // ========================= CARD 1: HỌC VIÊN (Xanh Lá) =========================
            // 
            // pnlCardHocVien
            // 
            this.pnlCardHocVien.BorderRadius = 15;
            this.pnlCardHocVien.Controls.Add(this.lblHocVienTitle);
            this.pnlCardHocVien.Controls.Add(this.lblSoLuongHocVien);
            this.pnlCardHocVien.Controls.Add(this.btnIconHocVien);
            this.pnlCardHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardHocVien.FillColor = System.Drawing.Color.White;
            this.pnlCardHocVien.Location = new System.Drawing.Point(15, 15);
            this.pnlCardHocVien.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCardHocVien.Name = "pnlCardHocVien";
            this.pnlCardHocVien.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlCardHocVien.ShadowDecoration.Enabled = true;
            this.pnlCardHocVien.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlCardHocVien.Size = new System.Drawing.Size(198, 130);
            this.pnlCardHocVien.TabIndex = 0;
            // 
            // lblHocVienTitle
            // 
            this.lblHocVienTitle.AutoSize = true;
            this.lblHocVienTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHocVienTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHocVienTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblHocVienTitle.Location = new System.Drawing.Point(15, 25);
            this.lblHocVienTitle.Name = "lblHocVienTitle";
            this.lblHocVienTitle.Size = new System.Drawing.Size(77, 19);
            this.lblHocVienTitle.TabIndex = 0;
            this.lblHocVienTitle.Text = "HỌC VIÊN";
            // 
            // lblSoLuongHocVien
            // 
            this.lblSoLuongHocVien.AutoSize = true;
            this.lblSoLuongHocVien.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongHocVien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongHocVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoLuongHocVien.Location = new System.Drawing.Point(12, 50);
            this.lblSoLuongHocVien.Name = "lblSoLuongHocVien";
            this.lblSoLuongHocVien.Size = new System.Drawing.Size(33, 37);
            this.lblSoLuongHocVien.TabIndex = 1;
            this.lblSoLuongHocVien.Text = "0";
            // 
            // btnIconHocVien
            // 
            this.btnIconHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconHocVien.BorderRadius = 20;
            this.btnIconHocVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnIconHocVien.Enabled = false;
            this.btnIconHocVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnIconHocVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIconHocVien.ForeColor = System.Drawing.Color.White;
            this.btnIconHocVien.Location = new System.Drawing.Point(143, 30);
            this.btnIconHocVien.Name = "btnIconHocVien";
            this.btnIconHocVien.Size = new System.Drawing.Size(40, 40);
            this.btnIconHocVien.TabIndex = 2;

            // 
            // ========================= CARD 2: KHÓA HỌC (Đỏ) =========================
            // 
            // pnlCardKhoaHoc
            // 
            this.pnlCardKhoaHoc.BorderRadius = 15;
            this.pnlCardKhoaHoc.Controls.Add(this.lblKhoaHocTitle);
            this.pnlCardKhoaHoc.Controls.Add(this.lblSoLuongKhoaHoc);
            this.pnlCardKhoaHoc.Controls.Add(this.btnIconKhoaHoc);
            this.pnlCardKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardKhoaHoc.FillColor = System.Drawing.Color.White;
            this.pnlCardKhoaHoc.Location = new System.Drawing.Point(223, 15);
            this.pnlCardKhoaHoc.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCardKhoaHoc.Name = "pnlCardKhoaHoc";
            this.pnlCardKhoaHoc.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlCardKhoaHoc.ShadowDecoration.Enabled = true;
            this.pnlCardKhoaHoc.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlCardKhoaHoc.Size = new System.Drawing.Size(198, 130);
            this.pnlCardKhoaHoc.TabIndex = 1;
            // 
            // lblKhoaHocTitle
            // 
            this.lblKhoaHocTitle.AutoSize = true;
            this.lblKhoaHocTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblKhoaHocTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKhoaHocTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblKhoaHocTitle.Location = new System.Drawing.Point(15, 25);
            this.lblKhoaHocTitle.Name = "lblKhoaHocTitle";
            this.lblKhoaHocTitle.Size = new System.Drawing.Size(85, 19);
            this.lblKhoaHocTitle.TabIndex = 0;
            this.lblKhoaHocTitle.Text = "KHÓA HỌC";
            // 
            // lblSoLuongKhoaHoc
            // 
            this.lblSoLuongKhoaHoc.AutoSize = true;
            this.lblSoLuongKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoLuongKhoaHoc.Location = new System.Drawing.Point(12, 50);
            this.lblSoLuongKhoaHoc.Name = "lblSoLuongKhoaHoc";
            this.lblSoLuongKhoaHoc.Size = new System.Drawing.Size(33, 37);
            this.lblSoLuongKhoaHoc.TabIndex = 1;
            this.lblSoLuongKhoaHoc.Text = "0";
            // 
            // btnIconKhoaHoc
            // 
            this.btnIconKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconKhoaHoc.BorderRadius = 20;
            this.btnIconKhoaHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnIconKhoaHoc.Enabled = false;
            this.btnIconKhoaHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnIconKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIconKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnIconKhoaHoc.Location = new System.Drawing.Point(143, 30);
            this.btnIconKhoaHoc.Name = "btnIconKhoaHoc";
            this.btnIconKhoaHoc.Size = new System.Drawing.Size(40, 40);
            this.btnIconKhoaHoc.TabIndex = 2;

            // 
            // ========================= CARD 3: GIÁO VIÊN (Xanh Dương) =========================
            // 
            // pnlCardGiaoVien
            // 
            this.pnlCardGiaoVien.BorderRadius = 15;
            this.pnlCardGiaoVien.Controls.Add(this.lblGiaoVienTitle);
            this.pnlCardGiaoVien.Controls.Add(this.lblSoLuongGiaoVien);
            this.pnlCardGiaoVien.Controls.Add(this.btnIconGiaoVien);
            this.pnlCardGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardGiaoVien.FillColor = System.Drawing.Color.White;
            this.pnlCardGiaoVien.Location = new System.Drawing.Point(431, 15);
            this.pnlCardGiaoVien.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCardGiaoVien.Name = "pnlCardGiaoVien";
            this.pnlCardGiaoVien.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlCardGiaoVien.ShadowDecoration.Enabled = true;
            this.pnlCardGiaoVien.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlCardGiaoVien.Size = new System.Drawing.Size(198, 130);
            this.pnlCardGiaoVien.TabIndex = 2;
            // 
            // lblGiaoVienTitle
            // 
            this.lblGiaoVienTitle.AutoSize = true;
            this.lblGiaoVienTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaoVienTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiaoVienTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblGiaoVienTitle.Location = new System.Drawing.Point(15, 25);
            this.lblGiaoVienTitle.Name = "lblGiaoVienTitle";
            this.lblGiaoVienTitle.Size = new System.Drawing.Size(81, 19);
            this.lblGiaoVienTitle.TabIndex = 0;
            this.lblGiaoVienTitle.Text = "GIÁO VIÊN";
            // 
            // lblSoLuongGiaoVien
            // 
            this.lblSoLuongGiaoVien.AutoSize = true;
            this.lblSoLuongGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongGiaoVien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoLuongGiaoVien.Location = new System.Drawing.Point(12, 50);
            this.lblSoLuongGiaoVien.Name = "lblSoLuongGiaoVien";
            this.lblSoLuongGiaoVien.Size = new System.Drawing.Size(33, 37);
            this.lblSoLuongGiaoVien.TabIndex = 1;
            this.lblSoLuongGiaoVien.Text = "0";
            // 
            // btnIconGiaoVien
            // 
            this.btnIconGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconGiaoVien.BorderRadius = 20;
            this.btnIconGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnIconGiaoVien.Enabled = false;
            this.btnIconGiaoVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnIconGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIconGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnIconGiaoVien.Location = new System.Drawing.Point(143, 30);
            this.btnIconGiaoVien.Name = "btnIconGiaoVien";
            this.btnIconGiaoVien.Size = new System.Drawing.Size(40, 40);
            this.btnIconGiaoVien.TabIndex = 2;

            // 
            // ========================= CARD 4: DOANH THU (Tím) =========================
            // 
            // pnlCardDoanhThu
            // 
            this.pnlCardDoanhThu.BorderRadius = 15;
            this.pnlCardDoanhThu.Controls.Add(this.lblDoanhThuTitle);
            this.pnlCardDoanhThu.Controls.Add(this.lblDoanhThuThang);
            this.pnlCardDoanhThu.Controls.Add(this.btnIconDoanhThu);
            this.pnlCardDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardDoanhThu.FillColor = System.Drawing.Color.White;
            this.pnlCardDoanhThu.Location = new System.Drawing.Point(639, 15);
            this.pnlCardDoanhThu.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCardDoanhThu.Name = "pnlCardDoanhThu";
            this.pnlCardDoanhThu.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlCardDoanhThu.ShadowDecoration.Enabled = true;
            this.pnlCardDoanhThu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlCardDoanhThu.Size = new System.Drawing.Size(198, 130);
            this.pnlCardDoanhThu.TabIndex = 3;
            // 
            // lblDoanhThuTitle
            // 
            this.lblDoanhThuTitle.AutoSize = true;
            this.lblDoanhThuTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblDoanhThuTitle.Location = new System.Drawing.Point(15, 25);
            this.lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            this.lblDoanhThuTitle.Size = new System.Drawing.Size(95, 19);
            this.lblDoanhThuTitle.TabIndex = 0;
            this.lblDoanhThuTitle.Text = "DOANH THU";
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDoanhThuThang.Location = new System.Drawing.Point(12, 50);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(33, 37);
            this.lblDoanhThuThang.TabIndex = 1;
            this.lblDoanhThuThang.Text = "0";
            // 
            // btnIconDoanhThu
            // 
            this.btnIconDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconDoanhThu.BorderRadius = 20;
            this.btnIconDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnIconDoanhThu.Enabled = false;
            this.btnIconDoanhThu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnIconDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIconDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnIconDoanhThu.Location = new System.Drawing.Point(143, 30);
            this.btnIconDoanhThu.Name = "btnIconDoanhThu";
            this.btnIconDoanhThu.Size = new System.Drawing.Size(40, 40);
            this.btnIconDoanhThu.TabIndex = 2;

            // 
            // ========================= CHART =========================
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pnlChartContainer, 2);
            this.pnlChartContainer.BorderRadius = 10;
            this.pnlChartContainer.Controls.Add(this.chart_HocVienMoi);
            this.pnlChartContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartContainer.FillColor = System.Drawing.Color.White;
            this.pnlChartContainer.Location = new System.Drawing.Point(15, 155);
            this.pnlChartContainer.Margin = new System.Windows.Forms.Padding(5);
            this.pnlChartContainer.Name = "pnlChartContainer";
            this.pnlChartContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlChartContainer.Size = new System.Drawing.Size(406, 179);
            this.pnlChartContainer.TabIndex = 4;
            // 
            // chart_HocVienMoi
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_HocVienMoi.ChartAreas.Add(chartArea1);
            this.chart_HocVienMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_HocVienMoi.Legends.Add(legend1);
            this.chart_HocVienMoi.Location = new System.Drawing.Point(10, 10);
            this.chart_HocVienMoi.Name = "chart_HocVienMoi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "HocVienMoi";
            this.chart_HocVienMoi.Series.Add(series1);
            this.chart_HocVienMoi.Size = new System.Drawing.Size(386, 159);
            this.chart_HocVienMoi.TabIndex = 0;
            this.chart_HocVienMoi.Text = "chart1";

            // 
            // ========================= LIST LỚP HỌC =========================
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pnlListLopHocContainer, 2);
            this.pnlListLopHocContainer.BorderRadius = 10;
            this.pnlListLopHocContainer.Controls.Add(this.tableLayoutPanel1);
            this.pnlListLopHocContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListLopHocContainer.FillColor = System.Drawing.Color.White;
            this.pnlListLopHocContainer.Location = new System.Drawing.Point(431, 155);
            this.pnlListLopHocContainer.Margin = new System.Windows.Forms.Padding(5);
            this.pnlListLopHocContainer.Name = "pnlListLopHocContainer";
            this.pnlListLopHocContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlListLopHocContainer.Size = new System.Drawing.Size(406, 179);
            this.pnlListLopHocContainer.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpLopHocSapKhaiGiang, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỚP HỌC SẮP KHAI GIẢNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpLopHocSapKhaiGiang
            // 
            this.flpLopHocSapKhaiGiang.AutoScroll = true;
            this.flpLopHocSapKhaiGiang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLopHocSapKhaiGiang.Location = new System.Drawing.Point(3, 43);
            this.flpLopHocSapKhaiGiang.Name = "flpLopHocSapKhaiGiang";
            this.flpLopHocSapKhaiGiang.Size = new System.Drawing.Size(380, 113);
            this.flpLopHocSapKhaiGiang.TabIndex = 1;

            // 
            // ========================= ACTIVITY BOTTOM =========================
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pnlActivityContainer, 4);
            this.pnlActivityContainer.BorderRadius = 10;
            this.pnlActivityContainer.Controls.Add(this.flowLayoutPanel1);
            this.pnlActivityContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivityContainer.FillColor = System.Drawing.Color.White;
            this.pnlActivityContainer.Location = new System.Drawing.Point(15, 344);
            this.pnlActivityContainer.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActivityContainer.Name = "pnlActivityContainer";
            this.pnlActivityContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlActivityContainer.Size = new System.Drawing.Size(822, 112);
            this.pnlActivityContainer.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 92);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoạt động gần đây";

            // 
            // tongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "tongQuan";
            this.Size = new System.Drawing.Size(852, 461);
            this.Load += new System.EventHandler(this.tongQuan_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlCardHocVien.ResumeLayout(false);
            this.pnlCardHocVien.PerformLayout();
            this.pnlCardKhoaHoc.ResumeLayout(false);
            this.pnlCardKhoaHoc.PerformLayout();
            this.pnlCardGiaoVien.ResumeLayout(false);
            this.pnlCardGiaoVien.PerformLayout();
            this.pnlCardDoanhThu.ResumeLayout(false);
            this.pnlCardDoanhThu.PerformLayout();
            this.pnlChartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_HocVienMoi)).EndInit();
            this.pnlListLopHocContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlActivityContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // KHAI BÁO BIẾN
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        // Card Học Viên
        private Guna.UI2.WinForms.Guna2Panel pnlCardHocVien;
        private Guna.UI2.WinForms.Guna2Button btnIconHocVien;
        private System.Windows.Forms.Label lblHocVienTitle;
        private System.Windows.Forms.Label lblSoLuongHocVien;

        // Card Khóa Học
        private Guna.UI2.WinForms.Guna2Panel pnlCardKhoaHoc;
        private Guna.UI2.WinForms.Guna2Button btnIconKhoaHoc;
        private System.Windows.Forms.Label lblKhoaHocTitle;
        private System.Windows.Forms.Label lblSoLuongKhoaHoc;

        // Card Giáo Viên
        private Guna.UI2.WinForms.Guna2Panel pnlCardGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnIconGiaoVien;
        private System.Windows.Forms.Label lblGiaoVienTitle;
        private System.Windows.Forms.Label lblSoLuongGiaoVien;

        // Card Doanh Thu
        private Guna.UI2.WinForms.Guna2Panel pnlCardDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnIconDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuTitle;
        private System.Windows.Forms.Label lblDoanhThuThang;

        // Chart
        private Guna.UI2.WinForms.Guna2Panel pnlChartContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_HocVienMoi;

        // List Lớp Học
        private Guna.UI2.WinForms.Guna2Panel pnlListLopHocContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpLopHocSapKhaiGiang;

        // Bottom Activity
        private Guna.UI2.WinForms.Guna2Panel pnlActivityContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}
