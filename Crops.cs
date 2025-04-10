using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriTrack_FinalProject
{
    public class Crops : UserControl
    {
        OleDbConnection? myConn;
        public string CropName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image CropImage { get; set; }
        public int UserID { get; set; }
        public string FarmerName { get; set; }
        public void EnsureDatabaseConnection()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
    }
}
