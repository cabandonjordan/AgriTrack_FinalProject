using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AgriTrack_FinalProject
{
    internal class AgriTrackMethods : AgriTrackDataBase
    {
        OleDbConnection? myConn;
        public string cropName {get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public string farmerName { get; set; }
        public void LoadCrops()
        {
            myConn = GetConnection();
        }
    }
}
