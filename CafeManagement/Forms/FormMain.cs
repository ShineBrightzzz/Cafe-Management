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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var products = new List<Product>
            {
                new Product("SP01", "Cà phê đen", "CF", 15000, 20000, "https://caphenguyenchat.vn/wp-content/uploads/2017/07/cafe-sach-giup-ban-song-lau-khoe-manh-hon-cach-nao-3-1024x1024.png"),
                new Product("SP02", "Trà sữa", "TS", 22000, 30000, "Images/trasua.jpg"),
                new Product("SP03", "Sinh tố bơ", "ST", 25000, 35000, "Images/sinhtobo.jpg")
            };

            mainPanel.Controls.Clear();

            foreach (var product in products)
            {
                ProductCard card = new ProductCard(product);
                mainPanel.Controls.Add(card);
            }
        }

    }
}
