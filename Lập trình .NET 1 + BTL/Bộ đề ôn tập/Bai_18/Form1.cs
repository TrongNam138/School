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

namespace Bai_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ người dùng
            string _class = txtClass.Text;
            string _sum = txtSum.Text;

            if (_class == "" || _sum == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSum.Text, out int x))
            {
                MessageBox.Show("Vui lòng nhập số lượng sinh viên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm thông tin vào ListView
            string[] row = { _class, _sum.ToString() };

            listView.Items.Add(new ListViewItem(row));

            // Xóa nội dung trong TextBox sau khi thêm
            txtClass.Focus();
            txtClass.Clear();
            txtSum.Clear();
        }
    }
}
