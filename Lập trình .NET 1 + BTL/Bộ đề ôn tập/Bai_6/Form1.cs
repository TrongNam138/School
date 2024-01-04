using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstNumber.Items.Add(txtInput.Text);
            txtInput.Clear();
            txtInput.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (string item in lstNumber.Items)
            {
                if (double.TryParse(item, out double number))
                {
                    sum += number;
                }
            }

            txtOutput.Text = sum.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lstNumber.Items.Count > 0)
            {
                lstNumber.Items.RemoveAt(0);
            }

            if (lstNumber.Items.Count > 0)
            {
                lstNumber.Items.RemoveAt(lstNumber.Items.Count - 1);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            while (lstNumber.SelectedIndices.Count > 0)
            {
                int selectedIndex = lstNumber.SelectedIndices[0];
                lstNumber.Items.RemoveAt(selectedIndex);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumber.Items.Count; i++)
            {

                if (double.TryParse(lstNumber.Items[i].ToString(), out double number))
                {
                    number += 2;
                    lstNumber.Items[i] = number.ToString();
                }
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumber.Items.Count; i++)
            {

                if (double.TryParse(lstNumber.Items[i].ToString(), out double number))
                {
                    number *= number;
                    lstNumber.Items[i] = number.ToString();
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                if (double.TryParse(lstNumber.Items[i].ToString(), out double number))
                {
                    if (number % 2 != 0)
                    {
                        lstNumber.SetSelected(i, true);
                    }
                }
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                if (double.TryParse(lstNumber.Items[i].ToString(), out double number))
                {
                    if (number % 2 == 0)
                    {
                        lstNumber.SetSelected(i, true);
                    }
                }
            }
        }
    }
}
