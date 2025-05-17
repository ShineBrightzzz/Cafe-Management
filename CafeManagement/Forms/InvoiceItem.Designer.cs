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
            lblQuantity = new Label();
            btnSubtract = new Button();
            btnAdd = new Button();
            lblTotalPrice = new Label();
            lblProductName = new Label();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(270, 15);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(207, 19);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(13, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "1";
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(172, 15);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(29, 27);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(226, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 27);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(406, 19);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(38, 15);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "label1";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(22, 19);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(38, 15);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "label1";
            // 
            // InvoiceItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblProductName);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Name = "InvoiceItem";
            Size = new Size(523, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblQuantity;
        private Button btnSubtract;
        private Button btnAdd;
        private Label lblProduct;
        private Label lblTotalPrice;
        private Label lblProductName;
    }
}
