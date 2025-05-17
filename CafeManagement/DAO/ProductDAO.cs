using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class ProductDAO
    {
        public void AddProduct(Product product)
        {
            string sql = "INSERT INTO products (id, name, type, import_price, sale_price, image) " +
                         "VALUES (@id, @name, @type, @import_price, @sale_price, @image)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", product.getId());
                        cmd.Parameters.AddWithValue("@name", product.getName());
                        cmd.Parameters.AddWithValue("@type", product.getType());
                        cmd.Parameters.AddWithValue("@import_price", product.getImportPrice());
                        cmd.Parameters.AddWithValue("@sale_price", product.getSalePrice());
                        cmd.Parameters.AddWithValue("@image", product.getImage());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding product: " + ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            string sql = "UPDATE products SET name = @name, type = @type, import_price = @import_price, " +
                         "sale_price = @sale_price, image = @image WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", product.getId());
                        cmd.Parameters.AddWithValue("@name", product.getName());
                        cmd.Parameters.AddWithValue("@type", product.getType());
                        cmd.Parameters.AddWithValue("@import_price", product.getImportPrice());
                        cmd.Parameters.AddWithValue("@sale_price", product.getSalePrice());
                        cmd.Parameters.AddWithValue("@image", product.getImage());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật sản phẩm: " + ex.Message);
            }
        }

        public void DeleteProduct(string id)
        {
            string sql = "DELETE FROM products WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xoá sản phẩm: " + ex.Message);
            }
        }

        public Product GetProductById(string id)
        {
            string sql = "SELECT * FROM products WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapReaderToProduct(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy sản phẩm theo ID: " + ex.Message);
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string sql = "SELECT * FROM products";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(MapReaderToProduct(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách sản phẩm: " + ex.Message);
            }

            return products;
        }

        private Product MapReaderToProduct(SqlDataReader reader)
        {
            return new Product(
                reader["id"].ToString(),
                reader["name"].ToString(),
                reader["type"].ToString(),
                Convert.ToDouble(reader["import_price"]),
                Convert.ToDouble(reader["sale_price"]),
                reader["image"].ToString()
            );
        }
    }
}
