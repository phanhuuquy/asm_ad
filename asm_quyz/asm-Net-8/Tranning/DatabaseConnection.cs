using Microsoft.Data.SqlClient;

namespace Tranning
{
    public class DatabaseConnection
    {
        public DatabaseConnection() { }

        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=Quyz\\QUYZ;Initial Catalog=Tranning;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
