using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CafeManagement.Entities;
using CafeManagement.Database;
using System.Windows.Forms;

namespace CafeManagement.DAO
{
    public class RecipeDAO
    {
        public List<Recipe> GetAll()
        {
            List<Recipe> recipes = new List<Recipe>();
            string sql = "SELECT * FROM recipes";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return recipes;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            recipes.Add(new Recipe(
                                reader["recipe_id"].ToString(),
                                reader["product_id"].ToString(),
                                reader["ingredient_id"].ToString(),
                                Convert.ToDouble(reader["amount"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách công thức: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }

            return recipes;
        }

        public List<Recipe> GetByProductId(string productId)
        {
            List<Recipe> recipes = new List<Recipe>();
            string sql = "SELECT * FROM recipes WHERE product_id = @productId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return recipes;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            recipes.Add(new Recipe(
                                reader["recipe_id"].ToString(),
                                reader["product_id"].ToString(),
                                reader["ingredient_id"].ToString(),
                                Convert.ToDouble(reader["amount"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy công thức sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }

            return recipes;
        }

        public Recipe GetById(string recipeId)
        {
            string sql = "SELECT * FROM recipes WHERE recipe_id = @recipeId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return null;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@recipeId", recipeId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Recipe(
                                reader["recipe_id"].ToString(),
                                reader["product_id"].ToString(),
                                reader["ingredient_id"].ToString(),
                                Convert.ToDouble(reader["amount"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm công thức: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }

            return null;
        }

        public bool Add(Recipe recipe)
        {
            string sql = @"INSERT INTO recipes (recipe_id, product_id, ingredient_id, amount) 
                          VALUES (@recipeId, @productId, @ingredientId, @amount)";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@recipeId", recipe.getRecipeId());
                    cmd.Parameters.AddWithValue("@productId", recipe.getProductId());
                    cmd.Parameters.AddWithValue("@ingredientId", recipe.getIngredientId());
                    cmd.Parameters.AddWithValue("@amount", recipe.getAmount());
                    
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm công thức: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool Update(Recipe recipe)
        {
            string sql = @"UPDATE recipes 
                          SET product_id = @productId, ingredient_id = @ingredientId, amount = @amount 
                          WHERE recipe_id = @recipeId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@recipeId", recipe.getRecipeId());
                    cmd.Parameters.AddWithValue("@productId", recipe.getProductId());
                    cmd.Parameters.AddWithValue("@ingredientId", recipe.getIngredientId());
                    cmd.Parameters.AddWithValue("@amount", recipe.getAmount());
                    
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật công thức: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool Delete(string recipeId)
        {
            string sql = "DELETE FROM recipes WHERE recipe_id = @recipeId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@recipeId", recipeId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa công thức: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool DeleteByProduct(string productId)
        {
            string sql = "DELETE FROM recipes WHERE product_id = @productId";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa công thức của sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }
    }
}
