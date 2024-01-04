using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemNodeGoc_Click(object sender, EventArgs e)
        {
            // Thêm node gốc
            TreeNode node = new TreeNode(txtNode.Text);
            treeView1.Nodes.Add(node);

            txtNode.Clear();
            txtNode.Focus();
        }

        private void btnThemNodeCon_Click(object sender, EventArgs e)
        {
            // Thêm node con tại vị trí đã chọn
            if (treeView1.SelectedNode != null)
            {
                TreeNode node = new TreeNode(txtNode.Text);
                treeView1.SelectedNode.Nodes.Add(node);
                treeView1.SelectedNode.Expand(); // Mở rộng node cha để hiển thị node con
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một node để thêm node con.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtNode.Clear();
            txtNode.Focus();
        }

        private void btnXoaTatCaNode_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            txtNode.Clear();
            txtNode.Focus();
        }

        private void btnXoaNodeDuocChon_Click(object sender, EventArgs e)
        {
            // Xóa node được chọn
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một node để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtNode.Clear();
            txtNode.Focus();
        }
    }
}
