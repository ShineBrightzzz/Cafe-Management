using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement.DAO
{
    public class CustomerDAO
    {
        public bool AddCustomer(Customer customer)
        {
            string sql = "INSERT INTO customers (id, name, phone) VALUES (@id, @name, @phone)";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customer.getId());
                    cmd.Parameters.AddWithValue("@name", customer.getName());
                    cmd.Parameters.AddWithValue("@phone", customer.getPhoneNumber());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            string sql = "UPDATE customers SET name = @name, phone = @phone WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customer.getId());
                    cmd.Parameters.AddWithValue("@name", customer.getName());
                    cmd.Parameters.AddWithValue("@phone", customer.getPhoneNumber());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool DeleteCustomer(string id)
        {
            string sql = "DELETE FROM customers WHERE id = @id";
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
                MessageBox.Show($"Lỗi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public Customer GetCustomerById(string id)
        {
            string sql = "SELECT * FROM customers WHERE id = @id";
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
                            return new Customer(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["phone"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM customers";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return customers;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["phone"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return customers;
        }

        public List<Customer> GetCustomerByName(string name)
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM customers WHERE name LIKE @name";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return customers;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["phone"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return customers;
        }
    }
}
