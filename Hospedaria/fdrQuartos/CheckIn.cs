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
    public partial class CheckIn : Form
    {
        private ConnectionClass db = new ConnectionClass();
        List<int> idCliente = new List<int>();
        List<string> nomeCliente = new List<string>();
        List<int> idQuarto = new List<int>();
        List<string> nomeQuarto = new List<string>();
        List<string> nomepensao = new List<string>();
        List<int> idpensao = new List<int>();

        public Form getform { get; set; }
        public CheckIn()
        {
            InitializeComponent();
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

                nomeCliente.Add(_dr["NOME"].ToString().Trim());//ADICIONA O QUE FOI LIDO NO SQL A LISTA NOME
                idCliente.Add(Convert.ToInt32(_dr["idCLIENTES"]));
            }
            //FECHA CONEXCAO
            db.closeConnection();//O READER PRECISA SER FECHADO, PARA SER ABERTO NOVO READER
            db.SqlConnection();

            //POPULA COMBOBOX HOSPEDAGEM
            query = "select hospedagem.idHOSPEDAGEM , hospedagem.NOME  from HOSPEDAGEM order by hospedagem.idhospedagem";
            db.SqlQuery(query);
            SqlDataReader _dr2 = db.QueryReader();
            while (_dr2.Read())
            {


                nomeQuarto.Add(_dr2["NOME"].ToString().Trim());
                idQuarto.Add(Convert.ToInt32(_dr2["idHOSPEDAGEM"]));


            }
            db.closeConnection();
            db.SqlConnection();
            query = "select * from pensao order by pensao.descricao";
            db.SqlQuery(query);
            SqlDataReader _dr3 = db.QueryReader();
            while (_dr3.Read())
            {


                nomepensao.Add(_dr3["descricao"].ToString().Trim());
                idpensao.Add(Convert.ToInt32(_dr3["idpensao"]));
            }
            db.closeConnection();

            foreach (string item in nomeCliente)
            {
                cbNomeCheckIn.Items.Add(item);
            }
            foreach (string item in nomeQuarto)
            {
                cbQuarto.Items.Add(item);
            }
            foreach (string item in nomepensao)
            {
                cbPensao.Items.Add(item);
            }


            cbPensao.SelectedIndex = 0;
            cbQuarto.SelectedIndex = 0;
            cbNomeCheckIn.SelectedIndex = 0;//SELECIONA O PRIMEIRO INDEX PARA SER MOSTRADO LOGO NO INICIO
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            popComboBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into situacao values('" + idQuarto[cbQuarto.SelectedIndex] + "', '" + idCliente[cbNomeCheckIn.SelectedIndex] + "', '" + idpensao[cbPensao.SelectedIndex] + "', '" + datepicker1.Value + "', '" + datepicker2.Value + "', 'Ocupado')";

            db.SqlConnection();
            db.SqlQuery(query);
            db.QueryRun();
            query = "Update hospedagem set idcondicao = '2' where idhospedagem = '" + idpensao[cbPensao.SelectedIndex] + "'";
            db.SqlQuery(query);
            db.QueryRun();
            db.closeConnection();

        }

        private void CheckIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 objPrin = new Form1();
            this.Hide();
            getform.Visible = true;

        }
    }
}
