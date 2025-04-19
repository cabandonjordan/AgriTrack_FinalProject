namespace AgriTrack_FinalProject
{
    partial class BuyNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyNow));
            deliveryAddress = new Panel();
            label1 = new Label();
            label2 = new Label();
            customerName = new Label();
            label3 = new Label();
            customerNum = new Label();
            addressTxt = new TextBox();
            gCash = new RadioButton();
            cashDelivery = new RadioButton();
            totPriceCrops = new Label();
            paymentMethod = new Panel();
            shipTotal = new Label();
            itemSubtotal = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            payMethod = new Panel();
            placeOrder = new Button();
            cancelBtn = new Button();
            label14 = new Label();
            panel1 = new Panel();
            productsOrderedPanel = new Panel();
            numericUpDown1 = new NumericUpDown();
            FarmerName = new Label();
            cropName = new Label();
            TotPrice = new Label();
            label13 = new Label();
            label11 = new Label();
            shippingFee = new Label();
            cropPrice = new Label();
            subTotal = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cropImage = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            deliveryAddress.SuspendLayout();
            paymentMethod.SuspendLayout();
            payMethod.SuspendLayout();
            productsOrderedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cropImage).BeginInit();
            SuspendLayout();
            // 
            // deliveryAddress
            // 
            deliveryAddress.Controls.Add(label1);
            deliveryAddress.Controls.Add(label2);
            deliveryAddress.Controls.Add(customerName);
            deliveryAddress.Controls.Add(label3);
            deliveryAddress.Controls.Add(customerNum);
            deliveryAddress.Controls.Add(addressTxt);
            deliveryAddress.Dock = DockStyle.Top;
            deliveryAddress.Location = new Point(0, 36);
            deliveryAddress.Name = "deliveryAddress";
            deliveryAddress.Size = new Size(1074, 100);
            deliveryAddress.TabIndex = 15;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 42);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(58, 9);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 2;
            label2.Text = "Delivery Address";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerName.ForeColor = Color.Green;
            customerName.Location = new Point(12, 60);
            customerName.Name = "customerName";
            customerName.Size = new Size(136, 21);
            customerName.TabIndex = 3;
            customerName.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(431, 21);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // customerNum
            // 
            customerNum.AutoSize = true;
            customerNum.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerNum.ForeColor = Color.Green;
            customerNum.Location = new Point(253, 60);
            customerNum.Name = "customerNum";
            customerNum.Size = new Size(74, 21);
            customerNum.TabIndex = 4;
            customerNum.Text = "Number";
            // 
            // addressTxt
            // 
            addressTxt.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressTxt.Location = new Point(431, 48);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(612, 33);
            addressTxt.TabIndex = 5;
            addressTxt.Text = "Carcar City";
            // 
            // gCash
            // 
            gCash.Appearance = Appearance.Button;
            gCash.AutoSize = true;
            gCash.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gCash.Image = (Image)resources.GetObject("gCash.Image");
            gCash.ImageAlign = ContentAlignment.MiddleLeft;
            gCash.Location = new Point(477, 7);
            gCash.Name = "gCash";
            gCash.Size = new Size(101, 38);
            gCash.TabIndex = 1;
            gCash.TabStop = true;
            gCash.Text = "        GCash";
            gCash.UseVisualStyleBackColor = true;
            // 
            // cashDelivery
            // 
            cashDelivery.Appearance = Appearance.Button;
            cashDelivery.AutoSize = true;
            cashDelivery.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashDelivery.Image = (Image)resources.GetObject("cashDelivery.Image");
            cashDelivery.ImageAlign = ContentAlignment.MiddleLeft;
            cashDelivery.Location = new Point(275, 8);
            cashDelivery.Name = "cashDelivery";
            cashDelivery.Size = new Size(186, 38);
            cashDelivery.TabIndex = 0;
            cashDelivery.TabStop = true;
            cashDelivery.Text = "         Cash on Delivery";
            cashDelivery.UseVisualStyleBackColor = true;
            // 
            // totPriceCrops
            // 
            totPriceCrops.AutoSize = true;
            totPriceCrops.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totPriceCrops.ForeColor = Color.Green;
            totPriceCrops.Location = new Point(946, 126);
            totPriceCrops.Name = "totPriceCrops";
            totPriceCrops.Size = new Size(75, 30);
            totPriceCrops.TabIndex = 26;
            totPriceCrops.Text = "₱0.00";
            // 
            // paymentMethod
            // 
            paymentMethod.Controls.Add(totPriceCrops);
            paymentMethod.Controls.Add(shipTotal);
            paymentMethod.Controls.Add(itemSubtotal);
            paymentMethod.Controls.Add(label12);
            paymentMethod.Controls.Add(label10);
            paymentMethod.Controls.Add(label8);
            paymentMethod.Controls.Add(payMethod);
            paymentMethod.Controls.Add(placeOrder);
            paymentMethod.Controls.Add(cancelBtn);
            paymentMethod.Controls.Add(label14);
            paymentMethod.Dock = DockStyle.Bottom;
            paymentMethod.Location = new Point(0, 415);
            paymentMethod.Name = "paymentMethod";
            paymentMethod.Size = new Size(1074, 210);
            paymentMethod.TabIndex = 14;
            // 
            // shipTotal
            // 
            shipTotal.AutoSize = true;
            shipTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shipTotal.ForeColor = Color.Green;
            shipTotal.Location = new Point(956, 101);
            shipTotal.Name = "shipTotal";
            shipTotal.Size = new Size(57, 21);
            shipTotal.TabIndex = 25;
            shipTotal.Text = "₱0.00";
            // 
            // itemSubtotal
            // 
            itemSubtotal.AutoSize = true;
            itemSubtotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemSubtotal.ForeColor = Color.Green;
            itemSubtotal.Location = new Point(964, 71);
            itemSubtotal.Name = "itemSubtotal";
            itemSubtotal.Size = new Size(57, 21);
            itemSubtotal.TabIndex = 24;
            itemSubtotal.Text = "₱0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(835, 71);
            label12.Name = "label12";
            label12.Size = new Size(123, 21);
            label12.TabIndex = 22;
            label12.Text = "Item Subtotal:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(835, 101);
            label10.Name = "label10";
            label10.Size = new Size(115, 21);
            label10.TabIndex = 22;
            label10.Text = "Shipping Fee:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(835, 133);
            label8.Name = "label8";
            label8.Size = new Size(105, 21);
            label8.TabIndex = 22;
            label8.Text = "Order Total:";
            // 
            // payMethod
            // 
            payMethod.Controls.Add(gCash);
            payMethod.Controls.Add(cashDelivery);
            payMethod.Location = new Point(479, 3);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(592, 52);
            payMethod.TabIndex = 10;
            // 
            // placeOrder
            // 
            placeOrder.FlatAppearance.BorderSize = 2;
            placeOrder.FlatStyle = FlatStyle.Flat;
            placeOrder.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeOrder.Image = (Image)resources.GetObject("placeOrder.Image");
            placeOrder.ImageAlign = ContentAlignment.MiddleLeft;
            placeOrder.Location = new Point(858, 163);
            placeOrder.Name = "placeOrder";
            placeOrder.Size = new Size(213, 44);
            placeOrder.TabIndex = 9;
            placeOrder.Text = "    Place Order";
            placeOrder.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(12, 163);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(113, 44);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Green;
            label14.Location = new Point(3, 9);
            label14.Name = "label14";
            label14.Size = new Size(192, 30);
            label14.TabIndex = 7;
            label14.Text = "Payment Method";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 36);
            panel1.TabIndex = 13;
            // 
            // productsOrderedPanel
            // 
            productsOrderedPanel.Controls.Add(numericUpDown1);
            productsOrderedPanel.Controls.Add(FarmerName);
            productsOrderedPanel.Controls.Add(cropName);
            productsOrderedPanel.Controls.Add(TotPrice);
            productsOrderedPanel.Controls.Add(label13);
            productsOrderedPanel.Controls.Add(label11);
            productsOrderedPanel.Controls.Add(shippingFee);
            productsOrderedPanel.Controls.Add(cropPrice);
            productsOrderedPanel.Controls.Add(subTotal);
            productsOrderedPanel.Controls.Add(label7);
            productsOrderedPanel.Controls.Add(label6);
            productsOrderedPanel.Controls.Add(label5);
            productsOrderedPanel.Controls.Add(cropImage);
            productsOrderedPanel.Controls.Add(label4);
            productsOrderedPanel.Controls.Add(panel3);
            productsOrderedPanel.Controls.Add(panel2);
            productsOrderedPanel.Dock = DockStyle.Fill;
            productsOrderedPanel.Location = new Point(0, 136);
            productsOrderedPanel.Name = "productsOrderedPanel";
            productsOrderedPanel.Size = new Size(1074, 279);
            productsOrderedPanel.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(676, 85);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 29);
            numericUpDown1.TabIndex = 50;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // FarmerName
            // 
            FarmerName.AutoSize = true;
            FarmerName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FarmerName.ForeColor = Color.Green;
            FarmerName.Location = new Point(185, 69);
            FarmerName.Name = "FarmerName";
            FarmerName.Size = new Size(124, 21);
            FarmerName.TabIndex = 49;
            FarmerName.Text = "Farmers Name";
            // 
            // cropName
            // 
            cropName.AutoSize = true;
            cropName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropName.ForeColor = Color.Green;
            cropName.Location = new Point(195, 138);
            cropName.Name = "cropName";
            cropName.Size = new Size(97, 21);
            cropName.TabIndex = 48;
            cropName.Text = "Crop Name";
            // 
            // TotPrice
            // 
            TotPrice.AutoSize = true;
            TotPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotPrice.ForeColor = Color.Black;
            TotPrice.Location = new Point(946, 172);
            TotPrice.Name = "TotPrice";
            TotPrice.Size = new Size(78, 32);
            TotPrice.TabIndex = 47;
            TotPrice.Text = "₱0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(835, 176);
            label13.Name = "label13";
            label13.Size = new Size(105, 21);
            label13.TabIndex = 46;
            label13.Text = "Order Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(390, 172);
            label11.Name = "label11";
            label11.Size = new Size(115, 21);
            label11.TabIndex = 45;
            label11.Text = "Shipping Fee:";
            // 
            // shippingFee
            // 
            shippingFee.AutoSize = true;
            shippingFee.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shippingFee.ForeColor = Color.Green;
            shippingFee.Location = new Point(511, 172);
            shippingFee.Name = "shippingFee";
            shippingFee.Size = new Size(75, 21);
            shippingFee.TabIndex = 44;
            shippingFee.Text = "₱120.00";
            // 
            // cropPrice
            // 
            cropPrice.AutoSize = true;
            cropPrice.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cropPrice.ForeColor = Color.Green;
            cropPrice.Location = new Point(396, 87);
            cropPrice.Name = "cropPrice";
            cropPrice.Size = new Size(57, 21);
            cropPrice.TabIndex = 41;
            cropPrice.Text = "₱0.00";
            // 
            // subTotal
            // 
            subTotal.AutoSize = true;
            subTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotal.ForeColor = Color.Green;
            subTotal.Location = new Point(967, 87);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(57, 21);
            subTotal.TabIndex = 43;
            subTotal.Text = "₱0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(921, 37);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 40;
            label7.Text = "Item Subtotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(666, 37);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 39;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(400, 37);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 38;
            label5.Text = "Price";
            // 
            // cropImage
            // 
            cropImage.BackColor = Color.DarkGray;
            cropImage.Image = (Image)resources.GetObject("cropImage.Image");
            cropImage.Location = new Point(6, 69);
            cropImage.Name = "cropImage";
            cropImage.Size = new Size(173, 110);
            cropImage.SizeMode = PictureBoxSizeMode.Zoom;
            cropImage.TabIndex = 36;
            cropImage.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(3, 23);
            label4.Name = "label4";
            label4.Size = new Size(194, 30);
            label4.TabIndex = 37;
            label4.Text = "Products Ordered";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 259);
            panel3.Name = "panel3";
            panel3.Size = new Size(1074, 20);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1074, 20);
            panel2.TabIndex = 0;
            // 
            // BuyNow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 625);
            Controls.Add(productsOrderedPanel);
            Controls.Add(deliveryAddress);
            Controls.Add(paymentMethod);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyNow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuyNow";
            deliveryAddress.ResumeLayout(false);
            deliveryAddress.PerformLayout();
            paymentMethod.ResumeLayout(false);
            paymentMethod.PerformLayout();
            payMethod.ResumeLayout(false);
            payMethod.PerformLayout();
            productsOrderedPanel.ResumeLayout(false);
            productsOrderedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cropImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel deliveryAddress;
        private Label label1;
        private Label label2;
        private Label customerName;
        private Label label3;
        private Label customerNum;
        private TextBox addressTxt;
        private RadioButton gCash;
        private RadioButton cashDelivery;
        private Label totPriceCrops;
        private Panel paymentMethod;
        private Label shipTotal;
        private Label itemSubtotal;
        private Label label12;
        private Label label10;
        private Label label8;
        private Panel payMethod;
        private Button placeOrder;
        private Button cancelBtn;
        private Label label14;
        private Panel panel1;
        private Panel productsOrderedPanel;
        private Panel panel3;
        private Panel panel2;
        private Label FarmerName;
        private Label cropName;
        private Label TotPrice;
        private Label label13;
        private Label label11;
        private Label shippingFee;
        private Label cropPrice;
        private Label subTotal;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox cropImage;
        private Label label4;
        private NumericUpDown numericUpDown1;
    }
}