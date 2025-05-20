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
            panel2 = new Panel();
            lblTotal = new Label();
            btnPayment = new Button();
            panel2.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnPayment);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(360, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 697);
            panel2.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 600);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(114, 21);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng tiền: 0 đ";
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(178, 647);
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
            Controls.Add(panel2);
            Controls.Add(itemPanel);
            Controls.Add(panel1);
            Name = "PaymentForm";
            Text = "Thanh toán";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView itemPanel;
        private Panel panel2;
        private Button btnPayment;
        private Label lblTotal;
    }
}