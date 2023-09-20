using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CLIENTES_WF.Repositorio
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;

        public DbConexao()
        {
            string connectionString = "Server=localhost;Database=cadastro_cliente;Trusted_Connection=True;TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);


        }

        public IDbConnection GetConnection()
        {
            if(connection.State != ConnectionState.Open)
            
                connection.Open();
                       
                return connection;
            
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
