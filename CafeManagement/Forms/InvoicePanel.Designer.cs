namespace CafeManagement.Forms
{
    partial class InvoicePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTotalPrice = new Label();
            button2 = new Button();
            btnPayment = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnPayment);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 618);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 143);
            panel1.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.FromArgb(51, 51, 51);
            lblTotalPrice.Location = new Point(22, 31);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(114, 19);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "Tổng tiền: 0 đ";
            // 
            // button2
            // 
            button2.Location = new Point(326, 81);
            button2.Name = "button2";
            button2.Size = new Size(178, 46);
            button2.TabIndex = 0;
            button2.Text = "Thông báo";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(22, 81);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(178, 46);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(523, 618);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // InvoicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "InvoicePanel";
            Size = new Size(523, 761);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnPayment;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTotalPrice;
    }
}
