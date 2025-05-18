using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Forms.Customer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CafeManagement.Forms
{
    public partial class CustomerPanel : UserControl
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKH addCustomer = new ThemKH();
            addCustomer.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgridKH.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn
                string maKH = dgridKH.CurrentRow.Cells["id"].Value?.ToString();
                string tenKH = dgridKH.CurrentRow.Cells["name"].Value?.ToString();
                string sdt = dgridKH.CurrentRow.Cells["phone"].Value?.ToString();

                // Mở form sửa và truyền dữ liệu
                SuaKH upadateCustomer = new SuaKH(maKH, tenKH, sdt);
                upadateCustomer.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
            }


        }

        DataTable tblKH;
        private void Load_DataGridView()
        {

            string sql;
            sql = "select id, name, phone from customers";
            tblKH = Functions.GetDataToTable(sql);
            dgridKH.DataSource = tblKH;
            dgridKH.Columns[0].HeaderText = "Mã khách hàng";
            dgridKH.Columns[1].HeaderText = "Tên khách hàng";
            dgridKH.Columns[2].HeaderText = "Số điện thoại ";
            dgridKH.Columns[0].Width = 100;
            dgridKH.Columns[1].Width = 100;
            dgridKH.Columns[2].Width = 100;

            dgridKH.AllowUserToAddRows = false;
            dgridKH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void dgridKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            dgridKH.BringToFront();
            Load_DataGridView();
        }

        private void dgridKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgridKH_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgridKH.CurrentRow != null)
            {
                // Lấy mã khách hàng từ dòng được chọn
                string maKH = dgridKH.CurrentRow.Cells["id"].Value.ToString();

                // Hỏi xác nhận trước khi xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khách hàng có mã: " + maKH + "?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE customers WHERE id=N'" + maKH + "'";
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
