using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class PurchasesData : UserControl
    {
        public int UserID { get; set; }
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public string FarmersName { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public int PurchaseID { get; set; }
        public string CustomerEmail { get; set; }
        public PurchasesData(string cropNames, string category, int quantityBought, string farmerName,
                  Image cropImages, string status, DateTime orderDate, string payMethods,
                  decimal total, int userID, int purchaseID, string email)
        {
            InitializeComponent();
            this.Paint += PurchasesData_Paint;
            CropName = cropNames;
            Quantity = quantityBought;
            Category = category;
            CropImage = cropImages;
            FarmersName = farmerName;
            Status = status;
            Total = total;
            UserID = userID;
            OrderDate = orderDate;
            PaymentMethod = payMethods;
            PurchaseID = purchaseID;
            CustomerEmail = email;

            nameFarmer.Text = farmerName;
            cropsName.Text = cropNames;
            addedQuant.Text = $"Quantity Bought: {quantityBought}kg";
            categorys.Text = $"Category: {category}";
            cropImage.Image = cropImages;
            statuses.Text = $"Status: {status}";
            datePending.Text = $"Order Date: {orderDate:yyyy-MM-dd}";
            payMethod.Text = $"Payment Method: {payMethods}";
            totalPrice.Text = $"Total Price: ₱{total:N2}";
        }
        private void PurchasesData_Paint(object sender, PaintEventArgs e)
        {
            var path = new GraphicsPath();
            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
