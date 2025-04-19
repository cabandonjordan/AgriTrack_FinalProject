namespace AgriTrack_FinalProject
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            customerName = new Label();
            customerNum = new Label();
            addressTxt = new TextBox();
            label3 = new Label();
            paymentMethod = new Panel();
            totPriceCrops = new Label();
            shipTotal = new Label();
            itemSubtotal = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            payMethod = new Panel();
            gCash = new RadioButton();
            cashDelivery = new RadioButton();
            placeOrder = new Button();
            cancelBtn = new Button();
            label14 = new Label();
            deliveryAddress = new Panel();
            ProductsOrderedPanel = new FlowLayoutPanel();
            paymentMethod.SuspendLayout();
            payMethod.SuspendLayout();
            deliveryAddress.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 0;
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
            paymentMethod.Location = new Point(0, 402);
            paymentMethod.Name = "paymentMethod";
            paymentMethod.Size = new Size(1074, 223);
            paymentMethod.TabIndex = 10;
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
            // placeOrder
            // 
            placeOrder.FlatAppearance.BorderSize = 2;
            placeOrder.FlatStyle = FlatStyle.Flat;
            placeOrder.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeOrder.Image = (Image)resources.GetObject("placeOrder.Image");
            placeOrder.ImageAlign = ContentAlignment.MiddleLeft;
            placeOrder.Location = new Point(858, 167);
            placeOrder.Name = "placeOrder";
            placeOrder.Size = new Size(213, 44);
            placeOrder.TabIndex = 9;
            placeOrder.Text = "    Place Order";
            placeOrder.UseVisualStyleBackColor = true;
            placeOrder.Click += placeOrder_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(12, 167);
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
            deliveryAddress.TabIndex = 11;
            // 
            // ProductsOrderedPanel
            // 
            ProductsOrderedPanel.AutoScroll = true;
            ProductsOrderedPanel.Dock = DockStyle.Fill;
            ProductsOrderedPanel.Location = new Point(0, 136);
            ProductsOrderedPanel.Name = "ProductsOrderedPanel";
            ProductsOrderedPanel.Size = new Size(1074, 266);
            ProductsOrderedPanel.TabIndex = 12;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1074, 625);
            Controls.Add(ProductsOrderedPanel);
            Controls.Add(deliveryAddress);
            Controls.Add(paymentMethod);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOut";
            paymentMethod.ResumeLayout(false);
            paymentMethod.PerformLayout();
            payMethod.ResumeLayout(false);
            payMethod.PerformLayout();
            deliveryAddress.ResumeLayout(false);
            deliveryAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label customerName;
        private Label customerNum;
        private TextBox addressTxt;
        private Label label3;
        private Panel productsOrdered;
        private Panel paymentMethod;
        private Panel deliveryAddress;
        private Label label14;
        private Button cancelBtn;
        private Button placeOrder;
        private Panel payMethod;
        private RadioButton gCash;
        private RadioButton cashDelivery;
        private Label label15;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label itemSubtotal;
        private FlowLayoutPanel ProductsOrderedPanel;
        private Label shipTotal;
        private Label totPriceCrops;
    }
}