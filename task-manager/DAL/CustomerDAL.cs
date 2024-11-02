using System;
using System.Data.SqlClient;
using task_manager.Entities;
using System.Data.Common;

namespace task_manager.DAL
{
    public class CustomerDAL
    {
        private readonly DatabaseConnection databaseConnection;
        public CustomerDAL()
        {
            databaseConnection = new DatabaseConnection();
        }
        public void AddCustomer(CustomerEnti customer)
        {
            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = "INSERT INTO CUSTOMER (NAME, EMAIL, PASSWORD) VALUES (@Name, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@Password", customer.Password);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public CustomerEnti GetCustomerByEmail(string email)
        {
            CustomerEnti customer = null;
            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = "SELECT EMAIL, PASSWORD FROM CUSTOMER WHERE EMAIL = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new CustomerEnti
                            {
                                Email = reader["EMAIL"].ToString(),
                                Password = reader["PASSWORD"].ToString()
                            };
                        }
                    }
                }
            }
            return customer;
        }
    }
}
