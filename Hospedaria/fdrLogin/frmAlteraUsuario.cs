using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrLogin
{
    public partial class frmAlteraUsuario : Form
    {
        private ConnectionClass db = new ConnectionClass();
        List<int> idUsuario = new List<int>();
        List<string> login = new List<string>();
        List<string> nomeUsu = new List<string>();
        List<int> idUsuarioCate = new List<int>();
        List<int> idCategoria = new List<int>();
        List<string> descricao = new List<string>();
        List<int> BanBool = new List<int>();
        private static int powerlevel;
        private static int logado;

        public Form getform { get; set; }



        public frmAlteraUsuario(int _powerlevel = 9, string nome = "")
        {
            InitializeComponent();
            powerlevel = _powerlevel;
            if (nome != "")
            {
                logado = nome;
            }
            
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlteraUsuario_Load(object sender, EventArgs e)
        {
            bool control;
            string query; //"select * from usuarios where usuarios.idcategoriausu >= '"+powerlevel+"' order  by usuarios.nome";
            db.SqlConnection();
            if (powerlevel <= 2)
            {
                query = "select * from categoriausu where categoriausu.powerlevel = '" + powerlevel + "' ";
                cbCargo.Visible = false;
                chekBan.Visible = false;
                label5.Visible = false;
                control = false;
            }
            else
            {
                query = "select * from categoriausu";
                cbCargo.Visible = true;
                chekBan.Visible = true;
                label5.Visible = true;
                control = true;
            }

            db.SqlQuery(query); Clipboard.SetText(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {
                idCategoria.Add(Convert.ToInt32(_dr["idcategoriausu"]));
                descricao.Add(_dr["descricao"].ToString());



            }
            db.closeConnection();


            if (control)
            {
                query = "select usuarios.idUSUARIOS, usuarios.nome, usuarios.login,usuarios.idcategoriausu, usuarios.ban,CATEGORIAUSU.powerlevel from usuarios inner join CATEGORIAUSU on CATEGORIAUSU.idCATEGORIAUSU = USUARIOS.idCATEGORIAUSU where CATEGORIAUSU.powerlevel < = '" + powerlevel + "' order by usuarios.nome";
            }
            else
            {
                query = "select usuarios.idUSUARIOS, usuarios.nome, usuarios.login,usuarios.idcategoriausu, usuarios.ban,CATEGORIAUSU.powerlevel from usuarios inner join CATEGORIAUSU on CATEGORIAUSU.idCATEGORIAUSU = USUARIOS.idCATEGORIAUSU where usuarios.nome = '" + logado + "' order by usuarios.nome";
            }
            
            db.SqlConnection();
            db.SqlQuery(query);  Clipboard.SetText(query);
            SqlDataReader _dt = db.QueryReader();
            while (_dt.Read())
            {
                idUsuario.Add(Convert.ToInt32(_dt["idUsuarios"]));
                nomeUsu.Add(_dt["nome"].ToString());
                login.Add(_dt["login"].ToString());
                idUsuarioCate.Add(Convert.ToInt32(_dt["idcategoriausu"]));
                BanBool.Add(Convert.ToInt32(_dt["ban"]));



            }
            for (int i = 0; i < nomeUsu.Count(); i++)
            {
                comboBox1.Items.Add(nomeUsu[i]);
            }

            
            /////--------------------------------------
            foreach (string item in descricao)
            {
                cbCargo.Items.Add(item);

            }

            txtlogin.Text = login[0];
            comboBox1.SelectedIndex = 0;
            cbCargo.SelectedIndex = 0;
            if (BanBool[0] == 1)
            {
                chekBan.Checked = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "delete from usuarios where usuarios.idusuarios = '"+idUsuario[login.IndexOf( txtlogin.Text) ]+"'";
            db.SqlConnection();
            db.SqlQuery(query);  Clipboard.SetText(query);  
            db.QueryRun();
            db.closeConnection();

            MessageBox.Show("Usuario deletado.");
            this.Close();

        }

        private void btGravar_Click(object sender, EventArgs e)
        {

            if (txtconfsenha.Text == txtnovasenha.Text)
            {
                string query;
                int Intban = chekBan.Checked ? 1 : 0;
                if (txtnovasenha.Text=="")
                {
                    if (powerlevel <=2)
                    {
                        query = "update usuarios set nome = '" + comboBox1.Text.Trim() + "' where usuarios.login = '" + txtlogin.Text + "'";
                    }
                    else
                    {
                        query = "update usuarios set idcategoriausu = '" + idUsuarioCate[cbCargo.SelectedIndex] + "' , nome = '" + comboBox1.Text.Trim() + "', ban = '" + Intban + "' where usuarios.login = '" + txtlogin.Text + "'";
                    }
                   
                }
                else
                {
                   
                    if (powerlevel <= 2)
                    {
                        query = "update usuarios set senha = '" + txtnovasenha.Text.Trim() + "', nome = '" + comboBox1.Text.Trim() + "' where usuarios.login = '" + txtlogin.Text + "'";
                    }
                    else
                    {
                        query = "update usuarios set senha = '" + txtnovasenha.Text.Trim() + "', idcategoriausu = '" + idUsuarioCate[cbCargo.SelectedIndex] + "' , nome = '" + comboBox1.Text.Trim() + "', ban = '" + Intban + "' where usuarios.login = '" + txtlogin.Text + "'";
                    }
                }
                
                
                db.SqlConnection();
                db.SqlQuery(query);  Clipboard.SetText(query);
                db.QueryRun();
                db.closeConnection();
                MessageBox.Show("Usuario Atualizado.");
                this.Hide();
                getform.Visible = true;



            }
            else
            {
                MessageBox.Show("Senhas nao conferem");
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtlogin.Text = login[comboBox1.SelectedIndex];
            if (cbCargo.Visible == true)
            {
                cbCargo.SelectedIndex = idCategoria.IndexOf(idUsuarioCate[login.IndexOf(txtlogin.Text)]);
            }
            
            if (BanBool[login.IndexOf(txtlogin.Text)] == 1)
            {
                chekBan.Checked = true;
            }
            else
            {
                chekBan.Checked =  false;
            }
        }

        private void frmAlteraUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            getform.Visible = true;
        }
    }
}
