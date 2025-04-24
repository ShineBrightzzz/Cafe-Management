using System;

namespace CafeManagement.Entities
{
    public class Sale_Invoice
    {
        private string invoiceId;        
        private DateTime saleDate;       
        private string employeeId;       
        private string customerId;       
        private double totalAmount;      

        public Sale_Invoice(string invoiceId, DateTime saleDate, string employeeId, string customerId, double totalAmount)
        {
            this.invoiceId = invoiceId;
            this.saleDate = saleDate;
            this.employeeId = employeeId;
            this.customerId = customerId;
            this.totalAmount = totalAmount;
        }

        public string getInvoiceId()
        {
            return invoiceId;
        }

        public void setInvoiceId(string value)
        {
            invoiceId = value;
        }

        public DateTime getSaleDate()
        {
            return saleDate;
        }

        public void setSaleDate(DateTime value)
        {
            saleDate = value;
        }

        public string getEmployeeId()
        {
            return employeeId;
        }

        public void setEmployeeId(string value)
        {
            employeeId = value;
        }

        public string getCustomerId()
        {
            return customerId;
        }

        public void setCustomerId(string value)
        {
            customerId = value;
        }

        public double getTotalAmount()
        {
            return totalAmount;
        }

        public void setTotalAmount(double value)
        {
            totalAmount = value;
        }
    }
}
