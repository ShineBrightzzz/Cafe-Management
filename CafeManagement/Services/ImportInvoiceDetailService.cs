using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class ImportInvoiceDetailService
    {
        private readonly ImportInvoiceDetailDao importInvoiceDetailDao;

        public ImportInvoiceDetailService()
        {
            importInvoiceDetailDao = new ImportInvoiceDetailDao();
        }

        public bool AddImportInvoiceDetail(ImportInvoiceDetail detail)
        {
            try
            {
                ValidateImportInvoiceDetail(detail);
                importInvoiceDetailDao.AddImportInvoiceDetail(detail);
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

        public bool UpdateImportInvoiceDetail(ImportInvoiceDetail detail)
        {
            try
            {
                ValidateImportInvoiceDetail(detail);
                importInvoiceDetailDao.UpdateImportInvoiceDetail(detail);
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

        public bool DeleteImportInvoiceDetail(string invoiceId, string ingredientId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(invoiceId) || string.IsNullOrWhiteSpace(ingredientId))
                    throw new ArgumentException("Invoice ID and Ingredient ID must be provided.");

                importInvoiceDetailDao.DeleteImportInvoiceDetail(invoiceId, ingredientId);
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

        public ImportInvoiceDetail GetImportInvoiceDetailById(string importInvoiceId, string ingredientId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(importInvoiceId) || string.IsNullOrWhiteSpace(ingredientId))
                    throw new ArgumentException("Invoice ID and Ingredient ID must be provided.");

                return importInvoiceDetailDao.GetImportInvoiceDetailById(importInvoiceId, ingredientId);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public List<ImportInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(invoiceId))
                    throw new ArgumentException("Invoice ID must be provided.");

                return importInvoiceDetailDao.GetDetailsByInvoiceId(invoiceId);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                return new List<ImportInvoiceDetail>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return new List<ImportInvoiceDetail>();
            }
        }

        public List<ImportInvoiceDetail> GetAllImportInvoiceDetails()
        {
            return importInvoiceDetailDao.GetAllImportInvoiceDetails();
        }

        private void ValidateImportInvoiceDetail(ImportInvoiceDetail detail)
        {
            if (detail == null)
                throw new ArgumentException("Import invoice detail must not be null.");

            if (string.IsNullOrWhiteSpace(detail.getImportInvoiceId()))
                throw new ArgumentException("Invoice ID is required.");

            if (string.IsNullOrWhiteSpace(detail.getIngredientId()))
                throw new ArgumentException("Ingredient ID is required.");

            if (detail.getQuantity() <= 0)
                throw new ArgumentException("Quantity must be greater than 0.");

            if (detail.getUnitPrice() < 0)
                throw new ArgumentException("Unit Price must be non-negative.");

            if (detail.getTotalPrice() < 0)
                throw new ArgumentException("Total Price must be non-negative.");
        }
    }
}
