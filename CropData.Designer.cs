namespace AgriTrack_FinalProject
{
    partial class CropData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropData));
            cropImage = new PictureBox();
            deleteBtn = new Button();
            cropName = new Label();
            quantity = new Label();
            price = new Label();
            category = new Label();
            farmersName = new Label();
            editBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.BorderStyle = BorderStyle.FixedSingle;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(64, 29);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(172, 138);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 0;
            cropImage.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(243, 365);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(47, 37);
            deleteBtn.TabIndex = 2;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cropName
            // 
            cropName.AutoSize = true;
            cropName.BackColor = Color.White;
            cropName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropName.Location = new Point(34, 198);
            cropName.Name = "cropName";
            cropName.Size = new Size(53, 21);
            cropName.TabIndex = 8;
            cropName.Text = "name";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.White;
            quantity.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.Location = new Point(34, 226);
            quantity.Name = "quantity";
            quantity.Size = new Size(56, 21);
            quantity.TabIndex = 9;
            quantity.Text = "quant";
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.White;
            price.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(34, 258);
            price.Name = "price";
            price.Size = new Size(49, 21);
            price.TabIndex = 10;
            price.Text = "price";
            // 
            // category
            // 
            category.AutoSize = true;
            category.BackColor = Color.White;
            category.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.Location = new Point(34, 288);
            category.Name = "category";
            category.Size = new Size(79, 21);
            category.TabIndex = 11;
            category.Text = "category";
            // 
            // farmersName
            // 
            farmersName.AutoSize = true;
            farmersName.BackColor = Color.White;
            farmersName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            farmersName.Location = new Point(34, 317);
            farmersName.Name = "farmersName";
            farmersName.Size = new Size(53, 21);
            farmersName.TabIndex = 12;
            farmersName.Text = "name";
            // 
            // editBtn
            // 
            editBtn.FlatAppearance.BorderSize = 2;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.Location = new Point(3, 365);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(47, 37);
            editBtn.TabIndex = 13;
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // CropData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(editBtn);
            Controls.Add(farmersName);
            Controls.Add(category);
            Controls.Add(price);
            Controls.Add(quantity);
            Controls.Add(cropName);
            Controls.Add(deleteBtn);
            Controls.Add(cropImage);
            Name = "CropData";
            Size = new Size(293, 405);
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cropImage;
        private Button deleteBtn;
        private Label cropName;
        private Label quantity;
        private Label price;
        private Label category;
        private Label farmersName;
        private Button editBtn;
    }
}
