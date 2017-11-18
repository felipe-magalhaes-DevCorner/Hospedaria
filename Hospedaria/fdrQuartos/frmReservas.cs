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
using System.Globalization;
using System.Threading;

namespace Hospedaria.fdrQuartos
{
    public partial class frmReservas : Form
    {
        private ConnectionClass db = new ConnectionClass();
        private static int selectedrow; //VARIAVEL GLOBAL PARA SEMPRE TER O VALOR DO ID SQL DO QUE ESTIVER SELECIONADO NA COMBOBOX
        private static int selectedrowhospedagem;    //VARIAVEL GLOBAL PARA SEMPRE TER O VALOR DO ID SQL DO QUE ESTIVER SELECIONADO NA COMBOBOX DA HOSPEDAGEM   
        List<string> listNames = new List<string>();// LISTAS COM OS NOMES
        public Form getform { get; set; }

        public frmReservas()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");





        }
        



        private void frmReservas_Load(object sender, EventArgs e)
        {
            //EXECUTA AO ABRIR O FORMULARIO
            popComboBoxes();//CHAMA METODO PARA POPULAR COMBOBOX NO LOAD
            //datepicker1.Format = DateTimePickerFormat.Custom;
           // datepicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            datepicker1.Value = Convert.ToDateTime(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy 14:00:00"));
            datepicker2.Value = Convert.ToDateTime(DateTime.Now.AddDays(2).ToString("dd/MM/yyyy 11:59:00"));
            datepicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            datepicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            
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
                listNames.Add(_dr["NOME"].ToString().Trim());//ADICIONA O QUE FOI LIDO NO SQL A LISTA NOME
                cbNomeRes.Items.Add(_dr["NOME"].ToString().Trim());//ADICIONA O QUE FOI LIDO NO SQL Á COMBOBOX NOME



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
                if (RunOnce)
                {
                    selectedrowhospedagem = Convert.ToInt32(_dr2["idhospedagem"]);
                    RunOnce = false;
                }

                cbQuarto.Items.Add(_dr2["NOME"].ToString().Trim());


            }

