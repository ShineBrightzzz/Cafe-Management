using System;
using System.Collections.Generic;
using System.Drawing;
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

        private Color availableColor = Color.LightGreen;
        private Color occupiedColor = Color.LightCoral;

        public event EventHandler<Table> TableSelected;

        public TablePanel()
        {
            InitializeComponent();
            InitializeTablePanel();
            tableController = new TableController();
            LoadTables();
        }

        private void InitializeTablePanel()
        {
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
                Button tableButton = CreateTableButtonControl(table);
                tableFlowPanel.Controls.Add(tableButton);
            }
        }

        private Button CreateTableButtonControl(Table table)
        {
            Button tableButton = new Button
            {
                Width = 120,
                Height = 80,
                Margin = new Padding(10),
                BackColor = table.getIsOccupied() ? occupiedColor : availableColor,
                Tag = table,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Text = $"{table.getName()}\nStatus: {(table.getIsOccupied() ? "Occupied" : "Available")}",
                TextAlign = ContentAlignment.MiddleCenter
            };

            tableButton.Click += TableButton_Click;
            return tableButton;
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Table table)
            {
                TableSelected?.Invoke(this, table);
            }
        }

        public void UpdateTableStatus(string tableId, bool isOccupied)
        {
            Table table = tableController.GetTableById(tableId);
            if (table != null)
            {
                table.setIsOccupied(isOccupied);
                tableController.UpdateTable(table.getId(), table.getName(), table.getIsOccupied());
                LoadTables();
            }
        }

        public void FilterTablesByOccupationStatus(bool? isOccupied)
        {
            tables = isOccupied == null
                ? tableController.GetAllTables()
                : tableController.GetTablesByOccupationStatus(isOccupied.Value);

            DisplayTables();
        }
    }
}
