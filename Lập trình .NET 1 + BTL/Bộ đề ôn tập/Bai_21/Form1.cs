using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyImageFromPictureBox(object sender, PictureBox destinationPictureBox)
        {
            // Kiểm tra xem sender có phải là PictureBox không
            if (sender is PictureBox clickedPictureBox)
            {
                // Sao chép hình ảnh từ PictureBox được click sang destinationPictureBox
                destinationPictureBox.Image = clickedPictureBox.Image;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CopyImageFromPictureBox(sender, pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CopyImageFromPictureBox(sender, pictureBox1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CopyImageFromPictureBox(sender, pictureBox1);
        }
    }
}
