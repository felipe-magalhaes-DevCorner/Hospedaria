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
    public partial class frmLogin : Form
    {
        private static int AuxCountLogin = 1;//mantem conta de numero de tentativas erradas
        private ConnectionClass db = new ConnectionClass();
        public static string loginName;
        public static string loggedName;
        public Form getform { get; set; }
        public int powerlevel { get; set; }
        
        public frmLogin()
        {
            
            InitializeComponent();
            this.Activate();
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           //garante q caso o nome do usuario mude uma nova quantidade de logins comeca
            loginName = txtUsername.Text;///continua linha de cima
            db.SqlConnection();
            string query = "select USUARIOS.NOME, USUARIOS.LOGIN, USUARIOS.SENHA,USUARIOS.BAN,USUARIOS.logged, CATEGORIAUSU.powerlevel from USUARIOS inner join CATEGORIAUSU on CATEGORIAUSU.idCATEGORIAUSU = USUARIOS.idCATEGORIAUSU where USUARIOS.login = '" + txtUsername.Text + "'";

            db.SqlQuery(query);             
            SqlDataReader _dr = db.QueryReader();
            if (_dr.HasRows)
            {

            }
            else
            {
                MessageBox.Show("Usuario Inesistente.");
            }
            while (_dr.Read())
            {
                if (AuxCountLogin<4)
                {

                    if (LoginSQl(_dr["LOGIN"].ToString(), _dr["SENHA"].ToString(), Convert.ToInt32(_dr["BAN"]), Convert.ToInt32(_dr["logged"]))) //testa
                    {
                        loginName = _dr["LOGIN"].ToString();
                        loggedName = _dr["NOME"].ToString();
                        powerlevel = (Convert.ToInt32(_dr["powerlevel"]));
                        Form1 objFrm1 = new Form1(false,loggedName, powerlevel, true);
                        //objFrm1.LoggedName = loggedName;

                        this.Close();
                        AuxCountLogin = 1;


                    }
                    else
                    {
                        AuxCountLogin++;
                    }

                }
                else
                {
                    ConnectionClass db2 = new ConnectionClass();
                    db2.SqlConnection();
                    query = "UPDATE USUARIOS SET BAN = 1 WHERE USUARIOS.LOGIN = '" + loginName.Trim() + "'";
                    db2.SqlQuery(query);
                    db2.QueryRun();
                    MessageBox.Show("Conta banida, o programa ira encessar agora. Contate o seu gerente para liberar seu usuario.");
                    db2.closeConnection();
                    Application.Exit();

                }


            }
            db.closeConnection();




        }
        private bool LoginSQl(string nome, string password, int ban, int LOG)
        {
            
            if (txtUsername.Text != "" )//check se esta vazio login
            {
                if (txtPassword.Text != "")//check se esta vazio password
                {
                    if (ban == 0)
                    {


                        if (LOG == 0)
                        {
                            if (nome == txtUsername.Text && password == txtPassword.Text)
                            {
                                return true;

                            }
                            else
	{
                                MessageBox.Show("Login Ou senha incorretors.");
                                return false;
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("Usuario ja em uso.");
                            return false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario banido.");
                        return false;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Favor preencher uma senha.");
                    return false;
                }                
                
            }
            MessageBox.Show("Favor preencher uma usuario.");

            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
