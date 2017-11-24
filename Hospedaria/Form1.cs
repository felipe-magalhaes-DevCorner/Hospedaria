using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace Hospedaria
{
    public partial class Form1 : Form
    {
        private ConnectionClass db = new ConnectionClass();
        //private bool RunOnce = true;
        static bool RunOnce = true;
        
        public static string LoggedName;

        public static int powerLvl;
        public Form1(bool checkStatus = false,string nomeUser = "",int _powerlevel = 6, bool control = false)
        {


            if (RunOnce == true)
            {
                Thread t = new Thread(new ThreadStart(splash));
                t.Start();
                Thread.Sleep(1000);
                t.Abort();

                this.Hide();
                RunOnce = false;
                fdrLogin.frmLogin objLogin = new fdrLogin.frmLogin();
                objLogin.getform = this;

                objLogin.ShowDialog();
                this.Hide();
                objLogin.Focus();

            }
            if (control)
            {

                LoggedName = nomeUser;
                powerLvl = _powerlevel;
            }

            InitializeComponent();
            TimerUpdated();
            //if (checkStatus)
            //{
            //    CheckStatus();
                
            //}
            //var startTimeSpan = TimeSpan.Zero;
            //var periodTimeSpan = TimeSpan.FromMinutes(5);

            //var timer = new System.Threading.Timer((e) =>
            //{
            //    TimerUpdated();
            //}, null, startTimeSpan, periodTimeSpan);

            //LoggedName = nomeUser;
            PowerLevel(powerLvl);
            lbLogged.Text = "Bem Vindo " + LoggedName + "";




            this.BringToFront();

        }
        private void PowerLevel(int _powerLvl)
        {
            switch (_powerLvl)
            {
                case 0:
                    {
                        financeiroToolStripMenuItem1.Visible = false;
                        cadastrarUsuarioToolStripMenuItem.Visible = false;
                        alterarUsuarioToolStripMenuItem.Visible = false;
                        manutençãoToolStripMenuItem.Visible = false;

                    }
                    break;


                case 1:
                    {
                        financeiroToolStripMenuItem1.Visible = false;
                        cadastrarUsuarioToolStripMenuItem.Visible = false;
                        alterarUsuarioToolStripMenuItem.Visible = false;
                        manutençãoToolStripMenuItem.Visible = false;

                    }
                    break;
                case 2:
                    {
                        usuariosToolStripMenuItem.Visible = false;
                        financeiroToolStripMenuItem1.Visible = false;
                        estoqueToolStripMenuItem.Visible = false;


                    }
                    break;
                case 3:
                    {
                        


                    }
                    break;
                case 4:
                    {

                        


                    }
                    break;
                default:
                    break;
            }
        }
        public void splash()
        {
            Application.Run(new frmSplash());
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            //cria um objeto contendo o form
            Clientes.frmmainClientes objCadastroc = new Clientes.frmmainClientes();
            //variavel no formulario frmmainClientes, referencio o form principal para ser chamado mais tarde no form frmmainClientes
            objCadastroc.RefToMenu = this;
            //esconde esse form
            this.Hide();
            //abre form cadastro de clientes
            objCadastroc.ShowDialog();


        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            fdrQuartos.frmReservasMain frmReservasmain = new fdrQuartos.frmReservasMain();
            frmReservasmain.getform = this;
            this.Hide();
            frmReservasmain.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckStatus();
        }
        


        private void CheckStatus()
        {

            string query = "select * from hospedagem"; //<<<<<<<<QUERY
            db.SqlConnection();
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                int idHOSPEDAGM = Convert.ToInt32(_dr["idHOSPEDAGEM"]);
                int idCONDICAO = Convert.ToInt32(_dr["idCONDICAO"]);
                if (idCONDICAO == 1)
                {
                    switch (idHOSPEDAGM)
                    {
                        case 1:
                            {
                                suitePresidenciaslToolStripMenuItem.Checked = false;
                                pbFloyd.Image = Hospedaria.Properties.Resources.green_circle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Livre";

                            }
                            break;
                        case 2:
                            {
                                suiteMasterToolStripMenuItem.Checked = false;
                                pbStones.Image = Hospedaria.Properties.Resources.green_circle;
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Livre";

                            }
                            break;
                        case 3:
                            {
                                suiteJaguaçãoToolStripMenuItem.Checked = false;
                                pbDave.Image = Hospedaria.Properties.Resources.green_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Livre";

                            }
                            break;
                        case 4:
                            {
                                quartoBobDylanToolStripMenuItem.Checked = false;
                                pbDylan.Image = Hospedaria.Properties.Resources.green_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Livre";

                            }
                            break;
                        case 5:
                            {
                                quartoJanesToolStripMenuItem.Checked = false;
                                pbJanes.Image = Hospedaria.Properties.Resources.green_circle;
                                pbJanes.SizeMode = PictureBoxSizeMode.StretchImage;
                                label6.Text = "Livre";
                                //db.SqlQuery("update hospedagem set idcondicao = '"+ idCONDICAO + "' where idhospedagem = '"+idHOSPEDAGM+"'");
                                //db.QueryRun();
                            }
                            break;
                    }

                }
                else if (idCONDICAO == 2)
                {
                    switch (idHOSPEDAGM)
                    {
                        case 1:
                            {
                                suitePresidenciaslToolStripMenuItem.Checked = false;
                                pbFloyd.Image = Hospedaria.Properties.Resources.red_circle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Ocupado";
                                //db.SqlQuery("update hospedagem set idcondicao = '"+ idCONDICAO + "' where idhospedagem = '"+idHOSPEDAGM+"'");
                                //db.QueryRun();

                            }
                            break;
                        case 2:
                            {
                                suiteMasterToolStripMenuItem.Checked = false;
                                pbStones.Image = Hospedaria.Properties.Resources.red_circle;
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Ocupado";
                            }
                            break;
                        case 3:
                            {
                                suiteJaguaçãoToolStripMenuItem.Checked = false;
                                pbDave.Image = Hospedaria.Properties.Resources.red_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Ocupado";
                            }
                            break;
                        case 4:
                            {
                                quartoBobDylanToolStripMenuItem.Checked = false;
                                pbDylan.Image = Hospedaria.Properties.Resources.red_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Ocupado";
                            }
                            break;
                        case 5:
                            {
                                quartoJanesToolStripMenuItem.Checked = false;
                                pbJanes.Image = Hospedaria.Properties.Resources.red_circle;
                                pbJanes.SizeMode = PictureBoxSizeMode.StretchImage;
                                label6.Text = "Ocupado";
                            }
                            break;
                    }

                }
                else if(idCONDICAO == 3)
                {
                    switch (idHOSPEDAGM)
                    {
                        case 1:
                            {
                                suitePresidenciaslToolStripMenuItem.Checked = true;
                                pbFloyd.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Manutenção";

                            }
                            break;
                        case 2:
                            {
                                suiteMasterToolStripMenuItem.Checked = true;
                                pbStones.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Manutenção";
                            }
                            break;
                        case 3:
                            {
                                suiteJaguaçãoToolStripMenuItem.Checked = true;
                                pbDave.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Manutenção";
                            }
                            break;
                        case 4:
                            {
                                quartoBobDylanToolStripMenuItem.Checked = true;
                                pbDylan.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Manutenção";
                            }
                            break;
                        case 5:
                            {
                                quartoJanesToolStripMenuItem.Checked = true;
                                pbJanes.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbJanes.SizeMode = PictureBoxSizeMode.StretchImage;
                                label6.Text = "Manutenção";
                            }
                            break;
                    }

                }
                else
                {//reservado
                    switch (idHOSPEDAGM)
                    {
                        case 1:
                            {
                                
                                pbFloyd.Image = Hospedaria.Properties.Resources.bluecircle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Reservado";
                                suitePresidenciaslToolStripMenuItem.Checked = false;

                            }
                            break;
                        case 2:
                            {
                                
                                pbStones.Image = Hospedaria.Properties.Resources.bluecircle; 
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Reservado";
                                suiteMasterToolStripMenuItem.Checked = false;
                            }
                            break;
                        case 3:
                            {
                                
                                pbDave.Image = Hospedaria.Properties.Resources.bluecircle; 
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Reservado";
                                suiteJaguaçãoToolStripMenuItem.Checked = false;
                            }
                            break;
                        case 4:
                            {
                                
                                pbDylan.Image = Hospedaria.Properties.Resources.bluecircle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Reservado";
                                quartoBobDylanToolStripMenuItem.Checked = false;
                            }
                            break;
                        case 5:
                            {
                                
                                pbJanes.Image = Hospedaria.Properties.Resources.bluecircle;
                                pbJanes.SizeMode = PictureBoxSizeMode.StretchImage;
                                label6.Text = "Reservado";
                                quartoJanesToolStripMenuItem.Checked = false;
                            }
                            break;
                    }

                }



            }
            db.closeConnection();
        }
        int auxCount = 1;
        private void suitePresidenciaslToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
            if (label10.Text == "Ocupado")
            {
                auxCount++;
                if (auxCount < 3)
                {
                    MessageBox.Show("O quarto esta com hospedes agora.");
                    suitePresidenciaslToolStripMenuItem.Checked = false;
                    auxCount = 1;
                }

                

            }
            else if (label10.Text != "Reservado")
            {
                db.SqlConnection();
                if (suitePresidenciaslToolStripMenuItem.Checked)
                {
                    db.SqlQuery("update hospedagem set idcondicao = '3' where idhospedagem = '1'");
                }
                else
                {
                    db.SqlQuery("update hospedagem set idcondicao = '1' where idhospedagem = '1'");
                }
                db.QueryRun();
                db.closeConnection();
                CheckStatus();

            }





        }

        private void suiteMasterToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
            if (label9.Text != "Reservado")
            {
                db.SqlConnection();
                if (suiteMasterToolStripMenuItem.Checked)
                {
                    db.SqlQuery("update hospedagem set idcondicao = '3' where idhospedagem = '2'");
                }
                else
                {
                    db.SqlQuery("update hospedagem set idcondicao = '1' where idhospedagem = '2'");
                }
                db.QueryRun();
                db.closeConnection();
                CheckStatus();

            }





        }

        private void suiteJaguaçãoToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

            
            if (label8.Text != "Reservado")
            {
                db.SqlConnection();
                if (suiteJaguaçãoToolStripMenuItem.Checked)
                {
                    db.SqlQuery("update hospedagem set idcondicao = '3' where idhospedagem = '3'");
                }
                else
                {
                    db.SqlQuery("update hospedagem set idcondicao = '1' where idhospedagem = '3'");
                }
                db.QueryRun();
                db.closeConnection();
                CheckStatus();

            }



            
        }

        private void quartoBobDylanToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
            if (label7.Text != "Reservado")
            {
                db.SqlConnection();
                if (quartoBobDylanToolStripMenuItem.Checked)
                {
                    db.SqlQuery("update hospedagem set idcondicao = '3' where idhospedagem = '4'");
                }
                else
                {
                    db.SqlQuery("update hospedagem set idcondicao = '1' where idhospedagem = '4'");
                }
                db.QueryRun();
                db.closeConnection();
                CheckStatus();
            }





        }

        private void quartoJanesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
            if (label6.Text != "Reservado")
            {
                db.SqlConnection();
                if (quartoJanesToolStripMenuItem.Checked)
                {
                    db.SqlQuery("update hospedagem set idcondicao = '3' where idhospedagem = '5'");
                }
                else
                {
                    db.SqlQuery("update hospedagem set idcondicao = '1' where idhospedagem = '5'");
                }
                db.QueryRun();
                db.closeConnection();
                CheckStatus();

            }




        }

        private void btMove_Click(object sender, EventArgs e)
        {
            fdrQuartos.frmUnidadesmain frmUnidadesmain = new fdrQuartos.frmUnidadesmain();
            frmUnidadesmain.getform = this;
            this.Hide();
            frmUnidadesmain.ShowDialog();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdrLogin.frmUsuarios objUsu = new fdrLogin.frmUsuarios();
            objUsu.getform = this;
            this.Hide();
            objUsu.ShowDialog();
        }

        private void alterarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdrLogin.frmAlteraUsuario objUsu = new fdrLogin.frmAlteraUsuario();
            objUsu.getform = this;
            this.Hide();
            objUsu.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdrLogin.frmLogin objLogin = new fdrLogin.frmLogin(true);
            objLogin.getform = this;
            objLogin.ShowDialog();

        }
        private void TimerUpdated()
        {

            List<string> query = new List<string>();
            int aux = 0;
            query.Add("select * from reservas order by RESERVAS.idRESERVA");

            db.SqlConnection();
            db.SqlQuery(query[0]);
            query.Clear();
            SqlDataReader _dr =  db.QueryReader();
            if (_dr.HasRows)
            {
                while (_dr.Read())
                {
                    DateTime tDateEntrada = Convert.ToDateTime(_dr["datareserva"]);
                    DateTime tDateSaida = Convert.ToDateTime(_dr["datasaida"]);
                    if (tDateEntrada <= DateTime.Now && DateTime.Now <= tDateSaida)
                    {

                        query.Add("update hospedagem set idcondicao = 4 where idhospedagem = '" + Convert.ToInt32(_dr["idhospedagem"]) + "'");

                    }
                }
                db.closeConnection();
                db.SqlConnection();
                foreach (string item in query)
                {

                    db.SqlQuery(query[aux]);
                    db.QueryRun();
                    aux++;


                }
                db.closeConnection();

            }
            
            CheckStatus();
            

        }


    }
}

