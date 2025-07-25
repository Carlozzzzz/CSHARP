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
                        "u.username AS username, " +
                        "u.email AS email, " +
                        "u.is_active AS status, " +
                        "u.created_at AS created_at, " +
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
                                user.username = reader["username"].ToString();
                                user.email = reader["email"].ToString();
                                user.status = Convert.ToInt32(reader["status"]);
                                user.createdAt = reader["created_at"].ToString();
                                user.userlevel_id = reader["user_level"].ToString();

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

    }

    
}
