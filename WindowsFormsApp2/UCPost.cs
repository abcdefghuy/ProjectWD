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
    public partial class UCPost : UserControl
    {
        public Label HoTen
        {
            get => lbl_name; set => lbl_name = value;
        }
        public Label CongViec
        {
            get => lbl_Congviec; set => lbl_Congviec = value;
        }
        public Label NgayLamViec
        {
            get => lbl_ngaylamviec; set => lbl_ngaylamviec = value;
        }
        public Guna2CirclePictureBox Avatar
        {
            get => ptb_avt; set => ptb_avt = value;
        }
        public Guna2TextBox ChiTiet
        {
            get => txb_chiTiet; set => txb_chiTiet = value;

        }
        public FlowLayoutPanel PanelAnh
        {
            get => panel_anh; set => panel_anh = value;
        }

        private string maCV;
        public string MaCV { get => maCV; set => maCV = value; }
        public UCPost(string r)
        {
            role = r;
            InitializeComponent();
        }
        public string role;
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (role == "User")
            {
                PostDetailForm f = new PostDetailForm(maCV,lbl_Congviec.Text);
                f.HoTen.Text = lbl_name.Text;
                f.Avatar.Image = ptb_avt.Image;
                f.Show();
            }
            else 
            {
                PostDetailWorkerForm f = new PostDetailWorkerForm(maCV);
                f.WorkerID = PostWorkerForm.workerID;
                f.HoTen.Text = lbl_name.Text;
                f.Avatar.Image = ptb_avt.Image;
                f.Show();
            }
        }
        private void UCPost_Load(object sender, EventArgs e)
        {
            
        }
    }
}
