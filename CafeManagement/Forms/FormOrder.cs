using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms
{
    public partial class FormOrder : Form
    {
        // UI components
        private Panel pnlLeft;
        private Panel pnlRight;
        private Panel pnlTableFilters;
        private Panel pnlTableTypes;
        private FlowLayoutPanel flpTables;
        private TextBox txtSearchTable;
        private Button btnSearch;
        private RadioButton rbAllTables;
        private RadioButton rbInUse;
        private RadioButton rbEmpty;
        private Panel pnlOrderHeader;
        private Panel pnlOrderDetails;
        private Panel pnlOrderFooter;
        private Button btnTakeAway;
        private ListView lvOrderItems;
        private Button btnCheckout;
        private Button btnNotification;
        private Label lblTableInfo;
        private TextBox txtCustomerSearch;
        private Button btnCart;
        private Button btnSettings;

        public FormOrder()
        {
            InitializeCustomComponents();
            LoadTables();
        }

        private void InitializeCustomComponents()
        {
            // Set form properties
            this.Text = "Cafe Management - Order System";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Create main panels
            pnlLeft = new Panel
            {
                Dock = DockStyle.Left,
                Width = this.Width / 2,
                BackColor = Color.WhiteSmoke
            };

            pnlRight = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // Create search panel
            Panel pnlSearch = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(23, 58, 108)
            };

            btnSearch = new Button
            {
                Size = new Size(30, 30),
                Location = new Point(10, 10),
                FlatStyle = FlatStyle.Flat,
                Text = "🔍",
                ForeColor = Color.White
            };
            btnSearch.FlatAppearance.BorderSize = 0;

            txtSearchTable = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(45, 10),
                PlaceholderText = "Tìm món (F3)"
            };

            Button btnNewOrder = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(pnlLeft.Width - 90, 5),
                FlatStyle = FlatStyle.Flat,
                Text = "⚡",
                Font = new Font("Arial", 12),
                ForeColor = Color.White
            };
            btnNewOrder.FlatAppearance.BorderSize = 0;

            Button btnAdd = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(pnlLeft.Width - 50, 5),
                FlatStyle = FlatStyle.Flat,
                Text = "+",
                Font = new Font("Arial", 14),
                ForeColor = Color.White
            };
            btnAdd.FlatAppearance.BorderSize = 0;

            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearchTable);
            pnlSearch.Controls.Add(btnNewOrder);
            pnlSearch.Controls.Add(btnAdd);

            // Create table type filter
            pnlTableTypes = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.White
            };

            string[] tableTypes = { "Tất cả", "Phòng", "Lô", "Líp", "CAFE" };
            int leftOffset = 30;

            foreach (string type in tableTypes)
            {
                Button btnType = new Button
                {
                    Text = type,
                    Location = new Point(leftOffset, 7),
                    Size = new Size(70, 25),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = type == "Tất cả" ? Color.FromArgb(0, 102, 204) : Color.White,
                    ForeColor = type == "Tất cả" ? Color.White : Color.Black,
                    Font = new Font("Arial", 9)
                };
                btnType.FlatAppearance.BorderSize = 0;
                pnlTableTypes.Controls.Add(btnType);
                leftOffset += 80;
            }

            // Create table filter options
            pnlTableFilters = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.WhiteSmoke
            };

            rbAllTables = new RadioButton
            {
                Text = "Tất cả (13)",
                Location = new Point(20, 10),
                AutoSize = true,
                Checked = true
            };

            rbInUse = new RadioButton
            {
                Text = "Sử dụng (2)",
                Location = new Point(135, 10),
                AutoSize = true
            };

            rbEmpty = new RadioButton
            {
                Text = "Còn trống (11)",
                Location = new Point(250, 10),
                AutoSize = true
            };

            pnlTableFilters.Controls.Add(rbAllTables);
            pnlTableFilters.Controls.Add(rbInUse);
            pnlTableFilters.Controls.Add(rbEmpty);

            // Create tables layout
            flpTables = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(15, 10, 15, 10)
            };

            // Add take away button
            btnTakeAway = new Button
            {
                Text = "Mang về",
                Size = new Size(80, 80),
                Margin = new Padding(10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Font = new Font("Arial", 9),
                TextAlign = ContentAlignment.BottomCenter,
                Image = new Bitmap(30, 30) // Placeholder for bag icon
            };
            btnTakeAway.FlatAppearance.BorderColor = Color.LightGray;
            btnTakeAway.ImageAlign = ContentAlignment.TopCenter;
            btnTakeAway.Padding = new Padding(0, 10, 0, 0);

            // Add checkbox at the bottom
            Panel pnlBottom = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 30
            };

            CheckBox chkAutoOpen = new CheckBox
            {
                Text = "Mở thực đơn khi chọn bàn",
                Location = new Point(20, 5),
                AutoSize = true
            };

            pnlBottom.Controls.Add(chkAutoOpen);

            // Add panels to left side
            pnlLeft.Controls.Add(flpTables);
            pnlLeft.Controls.Add(pnlTableFilters);
            pnlLeft.Controls.Add(pnlTableTypes);
            pnlLeft.Controls.Add(pnlSearch);
            pnlLeft.Controls.Add(pnlBottom);

            // Right panel - Order details header
            pnlOrderHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.White
            };

            lblTableInfo = new Label
            {
                Text = "5 / Lô",
                Location = new Point(40, 15),
                Font = new Font("Arial", 11),
                AutoSize = true
            };

            txtCustomerSearch = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(130, 15),
                PlaceholderText = "Tìm khách hàng (F4)"
            };

            Button btnAddCustomer = new Button
            {
                Text = "+",
                Size = new Size(25, 25),
                Location = new Point(335, 15),
                FlatStyle = FlatStyle.Flat
            };

            Button btnTableOption = new Button
            {
                Text = "⯆",
                Size = new Size(25, 25),
                Location = new Point(365, 15),
                FlatStyle = FlatStyle.Flat
            };
            
            btnCart = new Button
            {
                Size = new Size(40, 25),
                Location = new Point(400, 15),
                FlatStyle = FlatStyle.Flat,
                Text = "🛒"
            };

            Button btnMore = new Button
            {
                Size = new Size(30, 25),
                Location = new Point(445, 15),
                FlatStyle = FlatStyle.Flat,
                Text = "⋮"
            };

            pnlOrderHeader.Controls.Add(lblTableInfo);
            pnlOrderHeader.Controls.Add(txtCustomerSearch);
            pnlOrderHeader.Controls.Add(btnAddCustomer);
            pnlOrderHeader.Controls.Add(btnTableOption);
            pnlOrderHeader.Controls.Add(btnCart);
            pnlOrderHeader.Controls.Add(btnMore);

            // Right panel - Order items list
            pnlOrderDetails = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            lvOrderItems = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };

            lvOrderItems.Columns.Add("", 30);
            lvOrderItems.Columns.Add("STT. Tên món", 180);
            lvOrderItems.Columns.Add("SL", 40);
            lvOrderItems.Columns.Add("Đơn giá", 70);
            lvOrderItems.Columns.Add("Thành tiền", 70);

            // Add example items
            ListViewItem item1 = new ListViewItem("");
            item1.SubItems.Add("1. Trà Gừng");
            item1.SubItems.Add("0.017");
            item1.SubItems.Add("60,000");
            item1.SubItems.Add("1,020");
            lvOrderItems.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("");
            item2.SubItems.Add("2. Sting");
            item2.SubItems.Add("3");
            item2.SubItems.Add("15,000");
            item2.SubItems.Add("45,000");
            lvOrderItems.Items.Add(item2);

            pnlOrderDetails.Controls.Add(lvOrderItems);

            // Right panel - Order footer
            pnlOrderFooter = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 120,
                BackColor = Color.WhiteSmoke
            };

            ComboBox cmbServer = new ComboBox
            {
                Text = "Trung",
                Size = new Size(100, 25),
                Location = new Point(15, 15),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbServer.Items.Add("Trung");

            Button btnQuantity = new Button
            {
                Text = "0",
                Size = new Size(30, 25),
                Location = new Point(125, 15),
                FlatStyle = FlatStyle.Flat
            };

            Button btnEdit = new Button
            {
                Text = "✏️",
                Size = new Size(30, 25),
                Location = new Point(160, 15),
                FlatStyle = FlatStyle.Flat
            };

            Button btnRefresh = new Button
            {
                Text = "🔄",
                Size = new Size(30, 25),
                Location = new Point(195, 15),
                FlatStyle = FlatStyle.Flat
            };

            Button btnCalendar = new Button
            {
                Text = "📅",
                Size = new Size(30, 25),
                Location = new Point(230, 15),
                FlatStyle = FlatStyle.Flat
            };

            Button btnPrint = new Button
            {
                Text = "🖨️",
                Size = new Size(30, 25),
                Location = new Point(265, 15),
                FlatStyle = FlatStyle.Flat
            };

            Button btnInvoice = new Button
            {
                Text = "Tách gh",
                Size = new Size(70, 25),
                Location = new Point(300, 15),
                FlatStyle = FlatStyle.Flat
            };

            Panel pnlNotification = new Panel
            {
                Size = new Size(430, 35),
                Location = new Point(15, 45),
                BackColor = Color.FromArgb(220, 255, 220),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblNotification = new Label
            {
                Text = "✓ Bếp đã nhận được thông báo",
                Location = new Point(10, 8),
                AutoSize = true,
                ForeColor = Color.Green
            };

            pnlNotification.Controls.Add(lblNotification);

            btnCheckout = new Button
            {
                Text = "💰 Thanh toán (F9)",
                Size = new Size(200, 35),
                Location = new Point(15, 85),
                BackColor = Color.FromArgb(76, 175, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCheckout.FlatAppearance.BorderSize = 0;

            btnNotification = new Button
            {
                Text = "🔔 Thông báo (F10)",
                Size = new Size(200, 35),
                Location = new Point(225, 85),
                BackColor = Color.FromArgb(100, 149, 237),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnNotification.FlatAppearance.BorderSize = 0;

            pnlOrderFooter.Controls.Add(cmbServer);
            pnlOrderFooter.Controls.Add(btnQuantity);
            pnlOrderFooter.Controls.Add(btnEdit);
            pnlOrderFooter.Controls.Add(btnRefresh);
            pnlOrderFooter.Controls.Add(btnCalendar);
            pnlOrderFooter.Controls.Add(btnPrint);
            pnlOrderFooter.Controls.Add(btnInvoice);
            pnlOrderFooter.Controls.Add(pnlNotification);
            pnlOrderFooter.Controls.Add(btnCheckout);
            pnlOrderFooter.Controls.Add(btnNotification);

            // Add right side panels
            pnlRight.Controls.Add(pnlOrderDetails);
            pnlRight.Controls.Add(pnlOrderHeader);
            pnlRight.Controls.Add(pnlOrderFooter);

            // Add main panels to form
            this.Controls.Add(pnlRight);
            this.Controls.Add(pnlLeft);
        }

        private void LoadTables()
        {
            // Add take away button first
            flpTables.Controls.Add(btnTakeAway);

            // Create normal table buttons
            for (int i = 1; i <= 10; i++)
            {
                Button tableButton = CreateTableButton(i.ToString(), i == 1 || i == 5);
                flpTables.Controls.Add(tableButton);
            }

            // Add custom tables
            Button cfTable1 = CreateTableButton("CF01", false);
            Button cfTable2 = CreateTableButton("CF02", false);
            flpTables.Controls.Add(cfTable1);
            flpTables.Controls.Add(cfTable2);
        }

        private Button CreateTableButton(string text, bool isHighlighted)
        {
            Button btn = new Button
            {
                Text = text,
                Size = new Size(80, 60),
                Margin = new Padding(10),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 11, FontStyle.Bold),
                Tag = text
            };

            if (text == "5")
            {
                btn.BackColor = Color.FromArgb(23, 58, 108);
                btn.ForeColor = Color.White;
            }
            else if (isHighlighted)
            {
                btn.BackColor = Color.FromArgb(173, 216, 230);
            }
            else
            {
                btn.BackColor = Color.White;
            }

            btn.FlatAppearance.BorderColor = Color.LightGray;
            btn.Click += TableButton_Click;
            
            return btn;
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedTable = sender as Button;
            
            // Update UI based on table selection
            if (clickedTable.BackColor != Color.FromArgb(23, 58, 108))
            {
                // Change all highlighted tables back to white
                foreach (Control ctrl in flpTables.Controls)
                {
                    if (ctrl is Button btn && 
                        btn.BackColor == Color.FromArgb(173, 216, 230) &&
                        btn != clickedTable)
                    {
                        btn.BackColor = Color.White;
                    }
                }

                // Highlight clicked table
                clickedTable.BackColor = Color.FromArgb(173, 216, 230);
            }

            // Update order details to show selected table info
            lblTableInfo.Text = $"{clickedTable.Text} / Lô";

            // In a real app, you would load order details for the selected table here
        }
    }
}
