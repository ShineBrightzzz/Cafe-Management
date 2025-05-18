//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CafeManagement.Database;
//using CafeManagement.Entities;
//using Microsoft.Data.SqlClient;

//namespace CafeManagement.DAO
//{
//    public class ImportInvoiceDao
//    {
//        public void AddImportInvoice(ImportInvoice importInvoice)
//        {
//            string sql = "INSERT INTO import_invoices (id, import_date, employee_id, supplier_id, total_amount) VALUES (@id, @date, @employee, @supplier,@total)";
//            try
//            {
//                using (SqlConnection conn = DBConnect.GetConnection())
//                using (SqlCommand cmd = new SqlCommand(sql, conn))
//                {
//                    cmd.Parameters.AddWithValue("@id", importInvoice.getImportInvoiceId());
//                    cmd.Parameters.AddWithValue("@date", importInvoice.getDateOfImport());
//                    cmd.Parameters.AddWithValue("@employee", importInvoice.getEmployeeId());
//                    cmd.Parameters.AddWithValue("@supplier", importInvoice.getSupplierId());
//                    cmd.Parameters.AddWithValue("@total", importInvoice.getImportTotalPrice());
//                    cmd.ExecuteNonQuery();
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("AddImportInvoice Error: " + ex.Message);
//            }
//        }

//        //sửa thông tin hóa đơn nhập
//        public void UpdateImportInvoice(ImportInvoice importInvoice)
//        {
//            string sql = "UPDATE import_invoices SET import_date = @date,  employee_id = @employee, supplier_id = @supplier, total_amount = @total WHERE id = @id";
//            try
//            {
//                using (SqlConnection conn = DBConnect.GetConnection())
//                using (SqlCommand cmd = new SqlCommand(sql, conn))
//                {
//                    cmd.Parameters.AddWithValue("@id", importInvoice.getImportInvoiceId());
//                    cmd.Parameters.AddWithValue("@date", importInvoice.getDateOfImport());
//                    cmd.Parameters.AddWithValue("@employee", importInvoice.getEmployeeId());
//                    cmd.Parameters.AddWithValue("@supplier", importInvoice.getSupplierId());
//                    cmd.Parameters.AddWithValue("@total", importInvoice.getImportTotalPrice());
//                    cmd.ExecuteNonQuery();
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("UpdateImportInvoice Error: " + ex.Message);
//            }
//        }

//        public void DeleteImportInvoice(string id)
//        {
//            string sql = "DELETE FROM import_invoices WHERE id = @id";
//            try
//            {
//                using (SqlConnection conn = DBConnect.GetConnection())
//                using (SqlCommand cmd = new SqlCommand(sql, conn))
//                {
//                    cmd.Parameters.AddWithValue("@id", id);
//                    cmd.ExecuteNonQuery();
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("DeleteImportInvoice Error: " + ex.Message);
//            }
//        }

//        public ImportInvoice GetImportInvoiceById(string id)
//        {
//            string sql = "SELECT * FROM import_invoices WHERE id = @id";
//            try
//            {
//                using (SqlConnection conn = DBConnect.GetConnection())
//                using (SqlCommand cmd = new SqlCommand(sql, conn))
//                {
//                    cmd.Parameters.AddWithValue("@id", id);
//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            return new ImportInvoice(
//                                reader["id"].ToString(),
//                                Convert.ToDateTime(reader["import_date"]),
//                                reader["emplyee_id"].ToString(),
//                                reader["emplyee_id"].ToString(),
//                                Convert.ToDouble(reader["total_amount"])

//                            );
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("GetImportInvoiceById Error: " + ex.Message);
//            }
//            return null;
//        }

//        public List<ImportInvoice> GetAllImportInvoice()
//        {
//            List<ImportInvoice> importInvoices = new List<ImportInvoice>();
//            string sql = "SELECT * FROM import_invoices";
//            try
//            {
//                using (SqlConnection conn = DBConnect.GetConnection())
//                using (SqlCommand cmd = new SqlCommand(sql, conn))
//                {
//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            importInvoices.Add(new ImportInvoice(
//                                reader["id"].ToString(),
//                                Convert.ToDateTime(reader["import_date"]),
//                                reader["emplyee_id"].ToString(),
//                                reader["emplyee_id"].ToString(),
//                                Convert.ToDouble(reader["total_amount"])
//                            ));
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("GetAllCustomers Error: " + ex.Message);
//            }

//            return importInvoices;
//        }

//        public List<ImportInvoice> GetImportInvoicesByDate(DateTime date)
//        {
//            List<ImportInvoice> importInvoices = new List<ImportInvoice>();
//            string sql = "SELECT * FROM import_invoices WHERE import_date = @date";

//            try
//            {
//                using (SqlConnection conn = DBConnect.GetConnection())
//                using (SqlCommand cmd = new SqlCommand(sql, conn))
//                {
//                    cmd.Parameters.AddWithValue("@date", date);
//                    conn.Open();

//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            importInvoices.Add(new ImportInvoice(
//                                reader["id"].ToString(),
//                                Convert.ToDateTime(reader["import_date"]),
//                                reader["employee_id"].ToString(),
//                                reader["supplier_id"].ToString(),
//                                Convert.ToDouble(reader["total_amount"])
//                            ));
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("GetImportInvoicesByDate Error: " + ex.Message);
//            }

//            return importInvoices;
//        }
//    }
//}
