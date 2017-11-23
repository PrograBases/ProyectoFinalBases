using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Proyecto_Final_Bases_de_Datos
{
    public class ProductionOrderModel
    {
        public ProductionOrderModel()
        {
        }
        private ProductionOrder prodOrder;
        private SqlConnection connection = DBConnection.getInstance().connect();

        public ProductionOrderModel(ProductionOrder _productinoOrder) {
            prodOrder = _productinoOrder;
            connection = DBConnection.getInstance().connect();
        }

        public Boolean insert()
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Insert_ProdOrder()", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NoLote", SqlDbType.VarChar, 50).Value = prodOrder.getNoLote(); 
                cmd.Parameters.Add("@idProductoAsignado", SqlDbType.Int).Value = prodOrder.getIdAsignedProd();
                cmd.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = prodOrder.getCreationDate();
                cmd.Parameters.Add("@fechaTerminado", SqlDbType.DateTime).Value = prodOrder.getFinishedDate();
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = prodOrder.getStatus();

                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception e) {
                System.Console.WriteLine("No se pudo realizar la consulta");
                return false;
            } finally {
                DBConnection.getInstance().disconnect();
            }
        }

        public Boolean delete()
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Delete_ProdOrder", connection);
                cmd.Parameters.Add("@NoLote", SqlDbType.VarChar, 50).Value = prodOrder.getNoLote();
                cmd.ExecuteNonQuery();    
                return true;
            }
            catch (Exception e) {
                System.Console.WriteLine("No se pudo realizar la consulta");
                return false;
            } finally {
                DBConnection.getInstance().disconnect();
            }
        }
        public Boolean updateFinishedDate(DateTime _finishedDate) {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_FechaTerminado", connection);
                cmd.Parameters.Add("@NoLote", SqlDbType.VarChar, 50).Value = prodOrder.getNoLote();
                cmd.Parameters.Add("@fechaTerminado", SqlDbType.Date).Value = _finishedDate;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("No se pudo realizar la consulta");
                return false;
            }
            finally
            {
                DBConnection.getInstance().disconnect();
            }
        }
        public Boolean updateOrderStatus(int _orderStatus)
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_Status", connection);
                cmd.Parameters.Add("@NoLote", SqlDbType.VarChar, 50).Value = prodOrder.getNoLote();
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = _orderStatus;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("No se pudo realizar la consulta");
                return false;
            }
            finally
            {
                DBConnection.getInstance().disconnect();
            }
        }

        public Boolean update()
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_Status", connection);
                cmd.Parameters.Add("@NoLote", SqlDbType.VarChar, 50).Value = prodOrder.getNoLote();
                cmd.Parameters.Add("@fechaTerminado", SqlDbType.Date).Value = prodOrder.getFinishedDate();
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = prodOrder.getStatus();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("No se pudo realizar la consulta");
                return false;
            }
            finally
            {
                DBConnection.getInstance().disconnect();
            }
        }



        public string getNewProdOrderNumber(string _location)
        {
            SqlCommand cmd;
            string nolote = "", day, year, month, date, tuple, id;
            
            List<string> monthLetter = new List<string> { "A","B","C","D","E",
                                                "F","G","H","I","J","K","L"};

            try
            {
                // 10/10/2017
                cmd = new SqlCommand("get_new_OrderNumber", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@string", SqlDbType.VarChar, 50).Value = "";


                date = DateTime.Now.ToString();
                year = date.Substring(8, 9);
                month = date.Substring(0, 1);
                string monthL = monthLetter.ElementAt(Int32.Parse(month));
                day = date.Substring(3, 4);

                DataTable dataTable = new DataTable();
                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                var array = dataTable.Select();

                if (array.Length == 0)
                {
                    id = (_location.Substring(0, 1)) + year + monthL
                        + day + "001";
                }
                else
                {
                    List<int> codeslist = new List<int>();
                    foreach (var o in array)
                    {
                        tuple = o.ToString().Substring(7, 9);
                        codeslist.Add(Int32.Parse(tuple));

                    }

                    string code = getNewCode(codeslist);
                    id = (_location.Substring(0, 1)) + year + monthL
                        + day + code;

                }


                da.Dispose();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
                System.Console.WriteLine("Error");

            }
            finally
            {
                //DBConnection.getInstance().disconnect();

            }
            return nolote;

        }



        private string getNewCode(List<int> _codeslist)
        {

            int mayor = _codeslist.ElementAt(0);
            foreach (int e in _codeslist)
            {
                if (e > mayor)
                {
                    mayor = e;
                }
            }
            mayor++;
            string m = mayor.ToString();
            if (mayor < 10)
            {
                m = "00" + m;
            }
            else if (mayor < 100)
            {
                m = "0" + m;
            }

            return m;

        }


    }
}