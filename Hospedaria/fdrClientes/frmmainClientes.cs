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
            //RefToMenu.Hide();
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            fdrClientes.frmCadastroClientes objCadastro = new fdrClientes.frmCadastroClientes();            
            this.Hide();
            objCadastro.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fdrClientes.frmAlterarHospedes objAltera = new fdrClientes.frmAlterarHospedes();
            objAltera.RefToMenu = RefToMenu;
            this.Hide();
            objAltera.ShowDialog();
            

        }

        private void frmmainClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fdrClientes.frmAlterarHospedes objAlt = new fdrClientes.frmAlterarHospedes();
            //objAlt.RefToMenu = this.RefToMenu;
            //objAlt.RefToMenu.Visible = true;
            //Form1 objMain = new Form1();
            //objMain.ShowDialog();
            
        }
    }
}
