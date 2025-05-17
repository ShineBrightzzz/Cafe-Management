namespace CafeManagement.Forms
{
    partial class InvoiceItem
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
            txtPrice = new TextBox();
            lblPrice = new Label();
            label1 = new Label();
            btnSubtract = new Button();
            btnAdd = new Button();
            lblProduct = new Label();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(270, 15);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(420, 19);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 19);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 3;
            label1.Text = "2";
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(119, 15);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(29, 27);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(202, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 27);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(16, 22);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(38, 15);
            lblProduct.TabIndex = 5;
            lblProduct.Text = "label2";
            // 
            // InvoiceItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(label1);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Name = "InvoiceItem";
            Size = new Size(482, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrice;
        private Label lblPrice;
        private Label label1;
        private Button btnSubtract;
        private Button btnAdd;
        private Label lblProduct;
    }
}
