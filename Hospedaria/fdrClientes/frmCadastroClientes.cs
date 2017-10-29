using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrClientes
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteSQL cd = new clienteSQL();
            cd.cadastraCliente(mskCPF.Text.Trim(), txtName.Text.Trim(), mskTelefone.Text.Trim(), mskCelular.Text.Trim(), txtEmail.Text.Trim().ToLower());



        }

        private void InsertClient()
        {

            ConnectionClass db = new ConnectionClass();
            db.SqlConnection();
            db.SqlQuery("INSERT INTO CLIENTES VALUES ('" + mskCPF.Text.Trim() + "', '" + txtName.Text.Trim() + "', '" + mskTelefone.Text + "', '" + mskCelular.Text + "', '" + txtEmail.Text.Trim() + "' )");
            db.NonQueryEx();

        }

        void CheckifNull(string pifNull)
        {

        }
    }
}
