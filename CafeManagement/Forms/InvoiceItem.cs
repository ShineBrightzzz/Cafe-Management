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

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(lblQuantity.Text);
            quantity--;
            lblQuantity.Text = quantity.ToString();
            lblTotalPrice.Text = $"{_product.getSalePrice() * quantity:N0} đ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(lblQuantity.Text);
            quantity++;
            lblQuantity.Text = quantity.ToString();
            
            lblTotalPrice.Text = $"{_product.getSalePrice() * quantity:N0} đ";
        }
    }
}
