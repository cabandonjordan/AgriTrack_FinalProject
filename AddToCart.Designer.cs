namespace AgriTrack_FinalProject
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            paymentPanel = new Panel();
            addedCropsCart = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // paymentPanel
            // 
            paymentPanel.BackColor = Color.Transparent;
            paymentPanel.Dock = DockStyle.Right;
            paymentPanel.Location = new Point(709, 0);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(193, 440);
            paymentPanel.TabIndex = 0;
            // 
            // addedCropsCart
            // 
            addedCropsCart.BackColor = Color.Transparent;
            addedCropsCart.Dock = DockStyle.Fill;
            addedCropsCart.Location = new Point(0, 0);
            addedCropsCart.Name = "addedCropsCart";
            addedCropsCart.Size = new Size(709, 440);
            addedCropsCart.TabIndex = 1;
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(addedCropsCart);
            Controls.Add(paymentPanel);
            DoubleBuffered = true;
            Name = "AddToCart";
            Size = new Size(902, 440);
            ResumeLayout(false);
        }

        #endregion

        private Panel paymentPanel;
        private FlowLayoutPanel addedCropsCart;
    }
}
