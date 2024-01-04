using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLuuTapTin.Enabled = false;
        }

        string filePath = "";

        private void btnMoTapTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn của tập tin vào biến filePath
                filePath = openFileDialog.FileName;

                try
                {
                    // Đọc nội dung từ tập tin và hiển thị trên TextBox
                    string content = File.ReadAllText(filePath);
                    textBox.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi mở tập tin: " + ex.Message, "Lỗi");
                }
            }

            btnLuuTapTin.Enabled = true;
        }

        private void btnLuuTapTin_Click(object sender, EventArgs e)
        {
            try
            {
                // Lưu nội dung từ TextBox vào tập tin
                File.WriteAllText(filePath, textBox.Text);
                MessageBox.Show("Đã lưu tập tin thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu tập tin: " + ex.Message, "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
