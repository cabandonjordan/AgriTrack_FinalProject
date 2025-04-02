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
            paymentPanel = new Panel();
            SuspendLayout();
            // 
            // paymentPanel
            // 
            paymentPanel.Dock = DockStyle.Right;
            paymentPanel.Location = new Point(676, 0);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(226, 440);
            paymentPanel.TabIndex = 0;
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(paymentPanel);
            Name = "AddToCart";
            Size = new Size(902, 440);
            ResumeLayout(false);
        }

        #endregion

        private Panel paymentPanel;
    }
}
