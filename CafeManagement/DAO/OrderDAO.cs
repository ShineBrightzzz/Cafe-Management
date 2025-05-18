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
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddOrder Error: " + ex.Message);
            }
        }

        public void UpdateOrderStatus(string orderId, string status)
        {
            string sql = "UPDATE orders SET status = @status WHERE id = @orderId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateOrderStatus Error: " + ex.Message);
            }
        }

        public List<Order> GetOrdersByTableId(string tableId)
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM orders WHERE table_id = @tableId AND status = 'pending'";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetOrdersByTableId Error: " + ex.Message);
            }
            return orders;
        }

        public Order GetOrderById(string orderId)
        {
            string sql = "SELECT * FROM orders WHERE id = @orderId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetOrderById Error: " + ex.Message);
            }
            return null;
        }
    }
}
