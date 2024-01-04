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

namespace Bai_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        int b;

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Maximum;

            Random random = new Random();
            a = random.Next(-100, 100);
            b = random.Next(-100, 100);

            if (b >= 0) lblDeBai.Text = a + "x + " + b + " = 0";
            else lblDeBai.Text = a + "x - " + (-1 * b) + " = 0";

            timer.Start();
            btnKiemTra.Enabled = true;
            txtX.Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value -= 1;

            if (progressBar.Value <= progressBar.Minimum)
            {
                timer.Stop();
                btnKiemTra.Enabled = false;
                MessageBox.Show("Đã hết giờ làm bài.");
            }

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            double ketQua = Math.Round((double)(-1 * b) / a, 2);
            Console.WriteLine(Math.Round(ketQua, 2));

            if (double.TryParse(txtX.Text, out double txtketQua))
            {
                if (txtketQua == ketQua)
                {
                    timer.Stop();
                    MessageBox.Show($"Chính xác. Bạn đã giải trong {progressBar.Maximum - progressBar.Value} giây.");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai_17_Load(object sender, EventArgs e)
        {

        }
    }
}
