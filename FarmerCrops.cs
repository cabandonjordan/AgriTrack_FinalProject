using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class FarmerCrops : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        DataSet? ds;
        int userID;
        private List<CropData> allCrops = new List<CropData>();
        public FarmerCrops(int UsersID)
        {
            InitializeComponent();
            EnsureDatabaseConnection();
            userID = UsersID;
            LoadCrops();
        }
        public void FilterCrops(string searchText)
        {
            addedCropsFpanel.Controls.Clear();

            string search = searchText.ToLower();

            for (int i = 0; i < allCrops.Count; i++)
            {
                string cropName = allCrops[i].CropName.ToLower();
                string farmerName = allCrops[i].FarmerName.ToLower();

                if (cropName.Contains(search) || farmerName.Contains(search))
                {
                    addedCropsFpanel.Controls.Add(allCrops[i]);
                }
            }
        }
        private void EnsureDatabaseConnection()
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }
        private void LoadCrops()
        {
            try
            {
                myConn.Open();
                //string query = "SELECT Users.UserID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage, Users.FullName " +
                //               "FROM Users RIGHT JOIN Crops ON Users.UserID = Crops.UserID"; 
                string query = "SELECT Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage, Users.FullName\r\nFROM Users INNER JOIN Crops ON Users.UserID = Crops.UserID\r\nWHERE Crops.UserID = @userID;";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userID", userID);

                OleDbDataReader reader = cmd.ExecuteReader();

                allCrops.Clear();
                addedCropsFpanel.Controls.Clear();

                while (reader.Read())
                {
                    string cropName = reader["CropsName"].ToString();
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    string category = reader["Category"].ToString();
                    string farmerName = reader["FullName"].ToString();

                    byte[] imageBytes = (byte[])reader["CropsImage"];
                    Image cropImage;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        cropImage = Image.FromStream(ms);
                    }

                    CropData cropItem = new CropData(cropName, quantity, price, category, cropImage, userID, farmerName);
                    allCrops.Add(cropItem);
                    addedCropsFpanel.Controls.Add(cropItem);                 
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading crops: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        private void addCrop_Click(object sender, EventArgs e)
        {
            forAddCrops addCrops = new forAddCrops(userID);
            if (addCrops.ShowDialog() == DialogResult.OK)
            {
                AddCropItem(addCrops.CropData);
            }
        }
        public void AddCropItem(CropData cropData)
        {
            addedCropsFpanel.Controls.Add(cropData);
        }
    }
}
