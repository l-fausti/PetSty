using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_sala_petshop
{
    public class Connection
    {
        string server = @"SUPER\SQLSERVERDEV";
        string db = "db_petsty";
        string user = "sa";
        string pass = "lucas123";
        string connect;
        public SqlConnection conn;

        public Connection()
        {
            try
            {
                connect = $"Data Source={server};Initial Catalog={db};User id={user};Password={pass};TrustServerCertificate=True";
                conn = new SqlConnection(connect);
             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar");

            }
        }
    }
}
