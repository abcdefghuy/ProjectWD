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
        public PostDetailWorkerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Checked == true)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
