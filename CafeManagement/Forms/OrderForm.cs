using System;
using System.Windows.Forms;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public partial class OrderForm : Form
    {
        private Table selectedTable;
        private InvoicePanel invoicePanel;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTablePanel();
            LoadInvoicePanel();
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
            if (selectedTable != null)
            {
                invoicePanel = new InvoicePanel(selectedTable);
                invoicesPanel.Controls.Clear();
                invoicesPanel.Controls.Add(invoicePanel);
            }
        }

        private void LoadProductPanel(Table selectedTable)
        {
            ProductPanelOrder productPanel = new ProductPanelOrder(selectedTable);
            productPanel.ProductSelected += ProductPanel_ProductSelected;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }

        private void TablePanel_TableSelected(object sender, Table selectedTable)
        {
            this.selectedTable = selectedTable;
            LoadProductPanel(selectedTable);
            LoadInvoicePanel();
        }

        private void ProductPanel_ProductSelected(Product selectedProduct)
        {
            if (invoicePanel != null && selectedProduct != null)
            {
                invoicePanel.AddProduct(selectedProduct);
            }
        }        private void btnTable_Click(object sender, EventArgs e)
        {
            this.selectedTable = null;
            LoadTablePanel();
            LoadInvoicePanel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                LoadProductPanel(selectedTable);
            }
        }
    }
}
