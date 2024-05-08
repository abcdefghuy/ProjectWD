using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class PostForm : Form
    {
        public static PostForm instance;
        public string role;
        public static string userID;
        private List<Image> selectedImages = new List<Image>();
        public PostForm(string r)
        {
            role = r;
            instance = this;
            InitializeComponent();
        }

        public void PostForm_Load(object sender, EventArgs e)
        {
            panelAdd.Hide();
            flContainer.Controls.Clear();
            List<UCPost> posts = UserDAO.DanhSachPost(userID);
            foreach (UCPost uc in posts)
            {
                flContainer.Controls.Add(uc);
            }
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CongViecUser cv = new CongViecUser(DateTime.Now.ToString(), userID, CongViecBox.Text, diaChiBox.Text, chitiet_txb.Text, date_lamviec.Value, selectedImages);
            UserDAO.ThemBaiDang(cv.MaCV, cv.UserID, cv.CongViec, cv.DiaChi, cv.ChiTiet, cv.NgayLamViec, cv.ImgList);
            PostForm_Load(sender, e);
        }
        private void btn_filterDay_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            List<UCPost> posts = UserDAO.BaiDangTheoNgay(userID, start_day.Value, end_day.Value);
            foreach (UCPost uc in posts)
            {
                flContainer.Controls.Add(uc);
            }
        }
        private void box_congViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            List<UCPost> posts = UserDAO.BaiDangTheoCongViec(userID, box_congViec.Text);
            foreach (UCPost uc in posts)
            {
                flContainer.Controls.Add(uc);
            }
        }
        // ------------------------------------------------------------
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Các tệp ảnh (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    Image image = Image.FromFile(filePath);
                    selectedImages.Add(image);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
                    pictureBox.Cursor = Cursors.Hand; 
                    pictureBox.Click += pictureZoom_Click;

                    
                    AddCloseIcon(pictureBox);
                    panel_image.Controls.Add(pictureBox);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void AddCloseIcon(PictureBox pictureBox)
        {
            
            PictureBox closeIcon = new PictureBox();
            closeIcon.Image = Properties.Resources.close; 
            closeIcon.Size = new Size(20, 20); 
            closeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            closeIcon.Cursor = Cursors.Hand; 
            closeIcon.Click += pictureBox_Click; 

            closeIcon.Location = new Point(pictureBox.Width - closeIcon.Width, 0);

            
            pictureBox.Controls.Add(closeIcon);
        }
        private void DeletePreviewImage(PictureBox pictureBox)
        {
           
            selectedImages.Remove(pictureBox.Image);

            
            panel_image.Controls.Remove(pictureBox);

            
            pictureBox.Image?.Dispose();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender; 

            if (pictureBox.Parent is PictureBox imagePictureBox) 
            {
                
                DeletePreviewImage(imagePictureBox);
            }
        }
        private void pictureZoom_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            

           
            Form zoomForm = new Form();
            zoomForm.Height = 400;
            zoomForm.Width = 600;
            
            zoomForm.StartPosition = FormStartPosition.CenterScreen;
            zoomForm.Name = "Image";
            
            PictureBox zoomedPictureBox = new PictureBox();
            zoomedPictureBox.Image = pictureBox.Image; 
            zoomedPictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
            zoomedPictureBox.Dock = DockStyle.Fill; 

            
            zoomForm.Controls.Add(zoomedPictureBox);

            
            zoomForm.Show();
        }

        
    }
}
