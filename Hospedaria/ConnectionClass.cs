using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedaria
{
    class ConnectionClass
    {
        // We use these three Sql objects:
        private SqlConnection _conn;
        private SqlCommand _cmd;
        private SqlDataReader _datareader;
        private SqlDataAdapter _datadapter;
        private DataTable _dt;
        public void SqlConnection()
        {
            _conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=hospedaria;Integrated Security=True");
            _conn.Open();

        }
        public void SqlQuery(string pQueryText)
        {
            _cmd = new SqlCommand(pQueryText, _conn);
        }
        public DataTable QueryDT()
        {
            
            _datadapter = new SqlDataAdapter(_cmd);
            _dt = new DataTable();
            _datadapter.Fill(_dt);

            return _dt;

        }
        public SqlDataReader QueryReader()
        {
            
            _datareader = _cmd.ExecuteReader();
            
            
            return _datareader;

            



        }
        public void QueryRun()
        {
            
            _cmd.ExecuteNonQuery();

        }
        public void closeConnection()
        {
            _conn.Close();
            _conn.Dispose();
        }

    }
}
