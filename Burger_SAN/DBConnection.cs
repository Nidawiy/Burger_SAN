using MySql.Data.MySqlClient;

namespace Burger_SAN
{
    class DBConnection
    {
        private static string connectionString = "server=localhost;database=restaurant_reservation_db;uid=root;pwd=nidawiy2262";
        private MySqlConnection connection;

        public DBConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }

}
