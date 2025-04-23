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
    public partial class Admin : Form
    {
        private FarmerHome? farmerHomeUC;
        AgriTrackDataBase DataBase = new AgriTrackDataBase();
        public Admin()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            adminPanel.Controls.Clear();
            userManager.Dock = DockStyle.Fill;
            adminPanel.Controls.Add(userManager);
            userManager.BringToFront();
        }

        private void browseCrops_Click(object sender, EventArgs e)
        {
            farmerHomeUC = new FarmerHome(Form1.LoggedInUserID);
            adminPanel.Controls.Clear();
            farmerHomeUC.Dock = DockStyle.Fill;
            adminPanel.Controls.Add(farmerHomeUC);
            farmerHomeUC.BringToFront();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (farmerHomeUC != null)
            {
                farmerHomeUC.FilterCrops(searchBox.Text);
            }
        }

        private void salesOverview_Click(object sender, EventArgs e)
        {
            SalesOverview salesOverview = new SalesOverview();
            adminPanel.Controls.Clear();
            salesOverview.Dock = DockStyle.Fill;
            adminPanel.Controls.Add(salesOverview);
            salesOverview.BringToFront();
        }
    }
}
