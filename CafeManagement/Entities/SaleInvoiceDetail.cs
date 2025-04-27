namespace CafeManagement.Entities
{
    public class SaleInvoiceDetail
    {
        private string invoiceId;         
        private string productId;         
        private int quantity;             
        private double unitPrice;         
        private double discountPercent;   
        private double total;             

        public SaleInvoiceDetail(string invoiceId, string productId, int quantity, double unitPrice, double discountPercent)
        {
            this.invoiceId = invoiceId;
            this.productId = productId;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.discountPercent = discountPercent;
            this.total = (unitPrice * quantity) * (1 - discountPercent / 100);
        }

        public string getInvoiceId()
        {
            return invoiceId;
        }

        public void setInvoiceId(string value)
        {
            invoiceId = value;
        }

        public string getProductId()
        {
            return productId;
        }

        public void setProductId(string value)
        {
            productId = value;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int value)
        {
            quantity = value;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(double value)
        {
            unitPrice = value;
        }

        public double getDiscountPercent()
        {
            return discountPercent;
        }

        public void setDiscountPercent(double value)
        {
            discountPercent = value;
        }

        public double getTotal()
        {
            return total;
        }

        public void setTotal(double value)
        {
            total = value;
        }
    }
}
