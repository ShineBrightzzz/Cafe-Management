using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private SaleInvoiceService _saleInvoiceService;
        private SaleInvoiceDetailService _saleInvoiceDetailService;
        private double _total = 0;

        public PaymentForm(Table table, List<InvoiceItem> invoiceItems)
        {
            InitializeComponent();
            _table = table;
            _invoiceItems = invoiceItems;
            _tableService = new TableService();
            _saleInvoiceService = new SaleInvoiceService();
            _saleInvoiceDetailService = new SaleInvoiceDetailService();

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

                // Hỏi người dùng có muốn in hóa đơn không
                if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "In hóa đơn", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
                        pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 280, 600);

                        // Tạo form xem trước tùy chỉnh
                        Form previewForm = new Form();
                        previewForm.Text = "Xem trước hóa đơn";
                        previewForm.WindowState = FormWindowState.Maximized;
                        previewForm.BackColor = Color.Gray;

                        // Tạo PrintPreviewControl
                        PrintPreviewControl previewControl = new PrintPreviewControl();
                        previewControl.Document = pd;
                        previewControl.Zoom = 1.0;
                        previewControl.BackColor = Color.White;
                        previewControl.Dock = DockStyle.Fill;
                        previewForm.Controls.Add(previewControl);

                        // Tạo ToolStrip với các nút điều khiển
                        ToolStrip toolStrip = new ToolStrip();
                        toolStrip.BackColor = Color.White;

                        // Nút In
                        ToolStripButton printButton = new ToolStripButton();
                        printButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                        printButton.Text = "In";
                        printButton.Image = CreatePrintIcon();
                        printButton.Click += (s, args) =>
                        {
                            try
                            {
                                pd.Print();
                                previewForm.Close();

                                // Sau khi in thành công, cập nhật trạng thái bàn
                                UpdateTableAndClose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };

                        // Nút Zoom in/out
                        ToolStripButton zoomInButton = new ToolStripButton();
                        zoomInButton.Text = "Phóng to";
                        zoomInButton.Click += (s, args) => { previewControl.Zoom *= 1.25; };

                        ToolStripButton zoomOutButton = new ToolStripButton();
                        zoomOutButton.Text = "Thu nhỏ";
                        zoomOutButton.Click += (s, args) => { previewControl.Zoom /= 1.25; };

                        // Thêm các nút vào ToolStrip
                        toolStrip.Items.Add(printButton);
                        toolStrip.Items.Add(new ToolStripSeparator());
                        toolStrip.Items.Add(zoomInButton);
                        toolStrip.Items.Add(zoomOutButton);

                        // Thêm ToolStrip vào form
                        previewForm.Controls.Add(toolStrip);

                        // Hiển thị form xem trước
                        previewForm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi hiển thị hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateTableAndClose();
                    }
                }
                else
                {
                    // Nếu không in hóa đơn, chỉ cập nhật trạng thái bàn
                    UpdateTableAndClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }        
        
        private void UpdateTableAndClose()
        {
            try
            {
                // Tạo mã hóa đơn mới
                string invoiceId = DateTime.Now.ToString("yyyyMMddHHmmss");
                
                // Lấy tổng tiền sau khi trừ giảm giá
                double finalTotal = double.Parse(txtTotalCustomer.Text.Replace(",", "").Replace(" đ", ""));
                
                // Tạo đối tượng hóa đơn mới
                Sale_Invoice saleInvoice = new Sale_Invoice(
                    invoiceId,
                    DateTime.Now,
                    "7ab07743-0169-423c-83e2-cea0c82d2d43", 
                    "03d35fa5-2308-444a-b5f5-c22334171d30", 
                    finalTotal
                );

                // Lưu hóa đơn vào database
                try 
                {
                    _saleInvoiceService.AddSaleInvoice(saleInvoice);

                    // Nếu thêm hóa đơn thành công, kiểm tra xem có thật sự được thêm hay không
                    var addedInvoice = _saleInvoiceService.GetSaleInvoiceById(invoiceId);
                    if (addedInvoice == null)
                    {
                        throw new Exception("Không thể xác nhận hóa đơn đã được lưu");
                    }

                    // Lưu chi tiết hóa đơn
                    double discountPercent = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : double.Parse(txtDiscount.Text);
                    foreach (var item in _invoiceItems)
                    {
                        SaleInvoiceDetail detail = new SaleInvoiceDetail(
                            invoiceId,
                            item.GetProduct().getId(),
                            int.Parse(item.GetQuantity()),
                            item.GetPrice(),
                            discountPercent
                        );

                        try
                        {
                            _saleInvoiceDetailService.AddSaleInvoiceDetail(detail);
                            
                            // Kiểm tra chi tiết hóa đơn đã được thêm
                            var details = _saleInvoiceDetailService.GetDetailsByInvoiceId(invoiceId);
                            if (details == null || !details.Any(d => d.getProductId() == item.GetProduct().getId()))
                            {
                                throw new Exception($"Không thể xác nhận chi tiết hóa đơn cho sản phẩm {item.GetProduct().getName()} đã được lưu");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Nếu có lỗi khi thêm chi tiết, xóa hóa đơn đã thêm
                            _saleInvoiceService.DeleteSaleInvoice(invoiceId);
                            throw new Exception($"Lỗi khi lưu chi tiết hóa đơn: {ex.Message}");
                        }
                    }

                    // Cập nhật trạng thái bàn
                    _table.setIsOccupied(false);
                    _tableService.UpdateTable(_table);

                    // Đóng form với kết quả thành công
                    MessageBox.Show("Thanh toán hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi lưu hóa đơn: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Thiết lập font và bút vẽ
            Font regularFont = new Font("Arial", 8, FontStyle.Regular);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font titleFont = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);
            
            float pageWidth = 270; // Chiều rộng thực tế để in
            int startX = 5;
            int startY = 10;
            int lineHeight = 20;

            // Vẽ tiêu đề
            StringFormat centerFormat = new StringFormat() { Alignment = StringAlignment.Center };
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", titleFont, brush, startX + pageWidth/2, startY, centerFormat);
            startY += lineHeight * 2;

            // Vẽ thông tin cửa hàng
            e.Graphics.DrawString("HIGHLANDS COFFEE", boldFont, brush, startX + pageWidth/2, startY, centerFormat);
            startY += lineHeight;
            e.Graphics.DrawString("181 Nam Kỳ Khởi Nghĩa, Quận 1, HCM", regularFont, brush, startX + pageWidth/2, startY, centerFormat);
            startY += lineHeight;
            e.Graphics.DrawString("Tel: (84-28) 3821 2958", regularFont, brush, startX + pageWidth/2, startY, centerFormat);
            startY += lineHeight;

            // Vẽ đường kẻ ngang
            e.Graphics.DrawLine(pen, startX, startY, startX + pageWidth, startY);
            startY += 5;

            // Vẽ mã cửa hàng và mã số thuế
            e.Graphics.DrawString($"ShopID: {96999}", regularFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Mã số thuế: M1-24-FR602-8809100134", regularFont, brush, startX, startY);
            startY += lineHeight;

            // Vẽ thông tin giao dịch
            e.Graphics.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", regularFont, brush, startX, startY);
            startY += lineHeight;

            // Vẽ đường kẻ ngang
            e.Graphics.DrawLine(pen, startX, startY, startX + pageWidth, startY);
            startY += 10;            // Vẽ tiêu đề cột
            StringFormat rightAlign = new StringFormat() { Alignment = StringAlignment.Far };
            e.Graphics.DrawString("Tên SP", boldFont, brush, startX, startY);
            e.Graphics.DrawString("SL", boldFont, brush, startX + 120, startY, rightAlign);
            e.Graphics.DrawString("Đơn giá", boldFont, brush, startX + 180, startY, rightAlign);
            e.Graphics.DrawString("T.Tiền", boldFont, brush, startX + pageWidth - 10, startY, rightAlign);
            startY += lineHeight;

            // Vẽ đường kẻ ngang
            e.Graphics.DrawLine(pen, startX, startY, startX + pageWidth, startY);
            startY += 5;

            // Vẽ danh sách sản phẩm
            foreach (var item in _invoiceItems)
            {
                string productName = item.GetProduct().getName();
                int quantity = int.Parse(item.GetQuantity());
                double price = item.GetPrice();
                double subtotal = quantity * price;                e.Graphics.DrawString(productName, regularFont, brush, startX, startY);
                e.Graphics.DrawString(quantity.ToString(), regularFont, brush, startX + 120, startY, rightAlign);
                e.Graphics.DrawString($"{price:N0}", regularFont, brush, startX + 180, startY, rightAlign);
                e.Graphics.DrawString($"{subtotal:N0}", regularFont, brush, startX + pageWidth - 10, startY, rightAlign);
                startY += lineHeight;
            }

            // Vẽ đường kẻ ngang
            e.Graphics.DrawLine(pen, startX, startY, startX + pageWidth, startY);
            startY += 10;            // Vẽ tổng tiền
            int totalY = startY;
            string subTotalText = "Tổng cộng:";
            e.Graphics.DrawString(subTotalText, boldFont, brush, startX + pageWidth - 150, totalY);
            e.Graphics.DrawString($"{_total:N0} đ", boldFont, brush, startX + pageWidth, totalY, rightAlign);
            totalY += lineHeight;

            double discountPercent = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : double.Parse(txtDiscount.Text);
            if (discountPercent > 0)
            {
                string discountText = $"Giảm giá ({discountPercent}%):";
                double discountAmount = _total * discountPercent / 100;
                e.Graphics.DrawString(discountText, regularFont, brush, startX + pageWidth - 150, totalY);
                e.Graphics.DrawString($"-{discountAmount:N0} đ", regularFont, brush, startX + pageWidth, totalY, rightAlign);
                totalY += lineHeight;

                // Vẽ tổng tiền sau giảm giá
                double finalTotal = _total - discountAmount;
                e.Graphics.DrawString("Thành tiền:", boldFont, brush, startX + pageWidth - 150, totalY);
                e.Graphics.DrawString($"{finalTotal:N0} đ", boldFont, brush, startX + pageWidth, totalY, rightAlign);
            }

            startY = totalY + lineHeight * 2;

            // Vẽ đường kẻ ngang
            e.Graphics.DrawLine(pen, startX, startY, startX + pageWidth, startY);
            startY += 10;

            // Vẽ thông tin liên hệ
            e.Graphics.DrawString("*Chia sẻ ý kiến của bạn với chúng tôi*", regularFont, brush, startX + pageWidth/2, startY, centerFormat);
            startY += lineHeight;
            e.Graphics.DrawString("customerservice@highlandscoffee.com.vn", regularFont, brush, startX + pageWidth/2, startY, centerFormat);
            startY += lineHeight;

            // Vẽ thông báo
            string notice = "Quý khách có nhu cầu xuất hóa đơn vui lòng gửi yêu cầu và thông tin trong vòng 03 giờ kể từ lúc mua hàng";
            using (Font noticeFont = new Font("Arial", 7, FontStyle.Italic))
            {
                e.Graphics.DrawString(notice, noticeFont, brush, new RectangleF(startX, startY, pageWidth, lineHeight * 3), centerFormat);
            }
            startY += lineHeight * 3;

            // Vẽ QR code nếu thanh toán bằng ngân hàng
            if (rdBank.Checked && picQR.Image != null)
            {
                int qrSize = 100;
                e.Graphics.DrawImage(picQR.Image, startX + (pageWidth - qrSize)/2, startY, qrSize, qrSize);
                startY += qrSize + lineHeight;
            }

            // Vẽ đường kẻ ngang cuối cùng
            e.Graphics.DrawLine(pen, startX, startY, startX + pageWidth, startY);
            startY += 10;

            // Vẽ đường dẫn website
            e.Graphics.DrawString("https://invoice.highlandscoffee.com.vn", regularFont, brush, startX + pageWidth/2, startY, centerFormat);

            // Giải phóng tài nguyên
            pen.Dispose();
        }

        private Bitmap CreatePrintIcon()
        {
            // Tạo bitmap 16x16 cho icon
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                // Vẽ máy in
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    // Thân máy in
                    g.DrawRectangle(pen, 2, 4, 12, 8);
                    // Khay giấy
                    g.DrawRectangle(pen, 4, 2, 8, 2);
                    // Giấy in
                    g.DrawLine(pen, 6, 7, 10, 7);
                    g.DrawLine(pen, 6, 9, 10, 9);
                }
            }
            return bmp;
        }
    }
}
