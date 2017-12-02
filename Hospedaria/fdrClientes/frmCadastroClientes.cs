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

namespace Hospedaria.fdrClientes
{
    public partial class frmCadastroClientes : Form
    {
        public Form RefToMenu { get; set; }
        private ConnectionClass db = new ConnectionClass();


        public frmCadastroClientes()
        {
            InitializeComponent();
        }
        private bool ChechaCPF(string mskCPF)
        {
            List<string> listaCPF = new List<string>();
            bool unico;
            db.SqlConnection();
            string query = "Select clientes.cpf from clientes";
            db.SqlQuery(query);  Clipboard.SetText(query);
            SqlDataReader _dr = db.QueryReader();
            while (_dr.Read())
            {

                listaCPF.Add((_dr["CPF"].ToString().Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Trim()));

            }
            if (listaCPF.Contains(mskCPF.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Trim()))
            {
                unico = false;
            }
            else
            {
                unico = true;
            }

            return unico;
        }





        private void button1_Click(object sender, EventArgs e)
        /////botao GRAVAR----------------------------------------------------------------------------------------
        {

            //botao salvar
            //---------------------- VERIFICA SE CAMPO CPF É VALIDO(OU EM BRANCO)----------------------
            if (fdrClientes.ValidaCPF.IsCpf(mskCPF.Text))
            {

                //---------------------- VERIFICA SE CAMPO NOME ESTA EM BRANCO----------------------
                if (txtName.Text != "")
                {
                    //---------------------- VERIFICA SE O CPF JA ESTA CADASTRADO----------------------
                    if (ChechaCPF(mskCPF.Text))
                    {
                        //---------------------- VERIFICA SE CAMPO CIDADE ESTA EM BRANCO----------------------
                        if (txtCidade.Text != "")
                        {

                            
                            clienteSQL cd = new clienteSQL();

                            //---------------------- CHAMA CLASSE(METODO) DE CADASTRAR CLIENTES----------------------
                            cd.cadastraCliente(mskCPF.Text.Trim(), txtName.Text.Trim(), mskTelefone.Text.Trim(), mskCelular.Text.Trim(), txtEmail.Text.Trim().ToLower(), txtCidade.Text.Trim());
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastrado");
                            this.Close();
                            //DialogResult dialogResult = MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.YesNo);
                            //if (dialogResult == DialogResult.Yes)
                            //{
                            //    txtCidade.Clear();
                            //    txtEmail.Clear();
                            //    txtName.Clear();
                            //    mskCelular.Clear();
                            //    mskCPF.Clear();
                            //    mskTelefone.Clear();

                            //}
                            //else if (dialogResult == DialogResult.No)
                            //{
                            //    
                            //}


                        }
                        else
                        {
                            MessageBox.Show("O campo Cidade é obrigatorio");//CIDADE EM BRANCO
                        }

                    }
                    else
                    {
                        MessageBox.Show("CPF ja cadastrado. Revise informações.");
                    }
                    


                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatorio");//NOME EM BRANCO
                }


            }
            else
            {
                MessageBox.Show("O CPF informado é inválido!");//CPF INVALIDO
            }




        }
        private void clearitems()
        {
            txtCidade.Clear();
            txtEmail.Clear();
            txtName.Clear();
            mskCelular.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();


        }

        private void frmCadastroClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 objPrin = new Form1();
            this.Hide();
            RefToMenu.Visible = true;


        }
    }
}
