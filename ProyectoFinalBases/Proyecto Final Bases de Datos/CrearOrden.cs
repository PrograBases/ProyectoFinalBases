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
    public partial class CrearOrden : Form
    {
        private ProductionOrder prodOrder;
        private ProductionOrderModel prodOrderModel = new ProductionOrderModel();
        private SqlConnection connection = DBConnection.getInstance().connect();

        public CrearOrden()
        {

            InitializeComponent();
            prodBOX_Update();
            prodLineBOX_Update();
            //updateNoLote();
        }

        private void prodBOX_Click(object sender, EventArgs e)
        {

        }

        private void updateNoLote()
        {
            prodOrderModel.getNewProdOrderNumber("CR");
        }

        private void prodLineBOX_Update()
        {
            Console.WriteLine("JOJOJOJOJOJO");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                //cmd = new SqlCommand("getProductos", connection);
                //SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
                //SqlCommand cmd = new SqlCommand();
                //SqlDataReader reader;

                cmd.CommandText = "[dbo].[getLíneasProducción]";
                //cmd.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = 2;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                connection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    string title = reader["IdLíneaProd"].ToString();
                    //string description = (string)reader["Nombre"];

                    string item = string.Format("{0}", title);
                    //string item = string.Format("{0}", title);
                    Console.WriteLine(item);
                    //this.materialDispBOX.Items.Add(item);
                    prodLineBOX.Items.Add(item);
                }

            }
            catch (Exception a)
            {

                System.Console.WriteLine("No se pudo realizar la consulta");
                //return false;
            }
            finally
            {
                DBConnection.getInstance().disconnect();
            }

        }
        private void prodBOX_Update()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                //cmd = new SqlCommand("getProductos", connection);
                //SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
                //SqlCommand cmd = new SqlCommand();
                //SqlDataReader reader;

                cmd.CommandText = "[dbo].[getProductos]";
                //cmd.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = 2;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                connection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    string title = reader["IdProducto"].ToString();
                    string description = (string)reader["Nombre"];

                    string item = string.Format("{0} - {1}", title, description);
                    Console.WriteLine(item);
                    //this.materialDispBOX.Items.Add(item);
                    prodBOX.Items.Add(item);
                }

            }
            catch (Exception a)
            {

                System.Console.WriteLine("No se pudo realizar la consulta");
                //return false;
            }
            finally
            {
                DBConnection.getInstance().disconnect();
            }
        }
    }
}
