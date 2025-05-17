using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class TableDAO
    {        public void AddTable(Table table)
        {
            string sql = "INSERT INTO tables (id, name, is_occupied) VALUES (@id, @name, @is_occupied)";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    Console.WriteLine("AddTable error: Failed to get database connection");
                    return;
                }
                
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", table.getId());
                    cmd.Parameters.AddWithValue("@name", table.getName());
                    cmd.Parameters.AddWithValue("@is_occupied", table.getIsOccupied());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddTable error: " + ex.Message);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }        public void UpdateTable(Table table)
        {
            string sql = "UPDATE tables SET name = @name, is_occupied = @is_occupied WHERE id = @id";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    Console.WriteLine("UpdateTable error: Failed to get database connection");
                    return;
                }
                
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", table.getId());
                    cmd.Parameters.AddWithValue("@name", table.getName());
                    cmd.Parameters.AddWithValue("@is_occupied", table.getIsOccupied());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateTable error: " + ex.Message);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }        public void DeleteTable(string id)
        {
            string sql = "DELETE FROM tables WHERE id = @id";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    Console.WriteLine("DeleteTable error: Failed to get database connection");
                    return;
                }
                
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteTable error: " + ex.Message);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
        }public Table GetTableById(string id)
        {
            string sql = "SELECT * FROM tables WHERE id = @id";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    Console.WriteLine("GetTableById error: Failed to get database connection");
                    return null;
                }
                
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Table(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                Convert.ToBoolean(reader["is_occupied"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetTableById error: " + ex.Message);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            
            return null;
        }public List<Table> GetAllTables()
        {
            List<Table> tables = new List<Table>();
            string sql = "SELECT * FROM tables";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    Console.WriteLine("GetAllTables error: Failed to get database connection");
                    return tables;
                }
                
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Add(new Table(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                Convert.ToBoolean(reader["is_occupied"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllTables error: " + ex.Message);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            
            Console.WriteLine("GetAllTables: " + tables.Count);
            return tables;
        }        public List<Table> GetTablesByOccupationStatus(bool isOccupied)
        {
            List<Table> tables = new List<Table>();
            string sql = "SELECT * FROM tables WHERE is_occupied = @is_occupied";
            SqlConnection conn = null;
            
            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    Console.WriteLine("GetTablesByOccupationStatus error: Failed to get database connection");
                    return tables;
                }
                
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@is_occupied", isOccupied);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Add(new Table(
                                reader["id"].ToString(),
                                reader["name"].ToString(),
                                Convert.ToBoolean(reader["is_occupied"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetTablesByOccupationStatus error: " + ex.Message);
            }
            finally
            {
                DBConnect.CloseConnection(conn);
            }
            
            return tables;
        }
    }
}
