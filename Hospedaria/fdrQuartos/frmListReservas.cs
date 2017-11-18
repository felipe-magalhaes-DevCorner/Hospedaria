using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedaria.fdrQuartos
{
    public partial class frmListReservas : Form
    {
        private ConnectionClass db = new ConnectionClass();
        public frmListReservas()
        {
            InitializeComponent();
        }

        private void frmListReservas_Load(object sender, EventArgs e)
        {
            db.SqlConnection();
            string query = "select hospedagem.nome, clientes.nome,reservas.datareserva, reservas.datasaida from hospedagem inner join reservas on reservas.idhospedagem = hospedagem.idhospedagem inner join clientes on clientes.idclientes = reservas.idclientes ";
            db.SqlQuery(query);

            db.QueryRun();
            DataTable _dt = db.QueryDT();
            dataGridView1.DataSource = _dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                fdrQuartos.CheckIn objAlt = new fdrQuartos.CheckIn(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),'d');

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
