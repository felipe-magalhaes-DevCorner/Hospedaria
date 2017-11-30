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




            InitializeComponent();
            //this.Hide();
            //if (RunOnce == true)
            //{
            //    Thread t = new Thread(new ThreadStart(splash));
            //    t.Start();
            //    Thread.Sleep(1000);
            //    t.Abort();

            //    this.Hide();
            //    RunOnce = false;
            //    fdrLogin.frmLogin objlogin = new fdrLogin.frmLogin();
            //    objlogin.getform = this;

            //    objlogin.ShowDialog();


            //    //this.hide();
            //    //objlogin.focus();

            //}
            if (control)
            {

                LoggedName = nomeUser;
                powerLvl = _powerlevel;
            }
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

            LoggedName = nomeUser;
            PowerLevel(powerLvl);
            lbLogged.Text = "Bem Vindo " + LoggedName + "";



            CheckStatus();
            

        }
        private void PowerLevel(int _powerLvl)
        {
            switch (_powerLvl)
            {
                case 0:
                    {
                        financeiroToolStripMenuItem1.Visible = false;
                        cadastrarUsuarioToolStripMenuItem.Visible = false;
                        alterarUsuarioToolStripMenuItem.Visible = true;
                        manutençãoToolStripMenuItem.Visible = false;

                    }
                    break;


                case 1:
                    {
                        financeiroToolStripMenuItem1.Visible = false;
                        cadastrarUsuarioToolStripMenuItem.Visible = false;
                        alterarUsuarioToolStripMenuItem.Visible = true;
                        manutençãoToolStripMenuItem.Visible = false;

                    }
                    break;
                case 2:
                    {

                        cadastrarUsuarioToolStripMenuItem.Visible = false;
                        alterarUsuarioToolStripMenuItem.Visible = true;
                        financeiroToolStripMenuItem1.Visible = false;
                        


                    }
                    break;
                case 3:
                    {

                        financeiroToolStripMenuItem1.Visible = true;
                        cadastrarUsuarioToolStripMenuItem.Visible = true;
                        alterarUsuarioToolStripMenuItem.Visible = true;
                        manutençãoToolStripMenuItem.Visible = true;

                    }
                    break;
                case 4:
                    {
                        financeiroToolStripMenuItem1.Visible = true;
                        cadastrarUsuarioToolStripMenuItem.Visible = true;
                        alterarUsuarioToolStripMenuItem.Visible = true;
                        manutençãoToolStripMenuItem.Visible = true;




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
                                livreToolStripMenuItem.Checked = true;
                                ocupadoToolStripMenuItem.Checked = false;
                                manutençãoToolStripMenuItem1.Checked = false;
                                reservadoToolStripMenuItem.Checked = false;
                                pbFloyd.Image = Hospedaria.Properties.Resources.green_circle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Livre";

                            }
                            break;
                        case 2:
                            {
                                toolStripMenuItem1.Checked = true;
                                toolStripMenuItem2.Checked = false;
                                toolStripMenuItem3.Checked = false;
                                toolStripMenuItem4.Checked = false;
                                pbStones.Image = Hospedaria.Properties.Resources.green_circle;
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Livre";

                            }
                            break;
                        case 3:
                            {
                                toolStripMenuItem5.Checked = true;
                                toolStripMenuItem6.Checked = false;
                                toolStripMenuItem7.Checked = false;
                                toolStripMenuItem8.Checked = false;
                                
                                pbDave.Image = Hospedaria.Properties.Resources.green_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Livre";

                            }
                            break;
                        case 4:
                            {
                                toolStripMenuItem9.Checked = true;
                                toolStripMenuItem10.Checked = false;
                                toolStripMenuItem11.Checked = false;
                                toolStripMenuItem12.Checked = false;
                                
                                pbDylan.Image = Hospedaria.Properties.Resources.green_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Livre";

                            }
                            break;
                        case 5:
                            {
                                toolStripMenuItem13.Checked = true;
                                toolStripMenuItem14.Checked = false;
                                toolStripMenuItem15.Checked = false;
                                toolStripMenuItem16.Checked = false;

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
                                livreToolStripMenuItem.Checked = false;
                                ocupadoToolStripMenuItem.Checked = true;
                                manutençãoToolStripMenuItem1.Checked = false;
                                reservadoToolStripMenuItem.Checked = false;
                                pbFloyd.Image = Hospedaria.Properties.Resources.red_circle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Ocupado";
                                
                                //db.SqlQuery("update hospedagem set idcondicao = '"+ idCONDICAO + "' where idhospedagem = '"+idHOSPEDAGM+"'");
                                //db.QueryRun();

                            }
                            break;
                        case 2:
                            {
                                toolStripMenuItem1.Checked = false;
                                toolStripMenuItem2.Checked = true;
                                toolStripMenuItem3.Checked = false;
                                toolStripMenuItem4.Checked = false;
                                pbStones.Image = Hospedaria.Properties.Resources.red_circle;
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Ocupado";
                            }
                            break;
                        case 3:
                            {
                                toolStripMenuItem5.Checked = false;
                                toolStripMenuItem6.Checked = true;
                                toolStripMenuItem7.Checked = false;
                                toolStripMenuItem8.Checked = false;
                                pbDave.Image = Hospedaria.Properties.Resources.red_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Ocupado";
                            }
                            break;
                        case 4:
                            {
                                toolStripMenuItem9.Checked = false;
                                toolStripMenuItem10.Checked = true;
                                toolStripMenuItem11.Checked = false;
                                toolStripMenuItem12.Checked = false;
                                pbDylan.Image = Hospedaria.Properties.Resources.red_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Ocupado";
                            }
                            break;
                        case 5:
                            {
                                toolStripMenuItem13.Checked = false;
                                toolStripMenuItem14.Checked = true;
                                toolStripMenuItem15.Checked = false;
                                toolStripMenuItem16.Checked = false;
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

                                livreToolStripMenuItem.Checked = false;
                                ocupadoToolStripMenuItem.Checked = false;
                                manutençãoToolStripMenuItem1.Checked = true;
                                reservadoToolStripMenuItem.Checked = false;
                                pbFloyd.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Manutenção";

                            }
                            break;
                        case 2:
                            {
                                toolStripMenuItem1.Checked = false;
                                toolStripMenuItem2.Checked = false;
                                toolStripMenuItem3.Checked = true;
                                toolStripMenuItem4.Checked = false;
                                pbStones.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Manutenção";
                            }
                            break;
                        case 3:
                            {
                                toolStripMenuItem5.Checked = false;
                                toolStripMenuItem6.Checked = false;
                                toolStripMenuItem7.Checked = true;
                                toolStripMenuItem8.Checked = false;
                                pbDave.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Manutenção";
                            }
                            break;
                        case 4:
                            {
                                toolStripMenuItem9.Checked = false;
                                toolStripMenuItem10.Checked = false;
                                toolStripMenuItem11.Checked = true;
                                toolStripMenuItem12.Checked = false;
                                pbDylan.Image = Hospedaria.Properties.Resources.orange_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Manutenção";
                            }
                            break;
                        case 5:
                            {
                                toolStripMenuItem13.Checked = false;
                                toolStripMenuItem14.Checked = false;
                                toolStripMenuItem15.Checked = true;
                                toolStripMenuItem16.Checked = false;
                                
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
                                livreToolStripMenuItem.Checked = false;
                                ocupadoToolStripMenuItem.Checked = false;
                                manutençãoToolStripMenuItem1.Checked = false;
                                reservadoToolStripMenuItem.Checked = true;
                                pbFloyd.Image = Hospedaria.Properties.Resources.bluecircle;
                                pbFloyd.SizeMode = PictureBoxSizeMode.StretchImage;
                                label10.Text = "Reservado";
                                

                            }
                            break;
                        case 2:
                            {
                                toolStripMenuItem1.Checked = false;
                                toolStripMenuItem2.Checked = false;
                                toolStripMenuItem3.Checked = false;
                                toolStripMenuItem4.Checked = true;

                                pbStones.Image = Hospedaria.Properties.Resources.bluecircle; 
                                pbStones.SizeMode = PictureBoxSizeMode.StretchImage;
                                label9.Text = "Reservado";
                                
                            }
                            break;
                        case 3:
                            {
                                toolStripMenuItem5.Checked = false;
                                toolStripMenuItem6.Checked = false;
                                toolStripMenuItem7.Checked = false;
                                toolStripMenuItem8.Checked = true;

                                pbDave.Image = Hospedaria.Properties.Resources.bluecircle; 
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Reservado";
                                
                            }
                            break;
                        case 4:
                            {

                                toolStripMenuItem9.Checked = false;
                                toolStripMenuItem10.Checked = false;
                                toolStripMenuItem11.Checked = false;
                                toolStripMenuItem12.Checked = true;
                                pbDylan.Image = Hospedaria.Properties.Resources.bluecircle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Reservado";
                                
                            }
                            break;
                        case 5:
                            {
                                toolStripMenuItem13.Checked = false;
                                toolStripMenuItem14.Checked = false;
                                toolStripMenuItem15.Checked = false;
                                toolStripMenuItem16.Checked = true;
                                pbJanes.Image = Hospedaria.Properties.Resources.bluecircle;
                                pbJanes.SizeMode = PictureBoxSizeMode.StretchImage;
                                label6.Text = "Reservado";
                                
                            }
                            break;
                    }

                }



            }
            db.closeConnection();
        }
        private void updateCheckBoxes()
        {

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
                

            }
            CheckStatus();




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
            this.Hide();
            fdrLogin.frmAlteraUsuario objUsu = new fdrLogin.frmAlteraUsuario(powerLvl);
            objUsu.getform = this;
            
            objUsu.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fdrLogin.frmLogin objLogin = new fdrLogin.frmLogin(true);
            this.Hide();
            //objLogin.getform = this;
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

        private void relatorioDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financeiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fdrFinanceiro.frmFinanceiro objFin = new fdrFinanceiro.frmFinanceiro();
            objFin.getform = this;
            this.Hide();
            objFin.ShowDialog();
            
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.SqlConnection();
            if (livreToolStripMenuItem.Checked)
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



        private void CheckBoxUpdate(int Hospedagem, int condicao)
        {
            db.SqlConnection();

                db.SqlQuery("update hospedagem set idcondicao = '"+condicao+"' where idhospedagem = '"+ Hospedagem + "'");

                

            db.QueryRun();
            db.closeConnection();
            CheckStatus();
        }

        private void livreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (livreToolStripMenuItem.Checked)
            {
                CheckBoxUpdate(1, 1);

            }
            else
            {
                livreToolStripMenuItem.Checked = true;
            }

        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (manutençãoToolStripMenuItem1.Checked)
            {
                CheckBoxUpdate(1, 3);

            }
            else
            {
                manutençãoToolStripMenuItem1.Checked = true;
            }

        }

        private void reservadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reservadoToolStripMenuItem.Checked)
            {
                CheckBoxUpdate(1, 4);

            }
            else
            {
                reservadoToolStripMenuItem.Checked = true;
            }

        }

        private void ocupadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ocupadoToolStripMenuItem.Checked)
            {
                CheckBoxUpdate(1, 2);

            }
            else
            {
                ocupadoToolStripMenuItem.Checked = true;
            }


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem1.Checked)
            {
                CheckBoxUpdate(2, 1);

            }
            else
            {
                toolStripMenuItem1.Checked = true;
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem2.Checked)
            {
                CheckBoxUpdate(2, 2);

            }
            else
            {
                toolStripMenuItem2.Checked = true;
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem3.Checked)
            {
                CheckBoxUpdate(2, 3);

            }
            else
            {
                toolStripMenuItem3.Checked = true;
            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Checked)
            {
                CheckBoxUpdate(2, 4);

            }
            else
            {
                toolStripMenuItem4.Checked = true;
            }

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem5.Checked)
            {
                CheckBoxUpdate(3, 1);

            }
            else
            {
                toolStripMenuItem5.Checked = true;
            }


        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem6.Checked)
            {
                CheckBoxUpdate(3, 2);

            }
            else
            {
                toolStripMenuItem6.Checked = true;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem7.Checked)
            {
                CheckBoxUpdate(3, 3);

            }
            else
            {
                toolStripMenuItem7.Checked = true;
            }

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem8.Checked)
            {
                CheckBoxUpdate(3, 4);

            }
            else
            {
                toolStripMenuItem8.Checked = true;
            }

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem9.Checked)
            {
                CheckBoxUpdate(4, 1);

            }
            else
            {
                toolStripMenuItem9.Checked = true;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem10.Checked)
            {
                CheckBoxUpdate(4, 2);

            }
            else
            {
                toolStripMenuItem10.Checked = true;
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem11.Checked)
            {
                CheckBoxUpdate(4, 3);

            }
            else
            {
                toolStripMenuItem11.Checked = true;
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem12.Checked)
            {
                CheckBoxUpdate(4, 4);

            }
            else
            {
                toolStripMenuItem12.Checked = true;
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem13.Checked)
            {
                CheckBoxUpdate(5, 1);

            }
            else
            {
                toolStripMenuItem13.Checked = true;
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem14.Checked)
            {
                CheckBoxUpdate(5, 2);

            }
            else
            {
                toolStripMenuItem14.Checked = true;
            }
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem15.Checked)
            {
                CheckBoxUpdate(5, 3);

            }
            else
            {
                toolStripMenuItem15.Checked = true;
            }
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem16.Checked)
            {
                CheckBoxUpdate(5, 4);

            }
            else
            {
                toolStripMenuItem16.Checked = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("teste");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                CheckStatus();
            }


            
        }
    }
}

