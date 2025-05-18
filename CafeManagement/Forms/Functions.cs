using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CafeManagement.Database; 

namespace CafeManagement.Forms
{
    class Functions
    {
        public static SqlConnection Conn;
        public static string connstring;
        public static DataTable GetDataToTable(string sql)
        {
            Conn = DBConnect.GetConnection();
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open(); 
            }
            SqlDataAdapter Mydata = new SqlDataAdapter();
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = Conn;
            Mydata.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
        }

        public static bool checkkey(string sql)
        {
            if (Conn == null || Conn.State == ConnectionState.Closed)
            {
                Conn = DBConnect.GetConnection(); 
            }

            SqlDataAdapter mydata = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            using (SqlConnection conn = DBConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
            {
                return true;
            }
            else return false;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = string.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
    }
}
