using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int TimUSCLN(int numA, int numB)
            {
                while (numB != 0)
                {
                    int temp = numB;
                    numB = numA % numB;
                    numA = temp;
                }
                return numA;
            }

            int TimBSCNN(int numA, int numB)
            {
                return (numA * numB) / TimUSCLN(numA, numB);
            }

            if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                txtUSCLN.Text = TimUSCLN(a, b).ToString();
                txtBSCNN.Text = TimBSCNN(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ.");
            }
        }
    }
}
