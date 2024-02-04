using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy.provider
{
    public  class ConnectionProvider
    {
        public static IDbConnection GetConnection()
        {
            return new MySqlConnection("Server=localhost;database=bca_iii_test;Uid=root;Pwd=admin");
        }
    }
}
