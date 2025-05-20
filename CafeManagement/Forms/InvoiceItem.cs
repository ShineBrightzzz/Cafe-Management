using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Entities;
namespace CafeManagement.Forms
{
    public partial class InvoiceItem : UserControl
    {
        private Product _product;
        public event EventHandler QuantityChanged;
        public event EventHandler ItemDeleted; // Add new event for deletion

        public InvoiceItem()
        {
            InitializeComponent();

        }

        public InvoiceItem(Product product)
        {
            InitializeComponent();
            _product = product;
            InitializeInvoiceItem();
        }

        private void InitializeInvoiceItem()
        {
            this.Height = 60;
            this.BackColor = Color.White;
            this.Margin = new Padding(0, 0, 0, 5);
            this.BorderStyle = BorderStyle.None;

            // Add subtle shadow effect using panel
            Panel shadowPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(1),
                Margin = new Padding(5)
            };

            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(10),
                BackColor = Color.WhiteSmoke
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));


            lblProductName.Text = _product.getName();
            lblTotalPrice.Text = $"{_product.getSalePrice():N0} đ";

            txtPrice.Text = $"{_product.getSalePrice():N0} đ";
            txtPrice.Enabled = false;
            shadowPanel.Controls.Add(layout);
            this.Controls.Add(shadowPanel);
        }

        public string GetQuantity()
        {
            return lblQuantity.Text;
        }

        public double GetPrice()
        {
            return _product.getSalePrice();
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void IncreaseQuantity()
        {
            int quantity = Convert.ToInt32(lblQuantity.Text);
            quantity++;
            lblQuantity.Text = quantity.ToString();
            lblTotalPrice.Text = $"{_product.getSalePrice() * quantity:N0} đ";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(lblQuantity.Text);
            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                lblTotalPrice.Text = $"{_product.getSalePrice() * quantity:N0} đ";
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(lblQuantity.Text);
            quantity++;
            lblQuantity.Text = quantity.ToString();

            lblTotalPrice.Text = $"{_product.getSalePrice() * quantity:N0} đ";
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDeleted?.Invoke(this, EventArgs.Empty); // Notify listeners about deletion
            this.Parent?.Controls.Remove(this); // Remove this control from its parent
        }

        private void InvoiceItem_Load(object sender, EventArgs e)
        {

        }
    }
}
