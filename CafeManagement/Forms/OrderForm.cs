using System;
using System.Windows.Forms;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTablePanel();
        }

        private void LoadTablePanel()
        {
            TablePanel tablePanel = new TablePanel();
            tablePanel.TableSelected += TablePanel_TableSelected;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(tablePanel);
        }

        private void TablePanel_TableSelected(object sender, Table selectedTable)
        {
            ProductPanel productPanel = new ProductPanel(selectedTable);

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }
    }
}
