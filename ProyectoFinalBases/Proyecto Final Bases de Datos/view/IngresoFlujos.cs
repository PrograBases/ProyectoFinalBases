using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Bases_de_Datos.view
{
    public partial class IngresoFlujos : Form
    {
        DBConnection dbConnection = new DBConnection();

        public IngresoFlujos()
        {
            InitializeComponent();
        }

        private void IngresoFlujos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PRODDataSet1.FLUJO_MASTER' table. You can move, or remove it, as needed.
            this.fLUJO_MASTERTableAdapter.Fill(this.dB_PRODDataSet1.FLUJO_MASTER);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoFlujoMasterTxt.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nuevoFlujoMaster = Int32.Parse(nuevoFlujoMasterTxt.Text);
            dbConnection.conectar();
            dbConnection.insertFlujoMaster(Int32.Parse(nuevoFlujoMasterTxt.Text));
            dbConnection.desconectar();
            this.actualizarGrid();
            nuevoFlujoMasterTxt.Text = "";
        }

        private void actualizarGrid()
        {
            dbConnection.actualizarDataGridView(this.dataGridView1, "Select * From FLUJO_MASTER");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nuevoFlujo = Int32.Parse(codigoFlujoTxt.Text);
            int nuevoFlujoMaster = Int32.Parse(codigoFlujoMasterTxt.Text);

            dbConnection.conectar();
            dbConnection.insertFlujo(nuevoFlujo, nuevoFlujoMaster);
            dbConnection.desconectar();
            this.actualizarGrid();
            codigoFlujoTxt.Text = "";
            codigoFlujoMasterTxt.Text = "";
        }
    }
}
