namespace AgriTrack_FinalProject
{
    partial class MarketPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketPlace));
            marketPlaceFpan = new SiticoneNetCoreUI.SiticoneFlowPanel();
            SuspendLayout();
            // 
            // marketPlaceFpan
            // 
            marketPlaceFpan.AutoScroll = true;
            marketPlaceFpan.BackColor = Color.Transparent;
            marketPlaceFpan.Dock = DockStyle.Fill;
            marketPlaceFpan.EnableAnimations = true;
            marketPlaceFpan.EnableAutoScale = true;
            marketPlaceFpan.EnableDragDrop = false;
            marketPlaceFpan.EnableLayoutCaching = true;
            marketPlaceFpan.EnableSmoothScrolling = true;
            marketPlaceFpan.EnableSnapToGrid = false;
            marketPlaceFpan.EnableTransparency = false;
            marketPlaceFpan.EnableVirtualization = false;
            marketPlaceFpan.EnableWrapping = true;
            marketPlaceFpan.GridSize = 8;
            marketPlaceFpan.IsTrackingTheme = false;
            marketPlaceFpan.ItemSpacing = 5;
            marketPlaceFpan.Location = new Point(0, 0);
            marketPlaceFpan.Name = "marketPlaceFpan";
            marketPlaceFpan.Size = new Size(902, 440);
            marketPlaceFpan.TabIndex = 0;
            marketPlaceFpan.VirtualizationThreshold = 100;
            // 
            // MarketPlace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(marketPlaceFpan);
            Name = "MarketPlace";
            Size = new Size(902, 440);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneFlowPanel marketPlaceFpan;
    }
}
