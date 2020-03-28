using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdairRA2EventsUnlimited
{
    class DatabaseConnection
    {
        
        public static SqlConnection myConnection = new SqlConnection("user id = ;"
            + "password = ;"
            //+ "server = 10.1.21.19,49171;"
            //+ "server = ROWAN-PC\\SQLEXPRESS;"
            + "server = "
            + "Trusted_Connection = yes;"
            + "database = AdairRA2EventsUnlimited;"
            + "connection timeout = 30;");
        public static void OpenConnection()
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
        }/*Method to open connection to database*/
        public static void CloseConnection()
        {
            if (myConnection.State == ConnectionState.Open)
                myConnection.Close();
        }/*Method to close connection to database*/
        

    }
}
