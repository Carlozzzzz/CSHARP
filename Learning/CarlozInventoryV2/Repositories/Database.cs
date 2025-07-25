using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
{
    public static class Database
    {
        private static readonly string connectionString = "Data Source = localhost; Initial Catalog = carlozinvertory; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";
        
        public static string GetConnectionString()
        {
            try
            {
                return connectionString;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving connection string: " + ex.Message);
                return string.Empty;
            }

        }
    }

}
