using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms.ImportVoice
{
    public partial class SuaHDN : Form
    {
        public SuaHDN(string maHDN, string ngayNhap, string maNV, string maNCC, string tongTien)
        {
            InitializeComponent();
            txtMaHoaDonNhap.Text = maHDN;
            mskNgayNhap.Text = ngayNhap;
            txtMaNhanVien.Text = maNV;
            txtMaNhaCungCap.Text = maNCC;
            txtTongTien.Text = tongTien;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            string sql;

            // Kiểm tra dữ liệu nhập
            if (txtMaHoaDonNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDonNhap.Focus();
                return;
            }

            if (mskNgayNhap.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayNhap.Focus();
                return;
            }

            if (!Functions.IsDate(mskNgayNhap.Text))
            {
                MessageBox.Show("Ngày nhập không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayNhap.Focus();
                return;
            }

            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }

            if (txtMaNhaCungCap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaCungCap.Focus();
                return;
            }

            if (txtTongTien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }

            // Kiểm tra mã hóa đơn có trùng không
            sql = "SELECT id FROM import_invoices WHERE id = N'" + txtMaHoaDonNhap.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDonNhap.Focus();
                txtMaHoaDonNhap.Text = "";
                return;
            }

            double tongTien;
            if (!double.TryParse(txtTongTien.Text.Trim(), out tongTien))
            {
                MessageBox.Show("Tổng tiền phải là một số hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }

            // Thêm mới hóa đơn nhập
            sql = "INSERT INTO import_invoices(id, import_date, employee_id, supplier_id, total_amount) VALUES (" +
                  "N'" + txtMaHoaDonNhap.Text.Trim() + "', " +
                  "N'" + Functions.ConvertDateTime(mskNgayNhap.Text) + "', " +
                  "N'" + txtMaNhanVien.Text.Trim() + "', " +
                  "N'" + txtMaNhaCungCap.Text.Trim() + "', " +
                  tongTien.ToString() + ")";
            Functions.RunSql(sql);

            MessageBox.Show("Thêm hóa đơn nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHoaDonNhap.Text = "";
            mskNgayNhap.Text = "";
            txtMaNhanVien.Text = "";
            txtMaNhaCungCap.Text = "";
            txtTongTien.Text = "";
        }

    }
}

