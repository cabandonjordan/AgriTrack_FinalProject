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
    public partial class Farmer : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public Farmer()
        {
            InitializeComponent();
            EnsureDataBase();
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            profileInfo pfp = new profileInfo(Form1.LoggedInUser);
            farmerPanel.Controls.Clear();
            pfp.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(pfp);
            pfp.BringToFront();
        }

        private void myCrops_Click(object sender, EventArgs e)
        {
            FarmerCrops crops = new FarmerCrops(Form1.LoggedInUserID);
            farmerPanel.Controls.Clear();
            crops.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(crops);
            crops.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void saleHistory_Click(object sender, EventArgs e)
        {
            FarmerSale sale = new FarmerSale();
            farmerPanel.Controls.Clear();
            sale.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(sale);
            sale.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            FarmerHome home = new FarmerHome(Form1.LoggedInUserID);
            farmerPanel.Controls.Clear();
            home.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(home);
            home.BringToFront();
        }

        private void harvestLog_Click(object sender, EventArgs e)
        {
            HarvestLogs harvest = new HarvestLogs();
            farmerPanel.Controls.Clear();
            harvest.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(harvest);
            harvest.BringToFront();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            FarmersInventory inventory = new FarmersInventory();
            farmerPanel.Controls.Clear();
            inventory.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(inventory);
            inventory.BringToFront();
        }      
    }
}
