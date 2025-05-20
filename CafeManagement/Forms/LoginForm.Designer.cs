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
            lblLetsRegister = new Label();
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
            MainPanel.Controls.Add(lblLetsRegister);
            MainPanel.Controls.Add(btnLogin);
            MainPanel.Controls.Add(txtPassword);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(txtUsername);
            MainPanel.Controls.Add(label1);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(691, 543);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // lblLetsRegister
            // 
            lblLetsRegister.AutoSize = true;
            lblLetsRegister.Location = new Point(103, 409);
            lblLetsRegister.Name = "lblLetsRegister";
            lblLetsRegister.Size = new Size(470, 32);
            lblLetsRegister.TabIndex = 38;
            lblLetsRegister.Text = "Chưa có tài khoản? Ấn vào đây để đăng ký";
            lblLetsRegister.Click += lblLetsRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(237, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 67);
            btnLogin.TabIndex = 37;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(237, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(387, 39);
            txtPassword.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 221);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 35;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 145);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 34;
            label2.Text = "Tên người dùng:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(237, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(387, 39);
            txtUsername.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(185, 36);
            label1.Name = "label1";
            label1.Size = new Size(303, 65);
            label1.TabIndex = 32;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 543);
            Controls.Add(MainPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label lblLetsRegister;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
    }
}