using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    public class ImportInvoice
    {
        private String importInvoiceId; //mã hóa đơn nhập
        private DateTime dateOfImport; //ngày nhập
        private String employeeId; //mã nhân viên
        private String supplierId; //mã nhà cung cấp
        private double importTotalPrice; //tổng tiền 


        public ImportInvoice(String importInvoiceId, DateTime dateOfImport, String employeeId, String supplierId, double importTotalPrice)
        {
            this.importInvoiceId = importInvoiceId;
            this.dateOfImport = dateOfImport;   
            this.employeeId = employeeId;   
            this.supplierId = supplierId;
            this.importTotalPrice = importTotalPrice;
        }

        public String getImportInvoiceId() { return importInvoiceId; }
        public DateTime getDateOfImport() { return dateOfImport; }
        public String getEmployeeId() { return employeeId; }
        
        public String getSupplierId() { return supplierId; }
        public double getImportTotalPrice() { return importTotalPrice; }
        public double getTotalAmount() { return importTotalPrice; }
        public DateTime getImportDate() { return dateOfImport; }

        public void setImportInvoiceID(String importInvoiceID)
        {
            this.importInvoiceId = importInvoiceID;
        }

        public void setDateOfImport(DateTime dateOfImport)
        {
            this.dateOfImport = dateOfImport;
        }

        public void setEmployeeID(String employeeId)
        {
            this.employeeId = employeeId;
        }

        public void setSupplierId(String supplierId)
        {
            this.supplierId = supplierId;
        }

        public void setImportTotalPrice(double importTotalPrice)
        {
            this.importTotalPrice = importTotalPrice;
        }

        public void setTotalAmount(double totalAmount) { this.importTotalPrice = totalAmount; }
    }
}
