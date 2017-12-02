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
    public partial class splashEnceramento : Form
    {
        public splashEnceramento()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private void splashEnceramento_Load(object sender, EventArgs e)
        {
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();



        }
        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
