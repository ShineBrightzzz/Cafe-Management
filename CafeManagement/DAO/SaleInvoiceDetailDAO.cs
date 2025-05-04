using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class SaleInvoiceDetailDAO
    {
        public void AddDetail(SaleInvoiceDetail detail)
        {
            string sql = "INSERT INTO sale_invoice_details (invoice_id, product_id, quantity, unit_price, discount_percent, total) " +
                         "VALUES (@invoice_id, @product_id, @quantity, @unit_price, @discount_percent, @total)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", detail.getInvoiceId());
                    cmd.Parameters.AddWithValue("@product_id", detail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@unit_price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount_percent", detail.getDiscountPercent());
                    cmd.Parameters.AddWithValue("@total", detail.getTotal());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddDetail Error: " + ex.Message);
            }
        }


        public void UpdateDetail(SaleInvoiceDetail detail)
        {
            string sql = "UPDATE sale_invoice_details SET quantity = @quantity, unit_price = @unit_price, " +
                         "discount_percent = @discount_percent, total = @total " +
                         "WHERE invoice_id = @invoice_id AND product_id = @product_id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", detail.getInvoiceId());
                    cmd.Parameters.AddWithValue("@product_id", detail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@unit_price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount_percent", detail.getDiscountPercent());
                    cmd.Parameters.AddWithValue("@total", detail.getTotal());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateDetail Error: " + ex.Message);
            }
        }

        // Xoá chi tiết hóa đơn
        public void DeleteDetail(string invoiceId, string productId)
        {
            string sql = "DELETE FROM sale_invoice_details WHERE invoice_id = @invoice_id AND product_id = @product_id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", invoiceId);
                    cmd.Parameters.AddWithValue("@product_id", productId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteDetail Error: " + ex.Message);
            }
        }

        // Lấy chi tiết hóa đơn theo invoice_id
        public List<SaleInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            List<SaleInvoiceDetail> details = new List<SaleInvoiceDetail>();
            string sql = "SELECT * FROM sale_invoice_details WHERE invoice_id = @invoice_id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", invoiceId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new SaleInvoiceDetail(
                                reader["invoice_id"].ToString(),
                                reader["product_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount_percent"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetDetailsByInvoiceId Error: " + ex.Message);
            }
            return details;
        }

        // Lấy toàn bộ chi tiết của tất cả các hóa đơn
        public List<SaleInvoiceDetail> GetAllDetails()
        {
            List<SaleInvoiceDetail> details = new List<SaleInvoiceDetail>();
            string sql = "SELECT * FROM sale_invoice_details";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new SaleInvoiceDetail(
                                reader["invoice_id"].ToString(),
                                reader["product_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount_percent"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllDetails Error: " + ex.Message);
            }
            return details;
        }
    }
}
