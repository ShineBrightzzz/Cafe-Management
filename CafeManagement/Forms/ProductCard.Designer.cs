namespace CafeManagement.Forms
{
    partial class ProductCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox = new PictureBox();
            this.lblName = new Label();
            this.lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            //            // pictureBox
            // 
            this.pictureBox.Dock = DockStyle.Top;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new Size(180, 140);
            this.pictureBox.Margin = new Padding(0);
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Dock = DockStyle.Top;
            this.lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(180, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên sản phẩm";
            this.lblName.TextAlign = ContentAlignment.MiddleCenter;
            this.lblName.Padding = new Padding(5, 5, 5, 0);
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = DockStyle.Top;
            this.lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new Size(180, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá";
            this.lblPrice.ForeColor = Color.Red;
            this.lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            //            // ProductCard
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProductCard";
            this.Size = new Size(180, 220);
            this.BackColor = Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Label lblName;
        private Label lblPrice;
    }
}
