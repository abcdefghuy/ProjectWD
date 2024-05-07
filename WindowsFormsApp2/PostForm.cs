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
        public string role;
        public static string userID;
        private List<Image> selectedImages = new List<Image>();
        public PostForm(string r)
        {
            role = r;
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
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
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size as needed
                    pictureBox.Cursor = Cursors.Hand; // Set cursor to indicate interaction
                    pictureBox.Click += pictureZoom_Click;

                    // Add close icon (optional) and event handler (explained later)
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
            // Create a close icon PictureBox
            PictureBox closeIcon = new PictureBox();
            closeIcon.Image = Properties.Resources.close; // Assuming your close icon image resource is named "close_icon"
            closeIcon.Size = new Size(20, 20); // Adjust size as needed
            closeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            closeIcon.Cursor = Cursors.Hand; // Set cursor to indicate interaction
            closeIcon.Click += pictureBox_Click; // Attach click event handler for deletion

            // Position the close icon on top-right corner (adjust as needed)
            closeIcon.Location = new Point(pictureBox.Width - closeIcon.Width, 0);

            // Add the close icon as the first child of the PictureBox
            pictureBox.Controls.Add(closeIcon);
        }
        private void DeletePreviewImage(PictureBox pictureBox)
        {
            // Remove image from selectedImages list
            selectedImages.Remove(pictureBox.Image);

            // Remove PictureBox from FlowLayoutPanel
            panel_image.Controls.Remove(pictureBox);

            // Dispose of the image object (optional)
            pictureBox.Image?.Dispose();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender; // Cast sender to PictureBox (the close icon)

            if (pictureBox.Parent is PictureBox imagePictureBox) // Check if parent is a PictureBox
            {
                // Remove image from selectedImages list and FlowLayoutPanel
                DeletePreviewImage(imagePictureBox);
            }
        }
        private void pictureZoom_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            // Check if close icon is clicked (optional, skip zooming if close icon)

            // Create a new Form for zooming
            Form zoomForm = new Form();
            zoomForm.Height = 400;
            zoomForm.Width = 600;
            //zoomForm.WindowState = FormWindowState.Maximized; // Maximize zoom form
            zoomForm.StartPosition = FormStartPosition.CenterScreen;
            zoomForm.Name = "Image";
            // Create a larger PictureBox for zoomed image
            PictureBox zoomedPictureBox = new PictureBox();
            zoomedPictureBox.Image = pictureBox.Image; // Assign image from clicked PictureBox
            zoomedPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust size as needed
            zoomedPictureBox.Dock = DockStyle.Fill; // Fill the entire zoom form

            // Add zoomedPictureBox to the zoomForm
            zoomForm.Controls.Add(zoomedPictureBox);

            // Show the zoom form
            zoomForm.Show();
        }

        
    }
}
