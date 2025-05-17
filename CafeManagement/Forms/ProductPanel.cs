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


            headerPanel.Controls.Add(tableLabel);
            
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
                // Replace existing product display logic with ProductCard
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
       
    }
}
