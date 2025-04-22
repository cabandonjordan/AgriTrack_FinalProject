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
    public partial class PurchaseHistory : UserControl
    {
        OleDbConnection? myConn;
        public int UserID { get; private set; }
        public PurchaseHistory(int userID)
        {
            InitializeComponent();
            EnsureDataBase();
            UserID = userID;
            LoadPurchases();
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void LoadPurchases()
        {
            try
            {
                myConn?.Open();

                string query = @"
                    SELECT 
                        Purchase.PurchaseID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, 
                        Crops.CropsImage, Purchase.QuantityBought, Purchase.TotalPrices, Purchase.SaleDate, 
                        Purchase.PaymentMethod, Purchase.CustomerName, Purchase.FarmersName, 
                        Purchase.CustomerAddress, Purchase.Status, Purchase.Email
                    FROM 
                        (Purchase 
                        INNER JOIN Crops ON Purchase.CropID = Crops.CropID) 
                        INNER JOIN Users ON Purchase.CustomerID = Users.UserID
                    WHERE 
                        Purchase.CustomerID = ?";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", UserID);

                OleDbDataReader reader = cmd.ExecuteReader();
                purchaseFlowPanel.Controls.Clear(); // Make sure you have this FlowLayoutPanel in the form

                while (reader.Read())
                {
                    string cropName = reader["CropsName"].ToString();
                    string category = reader["Category"].ToString();
                    int quantityBought = Convert.ToInt32(reader["QuantityBought"]);
                    string farmerName = reader["FarmersName"].ToString();
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrices"]);
                    DateTime orderDate = Convert.ToDateTime(reader["SaleDate"]);
                    string paymentMethod = reader["PaymentMethod"].ToString();
                    string status = reader["Status"].ToString();
                    int purchaseID = Convert.ToInt32(reader["PurchaseID"]);
                    string customerEmail = reader["Email"].ToString();

                    byte[] imgBytes = (byte[])reader["CropsImage"];
                    Image cropImg;
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                        cropImg = Image.FromStream(ms);

                    PurchasesData purchaseCard = new PurchasesData(
                        cropName, category, quantityBought, farmerName, cropImg,
                        status, orderDate, paymentMethod, totalPrice,
                        UserID, purchaseID, customerEmail
                    );

                    purchaseFlowPanel.Controls.Add(purchaseCard);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchase history: " + ex.Message);
            }
            finally
            {
                myConn?.Close();
            }
        }
    }
}
