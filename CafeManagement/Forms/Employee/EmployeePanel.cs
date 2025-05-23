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

namespace CafeManagement.Forms.Employee
{
    public partial class EmployeePanel : UserControl
    {
        private readonly EmployeeController employeeController;
        private string selectedEmployeeId;
        private ActionMode currentMode = ActionMode.None;

        private enum ActionMode
        {
            None,
            Add,
            Edit,
            Delete
        }

        public EmployeePanel()
        {
            InitializeComponent();
            employeeController = new EmployeeController();

            // Đăng ký sự kiện click cho DataGridView
            dgidEmployee.CellClick += new DataGridViewCellEventHandler(dgidEmployee_CellClick);

            // Thiết lập ComboBox giới tính
            cbGender.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbGender.SelectedIndex = 0;

            // Thiết lập định dạng cho ô nhập ngày sinh
            mtxtDateOfBirth.Mask = "00/00/0000";
            mtxtDateOfBirth.ValidatingType = typeof(DateTime);

            // Thiết lập định dạng cho ô nhập số điện thoại
            mtxtPhone.Mask = "0000000000";
            mtxtPhone.ValidatingType = typeof(string);

            LoadEmployees();
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
                dgidEmployee.Enabled = true;
            }
            // Add/Edit/Delete action in progress
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                dgidEmployee.Enabled = false;
            }
        }

        private void LoadEmployees()
        {
            FormatDataGridView();
            var employees = employeeController.GetAllEmployees();
            if (employees != null)
            {
                // Tạo DataTable mới
                DataTable dt = new DataTable();
                dt.Columns.Add("id", typeof(string));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("address", typeof(string));
                dt.Columns.Add("gender", typeof(string));
                dt.Columns.Add("date_of_birth", typeof(DateTime)); // Đổi tên cột thành date_of_birth
                dt.Columns.Add("phone", typeof(string));

                // Thêm dữ liệu vào DataTable
                foreach (var emp in employees)
                {
                    dt.Rows.Add(
                        emp.getId(),
                        emp.getName(),
                        emp.getAddress(),
                        emp.getGender(),
                        emp.getDateOfBirth(),
                        emp.getPhoneNumber()
                    );
                }

                // Gán DataTable làm DataSource
                dgidEmployee.DataSource = dt;
                ResizeColumns();
            }
        }

        private void FormatDataGridView()
        {
            dgidEmployee.AutoGenerateColumns = false;
            dgidEmployee.AllowUserToAddRows = false;

            if (dgidEmployee.Columns.Count == 0)
            {
                // Thêm các cột
                var colId = new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    DataPropertyName = "id",
                    HeaderText = "Mã NV"
                };
                dgidEmployee.Columns.Add(colId);

                var colName = new DataGridViewTextBoxColumn
                {
                    Name = "name",
                    DataPropertyName = "name",
                    HeaderText = "Tên nhân viên"
                };
                dgidEmployee.Columns.Add(colName);

                var colAddress = new DataGridViewTextBoxColumn
                {
                    Name = "address",
                    DataPropertyName = "address",
                    HeaderText = "Địa chỉ"
                };
                dgidEmployee.Columns.Add(colAddress);

                var colGender = new DataGridViewTextBoxColumn
                {
                    Name = "gender",
                    DataPropertyName = "gender",
                    HeaderText = "Giới tính"
                };
                dgidEmployee.Columns.Add(colGender);

                var colDateOfBirth = new DataGridViewTextBoxColumn
                {
                    Name = "date_of_birth", // Đổi tên cột thành date_of_birth
                    DataPropertyName = "date_of_birth",
                    HeaderText = "Ngày sinh",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "dd/MM/yyyy"
                    }
                };
                dgidEmployee.Columns.Add(colDateOfBirth);

                var colPhone = new DataGridViewTextBoxColumn
                {
                    Name = "phone",
                    DataPropertyName = "phone",
                    HeaderText = "Số điện thoại",
                    ValueType = typeof(string)
                };
                dgidEmployee.Columns.Add(colPhone);
            }

            // Định dạng header
            dgidEmployee.EnableHeadersVisualStyles = false;
            dgidEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgidEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgidEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgidEmployee.ColumnHeadersHeight = 40;

            // Định dạng các dòng dữ liệu
            dgidEmployee.BackgroundColor = Color.White;
            dgidEmployee.DefaultCellStyle.BackColor = Color.White;
            dgidEmployee.DefaultCellStyle.ForeColor = Color.Black;
            dgidEmployee.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgidEmployee.RowTemplate.Height = 35;
            dgidEmployee.GridColor = Color.LightGray;
            dgidEmployee.BorderStyle = BorderStyle.Fixed3D;
            dgidEmployee.ReadOnly = true;
            dgidEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Định dạng màu khi chọn dòng
            dgidEmployee.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgidEmployee.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void ResizeColumns()
        {
            if (dgidEmployee == null || dgidEmployee.Columns.Count == 0)
                return;

            // Tính toán tổng chiều rộng khả dụng cho DataGridView
            int totalWidth = dgidEmployee.ClientSize.Width;

            // Thiết lập tỷ lệ cho từng cột
            dgidEmployee.Columns["id"].Width = (int)(totalWidth * 0.1);        // 10%
            dgidEmployee.Columns["name"].Width = (int)(totalWidth * 0.2);      // 20%
            dgidEmployee.Columns["address"].Width = (int)(totalWidth * 0.25);  // 25%
            dgidEmployee.Columns["gender"].Width = (int)(totalWidth * 0.1);    // 10%
            dgidEmployee.Columns["date_of_birth"].Width = (int)(totalWidth * 0.15); // 15%
            dgidEmployee.Columns["phone"].Width = (int)(totalWidth * 0.2);     // 20%
        }

        private void ClearInputs()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cbGender.SelectedIndex = 0;
            mtxtDateOfBirth.Text = string.Empty;
            mtxtPhone.Text = string.Empty;
            selectedEmployeeId = null;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeColumns();
        }

        private void dgidEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgidEmployee.Rows.Count)
                {
                    var row = dgidEmployee.Rows[e.RowIndex];
                    if (row?.Cells["id"]?.Value != null)
                    {
                        selectedEmployeeId = row.Cells["id"].Value.ToString();
                        txtName.Text = row.Cells["name"].Value.ToString();
                        txtAddress.Text = row.Cells["address"].Value.ToString();
                        cbGender.Text = row.Cells["gender"].Value.ToString();
                        mtxtDateOfBirth.Text = ((DateTime)row.Cells["date_of_birth"].Value).ToString("dd/MM/yyyy"); // Đổi tên cột thành date_of_birth
                        mtxtPhone.Text = row.Cells["phone"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi chọn dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(selectedEmployeeId))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Edit;
            UpdateButtonState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployeeId))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Delete;
            UpdateButtonState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(mtxtPhone.Text) || 
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(mtxtDateOfBirth.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = false;
            string message = "";

            // Validate date of birth
            if (!DateTime.TryParse(mtxtDateOfBirth.Text, out DateTime dateOfBirth))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = cbGender.SelectedItem.ToString();

            switch (currentMode)
            {
                case ActionMode.Add:
                    string newId = Guid.NewGuid().ToString();
                    success = employeeController.AddEmployee(
                        newId,
                        txtName.Text.Trim(),
                        txtAddress.Text.Trim(),
                        gender,
                        dateOfBirth,
                        mtxtPhone.Text.Trim()
                    );
                    message = success ? "Thêm nhân viên thành công!" : "Thêm nhân viên thất bại!";
                    break;

                case ActionMode.Edit:
                    success = employeeController.UpdateEmployee(
                        selectedEmployeeId,
                        txtName.Text.Trim(),
                        txtAddress.Text.Trim(),
                        gender,
                        dateOfBirth,
                        mtxtPhone.Text.Trim()
                    );
                    message = success ? "Cập nhật thông tin nhân viên thành công!" : "Cập nhật thông tin nhân viên thất bại!";
                    break;

                case ActionMode.Delete:
                    success = employeeController.DeleteEmployee(selectedEmployeeId);
                    message = success ? "Xóa nhân viên thành công!" : "Xóa nhân viên thất bại!";
                    break;
            }

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
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
            var exporter = new exportExcel();
            DataTable dt = (DataTable)dgidEmployee.DataSource;
            if (dt != null)
            {
                exporter.Export(dt, "DanhSachKhachHang");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
