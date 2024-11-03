using System;
using System.Data.SqlClient;
using task_manager.Entities;
using System.Data.Common;
using System.Collections.Generic;
namespace task_manager.DAL
{
    public class WorkspaceDAL
    {
        private readonly DatabaseConnection databaseConnection;
        public WorkspaceDAL()
        {
            databaseConnection = new DatabaseConnection();
        }
        public void AddWorkspace(WorkspaceEnti workspaceEnti)
        {
            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = "INSERT INTO WORKSPACE (NAME, Description, CustomerId) VALUES (@Name, @Description, @CustomerId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", workspaceEnti.Name);
                    command.Parameters.AddWithValue("@Description", workspaceEnti.Description);
                    command.Parameters.AddWithValue("@CustomerId", workspaceEnti.CustomerID);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public List<WorkspaceEnti> GetAllWorkspace(int customerId)
        {
            var workspaces = new List<WorkspaceEnti>();
            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = "SELECT Name, CustomerID FROM Workspace WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số CustomerID
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var workspace = new WorkspaceEnti
                            {
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            };
                            workspaces.Add(workspace);
                        }
                    }
                }
            }
            return workspaces;
        }


    }
}
