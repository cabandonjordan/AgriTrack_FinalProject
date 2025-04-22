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
    public partial class AddToCart : Form
    {
        public int addUserID { get; private set; }
        public string addCropName { get; private set; }
        public int addQuantities { get; private set; }
        public decimal addPrice { get; private set; }
        public string addCategory { get; private set; }
        public Image addCropImage { get; private set; }
        public string addFarmerName { get; private set; }
        public int cartID { get; private set; }
        public int addCropID { get; private set; }
        public int addQuantity;
        public DataAddCart dataAddCart { get; private set; } 
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public AddToCart(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName, int cropId)
        {
            InitializeComponent();
            addCropName = cropNames;
            addQuantities = quantitys;
            addPrice = prices;
            addCategory = categorys;
            addCropImage = cropImages;
            addUserID = userId;
            addFarmerName = farmerName;
            addCropID = cropId;

            cropName.Text = cropNames;
            stock.Text = "Stock: " + quantitys;
            price.Text = "Price: ₱" + prices.ToString("N2");
            categories.Text = "Category: " + categorys;
            cropImage.Image = cropImages;
            addUserID = userId;
            nameFarner.Text = farmerName;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCart_Click(object sender, EventArgs e)
        {
            int addQuantity = (int)quantityCrop.Value;
            decimal totPrice = addPrice * addQuantity;
            DateTime dateAdded = DateTime.Now;

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");

            try
            {
                myConn.Open();
                string customerName = "";
                string userType = "";

                string getUserInfoQuery = "SELECT FullName, UserType FROM Users WHERE UserID = @custId";
                using (OleDbCommand getUserCmd = new OleDbCommand(getUserInfoQuery, myConn))
                {
                    getUserCmd.Parameters.AddWithValue("@custId", addUserID);
                    OleDbDataReader reader = getUserCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        customerName = reader["FullName"].ToString();
                        userType = reader["UserType"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reader.Close();
                }
                //string query = "INSERT INTO Cart (UserID, AddedQuantity, TotalPrice, DateAdded, CheckedOut, CustomerName, FarmersName, CropID) " +
                //               "VALUES (@userId, @addquantity, @Totprice, @date, @checked, @nameCustomer, @farmerName, @cropId)";
                string query = "INSERT INTO Cart (UserID, AddedQuantity, TotalPrice, DateAdded, CheckedOut, CustomerName, FarmersName, CropID, CropName) " +
               "VALUES (@userId, @addquantity, @Totprice, @date, @checked, @nameCustomer, @farmerName, @cropId, @cropName)";


                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userId", addUserID);
                cmd.Parameters.AddWithValue("@addquantity", addQuantity);
                cmd.Parameters.AddWithValue("@Totprice", totPrice);
                cmd.Parameters.AddWithValue("@date", dateAdded.ToShortDateString());
                cmd.Parameters.AddWithValue("@checked", false);
                cmd.Parameters.AddWithValue("@nameCustomer", customerName);
                cmd.Parameters.AddWithValue("@farmerName", addFarmerName);
                cmd.Parameters.AddWithValue("@cropId", addCropID);
                cmd.Parameters.AddWithValue("@cropName", addCropName);

                cmd.ExecuteNonQuery();
                dataAddCart = new DataAddCart(addCropName, addQuantities, addPrice, addCategory, addCropImage, addUserID, addFarmerName, addCropID, totPrice, addQuantity, cartID);

                MessageBox.Show("Crop added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Data type mismatch error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding crop to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}