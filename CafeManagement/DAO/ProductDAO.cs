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
            string sql = "INSERT INTO products (id, name, type_id, import_price, sale_price, quantity, image) " +
                         "VALUES (@id, @name, @type_id, @import_price, @sale_price, @quantity, @image)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", product.getId());
                        cmd.Parameters.AddWithValue("@name", product.getName());
                        cmd.Parameters.AddWithValue("@type_id", product.getTypeId());
                        cmd.Parameters.AddWithValue("@import_price", product.getImportPrice());
                        cmd.Parameters.AddWithValue("@sale_price", product.getSalePrice());
                        cmd.Parameters.AddWithValue("@quantity", product.getQuantity());
                        cmd.Parameters.AddWithValue("@image", product.getImage());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            string sql = "UPDATE products SET name = @name, type_id = @type_id, import_price = @import_price, " +
                         "sale_price = @sale_price, quantity = @quantity, image = @image WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", product.getId());
                        cmd.Parameters.AddWithValue("@name", product.getName());
                        cmd.Parameters.AddWithValue("@type_id", product.getTypeId());
                        cmd.Parameters.AddWithValue("@import_price", product.getImportPrice());
                        cmd.Parameters.AddWithValue("@sale_price", product.getSalePrice());
                        cmd.Parameters.AddWithValue("@quantity", product.getQuantity());
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
                reader["type_id"].ToString(),
                Convert.ToDouble(reader["import_price"]),
                Convert.ToDouble(reader["sale_price"]),
                Convert.ToInt32(reader["quantity"]),
                reader["image"].ToString()
            );
        }
    }
}
