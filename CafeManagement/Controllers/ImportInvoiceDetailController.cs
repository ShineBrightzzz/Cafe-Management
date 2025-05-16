using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Entities;
using CafeManagement.Services;

namespace CafeManagement.Controllers
{
    internal class ImportInvoiceDetailController
    {
        private readonly ImportInvoiceDetailService importInvoiceDetailService;

        public ImportInvoiceDetailController()
        {
            importInvoiceDetailService = new ImportInvoiceDetailService();
        }

        public bool AddImportInvoiceDetail(string importInvoiceId, string productId, int quantity, double unitPrice, double discount, double totalPrice)
        {
            var detail = new ImportInvoiceDetail(importInvoiceId, productId, quantity, unitPrice, discount, totalPrice);
            return importInvoiceDetailService.AddImportInvoiceDetail(detail);
        }

        public bool UpdateImportInvoiceDetail(string importInvoiceId, string productId, int quantity, double unitPrice, double discount, double totalPrice)
        {
            var detail = new ImportInvoiceDetail(importInvoiceId, productId, quantity, unitPrice, discount, totalPrice);
            return importInvoiceDetailService.UpdateImportInvoiceDetail(detail);
        }

        public bool DeleteImportInvoiceDetail(string importInvoiceId, string productId)
        {
            return importInvoiceDetailService.DeleteImportInvoiceDetail(importInvoiceId, productId);
        }

        public ImportInvoiceDetail GetImportInvoiceDetailsByInvoiceId(string importInvoiceId, string productId)
        {
            return importInvoiceDetailService.GetImportInvoiceDetailById(importInvoiceId, productId);
        }

        public List<ImportInvoiceDetail> GetAllImportInvoiceDetails()
        {
            return importInvoiceDetailService.GetAllImportInvoiceDetails();
        }
    }
}
