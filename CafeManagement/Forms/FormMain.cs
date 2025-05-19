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
using CafeManagement.Forms.Customer;
using CafeManagement.Forms.Employee;
using CafeManagement.Forms.ProductManagement;

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
            ProductPanel productPanel = new ProductPanel();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CustomerPanel customerPanel = new Customer.CustomerPanel();
            mainPanel.Controls.Add(customerPanel);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            EmployeePanel employeePanel = new EmployeePanel();
            mainPanel.Controls.Add(employeePanel);
        }
    }
}
