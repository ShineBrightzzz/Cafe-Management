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

namespace CafeManagement.Forms.ImportInvoice
{
    public partial class ImportInvoicePanel : UserControl
    {
        private readonly ImportInvoiceController importInvoiceController;
        private readonly ImportInvoiceDetailController importInvoiceDetailController;

        public ImportInvoicePanel()
        {
            InitializeComponent();
            importInvoiceController = new ImportInvoiceController();
            importInvoiceDetailController = new ImportInvoiceDetailController();
            InitializeDataGridViews();
            FormatDataGridViews();
            LoadImportInvoices();
        }

        private void InitializeDataGridViews()
        {
            // Configure import invoices grid
            dgridImportInvoice.AutoGenerateColumns = false;
            dgridImportInvoice.Columns.Add("ImportInvoiceId", "Mã HĐN");
            dgridImportInvoice.Columns.Add("ImportDate", "Ngày Nhập");
            dgridImportInvoice.Columns.Add("EmployeeId", "Mã NV");
            dgridImportInvoice.Columns.Add("TotalAmount", "Tổng Tiền");

            // Configure import invoice details grid
            dgridImportInvoiceDetails.AutoGenerateColumns = false;
            dgridImportInvoiceDetails.Columns.Add("IngredientId", "Mã NL");
            dgridImportInvoiceDetails.Columns.Add("Quantity", "Số Lượng");
            dgridImportInvoiceDetails.Columns.Add("UnitPrice", "Đơn Giá");
            dgridImportInvoiceDetails.Columns.Add("Discount", "Giảm Giá %");
            dgridImportInvoiceDetails.Columns.Add("TotalPrice", "Thành Tiền");

            // Handle selection change in import invoices grid
            dgridImportInvoice.SelectionChanged += DgridImportInvoice_SelectionChanged;
        }

        private void LoadImportInvoices()
        {
            var invoices = importInvoiceController.GetAllImportInvoices();
            dgridImportInvoice.Rows.Clear();
            
            foreach (var invoice in invoices)
            {                
                    dgridImportInvoice.Rows.Add(
                    invoice.getImportInvoiceId(),
                    invoice.getDateOfImport().ToString("dd/MM/yyyy"),
                    invoice.getEmployeeId(),
                    invoice.getTotalAmount().ToString("N0")
                );
            }
        }

        private void DgridImportInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgridImportInvoice.CurrentRow != null)
            {
                string selectedInvoiceId = dgridImportInvoice.CurrentRow.Cells["ImportInvoiceId"].Value.ToString();
                LoadImportInvoiceDetails(selectedInvoiceId);
            }
        }

        private void LoadImportInvoiceDetails(string invoiceId)
        {
            var details = importInvoiceDetailController.GetDetailsByInvoiceId(invoiceId);
            dgridImportInvoiceDetails.Rows.Clear();

            foreach (var detail in details)
            {
                dgridImportInvoiceDetails.Rows.Add(
                    detail.getIngredientId(),
                    detail.getQuantity(),
                    detail.getUnitPrice().ToString("N0"),
                    detail.getDiscount().ToString("N1"),
                    detail.getTotalPrice().ToString("N0")
                );
            }
        }

        private void FormatDataGridViews()
        {
            // Format both grids
            foreach (var grid in new[] { dgridImportInvoice, dgridImportInvoiceDetails })
            {
                // Header format
                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersHeight = 40;

                // Content format
                grid.BackgroundColor = Color.White;
                grid.DefaultCellStyle.BackColor = Color.White;
                grid.DefaultCellStyle.ForeColor = Color.Black;
                grid.DefaultCellStyle.Font = new Font("Tahoma", 10);
                grid.RowTemplate.Height = 35;
                grid.GridColor = Color.LightGray;
                grid.BorderStyle = BorderStyle.Fixed3D;
                grid.ReadOnly = true;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Selection colors
                grid.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            }

            ResizeColumns();
        }

        private void ResizeColumns()
        {
            if (dgridImportInvoice.Columns.Count == 0) return;

            // Resize Import Invoice Grid columns
            int totalWidth = dgridImportInvoice.ClientSize.Width;
            dgridImportInvoice.Columns["ImportInvoiceId"].Width = (int)(totalWidth * 0.25);    // 25%
            dgridImportInvoice.Columns["ImportDate"].Width = (int)(totalWidth * 0.25);         // 25%
            dgridImportInvoice.Columns["EmployeeId"].Width = (int)(totalWidth * 0.25);         // 25%
            dgridImportInvoice.Columns["TotalAmount"].Width = (int)(totalWidth * 0.25);        // 25%

            if (dgridImportInvoiceDetails.Columns.Count == 0) return;

            // Resize Import Invoice Details Grid columns
            totalWidth = dgridImportInvoiceDetails.ClientSize.Width;
            dgridImportInvoiceDetails.Columns["IngredientId"].Width = (int)(totalWidth * 0.2);   // 20%
            dgridImportInvoiceDetails.Columns["Quantity"].Width = (int)(totalWidth * 0.15);      // 15%
            dgridImportInvoiceDetails.Columns["UnitPrice"].Width = (int)(totalWidth * 0.25);     // 25%
            dgridImportInvoiceDetails.Columns["Discount"].Width = (int)(totalWidth * 0.15);      // 15%
            dgridImportInvoiceDetails.Columns["TotalPrice"].Width = (int)(totalWidth * 0.25);    // 25%
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeColumns();
        }
    }
}
