namespace AgriTrack_FinalProject
{
    partial class forAddCrops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forAddCrops));
            cropCategory = new ReaLTaiizor.Controls.PoisonComboBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            priceKilo = new TextBox();
            quantityTxt = new TextBox();
            cropName = new TextBox();
            uploadPic = new Button();
            cropImage = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // cropCategory
            // 
            cropCategory.FormattingEnabled = true;
            cropCategory.ItemHeight = 23;
            cropCategory.Items.AddRange(new object[] { "Vegetable", "Fruits", "Root Crops", "Grains", "Legumes" });
            cropCategory.Location = new Point(30, 395);
            cropCategory.Name = "cropCategory";
            cropCategory.PromptText = "Crop";
            cropCategory.Size = new Size(206, 29);
            cropCategory.TabIndex = 24;
            cropCategory.Text = "Crop";
            cropCategory.UseSelectable = true;
            // 
            // saveBtn
            // 
            saveBtn.AutoEllipsis = true;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(12, 462);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(121, 37);
            saveBtn.TabIndex = 23;
            saveBtn.Text = "     Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoEllipsis = true;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Image = (Image)resources.GetObject("cancelBtn.Image");
            cancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelBtn.Location = new Point(152, 462);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(121, 37);
            cancelBtn.TabIndex = 22;
            cancelBtn.Text = "     Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 371);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 21;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 315);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 20;
            label3.Text = "Price / Kilo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 259);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 19;
            label2.Text = "Quantity";
            // 
            // priceKilo
            // 
            priceKilo.Font = new Font("Segoe UI", 12F);
            priceKilo.Location = new Point(30, 339);
            priceKilo.Name = "priceKilo";
            priceKilo.Size = new Size(206, 29);
            priceKilo.TabIndex = 18;
            // 
            // quantityTxt
            // 
            quantityTxt.Font = new Font("Segoe UI", 12F);
            quantityTxt.Location = new Point(30, 283);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(206, 29);
            quantityTxt.TabIndex = 17;
            // 
            // cropName
            // 
            cropName.Font = new Font("Segoe UI", 12F);
            cropName.Location = new Point(30, 227);
            cropName.Name = "cropName";
            cropName.Size = new Size(206, 29);
            cropName.TabIndex = 15;
            // 
            // uploadPic
            // 
            uploadPic.AutoEllipsis = true;
            uploadPic.FlatStyle = FlatStyle.Flat;
            uploadPic.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadPic.Image = (Image)resources.GetObject("uploadPic.Image");
            uploadPic.ImageAlign = ContentAlignment.MiddleLeft;
            uploadPic.Location = new Point(75, 158);
            uploadPic.Name = "uploadPic";
            uploadPic.Size = new Size(121, 37);
            uploadPic.TabIndex = 14;
            uploadPic.Text = "     Upload";
            uploadPic.UseVisualStyleBackColor = true;
            uploadPic.Click += uploadPic_Click;
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(64, 22);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(144, 129);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 13;
            cropImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 203);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 16;
            label1.Text = "Crop Name";
            // 
            // forAddCrops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 513);
            Controls.Add(cropCategory);
            Controls.Add(saveBtn);
            Controls.Add(cancelBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priceKilo);
            Controls.Add(quantityTxt);
            Controls.Add(label1);
            Controls.Add(cropName);
            Controls.Add(uploadPic);
            Controls.Add(cropImage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forAddCrops";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forAddCrops";
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonComboBox cropCategory;
        private Button saveBtn;
        private Button cancelBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox priceKilo;
        private TextBox quantityTxt;
        private TextBox cropName;
        private Button uploadPic;
        private PictureBox cropImage;
        private Label label1;
    }
}