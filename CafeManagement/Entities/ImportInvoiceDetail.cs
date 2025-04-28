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
        private float unitPrice;
        private float discount;
        private float totalPrice;

        public ImportInvoiceDetail(String importInvoiceId, String productId, int quantity, float unitPrice, float discount, float totalPrice) {
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
        public float getUnitPrice() { return unitPrice; }
        public float getDiscount() { return discount; }
        public float getTotalPrice() { return totalPrice; }

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
        public void setUnitPrice(float unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        public void setDiscount(float discount)
        {
            this.discount = discount;
        }
        public void setTotalPrice(float totalPrice)
        {
            this.totalPrice = totalPrice;
        }


    }
}
