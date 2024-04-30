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
    public partial class UCWorkerCancel : UserControl
    {
        private string workerID;
        private string cv;
       
        public Label LblName
        {
            get => lblName; set => lblName = value;
        }
        public Label LblPhone
        {
            get => lblPhone; set => lblPhone = value;
        }
        public Label LblHuy
        {
            get => lbl_Huy; set => lbl_Huy = value;
        }
        public string WorkerID { get => workerID; set => workerID = value; }
        public Guna2PictureBox Ptb_avt { get => ptb_avt; set => ptb_avt = value; }
        public string Cv { get => cv; set => cv = value; }
        public UCWorkerCancel()
        {
            InitializeComponent();
        }

        private void UCWorkerCancel_Load(object sender, EventArgs e)
        {
            FormCancel f = new FormCancel();
            f.WorkerID = workerID;
            f.Cv = cv;
            f.Show();
        }
    }
}
