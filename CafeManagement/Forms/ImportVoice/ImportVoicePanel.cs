using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Forms.SaleInvoice;

namespace CafeManagement.Forms.ImportVoice
{
    public partial class ImportVoicePanel : UserControl
    {
        public ImportVoicePanel()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            ThemHDN addImportInvoice = new ThemHDN();
            addImportInvoice.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgridHDN.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                string maHDN = dgridHDN.CurrentRow.Cells["id"].Value?.ToString();
                string ngayNhap = dgridHDN.CurrentRow.Cells["import_date"].Value?.ToString();
                string maNV = dgridHDN.CurrentRow.Cells["employee_id"].Value?.ToString();
                string maNCC = dgridHDN.CurrentRow.Cells["supplier_id"].Value?.ToString();
                string tongTien = dgridHDN.CurrentRow.Cells["total_amount"].Value?.ToString();


                SuaHDN suaHoaDonNhap = new SuaHDN(maHDN, ngayNhap, maNV, maNCC, tongTien);
                suaHoaDonNhap.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn nhập để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        DataTable tblHDN;
        private void Load_DataGridView_HDN()
        {
            string sql = "SELECT id, import_date, employee_id, supplier_id, total_amount FROM import_invoices";
            DataTable tblHDN = Functions.GetDataToTable(sql);
            dgridHDN.DataSource = tblHDN;

            dgridHDN.Columns[0].HeaderText = "Mã Hóa Đơn Nhập";
            dgridHDN.Columns[1].HeaderText = "Ngày Nhập";
            dgridHDN.Columns[2].HeaderText = "Mã Nhân Viên";
            dgridHDN.Columns[3].HeaderText = "Mã Nhà Cung Cấp";
            dgridHDN.Columns[4].HeaderText = "Tổng Tiền";

            dgridHDN.Columns[0].Width = 120;
            dgridHDN.Columns[1].Width = 100;
            dgridHDN.Columns[2].Width = 100;
            dgridHDN.Columns[3].Width = 120;
            dgridHDN.Columns[4].Width = 100;

            dgridHDN.AllowUserToAddRows = false;
            dgridHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgridHDN.CurrentRow != null)
            {
                // Lấy mã hóa đơn nhập từ dòng được chọn
                string maHDN = dgridHDN.CurrentRow.Cells["id"].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn nhập có mã: " + maHDN + "?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Nếu có bảng chi tiết hóa đơn nhập, xóa trước
                    string sqlChiTiet = "DELETE FROM ChiTietHDN WHERE id = N'" + maHDN + "'";
                    Functions.RunSql(sqlChiTiet);

                    // Sau đó xóa hóa đơn chính
                    string sql = "DELETE FROM HoaDonNhap WHERE id = N'" + maHDN + "'";
                    Functions.RunSql(sql);

                    // Tải lại danh sách hóa đơn nhập
                    Load_DataGridView_HDN();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn nhập để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgridHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImportVoicePanel_Load(object sender, EventArgs e)
        {
            Load_DataGridView_HDN();
        }
    }
}

