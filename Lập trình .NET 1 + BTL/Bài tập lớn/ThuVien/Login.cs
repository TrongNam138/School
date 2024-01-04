using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class Login : Form
    {

        string strConn = @"Data Source=DESKTOP-0U2JOLM;Initial Catalog=library;Integrated Security=True";
        string query;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;

        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = $"SELECT COUNT(*) FROM admins WHERE name = '{txtUsername.Text}' AND password = '{txtPassword.Text}'";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                Manage manageForm = new Manage();
                manageForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length >= 3) eprUsername.Clear();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 3)
                eprUsername.SetError(txtUsername, "Tên đăng nhập phải có ít nhất 3 kí tự");
            else
                eprUsername.Clear();
        }

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            ttpPassword.SetToolTip(txtPassword, "Mật khẩu phải có ít nhất 8 kí tự");
        }
    }
}
