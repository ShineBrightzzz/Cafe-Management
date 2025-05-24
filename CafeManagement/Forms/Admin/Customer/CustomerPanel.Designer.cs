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
            btnSave = new Button();
            txtName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            btnExcel = new Button();
            txtSearch = new TextBox();
            btnCancel = new Button();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgidCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgidCustomer
            // 
            dgidCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgidCustomer.Location = new Point(370, 173);
            dgidCustomer.Name = "dgidCustomer";
            dgidCustomer.Size = new Size(743, 408);
            dgidCustomer.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(305, 715);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(467, 715);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(628, 715);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(784, 715);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 50);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(669, 605);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 23);
            txtName.TabIndex = 4;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(669, 656);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(274, 23);
            mtxtPhone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 608);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 7;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 656);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(1093, 715);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(113, 50);
            btnExcel.TabIndex = 8;
            btnExcel.Text = "Xuất file excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(467, 131);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 23);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(934, 715);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 50);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 139);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(540, 54);
            label3.Name = "label3";
            label3.Size = new Size(300, 45);
            label3.TabIndex = 23;
            label3.Text = "Quản lý khách hàng";
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
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
        private Button btnSave;
        private TextBox txtSearch;
        private Button btnCancel;
        private Label label6;
        private Label label3;
    }
}
