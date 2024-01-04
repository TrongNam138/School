using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNS_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra định dạng ngày
            if (DateTime.TryParseExact(txtNS.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime d))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtNS, "Ngày sinh dd/mm/yyyy");
            }
        }

        private void txtDTB_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem điểm trung bình được nhập có phải là số hay không
            string diemTB = txtDTB.Text;
            if (double.TryParse(diemTB, out double d))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtDTB, "Nhập số");
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo kết quả
            MessageBox.Show($"Họ tên: {txtHVT.Text}\nNgày sinh: {txtNS.Text}\nĐiểm trung bình: {txtDTB.Text}");
        }
    }
}
