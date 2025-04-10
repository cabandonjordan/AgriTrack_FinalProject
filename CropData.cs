using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class CropData : Crops
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public event EventHandler? DeleteClicked;
        //public int UserID { get; private set; }
        //public string CropName { get; private set; }
        //public int Quantity { get; private set; }
        //public decimal Price { get; private set; }
        //public string Category { get; private set; }
        //public Image CropImage { get; private set; }
        //public string FarmerName { get; private set; }
        public CropData(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName)
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
            price.Text = "Price: ₱" + prices.ToString("N2");
            category.Text = "Category: " + categorys;
            cropImage.Image = cropImages;
            UserID = userId;
            farmersName.Text = farmerName;
        }
        private void EnsureDatabaseConnection()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this crop?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteCropFromDatabase();
                DeleteClicked?.Invoke(this, EventArgs.Empty);
                this.Parent?.Controls.Remove(this);
            }
        }
        private void DeleteCropFromDatabase()
        {
            try
            {
                myConn?.Open();
                string deleteQuery = "DELETE FROM Crops WHERE CropsName = ? AND UserID = ?";
                cmd = new OleDbCommand(deleteQuery, myConn);
                cmd.Parameters.AddWithValue("?", CropName);
                cmd.Parameters.AddWithValue("?", UserID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting crop: " + ex.Message);
            }
            finally
            {
                myConn?.Close();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            UpdateCrops updateForm = new UpdateCrops(UserID, CropName, Quantity, Price, Category, CropImage);
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                CropName = updateForm.UpdatedCropName;
                Quantity = updateForm.UpdatedQuantity;
                Price = updateForm.UpdatedPrice;
                Category = updateForm.UpdatedCategory;
                CropImage = updateForm.UpdatedCropImage;

                cropName.Text = "Cropname: " + updateForm.UpdatedCropName;
                quantity.Text = "Quantity: " + updateForm.UpdatedQuantity;
                price.Text = "Price: ₱" + updateForm.UpdatedPrice.ToString("N2");
                category.Text = "Category: " + updateForm.UpdatedCategory;
                cropImage.Image = updateForm.UpdatedCropImage;
            }
        }      
    }
}
