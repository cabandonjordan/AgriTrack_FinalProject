using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgriTrack_FinalProject
{
    public partial class Form1 : Form
    {
        public static string LoggedInUser { get; private set; }
        public static int LoggedInUserID { get; private set; }
        public Form1()
        {
            InitializeComponent();
            password.KeyDown += Password_KeyDown;
        }
        OleDbConnection? myConn;

        bool dragging;
        Point dragCursorPoint;
        Point dragFormPoint;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void createAcc_Click(object sender, EventArgs e)
        {
            CreateAccount cr = new CreateAccount();

            //int x = (this.ClientSize.Width - cr.Width) / 2;
            //int y = (this.ClientSize.Height - cr.Height) / 2;

            //cr.Location = new Point(x, y);
            //cr.Size = new Size(384, 565);

            // this.Controls.Add(cr);
            //cr.BringToFront();
            //panelRight.Controls.Clear();
            cr.Dock = DockStyle.Fill;
            panelRight.Controls.Add(cr);
            cr.BringToFront();
            userName.Clear();
            password.Clear();
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                password.UseSystemPasswordChar = false;
                password.PasswordChar = '\0';
            }
            else
            {
                password.UseSystemPasswordChar = true;
                password.PasswordChar = '•';
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userName.Text == "admin" && password.Text == "123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
                this.Close();
                return;
            }

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");

            if (string.IsNullOrWhiteSpace(userName.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter username & password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = HashPassword(password.Text);
            //string query = "SELECT UserID, UserType FROM Users WHERE UserName = ? AND [Password] = ?";
            string query = "SELECT UserID, UserType FROM Users WHERE StrComp(UserName, ?, 0) = 0 AND StrComp([Password], ?, 0) = 0";

            try
            {
                myConn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@username", userName.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            string userType = reader.GetString(1);
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoggedInUser = userName.Text;
                            LoggedInUserID = userId;
                            switch (userType.ToLower())
                            {
                                case "farmer":
                                    Farmer farmer = new Farmer();
                                    this.Hide();
                                    farmer.ShowDialog();
                                    this.Close();
                                    break;
                                case "customer":
                                    Customer customer = new Customer();
                                    this.Hide();
                                    customer.ShowDialog();
                                    this.Close();
                                    break;
                                default:
                                    MessageBox.Show("Invalid user role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }
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
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fr = new ForgotPassword();
            fr.Dock = DockStyle.Fill;
            panelRight.Controls.Add(fr);
            fr.BringToFront();
            userName.Clear();
            password.Clear();
        }
    }
}
