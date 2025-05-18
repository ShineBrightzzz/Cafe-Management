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
using CafeManagement.Forms.Employee;

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
                new Product("SP01", "Cà phê đen", "CF", 15000, 20000, 10, "https://caphenguyenchat.vn/wp-content/uploads/2017/07/cafe-sach-giup-ban-song-lau-khoe-manh-hon-cach-nao-3-1024x1024.png"),
                new Product("SP02", "Trà sữa", "TS", 22000, 30000, 5, "Images/trasua.jpg"),
                new Product("SP03", "Sinh tố bơ", "ST", 25000, 35000, 8, "Images/sinhtobo.jpg")
            };

            mainPanel.Controls.Clear();

            foreach (var product in products)
            {
                ProductCard card = new ProductCard(product);
                mainPanel.Controls.Add(card);
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerPanel customerPanel = new CustomerPanel();
            mainPanel.Controls.Clear();

            customerPanel.Margin = new Padding(10, 0, 0, 0);
            //customerPanel.Location = new Point(panelSidebar.Right, 0);
            //customerPanel.Size = new Size(this.mainPanel.Width - panelSidebar.Width, this.mainPanel.Height);
            //customerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.Resize += (s, e) =>
            //{
            //    customerPanel.Size = new Size(this.mainPanel.Width - panelSidebar.Width, this.mainPanel.Height);
            //};

            customerPanel.BringToFront();
            mainPanel.Controls.Add(customerPanel);

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeePanel employeePanel = new EmployeePanel();
            mainPanel.Controls.Clear();
            employeePanel.Margin = new Padding(10, 0, 0, 0);
            employeePanel.BringToFront();
            mainPanel.Controls.Add(employeePanel);
        }
    }
}
