namespace AgriTrack_FinalProject
{
    partial class OrdersData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersData));
            cropImage = new PictureBox();
            confirmBtn = new Button();
            addedQuant = new Label();
            declineBtn = new Button();
            cropsName = new Label();
            customerNames = new Label();
            statuses = new Label();
            totalPrice = new Label();
            datePending = new Label();
            categorys = new Label();
            payMethod = new Label();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // cropImage
            // 
            cropImage.BackColor = SystemColors.ActiveBorder;
            cropImage.BorderStyle = BorderStyle.FixedSingle;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(54, 53);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(188, 179);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 0;
            cropImage.TabStop = false;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(106, 153, 78);
            confirmBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            confirmBtn.FlatAppearance.BorderSize = 2;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            confirmBtn.Location = new Point(170, 514);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(103, 38);
            confirmBtn.TabIndex = 1;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // addedQuant
            // 
            addedQuant.AutoSize = true;
            addedQuant.BackColor = Color.LightGray;
            addedQuant.Font = new Font("Segoe UI", 12.75F);
            addedQuant.ForeColor = Color.FromArgb(28, 93, 61);
            addedQuant.Location = new Point(19, 320);
            addedQuant.Name = "addedQuant";
            addedQuant.Size = new Size(76, 23);
            addedQuant.TabIndex = 2;
            addedQuant.Text = "Quantity";
            // 
            // declineBtn
            // 
            declineBtn.BackColor = Color.Firebrick;
            declineBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            declineBtn.FlatAppearance.BorderSize = 2;
            declineBtn.FlatStyle = FlatStyle.Flat;
            declineBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            declineBtn.Location = new Point(19, 514);
            declineBtn.Name = "declineBtn";
            declineBtn.Size = new Size(103, 38);
            declineBtn.TabIndex = 3;
            declineBtn.Text = "Decline";
            declineBtn.UseVisualStyleBackColor = false;
            declineBtn.Click += declineBtn_Click;
            // 
            // cropsName
            // 
            cropsName.AutoSize = true;
            cropsName.BackColor = Color.LightGray;
            cropsName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cropsName.ForeColor = Color.ForestGreen;
            cropsName.Location = new Point(86, 235);
            cropsName.Name = "cropsName";
            cropsName.Size = new Size(119, 30);
            cropsName.TabIndex = 4;
            cropsName.Text = "Crop Name";
            // 
            // customerNames
            // 
            customerNames.AutoSize = true;
            customerNames.BackColor = Color.LightGray;
            customerNames.Font = new Font("Segoe UI", 12.75F);
            customerNames.ForeColor = Color.FromArgb(28, 93, 61);
            customerNames.Location = new Point(31, 17);
            customerNames.Name = "customerNames";
            customerNames.Size = new Size(56, 23);
            customerNames.TabIndex = 5;
            customerNames.Text = "Name";
            // 
            // statuses
            // 
            statuses.AutoSize = true;
            statuses.BackColor = Color.LightGray;
            statuses.Font = new Font("Segoe UI", 12.75F);
            statuses.ForeColor = Color.FromArgb(28, 93, 61);
            statuses.Location = new Point(19, 431);
            statuses.Name = "statuses";
            statuses.Size = new Size(56, 23);
            statuses.TabIndex = 6;
            statuses.Text = "Status";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.BackColor = Color.LightGray;
            totalPrice.Font = new Font("Segoe UI", 12.75F);
            totalPrice.ForeColor = Color.FromArgb(28, 93, 61);
            totalPrice.Location = new Point(19, 469);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(46, 23);
            totalPrice.TabIndex = 7;
            totalPrice.Text = "Total";
            // 
            // datePending
            // 
            datePending.AutoSize = true;
            datePending.BackColor = Color.LightGray;
            datePending.Font = new Font("Segoe UI", 12.75F);
            datePending.ForeColor = Color.FromArgb(28, 93, 61);
            datePending.Location = new Point(19, 394);
            datePending.Name = "datePending";
            datePending.Size = new Size(46, 23);
            datePending.TabIndex = 8;
            datePending.Text = "Date";
            // 
            // categorys
            // 
            categorys.AutoSize = true;
            categorys.BackColor = Color.LightGray;
            categorys.Font = new Font("Segoe UI", 12.75F);
            categorys.ForeColor = Color.FromArgb(28, 93, 61);
            categorys.Location = new Point(19, 278);
            categorys.Name = "categorys";
            categorys.Size = new Size(79, 23);
            categorys.TabIndex = 9;
            categorys.Text = "Category";
            // 
            // payMethod
            // 
            payMethod.AutoSize = true;
            payMethod.BackColor = Color.LightGray;
            payMethod.Font = new Font("Segoe UI", 12.75F);
            payMethod.ForeColor = Color.FromArgb(28, 93, 61);
            payMethod.Location = new Point(19, 358);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(76, 23);
            payMethod.TabIndex = 10;
            payMethod.Text = "Payment";
            // 
            // OrdersData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 245, 225);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(payMethod);
            Controls.Add(categorys);
            Controls.Add(datePending);
            Controls.Add(totalPrice);
            Controls.Add(statuses);
            Controls.Add(customerNames);
            Controls.Add(cropsName);
            Controls.Add(declineBtn);
            Controls.Add(addedQuant);
            Controls.Add(confirmBtn);
            Controls.Add(cropImage);
            Name = "OrdersData";
            Size = new Size(300, 565);
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cropImage;
        private Button confirmBtn;
        private Label addedQuant;
        private Button declineBtn;
        private Label cropsName;
        private Label customerNames;
        private Label statuses;
        private Label totalPrice;
        private Label datePending;
        private Label categorys;
        private Label payMethod;
    }
}
