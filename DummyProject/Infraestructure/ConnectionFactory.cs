using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using DummyProject.Domain;

namespace DummyProject.Infraestructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {

            _configuration = configuration;
        }


        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection sqlconnection = new();
                if (sqlconnection == null)
                {
                    return null;
                }

                sqlconnection.ConnectionString = _configuration.GetConnectionString(Constantes.DATABASE_NAME_CON);
                sqlconnection.Open();
                return sqlconnection;
        }
    }

    }
}
