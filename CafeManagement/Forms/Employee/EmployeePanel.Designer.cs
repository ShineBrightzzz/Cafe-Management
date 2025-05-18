namespace CafeManagement.Forms.Employee
{
    partial class EmployeePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgridNhanVien = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgridNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgridNhanVien
            // 
            dgridNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgridNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridNhanVien.Location = new Point(35, 233);
            dgridNhanVien.Name = "dgridNhanVien";
            dgridNhanVien.RowHeadersWidth = 51;
            dgridNhanVien.Size = new Size(806, 188);
            dgridNhanVien.TabIndex = 35;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(167, 153);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 38);
            btnSua.TabIndex = 34;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(306, 154);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 41);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseCompatibleTextRendering = true;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 152);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 41);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 40);
            label1.Name = "label1";
            label1.Size = new Size(444, 50);
            label1.TabIndex = 36;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // EmployeePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dgridNhanVien);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "EmployeePanel";
            Size = new Size(882, 554);
            ((System.ComponentModel.ISupportInitialize)dgridNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgridNhanVien;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
    }
}
