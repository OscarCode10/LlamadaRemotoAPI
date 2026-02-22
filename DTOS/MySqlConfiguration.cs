using MySql.Data.MySqlClient;
namespace LlamadaRemota.Repositories
{
    public class MySqlConfiguration
    {
        public string ConnectionString { get; set; }
        public MySqlConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
