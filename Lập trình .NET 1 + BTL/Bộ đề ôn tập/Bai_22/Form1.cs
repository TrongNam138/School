using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddItemToListView(ListView listView, string[] row)
        {
            // Tạo ListViewItem
            ListViewItem item = new ListViewItem(row);

            // Thêm ListViewItem vào ListView
            listView.Items.Add(item);
        }

        private void EditItemInListView(ListView listView, string[] row)
        {
            if (listView.SelectedItems.Count <= 0) return;
            // Lấy index của ListViewItem được chọn
            int selectedIndex = listView.SelectedIndices[0];

            // Gán giá trị mới cho các SubItems của ListViewItem đang được chọn
            for (int i = 0; i < listView.Items[selectedIndex].SubItems.Count; i++)
            {
                listView.Items[selectedIndex].SubItems[i].Text = row[i];
            }
        }

        private void DeleteItemInListView(ListView listView)
        {

            if (listView.SelectedItems.Count <= 0) return;
            // Lấy index của ListViewItem được chọn
            int selectedIndex = listView.SelectedIndices[0];

            // Xóa dòng được chọn khỏi ListView
            listView.Items.RemoveAt(selectedIndex);
        }

        private void DisplaySelectedItemInfo(ListView listView, params TextBox[] textBoxes)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    textBoxes[i].Text = selectedItem.SubItems[i].Text;
                }
            }
            else
            {
                // Nếu không có ListViewItem được chọn, xóa nội dung của TextBox
                foreach (var textBox in textBoxes)
                {
                    textBox.Text = "";
                }
            }
        }

        private void btnTab1Add_Click(object sender, EventArgs e)
        {
            // Tạo mảng giá trị từ các TextBox trên giao diện
            string[] row = { txtTab1HoVaTen.Text, txtTab1ChucVu.Text, txtTab1LuongCoBan.Text, txtTab1HeSoLuong.Text };

            // Gọi hàm AddItemToListView và truyền mảng giá trị vào
            AddItemToListView(listViewTab1, row);
        }

        private void listViewTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedItemInfo(listViewTab1, txtTab1HoVaTen, txtTab1ChucVu, txtTab1LuongCoBan, txtTab1HeSoLuong);
        }

        private void btnTab1Ẹdit_Click(object sender, EventArgs e)
        {
            string[] row = { txtTab1HoVaTen.Text, txtTab1ChucVu.Text, txtTab1LuongCoBan.Text, txtTab1HeSoLuong.Text };
            EditItemInListView(listViewTab1, row);
        }

        private void btnTab1Delete_Click(object sender, EventArgs e)
        {
            DeleteItemInListView(listViewTab1);
        }

        private void btnTab2Add_Click(object sender, EventArgs e)
        {
            // Tạo mảng giá trị từ các TextBox trên giao diện
            string[] row = { txtTab2HoVaTen.Text, txtTab2HocVi.Text, txtTab2SoTietDay.Text, txtTab2TienMotTiet.Text };

            // Gọi hàm AddItemToListView và truyền mảng giá trị vào
            AddItemToListView(listViewTab2, row);
        }

        private void btnTab2Edit_Click(object sender, EventArgs e)
        {
            // Tạo mảng giá trị từ các TextBox trên giao diện
            string[] row = { txtTab2HoVaTen.Text, txtTab2HocVi.Text, txtTab2SoTietDay.Text, txtTab2TienMotTiet.Text };

            // Gọi hàm EditItemInListView và truyền mảng giá trị vào
            EditItemInListView(listViewTab2, row);
        }

        private void btnTab2Delete_Click(object sender, EventArgs e)
        {
            DeleteItemInListView(listViewTab2);
        }

        private void listViewTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedItemInfo(listViewTab2, txtTab2HoVaTen, txtTab2HocVi, txtTab2SoTietDay, txtTab2TienMotTiet);
        }
    }
}
