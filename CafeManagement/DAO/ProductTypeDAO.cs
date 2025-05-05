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
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", type.getId());
                        cmd.Parameters.AddWithValue("@name", type.getName());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm loại sản phẩm: " + ex.Message);
            }
        }

        public void UpdateProductType(ProductType type)
        {
            string sql = "UPDATE product_types SET name = @name WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", type.getId());
                        cmd.Parameters.AddWithValue("@name", type.getName());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật loại sản phẩm: " + ex.Message);
            }
        }

        public void DeleteProductType(string id)
        {
            string sql = "DELETE FROM product_types WHERE id = @id";
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
                Console.WriteLine("Lỗi xoá loại sản phẩm: " + ex.Message);
            }
        }

        public ProductType GetProductTypeById(string id)
        {
            string sql = "SELECT * FROM product_types WHERE id = @id";
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
                                return new ProductType(
                                    reader["id"].ToString(),
                                    reader["name"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy loại sản phẩm theo ID: " + ex.Message);
            }
            return null;
        }

        public List<ProductType> GetAllProductTypes()
        {
            List<ProductType> list = new List<ProductType>();
            string sql = "SELECT * FROM product_types";
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
                                list.Add(new ProductType(
                                    reader["id"].ToString(),
                                    reader["name"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách loại sản phẩm: " + ex.Message);
            }

            return list;
        }

        public List<ProductType> GetProductTypesByName(string name)
        {
            List<ProductType> list = new List<ProductType>();
            string sql = "SELECT * FROM product_types WHERE name LIKE @name";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tìm kiếm loại sản phẩm: " + ex.Message);
            }

            return list;
        }
    }
}
