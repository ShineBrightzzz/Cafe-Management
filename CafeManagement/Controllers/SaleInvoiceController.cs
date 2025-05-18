using System;
using System.Collections.Generic;
using CafeManagement.Entities;
using CafeManagement.Services;

namespace CafeManagement.Controllers
{
    public class SaleInvoiceController
    {
        private readonly SaleInvoiceService saleInvoiceService;

        public SaleInvoiceController()
        {
            saleInvoiceService = new SaleInvoiceService();
        }

        public bool AddSaleInvoice(string invoiceId, DateTime saleDate, string employeeId, string customerId, double totalAmount)
        {
            var invoice = new Sale_Invoice(invoiceId, saleDate, employeeId, customerId, totalAmount);
            return saleInvoiceService.AddSaleInvoice(invoice);
        }

        public bool UpdateSaleInvoice(string invoiceId, DateTime saleDate, string employeeId, string customerId, double totalAmount)
        {
            var invoice = new Sale_Invoice(invoiceId, saleDate, employeeId, customerId, totalAmount);
            return saleInvoiceService.UpdateSaleInvoice(invoice);
        }

        public bool DeleteSaleInvoice(string invoiceId)
        {
            return saleInvoiceService.DeleteSaleInvoice(invoiceId);
        }

        public Sale_Invoice GetSaleInvoiceById(string invoiceId)
        {
            return saleInvoiceService.GetSaleInvoiceById(invoiceId);
        }

        public List<Sale_Invoice> GetAllSaleInvoices()
        {
            return saleInvoiceService.GetAllSaleInvoices();
        }
    }
}
