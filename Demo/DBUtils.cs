using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Demo
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-5N5LIOK\SQLEXPRESS";

            string database = "Dat";
       

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
