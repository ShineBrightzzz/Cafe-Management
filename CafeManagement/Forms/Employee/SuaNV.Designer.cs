namespace CafeManagement.Forms.Employee
{
    partial class SuaNV
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
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            btnHuy = new Button();
            btnXacNhan = new Button();
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
            SuspendLayout();
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(203, 168);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 53;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(361, 172);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 52;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(600, 414);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 51;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(238, 414);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 50;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // mskNgaySinh
            // 
            mskNgaySinh.Location = new Point(203, 235);
            mskNgaySinh.Mask = "00/00/0000";
            mskNgaySinh.Name = "mskNgaySinh";
            mskNgaySinh.Size = new Size(125, 27);
            mskNgaySinh.TabIndex = 49;
            mskNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(203, 8);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(506, 27);
            txtMaNhanVien.TabIndex = 48;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(203, 57);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(506, 27);
            txtTenNhanVien.TabIndex = 47;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(203, 112);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(506, 27);
            txtDiaChi.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(97, 8);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 45;
            label10.Text = "Mã nhân viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(97, 242);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 44;
            label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 172);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 43;
            label8.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 300);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 42;
            label7.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 60);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 41;
            label4.Text = "Tên nhân viên: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 115);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 40;
            label3.Text = "Địa chỉ: ";
            // 
            // mskSoDienThoai
            // 
            mskSoDienThoai.Location = new Point(203, 293);
            mskSoDienThoai.Mask = "(999) 000-0000";
            mskSoDienThoai.Name = "mskSoDienThoai";
            mskSoDienThoai.Size = new Size(125, 27);
            mskSoDienThoai.TabIndex = 39;
            // 
            // SuaNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "SuaNV";
            Text = "SuaNV";
            Load += SuaNV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Button btnHuy;
        private Button btnXacNhan;
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
    }
}