using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Repositories
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
                    string query = @"
                        SELECT 
                            p.id as Id,
                            p.supplier_id as SupplierId,
                            s.supplier as SupplierName,
                            p.product as ProductName,
                            p.description as Description,
                            p.quantity as Quantity,
                            p.is_active as IsActive,
                            p.modified_at as ModifiedAt,
                            p.created_at as CreatedAt
                        FROM ProductsTbl p
                        INNER JOIN SuppliersTbl s 
                            ON p.supplier_id = s.id";
                        
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    Id = reader.GetInt32(0),
                                    SupplierId = reader.GetInt32(1),
                                    SupplierName = reader.GetString(2),
                                    ProductName = reader.GetString(3),
                                    Description = reader.GetString(4),
                                    Quantity = reader.GetInt32(5),
                                    IsActive = reader.GetBoolean(6),
                                    ModifiedAt = reader.GetDateTime(7),
                                    CreatedAt = reader.GetDateTime(8)
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while retrieving products: {ex.Message}");
            }
            return null;
        }

        public Product GetProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query =
                        "SELECT " +
                        "   p.id AS Id, " +
                        "   p.supplier_id AS SupplierId, " +
                        "   s.supplier AS SupplierName, " +
                        "   p.product AS ProductName, " +
                        "   p.description AS Description, " +
                        "   p.quantity AS Quantity, " +
                        "   p.is_active AS IsActive " +
                        "FROM ProductsTbl p " +
                        "INNER JOIN SuppliersTbl s " +  // ← added space
                        "ON p.supplier_id = s.id " +
                        "WHERE p.id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", productId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Product product = new Product();
                                product.Id = reader.GetInt32(0);
                                product.SupplierId = reader.GetInt32(1);
                                product.SupplierName = reader.GetString(2);
                                product.ProductName = reader.GetString(3);
                                product.Description = reader.GetString(4);
                                product.Quantity = reader.GetInt32(5);
                                product.IsActive = reader.GetBoolean(6);

                                return product;
                            }

                        }

                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Error retrieving product : "+ ex.Message); }

            return null;
        }

        public void CreateProduct(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            INSERT INTO ProductsTbl (supplier_id, product, description, quantity, is_active, modified_at, created_at)
                            VALUES (@SupplierId, @ProductName, @Description, @Quantity, @IsActive, @ModifiedAt, @CreatedAt)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                        command.Parameters.AddWithValue("@ProductName", product.ProductName);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.Parameters.AddWithValue("@IsActive", product.IsActive);
                        command.Parameters.AddWithValue("@ModifiedAt", product.ModifiedAt);
                        command.Parameters.AddWithValue("@CreatedAt", product.CreatedAt);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating product: " + ex);
            }

        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            UPDATE ProductsTbl 
                            SET 
                                supplier_id = @SupplierId,
                                product = @ProductName,
                                description = @Description,
                                quantity = @Quantity,
                                is_active = @IsActive,
                                modified_at = @ModifiedAt
                            WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", product.Id);
                        command.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                        command.Parameters.AddWithValue("@ProductName", product.ProductName);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.Parameters.AddWithValue("@IsActive", product.IsActive);
                        command.Parameters.AddWithValue("@ModifiedAt", product.ModifiedAt);

                        Console.WriteLine(product.Id + product.ProductName);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating product: " + ex.Message);
            }
        }

        public void DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "DELETE FROM ProductsTbl WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", productId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while deleting product with ID {productId}: {ex.Message}");
            }
        }
    }
}
