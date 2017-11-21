using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Bases_de_Datos
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void mantProdBTN_Click(object sender, EventArgs e)
        {
            //Application.Run(new Productos());
            Productos newProd = new Productos();
            newProd.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearOrden newOrder = new CrearOrden();
            newOrder.Show();
        }

        private void compBTN_Click(object sender, EventArgs e)
        {
            Componentes newComponent = new Componentes();
            newComponent.Show();
            
        }
    }
}
