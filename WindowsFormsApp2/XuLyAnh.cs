using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class XuLyAnh
    {
        public static void ZoomImage(object sender, EventArgs e)
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
