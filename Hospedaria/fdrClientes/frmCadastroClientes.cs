using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrClientes
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionClass db = new ConnectionClass();
            db.SQLiteConnection();
            db.sqliteQuery();
            db.NonQueryEx();
        }
        void CheckifNull(string pifNull)
        {

        }
    }
}
