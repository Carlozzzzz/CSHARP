using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDV1.Model
{
    public class Product
    {
        private int id;
        private int user_id;
        private string product;
        private int quantity;
        private DateTime created_at;
        private DateTime modified_at;

        public int Id { get => id; set => id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string ProductName { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Modified_at { get => modified_at; set => modified_at = value; }
    }
}
