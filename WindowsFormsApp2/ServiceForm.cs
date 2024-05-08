using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Globalization;
using static ServiceStack.Script.Lisp;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            panelPage2.Hide();
        }
        private string tho;
        private void LoadTho(string tho)
        {
            panelPage2.Show();
            flContainer.Controls.Clear();
            
            List<UCWorker> workerList = UserDAO.Load_CongViecTho(tho);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }
        private void btnElectric_Click(object sender, EventArgs e)
        {
            tho = "Thợ Điện";
            LoadTho(tho);      
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelPage2.Hide();
        }

        private void btnRefriger_Click(object sender, EventArgs e)
        {
            tho = "Điện lạnh";
            LoadTho(tho);
        }

        private void btnPipe_Click(object sender, EventArgs e)
        {
            tho = "Ống nước";
            LoadTho(tho);
        }

        private void btnCarpen_Click(object sender, EventArgs e)
        {
            tho = "Thợ mộc";
            LoadTho(tho);
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            tho = "Xây dựng";
            LoadTho(tho);
        }

        private void btnUnclog_Click(object sender, EventArgs e)
        {
            tho = "Thông tắc";
            LoadTho(tho);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tho = "Vệ Sinh";
            LoadTho(tho);
        }

        private void btnFixing_Click(object sender, EventArgs e)
        {
            tho = "Sửa Nhà";
            LoadTho(tho);
        }

        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }
        //Tim kiem theo ten
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            
            List<UCWorker> workerList = UserDAO.tim_kiem_Tho(tho,txb_timkiem.Text);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }
      
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            
        }
        

        // search theo gia tien
        private void search_tien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select_item = search_tien.SelectedIndex;
            List < UCWorker > sortedUCs=  new List<UCWorker>    ();
            switch (select_item)
            {             
                case 0:
                     sortedUCs = flContainer.Controls.Cast<UCWorker>()
                 .OrderByDescending(uc => int.Parse(uc.LblTiencong.Text.Split(':')[1].Trim()))
                 .ToList();
                    
                    break;
                case 1:
                    sortedUCs = flContainer.Controls.Cast<UCWorker>()
                                     .OrderBy(uc => int.Parse(uc.LblTiencong.Text.Split(':')[1].Trim()))
                                     .ToList(); 
                    
                    break;
                
                    // Thêm các trường hợp sắp xếp khác nếu cần
            }
            // Xóa tất cả các UC hiện có từ Panel
           
            // Thêm các UC đã được sắp xếp vào Panel
            foreach (var uc in sortedUCs)
            {
                flContainer.Controls.Add(uc);
            }
        }
        // tim theo so sao
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            int star = 5;
            List<UCWorker> workerList = UserDAO.TimKiem_Star(tho, star);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            int star = 4;
            List<UCWorker> workerList = UserDAO.TimKiem_Star(tho, star);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            int star = 3;
            List<UCWorker> workerList = UserDAO.TimKiem_Star(tho, star);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            int star = 2;
            List<UCWorker> workerList = UserDAO.TimKiem_Star(tho, star);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            int star = 1;
            List<UCWorker> workerList = UserDAO.TimKiem_Star(tho, star);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btn_toptho_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            List<UCWorker> workerList = UserDAO.TimKiem_TopYeuThich(tho, 10);
            foreach (UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void cbtn_doanhthu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_doanhthu.Checked)
            {
                flContainer.Controls.Clear();
                List<UCWorker> uc = UserDAO.TopDoanhThu_Worker(tho);
                foreach(UCWorker x in uc)
                    flContainer.Controls.Add(x);
            }
            else
            {
                flContainer.Controls.Clear();
                LoadTho(tho);
            }
        }

        private void cbtn_congviecBook_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_congviecBook.Checked)
            {
                flContainer.Controls.Clear();
                List<UCWorker> uc = UserDAO.TopBooking(tho);
                foreach (UCWorker x in uc)
                    flContainer.Controls.Add(x);
            }
            else
            {
                flContainer.Controls.Clear();
                LoadTho(tho);
            }
        }

        private void btn_xemdshuy_Click(object sender, EventArgs e)
        {
            if (btn_xemdshuy.Checked == true)
            {
                flContainer.Controls.Clear();
                List<UCWorkerCancel> uc = UserDAO.XemThoBiHuy(tho);
                foreach (UCWorkerCancel x in uc)
                    flContainer.Controls.Add(x);
            }
            else
            {
                LoadTho(tho);
            }
        }

        private void search_kinhnghiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
