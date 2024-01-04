using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool isPrime(int n)
            {
                if (n < 2) return false;

                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0) return false;
                }

                return true;
            }

            txtResult.Clear();

            if (int.TryParse(txtN.Text, out int N) && N > 1)
            {
                for (int i = 2; i < N; i++)
                {
                    if (isPrime(i)) txtResult.Text += " " + i;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương lớn hơn 1.");
            }
        }
    }
}
