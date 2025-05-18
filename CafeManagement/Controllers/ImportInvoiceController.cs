using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Entities;
using CafeManagement.Services;

namespace CafeManagement.Controllers
{
    public class ImportInvoiceController
    {
        private readonly ImportInvoiceService importInvoiceService;

        public ImportInvoiceController()
        {
            importInvoiceService = new ImportInvoiceService();
        }

        public bool AddImportInvoice(string importInvoiceId, DateTime dateOfImport, string employeeId, string supplierId, double totalPrice)
        {
            var invoice = new ImportInvoice(importInvoiceId, dateOfImport, employeeId, supplierId, totalPrice);
            return importInvoiceService.AddImportInvoice(invoice);
        }

        public bool UpdateSaleInvoice(string importInvoiceId, DateTime dateOfImport, string employeeId, string supplierId, double totalPrice)
        {
            var invoice = new ImportInvoice(importInvoiceId, dateOfImport, employeeId, supplierId, totalPrice);
            return importInvoiceService.UpdateImportInvoice(invoice);
        }

        public bool DeleteImportInvoice(string invoiceId)
        {
            return importInvoiceService.DeleteImportInvoice(invoiceId);
        }

        public ImportInvoice GetImportInvoiceById(string invoiceId)
        {
            return importInvoiceService.GetImportInvoiceById(invoiceId);
        }

        public List<ImportInvoice> GetAllImportInvoices()
        {
            return importInvoiceService.GetAllImportInvoices();
        }
    }
}
