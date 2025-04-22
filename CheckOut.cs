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
            // Check if database connection is initialized
            if (myConn == null)
            {
                MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string paymentMethod = "";
            DateTime orderDate = DateTime.Now;

            // Check payment method
            if (cashDelivery.Checked)
                paymentMethod = "Cash on Delivery";
            else if (gCash.Checked)
                paymentMethod = "GCash";
            else
            {
                MessageBox.Show("⚠ Please select a payment method.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare email body
            string subject = "AgriTrack - Order Confirmation";
            StringBuilder body = new StringBuilder();
            body.AppendLine($"Hello {customerNames},");
            body.AppendLine("\nThank you for your purchase from AgriTrack!");
            body.AppendLine("Here’s your order summary:\n");

            decimal subtotal = 0;
            int itemCount = ProductsOrderedPanel.Controls.Count;

            // Loop through all the items in the order panel and generate the summary
            foreach (ProductsOrdered item in ProductsOrderedPanel.Controls)
            {
                body.AppendLine($"- {item.CropName} x{item.AddedQuant} @ ₱{item.Price:N2} = ₱{item.TotalPrice:N2}");
                subtotal += item.TotalPrice;
            }

            int totalShipping = itemCount * shipFee;
            decimal orderTotal = subtotal + totalShipping;

            body.AppendLine($"\nPayment Method: {paymentMethod}");
            body.AppendLine($"\nSubtotal: ₱{subtotal:N2}");
            body.AppendLine($"Shipping: ₱{totalShipping:N2}");
            body.AppendLine($"Total: ₱{orderTotal:N2}");
            body.AppendLine("\nYour order is currently pending and will be processed shortly.\n\nThank you!");

            string customerEmail = GetCustomerEmail();

            if (string.IsNullOrWhiteSpace(customerEmail))
            {
                MessageBox.Show("⚠ Email not found for this customer.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                myConn.Open();

                // Start a transaction
                OleDbTransaction transaction = myConn.BeginTransaction();

                try
                {
                    // Insert into Purchase table
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
                    }

                    foreach (ProductsOrdered item in ProductsOrderedPanel.Controls)
                    {
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
                    }

                    transaction.Commit();

                    SendEmail(customerEmail, subject, body.ToString());

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
        private void SendEmail(string recipientEmail, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("jordancab09@gmail.com");
            mail.To.Add(recipientEmail); 
            mail.Subject = subject;
            mail.Body = body;

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn");
            smtpServer.EnableSsl = true;

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
