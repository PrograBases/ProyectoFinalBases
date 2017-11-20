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


namespace MATERIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //materialDispBOX.

            SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "[dbo].[getMateriales]";
            cmd.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = 2;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("A versh");
                string title = reader["IdMAterial"].ToString();
                string description =  (string)reader["Descripción"];

                string item = string.Format("{0} - {1}", title, description);

                this.materialDispBOX.Items.Add(item);
            }


            sqlConnection1.Close();
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
            materialDispBOX.Items.Clear();

            SqlConnection sqlConnection1 = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
        

            int idProd = 0;

            Int32.TryParse(idProductoTxtBOX.Text, out idProd);

            cmd.CommandText = "[dbo].[getMateriales]";
            cmd.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = idProd;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("A versh");
                string title = reader["IdMAterial"].ToString();
                string description = (string)reader["Descripción"];

                string item = string.Format("{0} - {1}", title, description);

                this.materialDispBOX.Items.Add(item);
            }


            sqlConnection1.Close();

        }
    }
}
