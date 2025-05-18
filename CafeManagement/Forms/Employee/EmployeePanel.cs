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
    public partial class EmployeePanel : UserControl
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNV addEmployee = new ThemNV();
            addEmployee.Show();
        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        DataTable tblNV;
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from employees";
            tblNV = Functions.GetDataToTable(sql);
            dgridNhanVien.DataSource = tblNV;
            dgridNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgridNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgridNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgridNhanVien.Columns[3].HeaderText = "Giới tính";
            dgridNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgridNhanVien.Columns[5].HeaderText = "Số điện thoại";
            dgridNhanVien.Columns[0].Width = 100;
            dgridNhanVien.Columns[1].Width = 100;
            dgridNhanVien.Columns[2].Width = 100;
            dgridNhanVien.Columns[3].Width = 100;
            dgridNhanVien.Columns[4].Width = 100;
            dgridNhanVien.Columns[5].Width = 100;

            dgridNhanVien.AllowUserToAddRows = false;
            dgridNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgridNhanVien.CurrentRow != null)
            {
                string maNV = dgridNhanVien.CurrentRow.Cells["id"].Value?.ToString();
                string tenNV = dgridNhanVien.CurrentRow.Cells["name"].Value?.ToString();
                string diachi = dgridNhanVien.CurrentRow.Cells["address"].Value?.ToString();
                string gioitinh = dgridNhanVien.CurrentRow.Cells["gender"].Value?.ToString();

                string ngaysinh = dgridNhanVien.CurrentRow.Cells["date_of_birth"].Value?.ToString();

                string sdt = dgridNhanVien.CurrentRow.Cells["phone"].Value?.ToString();

                SuaNV updateEmployee = new SuaNV(maNV, tenNV, diachi, gioitinh, ngaysinh, sdt);
                updateEmployee.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgridNhanVien.CurrentRow != null)
            {
                
                string maNV = dgridNhanVien.CurrentRow.Cells["id"].Value.ToString();

                // Hỏi xác nhận trước khi xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khách hàng có mã: " + maNV + "?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE employees WHERE id=N'" + maNV + "'";
                    Functions.RunSql(sql);
                    Load_DataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }
    }
}
