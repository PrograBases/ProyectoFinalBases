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
    public partial class IngresoActividades : Form
    {
        public IngresoActividades()
        {
            InitializeComponent();
        }

        private void IngresoActividades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PRODDataSet3.ACTIVIDAD_MASTER' table. You can move, or remove it, as needed.
            this.aCTIVIDAD_MASTERTableAdapter1.Fill(this.dB_PRODDataSet3.ACTIVIDAD_MASTER);
            // TODO: This line of code loads data into the 'dB_PRODDataSet2.ACTIVIDAD_MASTER' table. You can move, or remove it, as needed.
            this.aCTIVIDAD_MASTERTableAdapter.Fill(this.dB_PRODDataSet2.ACTIVIDAD_MASTER);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            descripcion.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pantalla.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tipoFirma.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            rolSeguridad.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            requerida.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            periodica.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tiempo.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cambiaEstado.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            adHoc.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
