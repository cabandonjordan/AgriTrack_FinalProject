namespace AgriTrack_FinalProject
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            userGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            SuspendLayout();
            // 
            // userGrid
            // 
            userGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Location = new Point(137, 14);
            userGrid.Name = "userGrid";
            userGrid.ReadOnly = true;
            userGrid.Size = new Size(562, 410);
            userGrid.TabIndex = 0;
            // 
            // UserManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(userGrid);
            DoubleBuffered = true;
            Name = "UserManager";
            Size = new Size(902, 438);
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userGrid;
    }
}
