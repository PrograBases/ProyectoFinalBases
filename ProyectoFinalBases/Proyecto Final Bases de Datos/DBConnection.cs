using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Bases_de_Datos
{
    class DBConnection
    {
        //SqlConnection connection;
        private static DBConnection connectionInstance = null;
        private static SqlConnection connection;
        private static Boolean connected;

        public void conectar()
        {
            //connection = new SqlConnection("Data Source=163.178.173.148;Initial Catalog=DB_PROD;Persist Security Info=True;User ID=estudiantes;Password=estudiantes");
            //connection = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
            connection.Open();
        }

        public void desconectar()
        {
            connection.Close();
        }

        public void ejecutarSql(string sqlQuery)
        {
            SqlCommand commandQuery = new SqlCommand(sqlQuery, connection);
            int rowsAffected = commandQuery.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Operacion realizada correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("No se ha connectado a la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void actualizarDataGridView(DataGridView tableShow, string sqlQuery)
        {
            this.conectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connection); //Intermediario entre data set y base de datos
            da.Fill(ds, "PRODUCTOS_MASTER");
            tableShow.DataSource = ds;
            tableShow.DataMember = "PRODUCTOS_MASTER";
            this.desconectar();

        }
        public void insertProduct(string idProducto, string idFlujo, string TP, string Descp)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ProductCreate", connection))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id_Producto", SqlDbType.Int).Value = Int32.Parse(idProducto);
                    cmd.Parameters.Add("@Id_Flujo", SqlDbType.Int).Value = Int32.Parse(idFlujo);
                    cmd.Parameters.Add("@TipoProducto", SqlDbType.NVarChar).Value = TP;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Descp;
                    cmd.ExecuteNonQuery();
        
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} No se pudo realizar el sp.", e);
                }


            }
        }

        public void updateProduct(string idProducto, string idFlujo, string TP, string Descp)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ProductUpdate", connection))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id_Producto", SqlDbType.Int).Value = Int32.Parse(idProducto);
                    cmd.Parameters.Add("@Id_Flujo", SqlDbType.Int).Value = Int32.Parse(idFlujo);
                    cmd.Parameters.Add("@TipoProducto", SqlDbType.NVarChar).Value = TP;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Descp;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} No se pudo realizar el sp.", e);
                }


            }
        }

        public static DBConnection getInstance()
        {
            if (connectionInstance == null)
            {
                connectionInstance = new DBConnection();
            }
            return connectionInstance;

        }

        public SqlConnection connect()
        {
            try
            {
                /*connection = new SqlConnection("user id=username;" +
                                      "password=password;server=serverurl;" +
                                      "Trusted_Connection=yes;" +
                                      "database=database; " +
                                               "connection timeout=30");*/
                connection = new SqlConnection("Data Source=163.178.173.148;Initial Catalog=DB_PROD;Persist Security Info=True;User ID=estudiantes;Password=estudiantes");
                Console.WriteLine("Connected to DATABASE");

                //connection = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
                connected = true;
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public void disconnect()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }

    
}
