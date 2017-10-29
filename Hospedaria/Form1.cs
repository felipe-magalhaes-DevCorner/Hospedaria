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

        private void CheckStatus()
        {
            string query = "select * from hospedagem"; //<<<<<<<<QUERY
            db.SqlConnection();
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {

                switch (Convert.ToInt32(_dr["idCONDICAO"]))
                {
                    case 1:
                        {

                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        {
                            switch (Convert.ToInt32(_dr["idHOSPEDAGEM"]))
                            {
                                case 1:
                                    {
                                        suitePresidenciaslToolStripMenuItem.Checked = true;
                                    }
                                    break;
                                case 2:
                                    {
                                        suiteMasterToolStripMenuItem.Checked = true;
                                    }
                                    break;
                                case 3:
                                    {
                                        suiteJaguaçãoToolStripMenuItem.Checked = true;
                                    }
                                    break;
                                case 4:
                                    {
                                        quartoBobDylanToolStripMenuItem.Checked = true;
                                    }
                                    break;
                                case 5:
                                    {
                                        quartoJanesToolStripMenuItem.Checked = true;
                                    }
                                    break;
                            }

                        }
                        break;


                }





            }
        }
    }
}
