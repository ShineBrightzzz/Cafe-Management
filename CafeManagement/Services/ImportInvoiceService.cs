using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class ImportInvoiceService
    {
        private ImportInvoiceDao importInvoiceDao;

        public ImportInvoiceService()
        {
            importInvoiceDao = new ImportInvoiceDao();
        }

        public void ValidateImportInvoice(ImportInvoice importInvoice)
        {
            //Null toàn bộ thì báo lỗi
            if (importInvoice == null)
            {
                throw new ArgumentNullException("Import Invoice must not be null");
            }

            //Chỉ null 1 thuộc tính
            if (string.IsNullOrWhiteSpace(importInvoice.getImportInvoiceId()))
            {
                throw new ArgumentNullException("Import invoice ID is required");
            }
            if (importInvoice.getDateOfImport() == default)
            {
                throw new ArgumentNullException("Date of import invoice is required");
            }
            if (string.IsNullOrWhiteSpace(importInvoice.getEmployeeId()))
            {
                throw new ArgumentNullException("Employee ID is required");
            }
            if (string.IsNullOrWhiteSpace(importInvoice.getSupplierId()))
            {
                throw new ArgumentNullException("Supplier ID is required");
            }
            //Total nhập số âm
            if (importInvoice.getImportTotalPrice() < 0)
            {
                throw new ArgumentNullException("Total amount must be non negative");
            }
        }

        public bool AddImportInvoice(ImportInvoice importInvoice)
        {
            try
            {
                //Chuẩn hóa đối tượng truyền vào
                ValidateImportInvoice(importInvoice);

                //Mã hóa đơn đã tồn tại thì không cho thêm
                if (importInvoiceDao.GetImportInvoiceById(importInvoice.getImportInvoiceId()) != null)
                {
                    Console.WriteLine("Import invoice ID already exists.");
                    return false;
                }

                //Không lỗi thì thực hiện Dao thêm hóa đơn nhập
                importInvoiceDao.AddImportInvoice(importInvoice);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public bool UpdateImportInvoice(ImportInvoice importInvoice)
        {
            try
            {
                ValidateImportInvoice(importInvoice);

                if (importInvoiceDao.GetImportInvoiceById(importInvoice.getImportInvoiceId()) == null)
                {
                    Console.WriteLine("Import invoice not found.");
                    return false;
                }

                importInvoiceDao.UpdateImportInvoice(importInvoice);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public bool DeleteImportInvoice(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                    throw new ArgumentException("Import invoice ID must be provided.");

                if (importInvoiceDao.GetImportInvoiceById(id) == null)
                {
                    Console.WriteLine("Import invoice not found.");
                    return false;
                }

                importInvoiceDao.DeleteImportInvoice(id);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public ImportInvoice GetImportInvoiceById(string id)
        {
            return importInvoiceDao.GetImportInvoiceById(id);
        }

        public List<ImportInvoice> GetAllImportInvoices()
        {
            return importInvoiceDao.GetAllImportInvoice();
        }
    }
}
