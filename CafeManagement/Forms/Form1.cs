

using Microsoft.Data.SqlClient;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn =  Database.DBConnect.GetConnection();
            if(conn != null)
            {
                MessageBox.Show("Kết nối thành công"); return;
            } 
        }
    }
}
