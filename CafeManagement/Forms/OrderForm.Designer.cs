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
            panel1 = new Panel();
            invoicesPanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTable = new Button();
            btnMenu = new Button();
            mainPanel = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 61);
            panel1.TabIndex = 2;
            // 
            // invoicesPanel
            // 
            invoicesPanel.Dock = DockStyle.Right;
            invoicesPanel.Location = new Point(746, 61);
            invoicesPanel.Name = "invoicesPanel";
            invoicesPanel.Size = new Size(336, 670);
            invoicesPanel.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnTable);
            flowLayoutPanel1.Controls.Add(btnMenu);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(746, 46);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.LightBlue;
            btnTable.FlatAppearance.BorderSize = 0;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnTable.ForeColor = Color.White;
            btnTable.Location = new Point(3, 3);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(154, 37);
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
            btnMenu.Location = new Point(163, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(154, 37);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Thực đơn";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 107);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(746, 624);
            mainPanel.TabIndex = 7;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 731);
            Controls.Add(mainPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(invoicesPanel);
            Controls.Add(panel1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel invoicesPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTable;
        private Button btnMenu;
        private FlowLayoutPanel mainPanel;
    }
}