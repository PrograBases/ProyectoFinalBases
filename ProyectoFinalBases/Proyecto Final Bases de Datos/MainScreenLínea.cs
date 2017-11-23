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

namespace Proyecto_Final_Bases_de_Datos
{
    public partial class MainScreenLínea : Form
    {
        private ProductionOrderModel prodOrderModel = new ProductionOrderModel();
        private SqlConnection connection = DBConnection.getInstance().connect();


        public MainScreenLínea()
        {
            InitializeComponent();
        }

        public void InitializeActivities(int IdProducto)
        {
            try
            {
                //materialDispBOX.Items.Clear();

                //SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;


                int idProd = 1;

                //Int32.TryParse(idProductoTxtBOXX.Text, out idProd);

                //Console.WriteLine(idProductoTxtBOXX.Text);

                cmd.CommandText = "[dbo].[getFlujoDeProducto]";
                cmd.Parameters.Add("@idProd", SqlDbType.Int).Value = idProd;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                connection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Console.WriteLine("A versh");
                    string title = reader["Nombre"].ToString();
                    string Periódica = reader["Periódica"].ToString();   //Y-N
                    string TiempoMIN = reader["Tiempo"].ToString();     //TIEMPO EN MINUTOS

                    //int dependency = (int)reader["DEPENDIENTE"];
                    //DBNull.Value
                    string item = string.Format("{0}", title);
                    if (Periódica == "Y")
                    {
                        item = string.Format("{0} - {1}", title, TiempoMIN + "min");
                        PeriodicsBOX.Items.Add(item);
                    }

                    
                    else if (reader["DEPENDIENTE"] == DBNull.Value || ToDoBOX.Items.Count == 0)
                    {
                        //Console.WriteLine("HOLAAAAAAAAAAAA");
                        ToDoBOX.Items.Add(item);
                    }
                    else
                    {
                        IncomingBOX.Items.Add(item);
                    }

                    
                    Console.WriteLine(item);
                    //this.materialDispBOX.Items.Add(item);

                }

                //materialDispBOX.Update();
                connection.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.GetBaseException());
            }

        }

        private void hacerActBTN_Click(object sender, EventArgs e)
        {
            try
            { 
            ToDoBOX.Items.Clear();

            ToDoBOX.Items.Add(IncomingBOX.Items[0]);

            IncomingBOX.Items.RemoveAt(0);
            }catch(Exception exc)
            {
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CrearOrden newOrder = new CrearOrden();
            newOrder.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Componentes newComponent = new Componentes();
            newComponent.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Productos newProd = new Productos();
            newProd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.InitializeActivities(1);
        }

        private void mantenimientoFlujosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.IngresoFlujos ingresoFlujo = new view.IngresoFlujos();
            ingresoFlujo.Show();
        }

        private void mantenimientoActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.IngresoActividades ingresoActividades = new view.IngresoActividades();
            ingresoActividades.Show();
        }
    }
}
