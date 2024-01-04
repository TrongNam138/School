using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thêm các kiểu xem vào ComboBox
            cboView.Items.Add("Details");
            cboView.Items.Add("LargeIcon");
            cboView.Items.Add("SmallIcon");
            cboView.Items.Add("List");
            cboView.SelectedIndex = 0; // Mặc định chọn kiểu xem "Details"
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ người dùng
            string hoDem = txtHoDem.Text;
            string ten = txtTen.Text;
            string dienThoai = txtDienThoai.Text;

            if (hoDem == "" || ten == "" || dienThoai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] row = { hoDem, ten, dienThoai };

            ListViewItem item = new ListViewItem(row);
            item.ImageIndex = 0;
            listView.Items.Add(item);

            // Xóa nội dung trong TextBox sau khi thêm
            txtHoDem.Focus();
            txtHoDem.Clear();
            txtTen.Clear();
            txtDienThoai.Clear();
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật kiểu xem của ListView dựa trên lựa chọn trong ComboBox
            switch (cboView.SelectedItem.ToString())
            {
                case "Details":
                    listView.View = View.Details;
                    break;
                case "LargeIcon":
                    listView.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    listView.View = View.SmallIcon;
                    break;
                case "List":
                    listView.View = View.List;
                    break;
                default:
                    break;
            }
        }
    }
}
