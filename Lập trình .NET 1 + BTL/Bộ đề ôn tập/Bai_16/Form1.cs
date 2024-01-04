using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getSubjectSelected()
        {
            // Lấy danh sách môn học được chọn
            string subject = "";

            if (cbSubject1.Checked)
                subject += "Lập trình C#\n";

            if (cbSubject2.Checked)
                subject += "Mạng máy tính\n";

            if (cbSubject3.Checked)
                subject += "Xử lý ảnh\n";

            if (cbSubject4.Checked)
                subject += "Lập trình web\n";

            return subject;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển
            string _name = txtName.Text;
            string _class = txtClass.Text;
            string subjects = getSubjectSelected(); // Lấy môn học được chọn

            // Kiểm tra xem các thông tin có được nhập đầy đủ không
            if (string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_class) || string.IsNullOrEmpty(subjects))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                // Hiển thị thông tin trong MessageBox
                string thongTin = $"Họ tên: {_name}\nLớp: {_class}\nMôn học tự chọn: \n{subjects}";
                MessageBox.Show(thongTin, "Thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
