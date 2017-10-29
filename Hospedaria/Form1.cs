using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            Clientes.frmmainClientes objCadastroc = new Clientes.frmmainClientes();
            objCadastroc.RefToMenu = this;
            this.Hide();
            objCadastroc.ShowDialog();


        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            fdrVendas.frmVendas objVenda = new fdrVendas.frmVendas();            
            objVenda.ShowDialog();
            
        }
    }
}
