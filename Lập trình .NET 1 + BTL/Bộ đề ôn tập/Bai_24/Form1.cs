using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // Hiển thị ColorDialog và lấy màu được chọn
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Kiểm tra RadioButton nào được chọn và thay đổi màu cho Label tương ứng
                if (rbMauChu.Checked)
                {
                    label1.ForeColor = colorDialog.Color;
                }
                else if (rbMauNen.Checked)
                {
                    label1.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
