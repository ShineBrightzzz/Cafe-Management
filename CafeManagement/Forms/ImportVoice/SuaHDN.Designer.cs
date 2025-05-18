namespace CafeManagement.Forms.ImportVoice
{
    partial class SuaHDN
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
            btnHuy = new Button();
            txtTongTien = new TextBox();
            txtMaNhaCungCap = new TextBox();
            txtMaNhanVien = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnXacNhan = new Button();
            txtMaHoaDonNhap = new TextBox();
            mskNgayNhap = new MaskedTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(428, 387);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 44);
            btnHuy.TabIndex = 23;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(208, 317);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(410, 27);
            txtTongTien.TabIndex = 22;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Location = new Point(208, 249);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.Size = new Size(410, 27);
            txtMaNhaCungCap.TabIndex = 21;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(208, 181);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(410, 27);
            txtMaNhanVien.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 320);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 19;
            label5.Text = "Tổng tiền :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 249);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 18;
            label4.Text = "Mã nhà cung cấp :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 181);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 17;
            label3.Text = "Mã Nhân Viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 16;
            label2.Text = "Ngày nhập :";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(208, 387);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 44);
            btnXacNhan.TabIndex = 15;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtMaHoaDonNhap
            // 
            txtMaHoaDonNhap.Location = new Point(208, 26);
            txtMaHoaDonNhap.Name = "txtMaHoaDonNhap";
            txtMaHoaDonNhap.Size = new Size(410, 27);
            txtMaHoaDonNhap.TabIndex = 14;
            // 
            // mskNgayNhap
            // 
            mskNgayNhap.Location = new Point(208, 105);
            mskNgayNhap.Name = "mskNgayNhap";
            mskNgayNhap.Size = new Size(346, 27);
            mskNgayNhap.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 12;
            label1.Text = "Mã hóa đơn nhập :";
            // 
            // SuaHDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 460);
            Controls.Add(btnHuy);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaNhaCungCap);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnXacNhan);
            Controls.Add(txtMaHoaDonNhap);
            Controls.Add(mskNgayNhap);
            Controls.Add(label1);
            Name = "SuaHDN";
            Text = "SuaHDN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private TextBox txtTongTien;
        private TextBox txtMaNhaCungCap;
        private TextBox txtMaNhanVien;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXacNhan;
        private TextBox txtMaHoaDonNhap;
        private MaskedTextBox mskNgayNhap;
        private Label label1;
    }
}