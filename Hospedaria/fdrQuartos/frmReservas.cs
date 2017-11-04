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
        List<string> listNames = new List<string>();
        DateTime someDate = new DateTime(); //or an array of dates, then run a loop
        public frmReservas()
        {
            InitializeComponent();





        }
        



        private void frmReservas_Load(object sender, EventArgs e)
        {
            popComboBoxes();
            datepicker1.Format = DateTimePickerFormat.Custom;
            datepicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            datepicker1.Value = Convert.ToDateTime(DateTime.Now.AddDays(1).ToLocalTime().ToString("MM/dd/yyyy 14:00:00"));
            datepicker2.Value = Convert.ToDateTime(DateTime.Now.AddDays(2).ToLocalTime().ToString("MM/dd/yyyy 11:59:00"));
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
                


            }
            db.closeConnection();
            db.SqlConnection();

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
            cbNomeRes.SelectedIndex = 0;
        }
        private bool checkIfAlreadyReserved()
        {
            db.SqlConnection();
            string query = query = "select reservas.idhospedagem, reservas.datareserva, reservas.datasaida from reservas where reservas.idhospedagem = '"+selectedrowhospedagem+"'";
            db.SqlQuery(query);
            DateTime date = DateTime.Now.ToLocalTime();
            DateTime datePrevistaSaida;
            DateTime dateReserva;
            bool termina = true;
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
     
                    if (datepicker1.Value.ToLocalTime() >= DateTime.Now.ToLocalTime())
                    {
                        dateReserva = Convert.ToDateTime(_dr["datareserva"].ToString()).ToLocalTime();
                        datePrevistaSaida = Convert.ToDateTime(_dr["datasaida"].ToString()).ToLocalTime();
                        if (datepicker1.Value.ToLocalTime() > dateReserva && datepicker1.Value.ToLocalTime() > datePrevistaSaida)
                        {

                            termina = true;                           

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
                        
                        return false;
                        
                    }
            }
            db.closeConnection();
            if (termina)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> _listaClientes = new List<string>();
            db.SqlConnection();
            string query = "SELECT CLIENTES.NOME FROM CLIENTES";
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                _listaClientes.Add(_dr["NOME"].ToString().Trim());
            }
            if (cbNomeRes.Text != "")
            {
                if (_listaClientes.Contains(cbNomeRes.Text.Trim()))
                {
                    if (cbQuarto.Text.Trim() != "")
                    {
                        Inserecadastro();
                    }
                    else
                    {
                        MessageBox.Show("Escolha um quarto!");
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Cliente nao cadastrado, gostaria de cadastrar agora?", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        fdrClientes.frmCadastroClientes frmCadastroClientes = new fdrClientes.frmCadastroClientes();
                        frmCadastroClientes.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                }

            }
            else
            {
                MessageBox.Show("Insira o nome do cliente!");
            }
            
            


            
            

            

        }

        private void Inserecadastro()
        {

            if (checkIfAlreadyReserved())
            {
                if (listNames.Contains(cbNomeRes.Text))
                {
                    db.SqlConnection();
                    string query = "INSERT INTO RESERVAS values ('" + selectedrowhospedagem + "','" + selectedrow + "','" + datepicker1.Value.ToLocalTime() + "','" + datepicker2.Value.ToLocalTime() + "')";
                    db.SqlQuery(query);
                    db.QueryRun();
                    db.closeConnection();
                    MessageBox.Show("Reserva Efetuada!");

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
            else
            {
                MessageBox.Show("Nao cadastrou!");
            }
            
        }

        private void cbNomeRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.closeConnection();
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
            //someDate = Convert.ToDateTime(DateTime.Now.AddDays(5).ToShortDateString());
            //if (monthCalendar1.SelectionStart.ToString("MM-dd-yyyy") == someDate.ToString("MM-dd-yyyy"))
            //{
            //    monthCalendar1.BackColor = Color.Purple;
            //}
            //else
            //{
            //    monthCalendar1.BackColor = SystemColors.Control;
            //}


        }

    }
}
