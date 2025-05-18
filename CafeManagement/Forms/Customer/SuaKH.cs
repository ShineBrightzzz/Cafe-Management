using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CafeManagement.Forms.Customer
{
    public partial class SuaKH : Form
    {
        public SuaKH(string maKH, string tenKH, string sdt)
        {
            InitializeComponent();


            txtMaKhachHang.Text = maKH;
            txtTenKhachHang.Text = tenKH;
            mskSoDienThoai.Text = sdt;

        }

        DataTable tblKH;

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }

            if (mskSoDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSoDienThoai.Focus();
                return;
            }
            sql = "UPDATE customers SET  name=N'" + txtTenKhachHang.Text.Trim().ToString()
                  + "',phone=N'" + mskSoDienThoai.Text.ToString() + "' WHERE id=N'" + txtMaKhachHang.Text + "'";
            Functions.RunSql(sql);
        }

        private void SuaKH_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
