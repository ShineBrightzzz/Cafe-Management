using System.Collections.Generic;
using CafeManagement.Entities;
using CafeManagement.Services;

namespace CafeManagement.Controllers
{
    public class SaleInvoiceDetailController
    {
        private readonly SaleInvoiceDetailService saleInvoiceDetailService;

        public SaleInvoiceDetailController()
        {
            saleInvoiceDetailService = new SaleInvoiceDetailService();
        }

        public bool AddSaleInvoiceDetail(string invoiceId, string productId, int quantity, double unitPrice, double discountPercent)
        {
            var detail = new SaleInvoiceDetail(invoiceId, productId, quantity, unitPrice, discountPercent);
            return saleInvoiceDetailService.AddSaleInvoiceDetail(detail);
        }

        public bool UpdateSaleInvoiceDetail(string invoiceId, string productId, int quantity, double unitPrice, double discountPercent)
        {
            var detail = new SaleInvoiceDetail(invoiceId, productId, quantity, unitPrice, discountPercent);
            return saleInvoiceDetailService.UpdateSaleInvoiceDetail(detail);
        }

        public bool DeleteSaleInvoiceDetail(string invoiceId, string productId)
        {
            return saleInvoiceDetailService.DeleteSaleInvoiceDetail(invoiceId, productId);
        }

        public List<SaleInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            return saleInvoiceDetailService.GetDetailsByInvoiceId(invoiceId);
        }

        public List<SaleInvoiceDetail> GetAllSaleInvoiceDetails()
        {
            return saleInvoiceDetailService.GetAllSaleInvoiceDetails();
        }
    }
}
