using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoTpFedi
{
     class Connection
    {
        private static string connectionString = "Server=btssio.dedyn.io;port=3306;Database=ELMANOU_Ado;Uid=ELMANOU;password=17042003";
        private static MySqlConnection maConnection= new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection; set => maConnection = value; }
    }
}
