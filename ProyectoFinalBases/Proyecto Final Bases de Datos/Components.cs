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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
        }

        private void Components_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_PRODDataSet1.MATERIAL' Puede moverla o quitarla según sea necesario.
            this.mATERIALTableAdapter.Fill(this.dB_PRODDataSet1.MATERIAL);

        }
    }
}
