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
        public Form RefToMenu { get; set; }

        public frmCadastroClientes()
        {
            InitializeComponent();
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
                    if (txtCidade.Text != "")
                    {
                        //---------------------- VERIFICA SE CAMPO CIDADE ESTA EM BRANCO----------------------
                        clienteSQL cd = new clienteSQL();

                        //---------------------- CHAMA CLASSE(METODO) DE CADASTRAR CLIENTES----------------------
                        cd.cadastraCliente(mskCPF.Text.Trim(), txtName.Text.Trim(), mskTelefone.Text.Trim(), mskCelular.Text.Trim(), txtEmail.Text.Trim().ToLower(), txtCidade.Text.Trim());
                        
                        DialogResult dialogResult = MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtCidade.Clear();
                            txtEmail.Clear();
                            txtName.Clear();
                            mskCelular.Clear();
                            mskCPF.Clear();
                            mskTelefone.Clear();
                            
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("O campo Cidade é obrigatorio");//CIDADE EM BRANCO
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
            objPrin.ShowDialog();
            
        }
    }
}