            db.closeConnection();
            cbNomeRes.SelectedIndex = 0;//SELECIONA O PRIMEIRO INDEX PARA SER MOSTRADO LOGO NO INICIO
            cbQuarto.SelectedIndex = 0;
        }
        private bool checkIfAlreadyReserved()
        {
            db.SqlConnection();
            //PEGO DO SQL TODAS AS RESERVAS DO HOTEL
            string query = query = "select reservas.idhospedagem, reservas.datareserva, reservas.datasaida from reservas where reservas.idhospedagem = '"+selectedrowhospedagem+"'";
            db.SqlQuery(query);
            DateTime date = DateTime.Now;
            //ABRASILEIRO O PROGRAMA
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            DateTime datePrevistaSaida;
            DateTime dateReserva;
            bool termina = true;
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())//RODAR ENQUANTO TIVER CELULAS PARA LER
            {
     
                    if (datepicker1.Value >= DateTime.Now) // A DATA DA RESERVA É MAIOR Q A DATA DE HOJE?
                    {
                        dateReserva = Convert.ToDateTime(_dr["datareserva"].ToString()).ToLocalTime();//PEGA DATAS DE RESERVAS DO SQL
                        datePrevistaSaida = Convert.ToDateTime(_dr["datasaida"].ToString()).ToLocalTime();
                    // CONFERE SE JA NAO TEM RESERVAS
                        if (datepicker1.Value.ToLocalTime() > dateReserva && datepicker1.Value.ToLocalTime() > datePrevistaSaida) 
                        {

                            termina = true; //NAO TEM DEIXA PASSAR                          

                        }
                        else
                        {
                            MessageBox.Show("Ja existe uma reserva para essa data");
                            return false;
                            
                        }                       

                    }
                    else
                    {
                        MessageBox.Show("Data da reserva incorreta! Essa data ja passou.");
                        
                        return false;//A DATA DA RESERVA JA PASSOU
                        
                    }
            }
            db.closeConnection(); // FECHA CONEXAO
            if (termina)
            {
                return true;//SE PASSOU A RESERVA O METODO RETORNA VERDADE
            }
            else
            {
                return false;
            }
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //---------------------------------BOTAO GRAVAR//---------------------------------
            List<string> _listaClientes = new List<string>();
            db.SqlConnection();
            //---------------------------------PEGA NOMES CLIENTES SQL PARA COMPARAÇÃO(REDUNDANTE POR ENQUANTO, SERA ALTERADO)
            string query = "SELECT CLIENTES.NOME FROM CLIENTES";
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                _listaClientes.Add(_dr["NOME"].ToString().Trim());
            }
            if (cbNomeRes.Text != "")//CHEGA SE NOME ESTA EM BRANCO
            {
                if (_listaClientes.Contains(cbNomeRes.Text.Trim()))//CHEGA SE É UM CLIENTE CADASTRADO
                {
                    if (cbQuarto.Text.Trim() != "")//CHEGA SE UM QUARTO FOI SELECIONADO
                    {
                        Inserecadastro();//PROCEDE COM O CADASTRO CHAMASNDO O METODO CADASTRO
                    }
                    else
                    {
                        MessageBox.Show("Escolha um quarto!");//QUARTO EM BRANCO
                    }
                }
                else
                {
                    //CLIENTE NAO CADASTRADO! QUER CADASTRAR?
                    DialogResult dialogResult = MessageBox.Show("Cliente nao cadastrado, gostaria de cadastrar agora?", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        fdrClientes.frmCadastroClientes frmCadastroClientes = new fdrClientes.frmCadastroClientes();
                        frmCadastroClientes.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //SE CLICLOU EM NAO... FAZ NADA ELE QUER CORRIGIR
                    }

                }

            }
            else
            {
                MessageBox.Show("Insira o nome do cliente!");//NOME EM BRANCO
            }
            ////---------------------------------TERMINA CADASTRO
        }

        private void Inserecadastro()
        {
            //---------------------------------CHAMA O METODO QUE CONFERE SE JA ESTA RESERVADO//---------------------------------
            if (checkIfAlreadyReserved())
            {
                //---------------------------------CHEGA NOME CLIENTE NOVAMENTE ANTES DA INSERCAO
                if (listNames.Contains(cbNomeRes.Text))
                {
                    db.SqlConnection();
                    string query = "INSERT INTO RESERVAS values ('" + selectedrowhospedagem + "','" + selectedrow + "','"+datepicker1.Value.ToString("dd/MM/yyyy 14:00") + "','"+datepicker2.Value.ToString("dd/MM/yyyy 11:59") +"')";
                    db.SqlQuery(query);//COLA A QUERY
                    db.QueryRun();//EXECUTA A QUERY
                    db.closeConnection();//FECHA CONEXAO
                    MessageBox.Show("Reserva Efetuada!");//DEU TUDO CERTO!!

                }
                else
                {
                    //---------------------------------CLIENTE NAO CADASTRADO
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
            else
            {
                MessageBox.Show("Nao cadastrou!");//DEU RUIM AKI
            }
            
        }

        private void cbNomeRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---------------------------------PEGA NO SQL O INDEX DO CLIENTE QUE FOI SELECIONADO, TAMBEM REDUNDANTE SERA MUDADO PARA LISTA GLOBAL
            db.closeConnection();
            db.SqlConnection();
            string query = ("select clientes.idclientes from clientes where clientes.nome = '"+cbNomeRes.Text+"'");
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                selectedrow = Convert.ToInt32(_dr["idCLIENTES"]);//POPULA VARIAVEL GLOBAL COM VALOR SELECIONADO
            }

            db.closeConnection();//FECHA CONEXAO
        }

        private void cbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //db.SqlConnection();
            //string query = "select reservas.datareserva, reservas.datasaida from reservas where idquarto = '" + selectedrowhospedagem + "'";
            //db.SqlQuery(query);
            //SqlDataReader _dr = db.QueryReader();
            //while (_dr.Read())
            //{
            //    //selectedrowhospedagem = Convert.ToInt32(_dr["idhospedagem"]);

            //}
            ////monthCalendar1.Select
            //db.closeConnection();







            //---------------------------------PEGA OS DADOS DO SQL DA HOSPEDAGEM SELECIONADA, REDUNDANTE MESMOS CASOS ANTERIORES
            db.SqlConnection();
            string query = ("select hospedagem.idhospedagem from hospedagem where hospedagem.NOME = '" + cbQuarto.Text + "'");
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                selectedrowhospedagem = Convert.ToInt32(_dr["idhospedagem"]);
            }

            db.closeConnection();
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            //INUTIL POR ENQUANTO


        }

        private void frmReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1 objPrincipal = new Form1();
            //objPrincipal.Show();
        }

        private void frmReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 objPrincipal = new Form1();
            objPrincipal.Show();
        }

        private void cbQuarto_MouseMove(object sender, MouseEventArgs e)
        {
            if (cbQuarto.SelectedIndex == 0 || cbQuarto.SelectedIndex == 1)
            {
                toolTip1.SetToolTip(cbQuarto, "Suite Master. RS: 140,00");
            }
            else
            {
                toolTip1.SetToolTip(cbQuarto, "Suite Simples. RS: 100,00");
            }
        }


    }
}
