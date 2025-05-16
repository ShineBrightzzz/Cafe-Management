using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class SaleInvoiceService
    {
        private readonly SaleInvoiceDAO saleInvoiceDAO;

        public SaleInvoiceService()
        {
            saleInvoiceDAO = new SaleInvoiceDAO();
        }

        public bool AddSaleInvoice(Sale_Invoice invoice)
        {
            try
            {
                ValidateSaleInvoice(invoice);

                if (saleInvoiceDAO.GetInvoiceById(invoice.getInvoiceId()) != null)
                {
                    Console.WriteLine("Sale invoice ID already exists.");
                    return false;
                }

                saleInvoiceDAO.AddInvoice(invoice);
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

        public bool UpdateSaleInvoice(Sale_Invoice invoice)
        {
            try
            {
                ValidateSaleInvoice(invoice);

                if (saleInvoiceDAO.GetInvoiceById(invoice.getInvoiceId()) == null)
                {
                    Console.WriteLine("Sale invoice not found.");
                    return false;
                }

                saleInvoiceDAO.UpdateInvoice(invoice);
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

        public bool DeleteSaleInvoice(string invoiceId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(invoiceId))
                    throw new ArgumentException("Sale invoice ID must be provided.");

                if (saleInvoiceDAO.GetInvoiceById(invoiceId) == null)
                {
                    Console.WriteLine("Sale invoice not found.");
                    return false;
                }

                saleInvoiceDAO.DeleteInvoice(invoiceId);
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

        public Sale_Invoice GetSaleInvoiceById(string invoiceId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(invoiceId))
                    throw new ArgumentException("Sale invoice ID must be provided.");

                return saleInvoiceDAO.GetInvoiceById(invoiceId);
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

        public List<Sale_Invoice> GetAllSaleInvoices()
        {
            try
            {
                return saleInvoiceDAO.GetAllInvoices();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving sale invoices: {ex.Message}");
                return null;
            }
        }

        private void ValidateSaleInvoice(Sale_Invoice invoice)
        {
            if (invoice == null)
                throw new ArgumentException("Sale invoice must not be null.");

            if (string.IsNullOrWhiteSpace(invoice.getInvoiceId()))
                throw new ArgumentException("Invoice ID is required.");

            if (invoice.getSaleDate() == default)
                throw new ArgumentException("Sale date is required.");

            if (string.IsNullOrWhiteSpace(invoice.getEmployeeId()))
                throw new ArgumentException("Employee ID is required.");

            if (string.IsNullOrWhiteSpace(invoice.getCustomerId()))
                throw new ArgumentException("Customer ID is required.");

            if (invoice.getTotalAmount() < 0)
                throw new ArgumentException("Total amount must be non-negative.");
        }
    }
}


