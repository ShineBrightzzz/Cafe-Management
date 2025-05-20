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
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(501, 32);
            txtPrice.Margin = new Padding(6, 6, 6, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 39);
            txtPrice.TabIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(384, 41);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(27, 32);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "1";
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(319, 32);
            btnSubtract.Margin = new Padding(6, 6, 6, 6);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(54, 58);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(420, 28);
            btnAdd.Margin = new Padding(6, 6, 6, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(54, 58);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(754, 41);
            lblTotalPrice.Margin = new Padding(6, 0, 6, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(78, 32);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "label1";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(41, 41);
            lblProductName.Margin = new Padding(6, 0, 6, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(78, 32);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "label1";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(893, 32);
            btnDelete.Margin = new Padding(6, 6, 6, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(43, 49);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // InvoiceItem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(lblProductName);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Margin = new Padding(6, 6, 6, 6);
            Name = "InvoiceItem";
            Size = new Size(971, 128);
            Load += InvoiceItem_Load;
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
        private Button btnDelete;
    }
}
