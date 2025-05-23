using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CafeManagement.Entities;
using CafeManagement.Database;
using System.Windows.Forms;

namespace CafeManagement.DAO
{
    public class IngredientDAO
    {        public List<Ingredient> GetAll()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            string sql = "SELECT * FROM ingredients";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return ingredients;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredients.Add(new Ingredient(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["unit"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }

            return ingredients;
        }        public Ingredient GetById(string ingredientId)
        {
            string sql = "SELECT * FROM ingredients WHERE id = @ingredientId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return null;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ingredientId", ingredientId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Ingredient(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["unit"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return null;
        }        public bool Add(Ingredient ingredient)
        {
            string sql = @"INSERT INTO ingredients (id, name, unit, quantity, unit_price) 
                          VALUES (@ingredientId, @name, @unit, @quantity, @unitPrice)";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ingredientId", ingredient.getIngredientId());
                    cmd.Parameters.AddWithValue("@name", ingredient.getName());
                    cmd.Parameters.AddWithValue("@unit", ingredient.getUnit());
                    cmd.Parameters.AddWithValue("@quantity", ingredient.getQuantity());
                    cmd.Parameters.AddWithValue("@unitPrice", ingredient.getUnitPrice());
                    
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }        public bool Update(Ingredient ingredient)
        {
            string sql = @"UPDATE ingredients 
                          SET name = @name, unit = @unit, quantity = @quantity, unit_price = @unitPrice 
                          WHERE id = @ingredientId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ingredientId", ingredient.getIngredientId());
                    cmd.Parameters.AddWithValue("@name", ingredient.getName());
                    cmd.Parameters.AddWithValue("@unit", ingredient.getUnit());
                    cmd.Parameters.AddWithValue("@quantity", ingredient.getQuantity());
                    cmd.Parameters.AddWithValue("@unitPrice", ingredient.getUnitPrice());
                    
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }        public bool Delete(string ingredientId)
        {
            string sql = "DELETE FROM ingredients WHERE id = @ingredientId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ingredientId", ingredientId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }
    }
}
