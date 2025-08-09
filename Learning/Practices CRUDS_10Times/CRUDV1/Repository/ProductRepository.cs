using CRUDV1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDV1.Repository
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM Products_Tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                product.Id = reader.GetInt32(0);
                                product.User_id = reader.GetInt32(1);
                                product.ProductName = reader.GetString(2);
                                product.Created_at = reader.GetDateTime(3);
                                product.Modified_at = reader.GetDateTime(4);
                                product.Quantity = reader.GetInt32(5);

                                products.Add(product);
                            }

                            return products;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error retrieving products : " + ex.Message,"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error retrieving products: " + ex.Message);
            }

            return null;
        }

        public Product GetProduct(int product_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM Products_Tbl WHERE id=@Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", product_id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Product product = new Product();
                                product.Id = reader.GetInt32(0);
                                product.User_id = reader.GetInt32(1);
                                product.ProductName = reader.GetString(2);
                                product.Created_at = reader.GetDateTime(3);
                                product.Modified_at = reader.GetDateTime(4);
                                product.Quantity = reader.GetInt32(5);

                                return product;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products : " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public bool CreateProduct(Product product)
        {
            HelperDebug.Log(product);
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "INSERT INTO Products_Tbl (user_id, product, quantity, created_at, modified_at)" +
                        "VALUES (@User_id, @ProductName, @Quantity, @Created_at, @Modified_at)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@User_id", product.User_id);
                        command.Parameters.AddWithValue("@ProductName", product.ProductName);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.Parameters.AddWithValue("@Created_at", product.Created_at);
                        command.Parameters.AddWithValue("@Modified_at", product.Modified_at);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Failed to create new product: " + ex.Message, "Validpublic static void Log(Product product)\r\n{\r\n    Console.WriteLine(\r\n        $\"ID: {product.Id}\\n\" +\r\n        $\"User ID: {product.User_id}\\n\" +\r\n        $\"Product Name: {product.ProductName}\\n\" +\r\n        $\"Quantity: {product.Quantity}\\n\" +\r\n        $\"Created_at: {product.Created_at}\\n\" +\r\n        $\"Modified_at: {product.Modified_at}\\n\"\r\n    );\r\n}ation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Failed to create new product: " + ex.Message);
            }
            return false;
        }

        public bool UpdateProduct(Product product)
        {
            HelperDebug.Log(product);
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query =
                         "UPDATE Products_Tbl " +
                         "SET user_id = @User_id, " +
                         "   product = @ProductName, " +
                         "   quantity = @Quantity, " +
                         "   modified_at = @Modified_at " +
                         "WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", product.Id);
                        command.Parameters.AddWithValue("@User_id", product.User_id);
                        command.Parameters.AddWithValue("@ProductName", product.ProductName);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.Parameters.AddWithValue("@Modified_at", product.Modified_at);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Failed to update new product: " + ex.Message, "Validpublic static void Log(Product product)\r\n{\r\n    Console.WriteLine(\r\n        $\"ID: {product.Id}\\n\" +\r\n        $\"User ID: {product.User_id}\\n\" +\r\n        $\"Product Name: {product.ProductName}\\n\" +\r\n        $\"Quantity: {product.Quantity}\\n\" +\r\n        $\"Created_at: {product.Created_at}\\n\" +\r\n        $\"Modified_at: {product.Modified_at}\\n\"\r\n    );\r\n}ation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Failed to update product: " + ex.Message);
            }
            return false;
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query =
                         "Delete FROM Products_Tbl " +
                         "WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", productId);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Failed to update new product: " + ex.Message, "Validpublic static void Log(Product product)\r\n{\r\n    Console.WriteLine(\r\n        $\"ID: {product.Id}\\n\" +\r\n        $\"User ID: {product.User_id}\\n\" +\r\n        $\"Product Name: {product.ProductName}\\n\" +\r\n        $\"Quantity: {product.Quantity}\\n\" +\r\n        $\"Created_at: {product.Created_at}\\n\" +\r\n        $\"Modified_at: {product.Modified_at}\\n\"\r\n    );\r\n}ation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Failed to Delete the product: " + ex.Message);
            }
            return false;
        }
    }
}
