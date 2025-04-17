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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            cropImage = new PictureBox();
            cropName = new Label();
            addCart = new Button();
            stock = new Label();
            numericUpDown1 = new NumericUpDown();
            price = new Label();
            Quantity = new Label();
            cancelBtn = new Button();
            categories = new Label();
            nameFarner = new Label();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(73, 12);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(214, 196);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 0;
            cropImage.TabStop = false;
            // 
            // cropName
            // 
            cropName.AutoSize = true;
            cropName.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropName.Location = new Point(110, 211);
            cropName.Name = "cropName";
            cropName.Size = new Size(144, 32);
            cropName.TabIndex = 1;
            cropName.Text = "Crop Name";
            // 
            // addCart
            // 
            addCart.FlatStyle = FlatStyle.Flat;
            addCart.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCart.Image = (Image)resources.GetObject("addCart.Image");
            addCart.ImageAlign = ContentAlignment.MiddleLeft;
            addCart.Location = new Point(73, 472);
            addCart.Name = "addCart";
            addCart.Size = new Size(214, 43);
            addCart.TabIndex = 2;
            addCart.Text = "Add to Cart";
            addCart.UseVisualStyleBackColor = true;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stock.Location = new Point(73, 266);
            stock.Name = "stock";
            stock.Size = new Size(62, 25);
            stock.TabIndex = 3;
            stock.Text = "Stock";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(201, 425);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(86, 29);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(73, 305);
            price.Name = "price";
            price.Size = new Size(56, 25);
            price.TabIndex = 5;
            price.Text = "Price";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantity.Location = new Point(73, 425);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(89, 25);
            Quantity.TabIndex = 6;
            Quantity.Text = "Quantity";
            // 
            // cancelBtn
            // 
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(73, 521);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(214, 43);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // categories
            // 
            categories.AutoSize = true;
            categories.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categories.Location = new Point(73, 342);
            categories.Name = "categories";
            categories.Size = new Size(94, 25);
            categories.TabIndex = 8;
            categories.Text = "Category";
            // 
            // nameFarner
            // 
            nameFarner.AutoSize = true;
            nameFarner.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameFarner.Location = new Point(73, 384);
            nameFarner.Name = "nameFarner";
            nameFarner.Size = new Size(74, 25);
            nameFarner.TabIndex = 9;
            nameFarner.Text = "Farmer";
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 576);
            Controls.Add(nameFarner);
            Controls.Add(categories);
            Controls.Add(cancelBtn);
            Controls.Add(Quantity);
            Controls.Add(price);
            Controls.Add(numericUpDown1);
            Controls.Add(stock);
            Controls.Add(addCart);
            Controls.Add(cropName);
            Controls.Add(cropImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddToCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddToCart";
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cropImage;
        private Label cropName;
        private Button addCart;
        private Label stock;
        private NumericUpDown numericUpDown1;
        private Label price;
        private Label Quantity;
        private Button cancelBtn;
        private Label categories;
        private Label nameFarner;
    }
}