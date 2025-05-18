using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class OrderService
    {
        private OrderDAO _orderDAO;
        private OrderDetailDAO _orderDetailDAO;
        private ProductDAO _productDAO;

        public OrderService()
        {
            _orderDAO = new OrderDAO();
            _orderDetailDAO = new OrderDetailDAO();
            _productDAO = new ProductDAO();
        }

        public Order CreateNewOrder(string tableId)
        {
            string orderId = Guid.NewGuid().ToString();
            Order order = new Order(orderId, tableId, "pending", DateTime.Now);
            _orderDAO.AddOrder(order);
            return order;
        }

        public bool AddOrderDetail(string orderId, Product product, int quantity)
        {
            try
            {
                decimal amount = (decimal)product.getSalePrice() * quantity;
                OrderDetail detail = new OrderDetail(
                    orderId,
                    product.getId(),
                    quantity,
                    (decimal)product.getSalePrice(),
                    amount
                );
                _orderDetailDAO.AddOrderDetail(detail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddOrderDetail Error: " + ex.Message);
                return false;
            }
        }

        public bool RemoveOrderDetail(string orderId, string productId)
        {
            try
            {
                _orderDetailDAO.DeleteOrderDetail(orderId, productId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("RemoveOrderDetail Error: " + ex.Message);
                return false;
            }
        }

        public List<Order> GetPendingOrdersByTable(string tableId)
        {
            return _orderDAO.GetOrdersByTableId(tableId);
        }

        public List<OrderDetail> GetOrderDetails(string orderId)
        {
            return _orderDetailDAO.GetOrderDetailsByOrderId(orderId);
        }

        public bool CompleteOrder(string orderId)
        {
            try
            {
                _orderDAO.UpdateOrderStatus(orderId, "completed");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CompleteOrder Error: " + ex.Message);
                return false;
            }
        }
    }
}
