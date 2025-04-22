namespace AgriTrack_FinalProject
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            panel3 = new Panel();
            searchBtn = new Button();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            panel2 = new Panel();
            loadBtn = new Button();
            logOut = new Button();
            adminPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 68);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(searchBtn);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(searchBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 66);
            panel3.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Transparent;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(590, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(42, 35);
            searchBtn.TabIndex = 2;
            searchBtn.TextAlign = ContentAlignment.MiddleRight;
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.BackColor = SystemColors.Control;
            searchBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(176, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(408, 35);
            searchBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(loadBtn);
            panel2.Controls.Add(logOut);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 438);
            panel2.TabIndex = 1;
            // 
            // loadBtn
            // 
            loadBtn.Dock = DockStyle.Top;
            loadBtn.FlatStyle = FlatStyle.Flat;
            loadBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadBtn.Image = (Image)resources.GetObject("loadBtn.Image");
            loadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loadBtn.Location = new Point(0, 0);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(170, 53);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "       User Manager";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // logOut
            // 
            logOut.Dock = DockStyle.Bottom;
            logOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOut.Image = (Image)resources.GetObject("logOut.Image");
            logOut.ImageAlign = ContentAlignment.MiddleLeft;
            logOut.Location = new Point(0, 376);
            logOut.Name = "logOut";
            logOut.Size = new Size(170, 62);
            logOut.TabIndex = 7;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = true;
            logOut.Click += logOut_Click;
            // 
            // adminPanel
            // 
            adminPanel.AutoScroll = true;
            adminPanel.BackgroundImage = (Image)resources.GetObject("adminPanel.BackgroundImage");
            adminPanel.BackgroundImageLayout = ImageLayout.Stretch;
            adminPanel.Dock = DockStyle.Fill;
            adminPanel.Location = new Point(170, 68);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(902, 438);
            adminPanel.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 506);
            Controls.Add(adminPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button logOut;
        private Panel panel3;
        private Button searchBtn;
        private PictureBox pictureBox1;
        private TextBox searchBox;
        private Panel adminPanel;
        private Button loadBtn;
    }
}