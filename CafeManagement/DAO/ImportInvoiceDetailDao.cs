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
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
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
        }


        public void UpdateImportInvoiceDetail(ImportInvoiceDetail detail)
        {
            string sql = "UPDATE import_invoice_details SET quantity = @quantity, unit_price = @price, discount = @discount, amount = @amount WHERE invoice_id = @invoiceId AND product_id = @productId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", detail.getImportInvoiceId());
                    cmd.Parameters.AddWithValue("@productId", detail.getProductId());
                    cmd.Parameters.AddWithValue("@quantity", detail.getQuantity());
                    cmd.Parameters.AddWithValue("@price", detail.getUnitPrice());
                    cmd.Parameters.AddWithValue("@discount", detail.getDiscount());
                    cmd.Parameters.AddWithValue("@amount", detail.getTotalPrice());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateImportInvoiceDetail Error: " + ex.Message);
            }
        }

        // Xóa chi tiết hóa đơn nhập theo mã hóa đơn và sản phẩm
        public void DeleteImportInvoiceDetail(string invoiceId, string productId)
        {
            string sql = "DELETE FROM import_invoice_details WHERE invoice_id = @invoiceId AND product_id = @productId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteImportInvoiceDetail Error: " + ex.Message);
            }
        }

        // Lấy chi tiết hóa đơn nhập theo mã hóa đơn và sản phẩm
        public ImportInvoiceDetail GetImportInvoiceDetailById(string invoiceId, string productId)
        {
            string sql = "SELECT * FROM import_invoice_details WHERE invoice_id = @invoiceId AND product_id = @productId";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    conn.Open();

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
            return null;
        }

        public List<ImportInvoiceDetail> GetAllImportInvoiceDetails()
        {
            List<ImportInvoiceDetail> details = new List<ImportInvoiceDetail>();
            string sql = "SELECT * FROM import_invoice_details";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
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
            return details;
        }

    }
}
