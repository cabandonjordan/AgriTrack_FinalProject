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

                // Step 1: Get the current farmer's full name using UserID
                string getNameQuery = "SELECT FullName FROM Users WHERE UserID = ?";
                OleDbCommand getNameCmd = new OleDbCommand(getNameQuery, myConn);
                getNameCmd.Parameters.AddWithValue("?", UserID);
                string farmerName = getNameCmd.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(farmerName))
                {
                    MessageBox.Show("Farmer name not found.");
                    return;
                }

                // Step 2: Filter orders where Purchase.Status = 'Pending' AND Purchase.FarmersName = current farmer
                string orderQuery = @"
            SELECT 
                Purchase.PurchaseID, 
                Purchase.CropID, 
                Crops.CropsName, 
                Crops.Category, 
                Crops.CropsImage, 
                Purchase.QuantityBought, 
                Purchase.TotalPrices, 
                Purchase.SaleDate, 
                Purchase.PaymentMethod, 
                Purchase.CustomerName, 
                Purchase.CustomerAddress, 
                Purchase.Status
            FROM 
                (Purchase 
                INNER JOIN Crops ON Purchase.CropID = Crops.CropID)
            WHERE 
                Purchase.Status = 'Pending' AND 
                Purchase.FarmersName = ?";

                OleDbCommand cmd = new OleDbCommand(orderQuery, myConn);
                cmd.Parameters.AddWithValue("?", farmerName);  // Filter by farmer's full name

                OleDbDataReader reader = cmd.ExecuteReader();
                orderPanel.Controls.Clear();

                while (reader.Read())
                {
                    string cropName = reader["CropsName"].ToString();
                    int addedQuantity = Convert.ToInt32(reader["QuantityBought"]);
                    string category = reader["Category"].ToString();
                    byte[] imageBytes = (byte[])reader["CropsImage"];
                    Image cropImage;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                        cropImage = Image.FromStream(ms);

                    string customerName = reader["CustomerName"].ToString();
                    string status = reader["Status"].ToString();
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrices"]);
                    DateTime orderDate = Convert.ToDateTime(reader["SaleDate"]);
                    string paymentMethod = reader["PaymentMethod"].ToString();

                    OrdersData order = new OrdersData(
                        cropName, category, addedQuantity, customerName, cropImage,
                        status, orderDate, paymentMethod, totalPrice, UserID
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
