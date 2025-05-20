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
        public Account GetAccountByUserName(string username)
        {
            Account account = null;
            string sql = "SELECT * FROM accounts WHERE username = @username";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                if (conn == null) return account;

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username); 

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                account = new Account(
                                    reader["account_id"].ToString(),
                                    reader["employee_id"].ToString(),
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
                    MessageBox.Show($"Lỗi tìm kiếm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            return account;
        }

        public bool CreateAccount(Account account)
        { 
            String sql = @"INSERT INTO accounts (account_id, employee_id, username, password, role)
                             VALUES (@id, @employee_id, @username, @password, @role)";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", account.getId());
                    cmd.Parameters.AddWithValue("@employee_id", account.getEmployeeId());
                    cmd.Parameters.AddWithValue("@username", account.getUsername());
                    cmd.Parameters.AddWithValue("@password", account.getPassword());
                    cmd.Parameters.AddWithValue("@role", account.getRole());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        // Kiểm tra employeeId đã có tài khoản chưa, có rồi thì cho cook
        public bool IsEmployeeIdRegistered(string employeeId)
        {
            string sql = "SELECT COUNT(*) FROM accounts WHERE employee_id = @employee_id";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Kiểm tra employeeId có tồn tại trong bảng employees không
        public bool IsEmployeeIdExist(string employeeId)
        {
            string sql = "SELECT COUNT(*) FROM employees WHERE id = @employee_id";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


    }
}
