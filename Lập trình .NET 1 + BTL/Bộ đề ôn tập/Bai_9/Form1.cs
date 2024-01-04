using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dx = 8;
        int dy = 8;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (ball.Left <= 0 || ball.Right >= ClientRectangle.Width) dx = -dx;
            if (ball.Top <= 0 || ball.Bottom >= ClientRectangle.Height) dy = -dy;

            ball.Left += dx;
            ball.Top += dy;

        }
    }
}
