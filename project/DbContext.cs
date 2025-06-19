using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ADP_Bakery
{
    public class DbContext
    {
        private static string host = "localhost";
        private static string database = "bakery";
        private static string username = "postgres";
        private static string password = "Wafiya";
        private static int port = 5432;
        public static NpgsqlConnection GetConnection()
        {
            string conn = $"Host={host};Port={port};Database={database};Username={username};Password={password};";
            return new NpgsqlConnection(conn);
        }
    }
}
