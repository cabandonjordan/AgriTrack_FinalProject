using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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
    public partial class forAddCrops : Form
    {
        OleDbConnection? myConn;
        OleDbCommand? cmd;
        string imagePath = "";
        public int UserID { get; private set; }
        public CropData CropData { get; private set; }
        public string FullName { get; private set; }

        public forAddCrops(int userId)
        {
            InitializeComponent();
            EnsureDataBase();
            UserID = userId;
            FetchUserFullName();           
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }

        private void FetchUserFullName()
        {
            try
            {
                myConn.Open();
                string query = "SELECT FullName FROM Users WHERE UserID = @userId";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@userId", UserID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    FullName = result.ToString();
                }
                else
                {
                    FullName = "Unknown";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user name: " + ex.Message);
                FullName = "Unknown";
            }
            finally
            {
                myConn.Close();
            }
        }
        private void uploadPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    cropImage.ImageLocation = imagePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (cropName.Text == string.Empty || quantityTxt.Text == string.Empty || priceKilo.Text == string.Empty || cropCategory.SelectedItem == null
      || string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            string addCrops;
            string cropNames = cropName.Text;
            int quantity = int.Parse(quantityTxt.Text);
            decimal price = decimal.Parse(priceKilo.Text);
            DateTime dateAdded = DateTime.Now;
            string category = cropCategory.SelectedItem?.ToString() ?? "Uncategorized";
            Image cropImg = cropImage.Image;

            myConn?.Open();

            addCrops = "INSERT INTO Crops (UserID, CropsName, Quantity, Price, Category, CropsImage) " +
                          "VALUES (?, ?, ?, ?, ?, ?)";

            OleDbCommand cmd = new OleDbCommand(addCrops, myConn);
            cmd.Parameters.AddWithValue("?", UserID);
            cmd.Parameters.AddWithValue("?", cropNames);
            cmd.Parameters.AddWithValue("?", quantity);
            cmd.Parameters.AddWithValue("?", price);
            cmd.Parameters.AddWithValue("?", category);
            cmd.Parameters.Add("?", OleDbType.VarBinary).Value = imageBytes;
            cmd.ExecuteNonQuery();

            CropData = new CropData(cropNames, quantity, price, category, cropImg, UserID, FullName);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
