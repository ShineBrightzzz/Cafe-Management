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

namespace CafeManagement.Forms.Employee
{
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }



        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string gender;
            if (chkNam.Checked == true)
            {
                gender = "Nam";
            }
            else gender = "Nữ";

            string sql;
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSoDienThoai.Focus();
                return;
            }
            //if (!Regex.IsMatch(mskSoDienThoai.Text, @"^\d{10,11}$"))
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10-11 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (mskNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Ban phai nhap lai ngay sinh", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Text = "";
                mskNgaySinh.Focus();
                return;
            }
            if (chkNam.Checked == false && chkNu.Checked == false)
            {
                MessageBox.Show("Ban phai nhap giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sql = "SELECT id FROM employees WHERE id=N'" + txtMaNhanVien.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                txtMaNhanVien.Text = "";
                return;
            }
            sql = "INSERT INTO employees(id, name, address, gender, date_of_birth,phone) VALUES (N'" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text + "',N'" + txtDiaChi.Text + "',N'" + gender + "',N'" + Functions.ConvertDateTime(mskNgaySinh.Text) + "',N'" + mskSoDienThoai.Text + "')";
            Functions.RunSql(sql);
            MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
