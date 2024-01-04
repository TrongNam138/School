using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Khai báo biến
            double a, b;
            string phepTinh;

            // Kiểm tra nhập liệu
            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho A.");
                return;
            }

            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho B.");
                return;
            }

            // Kiểm tra phép tính
            if (cboCalc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phép tính.");
                return;
            }


            // Thực hiện phép tính
            switch (cboCalc.SelectedItem.ToString())
            {
                case "Cộng":
                    txtResult.Text = (a + b).ToString();
                    break;
                case "Trừ":
                    txtResult.Text = (a - b).ToString();
                    break;
                case "Nhân":
                    txtResult.Text = (a * b).ToString();
                    break;
                case "Chia":
                    if (b != 0)
                        txtResult.Text = (a / b).ToString();
                    else
                        MessageBox.Show("Không thể chia cho 0.");
                    break;
                default:
                    MessageBox.Show("Phép tính không hợp lệ.");
                    break;
            }
        }
    }
}
