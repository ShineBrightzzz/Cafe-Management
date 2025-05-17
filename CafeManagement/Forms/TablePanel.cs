using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Controllers;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public partial class TablePanel : UserControl
    {
        private TableController tableController;
        private List<Table> tables;
        private FlowLayoutPanel tableFlowPanel;

        // Colors for different table statuses
        private Color availableColor = Color.White;
        private Color occupiedColor = Color.LightBlue;

        public event EventHandler<Table> TableSelected;

        public TablePanel()
        {
            InitializeComponent();
            InitializeTablePanel();
            tableController = new TableController();
            
            // Load tables when component is initialized
            LoadTables();
        }

        private void InitializeTablePanel()
        {
            // Create and configure flow layout panel for tables
            tableFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10),
            };

            this.Controls.Add(tableFlowPanel);
        }        public void LoadTables()
        {
            try 
            {
                tables = tableController.GetAllTables();
                if (tables == null || tables.Count == 0)
                {
                    MessageBox.Show("No tables found in database. Please check your database connection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DisplayTables();
                // Debug message removed for production
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tables: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTables()
        {
            tableFlowPanel.Controls.Clear();

            if (tables == null || tables.Count == 0)
            {
                Label noTablesLabel = new Label
                {
                    Text = "No tables found. Please add tables to the database.",
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Margin = new Padding(10),
                };
                tableFlowPanel.Controls.Add(noTablesLabel);
                return;
            }

            foreach (var table in tables)
            {
                Panel tableButton = CreateTableButton(table);
                tableFlowPanel.Controls.Add(tableButton);
            }
        }

        private Panel CreateTableButton(Table table)
        {
            // Create panel to represent a table
            Panel tablePanel = new Panel
            {
                Width = 120,
                Height = 80,
                Margin = new Padding(10),
                BackColor = table.getIsOccupied() ? occupiedColor : availableColor,
                Tag = table,
            };

            // Add table name label
            Label nameLabel = new Label
            {
                Text = table.getName(),
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = tablePanel.Width - 10, // Adjust width to fit within the panel
                Height = 30,
                Location = new Point(5, 10), // Add padding to center the label
                AutoEllipsis = true // Enable ellipsis for long text
            };
            tablePanel.Controls.Add(nameLabel);

            // Update background color logic
            if (table.getIsOccupied())
            {
                tablePanel.BackColor = Color.LightBlue; // Light blue for occupied tables
            }
            else
            {
                tablePanel.BackColor = Color.White; // Default white for empty tables
            }

            // Add click event handler
            tablePanel.Click += TablePanel_Click;

            // Add border
            tablePanel.Paint += (sender, e) => {
                var p = sender as Panel;
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), 0, 0, p.Width - 1, p.Height - 1);
            };

            return tablePanel;
        }

        private void TablePanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel tablePanel && tablePanel.Tag is Table table)
            {
                // Trigger the event for handling table selection
                TableSelected?.Invoke(this, table);
            }
        }

        public void UpdateTableStatus(string tableId, bool isOccupied)
        {
            Table table = tableController.GetTableById(tableId);
            if (table != null)
            {
                table.setIsOccupied(isOccupied);
                tableController.UpdateTable(
                    table.getId(),
                    table.getName(),
                    table.getIsOccupied()
                );
                
                // Refresh display
                LoadTables();
            }
        }

        public void FilterTablesByOccupationStatus(bool? isOccupied)
        {
            if (isOccupied == null)
            {
                tables = tableController.GetAllTables();
            }
            else
            {
                tables = tableController.GetTablesByOccupationStatus(isOccupied.Value);
            }
            DisplayTables();
        }
    }
}
