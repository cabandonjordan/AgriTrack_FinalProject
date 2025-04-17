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
    public partial class ShoppingCart : UserControl
    {
        OleDbConnection? myConn;
        public int LoggedInUserId { get; set; }

        public ShoppingCart(int userID)
        {
            InitializeComponent();
            EnsureDataBase();
            LoggedInUserId = userID;
            LoadCartItems();
        }

        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }

        private void LoadCartItems()
        {
            addedCropsFpanel.Controls.Clear();

            if (myConn == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            try
            {
                myConn.Open();

                //string query = @"SELECT Cart.CartID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage,   
                //                               Cart.AddedQuantity, (Cart.AddedQuantity * Crops.Price) AS TotalPrice,   
                //                               Cart.DateAdded, Cart.CheckedOut, Cart.CustomerName, Cart.CropID,  
                //                               Users.FullName AS FarmersName   
                //                        FROM (Cart INNER JOIN Crops ON Cart.CropID = Crops.CropID)   
                //                        INNER JOIN Users ON Crops.UserID = Users.UserID   
                //                        WHERE Cart.UserID = @userId AND Cart.CheckedOut = false";
                string query = @"SELECT Cart.CartID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage,   
                               Cart.AddedQuantity, (Cart.AddedQuantity * Crops.Price) AS TotalPrice,   
                               Cart.DateAdded, Cart.CheckedOut, Cart.CustomerName, Cart.CropID,  
                               Users.FullName AS FarmersName   
                        FROM (Cart INNER JOIN Crops ON Cart.CropID = Crops.CropID)   
                        INNER JOIN Users ON Crops.UserID = Users.UserID   
                        WHERE Cart.UserID = @userId 
                        AND Cart.CheckedOut = false
                        AND Cart.UserID = @userId";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userId", LoggedInUserId);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string cropName = reader["CropsName"]?.ToString() ?? string.Empty;
                    int quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                    decimal unitPrice = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0;
                    string category = reader["Category"]?.ToString() ?? string.Empty;
                    string farmerName = reader["FarmersName"]?.ToString() ?? string.Empty;
                    int cropId = reader["CropID"] != DBNull.Value ? Convert.ToInt32(reader["CropID"]) : 0;
                    int addedQuantity = reader["AddedQuantity"] != DBNull.Value ? Convert.ToInt32(reader["AddedQuantity"]) : 0;
                    decimal totalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : 0;

                    Image cropImage = null;
                    if (reader["CropsImage"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["CropsImage"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            cropImage = Image.FromStream(ms);
                        }
                    }

                    var cartItem = new DataAddCart(cropName, quantity, unitPrice, category, cropImage, LoggedInUserId, farmerName, cropId, totalPrice, addedQuantity);
                    addedCropsFpanel.Controls.Add(cartItem);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load cart items: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
