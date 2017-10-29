using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.Clientes
{
    public partial class frmmainClientes : Form
    {
        public Form RefToMenu { get; set; }
        public frmmainClientes()
        {
            InitializeComponent();
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            fdrClientes.frmCadastroClientes objCadastro = new fdrClientes.frmCadastroClientes();
            objCadastro.RefToMain = this;
            this.Hide();
            objCadastro.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fdrClientes.frmAlterarHospedes objAltera = new fdrClientes.frmAlterarHospedes();
            objAltera.RefToMain = this;
            this.Hide();
            objAltera.ShowDialog();

        }

        private void frmmainClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMenu.Show();
        }
    }
}
