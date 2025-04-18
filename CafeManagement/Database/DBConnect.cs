using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement.Database
{
    internal class DBConnect
    {
        private static string connString = "Data Source=DESKTOP-RGO0IJA;Initial Catalog=cafe_mana;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return null;
            }
        }
    }
}
