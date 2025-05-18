using System;

namespace CafeManagement.Entities
{
    public class OrderDetail
    {
        private string _orderId;
        private string _productId;
        private int _quantity;
        private decimal _unitPrice;
        private decimal _amount;

        public OrderDetail(string orderId, string productId, int quantity, decimal unitPrice, decimal amount)
        {
            _orderId = orderId;
            _productId = productId;
            _quantity = quantity;
            _unitPrice = unitPrice;
            _amount = amount;
        }

        public string getOrderId() { return _orderId; }
        public string getProductId() { return _productId; }
        public int getQuantity() { return _quantity; }
        public decimal getUnitPrice() { return _unitPrice; }
        public decimal getAmount() { return _amount; }

        public void setOrderId(string orderId) { _orderId = orderId; }
        public void setProductId(string productId) { _productId = productId; }
        public void setQuantity(int quantity) { _quantity = quantity; }
        public void setUnitPrice(decimal unitPrice) { _unitPrice = unitPrice; }
        public void setAmount(decimal amount) { _amount = amount; }
    }
}
