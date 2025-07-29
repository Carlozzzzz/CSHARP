using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlozInventoryV2.Repositories
{
    public class SupplierRepository
    {

        public List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = " SELECT * FROM SuppliersTbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Supplier supplier = new Supplier();
                                supplier.Id = reader.GetInt32(0);
                                supplier.SupplierName = reader.GetString(1);
                                supplier.Email = reader.GetString(2);
                                supplier.Phone = reader.GetString(3);
                                supplier.ModifiedAt = reader.GetDateTime(4);
                                supplier.CreatedAt = reader.GetDateTime(5);

                                suppliers.Add(supplier);
                            }
                        }
                    }

                }
                return suppliers;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while retrieving suppliers: {ex.Message}");
            }

            return null;
        }

        public Supplier GetSupplier(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM SuppliersTbl WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Supplier supplier = new Supplier();
                                supplier.Id = reader.GetInt32(0);
                                supplier.SupplierName = reader.GetString(1);
                                supplier.Email = reader.GetString(2);
                                supplier.Phone = reader.GetString(3);
                                supplier.IsActive = reader.GetBoolean(6);

                                return supplier;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while retrieving supplier with ID {id}: {ex.Message}");
            }
            return null; // This method is not implemented yet
        }

        public void CreateSupplier(Supplier supplier)
        {
            // this method is not implemented yet
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            INSERT INTO SuppliersTbl (supplier, email, mobilenumber, is_active, modified_at, created_at)
                            VALUES (@SupplierName, @Email, @Phone, @IsActive, @ModifiedAt, @CreatedAt)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                        command.Parameters.AddWithValue("@Email", supplier.Email);
                        command.Parameters.AddWithValue("@Phone", supplier.Phone);
                        command.Parameters.AddWithValue("@IsActive", supplier.IsActive);
                        command.Parameters.AddWithValue("@ModifiedAt", supplier.ModifiedAt);
                        command.Parameters.AddWithValue("@CreatedAt", supplier.CreatedAt);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while creating supplier: {ex.Message}");
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                            UPDATE SuppliersTbl 
                            SET supplier = @SupplierName, 
                                email = @Email, 
                                mobilenumber = @Phone, 
                                is_active = @IsActive, 
                                modified_at = @ModifiedAt
                            WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", supplier.Id);
                        command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                        command.Parameters.AddWithValue("@Email", supplier.Email);
                        command.Parameters.AddWithValue("@Phone", supplier.Phone);
                        command.Parameters.AddWithValue("@IsActive", supplier.IsActive);
                        command.Parameters.AddWithValue("@ModifiedAt", supplier.ModifiedAt);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while updating supplier: {ex.Message}");
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "DELETE FROM SuppliersTbl WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", supplierId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while deleting supplier with ID {supplierId}: {ex.Message}");
            }
        }
    }
}
