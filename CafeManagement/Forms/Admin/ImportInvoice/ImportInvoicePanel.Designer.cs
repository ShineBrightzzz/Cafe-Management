using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms.ImportInvoice
{
    partial class ImportInvoicePanel
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
            dgridImportInvoiceDetails = new DataGridView();
            dgridImportInvoice = new DataGridView();
            btnCancel = new Button();
            btnSave = new Button();
            btnExcel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            cbEmployee = new ComboBox();
            cbSupplier = new ComboBox();
            btnSaveDetails = new Button();
            label6 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            ((ISupportInitialize)dgridImportInvoiceDetails).BeginInit();
            ((ISupportInitialize)dgridImportInvoice).BeginInit();
            SuspendLayout();
            // 
            // dgridImportInvoiceDetails
            // 
            dgridImportInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridImportInvoiceDetails.Location = new Point(761, 133);
            dgridImportInvoiceDetails.Name = "dgridImportInvoiceDetails";
            dgridImportInvoiceDetails.Size = new Size(658, 368);
            dgridImportInvoiceDetails.TabIndex = 34;
            // 
            // dgridImportInvoice
            // 
            dgridImportInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridImportInvoice.Location = new Point(73, 133);
            dgridImportInvoice.Name = "dgridImportInvoice";
            dgridImportInvoice.Size = new Size(587, 368);
            dgridImportInvoice.TabIndex = 35;
            dgridImportInvoice.CellClick += dgridImportInvoice_CellClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 567);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 43;
            label2.Text = "Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 624);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 43;
            label3.Text = "Nhà cung cấp";
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(351, 567);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(121, 23);
            cbEmployee.TabIndex = 45;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(350, 624);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(121, 23);
            cbSupplier.TabIndex = 45;
            // 
            // btnSaveDetails
            // 
            btnSaveDetails.Location = new Point(1306, 532);
            btnSaveDetails.Name = "btnSaveDetails";
            btnSaveDetails.Size = new Size(113, 50);
            btnSaveDetails.TabIndex = 46;
            btnSaveDetails.Text = "Lưu chi tiết";
            btnSaveDetails.UseVisualStyleBackColor = true;
            btnSaveDetails.Click += btnSaveDetails_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 87);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 48;
            label6.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(154, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 23);
            txtSearch.TabIndex = 47;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(561, 12);
            label4.Name = "label4";
            label4.Size = new Size(335, 45);
            label4.TabIndex = 49;
            label4.Text = "Quản lý hóa đơn nhập";
            // 
            // ImportInvoicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(btnSaveDetails);
            Controls.Add(cbSupplier);
            Controls.Add(cbEmployee);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnExcel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgridImportInvoiceDetails);
            Controls.Add(dgridImportInvoice);
            Name = "ImportInvoicePanel";
            Size = new Size(1477, 808);
            ((ISupportInitialize)dgridImportInvoiceDetails).EndInit();
            ((ISupportInitialize)dgridImportInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgridImportInvoiceDetails;
        private DataGridView dgridImportInvoice;
        private Button btnCancel;
        private Button btnSave;
        private Button btnExcel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private ComboBox cbEmployee;
        private ComboBox cbSupplier;
        private Button btnSaveDetails;
        private Label label6;
        private TextBox txtSearch;
        private Label label4;
    }
}
