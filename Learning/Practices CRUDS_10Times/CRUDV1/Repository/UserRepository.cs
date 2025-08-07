using CRUDV1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDV1.Repository
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users_Tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.Id = reader.GetInt32(0);
                                user.Username = reader.GetString(1);
                                user.Password = reader.GetString(2);
                                user.Email = reader.GetString(3);
                                user.User_level = reader.GetInt32(4);
                                user.Created_at = reader.GetDateTime(5);
                                user.Modified_at = reader.GetDateTime(6);

                                users.Add(user);
                            }

                            return users;
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the list of Users: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public User GetUser(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users_Tbl WHERE id = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.Id = reader.GetInt32(0);
                                user.Username = reader.GetString(1);
                                user.Password = reader.GetString(2);
                                user.Email = reader.GetString(3);
                                user.User_level = reader.GetInt32(4);
                                user.Created_at = reader.GetDateTime(5);
                                user.Modified_at = reader.GetDateTime(6);

                                return user;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the User: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }


        public bool CreateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "INSERT INTO Users_Tbl (username, password, email, user_level, created_at)" +
                        "VALUES (@Username, @Password, @Email, @User_Level, @Created_at)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Username);
                        command.Parameters.AddWithValue("@Email", user.Username);
                        command.Parameters.AddWithValue("@User_Level", user.User_level);
                        command.Parameters.AddWithValue("@Created_at", user.Created_at);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create new user: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public bool UpdateUser(User user)
        {
            HelperDebug.Log(user);

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "" +
                        "UPDATE Users_Tbl " +
                        "SET username = @Username, " +
                        "   password = @Password, " +
                        "   email = @Email, " +
                        "   user_level = @User_Level, " +
                        "   modified_at = @Modified_at " +
                        "WHERE id = @Id)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", user.Id);
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Username);
                        command.Parameters.AddWithValue("@Email", user.Username);
                        command.Parameters.AddWithValue("@User_Level", user.User_level);
                        command.Parameters.AddWithValue("@Modified_at", user.Modified_at);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update new user: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        
        internal void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
