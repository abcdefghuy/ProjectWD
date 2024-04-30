using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormCancel : Form
    {
        private string workerID;
        private string cv;
        public string WorkerID { get => workerID; set => workerID = value; }
        public string Cv { get => cv; set => cv = value; }
        public FormCancel()
        {
            InitializeComponent();
        }

        private void FormCancel_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format(@"SELECT CongViec.UserID, CongViec.Rate, DanhGia, HoTen, Avatar, CongViec.MaCongViec, CongViec.NgayLamViec, CongViec.WorkerID
                                        FROM CongViec 
                                        INNER JOIN UserInfoDB ON CongViec.UserID = UserInfoDB.UserID
                                        WHERE CongViec.WorkerID = '{0}' AND CongViec.TrangThai = 'Da huy' AND CongViec.MaCongViec='{1}'", workerID, Cv);
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
                    if (!reader.IsDBNull(4))
                    {
                        byte[] avt = (byte[])reader[4];
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                    flContainer.Controls.Add(uc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
