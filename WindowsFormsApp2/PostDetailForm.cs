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
        public PostDetailForm()
        {
            InitializeComponent();
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
            UCWorker uc1 = new UCWorker();
            UCWorker uc2 = new UCWorker();
            UCWorker uc3 = new UCWorker();

            flContainer.Controls.Add(uc1);
            flContainer.Controls.Add(uc2);
            flContainer.Controls.Add(uc3);
        }

        private void btn_viewWorker_Click(object sender, EventArgs e)
        {
            panelPage2.Show();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            panelPage2.Hide();
        }
    }
}
