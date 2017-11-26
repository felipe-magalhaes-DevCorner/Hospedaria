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
        public frmRecuperaSenha()
        {
            InitializeComponent();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                db.SqlConnection();
                string query = "UPDATE usuarios SET PASSWORD = '" + txtPass.Text.Trim() + "' WHERE USERNAME = '" + txtUser.Text.Trim() + "' AND RECUPERACAO = '" + txtRecu.Text.Trim() + "'";
                db.SqlQuery(query);
                db.QueryRun();
                db.closeConnection();
                MessageBox.Show("Senha Alterada");
                this.Hide();
                fdrLogin.frmLogin objLogin = new fdrLogin.frmLogin();
                objLogin.ShowDialog();


            }
            catch (Exception)
            {
                MessageBox.Show("Username ou ID errados");
                throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
