namespace CafeManagement.Forms.ImportVoice
{
    partial class ThemHDN
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
            mskNgayNhap = new MaskedTextBox();
            txtMaHoaDonNhap = new TextBox();
            btnXacNhan = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaNhanVien = new TextBox();
            txtMaNhaCungCap = new TextBox();
            txtTongTien = new TextBox();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn nhập :";
            // 
            // mskNgayNhap
            // 
            mskNgayNhap.Location = new Point(177, 101);
            mskNgayNhap.Name = "mskNgayNhap";
            mskNgayNhap.Size = new Size(346, 27);
            mskNgayNhap.TabIndex = 1;
            // 
            // txtMaHoaDonNhap
            // 
            txtMaHoaDonNhap.Location = new Point(177, 23);
            txtMaHoaDonNhap.Name = "txtMaHoaDonNhap";
            txtMaHoaDonNhap.Size = new Size(410, 27);
            txtMaHoaDonNhap.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(191, 380);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 44);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 101);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "Ngày nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 186);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã Nhân Viên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 246);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 6;
            label4.Text = "Mã nhà cung cấp :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 313);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 7;
            label5.Text = "Tổng tiền :";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(177, 183);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(410, 27);
            txtMaNhanVien.TabIndex = 8;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Location = new Point(177, 239);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.Size = new Size(410, 27);
            txtMaNhaCungCap.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(177, 306);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(410, 27);
            txtTongTien.TabIndex = 10;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(406, 380);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 44);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // ThemHDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "ThemHDN";
            Text = "Tổng tiền :";
            Load += ThemHDN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mskNgayNhap;
        private TextBox txtMaHoaDonNhap;
        private Button btnXacNhan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaNhanVien;
        private TextBox txtMaNhaCungCap;
        private TextBox txtTongTien;
        private Button btnHuy;
    }
}