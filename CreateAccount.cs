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
using System.Security.Cryptography;

namespace AgriTrack_FinalProject
{
    public partial class CreateAccount : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow; 
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                createPass.UseSystemPasswordChar = false;
                confirmPass.UseSystemPasswordChar = false;
                createPass.PasswordChar = '\0';
                confirmPass.PasswordChar = '\0';
            }
            else
            {
                createPass.UseSystemPasswordChar = true;
                confirmPass.UseSystemPasswordChar = true;
                createPass.PasswordChar = '•';
                confirmPass.PasswordChar = '•';
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
            string addInfo = "INSERT INTO Users (UserName, FullName, Email, PhoneNumber, [Password], UserType) VALUES (@username, @fullname, @email, @phonenum, @password, @usertype)";
            myConn.Open();
            if (createUser.Text == string.Empty || nameTxt.Text == string.Empty || createPass.Text == string.Empty || confirmPass.Text == string.Empty
                || emailTxt.Text == string.Empty || phoneNum.Text == string.Empty)
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(userRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role (Farmer or Customer).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (createPass.Text != confirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd = new OleDbCommand(addInfo, myConn);
            cmd.Parameters.AddWithValue("@username", createUser.Text);
            cmd.Parameters.AddWithValue("@fullname", nameTxt.Text);
            cmd.Parameters.AddWithValue("@email", emailTxt.Text);
            cmd.Parameters.AddWithValue("@phonenum", phoneNum.Text);
            cmd.Parameters.AddWithValue("@password", HashPassword(createPass.Text));
            cmd.Parameters.AddWithValue("@usertype", userRole.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Parent.Controls.Remove(this);
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
