namespace CafeManagement.Forms
{
    partial class FormMain
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
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnMenu = new Button();
            button1 = new Button();
            mainPanel = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 77);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 706);
            panel2.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(0, 320);
            button7.Name = "button7";
            button7.Size = new Size(200, 44);
            button7.TabIndex = 0;
            button7.Text = "Nhân viên";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(0, 270);
            button6.Name = "button6";
            button6.Size = new Size(200, 44);
            button6.TabIndex = 0;
            button6.Text = "Khách hàng";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(0, 211);
            button5.Name = "button5";
            button5.Size = new Size(200, 44);
            button5.TabIndex = 0;
            button5.Text = "Hóa đơn bán";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 150);
            button4.Name = "button4";
            button4.Size = new Size(200, 44);
            button4.TabIndex = 0;
            button4.Text = "Hóa đơn nhập";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 100);
            button3.Name = "button3";
            button3.Size = new Size(200, 44);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(0, 50);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(200, 44);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Thực đơn";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 44);
            button1.TabIndex = 0;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 77);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(886, 706);
            mainPanel.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 783);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnMenu;
        private Button button7;
        private FlowLayoutPanel mainPanel;
    }
}