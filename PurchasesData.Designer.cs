namespace AgriTrack_FinalProject
{
    partial class PurchasesData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesData));
            payMethod = new Label();
            categorys = new Label();
            datePending = new Label();
            totalPrice = new Label();
            statuses = new Label();
            cropsName = new Label();
            addedQuant = new Label();
            cropImage = new PictureBox();
            nameFarmer = new Label();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // payMethod
            // 
            payMethod.AutoSize = true;
            payMethod.BackColor = Color.LightGray;
            payMethod.Font = new Font("Segoe UI", 12.75F);
            payMethod.Location = new Point(25, 355);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(76, 23);
            payMethod.TabIndex = 19;
            payMethod.Text = "Payment";
            // 
            // categorys
            // 
            categorys.AutoSize = true;
            categorys.BackColor = Color.LightGray;
            categorys.Font = new Font("Segoe UI", 12.75F);
            categorys.Location = new Point(25, 276);
            categorys.Name = "categorys";
            categorys.Size = new Size(79, 23);
            categorys.TabIndex = 18;
            categorys.Text = "Category";
            // 
            // datePending
            // 
            datePending.AutoSize = true;
            datePending.BackColor = Color.LightGray;
            datePending.Font = new Font("Segoe UI", 12.75F);
            datePending.Location = new Point(25, 395);
            datePending.Name = "datePending";
            datePending.Size = new Size(46, 23);
            datePending.TabIndex = 17;
            datePending.Text = "Date";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.BackColor = Color.LightGray;
            totalPrice.Font = new Font("Segoe UI", 12.75F);
            totalPrice.Location = new Point(25, 470);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(46, 23);
            totalPrice.TabIndex = 16;
            totalPrice.Text = "Total";
            // 
            // statuses
            // 
            statuses.AutoSize = true;
            statuses.BackColor = Color.LightGray;
            statuses.Font = new Font("Segoe UI", 12.75F);
            statuses.Location = new Point(25, 431);
            statuses.Name = "statuses";
            statuses.Size = new Size(56, 23);
            statuses.TabIndex = 15;
            statuses.Text = "Status";
            // 
            // cropsName
            // 
            cropsName.AutoSize = true;
            cropsName.BackColor = Color.LightGray;
            cropsName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cropsName.Location = new Point(84, 213);
            cropsName.Name = "cropsName";
            cropsName.Size = new Size(119, 30);
            cropsName.TabIndex = 13;
            cropsName.Text = "Crop Name";
            // 
            // addedQuant
            // 
            addedQuant.AutoSize = true;
            addedQuant.BackColor = Color.LightGray;
            addedQuant.Font = new Font("Segoe UI", 12.75F);
            addedQuant.Location = new Point(25, 316);
            addedQuant.Name = "addedQuant";
            addedQuant.Size = new Size(76, 23);
            addedQuant.TabIndex = 12;
            addedQuant.Text = "Quantity";
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(59, 53);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(174, 157);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 11;
            cropImage.TabStop = false;
            // 
            // nameFarmer
            // 
            nameFarmer.AutoSize = true;
            nameFarmer.BackColor = Color.LightGray;
            nameFarmer.Font = new Font("Segoe UI", 12.75F);
            nameFarmer.Location = new Point(12, 11);
            nameFarmer.Name = "nameFarmer";
            nameFarmer.Size = new Size(69, 23);
            nameFarmer.TabIndex = 20;
            nameFarmer.Text = "Farmers";
            // 
            // PurchasesData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(nameFarmer);
            Controls.Add(payMethod);
            Controls.Add(categorys);
            Controls.Add(datePending);
            Controls.Add(totalPrice);
            Controls.Add(statuses);
            Controls.Add(cropsName);
            Controls.Add(addedQuant);
            Controls.Add(cropImage);
            Name = "PurchasesData";
            Size = new Size(302, 515);
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label payMethod;
        private Label categorys;
        private Label datePending;
        private Label totalPrice;
        private Label statuses;
        private Label cropsName;
        private Label addedQuant;
        private PictureBox cropImage;
        private Label nameFarmer;
    }
}
