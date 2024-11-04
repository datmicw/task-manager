using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using task_manager.Entities;

namespace task_manager.DAL
{
    public class TaskDAL
    {
        private readonly DatabaseConnection databaseConnection;

        public TaskDAL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void AddTask(TaskEnti taskEnti)
        {
            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = "INSERT INTO TASK (WORKSPACE_ID, CUSTOMER_ID, TITLE, STATUS) VALUES (@WORKSPACE_ID, @CUSTOMER_ID, @TITLE, 'Pending')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng WorkspaceID thay vì Id cho WORKSPACE_ID
                    command.Parameters.AddWithValue("@WORKSPACE_ID", taskEnti.WorkspaceId);
                    command.Parameters.AddWithValue("@CUSTOMER_ID", taskEnti.CustomerId);
                    command.Parameters.AddWithValue("@TITLE", taskEnti.Title);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<string> GetTaskTitles(int customerId, int workspaceId)
        {
            var taskTitles = new List<string>();

            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = "SELECT TITLE FROM Task WHERE CUSTOMER_ID = @CustomerID AND WORKSPACE_ID = @WorkspaceID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@WorkspaceID", workspaceId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taskTitles.Add(reader.GetString(reader.GetOrdinal("TITLE")));
                        }
                    }
                }
            }

            return taskTitles;
        }

    }
}
