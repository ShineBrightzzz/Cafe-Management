using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement.DAO
{
    public class AccountDAO
    {
        public bool AddAccount(Account account)
        {
            string sql = "INSERT INTO accounts (id, username, password, role) VALUES (@id, @username, @password, @role)";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", account.getId());
                    cmd.Parameters.AddWithValue("@username", account.getUsername());
                    cmd.Parameters.AddWithValue("@password", account.getPassword());
                    cmd.Parameters.AddWithValue("@role", account.getRole());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool UpdateAccount(Account account)
        {
            string sql = "UPDATE accounts SET username = @username, password = @password, role = @role WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", account.getId());
                    cmd.Parameters.AddWithValue("@username", account.getUsername());
                    cmd.Parameters.AddWithValue("@password", account.getPassword());
                    cmd.Parameters.AddWithValue("@role", account.getRole());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool DeleteAccount(Guid id)
        {
            string sql = "DELETE FROM accounts WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public Account GetAccountById(Guid id)
        {
            string sql = "SELECT * FROM accounts WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return null;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account(
                                Guid.Parse(reader["id"].ToString()),
                                reader["username"].ToString(),
                                reader["password"].ToString(),
                                reader["role"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return null;
        }

        public Account GetAccountByUsername(string username)
        {
            string sql = "SELECT * FROM accounts WHERE username = @username";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return null;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account(
                                Guid.Parse(reader["id"].ToString()),
                                reader["username"].ToString(),
                                reader["password"].ToString(),
                                reader["role"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return null;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            string sql = "SELECT * FROM accounts";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return accounts;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(new Account(
                                Guid.Parse(reader["id"].ToString()),
                                reader["username"].ToString(),
                                reader["password"].ToString(),
                                reader["role"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return accounts;
        }
    }
}
