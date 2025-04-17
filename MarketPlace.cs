using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class MarketPlace : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        DataSet? ds;
        int userID;
        AgriTrackDataBase DataBase = new AgriTrackDataBase();
        AgriTrackMethods properties = new AgriTrackMethods();
        private List<CropBuy> allCropItems = new List<CropBuy>();
        public MarketPlace(int UsersID)
        {
            InitializeComponent();
            userID = UsersID;
            LoadCrops();
        }
        public void FilterCrops(string searchText)
        {
            marketPlaceFpan.Controls.Clear();

            string search = searchText.ToLower();

            for (int i = 0; i < allCropItems.Count; i++)
            {
                string cropName = allCropItems[i].CropName.ToLower();
                string farmerName = allCropItems[i].FarmerName.ToLower();

                if (cropName.Contains(search) || farmerName.Contains(search))
                {
                    marketPlaceFpan.Controls.Add(allCropItems[i]);
                }
            }
        }
        private void LoadCrops()
        {
            myConn = DataBase.GetConnection();
            //try
            //{
            //    myConn.Open();

            //    string query = "SELECT Users.UserID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage, Users.FullName " +
            //                   "FROM Users RIGHT JOIN Crops ON Users.UserID = Crops.UserID";

            //    OleDbCommand cmd = new OleDbCommand(query, myConn);
            //    cmd.Parameters.AddWithValue("@userID", userID);

            //    OleDbDataReader reader = cmd.ExecuteReader();

            //    allCropItems.Clear();
            //    marketPlaceFpan.Controls.Clear();

            //    while (reader.Read())
            //    {
            //        properties.cropName = reader["CropsName"].ToString();
            //        properties.quantity = Convert.ToInt32(reader["Quantity"]);
            //        properties.price = Convert.ToDecimal(reader["Price"]);
            //        properties.category = reader["Category"].ToString();
            //        properties.farmerName = reader["FullName"].ToString();

            //        byte[] imageBytes = (byte[])reader["CropsImage"];
            //        Image cropImage;
            //        using (MemoryStream ms = new MemoryStream(imageBytes))
            //        {
            //            cropImage = Image.FromStream(ms);
            //        }
            //        CropBuy cropItem = new CropBuy(properties.cropName, properties.quantity, properties.price, properties.category, cropImage, userID, properties.farmerName);
            //        allCropItems.Add(cropItem);
            //        marketPlaceFpan.Controls.Add(cropItem);
            //    }
            //    reader.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading crops: " + ex.Message);
            //}
            //finally
            //{
            //    myConn.Close();
            //}my past code

            try
            {
                myConn.Open();

                string query = "SELECT Users.UserID, Crops.CropID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage, Users.FullName " +
                               "FROM Users RIGHT JOIN Crops ON Users.UserID = Crops.UserID";

                OleDbCommand cmd = new OleDbCommand(query, myConn);

                OleDbDataReader reader = cmd.ExecuteReader();

                allCropItems.Clear();
                marketPlaceFpan.Controls.Clear();

                while (reader.Read())
                {
                    int cropId = Convert.ToInt32(reader["CropID"]);
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

                    CropBuy cropItem = new CropBuy(cropName, quantity, price, category, cropImage, userID, farmerName, cropId);

                    allCropItems.Add(cropItem);
                    marketPlaceFpan.Controls.Add(cropItem);
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
    }
}