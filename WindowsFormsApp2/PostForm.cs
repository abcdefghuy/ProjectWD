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
    public partial class PostForm : Form
    {
        public string role;
        public PostForm(string r)
        {
            role = r;
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            panelAdd.Hide();
            UCPost uc1 = new UCPost(role);
            UCPost uc2 = new UCPost(role);
            UCPost uc3 = new UCPost(role);
            UCPost uc4 = new UCPost(role);
            flContainer.Controls.Add(uc1);
            flContainer.Controls.Add(uc2);
            flContainer.Controls.Add(uc3);
            flContainer.Controls.Add(uc4);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PostForm_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
