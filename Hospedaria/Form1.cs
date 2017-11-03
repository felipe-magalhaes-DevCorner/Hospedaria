using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospedaria
{

    public partial class Form1 : Form
    {
        private ConnectionClass db = new ConnectionClass();

        public Form1()
        {
            InitializeComponent();
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
            //cria um objeto contendo o form
            fdrVendas.frmVendas objVenda = new fdrVendas.frmVendas();
            //variavel no formulario frmmainClientes, referencio o form principal para ser chamado mais tarde no form frmmainClientes
            objVenda.RefToMenu = this;
            //esconde esse form
            this.Hide();
            //abre form venda de clientes
            objVenda.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckStatus();
        }
        private void UpdateCheckStatus()
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
                                db.SqlQuery("update hospedagem set idcondicao = '" + idCONDICAO + "' where idhospedagem = '" + idHOSPEDAGM + "'");
                                db.QueryRun();
                            }
                            break;
                        case 3:
                            {
                                suiteJaguaçãoToolStripMenuItem.Checked = false;
                                pbDave.Image = Hospedaria.Properties.Resources.green_circle;
                                pbDave.SizeMode = PictureBoxSizeMode.StretchImage;
                                label8.Text = "Livre";
                                db.SqlQuery("update hospedagem set idcondicao = '" + idCONDICAO + "' where idhospedagem = '" + idHOSPEDAGM + "'");
                                db.QueryRun();
                            }
                            break;
                        case 4:
                            {
                                quartoBobDylanToolStripMenuItem.Checked = false;
                                pbDylan.Image = Hospedaria.Properties.Resources.green_circle;
                                pbDylan.SizeMode = PictureBoxSizeMode.StretchImage;
                                label7.Text = "Livre";
                                db.SqlQuery("update hospedagem set idcondicao = '" + idCONDICAO + "' where idhospedagem = '" + idHOSPEDAGM + "'");
                                db.QueryRun();
                            }
                            break;
                        case 5:
                            {
                                quartoJanesToolStripMenuItem.Checked = false;
                                pbJanes.Image = Hospedaria.Properties.Resources.green_circle;
                                pbJanes.SizeMode = PictureBoxSizeMode.StretchImage;
                                label6.Text = "Livre";
                                db.SqlQuery("update hospedagem set idcondicao = '" + idCONDICAO + "' where idhospedagem = '" + idHOSPEDAGM + "'");
                                db.QueryRun();
                            }
                            break;



                        default:
                            break;
                    }


                }


            }

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
                else if (Convert.ToInt32(_dr["idCONDICAO"]) == 2)
                {
                    switch (Convert.ToInt32(_dr["idHOSPEDAGEM"]))
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
                else
                {
                    switch (Convert.ToInt32(_dr["idHOSPEDAGEM"]))
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



            }
            db.closeConnection();
        }

        private void suitePresidenciaslToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
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

        private void suiteMasterToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
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

        private void suiteJaguaçãoToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
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

        private void quartoBobDylanToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
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

        private void quartoJanesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
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

        private void btMove_Click(object sender, EventArgs e)
        {
            fdrQuartos.frmUnidadesmain frmUnidadesmain = new fdrQuartos.frmUnidadesmain();
            frmUnidadesmain.ShowDialog();
        }











        //private void quartoJanesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (quartoJanesToolStripMenuItem.Checked == true)
        //    {
        //        string query = "update hospedagem set idcondicao = '3' where idhospedagem = 5 "; //<<<<<<<<QUERY
        //        db.SqlConnection();
        //        db.SqlQuery(query);
        //        db.QueryRun();
        //        db.closeConnection();


        //    }
        //    else
        //    {
        //        string query = "update hospedagem set idcondicao = '1' where idhospedagem = 5"; //<<<<<<<<QUERY
        //        db.SqlConnection();
        //        db.SqlQuery(query);
        //        db.QueryRun();
        //        db.closeConnection();


        //    }
        //    CheckStatus();
        //}
    }
}
