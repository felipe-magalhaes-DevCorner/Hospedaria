using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrQuartos
{
    public partial class frmReservasMain : Form
    {
        public Form getform { get; set; }
        public frmReservasMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fdrQuartos.frmReservas frmReservas = new frmReservas();
            frmReservas.getform = getform;
            this.Hide();
            frmReservas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fdrQuartos.frmAlteraReserva frmAlteraReservas = new frmAlteraReserva();
            frmAlteraReservas.getform = getform;
            this.Hide();
            frmAlteraReservas.ShowDialog();
        }

        private void frmReservasMain_Load(object sender, EventArgs e)
        {

        }
    }
}
