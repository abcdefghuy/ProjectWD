using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Data;

namespace WindowsFormsApp2
{
    public class ppConnection
    {
        public ppConnection() { }
        public static void ThucThi(string sqlString)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string sqlStr = sqlString;
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Đã thực hiện hành động thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực hiện hành động thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public static SqlDataReader load(string sqlString)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                return reader;
            }
        }
        public static DataTable Load_ThongKe(string sqlStr)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            DataTable dtTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally { conn.Close(); }
            return dtTable;
        }
        public static bool check_Login(string sqlStr)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            if ((int)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Số điện thoại hoặc password không đúng");
                conn.Close();
                return false;
            }
        }
       

    }
}