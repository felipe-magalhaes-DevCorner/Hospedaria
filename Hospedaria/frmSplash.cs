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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if (progressBar1.Value == 100) timer1.Stop();
            if (progressBar1.Value > 90)
            {
                lbLoad.Text = "Quase la";
            }
            else if (progressBar1.Value > 85)
            {
                lbLoad.Text = "Abrindo as portas";
            }
            else if (progressBar1.Value > 70)
            {
                lbLoad.Text = "Perfumando os quartos";
            }
            else if (progressBar1.Value > 45)
            {
                lbLoad.Text = "Trocando os lençois";
            }
            else if (progressBar1.Value > 30)
            {
                lbLoad.Text = "Limpando quartos";
            }
            else if (progressBar1.Value > 15)
            {
                lbLoad.Text = "Conferindo frigobar";
            }
            else if (progressBar1.Value > 5)
            {
                lbLoad.Text = "Carregando database";
            }
            else
            {
                lbLoad.Text = "Iniciando livrarias";
            }

        }
    }
}
