using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Thanh_toan_don_hang_Load(object sender, EventArgs e)
        {
            txtTenHang.Focus();
        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            if (!double.TryParse(txtSoLuong.Text, out double donGia) && txtSoLuong.Text != "")
                MessageBox.Show("Giá tri không hợp lệ. Vui lòng nhập một số thực.");
        }

        private void txtDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            if (!double.TryParse(txtDonGia.Text, out double donGia) && txtSoLuong.Text != "")
                MessageBox.Show("Giá trị không hợp lệ. Vui lòng nhập một số thực.");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text)).ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTenHang.Clear();
            txtTenHang.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng?", "Xác nhận đóng form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
