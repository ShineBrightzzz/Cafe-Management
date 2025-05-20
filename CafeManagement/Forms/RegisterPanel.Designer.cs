namespace CafeManagement.Forms
{
    partial class RegisterPanel
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
            txtEmployeeId = new TextBox();
            txtPasswordRe = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUsernameRe = new TextBox();
            label1 = new Label();
            label5 = new Label();
            cboRole = new ComboBox();
            btnRegister = new Button();
            lblLetsLogin = new Label();
            SuspendLayout();
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(232, 260);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(387, 39);
            txtEmployeeId.TabIndex = 16;
            // 
            // txtPasswordRe
            // 
            txtPasswordRe.Location = new Point(232, 182);
            txtPasswordRe.Name = "txtPasswordRe";
            txtPasswordRe.Size = new Size(387, 39);
            txtPasswordRe.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 326);
            label4.Name = "label4";
            label4.Size = new Size(69, 32);
            label4.TabIndex = 14;
            label4.Text = "Vị trí:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 185);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 112);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 12;
            label2.Text = "Tên người dùng:";
            // 
            // txtUsernameRe
            // 
            txtUsernameRe.Location = new Point(232, 112);
            txtUsernameRe.Name = "txtUsernameRe";
            txtUsernameRe.Size = new Size(387, 39);
            txtUsernameRe.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(219, 15);
            label1.Name = "label1";
            label1.Size = new Size(231, 65);
            label1.TabIndex = 10;
            label1.Text = "ĐĂNG KÝ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 260);
            label5.Name = "label5";
            label5.Size = new Size(166, 32);
            label5.TabIndex = 19;
            label5.Text = "Mã nhân viên:";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(232, 326);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(387, 40);
            cboRole.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(232, 396);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 57);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblLetsLogin
            // 
            lblLetsLogin.AutoSize = true;
            lblLetsLogin.Location = new Point(97, 490);
            lblLetsLogin.Name = "lblLetsLogin";
            lblLetsLogin.Size = new Size(474, 32);
            lblLetsLogin.TabIndex = 20;
            lblLetsLogin.Text = "Đã có tài khoản? Ấn vào đây để đăng nhập";
            // 
            // RegisterPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblLetsLogin);
            Controls.Add(label5);
            Controls.Add(cboRole);
            Controls.Add(btnRegister);
            Controls.Add(txtEmployeeId);
            Controls.Add(txtPasswordRe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsernameRe);
            Controls.Add(label1);
            Name = "RegisterPanel";
            Size = new Size(703, 584);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeId;
        private TextBox txtPasswordRe;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUsernameRe;
        private Label label1;
        private Label label5;
        private ComboBox cboRole;
        private Button btnRegister;
        private Label lblLetsLogin;
    }
}
