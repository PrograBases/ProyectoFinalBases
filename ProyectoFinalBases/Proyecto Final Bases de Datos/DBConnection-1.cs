using System;
using System.Data.SqlClient;
namespace MATERIAL
{
    public sealed class DBConnection{
        private static DBConnection connectionInstance = null;
        private static SqlConnection connection;
        private static Boolean connected;

        private DBConnection() {
            

        }


        public static DBConnection getInstance()
        {
            if (connectionInstance == null) {
                connectionInstance = new DBConnection();
            }
            return connectionInstance;

        }

        public SqlConnection connect() {
            try
            {
                /*connection = new SqlConnection("user id=username;" +
                                      "password=password;server=serverurl;" +
                                      "Trusted_Connection=yes;" +
                                      "database=database; " +
                                               "connection timeout=30");
                Console.WriteLine("Connected to DATABASE");*/
                connection = new SqlConnection("Server= localhost; Database= DB_PROD; Integrated Security=True;");
                connected = true;
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public void disconnect() {
            try {
                connection.Close();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}