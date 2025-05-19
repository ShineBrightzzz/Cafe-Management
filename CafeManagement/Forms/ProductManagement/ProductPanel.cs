using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafeManagement.Controllers;
using CafeManagement.Entities;

namespace CafeManagement.Forms.ProductManagement
{
    public partial class ProductPanel : UserControl
    {
        private readonly ProductController productController;
        private readonly ProductTypeController typeController;
        private string selectedProductId;

        public ProductPanel()
        {
            InitializeComponent();
            productController = new ProductController();
            typeController = new ProductTypeController();

            dgridProduct.CellClick += dgidProduct_CellClick;
            LoadProductTypes();
            LoadProducts();
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
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (cbType.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbType.Focus();
                    return;
                }

                if (!double.TryParse(txtImportPrice.Text, out double importPrice))
                {
                    MessageBox.Show("Giá nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtImportPrice.Focus();
                    return;
                }

                if (!double.TryParse(txtSalePrice.Text, out double salePrice))
                {
                    MessageBox.Show("Giá bán không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalePrice.Focus();
                    return;
                }

                if (importPrice < 0 || salePrice < 0)
                {
                    MessageBox.Show("Giá không thể âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string newId = Guid.NewGuid().ToString();
                    string typeId = ((ProductType)cbType.SelectedItem).getId();

                    bool success = productController.AddProduct(newId, txtName.Text.Trim(), typeId, importPrice, salePrice, null);
                    if (success)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedProductId))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (cbType.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbType.Focus();
                    return;
                }

                if (!double.TryParse(txtImportPrice.Text, out double importPrice))
                {
                    MessageBox.Show("Giá nhập không hợp lệ.", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtImportPrice.Focus();
                    return;
                }

                if (!double.TryParse(txtSalePrice.Text, out double salePrice))
                {
                    MessageBox.Show("Giá bán không hợp lệ.", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalePrice.Focus();
                    return;
                }

                if (importPrice < 0 || salePrice < 0)
                {
                    MessageBox.Show("Giá không thể âm.", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc muốn cập nhật sản phẩm này?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string typeId = ((ProductType)cbType.SelectedItem).getId();

                    bool success = productController.UpdateProduct(selectedProductId, txtName.Text.Trim(), 
                        typeId, importPrice, salePrice, null);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductId))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool success = productController.DeleteProduct(selectedProductId);
                if (success)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
