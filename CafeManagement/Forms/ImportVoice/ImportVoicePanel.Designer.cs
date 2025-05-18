namespace CafeManagement.Forms.ImportVoice
{
    partial class ImportVoicePanel
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
            label1 = new Label();
            dgridHDN = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgridHDN).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Moccasin;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(469, 160);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 51);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 28);
            label1.Name = "label1";
            label1.Size = new Size(528, 50);
            label1.TabIndex = 1;
            label1.Text = "DANH MỤC HÓA ĐƠN NHẬP";
            // 
            // dgridHDN
            // 
            dgridHDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridHDN.Location = new Point(157, 241);
            dgridHDN.Name = "dgridHDN";
            dgridHDN.RowHeadersWidth = 51;
            dgridHDN.Size = new Size(819, 261);
            dgridHDN.TabIndex = 2;
            dgridHDN.CellContentClick += dgridHDN_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Salmon;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(157, 160);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 51);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Goldenrod;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(736, 160);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 51);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // ImportVoicePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgridHDN);
            Controls.Add(label1);
            Controls.Add(btnSua);
            Name = "ImportVoicePanel";
            Size = new Size(1152, 533);
            Load += ImportVoicePanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgridHDN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Label label1;
        private DataGridView dgridHDN;
        private Button btnThem;
        private Button btnXoa;
    }
}
