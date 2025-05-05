using CafeManagement.Entities;
using CafeManagement.Database;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CafeManagement.DAO
{
    public class SaleInvoiceDAO
    {
        public void AddInvoice(Sale_Invoice invoice)
        {
            string sql = "INSERT INTO sale_invoices (invoice_id, sale_date, employee_id, customer_id, total_amount) " +
                         "VALUES (@invoice_id, @sale_date, @employee_id, @customer_id, @total_amount)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", invoice.getInvoiceId());
                    cmd.Parameters.AddWithValue("@sale_date", invoice.getSaleDate());
                    cmd.Parameters.AddWithValue("@employee_id", invoice.getEmployeeId());
                    cmd.Parameters.AddWithValue("@customer_id", invoice.getCustomerId());
                    cmd.Parameters.AddWithValue("@total_amount", invoice.getTotalAmount());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddInvoice Error: " + ex.Message);
            }
        }

        public void UpdateInvoice(Sale_Invoice invoice)
        {
            string sql = "UPDATE sale_invoices SET sale_date = @sale_date, employee_id = @employee_id, " +
                         "customer_id = @customer_id, total_amount = @total_amount WHERE invoice_id = @invoice_id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", invoice.getInvoiceId());
                    cmd.Parameters.AddWithValue("@sale_date", invoice.getSaleDate());
                    cmd.Parameters.AddWithValue("@employee_id", invoice.getEmployeeId());
                    cmd.Parameters.AddWithValue("@customer_id", invoice.getCustomerId());
                    cmd.Parameters.AddWithValue("@total_amount", invoice.getTotalAmount());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateInvoice Error: " + ex.Message);
            }
        }

        public void DeleteInvoice(string invoiceId)
        {
            string sql = "DELETE FROM sale_invoices WHERE invoice_id = @invoice_id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", invoiceId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteInvoice Error: " + ex.Message);
            }
        }

        public Sale_Invoice GetInvoiceById(string invoiceId)
        {
            string sql = "SELECT * FROM sale_invoices WHERE invoice_id = @invoice_id";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoice_id", invoiceId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Sale_Invoice(
                                reader["invoice_id"].ToString(),
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
                Console.WriteLine("GetInvoiceById Error: " + ex.Message);
            }
            return null;
        }

        public List<Sale_Invoice> GetAllInvoices()
        {
            List<Sale_Invoice> saleInvoices = new List<Sale_Invoice>();
            string sql = "SELECT * FROM sale_invoices";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            saleInvoices.Add(new Sale_Invoice(
                                reader["invoice_id"].ToString(),
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
                Console.WriteLine("GetAllInvoices Error: " + ex.Message);
            }

            return saleInvoices;
        }
    }
}
