using System;
using System.Collections.Generic;
using CafeManagement.Entities;
using CafeManagement.Services;

namespace CafeManagement.Controllers
{
    public class ImportInvoiceDetailController
    {
        private readonly ImportInvoiceDetailService importInvoiceDetailService;

        public ImportInvoiceDetailController()
        {
            importInvoiceDetailService = new ImportInvoiceDetailService();
        }

        public bool AddImportInvoiceDetail(string importInvoiceId, string ingredientId, int quantity, double unitPrice, double discount)
        {
            double totalPrice = (quantity * unitPrice) * (1 - discount / 100);
            var detail = new ImportInvoiceDetail(importInvoiceId, ingredientId, quantity, unitPrice, discount, totalPrice);
            return importInvoiceDetailService.AddImportInvoiceDetail(detail);
        }

        public bool UpdateImportInvoiceDetail(string importInvoiceId, string ingredientId, int quantity, double unitPrice, double discount)
        {
            double totalPrice = (quantity * unitPrice) * (1 - discount / 100);
            var detail = new ImportInvoiceDetail(importInvoiceId, ingredientId, quantity, unitPrice, discount, totalPrice);
            return importInvoiceDetailService.UpdateImportInvoiceDetail(detail);
        }

        public bool DeleteImportInvoiceDetail(string importInvoiceId, string ingredientId)
        {
            return importInvoiceDetailService.DeleteImportInvoiceDetail(importInvoiceId, ingredientId);
        }

        public ImportInvoiceDetail GetImportInvoiceDetailById(string importInvoiceId, string ingredientId)
        {
            return importInvoiceDetailService.GetImportInvoiceDetailById(importInvoiceId, ingredientId);
        }

        public List<ImportInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            return importInvoiceDetailService.GetDetailsByInvoiceId(invoiceId);
        }

        public List<ImportInvoiceDetail> GetAllImportInvoiceDetails()
        {
            return importInvoiceDetailService.GetAllImportInvoiceDetails();
        }
    }
}
