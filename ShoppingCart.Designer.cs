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
            checkOut = new Button();
            selectAll = new CheckBox();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addedCropsFpanel
            // 
            addedCropsFpanel.AutoScroll = true;
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
            bottomPanel.Controls.Add(selectAll);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 378);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(902, 62);
            bottomPanel.TabIndex = 1;
            // 
            // checkOut
            // 
            checkOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkOut.FlatStyle = FlatStyle.Flat;
            checkOut.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOut.Location = new Point(760, 10);
            checkOut.Name = "checkOut";
            checkOut.Size = new Size(139, 45);
            checkOut.TabIndex = 1;
            checkOut.Text = "Check Out";
            checkOut.UseVisualStyleBackColor = true;
            checkOut.Click += checkOut_Click;
            // 
            // selectAll
            // 
            selectAll.AutoSize = true;
            selectAll.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectAll.Location = new Point(3, 14);
            selectAll.Name = "selectAll";
            selectAll.Size = new Size(117, 34);
            selectAll.TabIndex = 0;
            selectAll.Text = "Select All";
            selectAll.UseVisualStyleBackColor = true;
            selectAll.CheckedChanged += selectAll_CheckedChanged;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
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
        private CheckBox selectAll;
        private Button checkOut;
    }
}
