using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OrderForm : Form
    {   CheckCondition check=new CheckCondition();
        private string workerID;
        public string WorkerID { get => workerID; set => workerID = value; }

        private string congViec;
        public string CongViec { get => congViec; set => congViec = value; }

        public Label GiaTien
        {
            get => lbl_giatien; set => lbl_giatien = value;
        }
        public static DateTime Ngay;
        
        public OrderForm()
        {
            InitializeComponent();
            check.AttachValidatingEventToTextBoxes(this);
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
         /*  
            UCAddress uc = new UCAddress("Nguyễn Mạnh Tú", "01 Võ Văn Ngân, Phường Linh Chiểu, Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "0384983735");
            panelAddress.Controls.Add(uc);
         */
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        //dat lich
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserDAO.Order_Worker(UserForm.UserID, CongViec, ngaylamviec.Value.Date, giolamviec.Text, txb_ghichu.Text, WorkerID, txb_diachi.Text, lbl_giatien.Text);
            this.Close();
        }

        private void txb_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lich_Click(object sender, EventArgs e)
        {
                       
        }

        private void ngaylamviec_Click(object sender, EventArgs e)
        {
            OrderCustomerForm f = new OrderCustomerForm();
            f.Show();
        }
        public void CapNhatDateTimePicker(DateTime selectedDate)
        {
            // Cập nhật giá trị của DateTimePicker với ngày được chọn từ UserControl.
            ngaylamviec.Value = selectedDate;
        }

    }
}
