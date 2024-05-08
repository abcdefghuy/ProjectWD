using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class NotificationForm : Form
    {
        public static string workerID;
        public static NotificationForm Instance;
        public NotificationForm()
        {
            InitializeComponent();
            Instance = this;
        }
        public void NotificationForm_Load(object sender, EventArgs e)
        {
            lblNotifica.Text = "KHÔNG CÓ THÔNG BÁO";
            List<UCNotifica> uCNotificas = WorkerDAO.Load_ThongBao(workerID);
            if (uCNotificas.Any()) lblNotifica.Text = "";

            foreach (UCNotifica uc in uCNotificas)
            {
                flContainer.Controls.Add(uc);
            }

        }
    }
}
