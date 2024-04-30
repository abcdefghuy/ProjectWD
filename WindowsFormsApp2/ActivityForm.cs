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
    public partial class ActivityForm : Form
    {
        public static string userID;
        public static string workerID;
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            List<UCActiviti> workerList = UserDAO.Load_Worker_Activity(userID);
            foreach (UCActiviti uc in workerList)
            {
                flContainer.Controls.Add(uc);
            }
        }
    }
}
