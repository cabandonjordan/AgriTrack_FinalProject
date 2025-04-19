namespace AgriTrack_FinalProject
{
    partial class ProductsOrdered
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsOrdered));
            cropName = new Label();
            TotPrice = new Label();
            label13 = new Label();
            label11 = new Label();
            shippingFee = new Label();
            addedQuant = new Label();
            cropPrice = new Label();
            subTotal = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cropImage = new PictureBox();
            label4 = new Label();
            FarmerName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // cropName
            // 
            cropName.AutoSize = true;
            cropName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropName.ForeColor = Color.Green;
            cropName.Location = new Point(160, 77);
            cropName.Name = "cropName";
            cropName.Size = new Size(97, 21);
            cropName.TabIndex = 34;
            cropName.Text = "Crop Name";
            // 
            // TotPrice
            // 
            TotPrice.AutoSize = true;
            TotPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotPrice.ForeColor = Color.Black;
            TotPrice.Location = new Point(923, 118);
            TotPrice.Name = "TotPrice";
            TotPrice.Size = new Size(78, 32);
            TotPrice.TabIndex = 33;
            TotPrice.Text = "₱0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(812, 126);
            label13.Name = "label13";
            label13.Size = new Size(105, 21);
            label13.TabIndex = 32;
            label13.Text = "Order Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(401, 113);
            label11.Name = "label11";
            label11.Size = new Size(115, 21);
            label11.TabIndex = 31;
            label11.Text = "Shipping Fee:";
            // 
            // shippingFee
            // 
            shippingFee.AutoSize = true;
            shippingFee.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shippingFee.ForeColor = Color.Green;
            shippingFee.Location = new Point(522, 113);
            shippingFee.Name = "shippingFee";
            shippingFee.Size = new Size(67, 21);
            shippingFee.TabIndex = 30;
            shippingFee.Text = "₱50.00";
            // 
            // addedQuant
            // 
            addedQuant.AutoSize = true;
            addedQuant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addedQuant.ForeColor = Color.Green;
            addedQuant.Location = new Point(695, 54);
            addedQuant.Name = "addedQuant";
            addedQuant.Size = new Size(45, 21);
            addedQuant.TabIndex = 28;
            addedQuant.Text = "0.00";
            // 
            // cropPrice
            // 
            cropPrice.AutoSize = true;
            cropPrice.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropPrice.ForeColor = Color.Green;
            cropPrice.Location = new Point(398, 54);
            cropPrice.Name = "cropPrice";
            cropPrice.Size = new Size(57, 21);
            cropPrice.TabIndex = 27;
            cropPrice.Text = "₱0.00";
            // 
            // subTotal
            // 
            subTotal.AutoSize = true;
            subTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotal.ForeColor = Color.Green;
            subTotal.Location = new Point(980, 54);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(57, 21);
            subTotal.TabIndex = 29;
            subTotal.Text = "₱0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(950, 10);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 26;
            label7.Text = "Item Subtotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(680, 10);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 25;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(401, 10);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 24;
            label5.Text = "Price";
            // 
            // cropImage
            // 
            cropImage.BackColor = Color.DarkGray;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(6, 46);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(148, 88);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 22;
            cropImage.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(7, 10);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 23;
            label4.Text = "Products Ordered";
            // 
            // FarmerName
            // 
            FarmerName.AutoSize = true;
            FarmerName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FarmerName.ForeColor = Color.Green;
            FarmerName.Location = new Point(160, 46);
            FarmerName.Name = "FarmerName";
            FarmerName.Size = new Size(124, 21);
            FarmerName.TabIndex = 35;
            FarmerName.Text = "Farmers Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 10);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1074, 10);
            panel2.TabIndex = 37;
            // 
            // ProductsOrdered
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(FarmerName);
            Controls.Add(cropName);
            Controls.Add(TotPrice);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(shippingFee);
            Controls.Add(addedQuant);
            Controls.Add(cropPrice);
            Controls.Add(subTotal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cropImage);
            Controls.Add(label4);
            Name = "ProductsOrdered";
            Size = new Size(1074, 160);
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cropName;
        private Label TotPrice;
        private Label label13;
        private Label label11;
        private Label shippingFee;
        private Label addedQuant;
        private Label cropPrice;
        private Label subTotal;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox cropImage;
        private Label label4;
        private Label FarmerName;
        private Panel panel1;
        private Panel panel2;
    }
}
