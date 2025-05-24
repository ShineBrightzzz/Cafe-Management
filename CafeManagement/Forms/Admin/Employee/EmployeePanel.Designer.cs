namespace CafeManagement.Forms.Employee
{
    partial class EmployeePanel
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
            label2 = new Label();
            label1 = new Label();
            mtxtPhone = new MaskedTextBox();
            txtName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            dgidEmployee = new DataGridView();
            txtAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            mtxtDateOfBirth = new MaskedTextBox();
            label5 = new Label();
            cbGender = new ComboBox();
            btnExcel = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgidEmployee).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(783, 623);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 14;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 571);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 15;
            label1.Text = "Tên nhân viên";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(907, 623);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(131, 23);
            mtxtPhone.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(566, 568);
            txtName.Name = "txtName";
            txtName.Size = new Size(131, 23);
            txtName.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(584, 728);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 50);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(427, 728);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 50);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(268, 728);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 50);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(746, 728);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 50);
            btnSave.TabIndex = 18;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(907, 728);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 50);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgidEmployee
            // 
            dgidEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgidEmployee.Location = new Point(410, 136);
            dgidEmployee.Name = "dgidEmployee";
            dgidEmployee.Size = new Size(739, 408);
            dgidEmployee.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(566, 657);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(131, 23);
            txtAddress.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 657);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 15;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 618);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 15;
            label4.Text = "Giới tính";
            // 
            // mtxtDateOfBirth
            // 
            mtxtDateOfBirth.Location = new Point(907, 568);
            mtxtDateOfBirth.Mask = "00/00/0000";
            mtxtDateOfBirth.Name = "mtxtDateOfBirth";
            mtxtDateOfBirth.Size = new Size(131, 23);
            mtxtDateOfBirth.TabIndex = 13;
            mtxtDateOfBirth.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(783, 571);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "Ngày sinh";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(566, 615);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(131, 23);
            cbGender.TabIndex = 16;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(1068, 728);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(117, 50);
            btnExcel.TabIndex = 17;
            btnExcel.Text = "Xuất file excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(496, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 23);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 109);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 21;
            label6.Text = "Tìm kiếm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(584, 32);
            label7.Name = "label7";
            label7.Size = new Size(274, 45);
            label7.TabIndex = 24;
            label7.Text = "Quản lý nhân viên";
            // 
            // EmployeePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnExcel);
            Controls.Add(cbGender);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(mtxtDateOfBirth);
            Controls.Add(txtAddress);
            Controls.Add(mtxtPhone);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgidEmployee);
            Name = "EmployeePanel";
            Size = new Size(1477, 808);
            ((System.ComponentModel.ISupportInitialize)dgidEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private MaskedTextBox mtxtPhone;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSave;
        private Button btnCancel;
        private DataGridView dgidEmployee;
        private TextBox txtAddress;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtxtDateOfBirth;
        private Label label5;
        private ComboBox cbGender;
        private Button btnExcel;
        private TextBox txtSearch;
        private Label label6;
        private Label label7;
    }
}
