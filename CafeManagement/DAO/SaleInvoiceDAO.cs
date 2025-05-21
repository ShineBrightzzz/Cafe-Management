using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement.DAO
{
    public class SaleInvoiceDAO
    {
        public bool AddInvoice(Sale_Invoice invoice)
        {            
            string sql = "INSERT INTO sale_invoices (id, sale_date, employee_id, customer_id, total_amount) " +
                         "VALUES (@id, @sale_date, @employee_id, @customer_id, @total_amount)";
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = DBConnect.GetConnection();
                if (conn == null)
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var invoiceId = invoice.getInvoiceId();
                var saleDate = invoice.getSaleDate();
                var employeeId = string.IsNullOrWhiteSpace(invoice.getEmployeeId()) ? DBNull.Value : (object)invoice.getEmployeeId();
                var customerId = string.IsNullOrWhiteSpace(invoice.getCustomerId()) ? DBNull.Value : (object)invoice.getCustomerId();
                var totalAmount = invoice.getTotalAmount();

                transaction = conn.BeginTransaction();

                using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", invoiceId);
                    cmd.Parameters.AddWithValue("@sale_date", saleDate);
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);
                    cmd.Parameters.AddWithValue("@customer_id", customerId);
                    cmd.Parameters.AddWithValue("@total_amount", totalAmount);

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
                string error = $"Lỗi khi thêm hóa đơn:\n{ex.Message}";
                if (ex.InnerException != null)
                {
                    error += $"\n\nLỗi chi tiết:\n{ex.InnerException.Message}";
                }
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool UpdateInvoice(Sale_Invoice invoice)
        {            string sql = "UPDATE sale_invoices SET sale_date = @sale_date, employee_id = @employee_id, " +
                         "customer_id = @customer_id, total_amount = @total_amount WHERE id = @id";
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
                    cmd.Parameters.AddWithValue("@id", invoice.getInvoiceId());
                    cmd.Parameters.AddWithValue("@sale_date", invoice.getSaleDate());
                    cmd.Parameters.AddWithValue("@employee_id", 
                        string.IsNullOrWhiteSpace(invoice.getEmployeeId()) ? DBNull.Value : (object)invoice.getEmployeeId());
                    cmd.Parameters.AddWithValue("@customer_id", 
                        string.IsNullOrWhiteSpace(invoice.getCustomerId()) ? DBNull.Value : (object)invoice.getCustomerId());
                    cmd.Parameters.AddWithValue("@total_amount", invoice.getTotalAmount());
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
                MessageBox.Show("UpdateInvoice Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool DeleteInvoice(string invoiceId)
        {
            string sql = "DELETE FROM sale_invoices WHERE id = @id";
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
                    cmd.Parameters.AddWithValue("@id", invoiceId);
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
                MessageBox.Show("DeleteInvoice Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public Sale_Invoice GetInvoiceById(string invoiceId)
        {
            string sql = "SELECT * FROM sale_invoices WHERE id = @id";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                  using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", invoiceId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Sale_Invoice(
                                reader["id"].ToString(),
                                Convert.ToDateTime(reader["sale_date"]),
                                reader["employee_id"].ToString(),
                                reader["customer_id"].ToString(),
                                Convert.ToDouble(reader["total_amount"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetInvoiceById Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        public List<Sale_Invoice> GetAllInvoices()
        {
            List<Sale_Invoice> saleInvoices = new List<Sale_Invoice>();
            string sql = "SELECT * FROM sale_invoices";
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
                            saleInvoices.Add(new Sale_Invoice(
                                reader["id"].ToString(),
                                Convert.ToDateTime(reader["sale_date"]),
                                reader["employee_id"].ToString(),
                                reader["customer_id"].ToString(),
                                Convert.ToDouble(reader["total_amount"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllInvoices Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return saleInvoices;
        }
    }
}
