using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserForm : Form
    {
        public static string UserID ;
        public static UserForm instance;
        public UserForm()
        {
            InitializeComponent();
            instance = this;
        }

        private Form currentFormChild;
        public void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelContain.Controls.Add(form);
            PanelContain.Tag = form;
            form.BringToFront();
            form.Show();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfomationCusForm.role = "User";
            InfomationCusForm.ID = userID_lbl.Text;
            OpenForm(new InfomationCusForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryWorkerForm.userID = userID_lbl.Text;
            OpenForm(new HistoryWorkerForm("Customer"));
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            ServiceForm.UserID=userID_lbl.Text;
            OpenForm(new ServiceForm());
        }

        private void btnSinUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ActivityForm.userID = userID_lbl.Text;
            OpenForm(new ActivityForm());
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserID = userID_lbl.Text;
            User u = UserDAO.Load_info_User(UserID);
            lbl_Ten.Text = u.Hoten;
            if (u.Avatar != null && u.Avatar.Length > 0)
            {
                MemoryStream ms = new MemoryStream(u.Avatar, 0, u.Avatar.Length);
                ptb_avatar.Image = Image.FromStream(ms);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            PostForm.userID = userID_lbl.Text;
            OpenForm(new PostForm("User"));
        }
    }
}
