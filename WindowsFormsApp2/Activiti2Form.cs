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
    public partial class Activiti2Form : Form
    {
        private string workerID;
        private string userID;
        private string cv;
        private string ma;
        public string WorkerID { get => workerID; set => workerID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Cv { get => cv; set => cv = value; }
        public string Ma { get => ma; set => ma = value; }

        public Activiti2Form()
        {
            InitializeComponent();
        }
        public Activiti2Form(string userID, string workerID, string congviec,string ma)
        {
            InitializeComponent();
            UserID = userID;
            WorkerID = workerID;
            Cv = congviec;
            Ma = ma;
            panelPage2.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string lydo = cbSelect.Text + txbKhac.Text;           
            UserDAO.Huy_Worker(userID,workerID,Cv,ma,lydo);
            ActivityForm.userID= UserID;
            UserForm.instance.OpenForm(new ActivityForm());
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelPage2.Hide();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Activiti2Form_Load(object sender, EventArgs e)
        {
            Worker worker = UserDAO.History_Worker(Ma);
            lbl_name.Text = "Họ tên: " + worker.Hoten;
            lbl_thanhtoan.Text = "Đã thanh toán: " + worker.Cv.Thanhtoan;
            lbl_date.Text = "Ngày làm việc: " + (worker.Cv.NgayLamViec.ToString("dd/MM/yyyy"));
            rating.Value = worker.Cv.Rate;
            lbl_congviec.Text = "Công việc: " + cv;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panelPage2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
