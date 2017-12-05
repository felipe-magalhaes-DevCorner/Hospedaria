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
        private List<int> idUsuarioCate = new List<int>();
        private List<string> descricao = new List<string>();
        private ConnectionClass db = new ConnectionClass();
        public Form getform { get; set; }
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            db.SqlConnection();
            string query = "select categoriausu.descricao,  categoriausu.idcategoriausu from categoriausu where categoriausu.idcategoriausu <> 1";
            db.SqlQuery(query);  Clipboard.SetText(query);
            SqlDataReader _dr =  db.QueryReader();
            while (_dr.Read())
            {
                idUsuarioCate.Add(Convert.ToInt32( _dr["idcategoriausu"]));
                descricao.Add(_dr["descricao"].ToString());


            }
            
            foreach (string item in descricao)
            {
                comboBox1.Items.Add(item);

            }
            

            comboBox1.SelectedIndex = 0;
        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            getform.Visible = true;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {

            if (txtConfirmaSenha.Text != "")
            {

                if (txtLogin.Text != "")
                {
                    if (txtMestre.Text != "")
                    {
                        if (txtNome.Text != "")
                        {
                            if (txtSenha.Text != "")
                            {
                                if (txtSenha.Text == txtConfirmaSenha.Text)
                                {
                                    string query = "insert into usuarios values ('" + idUsuarioCate[comboBox1.SelectedIndex] + "', '" + txtNome.Text.Trim() + "', '" + txtLogin.Text.Trim() + "', '" + txtSenha.Text.Trim() + "', '" + txtMestre.Text.Trim() + "', '0', '0')";
                                    db.SqlConnection();
                                    db.SqlQuery(query); Clipboard.SetText(query);
                                    db.QueryRun();
                                    db.closeConnection();

                                    DialogResult dialogResult = MessageBox.Show("Novo usuario cadastrado com sucesso. Gostaria de cadastrar outro usuario?", "Concluido", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        txtNome.Clear();
                                        txtLogin.Clear();
                                        txtSenha.Clear();
                                        txtConfirmaSenha.Clear();
                                        txtMestre.Clear();
                                        comboBox1.SelectedIndex = 0;
                                    }
                                    else if (dialogResult == DialogResult.No)
                                    {
                                        this.Close();
                                    }

                                }
                                else
                                {

                                    MessageBox.Show("As senhas nao batem.");
                                }












                            }
                            else
                            {
                                MessageBox.Show("Nao sera dessa vez marlon");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Nao sera dessa vez marlon");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nao sera dessa vez marlon");
                    }

                }
                else
                {
                    MessageBox.Show("Nao sera dessa vez marlon");
                }
            }
            else
            {
                MessageBox.Show("Nao sera dessa vez marlon");
            }


















            
            



        }
        
    }
}
