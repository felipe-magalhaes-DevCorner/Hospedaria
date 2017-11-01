using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrQuartos
{
    public partial class frmReservas : Form
    {
        private ConnectionClass db = new ConnectionClass();
        private static int selectedrow;
        private static int selectedrowhospedagem;
        private static int selectedrowpensao;
        List<string> listNames = new List<string>();
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            popComboBoxes();
        }
        

        private void popComboBoxes()
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
                    //pega o index do primeiro item
                    selectedrow = Convert.ToInt32(_dr["idCLIENTES"]);
                    RunOnce = false;
                }
                listNames.Add(_dr["NOME"].ToString().Trim());
                cbNomeRes.Items.Add(_dr["NOME"].ToString().Trim());
                cbNomeRes.SelectedIndex = 0;


            }

            query = "select hospedagem.idhospedagem , hospedagem.nome  from pensao order by hospedagem.idhospedagem";
            db.SqlQuery(query);
            _dr = db.QueryReader();
            while (_dr.Read())
            {
                if (RunOnce)
                {
                    selectedrowhospedagem = Convert.ToInt32(_dr["idhospedagem"]);
                    RunOnce = false;
                }

                cbQuarto.Items.Add(_dr["descricao"].ToString().Trim());


            }

            db.closeConnection();
            cbNomeRes.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listNames.Contains(cbNomeRes.Text))
            {
                db.SqlConnection();
                string query = "INSERT INTO RESERVAS values ('" + selectedrowhospedagem + "','" + selectedrow + "','" + datepicker1.Value.ToLocalTime() + "')";
                db.SqlQuery(query);
                db.QueryRun();
                db.closeConnection();

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Cliente nao cadastrado. Gostaria de cadastrar?", "Erro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    fdrClientes.frmCadastroClientes objCadastro = new fdrClientes.frmCadastroClientes();
                    objCadastro.ShowDialog();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //faz nada volta para a tela que ja estava
                }
            }


        }

        private void cbNomeRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.SqlConnection();
            string query = ("select clientes.idclientes from clientes where clientes.nome = '"+cbNomeRes.Text+"'");
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                selectedrow = Convert.ToInt32(_dr["idCLIENTES"]);
            }

            db.closeConnection();
        }

        private void cbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.SqlConnection();
            string query = ("select hospedagem.idhospedagem from hospedagem where hospedagem.descricao = '" + cbQuarto.Text + "'");
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                selectedrowhospedagem = Convert.ToInt32(_dr["idhospedagem"]);
            }

            db.closeConnection();
        }
    }
}
