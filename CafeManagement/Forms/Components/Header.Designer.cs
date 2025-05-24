namespace CafeManagement.Forms
{
    partial class Header
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
            lblUsername = new Label();
            lblLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Control;
            lblUsername.Location = new Point(952, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(68, 30);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            // 
            // lblLogout
            // 
            lblLogout.Location = new Point(1080, 17);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(78, 30);
            lblLogout.TabIndex = 1;
            lblLogout.Text = "Đăng xuất";
            lblLogout.UseVisualStyleBackColor = true;
            lblLogout.Click += lblLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(433, 5);
            label1.Name = "label1";
            label1.Size = new Size(268, 45);
            label1.TabIndex = 2;
            label1.Text = "Quản lí quán cafe";
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(label1);
            Controls.Add(lblLogout);
            Controls.Add(lblUsername);
            Name = "Header";
            Size = new Size(1188, 61);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Button lblLogout;
        private Label label1;
    }
}
