using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrLogin
{
    public partial class frmRecuperaSenha : Form
    {
        private ConnectionClass db = new ConnectionClass();
        public Form getform { get; set; }
        public frmRecuperaSenha()
        {
            InitializeComponent();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                db.SqlConnection();
                string query = "UPDATE usuarios SET senha = '" + txtPass.Text.Trim() + "' WHERE login = '" + txtUser.Text.Trim() + "' AND senha_mestre = '" + txtRecu.Text.Trim() + "'";
                db.SqlQuery(query);  Clipboard.SetText(query);
                db.QueryRun();
                db.closeConnection();
                MessageBox.Show("Senha Alterada");
                this.Hide();
                getform.Visible = true;


            }
            catch (Exception)
            {
                MessageBox.Show("Username ou ID errados");
                throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            getform.Visible = true;
        }
    }
}
