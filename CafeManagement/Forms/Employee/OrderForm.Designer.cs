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
            btnTable = new Button();
            btnMenu = new Button();
            invoicesPanel = new FlowLayoutPanel();
            header = new Panel();
            panel1 = new Panel();
            mainPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTable
            // 
            btnTable.BackColor = SystemColors.GradientActiveCaption;
            btnTable.FlatAppearance.BorderSize = 0;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnTable.ForeColor = Color.Black;
            btnTable.Location = new Point(25, 6);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(154, 37);
            btnTable.TabIndex = 0;
            btnTable.Text = "Bàn";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.GradientActiveCaption;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(185, 6);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(154, 37);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Thực đơn";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // invoicesPanel
            // 
            invoicesPanel.Dock = DockStyle.Right;
            invoicesPanel.Location = new Point(665, 61);
            invoicesPanel.Name = "invoicesPanel";
            invoicesPanel.Size = new Size(523, 761);
            invoicesPanel.TabIndex = 9;
            // 
            // header
            // 
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1188, 61);
            header.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnTable);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 49);
            panel1.TabIndex = 10;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 110);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(665, 712);
            mainPanel.TabIndex = 11;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 822);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(invoicesPanel);
            Controls.Add(header);
            Name = "OrderForm";
            Text = "Quản lí quán cafe";
            Load += OrderForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTable;
        private Button btnMenu;
        private FlowLayoutPanel invoicesPanel;
        private Panel header;
        private FlowLayoutPanel mainPanel;
        private Panel panel1;
    }
}