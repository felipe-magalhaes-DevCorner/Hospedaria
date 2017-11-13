using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrLogin
{
    public partial class frmUsuarios : Form
    {
        private ConnectionClass db = new ConnectionClass();
        public Form getform { get; set; }
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            db.SqlConnection();
            string query = "select categoriausu.descricao from categoriausu where categoriausu.idcategoriausu <> 1";
            db.SqlQuery(query);
            SqlDataReader _dr =  db.QueryReader();
            while (_dr.Read())
            {
                comboBox1.Items.Add(_dr["descricao"]);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            getform.Show();
        }
    }
}
