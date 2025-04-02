using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace AgriTrack_FinalProject
{
    public partial class ForgotPassword : UserControl
    {
        string UserEmail;
        string generateOTP;
        int count = 30;
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private void generateAndSendOTP()
        {
            Random random = new Random();
            generateOTP = random.Next(100000, 999999).ToString();

            try
            {
                sendOTPEmail(UserEmail, generateOTP);
                MessageBox.Show("OTP has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sendOTPEmail(string user, string generateOTP)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("jordancab09@gmail.com", "dcbh fsap gziu dzpn");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jordancab09@gmail.com");
                mail.To.Add(user);
                mail.Subject = "OTP Verification";
                mail.Body = "Your OTP is: " + generateOTP;

                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void countDown()
        {
            resendOTP.Enabled = false;
            count = 30;
            timerOTP.Interval = 1000;
            timerOTP.Tick += timerOTP_Tick;
            timerOTP.Start();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void timerOTP_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                resendOTP.Text = "Resend OTP (" + count + ")";
            }
            else
            {
                timerOTP.Stop();
                resendOTP.Enabled = true;
                resendOTP.Text = "Resend OTP";
            }
        }
        private string enteredOTP()
        {
            return otp1.Text + otp2.Text + otp3.Text + otp4.Text + otp5.Text + otp6.Text;
        }
        private void resendOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generateAndSendOTP();
            countDown();
        }

        private void confirmOTP_Click(object sender, EventArgs e)
        {
            string enterOTP = enteredOTP();
            if (enteredOTP() == generateOTP)
            {
                MessageBox.Show("OTP Verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPassword reset = new ResetPassword(UserEmail);
                Control parentPanel = this.Parent;

                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(this);
                    reset.Dock = DockStyle.Fill;
                    parentPanel.Controls.Add(reset);
                    reset.BringToFront();
                }
                else
                {
                    MessageBox.Show("Error: Parent panel not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            string enteredEmail = emailPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredEmail))
            {
                MessageBox.Show("Please enter your email!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RetrieveEmailFromDatabase(enteredEmail);

            if (!string.IsNullOrEmpty(UserEmail))
            {
                generateAndSendOTP();
                countDown();
            }
            else
            {
                MessageBox.Show("Email not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RetrieveEmailFromDatabase(string enteredEmail)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                try
                {
                    myConn.Open();
                    string query = "SELECT Email FROM Users WHERE Email = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Email", enteredEmail);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            UserEmail = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
