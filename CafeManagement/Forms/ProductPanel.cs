using System;
using System.Drawing;
using System.Windows.Forms;
using CafeManagement.Entities;
using CafeManagement.Controllers;
using System.Collections.Generic;

namespace CafeManagement.Forms
{
    public partial class ProductPanel : UserControl
    {
        private Table selectedTable;
        private ProductController productController;
        private FlowLayoutPanel productsFlowLayout;
        
        public ProductPanel(Table table)
        {
            InitializeComponent();
            selectedTable = table;
            productController = new ProductController();
            InitializeProductPanel();
        }

        private void InitializeProductPanel()
        {
            // Create table header panel
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50
            };

            Label tableLabel = new Label
            {
                Text = $"Bàn: {selectedTable.getName()}",
                Font = new Font("Arial", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left,
                Padding = new Padding(10, 0, 0, 0)
            };

            Button backButton = new Button
            {
                Text = "Quay lại",
                Dock = DockStyle.Right,
                Width = 100,
                Height = 35,
                Margin = new Padding(0, 7, 10, 0),
                FlatStyle = FlatStyle.Flat
            };
            backButton.Click += BackButton_Click;

            headerPanel.Controls.Add(tableLabel);
            headerPanel.Controls.Add(backButton);
            
            // Create products flow layout
            productsFlowLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };

            // Add controls to main panel
            this.Controls.Add(productsFlowLayout);
            this.Controls.Add(headerPanel);
            
            // Load products
            LoadProducts();
        }
        
        private void LoadProducts()
        {
            List<Product> products = productController.GetAllProducts();
            MessageBox.Show($"Có {products.Count} sản phẩm trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (products == null || products.Count == 0)
            {
                Label noProductsLabel = new Label
                {
                    Text = "Không có sản phẩm nào",
                    Font = new Font("Arial", 12),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                productsFlowLayout.Controls.Add(noProductsLabel);
                return;
            }
            
            foreach (Product product in products)
            {
                ProductCard productCard = new ProductCard(product);
                productCard.Width = 180;
                productCard.Height = 220;
                productCard.Margin = new Padding(10);
                productCard.Click += ProductCard_Click;
                productCard.Tag = product;
                
                productsFlowLayout.Controls.Add(productCard);
            }
        }
        
        private void ProductCard_Click(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard && productCard.Tag is Product product)
            {
                MessageBox.Show($"Bạn đã chọn: {product.getName()}\nGiá: {product.getSalePrice():N0} đ", 
                    "Thông tin sản phẩm", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                
                // Ở đây bạn có thể mở form thêm sản phẩm vào hóa đơn hoặc xử lý logic khác
            }
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Trở về bảng chọn bàn
            var parent = this.Parent;
            if (parent != null)
            {
                TablePanel tablePanel = new TablePanel();
                parent.Controls.Clear();
                parent.Controls.Add(tablePanel);
            }
        }
    }
}
