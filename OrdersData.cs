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
    public partial class OrdersData : UserControl
    {
        public int UserID { get; set; }
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public string CustomerNames { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }

        public string CustomerEmail { get; set; }
        public OrdersData(string cropNames, string category, int quantity, string customerName,
                  Image cropImages, string status, DateTime orderDate, string payMethods,
                  decimal total, int userID)
        {
            InitializeComponent();
            CropName = cropNames;
            Quantity = quantity;
            Category = category;
            CropImage = cropImages;
            CustomerNames = customerName;
            Status = status;
            Total = total;
            UserID = userID;
            OrderDate = orderDate;
            PaymentMethod = payMethods;

            cropsName.Text = cropNames;
            addedQuant.Text = $"Quantity: {quantity}";
            customerNames.Text = customerName;
            categorys.Text = $"Category: {category}";
            cropImage.Image = cropImages;
            statuses.Text = $"Status: {status}";
            datePending.Text = $"Order Date: {orderDate:yyyy-MM-dd}";
            payMethod.Text = $"Payment Method: {payMethods}";
            totalPrice.Text = $"Total Price: ₱{total:N2}";
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
