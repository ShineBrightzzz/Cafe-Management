namespace CafeManagement.Forms.SaleInvoice
{
    partial class ThemHDB
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
            label1 = new Label();
            txtMaHoaDonBan = new TextBox();
            btnHuy = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaNhanVien = new TextBox();
            txtTongTien = new TextBox();
            txtMaKhachHang = new TextBox();
            mskNgayBan = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(174, 384);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 56);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã hóa đơn bán :";
            // 
            // txtMaHoaDonBan
            // 
            txtMaHoaDonBan.Location = new Point(174, 56);
            txtMaHoaDonBan.Name = "txtMaHoaDonBan";
            txtMaHoaDonBan.Size = new Size(317, 27);
            txtMaHoaDonBan.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(440, 384);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 116);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Ngày bán :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 179);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã nhân viên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 238);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 6;
            label4.Text = "Mã khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 304);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 7;
            label5.Text = "Tổng tiền : ";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(174, 179);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(317, 27);
            txtMaNhanVien.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(174, 297);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(317, 27);
            txtTongTien.TabIndex = 10;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(174, 235);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(317, 27);
            txtMaKhachHang.TabIndex = 11;
            // 
            // mskNgayBan
            // 
            mskNgayBan.Location = new Point(174, 116);
            mskNgayBan.Name = "mskNgayBan";
            mskNgayBan.Size = new Size(179, 27);
            mskNgayBan.TabIndex = 12;
            // 
            // ThemHDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mskNgayBan);
            Controls.Add(txtMaKhachHang);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnHuy);
            Controls.Add(txtMaHoaDonBan);
            Controls.Add(label1);
            Controls.Add(btnXacNhan);
            Name = "ThemHDB";
            Text = "Tổng tiền :";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXacNhan;
        private Label label1;
        private TextBox txtMaHoaDonBan;
        private Button btnHuy;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaNhanVien;
        private TextBox txtTongTien;
        private TextBox txtMaKhachHang;
        private MaskedTextBox mskNgayBan;
    }
}