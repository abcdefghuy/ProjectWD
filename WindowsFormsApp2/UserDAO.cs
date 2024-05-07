using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Data.SqlTypes;
using System.IO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using ServiceStack;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text.RegularExpressions;
using Guna.Charts.WinForms;
using System.Reflection;
using MySqlX.XDevAPI.Common;

namespace WindowsFormsApp2
{
    public class UserDAO
    {
        ppConnection pp = new ppConnection();

        // tạo user mới
        public static void New_User(User user, string password)
        {
            string sqlStr = string.Format("INSERT INTO UserInfoDB VALUES ('{0}','{1}', '', '1/1/2000', '{2}', '{3}', '{4}', '', '', 5, null)", user.Id, user.Hoten, user.Sdt, user.Email, password);
            ppConnection.ThucThi(sqlStr);
        }
        // Edit thông tin
        public static void Edit_Info(User user)
        {
            string sqlStr = string.Format("Update UserInfoDB Set HoTen='{0}', DiaChi='{1}', NgaySinh='{2}', SDT='{3}', Email='{4}', GioiTinh='{5}', CCCD='{6}' Where UserID='{7}'", user.Hoten, user.Diachi, user.Ngaysinh, user.Sdt, user.Email, user.Gioitinh, user.Cccd, user.Id);
            ppConnection.ThucThi(sqlStr);
        }
        //Load lich su danh sách thợ
        public static List<UCHistoryWorker> Load_Worker(string userID)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec, MaDatTho " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where UserID='{0}' and TrangThai!='Cho nhan'", userID);
            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }
        //Load danh sách công việc thợ
        public static List<UCWorker> Load_CongViecTho(string tho)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar, CongViecThoDB.ChiTietCV, WorkerInfoDB.DiaChi " +
                              " From WorkerInfoDB, CongViecThoDB" +
                              " Where WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID and CongViecThoDB.CongViec = '{0}'", tho);
            return ppConnection.DanhSachTho(queryStr, tho);
        }
        // tìm kiếm thợ theo tên
        public static List<UCWorker> tim_kiem_Tho(string tho, string tentho)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar, CongViecThoDB.ChiTietCV, WorkerInfoDB.DiaChi  " +
                              " From WorkerInfoDB, CongViecThoDB" +
                              " Where WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID and CongViecThoDB.CongViec = '{0}' and HoTen Like '%{1}%'", tho, tentho);
            return ppConnection.DanhSachTho(queryStr, tho);
        }
        //Tim kiem theo so sao
        public static List<UCWorker> TimKiem_Star(string tho, int star)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar, CongViecThoDB.ChiTietCV, WorkerInfoDB.DiaChi  " +
                              " From WorkerInfoDB, CongViecThoDB" +
                              " Where WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID and CongViecThoDB.CongViec = '{0}' and WorkerInfoDB.Rate = {1}", tho, star);
            return ppConnection.DanhSachTho(queryStr, tho);
        }
        // check dang nhap
        public static bool check_Login(string sdt, string password)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM UserInfoDB WHERE SDT='{0}' AND Password='{1}'", sdt, password);
            return ppConnection.check_Login(sqlStr);
        }
        // tìm kiếm theo tên thợ trong form lịch sử
        public static List<UCHistoryWorker> Timkiem_Ten(string userID, string tentho)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec,MaDatTho " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where CongViec.UserID='{0}' and TrangThai!='Cho nhan' and HoTen Like '%{1}%'", userID, tentho);

            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }

        // Tìm kiếm theo ngày làm việc trong form lịch sử
        public static List<UCHistoryWorker> Timkiem_Ngay(string userID, DateTime startDay, DateTime endDay)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec,MaDatTho " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where CongViec.UserID='{0}' and TrangThai!='Cho nhan' and NgayLamViec Between '{1}' and '{2}'", userID, startDay.Date, endDay.Date);

            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }
        //Tinh rate trung binh cua tho
        public static void Average_Rate(string workerID)
        {
            int rate = Rating(workerID);
            string queryString = string.Format("Update WorkerInfoDB Set Rate = {0} Where WorkerID = '{1}'", rate, workerID);
            ppConnection.ThucThi(queryString);
        }
        //Load thông tin user
        public static User Load_info_User(string userID)
        {
            User user = new User();
            string queryString = string.Format("Select * From UserInfoDB Where UserID = '{0}'", userID);
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        user.Hoten = reader.GetString(1);
                        user.Diachi = reader.GetString(2);
                        user.Ngaysinh = reader.GetDateTime(3);
                        user.Sdt = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.Gioitinh = reader.GetString(7);
                        user.Cccd = reader.GetString(8);
                        if (reader.IsDBNull(10))
                        {
                            //
                        }
                        else
                        {
                            object value = reader[10];
                            user.Avatar = (byte[])value;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Khong load dc" + userID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();

            }
            return user;
        }

        public static int Rating(string ID)
        {
            int rate = 0;
            string query = string.Format("SELECT AVG(Rate) FROM CongViec WHERE WorkerID = '{0}' group by WorkerID ", ID);
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                rate = Convert.ToInt32(reader.GetInt32(0)); // Chuyển đổi từ kiểu decimal sang int
                            }
                            else
                            {
                                // Xử lý trường hợp NULL nếu cần
                            }
                        }
                        else
                        {
                            // Xử lý trường hợp không tìm thấy bản ghi nếu cần
                        }
                    }
                }
            }
            return rate;
        }

        //Load thong tin chi tiet tho
        public static Worker Load_ChiTiet_Worker(string workerID, string congviec)
        {
            Worker worker = new Worker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select CongViecThoDB.WorkerID, KinhNghiem, TienCong, TgLamViecWeek, TgLamViecDay, ChiTietCV, HoTen, SDT, CongViec, WorkerInfoDB.Rate, Avatar, GioiTinh, NgaySinh " +
                                                   " From CongViecThoDB, WorkerInfoDB" +
                                                   " Where CongViecThoDB.WorkerID=WorkerInfoDB.WorkerID and CongViecThoDB.WorkerID='{0}' and CongViecThoDB.CongViec='{1}'", workerID, congviec);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    worker.Hoten = reader[6].ToString();
                    worker.Sdt = reader[7].ToString();
                    worker.Congviec.KinhNghiem = reader[1].ToString();
                    worker.Congviec.TienCong = reader[2].ToString();
                    worker.Congviec.TgLamViecWeek = reader[3].ToString();
                    worker.Congviec.TgLamViecDay = reader[4].ToString();
                    worker.Congviec.ChiTietCV = reader[5].ToString();
                    worker.Rate = Rating(reader.GetString(0));
                    worker.Congviec.CongViec = reader[8].ToString();
                    worker.Ngaysinh = reader.GetDateTime(12);
                    worker.Gioitinh = reader.GetString(11);
                    if (reader.IsDBNull(10))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[10];
                        worker.Avatar = (byte[])value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return worker;
        }
        //load comment danh gia tho
        public static List<UCComment> Load_Comment(string workerID, string cv)
        {
            List<UCComment> comments = new List<UCComment>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select CongViec.UserID, CongViec.Rate, DanhGia, HoTen, Avatar, CongViec.MaCongViec, CongViec.NgayLamViec, CongViec.WorkerID, CongViec.MaDatTho " +
                                                " From CongViec inner join UserInfoDB on CongViec.UserID = UserInfoDB.UserID" +
                                                " Where CongViec.WorkerID='{0}' and CongViec.MaCongViec='{1}'", workerID, cv);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCComment uc = new UCComment();
                    uc.UserID = reader[0].ToString();
                    uc.WorkerID = reader[7].ToString();
                    uc.CongViec = reader[5].ToString();
                    uc.LblName.Text = reader[3].ToString();
                    uc.Rating.Value = reader.GetInt32(1);
                    uc.TxbDanhgia.Text = reader[2].ToString();
                    uc.Lbl_Congviec.Text = "Công việc: " + reader[5].ToString();
                    uc.Lbl_NgayLamViec.Text = "Ngày làm việc: " + reader.GetDateTime(6).ToString("dd/MM/yyyy");
                    uc.Ma = reader[8].ToString();
                    if (reader.IsDBNull(4))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[4];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                    comments.Add(uc);
                }
                reader.Close();
                //load anh danh gia
                foreach (UCComment comment in comments)
                {
                    string queryImg = string.Format("Select * From ImgDanhGia Where UserID='{0}' and WorkerID='{1}' and MaCongViec='{2}' and MaDon='{3}'", comment.UserID, comment.WorkerID, comment.CongViec,comment.Ma);
                    List<PictureBox> listImg = new List<PictureBox>();
                    SqlCommand cmd2 = new SqlCommand(queryImg, conn);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Click += ppConnection.ZoomImage;
                        MemoryStream ms = new MemoryStream((byte[])reader2[3]);
                        pictureBox.Image = Image.FromStream(ms);
                        listImg.Add(pictureBox);
                    }
                    reader2.Close();
                    foreach (PictureBox img in listImg)
                    {
                        comment.Panel_Anh.Controls.Add(img);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return comments;
        }
        //load lich su tho
        public static Worker History_Worker(string maDatHang)
        {
            Worker worker = new Worker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select WorkerInfoDB.WorkerID, HoTen, ThanhToan, NgayLamViec, CongViec.Rate, DanhGia From WorkerInfoDB, CongViec Where WorkerinfoDB.WorkerID=CongViec.WorkerID and MaDatTho='{0}'", maDatHang);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    worker.Hoten = reader[1].ToString();
                    worker.Cv.Thanhtoan = reader[2].ToString();
                    worker.Cv.NgayLamViec = reader.GetDateTime(3);
                    worker.Cv.Rate = reader.GetInt32(4);
                    worker.Cv.DanhGia = reader[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return worker;
        }
        public static Worker Deni_Worker(string maDatHang)
        {
            Worker worker = new Worker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select A.WorkerID , Hoten,CongViec.NgayLamViec,LyDoHuy  from (Select WorkerInfoDB.WorkerID , Hoten, LyDoHuy from WorkerInfoDB " +
                    "inner join DSThoBiHuy on WorkerInfoDB.WorkerID = DSThoBiHuy.WorkerID where MaDon='{0}') as A \r\n" +
                    "inner join CongViec on A.WorkerID=CongViec.WorkerID where CongViec.MaDatTho='{1}'", maDatHang, maDatHang);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    worker.Hoten = reader[1].ToString();
                    worker.Cv.NgayLamViec = reader.GetDateTime(2);
                    worker.Cv.DanhGia = reader[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return worker;
        }
        //Danh gia tho
        public static void Danhgia_Worker(int rate, string danhgia, string workerID, string userID, string madat)
        {
            int thanhtoan = ThanhToan_Worker(workerID, userID, madat);
            string queryString = string.Format("Update CongViec Set Rate='{0}', DanhGia='{1}', TrangThai = 'Da hoan thanh', ThanhToan = '{3}' " +
                                                    " Where MaDatTho='{2}'", rate, danhgia, madat, thanhtoan);
            ppConnection.ThucThi(queryString);
            Average_Rate(workerID);
        }

        //Order tho
        public static void Order_Worker(string userID, string congviec, DateTime ngaylamviec, string giolamviec, string ghichi, string workerID, string diachi, string giatien)
        {
            string uniqueOrderID = GenerateUniqueOrderID();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

            try
            {
                conn.Open();
                string queryString = string.Format("Insert Into CongViec Values('{0}', '{1}', '{2}', '{3}', '{4}','Cho nhan', 0, 0, '{5}', ' ', '{6}', '{7}','{8}')",
                                                    userID, congviec, ngaylamviec.Date, giolamviec, ghichi, workerID, diachi, giatien, uniqueOrderID);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageForm f = new MessageForm();
                    f.ShowDialog(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + UserForm.UserID);
            }
            finally { conn.Close(); }
        }
        // luu anh
        public static void Save_Anh(string userID, byte[] imageData)
        {
            //string queryString = string.Format("DECLARE @varbinaryData VARBINARY(MAX) = CONVERT(VARBINARY(MAX), '{0}')\nUPDATE UserInfoDB SET Avatar = @varbinaryData Where UserID = '{1}'", imageData, userID);
            string queryString = string.Format("Update UserInfoDB Set Avatar = @avatar Where UserID = @userid");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string sqlStr = queryString;
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@avatar", imageData);

                if (cmd.ExecuteNonQuery() > 0)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }




        //Hiển thị thợ yêu thích
        public static List<UCWorkerYT> Load_ThoYT(string userID)
        {
            List<UCWorkerYT> workerList = new List<UCWorkerYT>();
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, HoTen, SDT, Rate, Avatar, DiaChi " +
                                            " From WorkerInfoDB inner join ThoYeuThich on WorkerInfoDB.WorkerID = ThoYeuThich.WorkerID_YT" +
                                            " Where ThoYeuThich.UserID = '{0}'", userID);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {

                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCWorkerYT uc = new UCWorkerYT();
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader[2].ToString();
                    uc.LblDiaChi.Text = "Địa chỉ: " + reader[4].ToString();
                    uc.Rating.Value = reader.GetInt32(3);

                    if (!reader.IsDBNull(4))
                    {
                        object value = reader[4];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.PtbAvt.Image = Image.FromStream(ms);
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

        // Danh dau tho yeu thich
        public static void DanhDau_ThoYT(string userID, string workerID)
        {
            string queryString = string.Format("Insert into ThoYeuThich values('{0}', '{1}')", userID, workerID);
            ppConnection.ThucThi(queryString);
        }

        // Lọc theo trạng thái công việc
        public static List<UCHistoryWorker> DaHoanThanh(string userID, string trangthai)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec,MaDatTho " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where CongViec.UserID='{0}' and TrangThai='{1}'", userID, trangthai);
            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }
        public static int ThanhToan_Worker(string workerID, string userID, string maDat)
        {
            int gio = 0;
            int tien = 0;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string query = string.Format("Select GioLamViec, TienCong from CongViec where UserID='{0}' and WorkerID='{1}' and MaDattho='{2}'", userID, workerID, maDat);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    gio = reader.GetInt32(0);
                    tien = Convert.ToInt32(reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return gio * tien;

        }
        public static List<UCWorker> TimKiem_TopYeuThich(string congviec, int topCount)
        {
            string queryStr = string.Format(@"
                    Select Distinct A.WorkerID, A.HoTen, A.SDT, A.KinhNghiem, A.TienCong, A.Rate, Avatar, A.ChiTietCv, A.DiaChi   Solan
                    From(Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar, CongViecThoDB.ChiTietCv, WorkerInfoDB.DiaChi  From WorkerInfoDB inner join CongViecThoDB on WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID 
                    Where CongViec = '{0}') as A, (SELECT WorkerID_YT, Count(WorkerID_YT) as SoLan FROM ThoYeuThich GROUP BY WorkerID_YT HAVING COUNT(*) = (SELECT MAX(counts) FROM(SELECT COUNT(*) AS counts FROM ThoYeuThich GROUP BY WorkerID_YT) AS counts)) as Q
                    Where A.WorkerID = Q.WorkerID_YT", congviec);

            return ppConnection.DanhSachTho(queryStr, congviec);
        }
        static string GenerateUniqueOrderID()
        {
            // Lấy thời gian hiện tại
            DateTime now = DateTime.Now;
            // Lấy các thành phần ngày, tháng, năm
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            // Tạo một phần ngẫu nhiên
            Random random = new Random();
            int randomNumber = random.Next(0, 9999999); // Số ngẫu nhiên từ 1000 đến 9999
            // Kết hợp thời gian và số ngẫu nhiên để tạo mã đơn đặt thợ
            string uniqueOrderID = string.Format("{0:yyyyMMddHHmmss}{1}{2}{3}", now, day, month, year);
            return uniqueOrderID;
        }

        public static List<UCActiviti> Load_Worker_Activity(string userID)
        {
            List<UCActiviti> workerList = new List<UCActiviti>();
            string queryStr = string.Format("SELECT w.WorkerID, cv.NgayLamViec, cv.TrangThai, cv.ThanhToan, cv.Rate, w.HoTen, w.Avatar, cv.MaCongViec,cv.MaDatTho " +
                                            "FROM CongViec cv " +
                                            "INNER JOIN WorkerInfoDB w ON cv.WorkerID = w.WorkerID " +
                                            "WHERE cv.UserID = '{0}' AND(cv.TrangThai = 'Cho nhan' OR cv.TrangThai = 'Da nhan')", userID);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {

                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCActiviti uc = new UCActiviti();
                    uc.UserID = userID;
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(5);
                    uc.Rating.Value = reader.GetInt32(4);
                    uc.LblTienThanhtoan.Text = "Đã thanh toán: " + reader.GetString(3);
                    uc.LblNgay.Text = "Ngày làm việc: " + reader.GetDateTime(1).ToString("dd/MM/yyyy");
                    uc.Cv = reader.GetString(7);
                    uc.Ma = reader.GetString(8);
                    uc.Lbl_TrangThai.Text = "Trạng thái: " + reader.GetString(2);

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
        public static void Huy_Worker(string userID, string workerID, string congviec, string ma, string lydo)
        {
            string queryString = string.Format("Update CongViec Set TrangThai = 'Da huy' Where MaDatTho='{0}'\r\n" +
                "Insert into DSThoBiHuy Values ('{1}','{2}','{3}','{0}','{4}')", ma, userID, workerID, congviec, lydo);
            ppConnection.ThucThi(queryString);


        }
        public static List<UCWorker> TopDoanhThu_Worker(string congviec)
        {
            string queryString = string.Format("SELECT DISTINCT WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, A.DiaChi  " +
                                                "CongViecThoDB.TienCong, WorkerInfoDB.Rate, WorkerInfoDB.Avatar, CongViecThoDB.ChiTietCV, WorkerInfoDB.DiaChi  \r\nFROM WorkerInfoDB \r\nINNER JOIN CongViecThoDB ON WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID " +
                                                "\r\nWHERE WorkerInfoDB.WorkerID = (\r\n    SELECT TOP 10 WorkerID\r\n    FROM (\r\n        SELECT WorkerID, SUM(CAST(ThanhToan AS INT)) AS ThuNhap \r\n        " +
                                                "FROM CongViec \r\n        WHERE MaCongViec = '{0}' \r\n        GROUP BY WorkerID\r\n    ) AS Subquery\r\n    ORDER BY ThuNhap DESC\r\n)", congviec);
            return ppConnection.DanhSachTho(queryString, congviec);
        }

        //tim kiem top booking
        public static List<UCWorker> TopBooking(string congviec)
        {
            string queryString = string.Format("Select Distinct A.WorkerID, A.HoTen, A.SDT, A.KinhNghiem, A.TienCong, A.Rate, Avatar, A.ChiTietCV, A.DiaChi  Solan\r\n" +
                "From (Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar, CongViecThoDB.ChiTietCv, WorkerInfoDB.DiaChi  " +
                "From WorkerInfoDB inner join CongViecThoDB on WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID Where CongViec = '{0}') as A, " +
                "(SELECT WorkerID, Count(WorkerID) as SoLan FROM CongViec GROUP BY WorkerID HAVING COUNT(*) = (SELECT MAX(counts) FROM (SELECT COUNT(*) AS counts " +
                "FROM CongViec GROUP BY WorkerID) AS counts)) as Q\r\nWhere A.WorkerID = Q.WorkerID", congviec);
            return ppConnection.DanhSachTho(queryString, congviec);

        }
        public static List<UCWorkerCancel> XemThoBiHuy(string tho)
        {
            List<UCWorkerCancel> list = new List<UCWorkerCancel>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);


            string query = @"SELECT w.WorkerID, w.HoTen, w.SDT, w.Avatar, cv.MaCongViec, COUNT(cv.CongViecID) AS CancelledJobsCount
                         FROM CongViec cv
                         INNER JOIN WorkerInfoDB w ON cv.WorkerID = w.WorkerID
                         WHERE cv.TrangThai = 'Da huy' AND cv.MaCongViec = @MaCongViec
                         GROUP BY w.WorkerID, w.HoTen, w.SDT, w.Avatar, cv.MaCongViec
                         ORDER BY CancelledJobsCount DESC";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@MaCongViec", tho);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    UCWorkerCancel uc = new UCWorkerCancel();
                    uc.WorkerID = reader["WorkerID"].ToString();
                    uc.Cv = reader["MaCongViec"].ToString();
                    uc.LblName.Text = "Họ tên: " + reader["HoTen"].ToString();
                    uc.LblPhone.Text = "Số điện thoại: " + reader["SDT"].ToString();
                    uc.LblHuy.Text = "Số lượt bị hủy: " + reader["CancelledJobsCount"].ToString();

                    if (reader["Avatar"] != DBNull.Value)
                    {
                        byte[] avt = (byte[])reader["Avatar"];
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }

                    list.Add(uc);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return list;
        }

        // Thêm bài đăng user
        public static void ThemBaiDang(string maCV, string userID, string congViec, string diaChi, string chiTiet, DateTime ngayLamViec, List<Image> listImage)
        {
            string queryString = string.Format("Insert Into CongViecUser Values ('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", userID, congViec, diaChi, chiTiet, maCV, ngayLamViec);
            ppConnection.ThucThi(queryString);
            // thêm ảnh của bài đăng
            ThemAnhBaiDang(maCV, listImage);
        }

        // Thêm ảnh bài đăng
        public static void ThemAnhBaiDang(string maCV, List<Image> listImage)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            string queryString_img = "Insert Into ImgCongViecUser Values(@maCV, @img)";
            conn.Open();
            foreach (Image image in listImage)
            {
                try
                {
                    byte[] imageByteArray = ImageToByteArray(image);
                    SqlCommand cmd = new SqlCommand(queryString_img, conn);
                    cmd.Parameters.AddWithValue("@maCV", maCV);
                    cmd.Parameters.AddWithValue("@img", imageByteArray);
                    if (cmd.ExecuteNonQuery() > 0) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            conn.Close();
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static List<UCPost> DanhSachBaiDang(string queryString)
        {
            List<UCPost> UCPosts = new List<UCPost>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCPost uc = new UCPost("User");
                    uc.MaCV = reader[0].ToString();
                    uc.HoTen.Text = reader[1].ToString();
                    uc.CongViec.Text = reader[3].ToString();
                    uc.ChiTiet.Text = reader[4].ToString();
                    uc.NgayLamViec.Text = reader.GetDateTime(5).ToString("dd/MM/yyyy");
                    if (!reader.IsDBNull(2))
                    {
                        object value = reader[2];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Avatar.Image = Image.FromStream(ms);
                    }
                    UCPosts.Add(uc);
                }
                reader.Close();
                // Load ảnh bài đăng 
                foreach (UCPost ucpost in UCPosts)
                {
                    string queryImg = string.Format("Select * From ImgCongViecUser Where MaCongViec = '{0}'", ucpost.MaCV);
                    List<PictureBox> listImg = new List<PictureBox>();
                    SqlCommand cmd2 = new SqlCommand(queryImg, conn);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Click += ppConnection.ZoomImage;
                        MemoryStream ms = new MemoryStream((byte[])reader2[1]);
                        pictureBox.Image = Image.FromStream(ms);
                        listImg.Add(pictureBox);
                    }
                    reader2.Close();
                    foreach (PictureBox img in listImg)
                    {
                        ucpost.PanelAnh.Controls.Add(img);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }

            return UCPosts;
        }

        //Load danh sách các bài đăng 
        public static List<UCPost> DanhSachPost(string userID)
        {
            string queryString = string.Format("Select CongViecUser.MaCongViec, UserInfoDB.HoTen, UserInfoDB.Avatar, CongViecUser.CongViec, CongViecUser.ChiTiet, CongViecUser.NgayLamViec" +
                                                " From CongViecUser inner join UserInfoDB on CongViecUser.UserID=UserInfoDB.UserID" +
                                                " Where CongViecUser.UserID = '{0}'", userID);
            return DanhSachBaiDang(queryString);
        }

        // Chi tiết bài đăng
        public static CongViecUser chiTietBaiDang(string maCV)
        {
            CongViecUser cvUser = new CongViecUser();
            string queryString = string.Format("Select * From CongViecUser Where MaCongViec='{0}'", maCV);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    cvUser.UserID = reader[0].ToString();
                    cvUser.CongViec = reader[1].ToString();
                    cvUser.DiaChi = reader[2].ToString();
                    cvUser.ChiTiet = reader[3].ToString();
                    cvUser.NgayLamViec = reader.GetDateTime(5);
                }
                reader.Close();
                // Load ảnh bài đăng 
                string queryImg = string.Format("Select * From ImgCongViecUser Where MaCongViec = '{0}'", maCV);
                SqlCommand cmd2 = new SqlCommand(queryImg, conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                List<Image> imgList = new List<Image>();
                while (reader2.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])reader2[1]);
                    imgList.Add(Image.FromStream(ms));
                }
                cvUser.ImgList = imgList;
                reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            return cvUser;
        }

        // Xóa bài đăng
        public static void XoaBaiDang(string maCV)
        {
            string queryString = string.Format("Delete From CongViecUser Where MaCongViec='{0}'" +
                                            "\r\nDelete From ImgCongViecUser Where MaCongViec='{0}'", maCV);
            ppConnection.ThucThi(queryString);
        }
        //Load thợ quan tâm
        public static List<UCWorker> ThoQuanTam(string maCV, string cv)
        {
            List<UCWorker> workerList = new List<UCWorker>();
            string queryString = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar, CongViecThoDB.ChiTietCV, WorkerInfoDB.DiaChi  " +
                                            "From WorkerInfoDB inner join CongViecThoDB on WorkerInfoDB.WorkerID=CongViecThoDB.WorkerID " +
                                            "Where WorkerInfoDB.WorkerID IN (Select WorkerID From ThoQuanTam Where MaBaiDang='{0}') and CongViecThoDB.CongViec='{1}'", maCV, cv);
            return ppConnection.DanhSachTho(queryString, cv);
        }
        // lọc bài đăng theo ngày
        public static List<UCPost> BaiDangTheoNgay(string userID, DateTime start_day, DateTime end_day)
        {
            string queryString = string.Format("Select CongViecUser.MaCongViec, UserInfoDB.HoTen, UserInfoDB.Avatar, CongViecUser.CongViec, CongViecUser.ChiTiet, CongViecUser.NgayLamViec" +
                                                " From CongViecUser inner join UserInfoDB on CongViecUser.UserID=UserInfoDB.UserID" +
                                                " Where CongViecUser.UserID = '{0}' and CongViecUser.NgayLamViec Between '{1}' and '{2}'", userID, start_day.Date, end_day.Date);
            return DanhSachBaiDang(queryString);
        }
        public static List<UCPost> BaiDangTheoCongViec(string userID, string congViec)
        {
            string queryString = string.Format("Select CongViecUser.MaCongViec, UserInfoDB.HoTen, UserInfoDB.Avatar, CongViecUser.CongViec, CongViecUser.ChiTiet, CongViecUser.NgayLamViec" +
                                                " From CongViecUser inner join UserInfoDB on CongViecUser.UserID=UserInfoDB.UserID" +
                                                " Where CongViecUser.UserID = '{0}' and CongViecUser.CongViec='{1}'", userID, congViec);
            return DanhSachBaiDang(queryString);
        }
    }
}