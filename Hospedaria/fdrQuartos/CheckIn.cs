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
        private static bool exit = false;
        DateTime dataProximaReserva;
        DateTime dataprosimaSaida;
        private static int idreserva;
        private static int indexReserva;


        public Form getform { get; set; }
        public CheckIn(string _pNomeSuite = "", string _pNomeCliente = "" , string _pDatareserva = "", string _pDataSaida = "",char reserva = 'c', bool exit = false)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            InitializeComponent();
            cbNomeCheckIn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbNomeCheckIn.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (reserva == 'd')
            {
                if (_pNomeCliente != "" && _pDataSaida != "" && _pDatareserva != "")
                {   
                    //pegar nome da suite, procurar qual index ele esta em nomes quartos. 
                    cbQuarto.SelectedIndex = nomeQuarto.IndexOf(_pNomeSuite);
                    cbNomeCheckIn.SelectedIndex = nomeCliente.IndexOf(_pNomeCliente);
                    DateTime dataentrada = Convert.ToDateTime(_pDatareserva);
                    DateTime datasaida = Convert.ToDateTime(_pDataSaida);
                    datepicker1.Value = dataentrada;
                    datepicker2.Value = datasaida;
                    this.Visible = true;

                }

                //

            }
            
            if (checkBox1.Checked)
            {
                datepicker2.Enabled = true;
            }
            else
            {
                datepicker2.Enabled = false;
            }
        }
        private void popComboBoxes()
        {
            //bool RunOnce = true;
            //---------------------- POPULA COMBOBOX NOME----------------------
            string query = "select clientes.nome, clientes.idclientes from clientes order by clientes.nome";
            db.SqlConnection();
            db.SqlQuery(query);  Clipboard.SetText(query); 


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
            db.SqlQuery(query);  Clipboard.SetText(query); 
            SqlDataReader _dr2 = db.QueryReader();
            while (_dr2.Read())
            {


                nomeQuarto.Add(_dr2["NOME"].ToString().Trim());
                idQuarto.Add(Convert.ToInt32(_dr2["idHOSPEDAGEM"]));


            }
            db.closeConnection();
            db.SqlConnection();
            query = "select * from pensao order by pensao.descricao";
            db.SqlQuery(query);  Clipboard.SetText(query); 
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
            DateTime dateini = DateTime.Now.AddMinutes(5);
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
            string query = "select hospedagem.idcondicao from hospedagem where hospedagem.idhospedagem = '" + idQuarto[cbQuarto.SelectedIndex] + "' ";
            db.SqlQuery(query);  Clipboard.SetText(query);
            
            

            SqlDataReader _dr = db.QueryReader();
            int condicao = 0;
            while (_dr.Read())
            {
                condicao = Convert.ToInt32(_dr["idcondicao"]);
                //dataProximaReserva = Convert.ToDateTime(_dr["datareserva"]);

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
                        exit = true;
                        

                    }
                    break;
                case 3:
                    {
                        MessageBox.Show("O quarto esta em manutencao.");
                        exit = true;

                    }
                    break;
                case 4:
                    {

                        db.SqlConnection();
                         query = "select reservas.datareserva from reservas where reservas.idhospedagem = '" + idQuarto[cbQuarto.SelectedIndex] + "' order by reservas.idreserva";
                        db.SqlQuery(query);  Clipboard.SetText(query);
                        

                        SqlDataReader _dr2 = db.QueryReader();
                        
                        while (_dr2.Read())
                        {
                            
                            dataProximaReserva = Convert.ToDateTime(_dr2["datareserva"]);

                        }
                        db.closeConnection();

                        QuartoLivreContinuaCheckin();



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
            if (datepicker1.Value >= datepicker2.Value || datepicker1.Value.ToString() == "" || datepicker1.Value < DateTime.Now)
            {
                MessageBox.Show("A data de entrada e saida nao conferem.");
            }
            else
            //passou pelos filtros anteriores
            {
                string query;
                db.SqlConnection();
                bool validaHospedagem = false;
                bool ValidaReserva = false;

                //CHECA SE TEM ALGUMA RESERVA PARA AQUELE QUARTO
                int quarto = idQuarto[cbQuarto.SelectedIndex];
                //query = "select datareserva from reservas where idhospedagem = '" + idQuarto + "' order by datareserva limit 1";
                //query = "select idhospedagem, DATARESERVA from RESERVAS where idHOSPEDAGEM = '" + idQuarto[cbQuarto.SelectedIndex] + "' and ((DATARESERVA between '" + datepicker1.Value.ToString("dd/MM/yyyy") + "' and '" + datepicker2.Value.ToString("dd/MM/yyyy HH:mm") + "') or (DATASAIDA between '" + datepicker1.Value.ToString("dd/MM/yyyy HH:mm") + "' and '" + datepicker1.Value.ToString("dd/MM/yyyy HH:mm") + "' ))";
                //query = "select idhospedagem, DATARESERVA from RESERVAS where idHOSPEDAGEM = '" + idQuarto[cbQuarto.SelectedIndex] + "' and((DATARESERVA > '" + datepicker1.Value.ToString("dd/MM/yyyy") + "' AND DATARESERVA <= '" + datepicker2.Value.ToString("dd/MM/yyyy") + "' AND DATEPART(hh, datareserva) >= '" + datepicker1.Value.ToString("HH") + "' AND DATEPART(hh, datareserva) <= '" + datepicker2.Value.ToString("HH") + "') or ((DATASAIDA > '" + datepicker1.Value.ToString("dd/MM/yyyy") + "' AND DATASAIDA <= '" + datepicker2.Value.ToString("dd/MM/yyyy") + "' AND DATEPART(hh, DATASAIDA) >= '" + datepicker1.Value.ToString("HH") + "' AND DATEPART(hh, DATASAIDA) <= '" + datepicker2.Value.ToString("hh") + "')";
                if (checkBox1.Checked)
                {
                    query = "select idhospedagem, DATARESERVA, datasaida, idclientes, idreserva from RESERVAS where idHOSPEDAGEM = '" + idQuarto[cbQuarto.SelectedIndex] + "' and(DATARESERVA > '" + datepicker1.Value.ToString("dd/MM/yyyy") + "' AND DATARESERVA <= '" + datepicker2.Value.ToString("dd/MM/yyyy") + "'  AND DATEPART(hh, datareserva) >= '" + datepicker1.Value.ToString("12") + "')";
                }
                else
                {
                    query = "select idhospedagem , DATARESERVA, datasaida, idclientes, idreserva from RESERVAS where idHOSPEDAGEM = '" + idQuarto[cbQuarto.SelectedIndex] + "' and((DATARESERVA > '" + datepicker1.Value.ToString("dd/MM/yyyy") + "') AND DATEPART(hh, datareserva) >= '" + datepicker1.Value.ToString("12") + "' )   or((DATASAIDA > '" + datepicker1.Value.ToString("dd/MM/yyyy") + "'    AND DATASAIDA <= '" + datepicker2.Value.ToString("dd/MM/yyyy") + "'     AND DATEPART(hh, DATASAIDA) <= '" + datepicker2.Value.ToString("hh") + "'))";
                }
                
                
                db.SqlQuery(query);  Clipboard.SetText(query); 
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
                            
                            if (datepicker2.Enabled == true)
                            {
                                dataprosimaSaida = Convert.ToDateTime(_dr["datasaida"]);
                            }
                            else
                            {
                                
                            }
                            indexReserva = Convert.ToInt32(_dr["idclientes"]);
                            idreserva = Convert.ToInt32(_dr["idreserva"]);


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
                    if (checkBox1.Checked)//sem reserva porem data final sem saida
                    {
                        
                        //existe data de saida, e nao existe reserva naquelas datas
                        //insere perfeito o q ta escrito
                        query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value.ToString("dd/MM/yyyy 14:mm") + "','" + datepicker2.Value.ToString("dd/MM/yyyy HH:mm") + "', 'Ocupado' )";
                        db.SqlQuery(query);  Clipboard.SetText(query); 
                        db.QueryRun();

                    }
                    else
                    {
                        //CASO NAO HAJA DATA DE SAIDA, VAI PRO SQL DATASAIDA NULL
                        DateTime date1 = Convert.ToDateTime(datepicker1.Value);
                        query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value.ToString("dd/MM/yyyy 14:mm") + "',NULL, 'Ocupado' )";
                        db.SqlQuery(query);  Clipboard.SetText(query); 
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
                    if (datepicker1.Value.ToString("dd/MM/yyyy 14:00") == dataProximaReserva.ToString("dd/MM/yyyy HH:mm"))//caso a data saida esteja em branco
                    {

                        DialogResult dialogResult = MessageBox.Show(string.Format("Existe uma reserva para o dia {0} para o cliente {1}, Confirma ser essa reserva?", dataProximaReserva.ToString("dd/MM/yyyy HH:mm"), nomeCliente[idCliente.IndexOf(indexReserva)] ), "Cadastrado", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //INSERE COM DATA SAIDA IGUAL AS 11:59 DO DIA DO INICIO DA PROXIMA RESERVA PARA AQUELE QUARTO
                            query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value.ToString("dd/MM/yyyy HH:mm") + "', '" + datepicker2.Value.ToString("dd/MM/yyyy 11:59") + "', 'Ocupado' )";
                            db.SqlQuery(query);  Clipboard.SetText(query); 
                            db.QueryRun();
                            validaHospedagem = true;
                            ValidaReserva = true;

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            
                            DialogResult dialogResult2 = MessageBox.Show(string.Format("Não cadastrado. Ja existe uma reserva de outro cliente para esses dias. Gostaria de alterar a reserva?"),"ALERTA!", MessageBoxButtons.YesNo);
                            if (dialogResult2 == DialogResult.Yes)
                            {
                                db.closeConnection();
                                exit = false;
                                fdrQuartos.frmAlteraReserva objAlteraRes = new frmAlteraReserva();
                                objAlteraRes.Show();
                               


                            }
                            else if (dialogResult2 == DialogResult.No)
                            {
                                MessageBox.Show("Não cadastrado. Ja existe uma reserva de outro cliente para esses dias.");

                            }
                            

                        }

                    }
                    else if (datepicker2.Value >= dataProximaReserva)
                    {
                        
                        DialogResult dialogResult = MessageBox.Show(string.Format("Existe uma reserva para o dia {0}, CheckOut pode ser ate esta data?", dataProximaReserva.ToString("dd/MM/yyyy HH:mm")), "Cadastrado", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //INSERE COM DATA SAIDA IGUAL AS 11:59 DO DIA DO INICIO DA PROXIMA RESERVA PARA AQUELE QUARTO
                            query = "insert into situacao values ('" + idQuarto[cbQuarto.SelectedIndex] + "','" + idCliente[cbNomeCheckIn.SelectedIndex] + "','" + idpensao[cbPensao.SelectedIndex] + "','" + datepicker1.Value.ToString("dd/MM/yyyy HH:mm") + "', '" + dataProximaReserva.ToString("dd/MM/yyyy 11:59") + "', 'Ocupado' )";
                            db.SqlQuery(query);  Clipboard.SetText(query); 
                            db.QueryRun();
                            validaHospedagem = true;
                            

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Não cadastrado. Ja existe uma reserva de outro cliente para esses dias.");
                            
                        }

                    }
                    else
                    {
                        MessageBox.Show(string.Format("Ja existe uma reserva para o periodo de tempo. De {0} as {1}", dataProximaReserva.ToString(), dataprosimaSaida.ToString()) );
                       
                    }


                }
                if (ValidaReserva)
                {
                    query = "delete  from reservas where reservas.idreserva = '" + idreserva + "'";
                    db.SqlQuery(query);  Clipboard.SetText(query); 
                    db.QueryRun();
                    db.closeConnection();
                    


                }
                if (validaHospedagem)
                {


                    query = "update hospedagem set idcondicao = '2' where idhospedagem = '" + idQuarto[cbQuarto.SelectedIndex] + "'";
                    db.SqlQuery(query);  Clipboard.SetText(query); 
                    db.QueryRun();
                    MessageBox.Show("CheckIn Efetuado com sucesso!");
                    this.Hide();
                    exit = false;
                    Form1 form1 = new Form1(true);

                    form1.Show();
                    
                    
                    




                }

                db.closeConnection();
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

            
            

        }

        private void CheckIn_FormClosing(object sender, FormClosingEventArgs e)
        {

                


                this.Hide();
            //controllers objControl = new controllers();
            //objControl.CallMenu();
                getform.Visible = true;
                

            

        }

        private void cbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void cbPensao_MouseMove(object sender, MouseEventArgs e)
        {
            if (cbPensao.SelectedIndex == 3)
            {
                toolTip1.SetToolTip(cbPensao, "Sem alimentação. RS: 80,00");
            }
            else if (cbPensao.SelectedIndex == 0)
            {
                toolTip1.SetToolTip(cbPensao, "Inclui cafe da manha e jantar. RS: 120,00");
            }
            else
            {
                toolTip1.SetToolTip(cbPensao, "Inclui cafe da manha, almoco e jantar. RS: 180,00");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListReservas frmListReservas = new frmListReservas();
            frmListReservas.getform = this;
            frmListReservas.TelaAnterior = "CheckIn";
            this.Hide();
            frmListReservas.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked  )
            {
                datepicker2.Enabled = true;
            }
            else
            {
                datepicker2.Enabled = false;
            }
        }
    }
}
