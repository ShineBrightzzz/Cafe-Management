namespace CafeManagement.Forms
{
    partial class LoginForm
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
            MainPanel = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(btnLogin);
            MainPanel.Controls.Add(txtPassword);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(txtUsername);
            MainPanel.Controls.Add(label1);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(2, 1, 2, 1);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(372, 255);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(128, 142);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 31);
            btnLogin.TabIndex = 37;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 104);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 35;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 34;
            label2.Text = "Tên người dùng:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(128, 68);
            txtUsername.Margin = new Padding(2, 1, 2, 1);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 23);
            txtUsername.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(100, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 32;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 255);
            Controls.Add(MainPanel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginForm";
            Text = "Đăng nhập";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
    }
}