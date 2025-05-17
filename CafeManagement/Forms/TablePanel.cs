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
        private Color availableColor = Color.LightGreen;
        private Color occupiedColor = Color.LightCoral;

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
        }        
        
        public void LoadTables()
        {
            try 
            {
                tables = tableController.GetAllTables();
                DisplayTables();
                Console.WriteLine($"Tables loaded successfully. Count: {tables?.Count ?? 0}");
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
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 120,
                Height = 30,
                Location = new Point(0, 10),
            };
            tablePanel.Controls.Add(nameLabel);

            // Add status label
            Label statusLabel = new Label
            {
                Text = $"Status: {(table.getIsOccupied() ? "Occupied" : "Available")}",
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 120,
                Height = 20,
                Location = new Point(0, 45),
            };
            tablePanel.Controls.Add(statusLabel);

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
