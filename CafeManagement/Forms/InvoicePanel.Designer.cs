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
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTotalPrice = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 618);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 143);
            panel1.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(22, 81);
            button1.Name = "button1";
            button1.Size = new Size(178, 46);
            button1.TabIndex = 0;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(523, 618);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(278, 31);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(38, 15);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "label1";
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
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTotalPrice;
    }
}
