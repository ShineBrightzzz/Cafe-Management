namespace CafeManagement.Forms.SaleInvoice
{
    partial class SaleInvoicePanel
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
            btnThem = new Button();
            btnSua = new Button();
            dgridHDB = new DataGridView();
            btnXoa = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgridHDB).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightCoral;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(164, 186);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 42);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Turquoise;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(430, 186);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 42);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgridHDB
            // 
            dgridHDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridHDB.Location = new Point(131, 261);
            dgridHDB.Name = "dgridHDB";
            dgridHDB.RowHeadersWidth = 51;
            dgridHDB.Size = new Size(704, 221);
            dgridHDB.TabIndex = 2;
            dgridHDB.CellContentClick += dgridHDB_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveCaption;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(709, 186);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 42);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 47);
            label1.Name = "label1";
            label1.Size = new Size(501, 50);
            label1.TabIndex = 4;
            label1.Text = "DANH MỤC HÓA ĐƠN BÁN";
            // 
            // SaleInvoicePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(dgridHDB);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "SaleInvoicePanel";
            Size = new Size(1036, 514);
            Load += SaleInvoicePanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgridHDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private DataGridView dgridHDB;
        private Button btnXoa;
        private Label label1;
    }
}
