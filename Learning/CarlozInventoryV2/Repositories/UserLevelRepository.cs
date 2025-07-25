using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
{
    public class UserLevelRepository
    {
        public List<UserLevel> GetUserLevels()
        {
            // create a list of client
            // oppen the connection
            // create a command
            // run the command with a reader
            // read the data
            // create an user object
            // add the user to the list

            List<UserLevel> userLevels = new List<UserLevel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query =
                        "SELECT * FROM UserLevelTbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserLevel userLevel = new UserLevel();
                                userLevel.id = reader.GetInt32(0);
                                userLevel.level = reader.GetString(1);

                                userLevels.Add(userLevel);
                            }
                        }
                    }
                }
                return userLevels;
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error displaying User Levels: " + ex);
            }


            return null;
        }

    }
}
