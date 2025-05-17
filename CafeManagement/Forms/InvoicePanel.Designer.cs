namespace CafeManagement.Forms
{
    partial class InvoicePanel
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
            actionPanel = new FlowLayoutPanel();
            invoicesPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Dock = DockStyle.Bottom;
            actionPanel.Location = new Point(0, 508);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(374, 100);
            actionPanel.TabIndex = 0;
            // 
            // invoicesPanel
            // 
            invoicesPanel.Dock = DockStyle.Fill;
            invoicesPanel.Location = new Point(0, 0);
            invoicesPanel.Name = "invoicesPanel";
            invoicesPanel.Size = new Size(374, 508);
            invoicesPanel.TabIndex = 1;
            // 
            // InvoicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(invoicesPanel);
            Controls.Add(actionPanel);
            Name = "InvoicePanel";
            Size = new Size(374, 608);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel actionPanel;
        private FlowLayoutPanel invoicesPanel;
    }
}
