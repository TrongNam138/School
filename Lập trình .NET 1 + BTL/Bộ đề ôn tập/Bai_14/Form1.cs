using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateComboBoxViTri();
        }

        private void updateComboBoxViTri()
        {
            // Cập nhật ComboBox với số lượng mục tương ứng với ListBox
            cboViTri.Items.Clear();

            for (int i = 0; i <= Li_DSSanPham.Items.Count; i++)
            {
                if (i == Li_DSSanPham.Items.Count && i != 0) break;
                cboViTri.Items.Add(i + 1);
            }

            cboViTri.SelectedIndex = 0; // Mặc định chọn vị trí đầu tiên
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm sản phẩm mới vào cuối danh sách
            string sanPham = txtSanPham.Text;
            if (sanPham != "") Li_DSSanPham.Items.Add(sanPham);

            txtSanPham.Clear();
            txtSanPham.Focus();
            updateComboBoxViTri();
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            Li_DSSanPham.Items.Insert(cboViTri.SelectedIndex, txtSanPhanVT.Text);

            txtSanPhanVT.Clear();
            txtSanPhanVT.Focus();
            updateComboBoxViTri();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Li_DSSanPham.Items.Contains(txtTimKiem.Text))
            {
                MessageBox.Show("Sản phẩm bạn tìm CÓ trong trong danh sách.");
            }
            else
            {
                MessageBox.Show("Sản phẩm bạn tìm KHÔNG CÓ trong danh sách.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (Li_DSSanPham.SelectedIndices.Count > 0)
            {
                int selectedIndex = Li_DSSanPham.SelectedIndices[0];
                Li_DSSanPham.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            Li_DSSanPham.Items.Clear();
        }
    }
}
