namespace AgriTrack_FinalProject
{
    partial class PendingOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingOrders));
            orderPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // orderPanel
            // 
            orderPanel.AutoScroll = true;
            orderPanel.BackColor = Color.Transparent;
            orderPanel.Dock = DockStyle.Fill;
            orderPanel.Location = new Point(0, 0);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(902, 440);
            orderPanel.TabIndex = 0;
            // 
            // PendingOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(orderPanel);
            DoubleBuffered = true;
            Name = "PendingOrders";
            Size = new Size(902, 440);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel orderPanel;
    }
}
