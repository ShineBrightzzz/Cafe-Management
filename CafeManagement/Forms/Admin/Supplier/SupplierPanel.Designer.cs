namespace CafeManagement.Forms.Supplier
{
    partial class SupplierPanel
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
            dgidSupplier = new DataGridView();
            btnCancel = new Button();
            btnSave = new Button();
            btnExcel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            mtxtPhone = new MaskedTextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgidSupplier).BeginInit();
            SuspendLayout();
            // 
            // dgidSupplier
            // 
            dgidSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgidSupplier.Location = new Point(413, 138);
            dgidSupplier.Name = "dgidSupplier";
            dgidSupplier.Size = new Size(658, 368);
            dgidSupplier.TabIndex = 34;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(870, 704);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 50);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(709, 704);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 50);
            btnSave.TabIndex = 40;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(1031, 704);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(117, 50);
            btnExcel.TabIndex = 39;
            btnExcel.Text = "Xuất file excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(547, 704);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 50);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(390, 704);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 50);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(231, 704);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 50);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(691, 572);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 572);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 43;
            label1.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 612);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 44;
            label2.Text = "Số điện thoại";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(691, 612);
            mtxtPhone.Mask = "0000000000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(200, 23);
            mtxtPhone.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 652);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 46;
            label3.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(691, 652);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 92);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 48;
            label6.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(494, 89);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 23);
            txtSearch.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(561, 12);
            label4.Name = "label4";
            label4.Size = new Size(327, 45);
            label4.TabIndex = 49;
            label4.Text = "Quản lý nhà cung cấp";
            // 
            // SupplierPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(mtxtPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnExcel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgidSupplier);
            Name = "SupplierPanel";
            Size = new Size(1477, 808);
            ((System.ComponentModel.ISupportInitialize)dgidSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgidSupplier;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
    }
}
