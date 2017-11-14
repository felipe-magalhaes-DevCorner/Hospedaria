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
            /////------------------------- AKI DIZEMOS AONDE ESTA O SQL-------------------------------
            //A _CONN PRIMEIRA É MINHA A SEGUNDA DE VOCES SE TIVER UM ERRO CHECAR AKI PRIMEIRO.
            //_conn = new SqlConnection("Data Source = (localdb)\ProjectsV13; Initial Catalog = Hospedaria; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            //_conn = new SqlConnection("Data Source = ANDROIDK1; Initial Catalog = Hospedaria; Persist Security Info = True; User ID = sa; Password = root");
            _conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=hospedaria;Integrated Security=True");
            /////------------------------- ABRO A CONEXAO-------------------------------
            _conn.Open();

        }
        public void SqlQuery(string pQueryText)
            ////
        {
            /////------------------------- DOU COLAR NA QUERO NO SQL E DIGO AONDE COLAR-------------------------------
            _cmd = new SqlCommand(pQueryText, _conn);
        }
        public DataTable QueryDT()
        {
            
            /////------------------------- ME RETORNA UMA TABELA COM O RESULTADO-------------------------------
            _datadapter = new SqlDataAdapter(_cmd);
            _dt = new DataTable();
            _datadapter.Fill(_dt);

            return _dt;

        }
        public SqlDataReader QueryReader()
        {
            /////------------------------- EXECUTA A QUERY E -------------------------------
            /////------------------------- ME RETORNA UM LEITOR, PARA LER AS CELULAS DO RESULTADO DA QUERY-------------------------------
            _datareader = _cmd.ExecuteReader();
            
            
            return _datareader;

            



        }
        public void QueryRun()
        {
            /////------------------------- EXECUTA A QUERY(COMANDOS ---INSERT / UPDATE AKI-------------------------------
            _cmd.ExecuteNonQuery();

        }
        public void closeConnection()
        {
            /////------------------------- FECHO A CONEXAO-------------------------------
            _conn.Close();
            _conn.Dispose();
        }

    }
}
