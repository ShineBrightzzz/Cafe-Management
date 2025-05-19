namespace CafeManagement.Forms.ProductManagement
{
    partial class ProductPanel
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
            cbType = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgridProduct = new DataGridView();
            txtImportPrice = new TextBox();
            txtSalePrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgridProduct).BeginInit();
            SuspendLayout();
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(162, 494);
            cbType.Name = "cbType";
            cbType.Size = new Size(131, 23);
            cbType.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 450);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 25;
            label5.Text = "Giá mua";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 502);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 26;
            label2.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 497);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 27;
            label4.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 450);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 29;
            label1.Text = "Tên sản phẩm";
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 447);
            txtName.Name = "txtName";
            txtName.Size = new Size(131, 23);
            txtName.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(503, 563);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 50);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(342, 563);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 50);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(180, 563);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 50);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgridProduct
            // 
            dgridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridProduct.Location = new Point(3, 3);
            dgridProduct.Name = "dgridProduct";
            dgridProduct.Size = new Size(739, 408);
            dgridProduct.TabIndex = 17;
            // 
            // txtImportPrice
            // 
            txtImportPrice.Location = new Point(503, 447);
            txtImportPrice.Name = "txtImportPrice";
            txtImportPrice.Size = new Size(131, 23);
            txtImportPrice.TabIndex = 31;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(503, 497);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(131, 23);
            txtSalePrice.TabIndex = 32;
            // 
            // ProductPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSalePrice);
            Controls.Add(txtImportPrice);
            Controls.Add(cbType);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgridProduct);
            Name = "ProductPanel";
            Size = new Size(751, 656);
            ((System.ComponentModel.ISupportInitialize)dgridProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbType;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgridProduct;
        private TextBox txtImportPrice;
        private TextBox txtSalePrice;
    }
}
