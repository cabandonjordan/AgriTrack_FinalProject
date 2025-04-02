using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class UpdateCrops : Form
    {
        OleDbConnection? myConn;
        OleDbCommand? cmd;
        private string CropName;
        int userID;
        string imagePath = "";
        public string UpdatedCropName { get; private set; }
        public int UpdatedQuantity { get; private set; }
        public decimal UpdatedPrice { get; private set; }
        public string UpdatedCategory { get; private set; }
        public Image UpdatedCropImage { get; private set; }
        public CropData CropData { get; private set; }
        public UpdateCrops(int usersID, string cropName, int quantity, decimal price, string category, Image cropImage)
        {
            InitializeComponent();
            EnsureDataBase();
            userID = usersID;
            CropName = cropName;

            upCropName.Text = cropName;
            updateQuant.Text = quantity.ToString();
            updatePrice.Text = price.ToString("F2");
            upCropCategory.SelectedItem = category;
            updateImage.Image = cropImage;
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    updateImage.ImageLocation = imagePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newCropName = upCropName.Text.Trim();
            int.TryParse(updateQuant.Text, out int newQuantity);
            decimal.TryParse(updatePrice.Text, out decimal newPrice);
            string newCategory = upCropCategory.Text.Trim();

            if (string.IsNullOrEmpty(newCropName))
            {
                MessageBox.Show("Crop name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                myConn?.Open();
                string updateQuery = "UPDATE Crops SET CropsName = ?, Quantity = ?, Price = ?, Category = ? WHERE CropsName = ? AND UserID = ?";
                cmd = new OleDbCommand(updateQuery, myConn);

                cmd.Parameters.AddWithValue("?", newCropName);
                cmd.Parameters.AddWithValue("?", newQuantity);
                cmd.Parameters.AddWithValue("?", newPrice);
                cmd.Parameters.AddWithValue("?", newCategory);
                cmd.Parameters.AddWithValue("?", CropName);
                cmd.Parameters.AddWithValue("?", userID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    UpdatedCropName = newCropName;
                    UpdatedQuantity = newQuantity;
                    UpdatedPrice = newPrice;
                    UpdatedCategory = newCategory;
                    UpdatedCropImage = updateImage.Image;

                    CropData = new CropData(UpdatedCropName, UpdatedQuantity, UpdatedPrice, UpdatedCategory, UpdatedCropImage, userID, "");
                    MessageBox.Show("Crop data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No crop data was updated. Please check the crop name and try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating crop: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn?.Close();
            }
        }
    }
}
