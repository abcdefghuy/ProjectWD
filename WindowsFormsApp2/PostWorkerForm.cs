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
    public partial class PostWorkerForm : Form
    {
        public string role;
        public static string workerID;
        public PostWorkerForm(string r)
        {
            role = r;
            InitializeComponent();
        }

        private void PostWorkerForm_Load(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            List<UCPost> ucPosts = WorkerDAO.DanhSachPost();
            foreach (UCPost uc in ucPosts)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void btn_filterDay_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            List<UCPost> ucPosts = WorkerDAO.BaiDangTheoNgay(start_day.Value, end_day.Value);
            foreach (UCPost uc in ucPosts)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void box_congviec_SelectedIndexChanged(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            List<UCPost> ucPosts = WorkerDAO.BaiDangTheoCongViec(box_congviec.Text);
            foreach (UCPost uc in ucPosts)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void cbtn_quantam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_quantam.Checked)
            {
                flContainer.Controls.Clear();
                List<UCPost> ucPosts = WorkerDAO.BaiDangQuanTam(workerID);
                foreach (UCPost uc in ucPosts)
                {
                    flContainer.Controls.Add(uc);
                }
            }
            else
            {
                PostWorkerForm_Load(sender, e);
            }
        }
    }
}
