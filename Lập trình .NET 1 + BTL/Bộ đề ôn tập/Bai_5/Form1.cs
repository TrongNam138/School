using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtN.Text, out int N))
            {
                float S = 0;

                if (rb1.Checked)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        S += 2 * i - 1;
                    }
                }
                else if (rb2.Checked)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        S += i * i;

                    }
                }
                else if (rb3.Checked)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        S += (float)1 / i;

                    }
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= N; i++)
                    {

                        factorial *= i;
                        S += (float)1 / factorial;
                    }
                }

                txtResult.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập N là một số nguyên.");
            }


        }
    }
}
