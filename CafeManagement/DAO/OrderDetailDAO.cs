using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CafeManagement.Entities;
using CafeManagement.Database;

namespace CafeManagement.DAO
{
    public class OrderDetailDAO
    {
        public void AddOrderDetail(OrderDetail detail)
        {
            string sql = "INSERT INTO order_details (order_id, product_id, quantity, unit_price, amount) VALUES (@orderId, @productId, @quantity, @unitPrice, @amount)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", detail.getOrderId());
                        cmd.Parameters.AddWithValue("@productId", detail.getProductId());
                        cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                        cmd.Parameters.AddWithValue("@unitPrice", detail.getUnitPrice());
                        cmd.Parameters.AddWithValue("@amount", detail.getAmount());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddOrderDetail Error: " + ex.Message);
            }
        }

        public void DeleteOrderDetail(string orderId, string productId)
        {
            string sql = "DELETE FROM order_details WHERE order_id = @orderId AND product_id = @productId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteOrderDetail Error: " + ex.Message);
            }
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(string orderId)
        {
            List<OrderDetail> details = new List<OrderDetail>();
            string sql = "SELECT * FROM order_details WHERE order_id = @orderId";
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
                            while (reader.Read())
                            {
                                details.Add(new OrderDetail(
                                    reader["order_id"].ToString(),
                                    reader["product_id"].ToString(),
                                    Convert.ToInt32(reader["quantity"]),
                                    Convert.ToDecimal(reader["unit_price"]),
                                    Convert.ToDecimal(reader["amount"])
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetOrderDetailsByOrderId Error: " + ex.Message);
            }
            return details;
        }
        
        public void UpdateOrderDetailQuantity(string orderId, string productId, int quantity, decimal amount)
        {
            string sql = "UPDATE order_details SET quantity = @quantity, amount = @amount WHERE order_id = @orderId AND product_id = @productId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateOrderDetailQuantity Error: " + ex.Message);
            }
        }
    }
}
