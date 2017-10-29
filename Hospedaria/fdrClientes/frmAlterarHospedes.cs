using System;
using System.Data.SqlClient;
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
    public partial class frmAlterarHospedes : Form
    {
        private ConnectionClass db = new ConnectionClass();
        public frmAlterarHospedes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameControl = cbNomeAlt.Text;
            string query = "select * from clientes where clientes.nome = '"+ nameControl+ "'";
            db.SqlConnection();
            db.SqlQuery(query);
            //db.NonQueryEx();

            
                
            using (SqlDataReader _dr = db.QueryReader())
            {
                if (_dr.Read())
                {
                    mskCPF.Text = _dr["CPF"].ToString();
                    mskCelular.Text = _dr["CELULAR"].ToString();
                    mskTelefone.Text = _dr["TELEFONE"].ToString();
                    txtCidade.Text = _dr["CIDADE"].ToString();
                    txtEMAIL.Text = _dr["EMAIL"].ToString();


                }
            }
            db.closeConnection();


        }

        private void frmAlterarHospedes_Load(object sender, EventArgs e)
        {
            
            string query = "select clientes.nome from clientes order by clientes.nome";
            db.SqlConnection();
            db.SqlQuery(query);
            //db.NonQueryEx();
            
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                cbNomeAlt.Items.Add(_dr["NOME"].ToString().Trim());
            }
            db.closeConnection();

            cbNomeAlt.SelectedIndex = 0;
            
            


        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //---------------------- DELETE CLIENTE----------------------
            string query = "delete from clientes where clientes.nome = '"+cbNomeAlt.Text+"' and clientes.cpf = '"+mskCPF.Text+"'";
            db.SqlConnection();
            db.SqlQuery(query);
            db.closeConnection();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
