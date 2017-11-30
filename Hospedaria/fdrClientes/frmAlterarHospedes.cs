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
        public string nome { get; set; }
        public Form RefToMenu { get; set; }
        private static bool exitend;
        //---------------------------------DEFINE O OBJETO DA CONEXAO SQL
        private ConnectionClass db = new ConnectionClass();
        public static string nameListAll; 

        
        private static int selectedrow;
        public frmAlterarHospedes(string Value = "", bool exit = false)
        {
            InitializeComponent();
            cbNomeAlt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbNomeAlt.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCPF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCPF.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (Value != "")
            {
                
                nameListAll = Value.Trim();

            }
            exitend = exit;
            //RefToMenu.Hide();




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
                    cbCPF.SelectedIndex = cbCPF.Items.IndexOf(_dr["CPF"].ToString().Trim());
                    mskCelular.Text = _dr["CELULAR"].ToString().Trim();
                    mskTelefone.Text = _dr["TELEFONE"].ToString().Trim();
                    txtCidade.Text = _dr["CIDADE"].ToString().Trim();
                    txtEMAIL.Text = _dr["EMAIL"].ToString().Trim();
                }
            }
            
            db.closeConnection();//FECHA CONEXCAO
        }

        private void frmAlterarHospedes_Load(object sender, EventArgs e)
        {
            bool RunOnce = true;
            //---------------------- POPULA COMBOBOX NOME----------------------
            string query = "select clientes.nome, clientes.idclientes, clientes.cpf from clientes order by clientes.nome";
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
                cbCPF.Items.Add(_dr["CPF"].ToString().Trim());


            }
            db.closeConnection();
            if (cbNomeAlt.Items.Count > 0)
            {
                cbNomeAlt.SelectedIndex = 0;
                cbCPF.SelectedIndex = 0;
            }

            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //---------------------- DELETE CLIENTE----------------------
            string query = "delete from clientes where clientes.idCLIENTES = '" + selectedrow + "'";
            db.SqlConnection();
            db.SqlQuery(query);
            db.QueryRun();
            db.closeConnection();
            MessageBox.Show("Cliente excluido.");
            this.Hide();
            RefToMenu.Show();
            
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //atualiza clientes
            string query = "update clientes set nome = '"+cbNomeAlt.Text.Trim()+"', cpf = '"+cbCPF.Text.Trim()+ "', telefone = '" + mskTelefone.Text.Trim() + "', celular = '" + mskCelular.Text.Trim() + "', cidade = '" + txtCidade.Text.Trim() + "', email = '" + txtEMAIL.Text.Trim().ToLower() + "' where clientes.idCLIENTES = '" + selectedrow + "'";
            db.SqlConnection();
            db.SqlQuery(query);
            db.QueryRun();
            db.closeConnection();
            MessageBox.Show("Cliente atualizado.");
            this.Hide();
            RefToMenu.Show();
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

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //---------------------- PEGA DADOS cpf SELECIONADO NA COMBOBOX----------------------
            //string nameControl = cbNomeAlt.Text;
            string query = "select * from clientes where clientes.cpf = '" + cbCPF.Text.Trim() + "'"; //<<<<<<<<QUERY
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
                    
                    cbNomeAlt.SelectedIndex = cbNomeAlt.Items.IndexOf(_dr["NOME"].ToString().Trim());
                    mskCelular.Text = _dr["CELULAR"].ToString();
                    mskTelefone.Text = _dr["TELEFONE"].ToString();
                    txtCidade.Text = _dr["CIDADE"].ToString();
                    txtEMAIL.Text = _dr["EMAIL"].ToString();
                }
            }

            db.closeConnection();//FECHA CONEXCAO
            if (nameListAll != null)
            {
                cbNomeAlt.SelectedIndex = cbNomeAlt.Items.IndexOf(nameListAll);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListAll objList = new frmListAll();
            this.Hide();
            objList.ShowDialog();
            


        }

        private void frmAlterarHospedes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1 objPrin = new Form1();
            if (exitend)
            {
                exitend = false;
            }
            else
            {
                RefToMenu.Visible = true;
                
            }
            

        }
    }
}
