using System;

namespace CafeManagement.Entities
{
    public class SalesInvoice
    {
        private string invoiceId;        // Mã HDB
        private DateTime saleDate;       // Ngày bán
        private string employeeId;       // Mã NV
        private string customerId;       // Mã KH
        private double totalAmount;      // Tổng tiền

        public SalesInvoice(string invoiceId, DateTime saleDate, string employeeId, string customerId, double totalAmount)
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
