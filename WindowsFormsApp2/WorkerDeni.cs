using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class WorkerDeni : Form
    {
        private string workerID;
        private string userID;
        private string cv;
        private string madattho;
        private string role;
        public string WorkerID { get => workerID; set => workerID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Cv { get => cv; set => cv = value; }
        public string MaDatTho { get => madattho; set => madattho = value; }
        public string Role { get => role; set => role = value; }

        public WorkerDeni()
        {
            InitializeComponent();
        }
        public WorkerDeni(string userID, string workerID, string congviec, string ma)
        {
            UserID = userID;
            WorkerID = workerID;
            Cv = congviec;
            MaDatTho = ma;
            
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerDeni_Load(object sender, EventArgs e)
        {
            if (Role == "User")
            {
                Worker worker = UserDAO.Deni_Worker(MaDatTho);
                lbl_name.Text = "Họ tên: " + worker.Hoten;
                lbl_date.Text = "Ngày làm việc: " + (worker.Cv.NgayLamViec.ToString("dd/MM/yyyy"));
                txb_danhgia.Text = worker.Cv.DanhGia;
                lbl_congviec.Text = "Công việc: " + cv;
            }
            else
            {
                User u =WorkerDAO.Deni_user(MaDatTho);
                lbl_name.Text = "Họ tên: " + u.Hoten;
                lbl_date.Text = "Ngày làm việc: " + (u.Congviec.NgayLamViec.ToString("dd/MM/yyyy"));
                txb_danhgia.Text = u.Congviec.DanhGia;
                lbl_congviec.Text = "Công việc: " + cv;
            }
                       
        }
    }
}
