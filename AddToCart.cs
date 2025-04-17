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
    public partial class AddToCart : Form
    {
        public int addUserID { get; private set; }
        public string addCropName { get; private set; }
        public int addQuantities { get; private set; }
        public decimal addPrice { get; private set; }
        public string addCategory { get; private set; }
        public Image addCropImage { get; private set; }
        public string addFarmerName { get; private set; }
        public AddToCart(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName)
        {
            InitializeComponent();
            addCropName = cropNames;
            addQuantities = quantitys;
            addPrice = prices;
            addCategory = categorys;
            addCropImage = cropImages;
            addUserID = userId;
            addFarmerName = farmerName;

            cropName.Text = cropNames;
            stock.Text = "Stock: " + quantitys;
            price.Text = "Price: ₱" + prices.ToString("N2");
            categories.Text = "Category: " + categorys;
            cropImage.Image = cropImages;
            addUserID = userId;
            nameFarner.Text = farmerName;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
