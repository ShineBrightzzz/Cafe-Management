namespace CafeManagement.Forms
{
    partial class CustomerPanel
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            dgridKH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgridKH).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MediumPurple;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(422, 217);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 57);
            btnSua.TabIndex = 35;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSteelBlue;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(262, 217);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 57);
            btnXoa.TabIndex = 34;
            btnXoa.Text = "Xóa";
            btnXoa.UseCompatibleTextRendering = true;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Plum;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(99, 217);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 57);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(251, 55);
            label1.Name = "label1";
            label1.Size = new Size(484, 50);
            label1.TabIndex = 22;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // dgridKH
            // 
            dgridKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridKH.Location = new Point(99, 306);
            dgridKH.Name = "dgridKH";
            dgridKH.RowHeadersWidth = 51;
            dgridKH.Size = new Size(840, 186);
            dgridKH.TabIndex = 36;
            dgridKH.CellContentClick += dgridKH_CellContentClick;
            dgridKH.Click += dgridKH_Click;
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgridKH);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Name = "CustomerPanel";
            Size = new Size(987, 854);
            Load += CustomerPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgridKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
        private DataGridView dgridKH;
    }
}
