namespace CafeManagement.Forms
{
    partial class FrmEmployee
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
            txtGioiTinh = new TextBox();
            mskSoDienThoai = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDiaChi = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            mskNgaySInh = new MaskedTextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnBoQua = new Button();
            btnDong = new Button();
            btnThem = new Button();
            dgridNhanVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgridNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 32);
            label1.Name = "label1";
            label1.Size = new Size(422, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(164, 282);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(506, 27);
            txtGioiTinh.TabIndex = 1;
            // 
            // mskSoDienThoai
            // 
            mskSoDienThoai.Location = new Point(164, 403);
            mskSoDienThoai.Mask = "(999) 000-0000";
            mskSoDienThoai.Name = "mskSoDienThoai";
            mskSoDienThoai.Size = new Size(125, 27);
            mskSoDienThoai.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 225);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 170);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên nhân viên: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 410);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 9;
            label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 282);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 10;
            label8.Text = "Giới tính:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 352);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 11;
            label9.Text = "Ngày sinh:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 118);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 12;
            label10.Text = "Mã nhân viên:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(164, 222);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(506, 27);
            txtDiaChi.TabIndex = 16;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(164, 167);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(506, 27);
            txtTenNhanVien.TabIndex = 17;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(164, 118);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(506, 27);
            txtMaNhanVien.TabIndex = 18;
            // 
            // mskNgaySInh
            // 
            mskNgaySInh.Location = new Point(164, 345);
            mskNgaySInh.Mask = "00/00/0000";
            mskNgaySInh.Name = "mskNgaySInh";
            mskNgaySInh.Size = new Size(125, 27);
            mskNgaySInh.TabIndex = 20;
            mskNgaySInh.ValidatingType = typeof(DateTime);
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 675);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 38);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(323, 675);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 41);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseCompatibleTextRendering = true;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(447, 675);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 41);
            btnLuu.TabIndex = 25;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(579, 677);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(96, 34);
            btnBoQua.TabIndex = 24;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(709, 677);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(96, 34);
            btnDong.TabIndex = 23;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(75, 675);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 41);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dgridNhanVien
            // 
            dgridNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgridNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridNhanVien.Location = new Point(58, 458);
            dgridNhanVien.Name = "dgridNhanVien";
            dgridNhanVien.RowHeadersWidth = 51;
            dgridNhanVien.Size = new Size(806, 188);
            dgridNhanVien.TabIndex = 28;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(954, 776);
            Controls.Add(dgridNhanVien);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnBoQua);
            Controls.Add(btnDong);
            Controls.Add(btnThem);
            Controls.Add(mskNgaySInh);
            Controls.Add(txtMaNhanVien);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtDiaChi);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mskSoDienThoai);
            Controls.Add(txtGioiTinh);
            Controls.Add(label1);
            Name = "FrmEmployee";
            Text = "FrmEmployee";
            ((System.ComponentModel.ISupportInitialize)dgridNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGioiTinh;
        private MaskedTextBox mskSoDienThoai;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDiaChi;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private MaskedTextBox mskNgaySInh;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnBoQua;
        private Button btnDong;
        private Button btnThem;
        private DataGridView dgridNhanVien;
    }
}