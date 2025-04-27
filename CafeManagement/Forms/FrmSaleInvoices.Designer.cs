namespace QLQC
{
    partial class frmHoadonBan
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
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            this.cboMaNhanVien = new ComboBox();
            this.drig = new DataGridView();
            label5 = new Label();
            label8 = new Label();
            txtMaHDBan = new TextBox();
            txtTongTien = new TextBox();
            label9 = new Label();
            label10 = new Label();
            this.cboMaKhachHang = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            this.cboMaSanPham = new ComboBox();
            this.txtThanhTien = new TextBox();
            this.txtDonGia = new TextBox();
            this.txtKhuyenMai = new TextBox();
            txtSoLuong = new TextBox();
            lblBangChu = new Label();
            label21 = new Label();
            label22 = new Label();
            btnTimKiem = new Button();
            btnDong = new Button();
            btnIn = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            cboMaHoaDon = new ComboBox();
            txtNgayBan = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.drig).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 657);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm hóa đơn";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(255, 27);
            label1.TabIndex = 2;
            label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 90);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 4;
            label3.Text = "Mã hóa đơn bán :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 133);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 5;
            label4.Text = "Ngày bán: ";
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new Point(652, 138);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new Size(121, 24);
            this.cboMaNhanVien.TabIndex = 6;
            // 
            // drig
            // 
            this.drig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drig.Location = new Point(128, 367);
            this.drig.Name = "drig";
            this.drig.RowHeadersWidth = 51;
            this.drig.RowTemplate.Height = 24;
            this.drig.Size = new Size(615, 174);
            this.drig.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 141);
            label5.Name = "label5";
            label5.Size = new Size(100, 16);
            label5.TabIndex = 9;
            label5.Text = "Mã nhân viên :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 90);
            label8.Name = "label8";
            label8.Size = new Size(115, 16);
            label8.TabIndex = 12;
            label8.Text = "Mã Khách Hàng :";
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(144, 90);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(190, 23);
            txtMaHDBan.TabIndex = 15;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(612, 565);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(131, 23);
            txtTongTien.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 274);
            label9.Name = "label9";
            label9.Size = new Size(0, 16);
            label9.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 232);
            label10.Name = "label10";
            label10.Size = new Size(100, 16);
            label10.TabIndex = 18;
            label10.Text = "Mã sản phẩm :";
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new Point(652, 90);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new Size(121, 24);
            this.cboMaKhachHang.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(669, 262);
            label13.Name = "label13";
            label13.Size = new Size(83, 16);
            label13.TabIndex = 24;
            label13.Text = "Thành tiền :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(375, 232);
            label14.Name = "label14";
            label14.Size = new Size(65, 16);
            label14.TabIndex = 25;
            label14.Text = "Đơn giá :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(353, 301);
            label15.Name = "label15";
            label15.Size = new Size(89, 16);
            label15.TabIndex = 26;
            label15.Text = "Khuyến Mãi :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(56, 301);
            label17.Name = "label17";
            label17.Size = new Size(73, 16);
            label17.TabIndex = 28;
            label17.Text = "Số lượng :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(511, 568);
            label18.Name = "label18";
            label18.Size = new Size(75, 16);
            label18.TabIndex = 29;
            label18.Text = "Tổng tiền :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(26, 36);
            label19.Name = "label19";
            label19.Size = new Size(110, 16);
            label19.TabIndex = 30;
            label19.Text = "Thông tin chung";
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.FormattingEnabled = true;
            this.cboMaSanPham.Location = new Point(144, 229);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.Size = new Size(121, 24);
            this.cboMaSanPham.TabIndex = 31;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new Point(776, 259);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new Size(139, 23);
            this.txtThanhTien.TabIndex = 32;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new Point(456, 229);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new Size(135, 23);
            this.txtDonGia.TabIndex = 33;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new Point(456, 294);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new Size(126, 23);
            this.txtKhuyenMai.TabIndex = 34;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(144, 294);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(121, 23);
            txtSoLuong.TabIndex = 36;
            // 
            // lblBangChu
            // 
            lblBangChu.AutoSize = true;
            lblBangChu.Location = new Point(56, 572);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(76, 16);
            lblBangChu.TabIndex = 37;
            lblBangChu.Text = "Bằng chữ :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(85, 627);
            label21.Name = "label21";
            label21.Size = new Size(0, 16);
            label21.TabIndex = 38;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(85, 747);
            label22.Name = "label22";
            label22.Size = new Size(87, 16);
            label22.TabIndex = 39;
            label22.Text = "Mã hóa đơn:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(481, 739);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(128, 23);
            btnTimKiem.TabIndex = 44;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(789, 657);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(126, 23);
            btnDong.TabIndex = 45;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(592, 657);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(126, 23);
            btnIn.TabIndex = 46;
            btnIn.Text = "In hóa đơn";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(392, 657);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(126, 23);
            btnHuy.TabIndex = 47;
            btnHuy.Text = "Hủy Hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(194, 657);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(126, 23);
            btnLuu.TabIndex = 48;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // cboMaHoaDon
            // 
            cboMaHoaDon.FormattingEnabled = true;
            cboMaHoaDon.Location = new Point(223, 739);
            cboMaHoaDon.Name = "cboMaHoaDon";
            cboMaHoaDon.Size = new Size(121, 24);
            cboMaHoaDon.TabIndex = 49;
            // 
            // txtNgayBan
            // 
            txtNgayBan.Location = new Point(144, 133);
            txtNgayBan.Name = "txtNgayBan";
            txtNgayBan.Size = new Size(190, 23);
            txtNgayBan.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 187);
            label6.Name = "label6";
            label6.Size = new Size(156, 16);
            label6.TabIndex = 51;
            label6.Text = "Thông tin các mặt hàng";
            // 
            // frmHoadonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 838);
            Controls.Add(label6);
            Controls.Add(txtNgayBan);
            Controls.Add(cboMaHoaDon);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(btnIn);
            Controls.Add(btnDong);
            Controls.Add(btnTimKiem);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(lblBangChu);
            Controls.Add(txtSoLuong);
            Controls.Add(this.txtKhuyenMai);
            Controls.Add(this.txtDonGia);
            Controls.Add(this.txtThanhTien);
            Controls.Add(this.cboMaSanPham);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(this.cboMaKhachHang);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaHDBan);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(this.drig);
            Controls.Add(this.cboMaNhanVien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Font = new Font("Arial", 8.25F);
            Name = "frmHoadonBan";
            Text = "HOA DON BAN";
            Load += frmHoadonBan_Load;
            ((System.ComponentModel.ISupportInitialize)this.drig).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private TextBox txtNgayBan;
        private Label label6;
    }
}

