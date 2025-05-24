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
using CafeManagement.Utils;

namespace CafeManagement.Forms.Supplier
{
    public partial class SupplierPanel : UserControl
    {
        private readonly SupplierController supplierController;
        private string selectedSupplierId;
        private ActionMode currentMode = ActionMode.None;

        private enum ActionMode
        {
            None,
            Add,
            Edit,
            Delete
        }

        public SupplierPanel()
        {
            InitializeComponent();
            supplierController = new SupplierController();

            // Đăng ký sự kiện click cho DataGridView
            dgidSupplier.CellClick += new DataGridViewCellEventHandler(dgidSupplier_CellClick);

            LoadSuppliers();
            UpdateButtonState();
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
                dgidSupplier.Enabled = true;
            }
            // Add/Edit/Delete action in progress
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                dgidSupplier.Enabled = false;
            }
        }

        private void LoadSuppliers()
        {
            FormatDataGridView();
            var suppliers = supplierController.GetAllSuppliers();
            if (suppliers != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Address", typeof(string));

                foreach (var supplier in suppliers)
                {
                    dt.Rows.Add(supplier.getId(), supplier.getName(), supplier.getPhoneNumber(), supplier.getAddress());
                }

                dgidSupplier.DataSource = dt;
                ResizeColumns();
            }
        }

        private void ResizeColumns()
        {
            if (dgidSupplier == null || dgidSupplier.Columns.Count == 0)
                return;

            int totalWidth = dgidSupplier.ClientSize.Width;

            dgidSupplier.Columns["Id"].Width = (int)(totalWidth * 0.15);
            dgidSupplier.Columns["Name"].Width = (int)(totalWidth * 0.35);
            dgidSupplier.Columns["Phone"].Width = (int)(totalWidth * 0.2);
            dgidSupplier.Columns["Address"].Width = (int)(totalWidth * 0.3);
        }

        private void FormatDataGridView()
        {
            dgidSupplier.AutoGenerateColumns = false;
            dgidSupplier.AllowUserToAddRows = false;

            if (dgidSupplier.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.Name = "Id";
                colId.DataPropertyName = "Id";
                colId.HeaderText = "Mã NCC";
                dgidSupplier.Columns.Add(colId);

                DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
                colName.Name = "Name";
                colName.DataPropertyName = "Name";
                colName.HeaderText = "Tên nhà cung cấp";
                dgidSupplier.Columns.Add(colName);

                DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                colPhone.Name = "Phone";
                colPhone.DataPropertyName = "Phone";
                colPhone.HeaderText = "Số điện thoại";
                dgidSupplier.Columns.Add(colPhone);

                DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
                colAddress.Name = "Address";
                colAddress.DataPropertyName = "Address";
                colAddress.HeaderText = "Địa chỉ";
                dgidSupplier.Columns.Add(colAddress);
            }

            // Định dạng header
            dgidSupplier.EnableHeadersVisualStyles = false;
            dgidSupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgidSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgidSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgidSupplier.ColumnHeadersHeight = 40;

            // Định dạng các dòng dữ liệu
            dgidSupplier.BackgroundColor = Color.White;
            dgidSupplier.DefaultCellStyle.BackColor = Color.White;
            dgidSupplier.DefaultCellStyle.ForeColor = Color.Black;
            dgidSupplier.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgidSupplier.RowTemplate.Height = 35;
            dgidSupplier.GridColor = Color.LightGray;
            dgidSupplier.BorderStyle = BorderStyle.Fixed3D;
            dgidSupplier.ReadOnly = true;
            dgidSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Định dạng màu khi chọn dòng
            dgidSupplier.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgidSupplier.DefaultCellStyle.SelectionForeColor = Color.Black;

            ResizeColumns();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeColumns();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            
            if (dgidSupplier.DataSource is DataTable dataTable)
            {
                DataView dv = dataTable.DefaultView;
                
                if (string.IsNullOrEmpty(searchText))
                {
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    dv.RowFilter = string.Format("Id LIKE '%{0}%' OR Name LIKE '%{0}%' OR Phone LIKE '%{0}%' OR Address LIKE '%{0}%'",
                        searchText.Replace("'", "''"));
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentMode = ActionMode.Add;
            ClearInputs();
            UpdateButtonState();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSupplierId))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Edit;
            UpdateButtonState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSupplierId))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                bool success = supplierController.DeleteSupplier(selectedSupplierId);
                if (success)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(mtxtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = false;
            string message = "";

            switch (currentMode)
            {
                case ActionMode.Add:
                    string newId = Guid.NewGuid().ToString();
                    success = supplierController.AddSupplier(newId, txtName.Text.Trim(), mtxtPhone.Text.Trim(), txtAddress.Text.Trim());
                    message = success ? "Thêm nhà cung cấp thành công!" : "Thêm nhà cung cấp thất bại!";
                    break;

                case ActionMode.Edit:
                    success = supplierController.UpdateSupplier(selectedSupplierId, txtName.Text.Trim(), mtxtPhone.Text.Trim(), txtAddress.Text.Trim());
                    message = success ? "Cập nhật thông tin nhà cung cấp thành công!" : "Cập nhật thông tin nhà cung cấp thất bại!";
                    break;
            }

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
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

        private void ClearInputs()
        {
            txtName.Text = string.Empty;
            mtxtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            selectedSupplierId = null;
        }

        private void dgidSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgidSupplier.Rows.Count)
                {
                    var row = dgidSupplier.Rows[e.RowIndex];
                    if (row?.Cells["Id"]?.Value != null &&
                        row?.Cells["Name"]?.Value != null &&
                        row?.Cells["Phone"]?.Value != null &&
                        row?.Cells["Address"]?.Value != null)
                    {
                        selectedSupplierId = row.Cells["Id"].Value.ToString();
                        txtName.Text = row.Cells["Name"].Value.ToString();
                        mtxtPhone.Text = row.Cells["Phone"].Value.ToString();
                        txtAddress.Text = row.Cells["Address"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi chọn dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var exporter = new exportExcel();
            DataTable dt = (DataTable)dgidSupplier.DataSource;
            if (dt != null)
            {
                exporter.Export(dt, "DanhSachNhaCungCap");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
