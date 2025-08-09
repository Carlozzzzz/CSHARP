using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDV1.Model
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private string userlevel;
        private int user_level;
        private DateTime created_at;
        private DateTime modified_at;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int User_level { get => user_level; set => user_level = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Modified_at { get => modified_at; set => modified_at = value; }
        public string Userlevel { get => userlevel; set => userlevel = value; }
    }
}
