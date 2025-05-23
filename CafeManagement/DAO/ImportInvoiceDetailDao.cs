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
            string sql = "INSERT INTO import_invoice_details (invoice_id, ingredient_id, quantity, unit_price, discount, total_price) VALUES (@id, @product, @quantity, @price, @discount, @total_price)";
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
                    cmd.Parameters.AddWithValue("@product", importInvoiceDetail.getIngredientId());
                    cmd.Parameters.AddWithValue("@quantity", importInvoiceDetail.getQuantity());
                    cmd.Parameters.AddWithValue("@price", importInvoiceDetail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", importInvoiceDetail.getDiscount());
                    cmd.Parameters.AddWithValue("@total_price", importInvoiceDetail.getTotalPrice());
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
            string sql = "UPDATE import_invoice_details SET quantity = @quantity, unit_price = @price, discount = @discount, total_price = @total_price WHERE invoice_id = @invoiceId AND ingredient_id = @productId";
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
                    cmd.Parameters.AddWithValue("@productId", detail.getIngredientId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", detail.getDiscount());
                    cmd.Parameters.AddWithValue("@total_price", detail.getTotalPrice());
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
            string sql = "DELETE FROM import_invoice_details WHERE invoice_id = @invoiceId AND ingredient_id = @productId";
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

        public List<ImportInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            List<ImportInvoiceDetail> details = new List<ImportInvoiceDetail>();
            string sql = "SELECT * FROM import_invoice_details WHERE invoice_id = @invoiceId";
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
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new ImportInvoiceDetail(
                                reader["invoice_id"].ToString(),
                                reader["ingredient_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount"]),
                                Convert.ToDouble(reader["total_price"])
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

        public ImportInvoiceDetail GetImportInvoiceDetailById(string invoiceId, string productId)
        {
            string sql = "SELECT * FROM import_invoice_details WHERE invoice_id = @invoiceId AND ingredient_id = @productId";
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
                                reader["ingredient_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount"]),
                                Convert.ToDouble(reader["total_price"])
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
                                reader["ingredient_id"].ToString(),
                                Convert.ToInt32(reader["quantity"]),
                                Convert.ToDouble(reader["unit_price"]),
                                Convert.ToDouble(reader["discount"]),
                                Convert.ToDouble(reader["total_price"])
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
