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
        public PostWorkerForm(string r)
        {
            role = r;
            InitializeComponent();
        }

        private void PostWorkerForm_Load(object sender, EventArgs e)
        {
            UCPost uc1 = new UCPost(role);
            UCPost uc2 = new UCPost(role);
            UCPost uc3 = new UCPost(role);
            UCPost uc4 = new UCPost(role);
            flContainer.Controls.Add(uc1);
            flContainer.Controls.Add(uc2);
            flContainer.Controls.Add(uc3);
            flContainer.Controls.Add(uc4);
        }
    }
}
