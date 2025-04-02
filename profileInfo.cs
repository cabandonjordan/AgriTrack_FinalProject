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

namespace AgriTrack_FinalProject
{
    public partial class profileInfo : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string imagePath = "";
        string LoggedInUser = "";
        public profileInfo(string username)
        {
            InitializeComponent();
            LoggedInUser = username;
            LoadPhoto();
        }
        private void uploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    profilePic.ImageLocation = imagePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = null;
            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                imageBytes = File.ReadAllBytes(imagePath);
            }

            using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb"))
            {
                myConn.Open();
                string updateQuery = "UPDATE Users SET UserName = @newUserName, FullName = @fullName, Email = @email, PhoneNumber = @phoneNumber";

                if (imageBytes != null)
                {
                    updateQuery += ", ProfilePic = @profilePic";
                }

                updateQuery += " WHERE UserName = @oldUserName";

                using (OleDbCommand cmd = new OleDbCommand(updateQuery, myConn))
                {
                    cmd.Parameters.AddWithValue("@newUserName", profUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@fullName", profName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", profEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@phoneNumber", profNum.Text.Trim());

                    if (imageBytes != null)
                    {
                        cmd.Parameters.AddWithValue("@profilePic", imageBytes);
                    }

                    cmd.Parameters.AddWithValue("@oldUserName", LoggedInUser.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user information. User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LoadPhoto()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
            myConn.Open();
            string userInfo = "SELECT ProfilePic, FullName, Email, PhoneNumber FROM Users WHERE UserName = @username";
            cmd = new OleDbCommand(userInfo, myConn);
            cmd.Parameters.Add("@username", OleDbType.VarChar).Value = LoggedInUser.Trim();
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Users");
            indexRow = 0;
            if (ds.Tables["Users"]?.Rows.Count > 0)
            {
                DataRow row = ds.Tables["Users"].Rows[0];
                byte[]? data = ds.Tables["Users"].Rows[indexRow]["ProfilePic"] as byte[];
                if (data != null)
                {
                    MemoryStream ms = new MemoryStream(data);
                    profilePic.Image = Image.FromStream(ms);
                }
                profName.Text = row["FullName"].ToString();
                profUsername.Text = LoggedInUser;
                profEmail.Text = row["Email"].ToString();
                profNum.Text = row["PhoneNumber"].ToString();
            }
            myConn.Close();
        }
    }
}
