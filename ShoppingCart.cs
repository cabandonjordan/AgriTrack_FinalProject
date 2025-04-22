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
        private List<DataAddCart> allCropItems = new List<DataAddCart>();
        public ShoppingCart(int userID)
        {
            InitializeComponent();
            EnsureDataBase();
            LoggedInUserId = userID;
            LoadCartItems();
        }
        public void FilterCrops(string searchText)
        {
            addedCropsFpanel.Controls.Clear();

            string search = searchText.ToLower();

            for (int i = 0; i < allCropItems.Count; i++)
            {
                string cropName = allCropItems[i].CropName.ToLower();
                string farmerName = allCropItems[i].FarmerName.ToLower();
                string category = allCropItems[i].Category.ToLower();

                if (cropName.Contains(search) || farmerName.Contains(search) || category.Contains(search))
                {
                    addedCropsFpanel.Controls.Add(allCropItems[i]);
                }
            }
        }

        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }

        private void LoadCartItems()
        {
            allCropItems.Clear();
            addedCropsFpanel.Controls.Clear();

            if (myConn == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            try
            {
                myConn.Open();

                // Adjusted query to include CartID
                string query = @"SELECT Cart.CartID, Crops.CropsName, Crops.Quantity, Crops.Price, Crops.Category, Crops.CropsImage,   
                               Cart.AddedQuantity, (Cart.AddedQuantity * Crops.Price) AS TotalPrice,   
                               Cart.DateAdded, Cart.CheckedOut, Cart.CustomerName, Cart.CropID,  
                               Users.FullName AS FarmersName   
                        FROM (Cart INNER JOIN Crops ON Cart.CropID = Crops.CropID)   
                        INNER JOIN Users ON Crops.UserID = Users.UserID   
                        WHERE Cart.UserID = @userId AND Cart.CheckedOut = false";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userId", LoggedInUserId);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int cartID = reader["CartID"] != DBNull.Value ? Convert.ToInt32(reader["CartID"]) : 0;
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

                    var cartItem = new DataAddCart(cropName, quantity, unitPrice, category, cropImage, LoggedInUserId, farmerName, cropId, totalPrice, addedQuantity, cartID);

                    // ✅ SUBSCRIBE to checkbox changed event
                    cartItem.CheckboxChanged += CartItem_CheckboxChanged;

                    addedCropsFpanel.Controls.Add(cartItem);
                    allCropItems.Add(cartItem);
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

        private void checkOut_Click(object sender, EventArgs e)
        {
            List<DataAddCart> selectedItems = new List<DataAddCart>();

            foreach (Control ctrl in addedCropsFpanel.Controls)
            {
                if (ctrl is DataAddCart cartItem && cartItem.IsChecked())
                {
                    selectedItems.Add(cartItem);
                }
            }

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item to checkout.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var customerInfo = GetCustomerInfo();

            // ✅ Each item will be charged ₱50 shipping
            CheckOut checkoutForm = new CheckOut(selectedItems, customerInfo.FullName, customerInfo.ContactNumber);
            checkoutForm.ShowDialog();
        }
        private (string FullName, string ContactNumber) GetCustomerInfo()
        {
            string fullName = "";
            string contactNumber = "";

            try
            {
                myConn.Open();
                string query = "SELECT FullName, PhoneNumber FROM Users WHERE UserID = @userId";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userId", Form1.LoggedInUserID);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fullName = reader["FullName"]?.ToString() ?? "";
                    contactNumber = reader["PhoneNumber"]?.ToString() ?? "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user info: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }

            return (fullName, contactNumber);
        }

        private void selectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = selectAll.Checked;

            foreach (Control ctrl in addedCropsFpanel.Controls)
            {
                if (ctrl is DataAddCart cart)
                {
                    cart.SetCheckboxState(isChecked);
                }
            }
        }
        private void CartItem_CheckboxChanged(object sender, EventArgs e)
        {
            UpdateSelectAllCheckbox();
        }

        private void UpdateSelectAllCheckbox()
        {
            bool allChecked = true;

            foreach (Control ctrl in addedCropsFpanel.Controls)
            {
                if (ctrl is DataAddCart cart && !cart.IsChecked())
                {
                    allChecked = false;
                    break;
                }
            }
            selectAll.CheckedChanged -= selectAll_CheckedChanged;
            selectAll.Checked = allChecked;
            selectAll.CheckedChanged += selectAll_CheckedChanged;
        }
    }
}
