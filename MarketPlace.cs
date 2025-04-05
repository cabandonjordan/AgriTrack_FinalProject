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
        public MarketPlace(int UsersID)
        {
            InitializeComponent();
            userID = UsersID;
            LoadCrops();
        }
        private void LoadCrops()
        {
            myConn = DataBase.GetConnection();
            try
            {
                myConn.Open();

                string query = "SELECT Users.UserID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage, Users.FullName " +
                               "FROM Users RIGHT JOIN Crops ON Users.UserID = Crops.UserID";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userID", userID);

                OleDbDataReader reader = cmd.ExecuteReader();

                marketPlaceFpan.Controls.Clear();

                while (reader.Read())
                {
                    properties.cropName = reader["CropsName"].ToString();
                    properties.quantity = Convert.ToInt32(reader["Quantity"]);
                    properties.price = Convert.ToDecimal(reader["Price"]);
                    properties.category = reader["Category"].ToString();
                    properties.farmerName = reader["FullName"].ToString();

                    byte[] imageBytes = (byte[])reader["CropsImage"];
                    Image cropImage;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        cropImage = Image.FromStream(ms);
                    }
                    CropBuy cropItem = new CropBuy(properties.cropName, properties.quantity, properties.price, properties.category, cropImage, userID, properties.farmerName);
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