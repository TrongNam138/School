using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = txtInput.Text;

            if (!string.IsNullOrEmpty(newItem))
            {
                lstOutPut.Items.Add(newItem);
                txtInput.Clear();
                txtInput.Focus();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (lstOutPut.SelectedIndices.Count > 0)
            {
                int selectedIndex = lstOutPut.SelectedIndices[0];
                lstOutPut.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
