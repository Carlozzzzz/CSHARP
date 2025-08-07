using CRUDV1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDV1.Repository
{
    public static class HelperDebug
    {
        public static void Log(User user)
        {
            Console.WriteLine(
                                 $"Username: {user.Username}\n" +
                                 $"Password: {user.Password}\n" +
                                 $"Email: {user.Email}\n" +
                                 $"User_level: {user.User_level}\n" +
                                 $"Created_at: {user.Created_at}\n"
                             );
        }
    }
}
