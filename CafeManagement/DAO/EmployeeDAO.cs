using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Database;
using Microsoft.Data.SqlClient;
using CafeManagement.Database;
using CafeManagement.Entities;

namespace CafeManagement.DAO
{
    public class EmployeeDAO
    {
        public void AddEmployee(Employee employee)
        {
            string sql = "insert into employees (id, name, address, gender, dateOfBirth,phone) values (@id, @name, @address, @gender, @dateOfBirth, @phone)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.getId());
                        cmd.Parameters.AddWithValue("@name", employee.getName());
                        cmd.Parameters.AddWithValue("@address", employee.getAddress());
                        cmd.Parameters.AddWithValue("@gender", employee.getGender());
                        cmd.Parameters.AddWithValue("@dateOfBirth", employee.getDateOfBirth());
                        cmd.Parameters.AddWithValue("@phone", employee.getPhoneNumber());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("AddEmployee error: "+e.Message);
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            string sql = "update employees set name = @name, address = @address, gender =@gender, dateOfBirth = @dateOfBirth, phone =@phone where id = @id";
            try
            {
                using(SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.getId());
                        cmd.Parameters.AddWithValue("@name", employee.getName());
                        cmd.Parameters.AddWithValue("@address", employee.getAddress());
                        cmd.Parameters.AddWithValue("@gender", employee.getGender());
                        cmd.Parameters.AddWithValue("@dateOfBirth", employee.getDateOfBirth());
                        cmd.Parameters.AddWithValue("@phone", employee.getPhoneNumber());
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("UpdateEmployee error: " + e.Message);
            }
        }

        public void DeleteEmployee(String id)
        {
            string sql = "delete from employees where id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("DeleteEmployee error: " + e.Message);

            }
        }

        public Employee GetEmployee(String id)
        {
            string sql = "SELECT * FROM employees WHERE id = @id";
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
                                return new Employee(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["address"].ToString(),
                                    reader["gender"].ToString(),
                                    Convert.ToDateTime(reader["dateOfBirth"]),
                                    reader["phone"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetEmployeeById Error: " + ex.Message);
            }
            return null;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM employees";
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
                                employees.Add(new Employee(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["address"].ToString(),
                                    reader["gender"].ToString(),
                                    Convert.ToDateTime(reader["dateOfBirth"]),
                                    reader["phone"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllEmployees Error: " + ex.Message);
            }
            return employees;
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM employees WHERE name LIKE @name";
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
                                employees.Add(new Employee(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["address"].ToString(),
                                    reader["gender"].ToString(),
                                    Convert.ToDateTime(reader["dateOfBirth"]),
                                    reader["phone"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetEmployeesByName Error: " + ex.Message);
            }
            return employees;
        }
    }
}
