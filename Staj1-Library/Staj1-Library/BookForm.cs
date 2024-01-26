using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Staj1_Library
{
    public partial class BookForm : Form
    {
        MainMenu libraryMainForm;
        LibraryC library;
        List<string> booksInfo;

        public BookForm()
        {
            InitializeComponent();

            libraryMainForm = new MainMenu();

            library = new LibraryC();

            booksInfo = new List<string>();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            richTextBox.Clear();

            booksInfo = library.ShowAllBooks();
            foreach (string bookInfo in booksInfo)
            {
                richTextBox.Text += bookInfo + "\n";
            }
        }

        // Alınan bilgilerle kitap nesnesi oluşturup veri tabanına eklemek için
        // kütüphane sınıfında bulunan AddBook fonksiyonunu çağırıyor ve richTextBox'ı güncelliyor
        private void button_AddBook_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Clear();

                int ISBN = Convert.ToInt32(mst_ISBN.Text.TrimStart('0'));
                string title = mst_BookName.Text;
                string author = mst_Author.Text;
                string category = mst_Category.Text;
                int page = Convert.ToInt32(mst_Page.Text.TrimStart('0'));
                int copy = Convert.ToInt32(mst_Copy.Text.TrimStart('0'));

                Book newBook = new Book(title, author, category, page, ISBN, copy);

                library.AddBook(newBook);

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

            ClearInputFields();
        }

        // Veri tabanından belirtilen ISBN'li kitabı silmek için 
        // kütüphane sınıfındaki DeleteBook fonksiyonunu çağırıyor ve richTextBox'ı güncelliyor
        private void button_DeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Clear();

                if (int.TryParse(mst_ISBN.Text, out int deleteISBN))
                {
                    deleteISBN = Convert.ToInt32(mst_ISBN.Text);

                    library.DeleteBook(deleteISBN);

                    booksInfo = library.ShowAllBooks();
                    if (booksInfo.Count > 0)
                    {
                        foreach (string bookInfo in booksInfo)
                        {
                            richTextBox.Text += bookInfo + "\n";
                        }
                    }
                    else { };
                }
                else
                {
                    MessageBox.Show("Please enter a valid ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"We encountered an error.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearInputFields();
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

        // Formdaki textBox'ları temizliyor
        private void ClearInputFields()
        {
            mst_ISBN.Clear();
            mst_BookName.Clear();
            mst_Author.Clear();
            mst_Category.Clear();
            mst_Copy.Clear();
            mst_Page.Clear();
        }

        // Ana menüye geçiş
        private void button_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            libraryMainForm.ShowDialog();
        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
