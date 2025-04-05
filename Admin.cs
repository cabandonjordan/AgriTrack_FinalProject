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
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
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
        //myConn = DataBase.GetConnection();
        //myConn.Open();
        //da = new OleDbDataAdapter("SELECT *FROM Users", myConn);
        //ds = new DataSet();
        //da.Fill(ds, "Users");
        //adminDataGrid.DataSource = ds.Tables["Users"];
        //myConn.Close();
        private void loadUsers_Click(object sender, EventArgs e)
        {
           
        }
    }
}
