namespace CafeManagement.Forms.SaleInvoice
{
    partial class SuaHDB
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
            btnXacNhan = new Button();
            btnHuy = new Button();
            txtMaHoaDonBan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaNhanVien = new TextBox();
            txtMaKhachHang = new TextBox();
            txtTongTien = new TextBox();
            mskNgayBan = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(178, 364);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(446, 364);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtMaHoaDonBan
            // 
            txtMaHoaDonBan.Location = new Point(162, 55);
            txtMaHoaDonBan.Name = "txtMaHoaDonBan";
            txtMaHoaDonBan.Size = new Size(378, 27);
            txtMaHoaDonBan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã hóa đơn bán :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 117);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Ngày bán :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 184);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã Nhân VIên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 245);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 6;
            label4.Text = "Mã Khách Hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 306);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 7;
            label5.Text = "Tổng Tiền :";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(162, 184);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(378, 27);
            txtMaNhanVien.TabIndex = 8;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(162, 245);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(378, 27);
            txtMaKhachHang.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(162, 303);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(378, 27);
            txtTongTien.TabIndex = 10;
            // 
            // mskNgayBan
            // 
            mskNgayBan.Location = new Point(162, 117);
            mskNgayBan.Name = "mskNgayBan";
            mskNgayBan.Size = new Size(223, 27);
            mskNgayBan.TabIndex = 11;
            mskNgayBan.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // SuaHDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mskNgayBan);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaKhachHang);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaHoaDonBan);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Name = "SuaHDB";
            Text = "+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXacNhan;
        private Button btnHuy;
        private TextBox txtMaHoaDonBan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaNhanVien;
        private TextBox txtMaKhachHang;
        private TextBox txtTongTien;
        private MaskedTextBox mskNgayBan;
    }
}