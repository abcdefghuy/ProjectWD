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
                PostDetailForm f = new PostDetailForm();
                f.Show();
            }
            else 
            {
                PostDetailWorkerForm f = new PostDetailWorkerForm();
                f.Show();
            }
        }

        private void UCPost_Load(object sender, EventArgs e)
        {

        }
    }
}
