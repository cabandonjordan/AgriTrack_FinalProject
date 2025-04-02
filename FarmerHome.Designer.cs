namespace AgriTrack_FinalProject
{
    partial class FarmerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerHome));
            homeCropsFlow = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // homeCropsFlow
            // 
            homeCropsFlow.AutoScroll = true;
            homeCropsFlow.BackColor = Color.Transparent;
            homeCropsFlow.Dock = DockStyle.Fill;
            homeCropsFlow.Location = new Point(0, 0);
            homeCropsFlow.Name = "homeCropsFlow";
            homeCropsFlow.Size = new Size(902, 440);
            homeCropsFlow.TabIndex = 0;
            // 
            // FarmerHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(homeCropsFlow);
            DoubleBuffered = true;
            Name = "FarmerHome";
            Size = new Size(902, 440);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel homeCropsFlow;
    }
}
