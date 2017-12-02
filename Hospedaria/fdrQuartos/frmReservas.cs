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
        
        List<string> listNames = new List<string>();// LISTAS COM OS NOMES
        List<int> idNames = new List<int>();// LISTAS COM OS NOMES
        List<string> listHospedagem = new List<string>();// LISTAS COM OS NOMES
        List<int> idHospedagem = new List<int>();// LISTAS COM OS NOMES
        public static Form getform { get; set; }

        public frmReservas()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            cbNomeRes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbNomeRes.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }
        



        private void frmReservas_Load(object sender, EventArgs e)
        {
            //EXECUTA AO ABRIR O FORMULARIO
            popComboBoxes();//CHAMA METODO PARA POPULAR COMBOBOX NO LOAD
            
            
            datepicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            datepicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            datepicker1.Value = Convert.ToDateTime(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy 14:00:00"));
            datepicker2.Value = Convert.ToDateTime(DateTime.Now.AddDays(2).ToString("dd/MM/yyyy 11:59:00"));


        }


        private void popComboBoxes()
        {
            
            //---------------------- POPULA COMBOBOX NOME----------------------
            string query = "select clientes.nome, clientes.idclientes from clientes order by clientes.nome";
            db.SqlConnection();
            db.SqlQuery(query);  Clipboard.SetText(query);


            //POPULA LEITOR DADOS (VARIOS DADOS)DE SQL, LEITOR DE TABELA DIGAMOS ASSIM
            SqlDataReader _dr = db.QueryReader();
            

            while (_dr.Read())
            {

                idNames.Add(Convert.ToInt32(_dr["idCLIENTES"]));
                listNames.Add(_dr["NOME"].ToString().Trim());//ADICIONA O QUE FOI LIDO NO SQL A LISTA NOME
                cbNomeRes.Items.Add(_dr["NOME"].ToString().Trim());//ADICIONA O QUE FOI LIDO NO SQL Á COMBOBOX NOME



            }
            //FECHA CONEXCAO
            db.SqlConnection();

            //POPULA COMBOBOX HOSPEDAGEM
            query = "select hospedagem.idHOSPEDAGEM , hospedagem.NOME  from HOSPEDAGEM order by hospedagem.idhospedagem";
            db.SqlQuery(query);  Clipboard.SetText(query);
            SqlDataReader _dr2 = db.QueryReader();
            while (_dr2.Read())
            {

                idHospedagem.Add(Convert.ToInt32(_dr2["idhospedagem"]));
                listHospedagem.Add(_dr2["NOME"].ToString().Trim());
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
            string query = query = "select reservas.idhospedagem, reservas.datareserva, reservas.datasaida from reservas where reservas.idhospedagem = '"+idHospedagem[listHospedagem.IndexOf(cbQuarto.Text.Trim())]+"'";
            db.SqlQuery(query);  Clipboard.SetText(query);

            
            DateTime date = DateTime.Now;
            //ABRASILEIRO O PROGRAMA
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            DateTime datePrevistaSaida;
            DateTime dateReserva;
            bool termina = true;
            SqlDataReader _dr = db.QueryReader();
            if (_dr.HasRows)
            {
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
            if (datepicker1.Value > DateTime.Now && datepicker2.Value > DateTime.Now)
            {

                //---------------------------------BOTAO GRAVAR//---------------------------------

                if (cbNomeRes.Text != "")//CHEGA SE NOME ESTA EM BRANCO
                {
                    if (listNames.Contains(cbNomeRes.Text.Trim()))//CHEGA SE É UM CLIENTE CADASTRADO
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
            else
            {
                MessageBox.Show("Essa data ja passou.");
            }


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
                    string query = "INSERT INTO RESERVAS values ('" + (cbQuarto.SelectedIndex + 1) + "','" +idNames[listNames.IndexOf(cbNomeRes.Text.Trim())]  + "','"+datepicker1.Value.ToString("dd/MM/yyyy 14:00") + "','"+datepicker2.Value.ToString("dd/MM/yyyy 11:59") +"')";
                    db.SqlQuery(query);  Clipboard.SetText(query);//COLA A QUERY
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

        }

        private void cbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void frmReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
