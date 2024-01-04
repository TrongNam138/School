using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai_10_Load(object sender, EventArgs e)
        {

        }

        private void MoveItem(ListBox source, ListBox destination, bool all = false)
        {
            if (all)
            {
                foreach (var item in source.Items)
                {
                    destination.Items.Add(item);
                }
            }
            else
            {
                foreach (var selectedItem in source.SelectedItems)
                {
                    destination.Items.Add(selectedItem);
                }
                source.SelectedItems.Clear();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            MoveItem(listBox1, listBox2);
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            MoveItem(listBox1, listBox2, true);
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnPrintMenu_Click(object sender, EventArgs e)
        {
            string selectedItems = "";
            foreach (var item in listBox2.Items)
            {
                selectedItems += item.ToString() + "\n";
            }

            MessageBox.Show("Thực đơn ngày hôm nay:\n\n" + selectedItems, "Thực đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
