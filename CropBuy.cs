using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class CropBuy : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public int UserID { get; private set; }
        public string CropName { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }
        public Image CropImage { get; private set; }
        public string FarmerName { get; private set; }
        public CropBuy(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName)
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

            cropName.Text = "Cropname: " + cropNames;
            quantity.Text = "Quantity: " + quantitys;
            price.Text = "Price: " + prices.ToString("C");
            category.Text = "Category: " + categorys;
            cropImage.Image = cropImages;
            UserID = userId;
            farmersName.Text = farmerName;

            cropImage.Paint += new PaintEventHandler(RoundCropImage);
            this.Paint += CropBuy_Paint;
        }
        private void EnsureDatabaseConnection()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void RoundCropImage(object sender, PaintEventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(1, 1, picBox.Width, picBox.Height);
                picBox.Region = new Region(path);
            }
        }
        private void CropBuy_Paint(object sender, PaintEventArgs e)
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

        private void addToCart_Click(object sender, EventArgs e)
        {
          
        }
    }
}
