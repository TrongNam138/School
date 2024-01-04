using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai_28
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string GetEnteredInformation()
        {
            // Build a string with all the entered information
            StringBuilder information = new StringBuilder();

            information.AppendLine($"Họ đệm: {txtHoDem.Text}");
            information.AppendLine($"Tên: {txtTen.Text}");

            if (rbNam.IsChecked == true)
                information.AppendLine("Giới tính: Nam");
            else if (rbNu.IsChecked == true)
                information.AppendLine("Giới tính: Nữ");

            information.Append("Ngoại ngữ: ");
            if (cbTiengAnh.IsChecked == true)
                information.Append("Tiếng Anh ");
            if (cbTiengTrung.IsChecked == true)
                information.Append("Tiếng Trung");

            information.AppendLine(); 

            information.AppendLine($"Quê quán: {cboQueQuan.Text}");

            return information.ToString();
        }

        private void ClearInputFields()
        {
            txtHoDem.Text = "";
            txtTen.Text = "";
            rbNam.IsChecked = false;
            rbNu.IsChecked = false;
            cbTiengAnh.IsChecked = false;
            cbTiengTrung.IsChecked = false;
            cboQueQuan.SelectedIndex = 0; 
        }

        private void ViewInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thông tin đã nhập:\n" + GetEnteredInformation());
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ClearInputFields();
            txtHoDem.Focus();
        }
    }
}
