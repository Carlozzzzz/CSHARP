using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Models
{
    public static class Session
    {
        public static string SessionName;
        public static string Name;
        public static string Username;
        public static string Level;

        public static void Setuser(User user)
        {
            if (user != null)
            {
                SessionName = "CarlozInventoryV2";
                Username = user.username;
                Level = user.level;
            }
            else
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }
        }

        public static void ClearSession()
        {
            SessionName = null;
            Username = null;
            Level = null;
        }
    }
}
