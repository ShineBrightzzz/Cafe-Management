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

namespace CafeManagement.Forms.Customer
{
    public partial class CustomerPanel : UserControl
    {
        private readonly CustomerController customerController;
        private string selectedCustomerId;
        private ActionMode currentMode = ActionMode.None;

        private enum ActionMode
        {
            None,
            Add,
            Edit,
            Delete
        }        public CustomerPanel()
        {
            InitializeComponent();
            customerController = new CustomerController();

            // Thiết lập định dạng cho ô nhập số điện thoại
            mtxtPhone.Mask = "0000000000";
            mtxtPhone.ValidatingType = typeof(string);
            
            // Đăng ký sự kiện click cho DataGridView
            dgidCustomer.CellClick += new DataGridViewCellEventHandler(dgidCustomer_CellClick);

            LoadCustomers();
            UpdateButtonState();
        }        private void UpdateButtonState()
        {
            // Default state (no action in progress)
            if (currentMode == ActionMode.None)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false; 
                dgidCustomer.Enabled = true;
                
                // Disable input controls when no action is in progress
                txtName.Enabled = false;
                mtxtPhone.Enabled = false;
            }
            // Add/Edit/Delete action in progress
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                dgidCustomer.Enabled = false;

                // Enable input controls when adding or editing
                txtName.Enabled = true;
                mtxtPhone.Enabled = true;
            }
        }

        private void LoadCustomers()
        {
            FormatDataGridView();
            var customers = customerController.GetAllCustomers();
            if (customers != null)
            {
                // Tạo DataTable mới
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Phone", typeof(string));                // Thêm dữ liệu vào DataTable
                foreach (var customer in customers)
                {
                    dt.Rows.Add(customer.getId(), customer.getName(), customer.getPhoneNumber());
                }

                // Gán DataTable làm DataSource
                dgidCustomer.DataSource = dt;
                ResizeColumns();
            }
        }

        private void ResizeColumns()
        {
            if (dgidCustomer == null || dgidCustomer.Columns.Count == 0)
                return;

            // Tính toán tổng chiều rộng khả dụng cho DataGridView
            int totalWidth = dgidCustomer.ClientSize.Width;

            // Thiết lập tỷ lệ cho từng cột bằng tên cột
            dgidCustomer.Columns["Id"].Width = (int)(totalWidth * 0.2); // 20%
            dgidCustomer.Columns["Name"].Width = (int)(totalWidth * 0.5); // 50%
            dgidCustomer.Columns["Phone"].Width = (int)(totalWidth * 0.3); // 30%
        }

        private void FormatDataGridView()
        {
            dgidCustomer.AutoGenerateColumns = false;
            dgidCustomer.AllowUserToAddRows = false; // Thêm dòng này để loại bỏ dòng trống

            if (dgidCustomer.Columns.Count == 0)
            {
                // Thêm cột ID
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.Name = "Id";
                colId.DataPropertyName = "Id";
                colId.HeaderText = "Mã KH";
                dgidCustomer.Columns.Add(colId);

                // Thêm cột Tên
                DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
                colName.Name = "Name";
                colName.DataPropertyName = "Name";
                colName.HeaderText = "Tên khách hàng";
                dgidCustomer.Columns.Add(colName);

                // Thêm cột Số điện thoại
                DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                colPhone.Name = "Phone";
                colPhone.DataPropertyName = "Phone";
                colPhone.HeaderText = "Số điện thoại";
                dgidCustomer.Columns.Add(colPhone);
            }

            // Định dạng header
            dgidCustomer.EnableHeadersVisualStyles = false;
            dgidCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgidCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgidCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgidCustomer.ColumnHeadersHeight = 40;

            // Định dạng các dòng dữ liệu
            dgidCustomer.BackgroundColor = Color.White;
            dgidCustomer.DefaultCellStyle.BackColor = Color.White;
            dgidCustomer.DefaultCellStyle.ForeColor = Color.Black;
            dgidCustomer.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgidCustomer.RowTemplate.Height = 35;
            dgidCustomer.GridColor = Color.LightGray;
            dgidCustomer.BorderStyle = BorderStyle.Fixed3D;
            dgidCustomer.ReadOnly = true;
            dgidCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Định dạng màu khi chọn dòng
            dgidCustomer.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgidCustomer.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Tự động điều chỉnh kích thước cột
            ResizeColumns();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeColumns();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var customers = customerController.GetCustomerByName(searchText);
                dgidCustomer.DataSource = customers;
            }
            else
            {
                LoadCustomers();
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
            if (string.IsNullOrEmpty(selectedCustomerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Edit;
            UpdateButtonState();
        }        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCustomerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                bool success = customerController.DeleteCustomer(selectedCustomerId);
                if (success)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(mtxtPhone.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            // Kiểm tra định dạng số điện thoại
            string phoneNumber = string.Join("", mtxtPhone.Text.Where(char.IsDigit));
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = false;
            string message = "";            switch (currentMode)
            {                case ActionMode.Add:
                    string newId = Guid.NewGuid().ToString();
                    success = customerController.AddCustomer(newId, txtName.Text.Trim(), phoneNumber);
                    message = success ? "Thêm khách hàng thành công!" : "Thêm khách hàng thất bại!";
                    break;                case ActionMode.Edit:
                    success = customerController.UpdateCustomer(selectedCustomerId, txtName.Text.Trim(), phoneNumber);
                    message = success ? "Cập nhật thông tin khách hàng thành công!" : "Cập nhật thông tin khách hàng thất bại!";
                    break;
            }

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
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
            mtxtPhone.Clear();
            mtxtPhone.Mask = "0000000000";
            selectedCustomerId = null;
        }

        private void dgidCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgidCustomer.Rows.Count)
                {
                    var row = dgidCustomer.Rows[e.RowIndex];
                    if (row?.Cells["Id"]?.Value != null &&
                        row?.Cells["Name"]?.Value != null &&
                        row?.Cells["Phone"]?.Value != null)
                    {
                        selectedCustomerId = row.Cells["Id"].Value.ToString();
                        txtName.Text = row.Cells["Name"].Value.ToString();
                        mtxtPhone.Text = row.Cells["Phone"].Value.ToString();
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
            DataTable dt = (DataTable)dgidCustomer.DataSource;
            if (dt != null)
            {
                exporter.Export(dt, "DanhSachKhachHang");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            
            if (dgidCustomer.DataSource is DataTable dataTable)
            {
                DataView dv = dataTable.DefaultView;
                
                if (string.IsNullOrEmpty(searchText))
                {
                    dv.RowFilter = string.Empty; // Xóa bộ lọc để hiển thị tất cả
                }
                else
                {
                    // Tạo filter để tìm kiếm trên tất cả các cột
                    dv.RowFilter = string.Format("Id LIKE '%{0}%' OR Name LIKE '%{0}%' OR Phone LIKE '%{0}%'",
                        searchText.Replace("'", "''"));  // Escape dấu nháy đơn để tránh lỗi SQL
                }
            }
        }
    }
}
