using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class ProductTypeDAO
    {
        public void AddProductType(ProductType type)
        {
            string sql = "INSERT INTO product_types (id, name) VALUES (@id, @name)";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", type.getId());
                    cmd.Parameters.AddWithValue("@name", type.getName());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm loại sản phẩm: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void UpdateProductType(ProductType type)
        {
            string sql = "UPDATE product_types SET name = @name WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", type.getId());
                    cmd.Parameters.AddWithValue("@name", type.getName());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật loại sản phẩm: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DeleteProductType(string id)
        {
            string sql = "DELETE FROM product_types WHERE id = @id";
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
                Console.WriteLine("Lỗi xoá loại sản phẩm: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public ProductType GetProductTypeById(string id)
        {
            string sql = "SELECT * FROM product_types WHERE id = @id";
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
                            return new ProductType(
                                reader["id"].ToString(),
                                reader["name"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy loại sản phẩm theo ID: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        public List<ProductType> GetAllProductTypes()
        {
            List<ProductType> list = new List<ProductType>();
            string sql = "SELECT * FROM product_types";
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
                            list.Add(new ProductType(
                                reader["id"].ToString(),
                                reader["name"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách loại sản phẩm: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return list;
        }

    }
}
