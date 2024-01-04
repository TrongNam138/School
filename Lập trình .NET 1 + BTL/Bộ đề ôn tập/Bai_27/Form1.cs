using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbMale.Checked = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            DateTime birthday = DateTime.Parse(txtBirthday.Text, culture);
            DateTime dateTime = DateTime.Now;

            int age = dateTime.Year - birthday.Year;
            string birthdayDayName = culture.DateTimeFormat.GetDayName(birthday.DayOfWeek);
            string title = "";
            string fullName = txtFullName.Text;

            if (rbMale.Checked)
            {
                if (age > 70) title = "Cụ";

                else if (age > 34) title = "Ông";

                else if (age > 17) title = "Anh";

                else if (age > 10) title = "Em";

                else if (age > 0) title = "Cháu";
            }

            else
            {
                if (age > 65) title = "Cụ";

                else if (age > 30) title = "Ông";

                else if (age > 23) title = "Anh";

                else if (age > 10) title = "Em";

                else if (age > 0) title = "Cháu";
            }

            lblInfo.Text = title + " " + fullName + ", " + age + " tuổi, sinh vào " + birthdayDayName;
        }
    }
}
