using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms.SaleInvoice
{
    public partial class ThemHDB : Form
    {
        public ThemHDB()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            string sql;

            // Kiểm tra dữ liệu nhập
            if (txtMaHoaDonBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDonBan.Focus();
                return;
            }

            if (mskNgayBan.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayBan.Focus();
                return;
            }

            if (!Functions.IsDate(mskNgayBan.Text))
            {
                MessageBox.Show("Ngày bán không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayBan.Focus();
                return;
            }

            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }

            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }

            if (txtTongTien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }

            // Kiểm tra mã hóa đơn có trùng không
            sql = "SELECT id FROM sale_invoices WHERE id = N'" + txtMaHoaDonBan.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDonBan.Focus();
                txtMaHoaDonBan.Text = "";
                return;
            }
            double tongTien;
            if (!double.TryParse(txtTongTien.Text.Trim(), out tongTien))
            {
                MessageBox.Show("Tổng tiền phải là một số hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }

            // Thêm mới hóa đơn bán
            sql = "INSERT INTO sale_invoices(id, sale_date, employee_id, customer_id, total_amount) VALUES (" +
                  "N'" + txtMaHoaDonBan.Text.Trim() + "', " +
                  "N'" + Functions.ConvertDateTime(mskNgayBan.Text) + "', " +
                  "N'" + txtMaNhanVien.Text.Trim() + "', " +
                  "N'" + txtMaKhachHang.Text.Trim() + "', " +
                  tongTien.ToString() + ")";
            Functions.RunSql(sql);
            MessageBox.Show("Thêm hóa đơn bán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtMaHoaDonBan.Text = "";
            txtMaHoaDonBan.Text = "";
            txtTongTien.Text = "";
            mskNgayBan.Text = "";
        }

    }
}

