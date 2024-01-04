using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class PhanSo
        {
            public int tuSo;
            public int mauSo;

            public PhanSo(int tu, int mau)
            {
                tuSo = tu;
                mauSo = mau;
            }

            // Nạp chồng toán tử cộng
            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tuSo * b.mauSo + b.tuSo * a.mauSo;
                int mauMoi = a.mauSo * b.mauSo;
                return RutGon(new PhanSo(tuMoi, mauMoi));
            }

            // Nạp chồng toán tử trừ
            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tuSo * b.mauSo - b.tuSo * a.mauSo;
                int mauMoi = a.mauSo * b.mauSo;
                return RutGon(new PhanSo(tuMoi, mauMoi));
            }

            // Nạp chồng toán tử nhân
            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tuSo * b.tuSo;
                int mauMoi = a.mauSo * b.mauSo;
                return RutGon(new PhanSo(tuMoi, mauMoi));
            }

            // Nạp chồng toán tử chia
            public static PhanSo operator /(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tuSo * b.mauSo;
                int mauMoi = a.mauSo * b.tuSo;
                return RutGon(new PhanSo(tuMoi, mauMoi));
            }

            // Hàm để rút gọn phân số
            private static PhanSo RutGon(PhanSo ps)
            {
                int USCLN = TimUSCLN(ps.tuSo, ps.mauSo);
                return new PhanSo(ps.tuSo / USCLN, ps.mauSo / USCLN);
            }

            // Hàm tìm ước số chung lớn nhất (USCLN)
            private static int TimUSCLN(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            public override string ToString()
            {
                return $"{tuSo}/{mauSo}";
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(txtTS1.Text), int.Parse(txtMS1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(txtTS2.Text), int.Parse(txtMS2.Text));
            PhanSo kq = ps1 + ps2;

            txtTSkq.Text = kq.tuSo.ToString();
            txtMSkq.Text = kq.mauSo.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(txtTS1.Text), int.Parse(txtMS1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(txtTS2.Text), int.Parse(txtMS2.Text));
            PhanSo kq = ps1 - ps2;

            txtTSkq.Text = kq.tuSo.ToString();
            txtMSkq.Text = kq.mauSo.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(txtTS1.Text), int.Parse(txtMS1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(txtTS2.Text), int.Parse(txtMS2.Text));
            PhanSo kq = ps1 * ps2;

            txtTSkq.Text = kq.tuSo.ToString();
            txtMSkq.Text = kq.mauSo.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(txtTS1.Text), int.Parse(txtMS1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(txtTS2.Text), int.Parse(txtMS2.Text));
            PhanSo kq = ps1 / ps2;

            txtTSkq.Text = kq.tuSo.ToString();
            txtMSkq.Text = kq.mauSo.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTS1.Clear();
            txtTS2.Clear();
            txtMS1.Clear();
            txtMS2.Clear();
            txtMSkq.Clear();
            txtMSkq.Clear();
        }
    }
}
