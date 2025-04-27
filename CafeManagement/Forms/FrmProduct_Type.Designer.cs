namespace CafeManagement.Forms
{
    partial class FrmProduct_Type
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
            btnThoat = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgridProductType = new DataGridView();
            txtMaLoaiSp = new TextBox();
            txtTenLoaiSp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgridProductType).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(57, 390);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(642, 390);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Location = new Point(519, 390);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(94, 29);
            btnBoqua.TabIndex = 23;
            btnBoqua.Text = "Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(403, 390);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 22;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(290, 390);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(176, 390);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(403, 41);
            label1.TabIndex = 26;
            label1.Text = "DANH MỤC LOẠI SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 88);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 27;
            label2.Text = "Mã loại sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 127);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 28;
            label3.Text = "Tên loại sản phẩm";
            // 
            // dgridProductType
            // 
            dgridProductType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridProductType.Location = new Point(86, 171);
            dgridProductType.Name = "dgridProductType";
            dgridProductType.RowHeadersWidth = 51;
            dgridProductType.Size = new Size(607, 188);
            dgridProductType.TabIndex = 29;
            // 
            // txtMaLoaiSp
            // 
            txtMaLoaiSp.Location = new Point(372, 88);
            txtMaLoaiSp.Name = "txtMaLoaiSp";
            txtMaLoaiSp.Size = new Size(173, 27);
            txtMaLoaiSp.TabIndex = 30;
            // 
            // txtTenLoaiSp
            // 
            txtTenLoaiSp.Location = new Point(372, 124);
            txtTenLoaiSp.Name = "txtTenLoaiSp";
            txtTenLoaiSp.Size = new Size(173, 27);
            txtTenLoaiSp.TabIndex = 31;
            // 
            // FrmProduct_Type
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTenLoaiSp);
            Controls.Add(txtMaLoaiSp);
            Controls.Add(dgridProductType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FrmProduct_Type";
            Text = "FrmProduct_Type";
            ((System.ComponentModel.ISupportInitialize)dgridProductType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnThoat;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgridProductType;
        private TextBox txtMaLoaiSp;
        private TextBox txtTenLoaiSp;
    }
}