namespace AgriTrack_FinalProject
{
    partial class FarmerCrops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerCrops));
            addCropsPanel = new Panel();
            addCrop = new Button();
            addedCropsFpanel = new FlowLayoutPanel();
            addCropsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addCropsPanel
            // 
            addCropsPanel.AutoScroll = true;
            addCropsPanel.BackColor = Color.Transparent;
            addCropsPanel.Controls.Add(addCrop);
            addCropsPanel.Dock = DockStyle.Right;
            addCropsPanel.Location = new Point(788, 0);
            addCropsPanel.Name = "addCropsPanel";
            addCropsPanel.Size = new Size(114, 503);
            addCropsPanel.TabIndex = 0;
            // 
            // addCrop
            // 
            addCrop.Dock = DockStyle.Bottom;
            addCrop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCrop.Image = (Image)resources.GetObject("addCrop.Image");
            addCrop.ImageAlign = ContentAlignment.MiddleLeft;
            addCrop.Location = new Point(0, 460);
            addCrop.Name = "addCrop";
            addCrop.Size = new Size(114, 43);
            addCrop.TabIndex = 4;
            addCrop.Text = "Add Crop";
            addCrop.TextAlign = ContentAlignment.MiddleRight;
            addCrop.UseVisualStyleBackColor = true;
            addCrop.Click += addCrop_Click;
            // 
            // addedCropsFpanel
            // 
            addedCropsFpanel.AutoScroll = true;
            addedCropsFpanel.BackColor = Color.Transparent;
            addedCropsFpanel.BackgroundImageLayout = ImageLayout.Stretch;
            addedCropsFpanel.Dock = DockStyle.Fill;
            addedCropsFpanel.Location = new Point(0, 0);
            addedCropsFpanel.Name = "addedCropsFpanel";
            addedCropsFpanel.Size = new Size(788, 503);
            addedCropsFpanel.TabIndex = 1;
            // 
            // FarmerCrops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(addedCropsFpanel);
            Controls.Add(addCropsPanel);
            DoubleBuffered = true;
            Name = "FarmerCrops";
            Size = new Size(902, 503);
            addCropsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel addCropsPanel;
        private FlowLayoutPanel addedCropsFpanel;
        private Button addCrop;
    }
}
