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
    public partial class BuyNow : Form
    {
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public int UserId { get; set; }
        public string FarmerNames { get; set; }
        public int CropId { get; set; }
        public decimal TotalPrice { get; set; }
        public int AddedQuant { get; set; }
        public decimal OrderTotal { get; set; }
        public int ShipFee { get; set; } = 120;
        public BuyNow(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName, int cropId, decimal total, int addQuant)
        {
            InitializeComponent();
            CropName = cropNames;
            Quantity = quantitys;
            Price = prices;
            Category = categorys;
            CropImage = cropImages;
            UserId = userId;
            FarmerNames = farmerName;
            AddedQuant = addQuant;
            CropId = cropId;
            TotalPrice = total;
            OrderTotal = TotalPrice + ShipFee;


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
