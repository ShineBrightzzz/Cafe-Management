using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    public class ImportInvoiceDetail
    {
        private String importInvoiceId;
        private String productId;
        private int quantity;
        private double unitPrice;
        private double discount;
        private double totalPrice;

        public ImportInvoiceDetail(String importInvoiceId, String productId, int quantity, double unitPrice, double discount, double totalPrice) {
            this.importInvoiceId = importInvoiceId; 
            this.productId = productId;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.discount = discount;
            this.totalPrice = totalPrice;
        }

        public String getImportInvoiceId() { return importInvoiceId; }
        public String getProductId() { return productId; }
        public int getQuantity() { return quantity; }
        public double getUnitPrice() { return unitPrice; }
        public double getDiscount() { return discount; }
        public double getTotalPrice() { return totalPrice; }

        public void setImportInvoice(String importInvoiceId)
        {
            this.importInvoiceId=importInvoiceId;
        }
        public void setProductId(String productId) { 
            this.productId=productId; 
        }
        public void setQuantity(int quantity) {
            this.quantity = quantity; 
        }
        public void setUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        public void setDiscount(double discount)
        {
            this.discount = discount;
        }
        public void setTotalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }


    }
}
