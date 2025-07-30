using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
{
    public class LoginRepository
    {
        public bool LoginUser(string username, string password)
        {
            // This method should contain the logic to authenticate a user.
            // It would typically involve checking the provided username and password
            // against stored credentials in a database or other storage.
            // For now, we will just print the credentials to the console.
            Console.WriteLine($"Username: {username}, Password: {password}");

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            SELECT u.id, u.username, u.email, ul.level
                            FROM UsersTbl u
                            INNER JOIN UserLevelTbl ul ON u.userlevel_id = ul.id
                            WHERE u.username = @username AND u.password = @password ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // User found, proceed with login
                                // assign the session for the current loggged in user
                                User user = new User();
                                user.id = reader.GetInt32(0);
                                user.username = reader.GetString(1);
                                user.email = reader.GetString(2);
                                user.level = reader.GetString(3);

                                Session.Setuser(user);

                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during login: " + ex.Message);
            }
            return false;
        }

        public void LogoutUser()
        {
            // This method should contain the logic to log out a user.
            // It would typically involve clearing the session or authentication token.
            // For now, we will just print a message to the console.
            Console.WriteLine("User logged out successfully.");

            Console.WriteLine("Logging out user with ID: " + Session.UserId);

            Session.ClearSession(); // Assuming Session.Clear() clears the current user session
        }
    }
}
