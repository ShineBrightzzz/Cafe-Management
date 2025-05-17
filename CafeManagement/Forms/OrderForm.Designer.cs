namespace CafeManagement.Forms
{
    partial class OrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tablePanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 61);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(746, 61);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(336, 670);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // tablePanel
            // 
            tablePanel.Dock = DockStyle.Fill;
            tablePanel.Location = new Point(0, 61);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(746, 670);
            tablePanel.TabIndex = 5;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 731);
            Controls.Add(tablePanel);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel tablePanel;
    }
}