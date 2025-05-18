using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CafeManagement.Forms.Customer
{
    public partial class ThemKH : Form
    {
        public ThemKH()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }
            if (mskSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSoDienThoai.Focus();
                return;
            }
            //if (!Regex.IsMatch(mskSoDienThoai.Text, @"^\d{10,11}$"))
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10-11 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            sql = "SELECT id FROM customers WHERE id=N'" + txtMaKhachHang.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                txtMaKhachHang.Text = "";
                return;
            }
            sql = "INSERT INTO customers(id, name, phone) VALUES (N'" + txtMaKhachHang.Text + "',N'" + txtTenKhachHang.Text + "',N'" + mskSoDienThoai.Text + "')";
            Functions.RunSql(sql);
            MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            mskSoDienThoai.Text = "(   )     -";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
