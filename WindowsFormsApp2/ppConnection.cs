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
                    MessageBox.Show("Da thuc hien hanh dong thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thuc hien hanh dong that bai" + ex);
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
        public static List<UCHistoryCustomer> load_Tim_kiem_KhachHang(string queryStr, string workerID)
        {
            List<UCHistoryCustomer> userList = new List<UCHistoryCustomer>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCHistoryCustomer uc = new UCHistoryCustomer();
                    uc.WorkerID = workerID;
                    uc.UserID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(5);
                    uc.Rating.Value = reader.GetInt32(4);
                    uc.LblTienThanhtoan.Text = "Đã thanh toán: " + reader.GetString(3);
                    uc.LblNgay.Text = "Ngày làm việc: " + (reader.GetDateTime(1)).ToString("dd/MM/yyyy");
                    uc.Lbl_TrangThai.Text = "Trạng thái: " + reader[2].ToString();
                    uc.Cv = reader.GetString(7);
                    uc.Ma = reader.GetString(8);
                    if (!reader.IsDBNull(6))
                    {
                        object value = reader[6];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }

                    userList.Add(uc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return userList;
        }
        public static List<UCHistoryWorker> load_Tim_Kiem_Tho(string queryStr, string userID)
        {
            List<UCHistoryWorker> workerList = new List<UCHistoryWorker>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {

                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCHistoryWorker uc = new UCHistoryWorker();
                    uc.UserID = userID;
                    uc.WorkerID = reader.GetString(0);
                    uc.Cv = reader.GetString(7);
                    uc.MaDat = reader.GetString(8);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(5);
                    uc.Rating.Value = reader.GetInt32(4);
                    uc.LblTienThanhtoan.Text = "Đã thanh toán: " + reader.GetString(3);
                    uc.LblNgay.Text = "Ngày làm việc: " + (reader.GetDateTime(1)).ToString("dd/MM/yyyy");
                    uc.Cv = reader[7].ToString();
                    uc.Lbl_TrangThai.Text = "Trạng thái: " + reader[2].ToString();
                    if (!reader.IsDBNull(6))
                    {
                        object value = reader[6];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }

                    workerList.Add(uc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            return workerList;
        }
        public static List<UCWorker> DanhSachTho(string querry, string tho)
        {
            List<UCWorker> workerList = new List<UCWorker>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlConnection cnn = new SqlConnection(Properties.Settings.Default.connStr);
                cnn.Open();
                SqlCommand sqlCommand = new SqlCommand(querry, cnn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCWorker uc = new UCWorker();
                    uc.Cv = tho;
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader.GetString(2);
                    uc.LblKinhnghiem.Text = "Kinh nghiệm: " + reader.GetString(3);
                    uc.LblTiencong.Text = "Tiền công: " + reader.GetString(4);
                    uc.Rating.Value = reader.GetInt32(5);
                    uc.MoTa.Text = reader.GetString(7);
                    uc.LblDiaChi.Text = "Địa chỉ: " + reader.GetString(8);
                    if (!reader.IsDBNull(6))
                    {
                        object value = reader[6];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }

                    workerList.Add(uc);
                }
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return workerList;
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
        public static void ZoomImage(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            // Check if close icon is clicked (optional, skip zooming if close icon)

            // Create a new Form for zooming
            Form zoomForm = new Form();
            zoomForm.Height = 400;
            zoomForm.Width = 600;
            //zoomForm.WindowState = FormWindowState.Maximized; // Maximize zoom form
            zoomForm.StartPosition = FormStartPosition.CenterScreen;
            zoomForm.Name = "Image";
            // Create a larger PictureBox for zoomed image
            PictureBox zoomedPictureBox = new PictureBox();
            zoomedPictureBox.Image = pictureBox.Image; // Assign image from clicked PictureBox
            zoomedPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust size as needed
            zoomedPictureBox.Dock = DockStyle.Fill; // Fill the entire zoom form

            // Add zoomedPictureBox to the zoomForm
            zoomForm.Controls.Add(zoomedPictureBox);

            // Show the zoom form
            zoomForm.Show();
        }

    }
}