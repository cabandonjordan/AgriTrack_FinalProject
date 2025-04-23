using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class CropsAll : Crops
    {
        public CropsAll(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName)
        {
            InitializeComponent();
            EnsureDatabaseConnection();
            CropName = cropNames;
            Quantity = quantitys;
            Price = prices;
            Category = categorys;
            CropImage = cropImages;
            UserID = userId;
            FarmerName = farmerName;

            cropName.Text = "Crop Name: " + cropNames;
            quantity.Text = "Quantity: " + quantitys + "kg";
            price.Text = "Price: ₱" + prices.ToString("N2");
            category.Text = "Category: " + categorys;
            cropImage.Image = cropImages;
            UserID = userId;
            farmersName.Text = farmerName;
        }
    }
}
