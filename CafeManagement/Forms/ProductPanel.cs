using System;
using System.Drawing;
using System.Windows.Forms;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public partial class ProductPanel : UserControl
    {
        private Table selectedTable;
        
        public ProductPanel(Table table)
        {
            InitializeComponent();
            selectedTable = table;
            InitializeProductPanel();
        }

        private void InitializeProductPanel()
        {
            MessageBox.Show($"{selectedTable.getName()}");
            Label label = new Label
            {
                Dock = DockStyle.Top,
                Text = $"You selected: {selectedTable.getName()}",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.Controls.Add(label);

        }
    }
}
