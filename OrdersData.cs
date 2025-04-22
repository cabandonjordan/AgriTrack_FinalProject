using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class OrdersData : UserControl
    {
        public int UserID { get; set; }
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public string CustomerNames { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public int PurchaseID { get; set; }
        public string CustomerEmail { get; set; }

        OleDbConnection? myConn;
        public OrdersData(string cropNames, string category, int quantity, string customerName,
                  Image cropImages, string status, DateTime orderDate, string payMethods,
                  decimal total, int userID, int purchaseID, string email)
        {
            InitializeComponent();
            EnsureDatabaseConnection();
            CropName = cropNames;
            Quantity = quantity;
            Category = category;
            CropImage = cropImages;
            CustomerNames = customerName;
            Status = status;
            Total = total;
            UserID = userID;
            OrderDate = orderDate;
            PaymentMethod = payMethods;
            PurchaseID = purchaseID;
            CustomerEmail = email;

            cropsName.Text = cropNames;
            addedQuant.Text = $"Quantity: {quantity}";
            customerNames.Text = customerName;
            categorys.Text = $"Category: {category}";
            cropImage.Image = cropImages;
            statuses.Text = $"Status: {status}";
            datePending.Text = $"Order Date: {orderDate:yyyy-MM-dd}";
            payMethod.Text = $"Payment Method: {payMethods}";
            totalPrice.Text = $"Total Price: ₱{total:N2}";
        }
        private void EnsureDatabaseConnection()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (myConn)
                {
                    myConn.Open();

                    string deleteQuery = "DELETE FROM Purchase WHERE Email = ? AND PurchaseID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", CustomerEmail);
                        cmd.Parameters.AddWithValue("?", PurchaseID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("jordancab09@gmail.com");
                            mail.To.Add(CustomerEmail);
                            mail.Subject = "Order Declined - AgriTrack";

                            MemoryStream cropStream = new MemoryStream();
                            using (Bitmap clonedImage = new Bitmap(CropImage))
                            {
                                clonedImage.Save(cropStream, System.Drawing.Imaging.ImageFormat.Png);
                            }
                            cropStream.Position = 0;

                            LinkedResource cropImg = new LinkedResource(cropStream, "image/png")
                            {
                                ContentId = "CropImageCid",
                                TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                            };

                            string logoPath = @"C:\Users\Jordan\Desktop\BSCPE\2ND YEAR\2ND SEM\CPE262\FINAL PROJECT\ICONS\Dark Green and White Leaf Agriculture Tea Farm Logo.png";
                            LinkedResource logoImg = new LinkedResource(logoPath, "image/png")
                            {
                                ContentId = "LogoImageCid",
                                TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                            };

                            string htmlBody = $@"
<html>
<body>
    <div style='max-width: 600px; margin: auto; padding: 20px; border: 2px solid #f44336; font-family: Arial, sans-serif;'>
        <div style='text-align: center; margin-bottom: 20px;'>
            <img src='cid:LogoImageCid' width='150' />
        </div>
        <h2 style='text-align: center; color: #f44336;'>Order Declined</h2>
        <p style='text-align: center;'>Hello <strong>{CustomerNames}</strong>,</p>
        <p style='text-align: center;'>We regret to inform you that your order has been <strong>declined and removed</strong> from our system.</p>
        <table style='margin: auto;'>
            <tr><td><strong>Crop:</strong></td><td>{CropName}</td></tr>
            <tr><td><strong>Category:</strong></td><td>{Category}</td></tr>
            <tr><td><strong>Quantity:</strong></td><td>{Quantity}</td></tr>
            <tr><td><strong>Total Price:</strong></td><td>₱{Total:N2}</td></tr>
            <tr><td><strong>Payment Method:</strong></td><td>{PaymentMethod}</td></tr>
            <tr><td><strong>Order Date:</strong></td><td>{OrderDate:yyyy-MM-dd}</td></tr>
        </table>
        <br/>
        <p style='text-align: center;'>Crop Image:</p>
        <div style='text-align: center;'>
            <img src='cid:CropImageCid' width='200'/>
        </div>
        <br/>
        <p style='text-align: center;'>We apologize for the inconvenience. Please feel free to browse other available crops in the AgriTrack marketplace.</p>
        <p style='text-align: center;'>Regards,<br/>AgriTrack Team</p>
    </div>
</body>
</html>";

                            AlternateView altView = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                            altView.LinkedResources.Add(logoImg);
                            altView.LinkedResources.Add(cropImg);
                            mail.AlternateViews.Add(altView);

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.Credentials = new NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);

                            MessageBox.Show("Order declined and email sent to the customer.");
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the order.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (myConn)
                {
                    myConn.Open();

                    string selectCropQuery = "SELECT Quantity FROM Crops WHERE CropsName = ?";
                    int currentStock = 0;

                    using (OleDbCommand cropSelectCmd = new OleDbCommand(selectCropQuery, myConn))
                    {
                        cropSelectCmd.Parameters.AddWithValue("?", CropName);
                        object stockResult = cropSelectCmd.ExecuteScalar();
                        if (stockResult == null || !int.TryParse(stockResult.ToString(), out currentStock))
                        {
                            MessageBox.Show("Crop not found in the database.");
                            return;
                        }
                    }

                    string selectPurchaseQuery = "SELECT QuantityBought FROM Purchase WHERE PurchaseID = ?";
                    int orderedQuantity = 0;

                    using (OleDbCommand purchaseSelectCmd = new OleDbCommand(selectPurchaseQuery, myConn))
                    {
                        purchaseSelectCmd.Parameters.AddWithValue("?", PurchaseID);
                        object orderResult = purchaseSelectCmd.ExecuteScalar();
                        if (orderResult == null || !int.TryParse(orderResult.ToString(), out orderedQuantity))
                        {
                            MessageBox.Show("Purchase record not found.");
                            return;
                        }
                    }

                    if (orderedQuantity > currentStock)
                    {
                        MessageBox.Show($"Insufficient stock! Available: {currentStock}, Ordered: {orderedQuantity}");
                        return;
                    }

                    int newStock = currentStock - orderedQuantity;
                    string updateCropQuery = "UPDATE Crops SET Quantity = ? WHERE CropsName = ?";
                    using (OleDbCommand updateCropCmd = new OleDbCommand(updateCropQuery, myConn))
                    {
                        updateCropCmd.Parameters.AddWithValue("?", newStock);
                        updateCropCmd.Parameters.AddWithValue("?", CropName);
                        updateCropCmd.ExecuteNonQuery();
                    }

                    string updatePurchaseStatusQuery = "UPDATE Purchase SET Status = 'Confirmed' WHERE PurchaseID = ?";
                    using (OleDbCommand updatePurchaseCmd = new OleDbCommand(updatePurchaseStatusQuery, myConn))
                    {
                        updatePurchaseCmd.Parameters.AddWithValue("?", PurchaseID);
                        updatePurchaseCmd.ExecuteNonQuery();
                    }

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
                        TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                    };

                    string logoPath = @"C:\Users\Jordan\Desktop\BSCPE\2ND YEAR\2ND SEM\CPE262\FINAL PROJECT\ICONS\Dark Green and White Leaf Agriculture Tea Farm Logo.png";
                    LinkedResource logoImg = new LinkedResource(logoPath, "image/png")
                    {
                        ContentId = "LogoImageCid",
                        TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                    };

                    string qrSection = "";
                    LinkedResource qrImg = null;

                    if (PaymentMethod.ToLower().Contains("gcash"))
                    {
                        string qrPath = @"C:\Users\Jordan\Desktop\BSCPE\2ND YEAR\2ND SEM\CPE262\FINAL PROJECT\ICONS\qrCode.png";
                        qrImg = new LinkedResource(qrPath, "image/png")
                        {
                            ContentId = "QrCodeCid",
                            TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                        };

                        qrSection = @"
                    <p style='text-align: center; font-weight: bold;'>To proceed with GCash payment, please scan the QR code below:</p>
                    <div style='text-align: center; margin-top: 10px;'>
                        <img src='cid:QrCodeCid' width='200'/>
                    </div>
                    <p style='text-align: center;'>After payment, you may reply to this email with your transaction proof for faster processing.</p>";
                    }

                    string htmlBody = $@"
<html>
<body>
    <div style='max-width: 600px; margin: auto; padding: 20px; border: 2px solid #4CAF50; font-family: Arial, sans-serif;'>
        <div style='text-align: center; margin-bottom: 20px;'>
            <img src='cid:LogoImageCid' width='150' />
        </div>
        <h2 style='text-align: center; color: #4CAF50;'>Order Confirmed</h2>
        <p style='text-align: center;'>Hello <strong>{CustomerNames}</strong>,</p>
        <p style='text-align: center;'>Your order has been <strong>confirmed</strong>. See the details below:</p>
        <table style='margin: auto;'>
            <tr><td><strong>Crop:</strong></td><td>{CropName}</td></tr>
            <tr><td><strong>Category:</strong></td><td>{Category}</td></tr>
            <tr><td><strong>Quantity:</strong></td><td>{orderedQuantity}</td></tr>
            <tr><td><strong>Total Price:</strong></td><td>₱{Total:N2}</td></tr>
            <tr><td><strong>Payment Method:</strong></td><td>{PaymentMethod}</td></tr>
            <tr><td><strong>Order Date:</strong></td><td>{OrderDate:yyyy-MM-dd}</td></tr>
        </table>
        <br/>
        <p style='text-align: center;'>Crop Image:</p>
        <div style='text-align: center;'>
            <img src='cid:CropImageCid' width='200'/>
        </div>
        {qrSection}
        <br/>
        <p style='text-align: center;'>Thank you for ordering with AgriTrack. We hope you enjoy your crops!</p>
        <p style='text-align: center;'>Best regards,<br/>AgriTrack Team</p>
    </div>
</body>
</html>";

                    AlternateView altView = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                    altView.LinkedResources.Add(logoImg);
                    altView.LinkedResources.Add(cropImg);
                    if (qrImg != null) altView.LinkedResources.Add(qrImg);

                    mail.AlternateViews.Add(altView);

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    MessageBox.Show("Order confirmed, quantity updated, and email sent.");
                    statuses.Text = "Status: Confirmed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
