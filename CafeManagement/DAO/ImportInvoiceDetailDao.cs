using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Database;
using CafeManagement.Entities;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class ImportInvoiceDetailDao
    {
        public void AddImportInvoiceDetail(ImportInvoiceDetail importInvoiceDetail)
        {
            string sql = "INSERT INTO import_invoice_details (invoice_id, product_id, quantity, unit_price, discount, amount) VALUES (@id, @product, @quantity, @price, @discount, @amount)";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", importInvoiceDetail.getImportInvoiceId());
                    cmd.Parameters.AddWithValue("@product", importInvoiceDetail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", importInvoiceDetail.getQuantity());
                    cmd.Parameters.AddWithValue("@price", importInvoiceDetail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", importInvoiceDetail.getDiscount());
                    cmd.Parameters.AddWithValue("@amount", importInvoiceDetail.getTotalPrice());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddImportInvoiceDetail Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void UpdateImportInvoiceDetail(ImportInvoiceDetail detail)
        {
            string sql = "UPDATE import_invoice_details SET quantity = @quantity, unit_price = @price, discount = @discount, amount = @amount WHERE invoice_id = @invoiceId AND product_id = @productId";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", detail.getImportInvoiceId());
                    cmd.Parameters.AddWithValue("@productId", detail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", detail.getDiscount());
                    cmd.Parameters.AddWithValue("@amount", detail.getTotalPrice());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateImportInvoiceDetail Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DeleteImportInvoiceDetail(string invoiceId, string productId)
        {
            string sql = "DELETE FROM import_invoice_details WHERE invoice_id = @invoiceId AND product_id = @productId";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteImportInvoiceDetail Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public ImportInvoiceDetail GetImportInvoiceDetailById(string invoiceId, string productId)
        {
            string sql = "SELECT * FROM import_invoice_details WHERE invoice_id = @invoiceId AND product_id = @productId";
            SqlConnection conn = null;
            try
            {
                if (conn == null)
                    conn = DBConnect.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ImportInvoiceDetail(
                                reader["invoice_id"].ToString(),
                                reader["product_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount"]),
                                Convert.ToDouble(reader["amount"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetImportInvoiceDetailById Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        public List<ImportInvoiceDetail> GetAllImportInvoiceDetails()
        {
            List<ImportInvoiceDetail> details = new List<ImportInvoiceDetail>();
            string sql = "SELECT * FROM import_invoice_details";
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
                            details.Add(new ImportInvoiceDetail(
                                reader["invoice_id"].ToString(),
                                reader["product_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount"]),
                                Convert.ToDouble(reader["amount"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllImportInvoiceDetails Error: " + ex.Message);
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
