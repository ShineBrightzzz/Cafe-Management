using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class SaleInvoiceDetailService
    {
        private readonly SaleInvoiceDetailDAO detailDAO;

        public SaleInvoiceDetailService()
        {
            detailDAO = new SaleInvoiceDetailDAO();
        }

        public bool AddSaleInvoiceDetail(SaleInvoiceDetail detail)
        {
            try
            {
                ValidateDetail(detail);
                detailDAO.AddDetail(detail);
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

        public bool UpdateSaleInvoiceDetail(SaleInvoiceDetail detail)
        {
            try
            {
                ValidateDetail(detail);
                detailDAO.UpdateDetail(detail);
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

        public bool DeleteSaleInvoiceDetail(string invoiceId, string productId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(invoiceId) || string.IsNullOrWhiteSpace(productId))
                    throw new ArgumentException("Invoice ID and Product ID must be provided.");

                detailDAO.DeleteDetail(invoiceId, productId);
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

        public List<SaleInvoiceDetail> GetDetailsByInvoiceId(string invoiceId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(invoiceId))
                    throw new ArgumentException("Invoice ID must be provided.");

                return detailDAO.GetDetailsByInvoiceId(invoiceId);
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

        public List<SaleInvoiceDetail> GetAllSaleInvoiceDetails()
        {
            try
            {
                return detailDAO.GetAllDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving details: {ex.Message}");
                return null;
            }
        }

        private void ValidateDetail(SaleInvoiceDetail detail)
        {
            if (detail == null)
                throw new ArgumentException("Sale invoice detail must not be null.");

            if (string.IsNullOrWhiteSpace(detail.getInvoiceId()))
                throw new ArgumentException("Invoice ID is required.");

            if (string.IsNullOrWhiteSpace(detail.getProductId()))
                throw new ArgumentException("Product ID is required.");

            if (detail.getQuantity() <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (detail.getUnitPrice() < 0)
                throw new ArgumentException("Unit price must be non-negative.");

            if (detail.getDiscountPercent() < 0 || detail.getDiscountPercent() > 100)
                throw new ArgumentException("Discount percent must be between 0 and 100.");
        }
    }
}
