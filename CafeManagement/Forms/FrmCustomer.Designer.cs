namespace CafeManagement.Forms
{
    partial class FrmCustomer
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
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMaKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            txtSoDIenThoai = new TextBox();
            button1 = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 50);
            label1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 219);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 9;
            label7.Text = "Số điện thoại: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 165);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 10;
            label8.Text = "Tên khách hàng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 111);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 11;
            label9.Text = "Mã khách hàng:";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(175, 111);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(356, 27);
            txtMaKhachHang.TabIndex = 13;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(177, 165);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(354, 27);
            txtTenKhachHang.TabIndex = 14;
            // 
            // txtSoDIenThoai
            // 
            txtSoDIenThoai.Location = new Point(177, 216);
            txtSoDIenThoai.Name = "txtSoDIenThoai";
            txtSoDIenThoai.Size = new Size(354, 27);
            txtSoDIenThoai.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(177, 290);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(312, 290);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(689, 380);
            Controls.Add(btnHuy);
            Controls.Add(button1);
            Controls.Add(txtSoDIenThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMaKhachHang);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            Load += FrmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtMaKhachHang;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDIenThoai;
        private Button button1;
        private Button btnHuy;
    }
}