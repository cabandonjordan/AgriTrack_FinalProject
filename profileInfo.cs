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
using AForge.Video;
using AForge.Video.DirectShow;

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

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private bool isCameraRunning = false;

        public profileInfo(string username)
        {
            InitializeComponent();
            LoggedInUser = username;
            LoadInfo();
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
            if (currentFrame != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    currentFrame.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
            }
            else if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                imageBytes = File.ReadAllBytes(imagePath);
            }
            //if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            //{
            //    imageBytes = File.ReadAllBytes(imagePath);
            //}

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
        private void LoadInfo()
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

        private void cameraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCameraRunning)
                {
                    videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                    if (videoDevices.Count == 0)
                    {
                        MessageBox.Show("No camera found!");
                        return;
                    }

                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    videoSource.Start();
                    isCameraRunning = true;
                }
                else
                {
                    if (currentFrame != null)
                    {
                        profilePic.Image = (Bitmap)currentFrame.Clone();
                    }

                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.NewFrame -= video_NewFrame;
                    }

                    isCameraRunning = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera error: " + ex.Message);
            }
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            currentFrame = (Bitmap)eventArgs.Frame.Clone();
            profilePic.Image = (Bitmap)currentFrame.Clone();
        }
    }
}
