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
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        public ProductCard(Product product)
        {
            InitializeComponent();
            _product = product;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.White;
            
            // Thêm sự kiện hover
            this.MouseEnter += ProductCard_MouseEnter;
            this.MouseLeave += ProductCard_MouseLeave;
            
            DisplayProduct();
        }

        private void ProductCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 230, 230);
        }

        private void ProductCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void DisplayProduct()
        {
            lblName.Text = _product.getName();
            lblPrice.Text = $"{_product.getSalePrice():N0} đ";

            string imagePath = _product.getImage();            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Hiển thị một hình ảnh mặc định khi không có ảnh
                    pictureBox.Image = null;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.BackColor = Color.LightGray;
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu không thể tải hình ảnh
                pictureBox.Image = null;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.BackColor = Color.LightGray;
            }
        }
    }
}
