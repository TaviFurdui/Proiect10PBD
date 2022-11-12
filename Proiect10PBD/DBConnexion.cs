using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect10PBD
{
    class DBConnexion
    {
        public static MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=pbd;Uid=root;Pwd=;");
    }
}
