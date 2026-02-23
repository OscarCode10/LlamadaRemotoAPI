using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LlamadaRemota.Repositories
{
    public class CreditosRepository : ICreditosRepository
    {
        private readonly string _connectionString;

        public CreditosRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SqlServerConnection");
        }

        protected IDbConnection DbConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public bool CreateCredito(CreditosRealizado creditosRealizado)
        {
            using (var db = DbConnection())
            {
                var sql = @"INSERT INTO creditosRealizado
                            (idCliente, idFondosCredito, fechaCredito, valorPrestado, noCuotas)
                            VALUES
                            (@IdCliente, @IdFondosCredito, @FechaCredito, @ValorPrestado, @NoCuotas)";

                var result = db.Execute(sql, creditosRealizado);

                return result > 0;
            }
        }
    }
}