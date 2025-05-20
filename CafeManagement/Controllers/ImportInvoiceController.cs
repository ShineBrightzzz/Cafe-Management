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

        public bool AddImportInvoice(DateTime dateOfImport, string employeeId, string supplierId, double totalAmount)
        {
            string invoiceId = Guid.NewGuid().ToString();
            var invoice = new ImportInvoice(invoiceId, dateOfImport, employeeId, supplierId, totalAmount);
            return importInvoiceService.AddImportInvoice(invoice);
        }

        public bool UpdateImportInvoice(string invoiceId, DateTime dateOfImport, string employeeId, string supplierId, double totalAmount)
        {
            var invoice = new ImportInvoice(invoiceId, dateOfImport, employeeId, supplierId, totalAmount);
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
