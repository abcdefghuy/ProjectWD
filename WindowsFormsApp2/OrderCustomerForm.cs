using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OrderCustomerForm : Form
    {
        
        public OrderCustomerForm()
        {
            InitializeComponent();
        }

        int month, year;
        public static int static_month, static_year;
        private string workerID;

        public string WorkerID { get => workerID; set => workerID = value; }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else month++;
            static_month = month;
            static_year = year;
            lblText.Text = "THÁNG " + month.ToString() + " NĂM " + year.ToString();
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UCDayBlank uc = new UCDayBlank();
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDayFree ucday = new UCDayFree();
                ucday.workerID = WorkerID;
                ucday.days(i);
                
                flowLayoutPanel1.Controls.Add((ucday));
            }
        }

        private void OrderCustomerForm_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else month--;
            static_month = month;
            static_year = year;
            lblText.Text = "THÁNG " + month.ToString() + " NĂM " + year.ToString();
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UCDayBlank uc = new UCDayBlank();
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDayFree ucday = new UCDayFree();
                ucday.workerID = WorkerID;
                ucday.days(i);
                flowLayoutPanel1.Controls.Add((ucday));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            static_month = month;
            static_year = year;
            lblText.Text = "THÁNG " + month.ToString() + " NĂM " + year.ToString();
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UCDayBlank uc = new UCDayBlank();
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDayFree ucday = new UCDayFree();
                ucday.workerID = WorkerID;
                ucday.days(i);
                flowLayoutPanel1.Controls.Add((ucday));
            }
        }
        public void NhanNgayDuocChon(DateTime selectedDate)
        {
            // Khi nhận được ngày được chọn từ UserControl, gọi phương thức tương ứng trong Form OrderForm để cập nhật DateTimePicker.
            if (Application.OpenForms["OrderForm"] is OrderForm orderForm)
            {
                orderForm.CapNhatDateTimePicker(selectedDate);
            }
        }
    }
}
