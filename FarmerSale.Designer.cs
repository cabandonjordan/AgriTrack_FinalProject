namespace AgriTrack_FinalProject
{
    partial class FarmerSale
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
            salesReport = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            totalAmount = new Label();
            viewSales = new MenuStrip();
            daily = new ToolStripMenuItem();
            weekly = new ToolStripMenuItem();
            monthly = new ToolStripMenuItem();
            Yearly = new ToolStripMenuItem();
            cartesianSales = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tablePanel = new TableLayoutPanel();
            viewSales.SuspendLayout();
            tablePanel.SuspendLayout();
            SuspendLayout();
            // 
            // salesReport
            // 
            salesReport.BackColor = SystemColors.ActiveBorder;
            salesReport.Dock = DockStyle.Fill;
            salesReport.InitialRotation = 0D;
            salesReport.IsClockwise = true;
            salesReport.Location = new Point(454, 3);
            salesReport.MaxAngle = 360D;
            salesReport.MaxValue = double.NaN;
            salesReport.MinValue = 0D;
            salesReport.Name = "salesReport";
            salesReport.Size = new Size(445, 368);
            salesReport.TabIndex = 0;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.Location = new Point(16, 33);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(66, 30);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "Total";
            // 
            // viewSales
            // 
            viewSales.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewSales.Items.AddRange(new ToolStripItem[] { daily, weekly, monthly, Yearly });
            viewSales.Location = new Point(0, 0);
            viewSales.Name = "viewSales";
            viewSales.Size = new Size(902, 33);
            viewSales.TabIndex = 2;
            viewSales.Text = "Daily";
            // 
            // daily
            // 
            daily.Name = "daily";
            daily.Size = new Size(125, 29);
            daily.Text = "Daily Sales";
            daily.Click += daily_Click;
            // 
            // weekly
            // 
            weekly.Name = "weekly";
            weekly.Size = new Size(147, 29);
            weekly.Text = "Weekly Sales";
            weekly.Click += weekly_Click;
            // 
            // monthly
            // 
            monthly.Name = "monthly";
            monthly.Size = new Size(157, 29);
            monthly.Text = "Monthly Sales";
            monthly.Click += monthly_Click;
            // 
            // Yearly
            // 
            Yearly.Name = "Yearly";
            Yearly.Size = new Size(144, 29);
            Yearly.Text = "Annual Sales";
            Yearly.Click += Yearly_Click;
            // 
            // cartesianSales
            // 
            cartesianSales.BackColor = SystemColors.ControlDark;
            cartesianSales.Dock = DockStyle.Fill;
            cartesianSales.Location = new Point(3, 3);
            cartesianSales.MatchAxesScreenDataRatio = false;
            cartesianSales.Name = "cartesianSales";
            cartesianSales.Size = new Size(445, 368);
            cartesianSales.TabIndex = 3;
            // 
            // tablePanel
            // 
            tablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablePanel.ColumnCount = 2;
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePanel.Controls.Add(cartesianSales, 0, 1);
            tablePanel.Controls.Add(salesReport, 1, 1);
            tablePanel.Location = new Point(0, 66);
            tablePanel.Name = "tablePanel";
            tablePanel.RowCount = 2;
            tablePanel.RowStyles.Add(new RowStyle());
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePanel.Size = new Size(902, 374);
            tablePanel.TabIndex = 4;
            // 
            // FarmerSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tablePanel);
            Controls.Add(totalAmount);
            Controls.Add(viewSales);
            Name = "FarmerSale";
            Size = new Size(902, 440);
            viewSales.ResumeLayout(false);
            viewSales.PerformLayout();
            tablePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.PieChart salesReport;
        private Label totalAmount;
        private MenuStrip viewSales;
        private ToolStripMenuItem daily;
        private ToolStripMenuItem weekly;
        private ToolStripMenuItem monthly;
        private ToolStripMenuItem Yearly;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianSales;
        private TableLayoutPanel tablePanel;
    }
}
