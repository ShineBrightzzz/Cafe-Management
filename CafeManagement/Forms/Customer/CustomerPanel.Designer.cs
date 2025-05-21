namespace CafeManagement.Forms.Customer
{
    partial class CustomerPanel
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
            dgidCustomer = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgidCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgidCustomer
            // 
            dgidCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgidCustomer.Location = new Point(371, 100);
            dgidCustomer.Name = "dgidCustomer";
            dgidCustomer.Size = new Size(743, 408);
            dgidCustomer.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(419, 645);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(581, 645);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(742, 645);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(670, 532);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 23);
            txtName.TabIndex = 4;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(670, 583);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(274, 23);
            mtxtPhone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 535);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 7;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(545, 583);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(917, 645);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(113, 50);
            btnExcel.TabIndex = 8;
            btnExcel.Text = "Xuất file excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExcel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtxtPhone);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgidCustomer);
            Name = "CustomerPanel";
            Size = new Size(1477, 808);
            ((System.ComponentModel.ISupportInitialize)dgidCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgidCustomer;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtName;
        private MaskedTextBox mtxtPhone;
        private Label label1;
        private Label label2;
        private Button btnExcel;
    }
}
