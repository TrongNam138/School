using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtR.Text = tbR.Value.ToString();
            txtG.Text = tbG.Value.ToString();
            txtB.Text = tbB.Value.ToString();
            updateColor();
        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            txtR.Text = tbR.Value.ToString();
            updateColor();

        }

        private void tbG_Scroll(object sender, EventArgs e)
        {
            txtG.Text = tbG.Value.ToString();
            updateColor();
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            txtB.Text = tbB.Value.ToString();
            updateColor();
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(txtR.Text);
            if (value >= 0 && value <= 255)
            {
                tbR.Value = value;
                updateColor();
            }
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(txtG.Text);
            if (value >= 0 && value <= 255)
            {
                tbG.Value = value;
                updateColor();
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(txtB.Text);
            if (value >= 0 && value <= 255)
            {
                tbB.Value = value;
                updateColor();
            }
        }

        private void updateColor()
        {
            int red = tbR.Value;
            int green = tbG.Value;
            int blue = tbB.Value;

            panel1.BackColor = Color.FromArgb(red, green, blue); ;
        }
    }
}
