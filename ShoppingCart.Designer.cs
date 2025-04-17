namespace AgriTrack_FinalProject
{
    partial class ShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCart));
            addedCropsFpanel = new FlowLayoutPanel();
            bottomPanel = new Panel();
            topPanel = new Panel();
            checkBox1 = new CheckBox();
            checkOut = new Button();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addedCropsFpanel
            // 
            addedCropsFpanel.BackColor = Color.Transparent;
            addedCropsFpanel.Dock = DockStyle.Fill;
            addedCropsFpanel.Location = new Point(0, 0);
            addedCropsFpanel.Name = "addedCropsFpanel";
            addedCropsFpanel.Size = new Size(902, 440);
            addedCropsFpanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(checkOut);
            bottomPanel.Controls.Add(checkBox1);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 378);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(902, 62);
            bottomPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(902, 60);
            topPanel.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(3, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 34);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Select All";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkOut
            // 
            checkOut.FlatStyle = FlatStyle.Flat;
            checkOut.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOut.Location = new Point(760, 10);
            checkOut.Name = "checkOut";
            checkOut.Size = new Size(139, 45);
            checkOut.TabIndex = 1;
            checkOut.Text = "Check Out";
            checkOut.UseVisualStyleBackColor = true;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(topPanel);
            Controls.Add(bottomPanel);
            Controls.Add(addedCropsFpanel);
            DoubleBuffered = true;
            Name = "ShoppingCart";
            Size = new Size(902, 440);
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel addedCropsFpanel;
        private Panel bottomPanel;
        private Panel topPanel;
        private CheckBox checkBox1;
        private Button checkOut;
    }
}
