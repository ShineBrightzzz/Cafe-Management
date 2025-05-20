namespace CafeManagement.Forms
{
    partial class PaymentForm
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
            itemPanel = new ListView();
            paymentPanel = new Panel();
            txtDiscount = new TextBox();
            txtCustomerPayment = new TextBox();
            rdBank = new RadioButton();
            rdCash = new RadioButton();
            txtTotalCustomer = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblTotal = new Label();
            btnPayment = new Button();
            paymentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 56);
            panel1.TabIndex = 0;
            // 
            // itemPanel
            // 
            itemPanel.Dock = DockStyle.Left;
            itemPanel.Location = new Point(0, 56);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(360, 697);
            itemPanel.TabIndex = 4;
            itemPanel.UseCompatibleStateImageBehavior = false;
            itemPanel.View = View.Details;
            // 
            // paymentPanel
            // 
            paymentPanel.Controls.Add(txtDiscount);
            paymentPanel.Controls.Add(txtCustomerPayment);
            paymentPanel.Controls.Add(rdBank);
            paymentPanel.Controls.Add(rdCash);
            paymentPanel.Controls.Add(txtTotalCustomer);
            paymentPanel.Controls.Add(label7);
            paymentPanel.Controls.Add(label4);
            paymentPanel.Controls.Add(label3);
            paymentPanel.Controls.Add(label1);
            paymentPanel.Controls.Add(lblTotal);
            paymentPanel.Controls.Add(btnPayment);
            paymentPanel.Dock = DockStyle.Fill;
            paymentPanel.Location = new Point(360, 56);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(497, 697);
            paymentPanel.TabIndex = 5;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(308, 114);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 4;
            // 
            // txtCustomerPayment
            // 
            txtCustomerPayment.Location = new Point(308, 210);
            txtCustomerPayment.Name = "txtCustomerPayment";
            txtCustomerPayment.Size = new Size(100, 23);
            txtCustomerPayment.TabIndex = 4;
            // 
            // rdBank
            // 
            rdBank.AutoSize = true;
            rdBank.Location = new Point(269, 302);
            rdBank.Name = "rdBank";
            rdBank.Size = new Size(102, 19);
            rdBank.TabIndex = 3;
            rdBank.TabStop = true;
            rdBank.Text = "Chuyển khoản";
            rdBank.UseVisualStyleBackColor = true;
            // 
            // rdCash
            // 
            rdCash.AutoSize = true;
            rdCash.Location = new Point(112, 302);
            rdCash.Name = "rdCash";
            rdCash.Size = new Size(71, 19);
            rdCash.TabIndex = 3;
            rdCash.TabStop = true;
            rdCash.Text = "Tiền mặt";
            rdCash.UseVisualStyleBackColor = true;
            // 
            // txtTotalCustomer
            // 
            txtTotalCustomer.AutoSize = true;
            txtTotalCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalCustomer.Location = new Point(308, 160);
            txtTotalCustomer.Name = "txtTotalCustomer";
            txtTotalCustomer.Size = new Size(63, 25);
            txtTotalCustomer.TabIndex = 2;
            txtTotalCustomer.Text = "label1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(56, 205);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 2;
            label7.Text = "Khách thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(56, 160);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Khách cần trả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(56, 114);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "Giảm giá(%)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(56, 58);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 2;
            label1.Text = "Tổng tiền hàng";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(308, 58);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng tiền: 0 đ";
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(269, 647);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(166, 38);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 753);
            Controls.Add(paymentPanel);
            Controls.Add(itemPanel);
            Controls.Add(panel1);
            Name = "PaymentForm";
            Text = "Thanh toán";
            paymentPanel.ResumeLayout(false);
            paymentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView itemPanel;
        private Panel paymentPanel;
        private Button btnPayment;
        private Label lblTotal;
        private TextBox txtDiscount;
        private TextBox txtCustomerPayment;
        private RadioButton rdBank;
        private RadioButton rdCash;
        private Label txtTotalCustomer;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}