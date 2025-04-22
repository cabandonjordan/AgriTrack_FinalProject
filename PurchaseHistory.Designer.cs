namespace AgriTrack_FinalProject
{
    partial class PurchaseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseHistory));
            purchaseFlowPanel = new FlowLayoutPanel();
            dateFilter = new MenuStrip();
            SuspendLayout();
            // 
            // purchaseFlowPanel
            // 
            purchaseFlowPanel.AutoScroll = true;
            purchaseFlowPanel.BackColor = Color.Transparent;
            purchaseFlowPanel.Dock = DockStyle.Fill;
            purchaseFlowPanel.Location = new Point(0, 24);
            purchaseFlowPanel.Name = "purchaseFlowPanel";
            purchaseFlowPanel.Size = new Size(902, 416);
            purchaseFlowPanel.TabIndex = 0;
            // 
            // dateFilter
            // 
            dateFilter.Location = new Point(0, 0);
            dateFilter.Name = "dateFilter";
            dateFilter.Size = new Size(902, 24);
            dateFilter.TabIndex = 1;
            dateFilter.Text = "menuStrip1";
            // 
            // PurchaseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(purchaseFlowPanel);
            Controls.Add(dateFilter);
            DoubleBuffered = true;
            Name = "PurchaseHistory";
            Size = new Size(902, 440);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel purchaseFlowPanel;
        private MenuStrip dateFilter;
    }
}
