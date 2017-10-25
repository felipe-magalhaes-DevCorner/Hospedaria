using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedaria
{
    class ConnectionClass
    {
        // We use these three SQLite objects:
        private SQLiteConnection _conn;
        private SQLiteCommand _cmd;
        private SQLiteDataReader _datareader;
        private SQLiteDataAdapter _datadapter;
        private DataTable _dt;
        public void SQLiteConnection()
        {
            _conn = new SQLiteConnection("Data Source = Hospedaria.db3;Version=3");
            _conn.Open();

        }
        public void sqliteQuery(string pQueryText)
        {
            _cmd = new SQLiteCommand(pQueryText, _conn);
        }
        public DataTable QueryEx()
        {
            _datadapter = new SQLiteDataAdapter(_cmd);
            _dt = new DataTable();
            _datadapter.Fill(_dt);
            return _dt;

        }
        public void NonQueryEx()
        {
            _cmd.ExecuteNonQuery();
        }

    }
}
