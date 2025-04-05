using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AgriTrack_FinalProject
{
    internal class AgriTrackDataBase : DataBase
    {
        public OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }
    }
}
