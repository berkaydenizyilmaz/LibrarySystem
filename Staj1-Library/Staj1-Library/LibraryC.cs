using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Staj1_Library
{
    // Kütüphane sınıfı
    class LibraryC
    {
        private string connectionStr;
        private List<string> bookList;

        public LibraryC()
        {
            string dbFileName = "Library.db";
            connectionStr = $"Data Source={dbFileName};Version=3;";

            bookList = new List<string>();
        }

        // Veri tabanına bilgileri atanmış kitap nesnesini ekliyor
        public void AddBook(Book book)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                string query = "INSERT INTO Books (ISBN, Title, Author, Category, Page, Copy, Borrowed) VALUES (@ISBN, @Title, @Author, @Category, @Page, @Copy, @Borrowed)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    if (IsISBNUnique(connection, book.ISBN))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                        cmd.Parameters.AddWithValue("@Title", book.title);
                        cmd.Parameters.AddWithValue("@Author", book.author);
                        cmd.Parameters.AddWithValue("@Category", book.category);
                        cmd.Parameters.AddWithValue("@Page", book.page);
                        cmd.Parameters.AddWithValue("@Copy", book.copy);
                        cmd.Parameters.AddWithValue("@Borrowed", book.borrowed);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("The book has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A book with the same ISBN already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Veri tabanından seçili ISBN'li kitabı siliyor
        public void DeleteBook(int ISBN)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                if (!IsISBNUnique(connection, ISBN))
                {
                    string query = "DELETE FROM Books WHERE ISBN = @ISBN";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", ISBN);

                        cmd.ExecuteNonQuery();

                        string bQuery = "DELETE FROM BorrowedBooks WHERE ISBN = @ISBN";

                        using (SQLiteCommand bCmd = new SQLiteCommand(bQuery, connection))
                        {
                            bCmd.Parameters.AddWithValue("@ISBN", ISBN);

                            bCmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("The book has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This ISBN is not registered; the book does not exist in the records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Veri tabanındaki tüm kitapları aşağıdaki formatta bir string listesine atıp geri döndürüyor
        public List<string> ShowAllBooks()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                string query = "SELECT * FROM Books";

                using (SQLiteCommand cmd = new SQLiteCommand(query , connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookInfo = $"ISBN: {reader["ISBN"]}\n" +
                                $"Title: {reader["Title"]}\n" +
                                $"Author: {reader["Author"]}\n" +
                                $"Category: {reader["Category"]}\n" +
                                $"Page: {reader["Page"]}\n" +
                                $"Copy: {reader["Copy"]}\n" +
                                $"Borrowed: {reader["Borrowed"]}\n";

                            bookList.Add(bookInfo);
                        }
                    }
                }
            }

            List<string> tempList = new List<string>(bookList);
            bookList.Clear();

            return tempList;
        }

        // Belirtilen kelimeyi içeren kitap var mı kontrol edip varsa kitabı veya kitapları 
        // listeye atıp geri döndürüyor
        public List<string> SearchBook(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return bookList;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                string query = "SELECT * FROM Books WHERE LOWER(Title) LIKE '%' || LOWER(@word) || '%' OR LOWER(Author) LIKE '%' || LOWER(@word) || '%' COLLATE NOCASE";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {                    
                    cmd.Parameters.AddWithValue("@word", word);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookInfo = $"ISBN: {reader["ISBN"]}\n" +
                                $"Title: {reader["Title"]}\n" +
                                $"Author: {reader["Author"]}\n" +
                                $"Category: {reader["Category"]}\n" +
                                $"Page: {reader["Page"]}\n" +
                                $"Copy: {reader["Copy"]}\n" +
                                $"Borrowed: {reader["Borrowed"]}\n";
                            bookList.Add(bookInfo);
                        }
                    }
                }
            }

            if (bookList.Count == 0)
            {
                return new List<string>();
            }

            List<string> tempList = new List<string>(bookList);
            bookList.Clear();

            return tempList;
        }

        // Gelen ISBN numarasındaki kitabı ödünç alınan kitaplar veri tabanına ekliyor ve kopya sayısını ayarlıyor
        public void Borrow(int ISBN)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                if (!IsISBNUnique(connection, ISBN))
                {
                    int copy = GetCopyCount(connection, ISBN);

                    if (copy > 0)
                    {
                        string query = "SELECT Title, Author FROM Books WHERE ISBN = @ISBN";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ISBN", ISBN);

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string title = reader["Title"].ToString();
                                    string author = reader["Author"].ToString();

                                    DateTime date = DateTime.Today.AddDays(14);
                                    DateTime date2 = DateTime.Today;

                                    string returnDate = date.ToString("yyyy-MM-dd");
                                    string borrowedDate = date2.ToString("yyyy-MM-dd");

                                    Random random = new Random();
                                    string loanNo = random.Next(10000, 99999).ToString();

                                    while (!IsLoanNoUnique(connection, loanNo))
                                    {
                                        loanNo = random.Next(10000, 99999).ToString();
                                    }

                                    string borrowQuery = "INSERT INTO BorrowedBooks (ISBN, Title, Author, LoanNo, BorrowedDate, ReturnDate, PastReturn) VALUES (@ISBN, @Title, @Author, @LoanNo, @BorrowedDate, @ReturnDate, @PastReturn)";
                                    using (SQLiteCommand borrowCmd = new SQLiteCommand(borrowQuery, connection))
                                    {
                                        borrowCmd.Parameters.AddWithValue("@ISBN", ISBN);
                                        borrowCmd.Parameters.AddWithValue("@Title", title);
                                        borrowCmd.Parameters.AddWithValue("@Author", author);
                                        borrowCmd.Parameters.AddWithValue("@LoanNo", loanNo);
                                        borrowCmd.Parameters.AddWithValue("@BorrowedDate", borrowedDate);
                                        borrowCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                                        borrowCmd.Parameters.AddWithValue("@PastReturn", "Not Overdue");

                                        borrowCmd.ExecuteNonQuery();
                                    }

                                    DecreaseCopy(connection, ISBN);
                                    IncreaseBorrowed(connection, ISBN);

                                    MessageBox.Show($"The book has been borrowed successfully.\n" +
                                        $"Borrowed Book:\n" +
                                        $"ISBN: {ISBN}\n" +
                                        $"Title: {title}\n" +
                                        $"Author: {author}\n" +
                                        $"Loan No: {loanNo}\n" +
                                        $"Borrowed Date: {borrowedDate}\n" +
                                        $"Return Date: {returnDate}",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no copies available for borrowing of this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ISBN is not registered; the book does not exist in the records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Belirtilen numaralı ödünç alınan kitabı ödünç alınan kitapların veri tabanından siliyor
        // ve kitaplar veri tabanındaki kopya sayısıyla ödünç alınan kitap sayısını düzenliyor
        public void ReturnBook(string loanNo)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                if (!IsLoanNoUnique(connection, loanNo))
                {
                    string query = "DELETE FROM BorrowedBooks WHERE LoanNo = @LoanNo";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        int ISBN = GetISBN(connection, loanNo);

                        cmd.Parameters.AddWithValue("@LoanNo", loanNo);

                        cmd.ExecuteNonQuery();

                        IncreaseCopy(connection, ISBN);
                        DecreaseBorrowed(connection, ISBN);

                        MessageBox.Show("The book has been successfully returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There is no book borrowed with this loan code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Veri tabanındaki tüm ödünç alınmış kitapları aşağıdaki formatta bir string listesine atıp geri döndürüyor
        public List<string> ShowAllBorrowedBooks()
        {

            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                CheckReturnDate(connection);

                string query = "SELECT * FROM BorrowedBooks";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookInfo = $"ISBN: {reader["ISBN"]}\n" +
                                              $"Title: {reader["Title"]}\n" +
                                              $"Author: {reader["Author"]}\n" +
                                              $"Loan No: {reader["LoanNo"]}\n" +
                                              $"Borrowed Date: {reader["BorrowedDate"]}\n" +
                                              $"Return Date: {reader["ReturnDate"]}\n" +
                                              $"Return Status: {reader["PastReturn"]}\n";

                            bookList.Add(bookInfo);
                        }
                    }
                }
            }

            List<string> tempList = new List<string>(bookList);
            bookList.Clear();

            return tempList;
        }

        // Veri tabanındaki iade tarihi geçmiş kitapları aşağıdaki formatta bir string listesine atıp geri döndürüyor
        public List<string> ShowOverdueBooks()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();

                CheckReturnDate(connection);

                string query = "SELECT * FROM BorrowedBooks WHERE PastReturn = 'Overdue'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookInfo = $"ISBN: {reader["ISBN"]}\n" +
                                              $"Title: {reader["Title"]}\n" +
                                              $"Author: {reader["Author"]}\n" +
                                              $"Loan No: {reader["LoanNo"]}\n" +
                                              $"Borrowed Date: {reader["BorrowedDate"]}\n" +
                                              $"Return Date: {reader["ReturnDate"]}\n" +
                                              $"Return Status: {reader["PastReturn"]}\n";

                            bookList.Add(bookInfo);
                        }
                    }
                }
            }

            List<string> tempList = new List<string>(bookList);
            bookList.Clear();

            return tempList;
        }


        // İade tarihi geçen kitapların iade durumunu günceller
        private void CheckReturnDate(SQLiteConnection connection)
        {
            string sQuery = "UPDATE BorrowedBooks SET PastReturn = @PastReturn WHERE DATE(ReturnDate) < DATE('now')";

            using (SQLiteCommand sCmd = new SQLiteCommand(sQuery, connection))
            {
                sCmd.Parameters.AddWithValue("@PastReturn", "Overdue");

                sCmd.ExecuteNonQuery();
            }
        }

        // Veri tabanında belirtilen ISBN'li kitap var mı kontrol ediyor
        private bool IsISBNUnique(SQLiteConnection connection, int ISBN)
        {
            string query = "SELECT COUNT(*) FROM Books WHERE ISBN = @ISBN";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count == 0;
            }
        }

        // Veri tabanındaki belirtilen numaralı bir veri var mı kontrol ediyor
        private bool IsLoanNoUnique(SQLiteConnection connection, string loanNo)
        {
            string query = "SELECT COUNT(*) FROM BorrowedBooks WHERE LoanNo = @LoanNo";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@LoanNo", loanNo);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count == 0;
            }
        }

        // Belirtilen ISBN'li kitabın kopya sayısını döndürüyor
        private int GetCopyCount(SQLiteConnection connection, int ISBN)
        {
            int copy = 0;

            string query = "SELECT Copy FROM Books WHERE ISBN = @ISBN";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN", ISBN);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        copy = Convert.ToInt32(reader["Copy"]);
                    }
                }
            }
            return copy;
        }

        // Belirtilen ISBN'li kitabın kopya sayısını azaltıyor
        private void DecreaseCopy(SQLiteConnection connection, int ISBN)
        {
            string query = "UPDATE Books SET Copy = Copy - 1 WHERE ISBN = @ISBN";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.ExecuteNonQuery();
            }
        }

        // Belirtilen ISBN'li kitabın kopya sayısını arttırıyor
        private void IncreaseCopy(SQLiteConnection connection, int ISBN)
        {
            string query = "UPDATE Books SET Copy = Copy + 1 WHERE ISBN = @ISBN";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.ExecuteNonQuery();
            }
        }

        // Belirtilen ISBN'li kitabın ödünç sayısını azaltıyor
        private void DecreaseBorrowed(SQLiteConnection connection, int ISBN)
        {
            string query = "UPDATE Books SET Borrowed = Borrowed - 1 WHERE ISBN = @ISBN";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.ExecuteNonQuery();
            }
        }

        // Belirtilen ISBN'li kitabın ödünç sayısını arttırıyor
        private void IncreaseBorrowed(SQLiteConnection connection, int ISBN)
        {
            string query = "UPDATE Books SET Borrowed = Borrowed + 1 WHERE ISBN = @ISBN";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.ExecuteNonQuery();
            }
        }

        // Belirtilen ödünç koduna sahip kitabın ISBN'inini döndürüyor
        private int GetISBN(SQLiteConnection connection, string loanNo)
        {
            int ISBN = 0;

            string query = $"SELECT ISBN FROM BorrowedBooks WHERE LoanNo = @LoanNo";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LoanNo", loanNo);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ISBN = Convert.ToInt32(reader["ISBN"]);
                    }
                }
            }
            return ISBN;
        }
    }
}