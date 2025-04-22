using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class BuyNow : Form
    {
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public int UserId { get; set; }
        public string FarmerNames { get; set; }
        public int CropId { get; set; }
        public decimal TotalPrice { get; set; }
        public int AddedQuant { get; set; }
        public decimal OrderTotal { get; set; }
        public int ShipFee { get; set; } = 50;

        OleDbConnection? myConn;
        OleDbCommand cmd;
        public BuyNow(string cropNames, int quantitys, decimal prices, string categorys, Image cropImages, int userId, string farmerName, int cropId, decimal total, int addQuant)
        {
            InitializeComponent();
            EnsureDatabaseConnection();
            CropName = cropNames;
            Quantity = quantitys;
            Price = prices;
            Category = categorys;
            CropImage = cropImages;
            UserId = userId;
            FarmerNames = farmerName;
            AddedQuant = addQuant;
            CropId = cropId;
            TotalPrice = total;
            OrderTotal = TotalPrice + ShipFee;

            LoadCustomerInfo();

            FarmerName.Text = FarmerNames;
            cropName.Text = CropName;
            cropImage.Image = CropImage;
            addedQuants.Value = AddedQuant;
            cropPrice.Text = "₱" + Price.ToString("N2");

            UpdateTotals();
        }
        private void EnsureDatabaseConnection()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void LoadCustomerInfo()
        {
            try
            {
                myConn.Open();
                string query = "SELECT FullName, PhoneNumber FROM Users WHERE UserID = ?";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", UserId);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    customerName.Text = reader["FullName"]?.ToString() ?? "";
                    customerNum.Text = reader["PhoneNumber"]?.ToString() ?? "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer info: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
        private void UpdateTotals()
        {
            AddedQuant = (int)addedQuants.Value;

            TotalPrice = Price * AddedQuant;
            OrderTotal = TotalPrice + ShipFee;

            subTotal.Text = "₱" + TotalPrice.ToString("N2");
            TotPrice.Text = "₱" + OrderTotal.ToString("N2");
            itemSubtotal.Text = "₱" + TotalPrice.ToString("N2");
            shipTotal.Text = "₱" + ShipFee.ToString("N2");
            totPriceCrops.Text = "₱" + OrderTotal.ToString("N2");
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addedQuants_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        private string GetCustomerEmail()
        {
            string email = "";

            try
            {
                myConn.Open();
                string query = "SELECT Email FROM Users WHERE UserID = ?";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", Form1.LoggedInUserID);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    email = reader["Email"]?.ToString() ?? "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }

            return email;
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            //    string paymentMethod = "";
            //    DateTime orderDate = DateTime.Now;
            //    if (cashDelivery.Checked)
            //        paymentMethod = "Cash on Delivery";
            //    else if (gCash.Checked)
            //        paymentMethod = "GCash";
            //    else
            //    {
            //        MessageBox.Show("Please select a payment method.");
            //        return;
            //    }

            //    string customerEmail = GetCustomerEmail();

            //    if (string.IsNullOrEmpty(customerEmail))
            //    {
            //        MessageBox.Show("Customer email not found.");
            //        return;
            //    }

            //    string subject = "AgriTrack Order Receipt - Pending Confirmation";
            //    string body = $"Hello {customerName.Text},\n\n" +
            //                  "Thank you for your order! Here are your order details:\n\n" +
            //                  $"Crop: {CropName}\n" +
            //                  $"Category: {Category}\n" +
            //                  $"Farmer: {FarmerNames}\n" +
            //                  $"Quantity: {AddedQuant}\n" +
            //                  $"Price per item: ₱{Price:N2}\n" +
            //                  $"Subtotal: ₱{TotalPrice:N2}\n" +
            //                  $"Shipping Fee: ₱{ShipFee:N2}\n" +
            //                  $"Total: ₱{OrderTotal:N2}\n" +
            //                  $"Payment Method: {paymentMethod}\n\n" +
            //                  $"Status: Pending - waiting for confirmation of the seller.\n\n" +
            //                  "We will notify you once the farmer confirms your order.\n\n" +
            //                  "Regards,\nAgriTrack Team";

            //    try
            //    {
            //        myConn.Open();

            //        string insertQuery = @"INSERT INTO Purchase 
            //(CustomerID, CropID, QuantityBought, TotalPrices, SaleDate, 
            // PaymentMethod, CropName, CustomerName, FarmersName, CustomerAddress, Status) 
            //VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            //        cmd = new OleDbCommand(insertQuery, myConn);
            //        cmd.Parameters.AddWithValue("CustomerID", UserId);
            //        cmd.Parameters.AddWithValue("CropID", CropId);
            //        cmd.Parameters.AddWithValue("QuantityBought", AddedQuant);
            //        cmd.Parameters.AddWithValue("TotalPrices", OrderTotal);
            //        cmd.Parameters.AddWithValue("SaleDate", orderDate.ToShortDateString());
            //        cmd.Parameters.AddWithValue("PaymentMethod", paymentMethod);
            //        cmd.Parameters.AddWithValue("CropName", CropName);
            //        cmd.Parameters.AddWithValue("CustomerName", customerName.Text);
            //        cmd.Parameters.AddWithValue("FarmersName", FarmerNames);
            //        cmd.Parameters.AddWithValue("CustomerAddress", addressTxt.Text);
            //        cmd.Parameters.AddWithValue("Status", "Pending");

            //        cmd.ExecuteNonQuery();

            //        MailMessage mail = new MailMessage();
            //        mail.From = new MailAddress("jordancab09@gmail.com");
            //        mail.To.Add(customerEmail);
            //        mail.Subject = subject;
            //        mail.Body = body;

            //        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //        smtp.Credentials = new System.Net.NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn");
            //        smtp.EnableSsl = true;
            //        smtp.Send(mail);

            //        MessageBox.Show("Order placed successfully!\nA confirmation receipt has been sent to your email.",
            //                        "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Failed to place order: " + ex.Message);
            //    }
            //    finally
            //    {
            //        if (myConn.State == ConnectionState.Open)
            //            myConn.Close();
            //    }
            string paymentMethod = "";
            DateTime orderDate = DateTime.Now;

            if(addressTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter your address.");
                return;
            }
            if (cashDelivery.Checked)
                paymentMethod = "Cash on Delivery";
            else if (gCash.Checked)
                paymentMethod = "GCash";
            else
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string customerEmail = GetCustomerEmail();

            if (string.IsNullOrEmpty(customerEmail))
            {
                MessageBox.Show("Customer email not found.");
                return;
            }

            try
            {

                myConn.Open();
                string insertQuery = @"INSERT INTO Purchase 
            (CustomerID, CropID, QuantityBought, TotalPrices, SaleDate, 
             PaymentMethod, CropName, CustomerName, FarmersName, CustomerAddress, Status, Email) 
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                cmd = new OleDbCommand(insertQuery, myConn);
                cmd.Parameters.AddWithValue("CustomerID", UserId);
                cmd.Parameters.AddWithValue("CropID", CropId);
                cmd.Parameters.AddWithValue("QuantityBought", AddedQuant);
                cmd.Parameters.AddWithValue("TotalPrices", OrderTotal);
                cmd.Parameters.AddWithValue("SaleDate", orderDate.ToShortDateString());
                cmd.Parameters.AddWithValue("PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("CropName", CropName);
                cmd.Parameters.AddWithValue("CustomerName", customerName.Text);
                cmd.Parameters.AddWithValue("FarmersName", FarmerNames);
                cmd.Parameters.AddWithValue("CustomerAddress", addressTxt.Text);
                cmd.Parameters.AddWithValue("Status", "Pending");
                cmd.Parameters.AddWithValue("Email", customerEmail);

                cmd.ExecuteNonQuery();
                myConn.Close();

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jordancab09@gmail.com");
                mail.To.Add(customerEmail);
                mail.Subject = "AgriTrack Order Receipt - Pending Confirmation";

                if (CropImage == null)
                {
                    MessageBox.Show("Crop image is null. Cannot attach.");
                    return;
                }

                MemoryStream cropStream = new MemoryStream();
                using (Bitmap clonedImage = new Bitmap(CropImage))
                {
                    clonedImage.Save(cropStream, System.Drawing.Imaging.ImageFormat.Png);
                }
                cropStream.Position = 0;

                LinkedResource cropImg = new LinkedResource(cropStream, "image/png");
                cropImg.ContentId = "CropImageCid";
                cropImg.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;

                string logoPath = @"C:\Users\Jordan\Desktop\BSCPE\2ND YEAR\2ND SEM\CPE262\FINAL PROJECT\ICONS\Dark Green and White Leaf Agriculture Tea Farm Logo.png";
                LinkedResource logoImg = new LinkedResource(logoPath, "image/png");
                logoImg.ContentId = "LogoImageCid";
                logoImg.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;

                string htmlBody = $@"
<html>
<body>
    <div style='max-width: 600px; margin: auto; padding: 20px; border: 2px solid #4CAF50; font-family: Arial, sans-serif;'>
        <div style='text-align: center; margin-bottom: 20px;'>
            <img src='cid:LogoImageCid' width='150' />
        </div>
        <h2 style='text-align: center;'>Order Confirmation</h2>
        <p style='text-align: center;'>Hello <strong>{customerName.Text}</strong>,</p>
        <p style='text-align: center;'>Thank you for your order! Here are your order details:</p>
        <table style='margin: auto;'>
            <tr><td><strong>Crop:</strong></td><td>{CropName}</td></tr>
            <tr><td><strong>Category:</strong></td><td>{Category}</td></tr>
            <tr><td><strong>Farmer:</strong></td><td>{FarmerNames}</td></tr>
            <tr><td><strong>Quantity:</strong></td><td>{AddedQuant}</td></tr>
            <tr><td><strong>Price per item:</strong></td><td>₱{Price:N2}</td></tr>
            <tr><td><strong>Subtotal:</strong></td><td>₱{TotalPrice:N2}</td></tr>
            <tr><td><strong>Shipping Fee:</strong></td><td>₱{ShipFee:N2}</td></tr>
            <tr><td><strong>Total:</strong></td><td>₱{OrderTotal:N2}</td></tr>
            <tr><td><strong>Address:</strong></td><td>{addressTxt.Text}</td></tr>
            <tr><td><strong>Payment Method:</strong></td><td>{paymentMethod}</td></tr>
            <tr><td><strong>Status:</strong></td><td>Pending - waiting for confirmation of the seller</td></tr>
        </table>
        <br/>
        <p style='text-align: center;'>Crop Image:</p>
        <div style='text-align: center;'>
            <img src='cid:CropImageCid' width='200'/>
        </div>
        <br/>
        <p style='text-align: center;'>We will notify you once the farmer confirms your order.</p>
        <p style='text-align: center;'>Regards,<br/>AgriTrack Team</p>
    </div>
</body>
</html>";

                AlternateView altView = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                altView.LinkedResources.Add(logoImg);
                altView.LinkedResources.Add(cropImg);
                mail.AlternateViews.Add(altView);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Order placed successfully!\nA confirmation receipt has been sent to your email.",
                                "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to place order: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }//with logo
        }
    }
}