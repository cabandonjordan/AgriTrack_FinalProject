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
    public partial class UserManager : UserControl
    {
        OleDbConnection? myConn;
        public UserManager()
        {
            InitializeComponent();
            EnsureDataBase();
            LoadUsers();
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void LoadUsers()
        {
            try
            {
                myConn?.Open();

                string query = "SELECT UserID, FullName, Email, UserType, PhoneNumber, ProfilePic FROM Users";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("UserID");
                dt.Columns.Add("FullName");
                dt.Columns.Add("Email");
                dt.Columns.Add("UserType");
                dt.Columns.Add("PhoneNumber");
                dt.Columns.Add("ProfilePic", typeof(Image));

                while (reader.Read())
                {
                    byte[] imageBytes = reader["ProfilePic"] != DBNull.Value ? (byte[])reader["ProfilePic"] : null;
                    Image profileImage = null;

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            profileImage = Image.FromStream(ms);
                        }
                    }

                    dt.Rows.Add(
                        reader["UserID"].ToString(),
                        reader["FullName"].ToString(),
                        reader["Email"].ToString(),
                        reader["UserType"].ToString(),
                        reader["PhoneNumber"].ToString(),
                        profileImage
                    );
                }

                userGrid.DataSource = dt;

                DataGridViewImageColumn imageCol = (DataGridViewImageColumn)userGrid.Columns["ProfilePic"];
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                userGrid.RowTemplate.Height = 60;
                userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message);
            }
            finally
            {
                myConn?.Close();
            }
        }
    }
}
