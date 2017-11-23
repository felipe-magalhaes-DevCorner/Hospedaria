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
        private static bool exitControl;
        public frmUnidadesmain(bool exit = true)
        {
            InitializeComponent();
            
        }



        private void btVenda_Click(object sender, EventArgs e)
        {
            fdrQuartos.CheckIn objCheckIn = new CheckIn();
            objCheckIn.getform = getform;
            this.Hide();
            objCheckIn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fdrQuartos.CheckOut objCheckOut = new CheckOut();
           // objCheckOut.getform = getform;
            this.Hide();
            objCheckOut.Show();


        }

        private void frmUnidadesmain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
