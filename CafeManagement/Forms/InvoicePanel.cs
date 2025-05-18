using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Entities; // Ensure the correct Table type is referenced

namespace CafeManagement.Forms
{
    public partial class InvoicePanel : UserControl    {
        private List<InvoiceItem> _invoiceItems;
        private Table _table;

        public InvoicePanel()
        {
            InitializeComponent();
            _invoiceItems = new List<InvoiceItem>();
            InitializeLayout();
        }

        public InvoicePanel(Table table)
        {
            InitializeComponent();
            _table = table;
            _invoiceItems = new List<InvoiceItem>();
            InitializeLayout();
            // Additional initialization logic for the table can be added here
        }

        private void InitializeLayout()
        {
            // Set border for the main panel
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;

            // Configure the flowLayoutPanel1 from Designer
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;            flowLayoutPanel1.Padding = new Padding(10);
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

        // Add a method to add a product directly
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
                InvoiceItem invoiceItem = new InvoiceItem(product);
                AddInvoiceItem(invoiceItem);
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

        private void InvoiceItem_QuantityChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
