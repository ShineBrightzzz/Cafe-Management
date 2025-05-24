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

            // Enable click events for child controls
            pictureBox.Click += (s, e) => this.OnClick(e);
            lblName.Click += (s, e) => this.OnClick(e);
            lblPrice.Click += (s, e) => this.OnClick(e);
            
            // Set cursor for child controls
            pictureBox.Cursor = Cursors.Hand;
            lblName.Cursor = Cursors.Hand;
            lblPrice.Cursor = Cursors.Hand;

            string imagePath = _product.getImage();            
            try
            {
                // Update default image logic to use a fallback file path
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Use a fallback file path for the default image
                    string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "DefaultProductImage.png");
                    if (File.Exists(defaultImagePath))
                    {
                        pictureBox.Image = Image.FromFile(defaultImagePath);
                    }
                    else
                    {
                        pictureBox.Image = null;
                        pictureBox.BackColor = Color.LightGray;
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {
                // Handle errors if the image cannot be loaded
                pictureBox.Image = null;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.BackColor = Color.LightGray;
            }

            // Ensure consistent alignment and size for labels
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;

            // Set font styles for better visibility
            lblName.Font = new Font("Arial", 10, FontStyle.Bold);
            lblPrice.Font = new Font("Arial", 9, FontStyle.Regular);
        }
    }
}
