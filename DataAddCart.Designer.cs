namespace AgriTrack_FinalProject
{
    partial class DataAddCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAddCart));
            cropImage = new PictureBox();
            checkBox = new CheckBox();
            nameCrop = new Label();
            checkOut = new Button();
            stock = new Label();
            price = new Label();
            category = new Label();
            addedQuant = new NumericUpDown();
            quantity = new Label();
            nameFarmer = new Label();
            deleteBtn = new Button();
            totalPrices = new Label();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addedQuant).BeginInit();
            SuspendLayout();
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveCaption;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(46, 43);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(185, 150);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 1;
            cropImage.TabStop = false;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(269, 13);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(15, 14);
            checkBox.TabIndex = 2;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // nameCrop
            // 
            nameCrop.AutoSize = true;
            nameCrop.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameCrop.Location = new Point(76, 196);
            nameCrop.Name = "nameCrop";
            nameCrop.Size = new Size(127, 30);
            nameCrop.TabIndex = 3;
            nameCrop.Text = "CropNAME";
            // 
            // checkOut
            // 
            checkOut.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOut.Location = new Point(3, 451);
            checkOut.Name = "checkOut";
            checkOut.Size = new Size(128, 38);
            checkOut.TabIndex = 4;
            checkOut.Text = "Check Out";
            checkOut.UseVisualStyleBackColor = true;
            checkOut.Click += checkOut_Click;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stock.Location = new Point(42, 245);
            stock.Name = "stock";
            stock.Size = new Size(53, 21);
            stock.TabIndex = 5;
            stock.Text = "Stock";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(42, 277);
            price.Name = "price";
            price.Size = new Size(49, 21);
            price.TabIndex = 6;
            price.Text = "Price";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.Location = new Point(42, 304);
            category.Name = "category";
            category.Size = new Size(81, 21);
            category.TabIndex = 7;
            category.Text = "Category";
            // 
            // addedQuant
            // 
            addedQuant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addedQuant.Location = new Point(156, 373);
            addedQuant.Name = "addedQuant";
            addedQuant.ReadOnly = true;
            addedQuant.Size = new Size(86, 29);
            addedQuant.TabIndex = 8;
            addedQuant.TextAlign = HorizontalAlignment.Center;
            addedQuant.ValueChanged += addedQuant_ValueChanged;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.Location = new Point(42, 375);
            quantity.Name = "quantity";
            quantity.Size = new Size(79, 21);
            quantity.TabIndex = 9;
            quantity.Text = "Quantity";
            // 
            // nameFarmer
            // 
            nameFarmer.AutoSize = true;
            nameFarmer.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameFarmer.Location = new Point(42, 338);
            nameFarmer.Name = "nameFarmer";
            nameFarmer.Size = new Size(74, 21);
            nameFarmer.TabIndex = 10;
            nameFarmer.Text = "Farmers";
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(156, 451);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(128, 38);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // totalPrices
            // 
            totalPrices.AutoSize = true;
            totalPrices.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPrices.Location = new Point(42, 415);
            totalPrices.Name = "totalPrices";
            totalPrices.Size = new Size(51, 21);
            totalPrices.TabIndex = 12;
            totalPrices.Text = "Total";
            // 
            // DataAddCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(totalPrices);
            Controls.Add(deleteBtn);
            Controls.Add(nameFarmer);
            Controls.Add(quantity);
            Controls.Add(addedQuant);
            Controls.Add(category);
            Controls.Add(price);
            Controls.Add(stock);
            Controls.Add(checkOut);
            Controls.Add(nameCrop);
            Controls.Add(checkBox);
            Controls.Add(cropImage);
            Name = "DataAddCart";
            Size = new Size(287, 505);
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)addedQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cropImage;
        private CheckBox checkBox;
        private Label nameCrop;
        private Button checkOut;
        private Label stock;
        private Label price;
        private Label category;
        private NumericUpDown addedQuant;
        private Label quantity;
        private Label nameFarmer;
        private Button deleteBtn;
        private Label totalPrices;
    }
}
