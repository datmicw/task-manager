using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration.Ini;

namespace task_manager.DAL
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection()
        {
            connectionString = Program.Configuration["Settings:connectionString"];
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void OpenConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
