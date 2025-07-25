using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Models
{
    public class User
    {
        public int id;
        public string username = "";
        public string password = "";
        public string email = "";
        public string level = "";
        public int userlevel_id;
        public int is_active;
        public string createdAt = "";
    }
}
