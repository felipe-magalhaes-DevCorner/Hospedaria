using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
        DateTime dataProximaReserva;
        

        public Form getform { get; set; }
        public CheckIn()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            InitializeComponent();
        }
        private void popComboBoxes()
        {
            //bool RunOnce = true;
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
            DateTime dateini = DateTime.Now;
            datepicker1.Value = dateini;
            datepicker2.Value = Convert.ToDateTime(dateini.AddDays(1).ToString("dd/MM/yyyy 11:59"));
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            popComboBoxes();
        }
        public void ChecaReserva()
        {
            db.SqlConnection();
            string query = "select hospedagem.idcondicao from hospedagem where idhospedagem = '" + idQuarto[cbQuarto.SelectedIndex] + "'";
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            int condicao = 0;
            while (_dr.Read())
            {
                condicao = Convert.ToInt32(_dr["idcondicao"]);
            }
            db.closeConnection();
            switch (condicao)
            {
                case 1:
                    {

                        QuartoLivreContinuaCheckin();
                    }
                    break;
                case 2:
                    {

                        MessageBox.Show("O quarto esta em ocupado.");

                    }
                    break;
                case 3:
                    {
                        MessageBox.Show("O quarto esta em manutencao.");
                        
                        
                    }
                    break;
                case 4:
                    {
                        MessageBox.Show("Existe uma reserva para esse horario. Gostaria de carregala?");
                        DialogResult dialogResult = MessageBox.Show(string.Format("Existe uma reserva para o dia {0}, agendar Data Saída para esse dia?", dataProximaReserva.ToString("dd/MM/yyyy 11:59")), "Cadastrado", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            query = "select * from reservas where idhospedagem = '" + idQuarto[cbQuarto.SelectedIndex] + "'";
                            db.SqlConnection();
                            db.SqlQuery(query);
                            SqlDataReader _dr2 = db.QueryReader();


                            while (_dr2.Read())
                            {
                                cbNomeCheckIn.SelectedIndex = idCliente.IndexOf(Convert.ToInt32(_dr2["idcliente"]));
                                cbQuarto.SelectedIndex = idQuarto.IndexOf(Convert.ToInt32(_dr2["idhospedagem"]));
                                datepicker1.Value = Convert.ToDateTime(_dr2["datareserva"]);
                                datepicker2.Value = Convert.ToDateTime(_dr2["datasaida"]);


                            }
                            db.closeConnection();
                            if (cbPensao.Text != "")
                            {

                                QuartoLivreContinuaCheckin();
                            }

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Não cadastrado. É preciso a concordancia da saida ate a data limite.");

                        }
                        

                    }
                    break;


            }



            
        }

        private void QuartoLivreContinuaCheckin()
        {
            //checa se
            //dataentrade é maior q data saida
            //se dataentrada esta em branco
            //se data entrada é maior q o tempo agora.
            if (datepicker1.Value >= datepicker2.Value || datepicker1.Value.ToString() == "" || datepicker1.Value > DateTime.Now)
            {
                MessageBox.Show("A data de entrada e saida nao conferem.");
            }
            else
            //passou pelos filtros anteriores
            {
                string query;
                db.SqlConnection();
                bool validaHospedagem = false;
                //CHECA SE TEM ALGUMA RESERVA PARA AQUELE QUARTO
                int quarto = idQuarto[cbQuarto.SelectedIndex];
                //query = "select datareserva from reservas where idhospedagem = '" + idQuarto + "' order by datareserva limit 1";
                query = "select idhospedagem, DATARESERVA from RESERVAS where idHOSPEDAGEM = '" + idQuarto[cbQuarto.SelectedIndex] + "' and ((DATARESERVA between '" + datepicker1.Value.ToString("MM/dd/yyyy hh:mm") + "' and '" + datepicker2.Value.ToString("MM/dd/yyyy hh:mm") + "') or (DATASAIDA between '" + datepicker1.Value.ToString("MM/dd/yyyy hh:mm") + "' and '" + datepicker1.Value.ToString("MM/dd/yyyy hh:mm") + "' ))";
                Clipboard.SetText(query);
                db.SqlQuery(query);
                SqlDataReader _dr = db.QueryReader();
                bool QuartoLivre = true;
                ////////////--------- chega reservas------------//////////
                if (_dr.HasRows)//se retornar alguma reserva
                {
                    //---------------- tem alguma reserva -----

                    while (_dr.Read())//pega a data da proxima reserva
                    {
                        if (QuartoLivre)
                        {
                            dataProximaReserva = Convert.ToDateTime(_dr["datareserva"]);
                            QuartoLivre = false;//existe alguma reserva para aquela data
                        }

                    }


                }
                db.closeConnection();
                db.SqlConnection();


                //------------------------------------------------------------------------
                if (QuartoLivre)//nao existe reservas para aquele quarto
                {
                    //vamos inserir reserva tudo certo aki
                    // ------------------- sem data de saida e sem reserva marcada
                    if (datepicker2.Value.ToString() == "")//sem reserva porem data final sem saida
                    {
                        //CASO NAO HAJA DATA DE SAIDA, VAI PRO SQL DATASAIDA NULL
                        query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value + "',NULL, 'Ocupado' )";
                        db.SqlQuery(query);
                        db.QueryRun();

                    }
                    else
                    {
                        //existe data de saida, e nao existe reserva naquelas datas
                        //insere perfeito o q ta escrito
                        DateTime date1 = Convert.ToDateTime(datepicker1.Value);
                        query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value.ToString("MM/dd/yyyy hh:mm") + "','" + datepicker2.Value.ToString("MM/dd/yyyy hh:mm") + "', 'Ocupado' )";
                        db.SqlQuery(query);
                        db.QueryRun();
                    }
                    validaHospedagem = true;

                }
                else//CASO O SQL TENHA RETORNADO ALGUMA RESERVA PARA AQUELE QUARTO ALGUM DIA
                {
                    //-----------------ja existe uma reserva algum dia
                    //checa se alguma data esta em branco
                    //data inicial nao pode ser em branco
                    //data final pode ser em branco ou ate a data da proxima reserva naquele quarto
                    if (datepicker2.Value.ToString() == "")//caso a data saida esteja em branco
                    {
                        DialogResult dialogResult = MessageBox.Show(string.Format("Existe uma reserva para o dia {0}, agendar Data Saída para esse dia?", dataProximaReserva.ToString("dd/MM/yyyy 11:59")), "Cadastrado", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //INSERE COM DATA SAIDA IGUAL AS 11:59 DO DIA DO INICIO DA PROXIMA RESERVA PARA AQUELE QUARTO
                            query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value + "', '" + dataProximaReserva.ToString("dd/MM/yyyy 11:59") + "', 'Ocupado' )";
                            db.SqlQuery(query);
                            db.QueryRun();
                            validaHospedagem = true;

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Não cadastrado. É preciso a concordancia da saida ate a data limite.");

                        }

                    }


                }
                if (validaHospedagem)
                {

                    query = "update hospedagem set idcondicao = '2' where idhospedagem = '" + idQuarto[cbQuarto.SelectedIndex] + "'";
                    db.SqlQuery(query);
                    db.QueryRun();
                    db.closeConnection();
                    MessageBox.Show("CheckIn Efetuado com sucesso!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nomeCliente.Contains(cbNomeCheckIn.Text.Trim()))
            {
                ChecaReserva();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Cliente nao cadastrado. Gostaria de cadastrar?", "Cadastrado", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //caso o cliente nao esteja cadastrado
                    fdrClientes.frmCadastroClientes objCadastro = new fdrClientes.frmCadastroClientes();
                    this.Hide();
                    objCadastro.Show();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //faz nada
                }
            }
            










            //string query = "insert into situacao values('" + idQuarto[cbQuarto.SelectedIndex] + "', '" + idCliente[cbNomeCheckIn.SelectedIndex] + "', '" + idpensao[cbPensao.SelectedIndex] + "', '" + datepicker1.Value + "', '" + datepicker2.Value + "', 'Ocupado')";

            //db.SqlConnection();
            //db.SqlQuery(query);
            //db.QueryRun();
            //query = "Update hospedagem set idcondicao = '2' where idhospedagem = '" + idpensao[cbPensao.SelectedIndex] + "'";
            //db.SqlQuery(query);
            //db.QueryRun();
            //db.closeConnection();

        }

        private void CheckIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 objPrin = new Form1();
            this.Hide();
            getform.Visible = true;

        }
    }
}
