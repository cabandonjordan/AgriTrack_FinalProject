using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            addedQuant.Text = $"Quantity Bought: {quantityBought}";
            categorys.Text = $"Category: {category}";
            cropImage.Image = cropImages;
            statuses.Text = $"Status: {status}";
            datePending.Text = $"Order Date: {orderDate:yyyy-MM-dd}";
            payMethod.Text = $"Payment Method: {payMethods}";
            totalPrice.Text = $"Total Price: ₱{total:N2}";
        }
    }
}
