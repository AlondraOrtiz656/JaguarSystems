using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarSystems.Data
{
    internal class Database
    {
        private string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=InventarioDB;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
