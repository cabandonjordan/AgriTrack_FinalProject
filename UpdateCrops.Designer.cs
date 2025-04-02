namespace AgriTrack_FinalProject
{
    partial class UpdateCrops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCrops));
            upCropCategory = new ReaLTaiizor.Controls.PoisonComboBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            updatePrice = new TextBox();
            updateQuant = new TextBox();
            label1 = new Label();
            upCropName = new TextBox();
            uploadPic = new Button();
            updateImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)updateImage).BeginInit();
            SuspendLayout();
            // 
            // upCropCategory
            // 
            upCropCategory.FormattingEnabled = true;
            upCropCategory.ItemHeight = 23;
            upCropCategory.Items.AddRange(new object[] { "Vegetable", "Fruits", "Root Crops", "Grains", "Legumes" });
            upCropCategory.Location = new Point(30, 391);
            upCropCategory.Name = "upCropCategory";
            upCropCategory.PromptText = "Crop";
            upCropCategory.Size = new Size(206, 29);
            upCropCategory.TabIndex = 36;
            upCropCategory.Text = "Crop";
            upCropCategory.UseSelectable = true;
            // 
            // saveBtn
            // 
            saveBtn.AutoEllipsis = true;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(12, 458);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(121, 37);
            saveBtn.TabIndex = 35;
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
            cancelBtn.Location = new Point(152, 458);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(121, 37);
            cancelBtn.TabIndex = 34;
            cancelBtn.Text = "     Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 367);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 33;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 311);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 32;
            label3.Text = "Price / Kilo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 255);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 31;
            label2.Text = "Quantity";
            // 
            // updatePrice
            // 
            updatePrice.Font = new Font("Segoe UI", 12F);
            updatePrice.Location = new Point(30, 335);
            updatePrice.Name = "updatePrice";
            updatePrice.Size = new Size(206, 29);
            updatePrice.TabIndex = 30;
            // 
            // updateQuant
            // 
            updateQuant.Font = new Font("Segoe UI", 12F);
            updateQuant.Location = new Point(30, 279);
            updateQuant.Name = "updateQuant";
            updateQuant.Size = new Size(206, 29);
            updateQuant.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 199);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 28;
            label1.Text = "Crop Name";
            // 
            // upCropName
            // 
            upCropName.Font = new Font("Segoe UI", 12F);
            upCropName.Location = new Point(30, 223);
            upCropName.Name = "upCropName";
            upCropName.Size = new Size(206, 29);
            upCropName.TabIndex = 27;
            // 
            // uploadPic
            // 
            uploadPic.AutoEllipsis = true;
            uploadPic.FlatStyle = FlatStyle.Flat;
            uploadPic.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadPic.Image = (Image)resources.GetObject("uploadPic.Image");
            uploadPic.ImageAlign = ContentAlignment.MiddleLeft;
            uploadPic.Location = new Point(75, 154);
            uploadPic.Name = "uploadPic";
            uploadPic.Size = new Size(121, 37);
            uploadPic.TabIndex = 26;
            uploadPic.Text = "     Upload";
            uploadPic.UseVisualStyleBackColor = true;
            uploadPic.Click += uploadPic_Click;
            // 
            // updateImage
            // 
            updateImage.BackColor = SystemColors.ActiveBorder;
            updateImage.Image = (Image)resources.GetObject("updateImage.Image");
            updateImage.Location = new Point(64, 18);
            updateImage.Name = "updateImage";
            updateImage.Size = new Size(144, 129);
            updateImage.SizeMode = PictureBoxSizeMode.Zoom;
            updateImage.TabIndex = 25;
            updateImage.TabStop = false;
            // 
            // UpdateCrops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 513);
            Controls.Add(upCropCategory);
            Controls.Add(saveBtn);
            Controls.Add(cancelBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(updatePrice);
            Controls.Add(updateQuant);
            Controls.Add(label1);
            Controls.Add(upCropName);
            Controls.Add(uploadPic);
            Controls.Add(updateImage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCrops";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCrops";
            ((System.ComponentModel.ISupportInitialize)updateImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonComboBox upCropCategory;
        private Button saveBtn;
        private Button cancelBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox updatePrice;
        private TextBox updateQuant;
        private Label label1;
        private TextBox upCropName;
        private Button uploadPic;
        private PictureBox updateImage;
    }
}