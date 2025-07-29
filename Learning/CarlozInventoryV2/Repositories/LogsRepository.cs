using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
{
    public class LogsRepository
    {
        public List<Log> GetLogs()
        {
            List<Log> logs = new List<Log>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            SELECT 
                                l.id AS Id, 
                                u.username AS Username, 
                                ul.level AS Level, 
                                l.action AS Action, 
                                l.created_at AS ModificationTime
                            FROM LogsTbl l  
                            INNER JOIN UsersTbl u ON l.user_id = u.id       
                            INNER JOIN UserLevelTbl ul ON u.userlevel_id = ul.id
                        ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Log log = new Log();
                                log.Id = Convert.ToInt32(reader["Id"]);
                                log.Username = reader["Username"].ToString();
                                log.Level = reader["Level"].ToString();
                                log.Action = reader["Action"].ToString();
                                log.ModificationTime = Convert.ToDateTime(reader["ModificationTime"]);

                                logs.Add(log);
                            }
                        }
                    }
                }
                return logs;
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return null;
        }

        public void CreateLog(Log Log)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            INSERT INTO LogsTbl (user_id, action)
                            VALUES (@user_id, @action)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", Log.UserId);
                        command.Parameters.AddWithValue("@action", Log.Action);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                Console.WriteLine("An error occurred while creating log: " + ex.Message);
            }
        }
    }
}
