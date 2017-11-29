using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrQuartos
{
    public partial class CheckOut : Form
    {
        private ConnectionClass db = new ConnectionClass();
        List<int> idCliente = new List<int>();
        List<string> nomeCliente = new List<string>();
        List<int> idQuarto = new List<int>();
        List<decimal> incrementoPensao = new List<decimal>();
        List<decimal> valorQuarto = new List<decimal>();
        List<DateTime> dataCheckIn = new List<DateTime>();
        List<DateTime> dataCheckOut = new List<DateTime>();
        List<string> nomeQuarto = new List<string>();
        List<string> nomepensao = new List<string>();
        List<int> idpensao = new List<int>();
        List<int> idsituacao = new List<int>();
        private static double horas;
        public Form getform { get; set; }
        private static decimal valorHospedagem;
        private static decimal valorPensao;
        private static decimal ValorTotal;

        public CheckOut()
        {
            InitializeComponent();
            popComboBoxes();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            //if (comboBox1.Items.Count > 0)
            //{
            //                }
            //else
            //{
            //    MessageBox.Show("Nao existem hospedes na hospedaria.");
            //    this.Hide();
            //    Form1 form = new Form1();
            //    form.Visible = true;
            //    this.Hide();


            //}
        }
        private void popComboBoxes()
        {

            string query;

            query = "select SITUACAO.idSITUACAO, SITUACAO.idHOSPEDAGEM , SITUACAO.idPENSAO , SITUACAO.DATACHECKIN, situacao.DATeCHECKout , pensao.INCREMENTO , PENSAO.DESCRICAO , clientes.NOME as nomeCliente, HOSPEDAGEM.nome as nomeHospedagem, categoria_quarto.valor as valor from SITUACAO inner join PENSAO on PENSAO.idPENSAO = SITUACAO.idPENSAO inner join CLIENTES on CLIENTES.idCLIENTES = SITUACAO.idCLIENTES inner join HOSPEDAGEM on HOSPEDAGEM.idHOSPEDAGEM = SITUACAO.idHOSPEDAGEM inner join categoria_quarto on categoria_quarto.idcategoria_quarto = hospedagem.idcategoria where SITUACAO.SITUACAO = 'Ocupado' order by SITUACAO.idSITUACAO";
            db.SqlConnection();
            db.SqlQuery(query);
            SqlDataReader _dr = db.QueryReader();
            if (_dr.HasRows)
            {
                while (_dr.Read())
                {
                    nomeQuarto.Add(_dr["nomeHospedagem"].ToString().Trim());
                    idQuarto.Add(Convert.ToInt32(_dr["idHOSPEDAGEM"]));
                    idsituacao.Add(Convert.ToInt32(_dr["idsituacao"]));
                    nomeCliente.Add(_dr["nomeCliente"].ToString().Trim());
                    idpensao.Add(Convert.ToInt32(_dr["idPENSAO"]));
                    nomepensao.Add(_dr["DESCRICAO"].ToString().Trim());
                    dataCheckIn.Add(Convert.ToDateTime(_dr["DATACHECKIN"]));
                    valorQuarto.Add(Convert.ToDecimal(_dr["valor"]));
                    incrementoPensao.Add(Convert.ToDecimal(_dr["INCREMENTO"]));
                    if (true)
                    {
                        if (!DBNull.Value.Equals(_dr["DATeCHECKOUT"]))
                        {
                            //not null
                            dataCheckOut.Add(Convert.ToDateTime(_dr["DATeCHECKOUT"]));
                        }
                        else
                        {
                            //null
                            dataCheckOut.Add(DateTime.Now);
                        }

                    }

                }
                db.closeConnection();

                foreach (string item in nomeQuarto)
                {
                    comboBox1.Items.Add(item);
                }
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }

            }
            


        }
        private void CheckOut_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "update situacao set situacao = 'Pago', datecheckout = '"+DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "' from situacao where idsituacao = '" + idsituacao[comboBox1.SelectedIndex] + "'";
            Clipboard.SetText(query);
            db.SqlConnection();
            db.SqlQuery(query);
            db.QueryRun();
            query = "update hospedagem set idcondicao = '1' from hospedagem where idhospedagem = '" + idQuarto[comboBox1.SelectedIndex] + "'";
            Clipboard.SetText(query);
            db.SqlQuery(query);
            db.QueryRun();
            
            
            query = "insert into faturamento values ('" + idsituacao[comboBox1.SelectedIndex] + "',  '" +  horas + "', '" + valorHospedagem.ToString().Replace(",", ".") + "', '" + valorPensao.ToString().Replace(",", ".") + "','" + ValorTotal.ToString().Replace(",", ".") + "' )";
            Clipboard.SetText(query);
            db.SqlQuery(query);
            db.QueryRun();
            db.closeConnection();
            MessageBox.Show("Check out realizado.");
            this.Close();
            //Form1 form1 = new Form1(true);
            //form1.Visible = true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            txtNomeCliente.Text = nomeCliente[index];
            txtNomePensao.Text = nomepensao[index];
            double dia = 24;
            TimeSpan spamHoras = DateTime.Now - dataCheckIn[comboBox1.SelectedIndex];
            horas = spamHoras.TotalHours / dia;
            horas = Math.Ceiling(horas);
            valorHospedagem = (Convert.ToDecimal( valorQuarto[index]) * Convert.ToDecimal(horas)) ;
            valorPensao = (Convert.ToDecimal(incrementoPensao[index]) * Convert.ToDecimal(horas));
            ValorTotal = (valorHospedagem + valorPensao) ; 
            txtValorPensao.Text = valorPensao.ToString("C");
            txtValorQuarto.Text = valorHospedagem.ToString("C");
            txtValorTotal.Text = ValorTotal.ToString("C");
        }

        private void CheckOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 objPrincipal = new Form1();
            this.Hide();
            objPrincipal.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
