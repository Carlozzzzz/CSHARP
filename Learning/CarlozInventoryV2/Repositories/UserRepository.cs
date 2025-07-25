using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            // create a list of client
            // oppen the connection
            // create a command
            // run the command with a reader
            // read the data
            // create an user object
            // add the user to the list

            List<User> users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = 
                        "SELECT " +
                        "u.id AS id, " +
                        "u.username AS username, " +
                        "u.email AS email, " +
                        "u.is_active AS status, " +
                        "u.created_at AS created_at, " +
                        "ul.id AS userlevel_id, " +
                        "ul.level AS user_level " +
                        "FROM UsersTbl u " +
                        "INNER JOIN UserLevelTbl ul ON u.userlevel_id = ul.id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.id = Convert.ToInt32(reader["id"]);
                                user.username = reader["username"].ToString();
                                user.email = reader["email"].ToString();
                                user.is_active = Convert.ToInt32(reader["status"]);
                                user.createdAt = reader["created_at"].ToString();
                                user.userlevel_id = Convert.ToInt32(reader["userlevel_id"]);
                                user.level = reader["user_level"].ToString();

                                users.Add(user);
                            }
                        }
                    }
                }
                return users;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error displaying Users: " + ex);
            }


            return null;
        }

        public User GetUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query =
                        "SELECT " +
                        "u.id AS id, " +
                        "u.username AS username, " +
                        "u.email AS email, " +
                        "u.is_active AS status, " +
                        "u.created_at AS created_at, " +
                        "ul.id AS userlevel_id, " +
                        "ul.level AS user_level " +
                        "FROM UsersTbl u " +
                        "INNER JOIN UserLevelTbl ul ON u.userlevel_id = ul.id " +
                        "WHERE u.id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.id = reader.GetInt32(0);
                                user.username = reader.GetString(1);
                                user.email = reader.GetString(2);
                                user.is_active = reader.GetBoolean(3) ? 1 : 0;
                                user.createdAt = reader.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss");
                                user.userlevel_id = reader.GetInt32(5);
                                user.level = reader.GetString(6);

                                return user;

                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting user: " + ex);
            }

            return null;
        }

        public void CreateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "INSERT INTO UsersTbl (username, password, email, userlevel_id, is_active) " +
                        "VALUES (@username, @password, @email, @userlevel_id, @is_active)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@password", user.password);
                        command.Parameters.AddWithValue("@email", user.email);
                        command.Parameters.AddWithValue("@userlevel_id", user.userlevel_id);
                        command.Parameters.AddWithValue("@is_active", user.is_active);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating user: " + ex);
            }

        }

        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                        UPDATE UsersTbl 
                        SET username = @username, 
                            email = @email, 
                            userlevel_id = @userlevel_id, 
                            is_active = @is_active 
                        WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", user.id);
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@email", user.email);
                        command.Parameters.AddWithValue("@userlevel_id", user.userlevel_id);
                        command.Parameters.AddWithValue("@is_active", user.is_active);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user: " + ex);
            }
        }
    
        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "DELETE FROM UsersTbl WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting user: " + ex);
            }
        }

    }

    
}
