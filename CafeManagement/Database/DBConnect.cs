using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace CafeManagement.Database
{
    internal class DBConnect
    {
        private static string connString;

        static DBConnect()
        {
            connString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Không tìm thấy chuỗi kết nối. Vui lòng kiểm tra file .env!");
            }
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var conn = new SqlConnection(connString);
                conn.Open();
                MessageBox.Show("Kết nối thành công!");
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return null;
            }
        }

        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
