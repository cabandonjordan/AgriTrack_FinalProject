using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class DataAddCart : UserControl
    {
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public int UserId { get; set; }
        public string FarmerName { get; set; }
        public int CropId { get; set; }
        public decimal TotalPrice { get; set; }
        public int AddedQuant { get; set; }
        public int CartsID { get; set; }

        public event EventHandler CheckboxChanged;
        public event EventHandler DeleteClicked;

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public DataAddCart(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName, int cropId, decimal total, int addQuant, int cartID)
        {
            InitializeComponent();
            EnsureDatabaseConnection();
            this.Paint += DataAddCart_Paint;
            CartsID = cartID;
            CropName = cropNames;
            Quantity = quantitys;
            Price = prices;
            Category = categorys;
            CropImage = cropImages;
            UserId = userId;
            FarmerName = farmerName;
            AddedQuant = addQuant;
            CropId = cropId;
            TotalPrice = total;

            nameCrop.Text = cropNames;
            stock.Text = "Stock: " + quantitys +"kg";
            price.Text = "Price: ₱" + prices.ToString("N2");
            category.Text = "Category: " + categorys;
            nameFarmer.Text = "Farmer: " + farmerName;
            cropImage.Image = cropImages;
            addedQuant.Value = addQuant;
            totalPrices.Text = "Total Amount: ₱" + total.ToString("N2");

            checkBox.CheckedChanged += checkBox_CheckedChanged;
            addedQuant.ValueChanged += addedQuant_ValueChanged;
        }
        private void EnsureDatabaseConnection()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void DataAddCart_Paint(object sender, PaintEventArgs e)
        {
            var path = new GraphicsPath();
            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            string customerName = "";
            string contactNumber = "";

            try
            {
                myConn.Open();
                string query = "SELECT FullName, PhoneNumber FROM Users WHERE UserID = ?";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", UserId);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customerName = reader["FullName"]?.ToString() ?? "";
                    contactNumber = reader["PhoneNumber"]?.ToString() ?? "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer info: " + ex.Message);
                return;
            }
            finally
            {
                myConn.Close();
            }

            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show("Customer information is incomplete.");
                return;
            }

            List<DataAddCart> selectedItems = new List<DataAddCart> { this };
            CheckOut checkoutForm = new CheckOut(selectedItems, customerName, contactNumber);
            checkoutForm.ShowDialog();
        }
        public void SetCheckboxState(bool isChecked)
        {
            checkBox.Checked = isChecked;
        }
        public bool IsChecked()
        {
            return checkBox.Checked;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChanged?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to remove this item from the cart?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                DeleteFromDatabase();
                DeleteClicked?.Invoke(this, EventArgs.Empty);
                this.Parent?.Controls.Remove(this);
            }
        }
        private void DeleteFromDatabase()
        {
            try
            {
                myConn?.Open();
                string deleteQuery = "DELETE FROM Cart WHERE CropID = ? AND UserID = ?";
                cmd = new OleDbCommand(deleteQuery, myConn);
                cmd.Parameters.AddWithValue("?", CropId);
                cmd.Parameters.AddWithValue("?", UserId);
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

        private void addedQuant_ValueChanged(object sender, EventArgs e)
        {
            AddedQuant = (int)addedQuant.Value;
            TotalPrice = Price * AddedQuant;
            totalPrices.Text = "Total Amount: ₱" + TotalPrice.ToString("N2");
            UpdateCartQuantityInDatabase();
        }
        private void UpdateCartQuantityInDatabase()
        {
            try
            {
                myConn?.Open();
                string updateQuery = "UPDATE Cart SET AddedQuantity = ?, TotalPrice = ? WHERE CropID = ? AND UserID = ?";
                cmd = new OleDbCommand(updateQuery, myConn);
                cmd.Parameters.AddWithValue("?", AddedQuant);
                cmd.Parameters.AddWithValue("?", TotalPrice);
                cmd.Parameters.AddWithValue("?", CropId);
                cmd.Parameters.AddWithValue("?", UserId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cart: " + ex.Message);
            }
            finally
            {
                myConn?.Close();
            }
        }
    }
}
