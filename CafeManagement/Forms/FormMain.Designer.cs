namespace CafeManagement.Forms
{
    partial class FormMain
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
            header = new Panel();
            panel2 = new Panel();
            btnEmployee = new Button();
            btnCustomer = new Button();
            btnSaleInvoice = new Button();
            btnImportInvoice = new Button();
            btnMenu = new Button();
            button1 = new Button();
            mainPanel = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1677, 61);
            header.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 240, 250);
            panel2.Controls.Add(btnEmployee);
            panel2.Controls.Add(btnCustomer);
            panel2.Controls.Add(btnSaleInvoice);
            panel2.Controls.Add(btnImportInvoice);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 808);
            panel2.TabIndex = 1;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = SystemColors.GradientActiveCaption;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Location = new Point(3, 220);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 44);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.GradientActiveCaption;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Location = new Point(3, 176);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(200, 44);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnSaleInvoice
            // 
            btnSaleInvoice.BackColor = SystemColors.GradientActiveCaption;
            btnSaleInvoice.FlatStyle = FlatStyle.Flat;
            btnSaleInvoice.Location = new Point(3, 132);
            btnSaleInvoice.Name = "btnSaleInvoice";
            btnSaleInvoice.Size = new Size(200, 44);
            btnSaleInvoice.TabIndex = 0;
            btnSaleInvoice.Text = "Hóa đơn bán";
            btnSaleInvoice.UseVisualStyleBackColor = false;
            btnSaleInvoice.Click += btnSaleInvoice_Click;
            // 
            // btnImportInvoice
            // 
            btnImportInvoice.BackColor = SystemColors.GradientActiveCaption;
            btnImportInvoice.FlatStyle = FlatStyle.Flat;
            btnImportInvoice.Location = new Point(3, 88);
            btnImportInvoice.Name = "btnImportInvoice";
            btnImportInvoice.Size = new Size(200, 44);
            btnImportInvoice.TabIndex = 0;
            btnImportInvoice.Text = "Hóa đơn nhập";
            btnImportInvoice.UseVisualStyleBackColor = false;
            btnImportInvoice.Click += btnImportInvoice_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.GradientActiveCaption;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(3, 44);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(200, 44);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Thực đơn";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 44);
            button1.TabIndex = 0;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(224, 224, 224);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 61);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1477, 808);
            mainPanel.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1677, 869);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(header);
            Name = "FormMain";
            Text = "FormMain";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel panel2;
        private Button button1;
        private Button btnCustomer;
        private Button btnSaleInvoice;
        private Button btnImportInvoice;
        private Button btnMenu;
        private Button btnEmployee;
        private FlowLayoutPanel mainPanel;
    }
}