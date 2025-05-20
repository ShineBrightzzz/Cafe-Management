namespace CafeManagement.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTable = new Button();
            btnMenu = new Button();
            invoicesPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            mainPanel = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnTable);
            flowLayoutPanel1.Controls.Add(btnMenu);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 130);
            flowLayoutPanel1.Margin = new Padding(6, 6, 6, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1235, 98);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.LightBlue;
            btnTable.FlatAppearance.BorderSize = 0;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnTable.ForeColor = Color.White;
            btnTable.Location = new Point(6, 6);
            btnTable.Margin = new Padding(6, 6, 6, 6);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(286, 79);
            btnTable.TabIndex = 0;
            btnTable.Text = "Bàn";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.LightBlue;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(304, 6);
            btnMenu.Margin = new Padding(6, 6, 6, 6);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(286, 79);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Thực đơn";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // invoicesPanel
            // 
            invoicesPanel.Dock = DockStyle.Right;
            invoicesPanel.Location = new Point(1235, 130);
            invoicesPanel.Margin = new Padding(6, 6, 6, 6);
            invoicesPanel.Name = "invoicesPanel";
            invoicesPanel.Size = new Size(971, 1624);
            invoicesPanel.TabIndex = 9;
            invoicesPanel.Paint += invoicesPanel_Paint;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2206, 130);
            panel1.TabIndex = 8;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 228);
            mainPanel.Margin = new Padding(6, 6, 6, 6);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1235, 1526);
            mainPanel.TabIndex = 11;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2206, 1754);
            Controls.Add(mainPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(invoicesPanel);
            Controls.Add(panel1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTable;
        private Button btnMenu;
        private FlowLayoutPanel invoicesPanel;
        private Panel panel1;
        private FlowLayoutPanel mainPanel;
    }
}