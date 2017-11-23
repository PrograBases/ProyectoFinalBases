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
using System.Configuration;
using System.Collections.Specialized;

namespace Proyecto_Final_Bases_de_Datos
{
    public partial class Productos : Form
    {
        private object configurationManager;
        DBConnection dbConnection = new DBConnection();
        Boolean editar;
       

        public Productos()
        {
            InitializeComponent();
            
        }
        public void actualizarGrid()
        {
            dbConnection.actualizarDataGridView(this.dataGridView1, "Select * From PRODUCTOS_MASTER");

        }
        public void limpiar()
        {
            idProducto.Text = ""; 
            idFlujoProducto.Text = "";
            tipoProducto.Text = "";
            descripcionProducto.Text = "";
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            editar = false;
            this.actualizarGrid();


        }


        private void crearProducto_Click(object sender, EventArgs e)
        {
            dbConnection.conectar();
            dbConnection.insertProduct(idProducto.Text, idFlujoProducto.Text, tipoProducto.Text, descripcionProducto.Text);
            dbConnection.desconectar();
            this.actualizarGrid();
            this.limpiar();
            MessageBox.Show("Operacion realizada correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoProducto_Click(object sender, EventArgs e)
        {
            idProducto.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            idFlujoProducto.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tipoProducto.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            descripcionProducto.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void actualizarProducto_Click(object sender, EventArgs e)
        {
            dbConnection.conectar();
            dbConnection.updateProduct(idProducto.Text, idFlujoProducto.Text, tipoProducto.Text, descripcionProducto.Text);
            dbConnection.desconectar();
            this.actualizarGrid();
            this.limpiar();
            MessageBox.Show("Operacion realizada correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void eliminarProducto_Click(object sender, EventArgs e)
        {
            dbConnection.conectar();
            string consulta = "delete from PRODUCTOS_MASTER where IdProducto = '" + Int32.Parse(idProducto.Text) + "';";
            dbConnection.ejecutarSql(consulta);
            this.actualizarGrid();
            dbConnection.desconectar();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verProducto_Click(object sender, EventArgs e)
        {
            idProducto.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            idFlujoProducto.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tipoProducto.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            descripcionProducto.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void buscarIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            dbConnection.actualizarDataGridView(dataGridView1, "Select * From PRODUCTOS_MASTER Where TipoProducto'" + buscarIdProducto.Text + "%'"); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
