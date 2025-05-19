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
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", product.getId());
                    cmd.Parameters.AddWithValue("@name", product.getName());
                    cmd.Parameters.AddWithValue("@type", product.getType());
                    cmd.Parameters.AddWithValue("@import_price", product.getImportPrice());
                    cmd.Parameters.AddWithValue("@sale_price", product.getSalePrice());
                    
                    // Xử lý image có thể null
                    if (string.IsNullOrEmpty(product.getImage()))
                        cmd.Parameters.AddWithValue("@image", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@image", product.getImage());

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding product: " + ex.Message);
                MessageBox.Show("Error adding product: " + ex.Message);
                throw; // Rethrow để Controller có thể xử lý
            }
            finally 
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void UpdateProduct(Product product)
        {
            string sql = "UPDATE products SET name = @name, type = @type, import_price = @import_price, " +
                         "sale_price = @sale_price, image = @image WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", product.getId());
                    cmd.Parameters.AddWithValue("@name", product.getName());
                    cmd.Parameters.AddWithValue("@type", product.getType());
                    cmd.Parameters.AddWithValue("@import_price", product.getImportPrice());
                    cmd.Parameters.AddWithValue("@sale_price", product.getSalePrice());
                    
                    // Xử lý image có thể null
                    if (string.IsNullOrEmpty(product.getImage()))
                        cmd.Parameters.AddWithValue("@image", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@image", product.getImage());

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật sản phẩm: " + ex.Message);
                throw; // Rethrow để Controller có thể xử lý
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DeleteProduct(string id)
        {
            string sql = "DELETE FROM products WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xoá sản phẩm: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public Product GetProductById(string id)
        {
            string sql = "SELECT * FROM products WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy sản phẩm theo ID: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string sql = "SELECT * FROM products";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách sản phẩm: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
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
