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
            panel1 = new Panel();
            panelSidebar = new Panel();
            button7 = new Button();
            btnCustomer = new Button();
            btnSaleInvoice = new Button();
            btnHoaDonNhap = new Button();
            button3 = new Button();
            btnMenu = new Button();
            button1 = new Button();
            mainPanel = new FlowLayoutPanel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 103);
            panel1.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(button7);
            panelSidebar.Controls.Add(btnCustomer);
            panelSidebar.Controls.Add(btnSaleInvoice);
            panelSidebar.Controls.Add(btnHoaDonNhap);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(btnMenu);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 103);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(229, 941);
            panelSidebar.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(0, 427);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(229, 59);
            button7.TabIndex = 0;
            button7.Text = "Nhân viên";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(0, 360);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(229, 59);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnSaleInvoice
            // 
            btnSaleInvoice.Location = new Point(0, 281);
            btnSaleInvoice.Margin = new Padding(3, 4, 3, 4);
            btnSaleInvoice.Name = "btnSaleInvoice";
            btnSaleInvoice.Size = new Size(229, 59);
            btnSaleInvoice.TabIndex = 0;
            btnSaleInvoice.Text = "Hóa đơn bán";
            btnSaleInvoice.UseVisualStyleBackColor = true;
            btnSaleInvoice.Click += btnSaleInvoice_Click;
            // 
            // btnHoaDonNhap
            // 
            btnHoaDonNhap.Location = new Point(0, 200);
            btnHoaDonNhap.Margin = new Padding(3, 4, 3, 4);
            btnHoaDonNhap.Name = "btnHoaDonNhap";
            btnHoaDonNhap.Size = new Size(229, 59);
            btnHoaDonNhap.TabIndex = 0;
            btnHoaDonNhap.Text = "Hóa đơn nhập";
            btnHoaDonNhap.UseVisualStyleBackColor = true;
            btnHoaDonNhap.Click += btnHoaDonNhap_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 133);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(229, 59);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(0, 67);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(229, 59);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Thực đơn";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(229, 59);
            button1.TabIndex = 0;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(229, 103);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1012, 941);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 1044);
            Controls.Add(mainPanel);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSidebar;
        private Button button1;
        private Button btnCustomer;
        private Button btnSaleInvoice;
        private Button btnHoaDonNhap;
        private Button button3;
        private Button btnMenu;
        private Button button7;
        private FlowLayoutPanel mainPanel;
    }
}