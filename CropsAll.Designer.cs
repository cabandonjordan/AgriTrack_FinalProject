namespace AgriTrack_FinalProject
{
    partial class CropsAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropsAll));
            farmersName = new Label();
            category = new Label();
            price = new Label();
            quantity = new Label();
            cropName = new Label();
            cropImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // farmersName
            // 
            farmersName.AutoSize = true;
            farmersName.BackColor = Color.White;
            farmersName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            farmersName.Location = new Point(45, 336);
            farmersName.Name = "farmersName";
            farmersName.Size = new Size(53, 21);
            farmersName.TabIndex = 18;
            farmersName.Text = "name";
            // 
            // category
            // 
            category.AutoSize = true;
            category.BackColor = Color.White;
            category.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.Location = new Point(45, 307);
            category.Name = "category";
            category.Size = new Size(79, 21);
            category.TabIndex = 17;
            category.Text = "category";
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.White;
            price.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(45, 277);
            price.Name = "price";
            price.Size = new Size(49, 21);
            price.TabIndex = 16;
            price.Text = "price";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.White;
            quantity.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.Location = new Point(45, 245);
            quantity.Name = "quantity";
            quantity.Size = new Size(56, 21);
            quantity.TabIndex = 15;
            quantity.Text = "quant";
            // 
            // cropName
            // 
            cropName.AutoSize = true;
            cropName.BackColor = Color.White;
            cropName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropName.Location = new Point(45, 217);
            cropName.Name = "cropName";
            cropName.Size = new Size(53, 21);
            cropName.TabIndex = 14;
            cropName.Text = "name";
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.BorderStyle = BorderStyle.FixedSingle;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(75, 48);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(172, 138);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 13;
            cropImage.TabStop = false;
            // 
            // CropsAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(farmersName);
            Controls.Add(category);
            Controls.Add(price);
            Controls.Add(quantity);
            Controls.Add(cropName);
            Controls.Add(cropImage);
            DoubleBuffered = true;
            Name = "CropsAll";
            Size = new Size(293, 405);
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
        private PictureBox cropImage;
    }
}
