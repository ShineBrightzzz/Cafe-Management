using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CafeManagement.Entities;
using CafeManagement.Database;

namespace CafeManagement.DAO
{
    public class OrderDAO
    {
        public void AddOrder(Order order)
        {
            string sql = "INSERT INTO orders (id, table_id, status, order_date) VALUES (@id, @tableId, @status, @orderDate)";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", order.getId());
                    cmd.Parameters.AddWithValue("@tableId", order.getTableId());
                    cmd.Parameters.AddWithValue("@status", order.getStatus());
                    cmd.Parameters.AddWithValue("@orderDate", order.getOrderDate());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddOrder Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void UpdateOrderStatus(string orderId, string status)
        {
            string sql = "UPDATE orders SET status = @status WHERE id = @orderId";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateOrderStatus Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public List<Order> GetOrdersByTableId(string tableId)
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM orders WHERE table_id = @tableId AND status = 'pending'";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tableId", tableId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new Order(
                                reader["id"].ToString(),
                                reader["table_id"].ToString(),
                                reader["status"].ToString(),
                                Convert.ToDateTime(reader["order_date"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetOrdersByTableId Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return orders;
        }

        public Order GetOrderById(string orderId)
        {
            string sql = "SELECT * FROM orders WHERE id = @orderId";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Order(
                                reader["id"].ToString(),
                                reader["table_id"].ToString(),
                                reader["status"].ToString(),
                                Convert.ToDateTime(reader["order_date"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetOrderById Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        public bool DeleteOrder(string orderId)
        {
            string sql = "DELETE FROM orders WHERE id = @orderId";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                // First delete all related order details
                using (SqlCommand cmdDetails = new SqlCommand("DELETE FROM order_details WHERE order_id = @orderId", conn))
                {
                    cmdDetails.Parameters.AddWithValue("@orderId", orderId);
                    cmdDetails.ExecuteNonQuery();
                }

                // Then delete the order
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteOrder Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
