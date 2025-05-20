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
using QRCoder;

namespace CafeManagement.Forms
{
    public partial class PaymentForm : Form
    {
        private List<InvoiceItem> _invoiceItems;
        private Table _table;
        private TableService _tableService;
        private double _total = 0;        public PaymentForm(Table table, List<InvoiceItem> invoiceItems)
        {
            InitializeComponent();
            _table = table;
            _invoiceItems = invoiceItems;
            _tableService = new TableService();
            
            // Set default values
            txtDiscount.Text = "0";
            rdCash.Checked = true;
            picQR.Visible = false;
            picQR.SizeMode = PictureBoxSizeMode.Zoom;
            
            // Handle discount changes
            txtDiscount.TextChanged += TxtDiscount_TextChanged;
            rdCash.CheckedChanged += RdPayment_CheckedChanged;
            rdBank.CheckedChanged += RdPayment_CheckedChanged;
            
            LoadInvoiceItems();
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            try
            {
                double discountPercent = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : double.Parse(txtDiscount.Text);
                if (discountPercent < 0) discountPercent = 0;
                if (discountPercent > 100) discountPercent = 100;
                
                double discountAmount = _total * discountPercent / 100;
                double finalTotal = _total - discountAmount;
                
                txtTotalCustomer.Text = $"{finalTotal:N0} đ";
                txtCustomerPayment.Text = finalTotal.ToString("N0");
            }
            catch
            {
                txtTotalCustomer.Text = $"{_total:N0} đ";
                txtCustomerPayment.Text = _total.ToString("N0");
            }
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

            _total = 0;
            foreach (var item in _invoiceItems)
            {
                string productName = item.GetProduct().getName();
                int quantity = int.Parse(item.GetQuantity());
                double price = item.GetPrice();
                double subtotal = quantity * price;
                _total += subtotal;

                ListViewItem listItem = new ListViewItem(new string[] {
                    productName,
                    quantity.ToString(),
                    price.ToString("N0") + " đ",
                    subtotal.ToString("N0") + " đ"
                });
                itemPanel.Items.Add(listItem);
            }

            // Update total amount labels
            lblTotal.Text = $"{_total:N0} đ";
            UpdateTotalAmount();
        }        
        
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {                
                // Validate payment amount
                double customerPayment = 0;
                if (!double.TryParse(txtCustomerPayment.Text.Replace(",", ""), out customerPayment))
                {
                    MessageBox.Show("Vui lòng nhập số tiền thanh toán hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double finalTotal = double.Parse(txtTotalCustomer.Text.Replace(",", "").Replace(" đ", ""));
                if (customerPayment < finalTotal)
                {
                    MessageBox.Show("Số tiền thanh toán không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

        private void RdPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCash.Checked)
            {
                picQR.Visible = false;
            }
            else if (rdBank.Checked)
            {
                picQR.Visible = true;
                GenerateQRCode();
            }
        }

        private void GenerateQRCode()
        {
            try
            {
                double amount = double.Parse(txtTotalCustomer.Text.Replace(",", "").Replace(" đ", ""));
                string qrContent = $"Thanh toán: {amount:N0} VND\n" +
                                 "Số tài khoản: 123456789\n" +
                                 "Ngân hàng: VPBank\n" +
                                 "Tên: CAFE MANAGEMENT";

                QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
                QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCoder.QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
                
                // Tạo QR code với kích thước phù hợp với PictureBox
                int minDimension = Math.Min(picQR.Width, picQR.Height);
                picQR.Image = qrCode.GetGraphic(minDimension / 50); // Điều chỉnh pixel size
                picQR.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo mã QR: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
