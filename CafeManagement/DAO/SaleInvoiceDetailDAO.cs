using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class SaleInvoiceDetailDAO
    {        public bool AddDetail(SaleInvoiceDetail detail)
        {
            string sql = "INSERT INTO sale_invoice_details (invoice_id, product_id, quantity, unit_price, discount) " +
                         "VALUES (@invoice_id, @product_id, @quantity, @unit_price, @discount)";
            SqlConnection conn = null;
            SqlTransaction transaction = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                transaction = conn.BeginTransaction();
                
                using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", detail.getInvoiceId());
                    cmd.Parameters.AddWithValue("@product_id", detail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@unit_price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", detail.getDiscountPercent());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddDetail Error: " + ex.Message);
                if (transaction != null)
                    transaction.Rollback();
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void UpdateDetail(SaleInvoiceDetail detail)
        {
            string sql = "UPDATE sale_invoice_details SET quantity = @quantity, unit_price = @unit_price, " +
                         "discount = @discount" +
                         "WHERE invoice_id = @invoice_id AND product_id = @product_id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", detail.getInvoiceId());
                    cmd.Parameters.AddWithValue("@product_id", detail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@unit_price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", detail.getDiscountPercent());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateDetail Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DeleteDetail(string invoiceId, string productId)
        {
            string sql = "DELETE FROM sale_invoice_details WHERE invoice_id = @invoice_id AND product_id = @product_id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
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
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public List<SaleInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            List<SaleInvoiceDetail> details = new List<SaleInvoiceDetail>();
            string sql = "SELECT * FROM sale_invoice_details WHERE invoice_id = @invoice_id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
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
                                Convert.ToDouble(reader["discount"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetDetailsByInvoiceId Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return details;
        }

        public List<SaleInvoiceDetail> GetAllDetails()
        {
            List<SaleInvoiceDetail> details = new List<SaleInvoiceDetail>();
            string sql = "SELECT * FROM sale_invoice_details";
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
                            details.Add(new SaleInvoiceDetail(
                                reader["invoice_id"].ToString(),
                                reader["product_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllDetails Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return details;
        }
    }
}
