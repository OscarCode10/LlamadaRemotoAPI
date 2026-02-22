using Dapper;
using MySqlConnector;
namespace LlamadaRemota.Repositories
{
    public class CreditosRepository : ICreditosRepository
    {
        private readonly MySqlConfiguration _mySqlConfiguration;

        public CreditosRepository(MySqlConfiguration mySqlConfiguration)
        {
            _mySqlConfiguration = mySqlConfiguration;
        }

        protected MySqlConnection DbConnection()
        {
            return new MySqlConnection(_mySqlConfiguration.ConnectionString);
        }

        public bool CreateCredito(CreditosRealizado creditosRealizado)
        {
            var db = DbConnection();

            var sql = @"INSERT INTO creditosRealizado
                (idCliente, idFondosCredito, fechaCredito, valorPrestado, noCuotas)
                VALUES
                (@IdCliente, @IdFondosCredito, @FechaCredito, @ValorPrestado, @NoCuotas)";

            var result = db.Execute(sql, creditosRealizado);

            return result > 0;
        }

    }
}
