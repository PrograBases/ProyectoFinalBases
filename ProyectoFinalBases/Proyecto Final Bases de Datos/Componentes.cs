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
    public partial class Componentes : Form
    {
        private ProductionOrderModel prodOrderModel = new ProductionOrderModel();
        private SqlConnection connection = DBConnection.getInstance().connect();

        public Componentes()
        {
            InitializeComponent();
            Console.WriteLine("A AGAGASG");
            InitializeComponent();
            //materialDispBOX.

            //SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "[dbo].[getMateriales]";
            cmd.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = 2;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            connection.Open();

            reader = cmd.ExecuteReader();
            //materialDispBOX.Items.Add("Horse");
            while (reader.Read())
            {
                Console.WriteLine("A versh");
                string title = reader["IdMAterial"].ToString();
                string description = (string)reader["Descripción"];

                string item = string.Format("{0} - {1}", title, description);

                this.materialDispBOX.Items.Add(item);
                materialDispBOX.Refresh();
            }


            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retrieveMaterialBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialSelectBOX.SelectedItem != null)
                {
                    materialDispBOX.Items.Add(materialSelectBOX.SelectedItem);
                    materialSelectBOX.Items.RemoveAt(materialSelectBOX.SelectedIndex);

                }
            }
            catch { }


        }

        private void addMaterialBTN_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (materialDispBOX.SelectedItem != null)
                {
                    materialSelectBOX.Items.Add(materialDispBOX.SelectedItem);
                    materialDispBOX.Items.RemoveAt(materialDispBOX.SelectedIndex);
                }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                materialDispBOX.Items.Clear();

                //SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;


                int idProd = 1;

                //Int32.TryParse(idProductoTxtBOXX.Text, out idProd);

                Console.WriteLine(idProductoTxtBOXX.Text);

                cmd.CommandText = "[dbo].[getMateriales]";
                cmd.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = idProd;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                connection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    //Console.WriteLine("A versh");
                    string title = reader["IdMAterial"].ToString();
                    string description = (string)reader["Descripción"];

                    string item = string.Format("{0} - {1}", title, description);
                    Console.WriteLine(item);
                    this.materialDispBOX.Items.Add(item);
                    
                }

                materialDispBOX.Update();
                connection.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.GetBaseException());
            }

        }

        private void aceptarCompBTN_Click(object sender, EventArgs e)
        {
            materialSelectBOX.Items.Clear();
        }


    }
}
