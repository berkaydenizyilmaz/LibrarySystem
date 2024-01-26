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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Kütüphane yönetim formuna geçiş
        private void button_Library_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Library libraryForm = new Library())
            {
                libraryForm.ShowDialog();
            }
        }

        // Kitap ekleme silme formuna geçiş
        private void button_BookAddRemove_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (BookForm bookForm = new BookForm())
            {
                bookForm.ShowDialog();
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}