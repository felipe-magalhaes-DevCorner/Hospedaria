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
        private ConnectionClass db = new ConnectionClass();
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            //---------------------- pega tudo do SQL faturamento
            string query = "select RTRIM(LTRIM(FATURAMENTO.idSITUACAO))  as NotaFiscal, RTRIM(LTRIM(HOSPEDAGEM.NOME)) as Quarto, RTRIM(LTRIM(CLIENTES.NOME)) as Cliente, FATURAMENTO.VALOR_HOSPEDAGEM as ValorQuarto, FATURAMENTO.valor_pensao as ValorPensao, FATURAMENTO.VALOR_TOTAL as Total, SITUACAO.DATACHECKIN as CheckIn, SITUACAO.DATECHECKOUT as CheckOut from faturamento inner join SITUACAO on SITUACAO.idSITUACAO = FATURAMENTO.idSITUACAO inner join HOSPEDAGEM on HOSPEDAGEM.idHOSPEDAGEM = SITUACAO.idHOSPEDAGEM inner join CLIENTES on CLIENTES.idCLIENTES = SITUACAO.idCLIENTES ";
            db.SqlConnection();
            Clipboard.SetText(query);
            db.SqlQuery(query);

            db.QueryRun();
            DataTable _dt = db.QueryDT();
            
            dataGridView2.DataSource = _dt;
            dataGridView2.AutoResizeColumn(1);

            db.closeConnection();
            

        }

        private void frmFinanceiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 objPrin = new Form1();
            objPrin.Visible = true;
        }
    }
}
