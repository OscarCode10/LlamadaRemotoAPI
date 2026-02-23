using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
                var dbName = db.QuerySingle<string>("SELECT DB_NAME()");
                Console.WriteLine($"Base actual: {dbName}");
                var server = db.QuerySingle<string>("SELECT @@SERVERNAME");
                Console.WriteLine($"Servidor: {server}");

                    var sql = @"INSERT INTO dbo.creditosRealizado
                            (idCliente, idFondosCredito, fechaCredito, valorPrestado, noCuotas)
                            VALUES
                            (@IdCliente, @IdFondosCredito, @FechaCredito, @ValorPrestado, @NoCuotas)";


                var result = db.Execute(sql, creditosRealizado);

                return result > 0;
            }
        }
    }
}