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

namespace CafeManagement.Forms
{
    public partial class PaymentForm : Form
    {
        private List<InvoiceItem> _invoiceItems;
        private Table _table;
        private TableService _tableService;

        public PaymentForm(Table table, List<InvoiceItem> invoiceItems)
        {
            InitializeComponent();
            _table = table;
            _invoiceItems = invoiceItems;
            _tableService = new TableService();
            LoadInvoiceItems();
        }

        private void LoadInvoiceItems()
        {
            // Clear existing items and add columns if not already added
            itemPanel.Items.Clear();
            if (itemPanel.Columns.Count == 0)
            {
                itemPanel.Columns.Add("Tên sản phẩm", 120);
                itemPanel.Columns.Add("Số lượng", 70);
                itemPanel.Columns.Add("Đơn giá", 90);
                itemPanel.Columns.Add("Thành tiền", 90);
            }

            double total = 0;
            foreach (var item in _invoiceItems)
            {
                string productName = item.GetProduct().getName();
                int quantity = int.Parse(item.GetQuantity());
                double price = item.GetPrice();
                double subtotal = quantity * price;
                total += subtotal;

                ListViewItem listItem = new ListViewItem(new string[] {
                    productName,
                    quantity.ToString(),
                    price.ToString("N0") + " đ",
                    subtotal.ToString("N0") + " đ"
                });
                itemPanel.Items.Add(listItem);
            }

            // Update total amount label
            lblTotal.Text = $"Tổng tiền: {total:N0} đ";
        }        
        
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {                
                // Update table status to available
                _table.setIsOccupied(false);
                _tableService.UpdateTable(_table);

                // Close form with success result
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
