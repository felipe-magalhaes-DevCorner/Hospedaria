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
    public partial class frmListAll : Form
    {
        private ConnectionClass db = new ConnectionClass();
        public frmListAll()
        {

            InitializeComponent();
            


        }

        private void frmListAll_Load(object sender, EventArgs e)
        {
            db.SqlConnection();
            string query = "select clientes.nome, clientes.cpf, clientes.telefone, clientes.celular, clientes.email, clientes.cidade from clientes";
            db.SqlQuery(query);  Clipboard.SetText(query);
            db.QueryRun();
            DataTable _dt = db.QueryDT();
            dataGridView1.DataSource = _dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }
        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //    {
        //        if (e.Value != null)
        //        {
        //            e.Value = e.Value.ToString().Trim();
        //        }
        //    }
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                
                fdrClientes.frmAlterarHospedes objAlt = new frmAlterarHospedes(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), true);
                
                objAlt.Show();
                
                
                this.Hide();


            }
            else
            {
                MessageBox.Show("Selecione um cliente");
            }
        }
    }
}
