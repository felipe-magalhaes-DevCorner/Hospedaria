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
    public partial class frmUnidadesmain : Form
    {
        public Form getform { get; set; }
        public frmUnidadesmain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fdrQuartos.frmReservas frmReservas = new frmReservas();
            frmReservas.getform = getform;
            frmReservas.ShowDialog();
        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            fdrQuartos.CheckIn objCheckIn = new CheckIn();
            objCheckIn.getform = getform;
            this.Hide();
            objCheckIn.Show();
        }
    }
}
