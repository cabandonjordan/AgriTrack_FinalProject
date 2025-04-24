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
using System.Net.Mail;
using System.Net.Mime;

namespace AgriTrack_FinalProject
{
    public partial class CheckOut : Form
    {
        public int shipFee = 50;
        OleDbConnection? myConn;

        private string customerNames;
        private string contactNumber;

        public CheckOut(List<DataAddCart> selectedItems, string customerNames, string contactNumber)
        {
            InitializeComponent();
            EnsureDataBase();

            this.customerNames = customerNames;
            this.contactNumber = contactNumber;

            DisplayCustomerInfo();
            LoadCart(selectedItems);
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCart(List<DataAddCart> selectedItems)
        {
            //decimal subtotal = 0;

            //foreach (var item in selectedItems)
            //{
            //    ProductsOrdered ordered = new ProductsOrdered(
            //        item.CropName,
            //        item.Quantity,
            //        item.Price,
            //        item.Category,
            //        item.CropImage,
            //        item.UserId,
            //        item.FarmerName,
            //        item.CropId,
            //        item.TotalPrice,
            //        item.AddedQuant
            //    );

            //    subtotal += item.TotalPrice;
            //    ProductsOrderedPanel.Controls.Add(ordered);
            //}

            //itemSubtotal.Text = "₱" + subtotal.ToString("N2");
            //shipTotal.Text = "₱" + shipFee.ToString("N2");

            //decimal orderTotal = subtotal + shipFee;
            //totPriceCrops.Text = "₱" + orderTotal.ToString("N2");
            decimal subtotal = 0;
            int itemCount = 0;

            foreach (var item in selectedItems)
            {
                ProductsOrdered ordered = new ProductsOrdered(
                    item.CropName,
                    item.Quantity,
                    item.Price,
                    item.Category,
                    item.CropImage,
                    item.UserId,
                    item.FarmerName,
                    item.CropId,
                    item.TotalPrice,
                    item.AddedQuant,
                    item.CartsID
                );

                subtotal += item.TotalPrice;
                ProductsOrderedPanel.Controls.Add(ordered);
                itemCount++;
            }

            int totalShipping = itemCount * shipFee;
            decimal orderTotal = subtotal + totalShipping;

            itemSubtotal.Text = "₱" + subtotal.ToString("N2");
            shipTotal.Text = "₱" + totalShipping.ToString("N2");
            totPriceCrops.Text = "₱" + orderTotal.ToString("N2");
        }

        private void DisplayCustomerInfo()
        {
            customerName.Text = customerNames;
            customerNum.Text = contactNumber;
            MessageBox.Show($"Name: {customerNames}, Contact: {contactNumber}");
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            if (myConn == null)
            {
                MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string paymentMethod = "";
            DateTime orderDate = DateTime.Now;

            if (cashDelivery.Checked)
                paymentMethod = "Cash on Delivery";
            else if (gCash.Checked)
                paymentMethod = "GCash";
            else
            {
                MessageBox.Show("⚠ Please select a payment method.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerEmail = GetCustomerEmail();

            if (string.IsNullOrWhiteSpace(customerEmail))
            {
                MessageBox.Show("⚠ Email not found for this customer.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                myConn.Open();
                OleDbTransaction transaction = myConn.BeginTransaction();

                try
                {
                    foreach (ProductsOrdered item in ProductsOrderedPanel.Controls)
                    {
                        string insertPurchase = @"
                        INSERT INTO Purchase 
                        (CustomerID, CropID, QuantityBought, TotalPrices, SaleDate, PaymentMethod, CropName, CustomerName, 
                         FarmersName, CustomerAddress, Status, Email, CartID) 
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        OleDbCommand insertCmd = new OleDbCommand(insertPurchase, myConn, transaction);
                        insertCmd.Parameters.AddWithValue("CustomerID", Form1.LoggedInUserID);
                        insertCmd.Parameters.AddWithValue("CropID", item.CropId);
                        insertCmd.Parameters.AddWithValue("QuantityBought", item.AddedQuant);
                        insertCmd.Parameters.AddWithValue("TotalPrices", item.TotalPrice + 50);
                        insertCmd.Parameters.AddWithValue("SaleDate", orderDate.ToShortDateString());
                        insertCmd.Parameters.AddWithValue("PaymentMethod", paymentMethod);
                        insertCmd.Parameters.AddWithValue("CropName", item.CropName);
                        insertCmd.Parameters.AddWithValue("CustomerName", customerNames);
                        insertCmd.Parameters.AddWithValue("FarmersName", item.FarmersNames);
                        insertCmd.Parameters.AddWithValue("CustomerAddress", addressTxt.Text);
                        insertCmd.Parameters.AddWithValue("Status", "Pending");
                        insertCmd.Parameters.AddWithValue("Email", customerEmail);
                        insertCmd.Parameters.AddWithValue("CartID", item.CartsID);

                        insertCmd.ExecuteNonQuery();

                        OleDbCommand getPurchaseIDCmd = new OleDbCommand("SELECT @@IDENTITY", myConn, transaction);
                        int purchaseID = Convert.ToInt32(getPurchaseIDCmd.ExecuteScalar());

                        string updateCart = @"
                        UPDATE Cart 
                        SET CheckedOut = ?, PurchaseID = ? 
                        WHERE CartID = ?";

                        OleDbCommand updateCmd = new OleDbCommand(updateCart, myConn, transaction);
                        updateCmd.Parameters.AddWithValue("CheckedOut", true);
                        updateCmd.Parameters.AddWithValue("PurchaseID", purchaseID);
                        updateCmd.Parameters.AddWithValue("CartID", item.CartsID);
                        updateCmd.ExecuteNonQuery();

                        SendHtmlEmail(customerEmail, customerNames, item.CropName, item.Category, item.AddedQuant, item.TotalPrice, paymentMethod, orderDate, item.CropImage);
                    }

                    transaction.Commit();
                    MessageBox.Show("✅ Order successfully placed and confirmation email sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("❌ Failed to complete order: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to start transaction: " + ex.Message);
            }
            finally
            {
                if (myConn != null && myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
        //app password
        //dcbh fsap gziu dzpn
        private void SendHtmlEmail(string CustomerEmail, string CustomerNames, string CropName, string Category, int orderedQuantity, decimal Total, string PaymentMethod, DateTime OrderDate, Image CropImage)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("jordancab09@gmail.com");
            mail.To.Add(CustomerEmail);
            mail.Subject = "Order Confirmed - AgriTrack";

            MemoryStream cropStream = new MemoryStream();
            using (Bitmap clonedImage = new Bitmap(CropImage))
            {
                clonedImage.Save(cropStream, System.Drawing.Imaging.ImageFormat.Png);
            }
            cropStream.Position = 0;
            LinkedResource cropImg = new LinkedResource(cropStream, "image/png")
            {
                ContentId = "CropImageCid",
                TransferEncoding = TransferEncoding.Base64
            };

            string logoPath = @"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\ICONS\\Dark Green and White Leaf Agriculture Tea Farm Logo.png";
            LinkedResource logoImg = new LinkedResource(logoPath, "image/png")
            {
                ContentId = "LogoImageCid",
                TransferEncoding = TransferEncoding.Base64
            };

            string qrSection = "";
            LinkedResource qrImg = null;

            string htmlBody = $@"
<html>
  <body>
    <div style='max-width: 600px; margin: auto; padding: 20px; border: 2px solid #4CAF50; font-family: Arial, sans-serif;'>
      <div style='text-align: center; margin-bottom: 20px;'>
        <img src='cid:LogoImageCid' width='150' />
      </div>
      <h2 style='text-align: center; color: #4CAF50;'>Order Confirmed</h2>
      <p style='text-align: center;'>Hello <strong>{CustomerNames}</strong>,</p>
      <p style='text-align: center;'>Thank you for your order! Here are your order details:</p>
      <table style='margin: auto;'>
        <tr><td><strong>Crop:</strong></td><td>{CropName}</td></tr>
        <tr><td><strong>Category:</strong></td><td>{Category}</td></tr>
        <tr><td><strong>Quantity:</strong></td><td>{orderedQuantity} kg</td></tr>
        <tr><td><strong>Total Price:</strong></td><td>₱{Total:N2}</td></tr>
        <tr><td><strong>Shipping Fee:</strong></td><td>₱50.00</td></tr>
        <tr><td><strong>Grand Total:</strong></td><td>₱{(Total + 50):N2}</td></tr>
        <tr><td><strong>Payment Method:</strong></td><td>{PaymentMethod}</td></tr>
        <tr><td><strong>Order Date:</strong></td><td>{OrderDate:yyyy-MM-dd}</td></tr>
        <tr><td><strong>Shipping Address:</strong></td><td>{addressTxt.Text}</td></tr>
        <tr><td><strong>Status:</strong></td><td>Pending - waiting for confirmation of the seller</td></tr>
      </table>
      <br/>
      <p style='text-align: center;'>Crop Image:</p>
      <div style='text-align: center;'>
        <img src='cid:CropImageCid' width='200'/>
      </div>
      <br/>
      <p style='text-align: center;'>We will notify you once the farmer confirms your order.</p>
      <p style='text-align: center;'>Best regards,<br/>AgriTrack Team</p>
    </div>
  </body>
</html>";

            AlternateView altView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            altView.LinkedResources.Add(logoImg);
            altView.LinkedResources.Add(cropImg);
            if (qrImg != null) altView.LinkedResources.Add(qrImg);

            mail.AlternateViews.Add(altView);

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn"),
                EnableSsl = true
            };

            smtpServer.Send(mail);
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
    }
}
