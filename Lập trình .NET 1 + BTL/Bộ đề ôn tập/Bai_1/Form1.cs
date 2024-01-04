using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            txtInput.Text += ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text += "9";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtInput.Text += "+";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtInput.Text += "-";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtInput.Text += "*";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtInput.Text += "/";
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1);
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        double calc(string expression)
        {
            int splitIndex;

            //tách hai vế bằng dấu cộng
            splitIndex = expression.IndexOf("+");

            if (splitIndex > 0)
            {
                string partLeft = expression.Substring(0, splitIndex);
                string partRight = expression.Substring(splitIndex + 1);

                return calc(partLeft) + calc(partRight);
            }

            //tách hai vế bằng dấu trừ
            splitIndex = expression.IndexOf("-");

            if (splitIndex > 0)
            {
                string partLeft = expression.Substring(0, splitIndex);
                string partRight = expression.Substring(splitIndex + 1);

                return calc(partLeft) - calc(partRight);
            }

            //tách hai vế bằng dấu nhân
            splitIndex = expression.IndexOf("*");

            if (splitIndex > 0)
            {
                string partLeft = expression.Substring(0, splitIndex);
                string partRight = expression.Substring(splitIndex + 1);

                return calc(partLeft) * calc(partRight);
            }

            //tách hai vế bằng dấu chia
            splitIndex = expression.IndexOf("/");

            if (splitIndex > 0)
            {
                string partLeft = expression.Substring(0, splitIndex);
                string partRight = expression.Substring(splitIndex + 1);

                return calc(partLeft) / calc(partRight);
            }

            return double.Parse(expression);
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            txtOutput.Text = calc(txtInput.Text).ToString();
        }
    }
}
