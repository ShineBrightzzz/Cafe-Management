namespace CafeManagement.Forms
{
    partial class FrmCustomer
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
            btnThem = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMaKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            txtSoDIenThoai = new TextBox();
            dgridKhachHang = new DataGridView();
            btnDong = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgridKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 29);
            label1.Name = "label1";
            label1.Size = new Size(458, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 544);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 41);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 219);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 9;
            label7.Text = "Số điện thoại: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 165);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 10;
            label8.Text = "Tên khách hàng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 111);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 11;
            label9.Text = "Mã khách hàng:";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(175, 111);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(356, 27);
            txtMaKhachHang.TabIndex = 13;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(177, 165);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(354, 27);
            txtTenKhachHang.TabIndex = 14;
            // 
            // txtSoDIenThoai
            // 
            txtSoDIenThoai.Location = new Point(177, 216);
            txtSoDIenThoai.Name = "txtSoDIenThoai";
            txtSoDIenThoai.Size = new Size(354, 27);
            txtSoDIenThoai.TabIndex = 15;
            // 
            // dgridKhachHang
            // 
            dgridKhachHang.BackgroundColor = SystemColors.Control;
            dgridKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridKhachHang.Location = new Point(3, 288);
            dgridKhachHang.Name = "dgridKhachHang";
            dgridKhachHang.RowHeadersWidth = 51;
            dgridKhachHang.Size = new Size(798, 228);
            dgridKhachHang.TabIndex = 16;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(655, 546);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(96, 34);
            btnDong.TabIndex = 17;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(525, 546);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(96, 34);
            btnBoQua.TabIndex = 18;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(393, 544);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 41);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(269, 544);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 41);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseCompatibleTextRendering = true;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(146, 544);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 38);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(804, 610);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnBoQua);
            Controls.Add(btnDong);
            Controls.Add(dgridKhachHang);
            Controls.Add(txtSoDIenThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMaKhachHang);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnThem);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            ((System.ComponentModel.ISupportInitialize)dgridKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Button btnThem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtMaKhachHang;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDIenThoai;
        private DataGridView dgridKhachHang;
        private Button btnDong;
        private Button btnBoQua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
    }
}