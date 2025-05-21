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
            ((ISupportInitialize)dgridImportInvoiceDetails).BeginInit();
            ((ISupportInitialize)dgridImportInvoice).BeginInit();
            SuspendLayout();
            // 
            // dgridImportInvoiceDetails
            // 
            dgridImportInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridImportInvoiceDetails.Location = new Point(761, 65);
            dgridImportInvoiceDetails.Name = "dgridImportInvoiceDetails";
            dgridImportInvoiceDetails.Size = new Size(658, 567);
            dgridImportInvoiceDetails.TabIndex = 34;
            // 
            // dgridImportInvoice
            // 
            dgridImportInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridImportInvoice.Location = new Point(73, 65);
            dgridImportInvoice.Name = "dgridImportInvoice";
            dgridImportInvoice.Size = new Size(587, 567);
            dgridImportInvoice.TabIndex = 35;
            // 
            // ImportInvoicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgridImportInvoiceDetails);
            Controls.Add(dgridImportInvoice);
            Name = "ImportInvoicePanel";
            Size = new Size(1477, 808);
            ((ISupportInitialize)dgridImportInvoiceDetails).EndInit();
            ((ISupportInitialize)dgridImportInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgridImportInvoiceDetails;
        private DataGridView dgridImportInvoice;
    }
}
