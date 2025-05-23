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
        private readonly EmployeeController employeeController;
        private readonly SupplierController supplierController;
        private string selectedInvoiceId;
        private ActionMode currentMode = ActionMode.None;

        private enum ActionMode
        {
            None,
            Add,
            Edit,
            Delete
        }

        public ImportInvoicePanel()
        {
            InitializeComponent();
            importInvoiceController = new ImportInvoiceController();
            importInvoiceDetailController = new ImportInvoiceDetailController();
            employeeController = new EmployeeController();
            supplierController = new SupplierController();

            // Initialize ComboBoxes
            InitializeComboBoxes();

            InitializeDataGridViews();
            FormatDataGridViews();
            LoadImportInvoices();
            UpdateButtonState();
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
        {            // Format both grids
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
                
                // Grid-specific settings
                if (grid == dgridImportInvoice)
                {
                    grid.ReadOnly = true; // Main grid is read-only
                    grid.AllowUserToAddRows = false;
                    grid.EditMode = DataGridViewEditMode.EditProgrammatically;
                }
                else // Import invoice details grid
                {
                    grid.ReadOnly = false; // Details grid is editable
                    grid.AllowUserToAddRows = true;
                    grid.EditMode = DataGridViewEditMode.EditOnEnter;
                }                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Selection colors
                grid.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                grid.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Handle double-click editing for details grid
                if (grid == dgridImportInvoiceDetails)
                {
                    grid.CellDoubleClick += (s, e) => {
                        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                            grid.BeginEdit(true);
                    };
                }
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

        private void UpdateButtonState()
        {
            // Default state (no action in progress)
            if (currentMode == ActionMode.None)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                dgridImportInvoice.Enabled = true;
                dgridImportInvoiceDetails.Enabled = true;
            }
            // Add/Edit/Delete action in progress
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                dgridImportInvoice.Enabled = false;
                dgridImportInvoiceDetails.Enabled = false;
            }
        }

        private void InitializeComboBoxes()
        {
            // Clear existing items
            cbEmployee.Items.Clear();
            cbSupplier.Items.Clear();

            // Load Employees
            var employees = employeeController.GetAllEmployees();
            foreach (var emp in employees)
            {
                cbEmployee.Items.Add(new ComboboxItem { Text = emp.getName(), Value = emp.getId() });
            }

            // Load Suppliers
            var suppliers = supplierController.GetAllSuppliers();
            foreach (var sup in suppliers)
            {
                cbSupplier.Items.Add(new ComboboxItem { Text = sup.getName(), Value = sup.getId() });
            }

            // Set default selection if items exist
            if (cbEmployee.Items.Count > 0) cbEmployee.SelectedIndex = 0;
            if (cbSupplier.Items.Count > 0) cbSupplier.SelectedIndex = 0;
        }

        // Helper class for ComboBox items
        private class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        // Helper methods to get selected values
        private string GetSelectedEmployeeId()
        {
            return cbEmployee.SelectedItem != null ? ((ComboboxItem)cbEmployee.SelectedItem).Value : null;
        }

        private string GetSelectedSupplierId()
        {
            return cbSupplier.SelectedItem != null ? ((ComboboxItem)cbSupplier.SelectedItem).Value : null;
        }

        private void ClearInputs()
        {
            selectedInvoiceId = null;
            if (cbEmployee.Items.Count > 0) cbEmployee.SelectedIndex = 0;
            if (cbSupplier.Items.Count > 0) cbSupplier.SelectedIndex = 0;
            dgridImportInvoiceDetails.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentMode = ActionMode.Add;
            ClearInputs();
            UpdateButtonState();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedInvoiceId))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn nhập cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Edit;
            UpdateButtonState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedInvoiceId))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn nhập cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn nhập này?", "Xác nhận xóa", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = importInvoiceController.DeleteImportInvoice(selectedInvoiceId);
                if (success)
                {
                    MessageBox.Show("Xóa hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadImportInvoices();
                    ClearInputs();
                }
                else 
                {
                    MessageBox.Show("Xóa hóa đơn nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = false;
            string message = "";            switch (currentMode)
            {
                case ActionMode.Add:
                    string newId = Guid.NewGuid().ToString();
                    string employeeId = GetSelectedEmployeeId();
                    string supplierId = GetSelectedSupplierId();
                    
                    if (string.IsNullOrEmpty(employeeId) || string.IsNullOrEmpty(supplierId))
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên và nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    success = importInvoiceController.AddImportInvoice(
                        DateTime.Now,
                        employeeId,
                        supplierId,
                        0 // Tổng tiền mặc định là 0
                    );
                    message = success ? "Thêm hóa đơn nhập thành công!" : "Thêm hóa đơn nhập thất bại!";
                    break;

                case ActionMode.Edit:
                    // TODO: Implement update logic with proper validation
                    success = false; // Replace with actual update logic
                    message = success ? "Cập nhật hóa đơn nhập thành công!" : "Cập nhật hóa đơn nhập thất bại!";
                    break;
            }

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadImportInvoices();
                ClearInputs();
                currentMode = ActionMode.None;
                UpdateButtonState();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
            currentMode = ActionMode.None;
            UpdateButtonState();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var exporter = new Utils.exportExcel();
            if (dgridImportInvoice.Rows.Count > 0)
            {
                // Create DataTable from DataGridView
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dgridImportInvoice.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgridImportInvoice.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                exporter.Export(dt, "DanhSachHoaDonNhap");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
