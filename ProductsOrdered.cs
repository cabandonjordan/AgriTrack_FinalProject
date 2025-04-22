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
    public partial class ProductsOrdered : UserControl
    {
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public int UserId { get; set; }
        public string FarmersNames { get; set; }
        public int CropId { get; set; }
        public decimal TotalPrice { get; set; }
        public int AddedQuant { get; set; }
        public decimal OrderTotal { get; set; }
        public int CartsID { get; set; }
        public ProductsOrdered(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName, int cropId, decimal total, int addQuant, int cartId)
        {
            InitializeComponent();
            CartsID = cartId;
            CropName = cropNames;
            Quantity = quantitys;
            Price = prices;
            Category = categorys;
            CropImage = cropImages;
            UserId = userId;
            FarmersNames = farmerName;
            AddedQuant = addQuant;
            CropId = cropId;
            TotalPrice = total;
            OrderTotal = TotalPrice + 50;

            cropImage.Image = cropImages;
            cropName.Text = cropNames;
            FarmerName.Text = "Farmer: " + farmerName;
            cropPrice.Text = "₱" + prices.ToString("N2");
            addedQuant.Text = addQuant.ToString();
            subTotal.Text = "₱" + total.ToString("N2");
            TotPrice.Text = "₱" + OrderTotal.ToString("N2");
        }
    }
}
