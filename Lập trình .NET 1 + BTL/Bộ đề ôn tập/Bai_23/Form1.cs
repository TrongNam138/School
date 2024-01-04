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

namespace Bai_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.Items.Add(new ListViewItem("google.com"));
            listView.Items.Add(new ListViewItem("24h.com.vn"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem link có giá trị không
            if (!string.IsNullOrEmpty(txtLink.Text))
            {
                // Thêm dữ liệu vào ListView
                ListViewItem newItem = new ListViewItem(txtLink.Text);
                listView.Items.Add(newItem);

                // Xóa nội dung của txtLink sau khi thêm
                txtLink.Text = "";
            }

            txtLink.Clear();
            txtLink.Focus();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                txtLink.Text = selectedItem.SubItems[0].Text;

                // Hiển thị đường dẫn trong WebBrowser
                webBrowser.Navigate(txtLink.Text);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtLink.Text;
            }

            txtLink.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                int selectedIndex = listView.SelectedIndices[0];
                listView.Items.RemoveAt(selectedIndex);
            }

            txtLink.Clear();
        }
    }
}
