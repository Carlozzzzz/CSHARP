using SimpleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Repositories
{
    public class ClientRepository
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=test1;Integrated Security=True;TrustServerCertificate=True";

        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            // fill data from db

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM clients order by id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.GetString(1);
                                client.lastName = reader.GetString(2);
                                client.email = reader.GetString(3);
                                client.phone = reader.GetString(4);
                                client.address = reader.GetString(5);
                                client.createdAt = reader.GetDateTime(6).ToString("yyyy-MM-dd HH:mm:ss");

                                clients.Add(client);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error client repository: " + ex.Message);
            }
            return clients;
        }

        public Client GetClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.GetString(1);
                                client.lastName = reader.GetString(2);
                                client.email = reader.GetString(3);
                                client.phone = reader.GetString(4);
                                client.address = reader.GetString(5);

                                return client;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return null;
        }

        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients (firstname, lastname, email, phone, address) VALUES " +
                                                         "(@firstName, @lastName, @email, @phone, @address)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", client.firstName);
                        command.Parameters.AddWithValue("@lastName", client.lastName);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error CREATE CLIENT: " + ex.Message);
            }
        }

        public void UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients " +
                                "SET firstname=@firstName, lastname=@lastName, " +
                                "email=@email, phone=@phone, address=@address " +
                                "WHERE id=@id";

                    // replace the parameters with value inside the object
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", client.firstName);
                        command.Parameters.AddWithValue("@lastname", client.lastName);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);
                        command.Parameters.AddWithValue("@id", client.id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE from clients WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);


            }
        }
    }
}

