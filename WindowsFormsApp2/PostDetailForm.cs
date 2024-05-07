using Guna.UI2.WinForms;
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
    public partial class PostDetailForm : Form
    {
        private string maCV;
        private string Cv;
        public Label HoTen
        {
            get => lbl_name; set => lbl_name = value;
        }
        public Guna2CirclePictureBox Avatar
        {
            get => ptb_avt; set => ptb_avt = value;
        }
        public PostDetailForm(string maCV,string cv)
        {
            InitializeComponent();
            this.maCV = maCV;
            this.Cv = cv;
        }

        private void lbl_Congviec_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ngaylamviec_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostDetailForm_Load(object sender, EventArgs e)
        {
            panelPage2.Hide();
            CongViecUser cvUser = UserDAO.chiTietBaiDang(maCV);
            lbl_Congviec.Text = "Yêu cầu: "+ cvUser.CongViec;
            lbl_Diachi.Text = "Địa chỉ: "+ cvUser.DiaChi;
            txb_chitiet.Text = cvUser.ChiTiet;
            lbl_ngaylamviec.Text = "Ngày làm việc:" + cvUser.NgayLamViec.ToString("dd/MM/yyyy");
            foreach(Image img in cvUser.ImgList)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Click += ppConnection.ZoomImage;
                pictureBox.Image = img;
                panel_anh.Controls.Add(pictureBox);
            }

        }

        private void btn_viewWorker_Click(object sender, EventArgs e)
        {
            panelPage2.Show();
            flContainer.Controls.Clear();
            List<UCWorker> workerList = UserDAO.ThoQuanTam(maCV,Cv);
            foreach(UCWorker uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            panelPage2.Hide();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            UserDAO.XoaBaiDang(maCV);
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {

        }
    }
}
