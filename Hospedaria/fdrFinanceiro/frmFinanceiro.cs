using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrFinanceiro
{
    public partial class frmFinanceiro : Form
    {
        public Form getform { get; set; }
        private ConnectionClass db = new ConnectionClass();
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            CarregaDados();
            dia.Checked = true;


        }

        private void CarregaDados()
        {
            string query;
            dataGridView2.DataSource = "";
            //---------------------- pega tudo do SQL faturamento
            if (periodo.Checked)//se for periodo
            {
                query = "select RTRIM(LTRIM(FATURAMENTO.idSITUACAO))  as NotaFiscal, RTRIM(LTRIM(HOSPEDAGEM.NOME)) as Quarto, RTRIM(LTRIM(CLIENTES.NOME)) as Cliente, FATURAMENTO.VALOR_HOSPEDAGEM as ValorQuarto, FATURAMENTO.valor_pensao as ValorPensao, FATURAMENTO.VALOR_TOTAL as Total, SITUACAO.DATACHECKIN as CheckIn, SITUACAO.DATECHECKOUT as CheckOut from faturamento inner join SITUACAO on SITUACAO.idSITUACAO = FATURAMENTO.idSITUACAO inner join HOSPEDAGEM on HOSPEDAGEM.idHOSPEDAGEM = SITUACAO.idHOSPEDAGEM inner join CLIENTES on CLIENTES.idCLIENTES = SITUACAO.idCLIENTES where  cast (SITUACAO.datecheckout as date) between  '" + datepicker1.Value.ToString("dd/MM/yyyy") + "' and '" + datepicker2.Value.ToString("dd/MM/yyyy") + "' order by  Quarto , CheckIn, Cliente  ";
            }
            else//se for dia
            {
                query = "select RTRIM(LTRIM(FATURAMENTO.idSITUACAO))  as NotaFiscal, RTRIM(LTRIM(HOSPEDAGEM.NOME)) as Quarto, RTRIM(LTRIM(CLIENTES.NOME)) as Cliente, FATURAMENTO.VALOR_HOSPEDAGEM as ValorQuarto, FATURAMENTO.valor_pensao as ValorPensao, FATURAMENTO.VALOR_TOTAL as Total, SITUACAO.DATACHECKIN as CheckIn, SITUACAO.DATECHECKOUT as CheckOut from faturamento inner join SITUACAO on SITUACAO.idSITUACAO = FATURAMENTO.idSITUACAO inner join HOSPEDAGEM on HOSPEDAGEM.idHOSPEDAGEM = SITUACAO.idHOSPEDAGEM inner join CLIENTES on CLIENTES.idCLIENTES = SITUACAO.idCLIENTES where  cast (SITUACAO.datecheckout as date) = '" + datepicker1.Value.ToString("dd/MM/yyyy") + "' order by  Quarto , CheckIn, Cliente  ";
            }

            db.SqlConnection();
            
            db.SqlQuery(query);  Clipboard.SetText(query);

            db.QueryRun();
            DataTable _dt = db.QueryDT();

            dataGridView2.DataSource = _dt;
            dataGridView2.AutoResizeColumns();
            db.closeConnection();
        }

        private void frmFinanceiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            getform.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (periodo.Checked)
            {
                
                datepicker2.Visible = true;
                label1.Visible = true;
                
                DateTime dt = DateTime.Now;

                var firstDayOfMonth = new DateTime(dt.Year, dt.Month, 1);
                datepicker1.Value = firstDayOfMonth;
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                datepicker2.Value = lastDayOfMonth;
            }
            CarregaDados();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (dia.Checked)
            {
                datepicker1.Enabled = true;
                datepicker2.Visible = false;
                label1.Visible = false;
                datepicker1.Value = DateTime.Now;

            }
            CarregaDados();


        }

        private void datepicker1_ValueChanged(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void datepicker2_ValueChanged(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
