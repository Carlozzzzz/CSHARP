using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
{
    public static class LogRepo
    {
        public static void CreateLog(string action)
        {
            try
            {
                var log = new Log();
                log.UserId = Session.UserId;
                log.Action = action;

                var logRepo = new LogRepository();
                logRepo.CreateLog(log);
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                Console.WriteLine("An error occurred while creating a log: " + ex.Message);
            }
        }
    }
}
