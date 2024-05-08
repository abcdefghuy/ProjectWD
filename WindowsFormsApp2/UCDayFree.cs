using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UCDayFree : UserControl
    {
        public string workerID;
        public UCDayFree()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lblday.Text = numday + "";
        }

        private void UCDayFree_Load(object sender, EventArgs e)
        {
            UCDayFree uc = new UCDayFree();
            DateTime date = new DateTime(OrderCustomerForm.static_year, OrderCustomerForm.static_month, int.Parse(lblday.Text));
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select HoTen " +
                                                    "From UserInfoDB inner join CongViec on UserInfoDB.UserID=CongViec.UserID " +
                                                    "Where WorkerID = '{0}' and NgayLamViec = '{1}' and TrangThai='Đã nhận'", workerID, date.Date);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl_sukien.Text = "Đã có khách hàng";
                    this.BackColor = Color.Salmon;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            
            if(this.BackColor == Color.Salmon)
            {
                btn_datlich.Visible = false;
            }

        }
        public event EventHandler<DateTime> NgayDuocChon;

        private void btn_datlich_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm is OrderCustomerForm)
            {
                DateTime selectedDate = LayNgayDuocChon();
                ((OrderCustomerForm)parentForm).NhanNgayDuocChon(selectedDate);
                ((OrderCustomerForm)parentForm).Close();
            }
        }
        public DateTime LayNgayDuocChon()
        {
            // Lấy ngày từ các thành phần UI trong UserControl của bạn.
            // Ví dụ: 
            int ngay = int.Parse(lblday.Text);
            // Tạo ngày từ ngày, tháng, năm hiện tại và ngày được chọn.
            DateTime ngayDuocChon = new DateTime(OrderCustomerForm.static_year, OrderCustomerForm.static_month, ngay);
            return ngayDuocChon;
        }

    }
}
