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
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoiceDetails).BeginInit();
            SuspendLayout();
            // 
            // dgridSaleInvoice
            // 
            dgridSaleInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridSaleInvoice.Location = new Point(108, 76);
            dgridSaleInvoice.Name = "dgridSaleInvoice";
            dgridSaleInvoice.Size = new Size(739, 250);
            dgridSaleInvoice.TabIndex = 33;
            // 
            // dgridSaleInvoiceDetails
            // 
            dgridSaleInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridSaleInvoiceDetails.Location = new Point(108, 433);
            dgridSaleInvoiceDetails.Name = "dgridSaleInvoiceDetails";
            dgridSaleInvoiceDetails.Size = new Size(739, 250);
            dgridSaleInvoiceDetails.TabIndex = 33;
            // 
            // SaleInvoicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgridSaleInvoiceDetails);
            Controls.Add(dgridSaleInvoice);
            Name = "SaleInvoicePanel";
            Size = new Size(988, 761);
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgridSaleInvoiceDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgridSaleInvoice;
        private DataGridView dgridSaleInvoiceDetails;
    }
}
