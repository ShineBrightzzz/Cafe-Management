using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafeManagement.Controllers;
using CafeManagement.Entities;
using CafeManagement.Utils;

namespace CafeManagement.Forms.ProductManagement
{
    public partial class ProductPanel : UserControl
    {
        private readonly ProductController productController;
        private readonly ProductTypeController typeController;
        private string selectedProductId;
        private ActionMode currentMode = ActionMode.None;

        private enum ActionMode
        {
            None,
            Add,
            Edit,
            Delete
        }

        public ProductPanel()
        {
            InitializeComponent();
            productController = new ProductController();
            typeController = new ProductTypeController();

            dgridProduct.CellClick += dgidProduct_CellClick;
            LoadProductTypes();
            LoadProducts();
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
                dgridProduct.Enabled = true;
            }
            // Add/Edit/Delete action in progress
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                dgridProduct.Enabled = false;
            }
        }

        private void LoadProductTypes()
        {
            try
            {
                var types = typeController.GetAllProductTypes();
                if (types != null && types.Any())
                {
                    cbType.DataSource = types;
                    cbType.DisplayMember = "name";
                    cbType.ValueMember = "id";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu loại sản phẩm.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách loại sản phẩm: {ex.Message}",
                    "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                FormatDataGridView();
                var products = productController.GetAllProducts();
                if (products != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("id", typeof(string));
                    dt.Columns.Add("name", typeof(string));
                    dt.Columns.Add("type", typeof(string));
                    dt.Columns.Add("import_price", typeof(double));
                    dt.Columns.Add("sale_price", typeof(double));

                    var allTypes = typeController.GetAllProductTypes();
                    foreach (var product in products)
                    {
                        var type = allTypes.FirstOrDefault(t => t.getId() == product.getType());
                        dt.Rows.Add(
                            product.getId(),
                            product.getName(),
                            type?.getName(),
                            product.getImportPrice(),
                            product.getSalePrice()
                        );
                    }

                    dgridProduct.DataSource = dt;
                    ResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sản phẩm: {ex.Message}",
                    "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dgridProduct.AutoGenerateColumns = false;
            dgridProduct.AllowUserToAddRows = false;

            if (dgridProduct.Columns.Count == 0)
            {
                dgridProduct.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    DataPropertyName = "id",
                    HeaderText = "Mã SP"
                });
                dgridProduct.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "name",
                    DataPropertyName = "name",
                    HeaderText = "Tên SP"
                });
                dgridProduct.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "type",
                    DataPropertyName = "type",
                    HeaderText = "Loại SP"
                });
                dgridProduct.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "import_price",
                    DataPropertyName = "import_price",
                    HeaderText = "Giá nhập"
                });
                dgridProduct.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "sale_price",
                    DataPropertyName = "sale_price",
                    HeaderText = "Giá bán"
                });
            }

            // Định dạng header
            dgridProduct.EnableHeadersVisualStyles = false;
            dgridProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgridProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgridProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgridProduct.ColumnHeadersHeight = 40;

            // Định dạng các dòng dữ liệu
            dgridProduct.BackgroundColor = Color.White;
            dgridProduct.DefaultCellStyle.BackColor = Color.White;
            dgridProduct.DefaultCellStyle.ForeColor = Color.Black;
            dgridProduct.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgridProduct.RowTemplate.Height = 35;
            dgridProduct.GridColor = Color.LightGray;
            dgridProduct.BorderStyle = BorderStyle.Fixed3D;
            dgridProduct.ReadOnly = true;
            dgridProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Định dạng màu khi chọn dòng
            dgridProduct.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgridProduct.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void ResizeColumns()
        {
            if (dgridProduct.Columns.Count == 0) return;
            int total = dgridProduct.ClientSize.Width;
            dgridProduct.Columns["id"].Width = (int)(total * 0.1);
            dgridProduct.Columns["name"].Width = (int)(total * 0.25);
            dgridProduct.Columns["type"].Width = (int)(total * 0.2);
            dgridProduct.Columns["import_price"].Width = (int)(total * 0.2);
            dgridProduct.Columns["sale_price"].Width = (int)(total * 0.2);
        }

        private void dgidProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgridProduct.Rows.Count)
                {
                    var row = dgridProduct.Rows[e.RowIndex];
                    if (row?.Cells["id"]?.Value == null) return;

                    selectedProductId = row.Cells["id"].Value.ToString();
                    txtName.Text = row.Cells["name"].Value?.ToString() ?? string.Empty;
                    txtImportPrice.Text = row.Cells["import_price"].Value?.ToString() ?? string.Empty;
                    txtSalePrice.Text = row.Cells["sale_price"].Value?.ToString() ?? string.Empty;

                    // Tìm loại sản phẩm theo tên hiển thị
                    string typeName = row.Cells["type"].Value?.ToString();
                    if (!string.IsNullOrEmpty(typeName))
                    {
                        for (int i = 0; i < cbType.Items.Count; i++)
                        {
                            var item = (ProductType)cbType.Items[i];
                            if (item.getName() == typeName)
                            {
                                cbType.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi chọn sản phẩm: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            cbType.SelectedIndex = 0;
            txtImportPrice.Text = "";
            txtSalePrice.Text = "";
            selectedProductId = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentMode = ActionMode.Add;
            ClearInputs();
            UpdateButtonState();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductId))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Edit;
            UpdateButtonState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductId))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMode = ActionMode.Delete;
            UpdateButtonState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || cbType.SelectedValue == null ||
                string.IsNullOrEmpty(txtImportPrice.Text) || string.IsNullOrEmpty(txtSalePrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = false;
            string message = "";

            if (!double.TryParse(txtImportPrice.Text, out double importPrice) ||
                !double.TryParse(txtSalePrice.Text, out double salePrice))
            {
                MessageBox.Show("Giá nhập hoặc giá bán không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string typeId = cbType.SelectedValue.ToString();

            switch (currentMode)
            {
                case ActionMode.Add:
                    string newId = Guid.NewGuid().ToString();
                    success = productController.AddProduct(newId, txtName.Text.Trim(), typeId,
                        importPrice, salePrice, null); // passing null for image parameter
                    message = success ? "Thêm sản phẩm thành công!" : "Thêm sản phẩm thất bại!";
                    break;

                case ActionMode.Edit:
                    success = productController.UpdateProduct(selectedProductId, txtName.Text.Trim(), typeId,
                        importPrice, salePrice, null); // passing null for image parameter
                    message = success ? "Cập nhật thông tin sản phẩm thành công!" : "Cập nhật thông tin sản phẩm thất bại!";
                    break;

                case ActionMode.Delete:
                    success = productController.DeleteProduct(selectedProductId);
                    message = success ? "Xóa sản phẩm thành công!" : "Xóa sản phẩm thất bại!";
                    break;
            }

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
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
            DataTable dt = (DataTable)dgridProduct.DataSource;
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
