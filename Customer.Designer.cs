namespace AgriTrack_FinalProject
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            panel1 = new Panel();
            label1 = new Label();
            profileBtn = new Button();
            searchBtn = new Button();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            slideMenu = new Panel();
            logOut = new Button();
            purchaseHistory = new Button();
            addToCart = new Button();
            marketPlace = new Button();
            customerPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            slideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(profileBtn);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(searchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(984, 50);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Profile";
            // 
            // profileBtn
            // 
            profileBtn.Anchor = AnchorStyles.Right;
            profileBtn.BackColor = Color.Transparent;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Image = (Image)resources.GetObject("profileBtn.Image");
            profileBtn.Location = new Point(978, 12);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(56, 35);
            profileBtn.TabIndex = 3;
            profileBtn.UseVisualStyleBackColor = false;
            profileBtn.Click += profileBtn_Click;
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
            // slideMenu
            // 
            slideMenu.BackgroundImage = (Image)resources.GetObject("slideMenu.BackgroundImage");
            slideMenu.BackgroundImageLayout = ImageLayout.Stretch;
            slideMenu.Controls.Add(logOut);
            slideMenu.Controls.Add(purchaseHistory);
            slideMenu.Controls.Add(addToCart);
            slideMenu.Controls.Add(marketPlace);
            slideMenu.Dock = DockStyle.Left;
            slideMenu.Location = new Point(0, 66);
            slideMenu.Name = "slideMenu";
            slideMenu.Size = new Size(170, 440);
            slideMenu.TabIndex = 2;
            // 
            // logOut
            // 
            logOut.Dock = DockStyle.Bottom;
            logOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOut.Image = (Image)resources.GetObject("logOut.Image");
            logOut.ImageAlign = ContentAlignment.MiddleLeft;
            logOut.Location = new Point(0, 378);
            logOut.Name = "logOut";
            logOut.Size = new Size(170, 62);
            logOut.TabIndex = 7;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = true;
            logOut.Click += logOut_Click;
            // 
            // purchaseHistory
            // 
            purchaseHistory.Dock = DockStyle.Top;
            purchaseHistory.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseHistory.Image = (Image)resources.GetObject("purchaseHistory.Image");
            purchaseHistory.ImageAlign = ContentAlignment.MiddleLeft;
            purchaseHistory.Location = new Point(0, 124);
            purchaseHistory.Name = "purchaseHistory";
            purchaseHistory.Size = new Size(170, 62);
            purchaseHistory.TabIndex = 3;
            purchaseHistory.Text = "       Purchase History";
            purchaseHistory.UseVisualStyleBackColor = true;
            purchaseHistory.Click += purchaseHistory_Click;
            // 
            // addToCart
            // 
            addToCart.Dock = DockStyle.Top;
            addToCart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToCart.Image = (Image)resources.GetObject("addToCart.Image");
            addToCart.ImageAlign = ContentAlignment.MiddleLeft;
            addToCart.Location = new Point(0, 62);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(170, 62);
            addToCart.TabIndex = 2;
            addToCart.Text = "    Shopping Cart";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += addToCart_Click;
            // 
            // marketPlace
            // 
            marketPlace.Dock = DockStyle.Top;
            marketPlace.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marketPlace.Image = (Image)resources.GetObject("marketPlace.Image");
            marketPlace.ImageAlign = ContentAlignment.MiddleLeft;
            marketPlace.Location = new Point(0, 0);
            marketPlace.Name = "marketPlace";
            marketPlace.Size = new Size(170, 62);
            marketPlace.TabIndex = 1;
            marketPlace.Text = "  Marketplace";
            marketPlace.UseVisualStyleBackColor = true;
            marketPlace.Click += marketPlace_Click;
            // 
            // customerPanel
            // 
            customerPanel.AutoScroll = true;
            customerPanel.BackgroundImage = (Image)resources.GetObject("customerPanel.BackgroundImage");
            customerPanel.BackgroundImageLayout = ImageLayout.Stretch;
            customerPanel.Dock = DockStyle.Fill;
            customerPanel.Location = new Point(170, 66);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(902, 440);
            customerPanel.TabIndex = 3;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 506);
            Controls.Add(customerPanel);
            Controls.Add(slideMenu);
            Controls.Add(panel1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            slideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox searchBox;
        private PictureBox pictureBox1;
        private Button searchBtn;
        private Button profileBtn;
        private Label label1;
        private Button addtoCart;
        private Panel slideMenu;
        private Panel customerPanel;
        private Button marketPlace;
        private Button purchaseHistory;
        private Button addToCart;
        private Button logOut;
    }
}