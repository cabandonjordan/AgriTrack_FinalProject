using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            profileInfo pfp = new profileInfo(Form1.LoggedInUser);
            customerPanel.Controls.Clear();
            pfp.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(pfp);
            pfp.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void marketPlace_Click(object sender, EventArgs e)
        {
            MarketPlace mp = new MarketPlace(Form1.LoggedInUserID);
            customerPanel.Controls.Clear();
            mp.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(mp);
            mp.BringToFront();
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            customerPanel.Controls.Clear();
            sc.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(sc);
            sc.BringToFront();
        }

        private void purchaseHistory_Click(object sender, EventArgs e)
        {
            PurchaseHistory ph = new PurchaseHistory();
            customerPanel.Controls.Clear();
            ph.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(ph);
            ph.BringToFront();
        }
    }
}
