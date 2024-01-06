using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ql_TXM.Modify
{
    class connection
    {
        private static string stringConnection = @"Data Source=MSI\MSI;Initial Catalog=SQLXM;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
