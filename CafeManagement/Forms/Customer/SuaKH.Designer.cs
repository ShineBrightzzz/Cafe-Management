namespace CafeManagement.Forms.Customer
{
    partial class SuaKH
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            txtMaKhachHang = new TextBox();
            mskSoDienThoai = new MaskedTextBox();
            txtTenKhachHang = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(163, 162);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 31;
            label9.Text = "Mã khách hàng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 216);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 30;
            label8.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 270);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 29;
            label7.Text = "Số điện thoại: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 80);
            label1.Name = "label1";
            label1.Size = new Size(0, 50);
            label1.TabIndex = 28;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(312, 343);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 37;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(486, 343);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 38;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(281, 162);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(327, 27);
            txtMaKhachHang.TabIndex = 39;
            // 
            // mskSoDienThoai
            // 
            mskSoDienThoai.Location = new Point(281, 263);
            mskSoDienThoai.Name = "mskSoDienThoai";
            mskSoDienThoai.Size = new Size(327, 27);
            mskSoDienThoai.TabIndex = 40;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(283, 209);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(325, 27);
            txtTenKhachHang.TabIndex = 41;
            // 
            // SuaKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTenKhachHang);
            Controls.Add(mskSoDienThoai);
            Controls.Add(txtMaKhachHang);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "SuaKH";
            Text = "SuaKH";
            Load += SuaKH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label1;
        private Button btnXacNhan;
        private Button btnHuy;
        private TextBox txtMaKhachHang;
        private MaskedTextBox mskSoDienThoai;
        private TextBox txtTenKhachHang;
    }
}