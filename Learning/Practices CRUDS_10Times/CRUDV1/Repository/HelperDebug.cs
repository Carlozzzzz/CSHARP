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
                                 $"ID: {(user.Id == 0 ? 0 : user.Id)}\n" +
                                 $"Username: {user.Username}\n" +
                                 $"Password: {user.Password}\n" +
                                 $"Email: {user.Email}\n" +
                                 $"User_level: {user.User_level}\n" +
                                 $"Created_at: {user.Created_at}\n"
                             );
        }

        public static void Log(Product product)
        {
            Console.WriteLine(
                //$"ID: {product.Id}\n" +
                $"User ID: {product.User_id}\n" +
                $"Product Name: {product.ProductName}\n" +
                $"Quantity: {product.Quantity}\n" +
                $"Created_at: {product.Created_at}\n" +
                $"Modified_at: {product.Modified_at}\n"
            );
        }
    }
}
