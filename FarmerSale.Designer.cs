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
            SuspendLayout();
            // 
            // salesReport
            // 
            salesReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salesReport.BackColor = SystemColors.ActiveBorder;
            salesReport.InitialRotation = 0D;
            salesReport.IsClockwise = true;
            salesReport.Location = new Point(67, 58);
            salesReport.MaxAngle = 360D;
            salesReport.MaxValue = double.NaN;
            salesReport.MinValue = 0D;
            salesReport.Name = "salesReport";
            salesReport.Size = new Size(453, 308);
            salesReport.TabIndex = 0;
            // 
            // totalAmount
            // 
            totalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.Location = new Point(617, 22);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(66, 30);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "Total";
            // 
            // FarmerSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalAmount);
            Controls.Add(salesReport);
            Name = "FarmerSale";
            Size = new Size(902, 440);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.PieChart salesReport;
        private Label totalAmount;
    }
}
