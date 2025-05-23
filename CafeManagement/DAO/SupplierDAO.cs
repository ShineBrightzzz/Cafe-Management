using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CafeManagement.Database;
using CafeManagement.Entities;
using System.Windows.Forms;

namespace CafeManagement.DAO
{
    public class SupplierDAO
    {
        public bool AddSupplier(Supplier supplier)
        {
            string sql = "INSERT INTO suppliers (id, name, phone, address) VALUES (@id, @name, @phone, @address)";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplier.getId());
                    cmd.Parameters.AddWithValue("@name", supplier.getName());
                    cmd.Parameters.AddWithValue("@phone", supplier.getPhoneNumber());
                    cmd.Parameters.AddWithValue("@address", supplier.getAddress());
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddSupplier Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            string sql = "UPDATE suppliers SET name = @name, phone = @phone, address = @address WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplier.getId());
                    cmd.Parameters.AddWithValue("@name", supplier.getName());
                    cmd.Parameters.AddWithValue("@phone", supplier.getPhoneNumber());
                    cmd.Parameters.AddWithValue("@address", supplier.getAddress());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateSupplier Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool DeleteSupplier(string id)
        {
            string sql = "DELETE FROM suppliers WHERE id = @id";
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
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteSupplier Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public Supplier GetSupplierById(string id)
        {
            string sql = "SELECT * FROM suppliers WHERE id = @id";
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
                            return new Supplier(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["phone"].ToString(),
                                reader["address"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetSupplierById Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            string sql = "SELECT * FROM suppliers";
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
                            suppliers.Add(new Supplier(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                reader["phone"].ToString(),
                                reader["address"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllSuppliers Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return suppliers;
        }
    }
}
