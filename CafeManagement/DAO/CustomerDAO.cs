using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class CustomerDAO
    {
        public void AddCustomer(Customer customer)
        {
            string sql = "INSERT INTO customers (id, name, phone) VALUES (@id, @name, @phone)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())  
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customer.getId());
                    cmd.Parameters.AddWithValue("@name", customer.getName());
                    cmd.Parameters.AddWithValue("@phone", customer.getPhoneNumber());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddCustomer Error: " + ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            string sql = "UPDATE customers SET name = @name, phone = @phone WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customer.getId());
                    cmd.Parameters.AddWithValue("@name", customer.getName());
                    cmd.Parameters.AddWithValue("@phone", customer.getPhoneNumber());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateCustomer Error: " + ex.Message);
            }
        }

        public void DeleteCustomer(string id)
        {
            string sql = "DELETE FROM customers WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteCustomer Error: " + ex.Message);
            }
        }

        public Customer GetCustomerById(string id)
        {
            string sql = "SELECT * FROM customers WHERE id = @id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
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
                Console.WriteLine("GetCustomerById Error: " + ex.Message);
            }
            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM customers";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
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
                Console.WriteLine("GetAllCustomers Error: " + ex.Message);
            }

            return customers;
        }

        public List<Customer> GetCustomerByName(string name)
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM customers WHERE name LIKE @name";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
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
                Console.WriteLine("GetCustomerByName Error: " + ex.Message);
            }

            return customers;
        }
    }
}
