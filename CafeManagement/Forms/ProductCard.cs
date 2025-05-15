using CafeManagement.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeManagement.Forms
{
    public partial class ProductCard : UserControl
    {
        private Product _product;

        public ProductCard()
        {
            InitializeComponent(); // Dùng khi kéo thả trong Designer
        }

        public ProductCard(Product product)
        {
            InitializeComponent(); // Dùng khi tạo từ code
            _product = product;
            DisplayProduct();
        }

        private void DisplayProduct()
        {
            lblName.Text = _product.getName();
            lblPrice.Text = $"{_product.getSalePrice():N0} đ";

            string imagePath = _product.getImage();
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox.Image = null;
            }
        }
    }

}
