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
    public partial class ResetPassword : Password
    {
        OleDbCommand? cmd;
        string Email;
        public ResetPassword(string UserEmail)
        {
            InitializeComponent();
            Email = UserEmail;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                newPass.UseSystemPasswordChar = false;
                confirmPass.UseSystemPasswordChar = false;
                newPass.PasswordChar = '\0';
                confirmPass.PasswordChar = '\0';
            }
            else
            {
                newPass.UseSystemPasswordChar = true;
                confirmPass.UseSystemPasswordChar = true;
                newPass.PasswordChar = '•';
                confirmPass.PasswordChar = '•';
            }
        }
        //private string HashPassword(string password)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder builder = new StringBuilder();
        //        foreach (byte b in bytes)
        //        {
        //            builder.Append(b.ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }
        //}
        private void resetPass_Click(object sender, EventArgs e)
        {
            myConn = EnsureDataBase();
            string updatePass = "UPDATE Users SET [Password] = @password WHERE Email = @email";
            myConn.Open();
            if (newPass.Text == string.Empty || confirmPass.Text == string.Empty)
            {
                MessageBox.Show("Please fill up all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPass.Text != confirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = HashPassword(newPass.Text);
            cmd = new OleDbCommand(updatePass, myConn);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myConn.Close();

            Form1 form = new Form1();
            this.Parent.Controls.Remove(this);
        }
    }
}
