using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Npgsql;
using System.Configuration;

namespace GISApplication
{
    public class PgSqlConnection
    {
        private static NpgsqlConnection sqlCon = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["PGSQL"].ConnectionString);
        public PgSqlConnection() { }
        public static void GetMeSomething()
        {
            sqlCon.Open();
        }
    }
}