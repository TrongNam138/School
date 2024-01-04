using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ThuVien
{
    public partial class Manage : Form
    {
        string strConn = @"Data Source=DESKTOP-0U2JOLM;Initial Catalog=library;Integrated Security=True";
        string query;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;

        int borrowBookPrice = 0;

        public Manage()
        {
            InitializeComponent();
        }

        private bool IsInt(string value)
        {
            return int.TryParse(value, out _);
        }

        private void txtOnlyNumber(TextBox textBox)
        {
            string text = textBox.Text.Trim();
            textBox.SelectionStart = textBox.Text.Length;

            if (text.Length == 0) return;

            string lastChar = text.Substring(textBox.Text.Length - 1);
            if (!IsInt(lastChar))
            {
                textBox.Text = text.Substring(0, text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
                return;
            }
            
        }

        private void loadListView(ListView lv, string query)
        {
            lv.Items.Clear();

            conn.Open();

            cmd = new SqlCommand(query, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int i = 0;
                ListViewItem lvi = new ListViewItem(rdr[i++].ToString());
                while (i < lv.Columns.Count)
                {
                    if (rdr[i] is DBNull)
                    {
                        lvi.SubItems.Add("");
                        i++;
                    }
                    else if (rdr[i] is DateTime)
                    {
                        DateTime date = rdr.GetDateTime(i++);
                        lvi.SubItems.Add(date.ToString("dd-MM-yyyy"));
                    }
                    else
                    {
                        lvi.SubItems.Add( rdr[i++].ToString() );
                    }

                }
                lv.Items.Add(lvi);
            }

            conn.Close();
        }

        private void manage_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);

            tabManage.SelectedIndex = 0;
            loadListView(lvReader, "SELECT id, name, cccd, phone, address FROM readers ORDER BY id DESC");

            cbReaderSearch.SelectedIndex = 0; 
            cbBookSearch.SelectedIndex = 0;
            cbBorrowFilter.SelectedIndex = 0;
            cbBorrowSearch.SelectedIndex = 0;

            dtpBorrowDeadline.Format = DateTimePickerFormat.Custom;
            dtpBorrowDeadline.CustomFormat = "dd-MM-yyyy";
        }

        private void clearTxtReader()
        {
            txtReaderId.Clear();  
            
            txtReaderName.Clear();
            txtReaderCCCD.Clear();
            txtReaderPhone.Clear();
            txtReaderAddress.Clear();

            txtReaderSearch.Clear();

            cbReaderSearch.SelectedIndex = 0;
        }

        private void lvReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvReader.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvReader.SelectedItems[0];
                txtReaderId.Text = lvi.SubItems[0].Text;
                txtReaderName.Text = lvi.SubItems[1].Text;
                txtReaderCCCD.Text = lvi.SubItems[2].Text;
                txtReaderPhone.Text = lvi.SubItems[3].Text;
                txtReaderAddress.Text = lvi.SubItems[4].Text;
            }
        }

        private void btnReaderAdd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO readers (name, cccd, phone, address) VALUES ('{txtReaderName.Text}', '{txtReaderCCCD.Text}', '{txtReaderPhone.Text}', '{txtReaderAddress.Text}')";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadListView(lvReader, "SELECT id, name, cccd, phone, address FROM readers ORDER BY id DESC");
            clearTxtReader();
        }

        private void btnReaderEdit_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE readers SET name = '{txtReaderName.Text}', cccd = '{txtReaderCCCD.Text}', phone = '{txtReaderPhone.Text}', address = '{txtReaderAddress.Text}'  WHERE id = {txtReaderId.Text}";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadListView(lvReader, "SELECT id, name, cccd, phone, address FROM readers ORDER BY id DESC");
            clearTxtReader();
        }

        private void btnReaderDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM readers WHERE id = {txtReaderId.Text}";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadListView(lvReader, "SELECT id, name, cccd, phone, address FROM readers ORDER BY id DESC");
            clearTxtReader();
        }

        private void btnReaderClear_Click(object sender, EventArgs e)
        {
            clearTxtReader();
        }

        private void txtReaderSearch_TextChanged(object sender, EventArgs e)
        {
            string option = "id";
            switch (cbReaderSearch.SelectedIndex)
            {
                case 0:
                    option = "id";
                    break;
                case 1:
                    option = "name";
                    break;
                case 2:
                    option = "cccd";
                    break;
                case 3:
                    option = "phone";
                    break;
                case 4:
                    option = "address";
                    break;
            }

            string query = $"SELECT id, name, cccd, phone, address FROM readers WHERE {option} LIKE '%{txtReaderSearch.Text}%' ORDER BY id DESC";
            loadListView(lvReader, query);
        }

        private void clearTxtBook()
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtBookAuthor.Clear();
            txtBookGenre.Clear();

            txtBookLanguage.Clear();
            txtBookPublisher.Clear();
            txtBookPrice.Clear();
            txtBookQuantily.Clear();

            txtBookSearch.Clear();

            cbBookSearch.SelectedIndex = 0;
        }

        private void lvBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBook.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvBook.SelectedItems[0];

                txtBookId.Text = lvi.SubItems[0].Text;
                txtBookName.Text = lvi.SubItems[1].Text;
                txtBookAuthor.Text = lvi.SubItems[2].Text;
                txtBookGenre.Text = lvi.SubItems[3].Text;

                txtBookLanguage.Text = lvi.SubItems[4].Text;
                txtBookPublisher.Text = lvi.SubItems[5].Text;
                txtBookPrice.Text = lvi.SubItems[6].Text;
                txtBookQuantily.Text = lvi.SubItems[7].Text;
            }
        }

        private void txtBookAdd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO books (name, author, genre, language, publisher, price, quantity) " +
                $"VALUES ('{txtBookName.Text}', '{txtBookAuthor.Text}', '{txtBookGenre.Text}', '{txtBookLanguage.Text}', " +
                $"'{txtBookPublisher.Text}', '{txtBookPrice.Text}', '{txtBookQuantily.Text}')";

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadListView(lvBook, "SELECT id, name, author, genre, language, publisher, price, quantity FROM books ORDER BY id DESC");
            clearTxtBook();
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE books SET name = '{txtBookName.Text}', author = '{txtBookAuthor.Text}', genre = '{txtBookGenre.Text}', " +
                $"language = '{txtBookLanguage.Text}', publisher = '{txtBookPublisher.Text}', price = '{txtBookPrice.Text}', quantity = '{txtBookQuantily.Text}' " +
                $"WHERE id = '{txtBookId.Text}'";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadListView(lvBook, "SELECT id, name, author, genre, language, publisher, price, quantity FROM books ORDER BY id DESC");
            clearTxtBook();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            query = $"DELETE FROM books WHERE id = {txtBookId.Text}";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadListView(lvBook, "SELECT id, name, author, genre, language, publisher, price, quantity FROM books ORDER BY id DESC");
            clearTxtBook();
        }

        private void btnBookClear_Click(object sender, EventArgs e)
        {
            clearTxtBook();
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            string option = "id";

            switch (cbBookSearch.SelectedIndex)
            {
                case 0:
                    option = "id";
                    break;
                case 1:
                    option = "name";
                    break;
                case 2:
                    option = "author";
                    break;
                case 3:
                    option = "genre";
                    break;
                case 4:
                    option = "language";
                    break;
                case 5:
                    option = "publisher";
                    break;
                case 6:
                    option = "price";
                    break;
                case 7:
                    option = "quantity";
                    break;
            }

            string query = $"SELECT id, name, author, genre, language, publisher, price, quantity FROM books WHERE {option} LIKE '%{txtBookSearch.Text}%' ORDER BY id DESC";
            loadListView(lvBook, query);
        }

        private void clearTxtBorrow()
        {
            txtBorrowId.Clear();
            txtBorrowReaderId.Clear();
            txtBorrowBookId.Clear();
            txtBorrowQuantity.Clear();

            txtBorrowReaderName.Clear();
            txtBorrowReaderCCCD.Clear();
            txtBorrowReaderPhone.Clear();

            txtBorrowBookName.Clear();
            txtBorrowBookAuthor.Clear();
            txtBorrowBookQuantity.Clear();

            lblBorrowDeposit.Text = "0";
            lblBorrowFines.Text = "0";

            txtBorrowSearch.Clear();
            cbBorrowFilter.SelectedIndex = 0;
            cbBorrowSearch.SelectedIndex = 0;
        }

        private void btnEnabledBorrow()
        {
            bool flag = txtBorrowReaderName.Text != ""
                && txtBorrowBookName.Text != ""
                && txtBorrowQuantity.Text != ""
                && int.Parse(txtBorrowQuantity.Text) > 0;

            if (flag)
            {
                btnBorrowAdd.Enabled = true;
            }
            else
            {
                btnBorrowAdd.Enabled = false;
            }
        }

        private void txtBorrowReaderId_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            conn.Open();
            query = $"SELECT name, cccd, phone FROM readers WHERE id = '{txtBorrowReaderId.Text}'";
            cmd = new SqlCommand(query, conn);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                txtBorrowReaderName.Text = rdr[0].ToString();
                txtBorrowReaderCCCD.Text = rdr[1].ToString();
                txtBorrowReaderPhone.Text = rdr[2].ToString();
            }
            else
            {
                txtBorrowReaderName.Clear();
                txtBorrowReaderCCCD.Clear();
                txtBorrowReaderPhone.Clear();
            }

            conn.Close();
            btnEnabledBorrow();

        }

        private void txtBorrowBookId_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            conn.Open();
            query = $"SELECT name, author, quantity, price FROM books WHERE id = '{txtBorrowBookId.Text}'";
            cmd = new SqlCommand(query, conn);
            rdr = cmd.ExecuteReader();


            if (rdr.Read())
            {
                txtBorrowBookName.Text = rdr[0].ToString();
                txtBorrowBookAuthor.Text = rdr[1].ToString();
                txtBorrowBookQuantity.Text = rdr[2].ToString();

                borrowBookPrice = int.Parse(rdr[3].ToString());

                if(int.Parse(txtBorrowBookQuantity.Text) > 0)
                {
                    btnBorrowAdd.Enabled = true;
                    txtBorrowQuantity.Enabled = true;
                }
                else
                {
                    btnBorrowAdd.Enabled = false;
                    txtBorrowQuantity.Enabled = false;
                }
            }
            else
            {
                txtBorrowBookName.Clear();
                txtBorrowBookAuthor.Clear();
                txtBorrowBookQuantity.Clear();
                lblBorrowDeposit.Text = "0";
                borrowBookPrice = 0;
            }

            conn.Close();
            btnEnabledBorrow();
        }

        private void txtBorrowQuantity_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            btnEnabledBorrow();
            if (txtBorrowQuantity.Text != "")
            {
                lblBorrowDeposit.Text = (borrowBookPrice * int.Parse(txtBorrowQuantity.Text) * 0.8).ToString();
            }
            else
            {
                lblBorrowDeposit.Text = "0";
            }
            
        }

        private void btnBorrowAdd_Click(object sender, EventArgs e)
        {

            conn.Open();

            query = $"INSERT INTO borrows (reader_id, book_id, borrow_date, deadline, quantity, deposit) " +
                $"VALUES ('{txtBorrowReaderId.Text}', '{txtBorrowBookId.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{dtpBorrowDeadline.Value}', " +
                $"'{txtBorrowQuantity.Text}', '{lblBorrowDeposit.Text}')";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            query = $"UPDATE books SET quantity = '{int.Parse(txtBorrowBookQuantity.Text) - int.Parse(txtBorrowQuantity.Text)}' WHERE id = '{txtBorrowBookId.Text}'";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            loadListView(lvBorrow, "SELECT id, reader_id, book_id, quantity, borrow_date, deadline, return_date, deposit, fines FROM borrows ORDER BY id DESC");
            clearTxtBorrow();
        }

        private void lvBorrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBorrow.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvBorrow.SelectedItems[0];

                txtBorrowId.Text = lvi.SubItems[0].Text;
                txtBorrowReaderId.Text = lvi.SubItems[1].Text;
                txtBorrowBookId.Text = lvi.SubItems[2].Text;

                txtBorrowQuantity.Text = lvi.SubItems[3].Text;

                dtpBorrowDeadline.Value = DateTime.ParseExact(lvi.SubItems[5].Text, "dd-MM-yyyy", null);

                lblBorrowDeposit.Text = lvi.SubItems[7].Text;

                int overdue = (DateTime.Now - dtpBorrowDeadline.Value).Days;

                if (overdue > 0)
                {
                    lblBorrowFines.Text = (overdue * 1000).ToString();
                }
                else
                {
                    lblBorrowFines.Text = lvi.SubItems[8].Text;
                }

                if(lvi.SubItems[6].Text != "")
                {
                    btnBorrowReturn.Enabled = false;
                }
                else
                {
                    btnBorrowReturn.Enabled = true;
                }

            }
        }

        private void btnBorrowClear_Click(object sender, EventArgs e)
        {
            clearTxtBorrow();
        }

        private void btnBorrowDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = $"DELETE FROM borrows WHERE id = {txtBorrowId.Text}";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            query = $"UPDATE books SET quantity = '{int.Parse(txtBorrowBookQuantity.Text) + int.Parse(txtBorrowQuantity.Text)}' WHERE id = '{txtBorrowBookId.Text}'";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            loadListView(lvBorrow, "SELECT id, reader_id, book_id, quantity, borrow_date, deadline, return_date, deposit, fines FROM borrows ORDER BY id DESC");
            clearTxtBorrow();
        }

        private void tabManage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabManage.SelectedIndex)
            {
                case 0:
                    loadListView(lvReader, "SELECT id, name, cccd, phone, address FROM readers ORDER BY id DESC");
                    break;
                case 1:
                    loadListView(lvBook, "SELECT id, name, author, genre, language, publisher, price, quantity FROM books ORDER BY id DESC");
                    break;
                case 2:
                    borrowFilterSearch();
                    break;
            }
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            conn.Open();

            query = $"UPDATE borrows SET return_date = '{DateTime.Now.ToString("yyyy-MM-dd")}', fines = '{lblBorrowFines.Text}' WHERE id = '{txtBorrowId.Text}'";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            query = $"UPDATE books SET quantity = '{int.Parse(txtBorrowBookQuantity.Text) + int.Parse(txtBorrowQuantity.Text)}' WHERE id = '{txtBorrowBookId.Text}'";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            loadListView(lvBorrow, "SELECT id, reader_id, book_id, quantity, borrow_date, deadline, return_date, deposit, fines FROM borrows ORDER BY id DESC");
            clearTxtBorrow();
        }

        private void borrowFilterSearch()
        {
            string borrowFilter = "";

            switch (cbBorrowFilter.SelectedIndex)
            {
                case 1:
                    borrowFilter = "return_date IS NULL";
                    break;
                case 2:
                    borrowFilter = "return_date <= deadline AND return_date IS NOT NULL";
                    break;
                case 3:
                    borrowFilter = "return_date > deadline AND return_date IS NOT NULL";
                    break;
            }

            string borrowSearch = "id";

            switch (cbBorrowSearch.SelectedIndex)
            {
                case 1:
                    borrowSearch = "reader_id";
                    break;
                case 2:
                    borrowSearch = "book_id";
                    break;
                case 3:
                    borrowSearch = "quantity";
                    break;
                case 4:
                    borrowSearch = "FORMAT(borrow_date, 'dd-MM-yyyy')";
                    break;
                case 5:
                    borrowSearch = "FORMAT(deadline, 'dd-MM-yyyy')";
                    break;
                case 6:
                    borrowSearch = "FORMAT(return_date, 'dd-MM-yyyy')";
                    break;
            }

            if (txtBorrowSearch.Text == "")
            {
                borrowSearch = "id";
            }

            if (borrowFilter != "") borrowFilter = "AND " + borrowFilter;

            loadListView(lvBorrow, $"SELECT id, reader_id, book_id, quantity, borrow_date, deadline, return_date, deposit, fines FROM borrows WHERE {borrowSearch} LIKE '%{txtBorrowSearch.Text}%'  {borrowFilter} ORDER BY id DESC");
        }

        private void cbBorrowFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            borrowFilterSearch();
        }

        private void txtBorrowSearch_TextChanged(object sender, EventArgs e)
        {
            borrowFilterSearch();
        }

        private void txtBookPrice_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            btnEnabledBook();
        }

        private void txtBookQuantily_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            btnEnabledBook();
        }

        private void txtReaderCCCD_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            btnEnabledReader();
        }

        private void txtReaderPhone_TextChanged(object sender, EventArgs e)
        {
            txtOnlyNumber(sender as TextBox);
            btnEnabledReader();
        }

        private void btnEnabledBook()
        {
            bool flag = txtBookName.Text != ""
                && txtBookAuthor.Text != ""
                && txtBookGenre.Text != ""
                && txtBookLanguage.Text != ""
                && txtBookPublisher.Text != ""
                && txtBookPrice.Text != ""
                && txtBookQuantily.Text != ""
                && int.Parse(txtBookPrice.Text) >= 0
                && int.Parse(txtBookQuantily.Text) >= 0;

            if (flag)
            {
                btnBookAdd.Enabled = true;
                if (txtBookId.Text != "")
                {
                    btnBookEdit.Enabled = true;
                }
            }
            else
            {
                btnBookAdd.Enabled = false;
                btnBookEdit.Enabled = false;
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            btnEnabledBook();
        }

        private void txtBookAuthor_TextChanged(object sender, EventArgs e)
        {
            btnEnabledBook();
        }

        private void txtBookGenre_TextChanged(object sender, EventArgs e)
        {
            btnEnabledBook();
        }

        private void txtBookLanguage_TextChanged(object sender, EventArgs e)
        {
            btnEnabledBook();
        }

        private void txtBookPublisher_TextChanged(object sender, EventArgs e)
        {
            btnEnabledBook();
        }

        private void btnEnabledReader()
        {
            bool flag = txtReaderName.Text != ""
                && txtReaderCCCD.Text.Length >= 10
                && txtReaderPhone.Text.Length >= 10
                && txtReaderAddress.Text != "";


            if (flag)
            {
                btnReaderAdd.Enabled = true;
                if (txtReaderId.Text != "")
                {
                    btnReaderEdit.Enabled = true;
                }
            }
            else
            {
                btnReaderAdd.Enabled = false;
                btnReaderEdit.Enabled = false;
            }
        }

        private void txtReaderName_TextChanged(object sender, EventArgs e)
        {
            btnEnabledReader();
        }

        private void txtReaderAddress_TextChanged(object sender, EventArgs e)
        {
            btnEnabledReader();
        }
    }
}
