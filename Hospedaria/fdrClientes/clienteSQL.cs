using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedaria.fdrClientes
{
    class clienteSQL
    {
        public void cadastraCliente(string pCPF, string pNOME, string pTELEFONE, string pCELULAR, string pEMAIL)
        {
            ConnectionClass db = new ConnectionClass();
            db.SqlConnection();
            db.SqlQuery("INSERT INTO CLIENTES VALUES ('" + pCPF + "', '" + pNOME + "', '" + pTELEFONE + "', '" +pCELULAR+ "', '" + pEMAIL + "' )");
            db.NonQueryEx();
        }
        public void alteraCliente(string pCPF, string pNOME, string pTELEFONE, string pCELULAR, string pEMAIL)
        {
            ConnectionClass db = new ConnectionClass();
            db.SqlConnection();
            //db.SqlQuery("UPDATE CLIENTES SET );
            //db.NonQueryEx();
        }


    }
}
