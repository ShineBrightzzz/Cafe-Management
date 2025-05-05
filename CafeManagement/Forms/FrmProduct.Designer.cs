namespace CafeManagement.Forms
{
    partial class FormProduct
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtMaLoaiSp = new TextBox();
            txtGiaNhap = new TextBox();
            txtGiaBan = new TextBox();
            txtSoluong = new TextBox();
            dgridProduct = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnBoqua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgridProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC SẢN PHẨM\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 107);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 71);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 71);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 110);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 146);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã loại sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 143);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Số lượng";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(189, 71);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(161, 27);
            txtMaSP.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(189, 107);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(161, 27);
            txtTenSP.TabIndex = 8;
            // 
            // txtMaLoaiSp
            // 
            txtMaLoaiSp.Location = new Point(189, 143);
            txtMaLoaiSp.Name = "txtMaLoaiSp";
            txtMaLoaiSp.Size = new Size(161, 27);
            txtMaLoaiSp.TabIndex = 9;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(505, 71);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(167, 27);
            txtGiaNhap.TabIndex = 10;
            txtGiaNhap.TextChanged += txtGiaNhap_TextChanged;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(505, 107);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(167, 27);
            txtGiaBan.TabIndex = 11;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(505, 141);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(167, 27);
            txtSoluong.TabIndex = 12;
            // 
            // dgridProduct
            // 
            dgridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridProduct.Location = new Point(59, 185);
            dgridProduct.Name = "dgridProduct";
            dgridProduct.RowHeadersWidth = 51;
            dgridProduct.Size = new Size(661, 208);
            dgridProduct.TabIndex = 13;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(178, 409);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(292, 409);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(405, 409);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Location = new Point(521, 409);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(94, 29);
            btnBoqua.TabIndex = 17;
            btnBoqua.Text = "Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(644, 409);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(59, 409);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 457);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(dgridProduct);
            Controls.Add(txtSoluong);
            Controls.Add(txtGiaBan);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtMaLoaiSp);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduct";
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgridProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtMaLoaiSp;
        private TextBox txtGiaNhap;
        private TextBox txtGiaBan;
        private TextBox txtSoluong;
        private DataGridView dgridProduct;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnBoqua;
        private Button btnThoat;
        private Button btnThem;
    }
}