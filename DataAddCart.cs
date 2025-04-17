using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class DataAddCart : UserControl
    {
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public int UserId { get; set; }
        public string FarmerName { get; set; }
        public int CropId { get; set; }
        public decimal TotalPrice { get; set; }
        public int AddedQuant { get; set; }
        public DataAddCart(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName, int cropId, decimal total, int addQuant)
        {
            InitializeComponent();
            this.Paint += DataAddCart_Paint;
            CropName = cropNames;
            Quantity = quantitys;
            Price = prices;
            Category = categorys;
            CropImage = cropImages;
            UserId = userId;
            FarmerName = farmerName;
            AddedQuant = addQuant;
            CropId = cropId;
            TotalPrice = total;

            nameCrop.Text = cropNames;
            stock.Text = "Stock: " + quantitys;
            price.Text = "Price: ₱" + prices.ToString("N2");
            category.Text = "Category: " + categorys;
            nameFarmer.Text = "Farmer: " + farmerName;
            cropImage.Image = cropImages;
            addedQuant.Value = addQuant;
        }
        private void DataAddCart_Paint(object sender, PaintEventArgs e)
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
