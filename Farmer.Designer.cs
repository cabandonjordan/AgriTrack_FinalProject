namespace AgriTrack_FinalProject
{
    partial class Farmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmer));
            topPanel = new Panel();
            weatherImage = new PictureBox();
            temperature = new Label();
            statusWeather = new Label();
            label1 = new Label();
            profileBtn = new Button();
            searchBtn = new Button();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            sideMenu = new Panel();
            pendingOrders = new Button();
            logOut = new Button();
            saleHistory = new Button();
            myCrops = new Button();
            homeBtn = new Button();
            farmerPanel = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weatherImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.BackgroundImage = (Image)resources.GetObject("topPanel.BackgroundImage");
            topPanel.BackgroundImageLayout = ImageLayout.Stretch;
            topPanel.Controls.Add(weatherImage);
            topPanel.Controls.Add(temperature);
            topPanel.Controls.Add(statusWeather);
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(profileBtn);
            topPanel.Controls.Add(searchBtn);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(searchBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1072, 66);
            topPanel.TabIndex = 1;
            // 
            // weatherImage
            // 
            weatherImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            weatherImage.BackColor = Color.Transparent;
            weatherImage.Location = new Point(897, 9);
            weatherImage.Name = "weatherImage";
            weatherImage.Size = new Size(95, 50);
            weatherImage.SizeMode = PictureBoxSizeMode.Zoom;
            weatherImage.TabIndex = 6;
            weatherImage.TabStop = false;
            // 
            // temperature
            // 
            temperature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            temperature.AutoSize = true;
            temperature.BackColor = Color.Transparent;
            temperature.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            temperature.Location = new Point(680, 38);
            temperature.Name = "temperature";
            temperature.Size = new Size(58, 21);
            temperature.TabIndex = 5;
            temperature.Text = "label3";
            // 
            // statusWeather
            // 
            statusWeather.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusWeather.AutoSize = true;
            statusWeather.BackColor = Color.Transparent;
            statusWeather.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            statusWeather.Location = new Point(680, 9);
            statusWeather.Name = "statusWeather";
            statusWeather.Size = new Size(58, 21);
            statusWeather.TabIndex = 4;
            statusWeather.Text = "label2";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(1013, 48);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // profileBtn
            // 
            profileBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            profileBtn.BackColor = Color.Transparent;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Image = (Image)resources.GetObject("profileBtn.Image");
            profileBtn.Location = new Point(1007, 10);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(53, 35);
            profileBtn.TabIndex = 3;
            profileBtn.UseVisualStyleBackColor = false;
            profileBtn.Click += profileBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Left;
            searchBtn.BackColor = Color.Transparent;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(632, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(42, 35);
            searchBtn.TabIndex = 2;
            searchBtn.TextAlign = ContentAlignment.MiddleRight;
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Left;
            searchBox.BackColor = SystemColors.Control;
            searchBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(176, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(450, 35);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // sideMenu
            // 
            sideMenu.BackgroundImage = (Image)resources.GetObject("sideMenu.BackgroundImage");
            sideMenu.BackgroundImageLayout = ImageLayout.Stretch;
            sideMenu.Controls.Add(pendingOrders);
            sideMenu.Controls.Add(logOut);
            sideMenu.Controls.Add(saleHistory);
            sideMenu.Controls.Add(myCrops);
            sideMenu.Controls.Add(homeBtn);
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Location = new Point(0, 66);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(170, 440);
            sideMenu.TabIndex = 2;
            // 
            // pendingOrders
            // 
            pendingOrders.Dock = DockStyle.Top;
            pendingOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingOrders.Image = (Image)resources.GetObject("pendingOrders.Image");
            pendingOrders.ImageAlign = ContentAlignment.MiddleLeft;
            pendingOrders.Location = new Point(0, 186);
            pendingOrders.Name = "pendingOrders";
            pendingOrders.Size = new Size(170, 62);
            pendingOrders.TabIndex = 7;
            pendingOrders.Text = "Orders";
            pendingOrders.UseVisualStyleBackColor = true;
            pendingOrders.Click += pendingOrders_Click;
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
            logOut.TabIndex = 6;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = true;
            logOut.Click += logOut_Click;
            // 
            // saleHistory
            // 
            saleHistory.Dock = DockStyle.Top;
            saleHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saleHistory.Image = (Image)resources.GetObject("saleHistory.Image");
            saleHistory.ImageAlign = ContentAlignment.MiddleLeft;
            saleHistory.Location = new Point(0, 124);
            saleHistory.Name = "saleHistory";
            saleHistory.Size = new Size(170, 62);
            saleHistory.TabIndex = 2;
            saleHistory.Text = "  Sale History";
            saleHistory.UseVisualStyleBackColor = true;
            saleHistory.Click += saleHistory_Click;
            // 
            // myCrops
            // 
            myCrops.Dock = DockStyle.Top;
            myCrops.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myCrops.Image = (Image)resources.GetObject("myCrops.Image");
            myCrops.ImageAlign = ContentAlignment.MiddleLeft;
            myCrops.Location = new Point(0, 62);
            myCrops.Name = "myCrops";
            myCrops.Size = new Size(170, 62);
            myCrops.TabIndex = 1;
            myCrops.Text = "My Crops";
            myCrops.UseVisualStyleBackColor = true;
            myCrops.Click += myCrops_Click;
            // 
            // homeBtn
            // 
            homeBtn.Dock = DockStyle.Top;
            homeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 0);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(170, 62);
            homeBtn.TabIndex = 0;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // farmerPanel
            // 
            farmerPanel.AutoScroll = true;
            farmerPanel.BackgroundImage = (Image)resources.GetObject("farmerPanel.BackgroundImage");
            farmerPanel.BackgroundImageLayout = ImageLayout.Stretch;
            farmerPanel.Dock = DockStyle.Fill;
            farmerPanel.Location = new Point(170, 66);
            farmerPanel.Name = "farmerPanel";
            farmerPanel.Size = new Size(902, 440);
            farmerPanel.TabIndex = 3;
            // 
            // Farmer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 506);
            Controls.Add(farmerPanel);
            Controls.Add(sideMenu);
            Controls.Add(topPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Farmer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weatherImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Button profileBtn;
        private Button searchBtn;
        private PictureBox pictureBox1;
        private TextBox searchBox;
        private Panel sideMenu;
        private Button homeBtn;
        private Button saleHistory;
        private Button myCrops;
        private Label label1;
        private Panel farmerPanel;
        private Button logOut;
        private Button pendingOrders;
        private PictureBox weatherImage;
        private Label temperature;
        private Label statusWeather;
    }
}