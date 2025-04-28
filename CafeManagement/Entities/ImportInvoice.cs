using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    internal class ImportInvoice
    {
        private String importInvoiceId; //mã hóa đơn nhập
        private DateTime dateOfImport; //ngày nhập
        private String employeeId; //mã nhân viên
        private String supplierId; //mã nhà cung cấp
        private float importTotalPrice; //tổng tiền 


        public ImportInvoice(String importInvoiceId, DateTime dateOfImport, String employeeId, String supplierId, float importTotalPrice)
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
        public float getImportTotalPrice() { return importTotalPrice; }

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

        public void setImportTotalPrice(float importTotalPrice)
        {
            this.importTotalPrice = importTotalPrice;
        }


    }
}
