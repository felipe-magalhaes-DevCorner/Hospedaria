using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedaria.fdrClientes
{
    class clienteSQL
    {
        public void cadastraCliente(string pCPF, string pNOME, string pTELEFONE, string pCELULAR, string pEMAIL, string pCIDADE)
        {
            ConnectionClass db = new ConnectionClass();
            //---------------------------------QUERY QUE GRAVA DADOS DO CLIENTE
            db.SqlConnection();
            db.SqlQuery("INSERT INTO CLIENTES VALUES ('" + pCPF.Trim() + "', '" + pNOME.Trim() + "', '" + pTELEFONE.Trim() + "', '" +pCELULAR.Trim()+ "', '" + pEMAIL + "', '"+pCIDADE+"' )");
            db.QueryRun();
        }
        public void alteraCliente(string pCPF, string pNOME, string pTELEFONE, string pCELULAR, string pEMAIL)
        {

            //INUTIL POR ENQUANTO E TALVEZ SEMPRE
            ConnectionClass db = new ConnectionClass();
            db.SqlConnection();
            
            //db.SqlQuery("UPDATE CLIENTES SET );
            //db.NonQueryEx();
        }


    }
}
