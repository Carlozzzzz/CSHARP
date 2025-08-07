using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDV1.Repository
{
    public static class Database
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=CRUDV1;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

        public static string GetConnectionString()
        {
            try
            {
                return connectionString;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error retrieving connection string:" + ex.Message);
                return string.Empty;
            }

        }
    }
}
