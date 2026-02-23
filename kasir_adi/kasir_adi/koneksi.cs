using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kasir_adi
{
    class koneksi
    {
        public static MySqlConnection con = new MySqlConnection("Server=localhost;UID=root;PWD=;Database=kasir_resto");
    }
}
