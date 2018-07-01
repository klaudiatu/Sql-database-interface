using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace SaveImagetoSQLServer
{
    class Class1
    {
        public static SqlConnection ConnectDB()
        {

            string zmienna = ConfigurationManager.ConnectionStrings["ConnectSQLDB"].ConnectionString;

            SqlConnection conn = new SqlConnection(zmienna);
            conn.Open();
            
            return conn;
        }

    }
}
