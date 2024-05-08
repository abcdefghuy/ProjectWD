using Guna.UI2.WinForms;
using ServiceStack.Script;
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
    public partial class PostDetailWorkerForm : Form
    {
        private string maCV;
        private string workerID;
        public PostDetailWorkerForm(string maCV)
        {
            InitializeComponent();
            this.maCV = maCV;
        }
        public Label HoTen
        {
            get => lbl_name; set => lbl_name = value;
        }
        public Guna2CirclePictureBox Avatar
        {
            get => ptb_avt; set => ptb_avt = value;
        }
        public string WorkerID { get => workerID; set => workerID = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.FillColor == Color.DodgerBlue)
            {
                btnAdd.Text = "Bỏ quan tâm";
                btnAdd.FillColor = Color.Red;
            }
            else
            {
                btnAdd.Text = "Quan Tâm";
                btnAdd.FillColor = Color.DodgerBlue;
            }
        }
        private void quanTam(object sender, EventArgs e)
        {
            WorkerDAO.QuanTamBaiDang(maCV, workerID);
        }
        private void boQuanTam(object sender, EventArgs e)
        {
            WorkerDAO.BoQuanTamBaiDang(maCV, workerID);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostDetailWorkerForm_Load(object sender, EventArgs e)
        {
            if (WorkerDAO.checkQuanTam(maCV,workerID))
            {
                btnAdd.Text = "Bỏ quan tâm";
                btnAdd.FillColor = Color.Red;
                btnAdd.Click += boQuanTam;
            }
            else
            {
                btnAdd.Text = "Quan Tâm";
                btnAdd.FillColor = Color.DodgerBlue;
                btnAdd.Click += quanTam;
            }

            CongViecUser cvUser = UserDAO.chiTietBaiDang(maCV);
            lbl_Congviec.Text = cvUser.CongViec;
            lbl_Diachi.Text = cvUser.DiaChi;
            txb_chitiet.Text = cvUser.ChiTiet;
            lbl_ngaylamviec.Text = cvUser.NgayLamViec.ToString("dd/MM/yyyy");
            foreach (Image img in cvUser.ImgList)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Click += XuLyAnh.ZoomImage;
                pictureBox.Image = img;
                panel_anh.Controls.Add(pictureBox);
            }
        }
    }
}
