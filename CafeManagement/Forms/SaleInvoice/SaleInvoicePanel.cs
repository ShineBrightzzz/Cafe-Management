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
    public partial class SaleInvoicePanel : UserControl
    {
        public SaleInvoicePanel()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHDB addSaleInvoice = new ThemHDB();
            addSaleInvoice.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgridHDB.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                string maHDB = dgridHDB.CurrentRow.Cells["id"].Value?.ToString();
                string ngayBan = dgridHDB.CurrentRow.Cells["sale_date"].Value?.ToString();
                string maNV = dgridHDB.CurrentRow.Cells["employee_id"].Value?.ToString();
                string maKH = dgridHDB.CurrentRow.Cells["customer_id"].Value?.ToString();
                string tongTien = dgridHDB.CurrentRow.Cells["total_amount"].Value?.ToString();

                // Mở form sửa và truyền dữ liệu
                SuaHDB suaHoaDonBan = new SuaHDB(maHDB, ngayBan, maNV, maKH, tongTien);
                suaHoaDonBan.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.");
            }

        }
        DataTable tblHDB;
        private void Load_DataGridView_HDB()
        {
            string sql;
            sql = "SELECT id, sale_date, employee_id, customer_id, total_amount FROM sale_invoices"; // Đổi tên bảng nếu cần
            DataTable tblHDB = Functions.GetDataToTable(sql);
            dgridHDB.DataSource = tblHDB;


            dgridHDB.Columns[0].HeaderText = "Mã Hóa Đơn Bán";
            dgridHDB.Columns[1].HeaderText = "Ngày Bán";
            dgridHDB.Columns[2].HeaderText = "Mã Nhân Viên";
            dgridHDB.Columns[3].HeaderText = "Mã Khách Hàng";
            dgridHDB.Columns[4].HeaderText = "Tổng Tiền";

            dgridHDB.Columns[0].Width = 120;
            dgridHDB.Columns[1].Width = 100;
            dgridHDB.Columns[2].Width = 100;
            dgridHDB.Columns[3].Width = 100;
            dgridHDB.Columns[4].Width = 100;


            dgridHDB.AllowUserToAddRows = false;
            dgridHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridHDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgridHDB.CurrentRow != null)
            {
                // Lấy mã hóa đơn bán từ dòng được chọn
                string maHDB = dgridHDB.CurrentRow.Cells["id"].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hóa đơn có mã: " + maHDB + "?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM sale_invoices WHERE id = N'" + maHDB + "'";
                    Functions.RunSql(sql); // Xóa dữ liệu
                    Load_DataGridView_HDB(); // Tải lại danh sách hóa đơn
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.");
            }
        }

        private void SaleInvoicePanel_Load(object sender, EventArgs e)
        {
            Load_DataGridView_HDB();
        }
    }
}













