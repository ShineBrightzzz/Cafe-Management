namespace CafeManagement.Forms.SaleInvoice
{
    partial class SaleInvoicePanel
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
            dgridSaleInvoice = new DataGridView();
            dgridSaleInvoiceDetails = new DataGridView();
            label6 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoiceDetails).BeginInit();
            SuspendLayout();
            // 
            // dgridSaleInvoice
            // 
            dgridSaleInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridSaleInvoice.Location = new Point(97, 155);
            dgridSaleInvoice.Name = "dgridSaleInvoice";
            dgridSaleInvoice.Size = new Size(609, 486);
            dgridSaleInvoice.TabIndex = 33;
            // 
            // dgridSaleInvoiceDetails
            // 
            dgridSaleInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridSaleInvoiceDetails.Location = new Point(759, 155);
            dgridSaleInvoiceDetails.Name = "dgridSaleInvoiceDetails";
            dgridSaleInvoiceDetails.Size = new Size(657, 486);
            dgridSaleInvoiceDetails.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 120);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 35;
            label6.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(184, 117);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 23);
            txtSearch.TabIndex = 34;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(589, 23);
            label3.Name = "label3";
            label3.Size = new Size(317, 45);
            label3.TabIndex = 36;
            label3.Text = "Quản lý hóa đơn bán";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(668, 716);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(113, 48);
            btnExcel.TabIndex = 37;
            btnExcel.Text = "Xuất file excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // SaleInvoicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExcel);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(dgridSaleInvoiceDetails);
            Controls.Add(dgridSaleInvoice);
            Name = "SaleInvoicePanel";
            Size = new Size(1477, 808);
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoiceDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgridSaleInvoice;
        private DataGridView dgridSaleInvoiceDetails;
        private Label label6;
        private TextBox txtSearch;
        private Label label3;
        private Button btnExcel;
    }
}
