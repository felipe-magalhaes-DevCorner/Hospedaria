using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
            //using System.IO;  
            string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string myFile = Path.Combine(applicationDirectory, "Ajuda.html");
            webBrowser1.Url = new Uri("file:///" + myFile);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
