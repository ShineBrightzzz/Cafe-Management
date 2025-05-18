using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Entities;
using CafeManagement.Services;
using CafeManagement.DAO;

namespace CafeManagement.Forms
{
    public partial class InvoicePanel : UserControl
    {
        private List<InvoiceItem> _invoiceItems;
        private Table _table;
        private Order _currentOrder;
        private OrderService _orderService;
        private ProductDAO _productDAO;

        public InvoicePanel()
        {
            InitializeComponent();
            _invoiceItems = new List<InvoiceItem>();
            _orderService = new OrderService();
            _productDAO = new ProductDAO();
            InitializeLayout();
        }

        public InvoicePanel(Table table)
        {
            InitializeComponent();
            _table = table;
            _invoiceItems = new List<InvoiceItem>();
            _orderService = new OrderService();
            _productDAO = new ProductDAO();
            InitializeLayout();
            LoadPendingOrder(); // Load any pending order for this table
        }

        private void InitializeLayout()
        {
            // Set border for the main panel
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;

            // Configure the flowLayoutPanel1 from Designer
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.BackColor = Color.White;
        }

        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach (var item in _invoiceItems)
            {
                int quantity = int.Parse(item.GetQuantity());
                double price = item.GetPrice();
                total += quantity * price;
            }
            lblTotalPrice.Text = $"Tổng tiền: {total:N0} đ";
        }

        private void LoadPendingOrder()
        {
            var pendingOrders = _orderService.GetPendingOrdersByTable(_table.getId());
            if (pendingOrders.Count > 0)
            {
                _currentOrder = pendingOrders[0]; // Get the first pending order
                var orderDetails = _orderService.GetOrderDetails(_currentOrder.getId());

                foreach (var detail in orderDetails)
                {
                    Product product = _productDAO.GetProductById(detail.getProductId());
                    if (product != null)
                    {
                        InvoiceItem invoiceItem = new InvoiceItem(product);
                        // Set the quantity from order detail
                        for (int i = 1; i < detail.getQuantity(); i++)
                        {
                            invoiceItem.IncreaseQuantity();
                        }
                        AddInvoiceItem(invoiceItem);
                    }
                }
            }
        }

        private void LoadInvoiceItems()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in _invoiceItems)
            {
                item.Width = flowLayoutPanel1.Width - 20; // Account for padding
                flowLayoutPanel1.Controls.Add(item);
            }
            UpdateTotalPrice();
        }

        public void AddProduct(Product product)
        {
            var result = MessageBox.Show(
                $"Thêm {product.getName()} vào hóa đơn?\nGiá: {product.getSalePrice():N0} đ",
                "Xác nhận thêm món",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Create new order if doesn't exist
                if (_currentOrder == null)
                {
                    _currentOrder = _orderService.CreateNewOrder(_table.getId());
                }

                InvoiceItem invoiceItem = new InvoiceItem(product);
                invoiceItem.ItemDeleted += InvoiceItem_Deleted;

                // Add to database first
                if (_orderService.AddOrderDetail(_currentOrder.getId(), product, 1))
                {
                    AddInvoiceItem(invoiceItem);
                }
                else
                {
                    MessageBox.Show("Không thể thêm món vào đơn hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AddInvoiceItem(InvoiceItem item)
        {
            _invoiceItems.Add(item);
            item.Width = flowLayoutPanel1.Width - 20; // Account for padding
            item.QuantityChanged += InvoiceItem_QuantityChanged;  // Subscribe to quantity changes
            flowLayoutPanel1.Controls.Add(item);
            flowLayoutPanel1.ScrollControlIntoView(item);
            UpdateTotalPrice();
        }

        private void InvoiceItem_Deleted(object sender, EventArgs e)
        {
            if (sender is InvoiceItem item)
            {
                _invoiceItems.Remove(item);
                if (_currentOrder != null)
                {
                    _orderService.RemoveOrderDetail(_currentOrder.getId(), item.GetProduct().getId());
                }
                UpdateTotalPrice();
            }
        }

        private void InvoiceItem_QuantityChanged(object sender, EventArgs e)
        {
            if (sender is InvoiceItem item && _currentOrder != null)
            {
                // Update the order detail with new quantity
                _orderService.RemoveOrderDetail(_currentOrder.getId(), item.GetProduct().getId());
                _orderService.AddOrderDetail(
                    _currentOrder.getId(),
                    item.GetProduct(),
                    int.Parse(item.GetQuantity())
                );
            }
            UpdateTotalPrice();
        }

        public Order GetCurrentOrder()
        {
            return _currentOrder;
        }

        public void CompleteOrder()
        {
            if (_currentOrder != null)
            {
                if (_orderService.CompleteOrder(_currentOrder.getId()))
                {
                    _currentOrder = null;
                    _invoiceItems.Clear();
                    flowLayoutPanel1.Controls.Clear();
                    UpdateTotalPrice();
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (_currentOrder == null)
            {
                MessageBox.Show("Không có hóa đơn cần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Xác nhận thanh toán hóa đơn?\nTổng tiền: {lblTotalPrice.Text}",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (_orderService.CompleteOrder(_currentOrder.getId()))
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // CompleteOrder() already handles:
                    // 1. Update order status to completed
                    // 2. Update table status to available if no other pending orders
                    // 3. Clear the order and items from memory
                    CompleteOrder(); // This method will clear the UI
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
