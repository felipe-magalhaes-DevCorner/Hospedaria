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
        //---------------------------------DEFINE O OBJETO DA CONEXAO SQL
        private ConnectionClass db = new ConnectionClass();

        
        private static int selectedrow;
        public frmAlterarHospedes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //---------------------- PEGA DADOS CLIENTE SELECIONADO NA COMBOBOX----------------------
            //string nameControl = cbNomeAlt.Text;
            string query = "select * from clientes where clientes.nome = '"+ cbNomeAlt.Text.Trim() + "'"; //<<<<<<<<QUERY
            db.SqlConnection();
            db.SqlQuery(query);
            
            using (SqlDataReader _dr = db.QueryReader())
            {
                if (_dr.Read())
                {
                    //---------------------------------GRAVA O QUE FOR LIDO POR LINHA DE RESPOSTA DO SQL NAS VARIAVEIS DO C#
                    //---------------------------------GRAVA O QUE FOR LIDO POR LINHA DE RESPOSTA DO SQL NAS VARIAVEIS DO C#
                    //---------------------------------GRAVA O QUE FOR LIDO POR LINHA DE RESPOSTA DO SQL NAS VARIAVEIS DO C#
                    //---------------------------------GRAVA O QUE FOR LIDO POR LINHA DE RESPOSTA DO SQL NAS VARIAVEIS DO C#
                    //---------------------------------GRAVA O QUE FOR LIDO POR LINHA DE RESPOSTA DO SQL NAS VARIAVEIS DO C#
                    //---------------------------------GRAVA O QUE FOR LIDO POR LINHA DE RESPOSTA DO SQL NAS VARIAVEIS DO C#
                    selectedrow = Convert.ToInt32(_dr["idCLIENTES"].ToString().Trim());
                    mskCPF.Text = _dr["CPF"].ToString();
                    mskCelular.Text = _dr["CELULAR"].ToString();
                    mskTelefone.Text = _dr["TELEFONE"].ToString();
                    txtCidade.Text = _dr["CIDADE"].ToString();
                    txtEMAIL.Text = _dr["EMAIL"].ToString();
                }
            }
            
            db.closeConnection();//FECHA CONEXCAO
        }

        private void frmAlterarHospedes_Load(object sender, EventArgs e)
        {
            bool RunOnce = true;
            //---------------------- POPULA COMBOBOX NOME----------------------
            string query = "select clientes.nome, clientes.idclientes from clientes order by clientes.nome";
            db.SqlConnection();
            db.SqlQuery(query);
            

            //POPULA LEITOR DADOS (VARIOS DADOS)DE SQL, LEITOR DE TABELA DIGAMOS ASSIM
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                if (RunOnce)
                {
                    selectedrow = Convert.ToInt32(_dr["idCLIENTES"]);
                    RunOnce = false;
                }

                cbNomeAlt.Items.Add(_dr["NOME"].ToString().Trim());
                

            }
            db.closeConnection();
            cbNomeAlt.SelectedIndex = 0;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //---------------------- DELETE CLIENTE----------------------
            string query = "delete from clientes where clientes.idCLIENTES = '" + selectedrow + "'";
            db.SqlConnection();
            db.SqlQuery(query);
            db.QueryRun();
            db.closeConnection();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            string query = "update clientes set  where clientes.idCLIENTES = '" + selectedrow + "'";
            db.SqlConnection();
            db.SqlQuery(query);
            db.closeConnection();

        }
        public sealed class RunOnceAction
        {
            private readonly Action F;
            private bool hasRun;

            public RunOnceAction(Action f)
            {
                F = f;
            }

            public void run()
            {
                if (hasRun) return;
                F();
                hasRun = true;
            }
        }
    }
}
