using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PROD_DB
{
    public class ProductionOrderModel
    {
        public ProductionOrderModel()
        {
        }
        private ProductionOrder prodOrder;
        private SqlConnection connection;

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

        public string getNewProdOrderNumber(string _location) {
            SqlCommand cmd;
            string nolote = "",day,year,monthm,date;
            try
            {
                cmd = new SqlCommand("get_new_OrderNumber", connection);
                date = DateTime.Now.ToString();
                year = date.Substring(8, 9);
                cmd.Parameters.Add("@string", SqlDbType.VarChar, 50).Value = "";

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rdr);
                List<string> list = new List<string>;
                string NoLoteStr = "";
                while (rdr.Read()) {
                    //do something
                    NoLoteStr = rdr[name: "NoLote"];
                    list.Add(NoLoteStr);


                    
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("No se pudo realizar la consulta");
                
            }
            finally
            {
                DBConnection.getInstance().disconnect();
                
            }
            return nolote;

        }

        
    }
}