using System;

namespace CafeManagement.Entities
{
    public class Order
    {
        private string _id;
        private string _tableId;
        private string _status;
        private DateTime _orderDate;

        public Order(string id, string tableId, string status, DateTime orderDate)
        {
            _id = id;
            _tableId = tableId;
            _status = status;
            _orderDate = orderDate;
        }

        public string getId() { return _id; }
        public string getTableId() { return _tableId; }
        public string getStatus() { return _status; }
        public DateTime getOrderDate() { return _orderDate; }

        public void setId(string id) { _id = id; }
        public void setTableId(string tableId) { _tableId = tableId; }
        public void setStatus(string status) { _status = status; }
        public void setOrderDate(DateTime orderDate) { _orderDate = orderDate; }
    }
}
