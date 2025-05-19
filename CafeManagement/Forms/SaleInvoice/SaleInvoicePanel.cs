using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Controllers;
using CafeManagement.Entities;

namespace CafeManagement.Forms.SaleInvoice
{
    public partial class SaleInvoicePanel : UserControl
    {
        private readonly SaleInvoiceController saleInvoiceController;
        private readonly SaleInvoiceDetailController saleInvoiceDetailController;

        public SaleInvoicePanel()
        {
            InitializeComponent();
            saleInvoiceController = new SaleInvoiceController();
            saleInvoiceDetailController = new SaleInvoiceDetailController();
            InitializeDataGridViews();
            FormatDataGridViews();
            LoadSaleInvoices();
        }

        private void InitializeDataGridViews()
        {
            // Configure sale invoices grid
            dgridSaleInvoice.AutoGenerateColumns = false;
            dgridSaleInvoice.Columns.Add("InvoiceId", "Mã HĐB");
            dgridSaleInvoice.Columns.Add("SaleDate", "Ngày Bán");
            dgridSaleInvoice.Columns.Add("EmployeeId", "Mã NV");
            dgridSaleInvoice.Columns.Add("CustomerId", "Mã KH");
            dgridSaleInvoice.Columns.Add("TotalAmount", "Tổng Tiền");

            // Configure sale invoice details grid
            dgridSaleInvoiceDetails.AutoGenerateColumns = false;
            dgridSaleInvoiceDetails.Columns.Add("ProductId", "Mã SP");
            dgridSaleInvoiceDetails.Columns.Add("Quantity", "Số Lượng");
            dgridSaleInvoiceDetails.Columns.Add("UnitPrice", "Đơn Giá");
            dgridSaleInvoiceDetails.Columns.Add("DiscountPercent", "Giảm Giá %");
            dgridSaleInvoiceDetails.Columns.Add("Total", "Thành Tiền");

            // Handle selection change in sale invoices grid
            dgridSaleInvoice.SelectionChanged += DgridSaleInvoice_SelectionChanged;
        }

        private void LoadSaleInvoices()
        {
            var invoices = saleInvoiceController.GetAllSaleInvoices();
            dgridSaleInvoice.Rows.Clear();
            
            foreach (var invoice in invoices)
            {
                dgridSaleInvoice.Rows.Add(
                    invoice.getInvoiceId(),
                    invoice.getSaleDate().ToString("dd/MM/yyyy"),
                    invoice.getEmployeeId(),
                    invoice.getCustomerId(),
                    invoice.getTotalAmount().ToString("N0")
                );
            }
        }

        private void DgridSaleInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgridSaleInvoice.CurrentRow != null)
            {
                string selectedInvoiceId = dgridSaleInvoice.CurrentRow.Cells["InvoiceId"].Value.ToString();
                LoadSaleInvoiceDetails(selectedInvoiceId);
            }
        }

        private void LoadSaleInvoiceDetails(string invoiceId)
        {
            var details = saleInvoiceDetailController.GetDetailsByInvoiceId(invoiceId);
            dgridSaleInvoiceDetails.Rows.Clear();

            foreach (var detail in details)
            {
                dgridSaleInvoiceDetails.Rows.Add(
                    detail.getProductId(),
                    detail.getQuantity(),
                    detail.getUnitPrice().ToString("N0"),
                    detail.getDiscountPercent().ToString("N1"),
                    detail.getTotal().ToString("N0")
                );
            }
        }

        private void FormatDataGridViews()
        {
            // Format Sale Invoice Grid
            dgridSaleInvoice.AutoGenerateColumns = false;
            dgridSaleInvoice.AllowUserToAddRows = false;

            // Format Sale Invoice Details Grid
            dgridSaleInvoiceDetails.AutoGenerateColumns = false;
            dgridSaleInvoiceDetails.AllowUserToAddRows = false;

            // Common styling for both grids
            foreach (var grid in new[] { dgridSaleInvoice, dgridSaleInvoiceDetails })
            {
                // Định dạng header
                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersHeight = 40;

                // Định dạng các dòng dữ liệu
                grid.BackgroundColor = Color.White;
                grid.DefaultCellStyle.BackColor = Color.White;
                grid.DefaultCellStyle.ForeColor = Color.Black;
                grid.DefaultCellStyle.Font = new Font("Tahoma", 10);
                grid.RowTemplate.Height = 35;
                grid.GridColor = Color.LightGray;
                grid.BorderStyle = BorderStyle.Fixed3D;
                grid.ReadOnly = true;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Định dạng màu khi chọn dòng
                grid.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            }

            ResizeColumns();
        }

        private void ResizeColumns()
        {
            if (dgridSaleInvoice.Columns.Count == 0) return;

            // Resize Sale Invoice Grid columns
            int totalWidth = dgridSaleInvoice.ClientSize.Width;
            dgridSaleInvoice.Columns["InvoiceId"].Width = (int)(totalWidth * 0.15);    // 15%
            dgridSaleInvoice.Columns["SaleDate"].Width = (int)(totalWidth * 0.25);     // 25%
            dgridSaleInvoice.Columns["EmployeeId"].Width = (int)(totalWidth * 0.15);   // 15%
            dgridSaleInvoice.Columns["CustomerId"].Width = (int)(totalWidth * 0.15);   // 15%
            dgridSaleInvoice.Columns["TotalAmount"].Width = (int)(totalWidth * 0.30);  // 30%

            if (dgridSaleInvoiceDetails.Columns.Count == 0) return;

            // Resize Sale Invoice Details Grid columns
            totalWidth = dgridSaleInvoiceDetails.ClientSize.Width;
            dgridSaleInvoiceDetails.Columns["ProductId"].Width = (int)(totalWidth * 0.2);     // 20%
            dgridSaleInvoiceDetails.Columns["Quantity"].Width = (int)(totalWidth * 0.15);     // 15%
            dgridSaleInvoiceDetails.Columns["UnitPrice"].Width = (int)(totalWidth * 0.25);    // 25%
            dgridSaleInvoiceDetails.Columns["DiscountPercent"].Width = (int)(totalWidth * 0.15); // 15%
            dgridSaleInvoiceDetails.Columns["Total"].Width = (int)(totalWidth * 0.25);        // 25%
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeColumns();
        }
    }
}
