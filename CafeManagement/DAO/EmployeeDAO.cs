using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CafeManagement.Database;
using CafeManagement.Entities;

namespace CafeManagement.DAO
{
    public class EmployeeDAO
    {
        public bool AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO employees (id, name, address, gender, date_of_birth, phone) VALUES (@id, @name, @address, @gender, @dateOfBirth, @phone)";
            SqlConnection conn = null;
            MessageBox.Show("Adding employee...");
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.getId());
                    cmd.Parameters.AddWithValue("@name", employee.getName());
                    cmd.Parameters.AddWithValue("@address", employee.getAddress());
                    cmd.Parameters.AddWithValue("@gender", employee.getGender());
                    cmd.Parameters.AddWithValue("@dateOfBirth", employee.getDateOfBirth().Date);
                    cmd.Parameters.AddWithValue("@phone", employee.getPhoneNumber());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE employees SET name = @name, address = @address, gender = @gender, date_of_birth = @dateOfBirth, phone = @phone WHERE id = @id";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return false;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.getId());
                    cmd.Parameters.AddWithValue("@name", employee.getName());
                    cmd.Parameters.AddWithValue("@address", employee.getAddress());
                    cmd.Parameters.AddWithValue("@gender", employee.getGender());
                    cmd.Parameters.AddWithValue("@dateOfBirth", employee.getDateOfBirth().Date);
                    cmd.Parameters.AddWithValue("@phone", employee.getPhoneNumber());
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public bool DeleteEmployee(string id)
        {
            string sql = "DELETE FROM employees WHERE id = @id";
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
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }

        public Employee GetEmployee(string id)
        {
            string sql = "SELECT * FROM employees WHERE id = @id";
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
                            return new Employee(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["address"].ToString(),
                                reader["gender"].ToString(),
                                Convert.ToDateTime(reader["date_of_birth"]).Date,
                                reader["phone"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return null;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM employees";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return employees;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["address"].ToString(),
                                reader["gender"].ToString(),
                                Convert.ToDateTime(reader["date_of_birth"]).Date,
                                reader["phone"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return employees;
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM employees WHERE name LIKE @name";
            SqlConnection conn = null;
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null) return employees;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["address"].ToString(),
                                reader["gender"].ToString(),
                                Convert.ToDateTime(reader["date_of_birth"]).Date,
                                reader["phone"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            return employees;
        }
    }
}
