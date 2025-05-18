using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms.Employee
{
    public partial class SuaNV : Form
    {
        public SuaNV(string maNV, string tenNV, string diachi, string gioitinh, string ngaysinh, string sdt)
        {
            InitializeComponent();

            txtMaNhanVien.Text = maNV;
            txtTenNhanVien.Text = tenNV;
            txtDiaChi.Text = diachi;
            if (gioitinh == "Nam")
            {
                rdoNam.Checked = true;
            }
            else rdoNu.Checked = true;
            mskNgaySinh.Text = ngaysinh;
            mskSoDienThoai.Text = sdt;
        }

        DataTable tblNV;
        private void SuaNV_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sql;
            string gender;
            if (rdoNam.Checked == true)
            {
                gender = "Nam";
            }
            else gender = "Nữ";

            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Ban phai nhap giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sql = "UPDATE employees SET name=N'" + txtTenNhanVien.Text.ToString() + "',address=N'" + txtDiaChi.Text.ToString() + "',gender=N'" + gender + "',date_of_birth=N'" + Functions.ConvertDateTime(mskNgaySinh.Text) + "',phone=N'" + mskSoDienThoai.Text.ToString() + "' WHERE id=N'" + txtMaNhanVien.Text + "'";
            Functions.RunSql(sql);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            mskNgaySinh.Text = "  /  /";
            mskSoDienThoai.Text = "(   )     -";
        }
    }
}
