namespace CafeManagement.Forms.Employee
{
    partial class ThemNV
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
            mskNgaySinh = new MaskedTextBox();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            txtDiaChi = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            mskSoDienThoai = new MaskedTextBox();
            btnXacNhan = new Button();
            btnHuy = new Button();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            SuspendLayout();
            // 
            // mskNgaySinh
            // 
            mskNgaySinh.Location = new Point(203, 296);
            mskNgaySinh.Mask = "00/00/0000";
            mskNgaySinh.Name = "mskNgaySinh";
            mskNgaySinh.Size = new Size(125, 27);
            mskNgaySinh.TabIndex = 32;
            mskNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(203, 69);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(506, 27);
            txtMaNhanVien.TabIndex = 31;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(203, 118);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(506, 27);
            txtTenNhanVien.TabIndex = 30;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(203, 173);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(506, 27);
            txtDiaChi.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(97, 69);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 28;
            label10.Text = "Mã nhân viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(97, 303);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 27;
            label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 233);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 26;
            label8.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 361);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 25;
            label7.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 121);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 24;
            label4.Text = "Tên nhân viên: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 176);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 23;
            label3.Text = "Địa chỉ: ";
            // 
            // mskSoDienThoai
            // 
            mskSoDienThoai.Location = new Point(203, 354);
            mskSoDienThoai.Mask = "(999) 000-0000";
            mskSoDienThoai.Name = "mskSoDienThoai";
            mskSoDienThoai.Size = new Size(125, 27);
            mskSoDienThoai.TabIndex = 22;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(238, 475);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 33;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(600, 475);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(361, 233);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 37;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(203, 229);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 38;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            rdoNam.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // ThemNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 599);
            Controls.Add(rdoNam);
            Controls.Add(rdoNu);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(mskNgaySinh);
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
            Name = "ThemNV";
            Text = "ThemNV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskNgaySinh;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private TextBox txtDiaChi;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private MaskedTextBox mskSoDienThoai;
        private Button btnXacNhan;
        private Button btnHuy;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
    }
}