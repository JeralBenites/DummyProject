using System.Data;

namespace DummyProject.Infraestructure
{
    public interface IConnectionFactory
    {
        IDbConnection GetSqlConnection { get; }
    }
}
