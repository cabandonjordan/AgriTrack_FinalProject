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
    public partial class PendingOrders : UserControl
    {
        OleDbConnection? myConn;
        public int UserID { get; private set; }
        public PendingOrders(int userId)
        {
            InitializeComponent();
            EnsureDataBase();
            UserID = userId;

            LoadPendingOrders();
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void LoadPendingOrders()
        {
            try
            {
                myConn?.Open();

                string getNameQuery = "SELECT FullName FROM Users WHERE UserID = ?";
                OleDbCommand getNameCmd = new OleDbCommand(getNameQuery, myConn);
                getNameCmd.Parameters.AddWithValue("?", UserID);
                string farmerName = getNameCmd.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(farmerName))
                {
                    MessageBox.Show("Farmer name not found.");
                    return;
                }

                string orderQuery = @"
            SELECT 
                Crops.CropsName, 
                Crops.Quantity AS AvailableQuantity, 
                Crops.Price, 
                Crops.Category, 
                FIRST(Crops.CropsImage) AS CropsImage, 
                SUM(Purchase.QuantityBought) AS TotalQuantityBought, 
                SUM(Purchase.TotalPrices) AS TotalPrice, 
                Purchase.SaleDate, 
                Purchase.PaymentMethod, 
                Purchase.CustomerName, 
                Purchase.FarmersName, 
                FIRST(Purchase.Email) AS Email,
                MIN(Purchase.PurchaseID) AS PurchaseID,
                FIRST(Purchase.Status) AS Status
            FROM 
                (Purchase 
                INNER JOIN Crops ON Purchase.CropID = Crops.CropID) 
                INNER JOIN Users ON Purchase.CustomerID = Users.UserID
            WHERE 
                Purchase.Status IN ('Pending', 'Confirmed') AND 
                Purchase.FarmersName = ?
            GROUP BY 
                Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, 
                Purchase.SaleDate, Purchase.PaymentMethod, Purchase.CustomerName, Purchase.FarmersName";

                OleDbCommand cmd = new OleDbCommand(orderQuery, myConn);
                cmd.Parameters.AddWithValue("?", farmerName);

                OleDbDataReader reader = cmd.ExecuteReader();
                orderPanel.Controls.Clear();

                while (reader.Read())
                {
                    string cropName = reader["CropsName"].ToString();
                    int availableQuantity = Convert.ToInt32(reader["AvailableQuantity"]);
                    decimal cropPrice = Convert.ToDecimal(reader["Price"]);
                    string category = reader["Category"].ToString();
                    byte[] imageBytes = (byte[])reader["CropsImage"];
                    Image cropImage;
                    
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                        cropImage = Image.FromStream(ms);

                    int purchasedQuantity = Convert.ToInt32(reader["TotalQuantityBought"]);
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                    DateTime orderDate = Convert.ToDateTime(reader["SaleDate"]);
                    string paymentMethod = reader["PaymentMethod"].ToString();
                    string customerName = reader["CustomerName"].ToString();
                    string customerEmail = reader["Email"].ToString();
                    int purchaseID = Convert.ToInt32(reader["PurchaseID"]);
                    string status = reader["Status"].ToString();  // Dynamically read status

                    OrdersData order = new OrdersData(
                        cropName, category, availableQuantity, customerName, cropImage,
                        status, orderDate, paymentMethod, totalPrice, UserID, purchaseID, customerEmail
                    );

                    orderPanel.Controls.Add(order);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
            finally
            {
                myConn?.Close();
            }
        }
    }
}