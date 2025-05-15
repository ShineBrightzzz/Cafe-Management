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
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new Point(10, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new Size(250, 150);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblName.Location = new Point(10, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(250, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên sản phẩm";
            this.lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblPrice.Location = new Point(10, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new Size(250, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá";
            this.lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Name = "ProductCard";
            this.Size = new Size(270, 240);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Label lblName;
        private Label lblPrice;
    }
}
