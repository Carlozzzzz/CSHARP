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

        public UserLevel GetUserLevelByLevel(string level)
        {
            UserLevel userLevel = new UserLevel();

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 * FROM UserLevelTbl where level = @level ORDER BY id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@level", level);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userLevel.id = reader.GetInt32(0);
                                userLevel.level = reader.GetString(1);
                            }

                        }
                    }
                }
                return userLevel;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting User Level by level: " + ex);
            }

            return null;

        }

        public int GetUserLevelId(string level)
        {
            var userLevels = GetUserLevels();

            foreach (var userLevel in userLevels)
            {
                if (level == userLevel.level)
                    return (int)userLevel.id;
            }

            return 0;
        }
    }
}
