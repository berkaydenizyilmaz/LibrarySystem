using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj1_Library
{
    public partial class Library : Form
    {
        MainMenu libraryMainForm;
        LibraryC library;
        List<string> booksInfo;
        List<string> searchedBooks;
        DateTime today;
        public Library()
        {
            InitializeComponent();

            libraryMainForm = new MainMenu();

            library = new LibraryC();

            booksInfo = new List<string>();
            searchedBooks = new List<string>();

            today = DateTime.Now;
            label_Date.Text = today.ToShortDateString();
        }

        // Girilen kelimeyi veri tabanında yazar ve kitap başlıklarında kontrol edip varsa getiren kütüphane sınıfının
        // search book fonksiyonunu çağırıyor
        private void button_SearchBook_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            string word = textBox.Text.Trim();
            searchedBooks = library.SearchBook(word);

            if (searchedBooks.Count > 0)
            {
                foreach (string bookInfo in searchedBooks)
                {
                    richTextBox.Text += bookInfo + "\n";
                }
            }
            else
            {
                MessageBox.Show("The book or author could not be found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            searchedBooks.Clear();

            textBox.Clear();
        }

        // Tüm kitapları richTextBox'ta, kütüphane sınıfının showAllBooks fonksiyonunu çağırarak sıralıyor
        private void button_ShowAllBooks_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            booksInfo = library.ShowAllBooks();
            if (booksInfo.Count > 0)
            {
                foreach (string bookInfo in booksInfo)
                {
                    richTextBox.Text += bookInfo + "\n";
                }
            }
            else
            {
                MessageBox.Show("There are no books in the library.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ISBN numarasını alıp kütüphane sınıfının borrow fonksiyonunu çağırıyor ve richTextBox'ı güncelliyor
        private void button_Borrow_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Clear();

                int ISBN = Convert.ToInt32(textBox.Text.Trim());

                library.Borrow(ISBN);

                booksInfo = library.ShowAllBooks();
                foreach (string bookInfo in booksInfo)
                {
                    richTextBox.Text += bookInfo + "\n";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"We encountered an error.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox.Clear();
        }

        // Ödünç numarasını alıp kütüphane sınıfının return book fonksiyonunu çağırıyor
        private void button_Return_Click(object sender, EventArgs e)
        {
            try
            {
                string loanNo = textBox.Text.Trim();

                library.ReturnBook(loanNo);

                richTextBox.Clear();

                booksInfo = library.ShowAllBorrowedBooks();
                foreach (string bookInfo in booksInfo)
                {
                    richTextBox.Text += bookInfo + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"We encountered an error.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox.Clear();
        }

        // Ödünç alınan tüm kitapları, kütüphane sınıfının show all borrowed books fonksiyonunu çağırarak sıralıyor
        private void button_ShowAllBrowedBooks_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        
            booksInfo = library.ShowAllBorrowedBooks();
            if (booksInfo.Count > 0)
            {
                foreach (string bookInfo in booksInfo)
                {
                    richTextBox.Text += bookInfo + "\n";
                }
            }
            else
            {
                MessageBox.Show("There are no borrowed books in the library.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tarihi geçmiş kitapları göstermeyi sağlayan kütüphane sınıfının show overdue books fonksiyonunu çağırır
        private void button_ShowOverdueBooks_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            booksInfo = library.ShowOverdueBooks();
            if (booksInfo.Count > 0)
            {
                foreach (string bookInfo in booksInfo)
                {
                    richTextBox.Text += bookInfo + "\n";
                }
            }
            else
            {
                MessageBox.Show("There are no overdue books in the library.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Ana menüye geçiş
        private void button_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            libraryMainForm.ShowDialog();
        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}