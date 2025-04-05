namespace AgriTrack_FinalProject
{
    partial class CropBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropBuy));
            farmersName = new Label();
            category = new Label();
            price = new Label();
            quantity = new Label();
            cropName = new Label();
            buyNow = new Button();
            cropImage = new PictureBox();
            addToCart = new Button();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // farmersName
            // 
            farmersName.AutoSize = true;
            farmersName.BackColor = Color.White;
            farmersName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            farmersName.Location = new Point(33, 275);
            farmersName.Name = "farmersName";
            farmersName.Size = new Size(53, 21);
            farmersName.TabIndex = 20;
            farmersName.Text = "name";
            // 
            // category
            // 
            category.AutoSize = true;
            category.BackColor = Color.White;
            category.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.Location = new Point(33, 249);
            category.Name = "category";
            category.Size = new Size(79, 21);
            category.TabIndex = 19;
            category.Text = "category";
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.White;
            price.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(33, 223);
            price.Name = "price";
            price.Size = new Size(49, 21);
            price.TabIndex = 18;
            price.Text = "price";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.White;
            quantity.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.Location = new Point(33, 197);
            quantity.Name = "quantity";
            quantity.Size = new Size(56, 21);
            quantity.TabIndex = 17;
            quantity.Text = "quant";
            // 
            // cropName
            // 
            cropName.AutoSize = true;
            cropName.BackColor = Color.White;
            cropName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropName.Location = new Point(33, 171);
            cropName.Name = "cropName";
            cropName.Size = new Size(53, 21);
            cropName.TabIndex = 16;
            cropName.Text = "name";
            // 
            // buyNow
            // 
            buyNow.BackColor = Color.White;
            buyNow.FlatAppearance.BorderSize = 2;
            buyNow.FlatStyle = FlatStyle.Flat;
            buyNow.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyNow.ForeColor = Color.Black;
            buyNow.Location = new Point(33, 356);
            buyNow.Name = "buyNow";
            buyNow.Size = new Size(172, 37);
            buyNow.TabIndex = 15;
            buyNow.Text = "Buy Now";
            buyNow.UseVisualStyleBackColor = false;
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.BorderStyle = BorderStyle.FixedSingle;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(33, 29);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(172, 138);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 14;
            cropImage.TabStop = false;
            // 
            // addToCart
            // 
            addToCart.BackColor = Color.White;
            addToCart.FlatAppearance.BorderSize = 2;
            addToCart.FlatStyle = FlatStyle.Flat;
            addToCart.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToCart.ForeColor = Color.Black;
            addToCart.Image = (Image)resources.GetObject("addToCart.Image");
            addToCart.ImageAlign = ContentAlignment.MiddleLeft;
            addToCart.Location = new Point(33, 313);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(172, 37);
            addToCart.TabIndex = 21;
            addToCart.Text = "     Add To Cart";
            addToCart.UseVisualStyleBackColor = false;
            addToCart.Click += addToCart_Click;
            // 
            // CropBuy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(addToCart);
            Controls.Add(farmersName);
            Controls.Add(category);
            Controls.Add(price);
            Controls.Add(quantity);
            Controls.Add(cropName);
            Controls.Add(buyNow);
            Controls.Add(cropImage);
            Name = "CropBuy";
            Size = new Size(240, 405);
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label farmersName;
        private Label category;
        private Label price;
        private Label quantity;
        private Label cropName;
        private Button buyNow;
        private PictureBox cropImage;
        private Button addToCart;
    }
}
