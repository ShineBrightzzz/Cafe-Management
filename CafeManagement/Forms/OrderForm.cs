using System;
using System.Windows.Forms;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public partial class OrderForm : Form
    {
        private Table selectedTable;

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

        private void LoadInvoicePanel()
        {
            InvoicePanel invoicePanel = new InvoicePanel(selectedTable);
            invoicesPanel.Controls.Clear();
            invoicePanel.Controls.Add(invoicePanel);
        }

        private void LoadProductPanel(Table selectedTable)
        {
            ProductPanel productPanel = new ProductPanel(selectedTable);

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }

        private void TablePanel_TableSelected(object sender, Table selectedTable)
        {
            this.selectedTable = selectedTable;
            ProductPanel productPanel = new ProductPanel(selectedTable);

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            LoadTablePanel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadProductPanel(selectedTable);
        }
    }
}
