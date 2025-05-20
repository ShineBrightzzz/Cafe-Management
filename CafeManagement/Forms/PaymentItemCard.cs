using System;
using System.Drawing;
using System.Windows.Forms;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public class PaymentItemCard : Panel
    {
        private Label lblProductName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblSubtotal;

        private Product _product;
        private int _quantity;
        private double _price;

        public PaymentItemCard(string productName, int quantity, double price)
        {
            _quantity = quantity;
            _price = price;

            InitializeComponents();
            UpdateLabels(productName, quantity, price);
        }

        private void InitializeComponents()
        {
            this.Size = new Size(300, 100);
            this.BackColor = Color.White;
            this.Margin = new Padding(10);

            // Product name
            lblProductName = new Label
            {
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Quantity
            lblQuantity = new Label
            {
                Font = new Font("Arial", 10),
                Location = new Point(10, 35),
                AutoSize = true
            };

            // Price
            lblPrice = new Label
            {
                Font = new Font("Arial", 10),
                Location = new Point(10, 60),
                AutoSize = true
            };

            // Subtotal
            lblSubtotal = new Label
            {
                Font = new Font("Arial", 11, FontStyle.Bold),
                Location = new Point(150, 60),
                AutoSize = true
            };

            this.Controls.AddRange(new Control[] { lblProductName, lblQuantity, lblPrice, lblSubtotal });

            // Add border
            this.Paint += (sender, e) =>
            {
                var p = sender as Panel;
                e.Graphics.DrawRectangle(new Pen(Color.LightGray, 1), 0, 0, p.Width - 1, p.Height - 1);
            };
        }

        private void UpdateLabels(string productName, int quantity, double price)
        {
            lblProductName.Text = productName;
            lblQuantity.Text = $"Số lượng: {quantity}";
            lblPrice.Text = $"Đơn giá: {price:N0} đ";
            lblSubtotal.Text = $"Thành tiền: {(quantity * price):N0} đ";
        }
    }
}
