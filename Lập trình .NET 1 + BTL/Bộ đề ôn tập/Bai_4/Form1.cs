using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbBlack.Checked = true;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked) { txtIO.ForeColor = Color.Black; }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked) { txtIO.ForeColor = Color.Blue; }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked) { txtIO.ForeColor = Color.Red; }
        }

        private void UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (cbBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (cbItalic.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (cbUnderline.Checked)
            {
                style |= FontStyle.Underline;
            }

            txtIO.Font = new Font(txtIO.Font, style);
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }
    }
}
