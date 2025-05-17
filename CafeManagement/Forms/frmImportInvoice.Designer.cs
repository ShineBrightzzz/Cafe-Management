namespace CafeManagement.Forms
{
    partial class frmImportInvoice
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
            groupBox1 = new GroupBox();
            cboMaNhanVien = new ComboBox();
            cboMaNhaCungCap = new ComboBox();
            txtNgayNhap = new MaskedTextBox();
            txtSoDienThoaiNhaCungCap = new MaskedTextBox();
            txtDiaChiNhaCungCap = new TextBox();
            txtTenNhaCungCap = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaHoaDonNhap = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtSoLuong = new TextBox();
            txtTenHang = new TextBox();
            cboMaHang = new ComboBox();
            btnDong = new Button();
            btnIn = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            lblBangChu = new Label();
            label17 = new Label();
            txtTongTien = new TextBox();
            label16 = new Label();
            dgridChiTietHoaDonNhap = new DataGridView();
            txtDonGia = new TextBox();
            txtGiam = new TextBox();
            txtThanhTien = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label19 = new Label();
            cboMaHoaDonNhap = new ComboBox();
            btnTimKiem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridChiTietHoaDonNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(576, 20);
            label1.Name = "label1";
            label1.Size = new Size(600, 72);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(cboMaNhaCungCap);
            groupBox1.Controls.Add(txtNgayNhap);
            groupBox1.Controls.Add(txtSoDienThoaiNhaCungCap);
            groupBox1.Controls.Add(txtDiaChiNhaCungCap);
            groupBox1.Controls.Add(txtTenNhaCungCap);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(txtMaHoaDonNhap);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(95, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1528, 440);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(273, 233);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(408, 40);
            cboMaNhanVien.TabIndex = 36;
            // 
            // cboMaNhaCungCap
            // 
            cboMaNhaCungCap.FormattingEnabled = true;
            cboMaNhaCungCap.Location = new Point(1059, 83);
            cboMaNhaCungCap.Name = "cboMaNhaCungCap";
            cboMaNhaCungCap.Size = new Size(408, 40);
            cboMaNhaCungCap.TabIndex = 35;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.Location = new Point(273, 156);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.Size = new Size(408, 39);
            txtNgayNhap.TabIndex = 11;
            // 
            // txtSoDienThoaiNhaCungCap
            // 
            txtSoDienThoaiNhaCungCap.Location = new Point(1059, 293);
            txtSoDienThoaiNhaCungCap.Name = "txtSoDienThoaiNhaCungCap";
            txtSoDienThoaiNhaCungCap.Size = new Size(408, 39);
            txtSoDienThoaiNhaCungCap.TabIndex = 17;
            // 
            // txtDiaChiNhaCungCap
            // 
            txtDiaChiNhaCungCap.Location = new Point(1059, 223);
            txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            txtDiaChiNhaCungCap.Size = new Size(408, 39);
            txtDiaChiNhaCungCap.TabIndex = 15;
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Location = new Point(1059, 156);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(408, 39);
            txtTenNhaCungCap.TabIndex = 14;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(273, 304);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(408, 39);
            txtTenNhanVien.TabIndex = 12;
            // 
            // txtMaHoaDonNhap
            // 
            txtMaHoaDonNhap.Location = new Point(273, 84);
            txtMaHoaDonNhap.Name = "txtMaHoaDonNhap";
            txtMaHoaDonNhap.Size = new Size(408, 39);
            txtMaHoaDonNhap.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(828, 293);
            label9.Name = "label9";
            label9.Size = new Size(156, 32);
            label9.TabIndex = 9;
            label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(828, 223);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 8;
            label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(824, 156);
            label7.Name = "label7";
            label7.Size = new Size(203, 32);
            label7.TabIndex = 7;
            label7.Text = "Tên nhà cung cấp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(828, 84);
            label6.Name = "label6";
            label6.Size = new Size(199, 32);
            label6.TabIndex = 6;
            label6.Text = "Mã nhà cung cấp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 307);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 5;
            label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 233);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 4;
            label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 156);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 3;
            label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 88);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtTenHang);
            groupBox2.Controls.Add(cboMaHang);
            groupBox2.Controls.Add(btnDong);
            groupBox2.Controls.Add(btnIn);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(lblBangChu);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(dgridChiTietHoaDonNhap);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(txtGiam);
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(105, 608);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1518, 817);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin mặt hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(712, 80);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(201, 39);
            txtSoLuong.TabIndex = 36;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(236, 147);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(201, 39);
            txtTenHang.TabIndex = 35;
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(236, 72);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(242, 40);
            cboMaHang.TabIndex = 34;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(1133, 741);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(150, 46);
            btnDong.TabIndex = 33;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(944, 741);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(150, 46);
            btnIn.TabIndex = 32;
            btnIn.Text = "Ịn hóa đơn";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(763, 741);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 31;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += button3_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(596, 741);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 30;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(329, 741);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(244, 46);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm hóa đơn nhập";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lblBangChu
            // 
            lblBangChu.AutoSize = true;
            lblBangChu.Location = new Point(57, 671);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(126, 32);
            lblBangChu.TabIndex = 28;
            lblBangChu.Text = "Bằng chữ: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.MenuHighlight;
            label17.Location = new Point(57, 617);
            label17.Name = "label17";
            label17.Size = new Size(360, 32);
            label17.TabIndex = 27;
            label17.Text = "Kích đúp một dòng hàng để xóa";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(1111, 629);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(217, 39);
            txtTongTien.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(988, 632);
            label16.Name = "label16";
            label16.Size = new Size(117, 32);
            label16.TabIndex = 25;
            label16.Text = "Tổng tiền";
            // 
            // dgridChiTietHoaDonNhap
            // 
            dgridChiTietHoaDonNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridChiTietHoaDonNhap.Location = new Point(82, 252);
            dgridChiTietHoaDonNhap.Name = "dgridChiTietHoaDonNhap";
            dgridChiTietHoaDonNhap.RowHeadersWidth = 82;
            dgridChiTietHoaDonNhap.Size = new Size(1317, 317);
            dgridChiTietHoaDonNhap.TabIndex = 24;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(712, 147);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(201, 39);
            txtDonGia.TabIndex = 22;
            // 
            // txtGiam
            // 
            txtGiam.Location = new Point(1182, 81);
            txtGiam.Name = "txtGiam";
            txtGiam.Size = new Size(217, 39);
            txtGiam.TabIndex = 21;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(1182, 147);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(217, 39);
            txtThanhTien.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1049, 147);
            label15.Name = "label15";
            label15.Size = new Size(129, 32);
            label15.TabIndex = 8;
            label15.Text = "Thành tiền";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1049, 80);
            label14.Name = "label14";
            label14.Size = new Size(96, 32);
            label14.TabIndex = 7;
            label14.Text = "% Giảm";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(596, 144);
            label13.Name = "label13";
            label13.Size = new Size(98, 32);
            label13.TabIndex = 6;
            label13.Text = "Đơn giá";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(596, 84);
            label12.Name = "label12";
            label12.Size = new Size(110, 32);
            label12.TabIndex = 5;
            label12.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 147);
            label11.Name = "label11";
            label11.Size = new Size(113, 32);
            label11.TabIndex = 4;
            label11.Text = "Tên hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 80);
            label10.Name = "label10";
            label10.Size = new Size(109, 32);
            label10.TabIndex = 3;
            label10.Text = "Mã hàng";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(171, 1477);
            label19.Name = "label19";
            label19.Size = new Size(144, 32);
            label19.TabIndex = 12;
            label19.Text = "Mã hóa đơn";
            // 
            // cboMaHoaDonNhap
            // 
            cboMaHoaDonNhap.FormattingEnabled = true;
            cboMaHoaDonNhap.Location = new Point(321, 1477);
            cboMaHoaDonNhap.Name = "cboMaHoaDonNhap";
            cboMaHoaDonNhap.Size = new Size(242, 40);
            cboMaHoaDonNhap.TabIndex = 35;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(626, 1477);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 36;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmImportInvoice
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 1559);
            Controls.Add(btnTimKiem);
            Controls.Add(cboMaHoaDonNhap);
            Controls.Add(label19);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmImportInvoice";
            Text = "frmImportInvoice";
            Load += frmImportInvoice_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgridChiTietHoaDonNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private TextBox txtDiaChiNhaCungCap;
        private TextBox txtTenNhaCungCap;
        private TextBox txtMaNhaCungCap;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private TextBox txtMaHoaDonNhap;
        private MaskedTextBox txtSoDienThoaiNhaCungCap;
        private MaskedTextBox txtNgayNhap;
        private GroupBox groupBox2;
        private TextBox textBox12;
        private TextBox txtDonGia;
        private TextBox txtGiam;
        private TextBox txtThanhTien;
        private TextBox textBox8;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnDong;
        private Button btnIn;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Label lblBangChu;
        private Label label17;
        private TextBox txtTongTien;
        private Label label16;
        private DataGridView dgridChiTietHoaDonNhap;
        private ComboBox cboMaHang;
        private Label label19;
        private ComboBox cboMaNhanVien;
        private ComboBox cboMaNhaCungCap;
        private ComboBox cboMaHoaDonNhap;
        private Button btnTimKiem;
        private TextBox txtSoLuong;
        private TextBox txtTenHang;
    }
}