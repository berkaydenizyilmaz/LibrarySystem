namespace Staj1_Library
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Main = new System.Windows.Forms.Button();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_BookName = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_colon = new System.Windows.Forms.Label();
            this.label_colon2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_colon4 = new System.Windows.Forms.Label();
            this.label_colon6 = new System.Windows.Forms.Label();
            this.label_Copy = new System.Windows.Forms.Label();
            this.label_colon3 = new System.Windows.Forms.Label();
            this.label_Page = new System.Windows.Forms.Label();
            this.label_colon5 = new System.Windows.Forms.Label();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.mst_ISBN = new System.Windows.Forms.MaskedTextBox();
            this.mst_BookName = new System.Windows.Forms.MaskedTextBox();
            this.mst_Author = new System.Windows.Forms.MaskedTextBox();
            this.mst_Category = new System.Windows.Forms.MaskedTextBox();
            this.mst_Page = new System.Windows.Forms.MaskedTextBox();
            this.mst_Copy = new System.Windows.Forms.MaskedTextBox();
            this.button_DeleteBook = new System.Windows.Forms.Button();
            this.label_Information = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_ShowAllBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Main
            // 
            this.button_Main.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Main.Location = new System.Drawing.Point(254, 493);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(165, 48);
            this.button_Main.TabIndex = 5;
            this.button_Main.Text = "Main Menu";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // label_ISBN
            // 
            this.label_ISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ISBN.Location = new System.Drawing.Point(104, 111);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(62, 25);
            this.label_ISBN.TabIndex = 6;
            this.label_ISBN.Text = "ISBN";
            this.label_ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BookName
            // 
            this.label_BookName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_BookName.AutoSize = true;
            this.label_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_BookName.Location = new System.Drawing.Point(43, 162);
            this.label_BookName.Name = "label_BookName";
            this.label_BookName.Size = new System.Drawing.Size(123, 25);
            this.label_BookName.TabIndex = 7;
            this.label_BookName.Text = "Book Name";
            this.label_BookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Author
            // 
            this.label_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Author.Location = new System.Drawing.Point(90, 216);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(76, 25);
            this.label_Author.TabIndex = 8;
            this.label_Author.Text = "Author";
            // 
            // label_Category
            // 
            this.label_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Category.Location = new System.Drawing.Point(66, 265);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(100, 25);
            this.label_Category.TabIndex = 9;
            this.label_Category.Text = "Category";
            this.label_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_colon
            // 
            this.label_colon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_colon.AutoSize = true;
            this.label_colon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_colon.Location = new System.Drawing.Point(172, 111);
            this.label_colon.Name = "label_colon";
            this.label_colon.Size = new System.Drawing.Size(19, 25);
            this.label_colon.TabIndex = 10;
            this.label_colon.Text = ":";
            // 
            // label_colon2
            // 
            this.label_colon2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_colon2.AutoSize = true;
            this.label_colon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_colon2.Location = new System.Drawing.Point(172, 162);
            this.label_colon2.Name = "label_colon2";
            this.label_colon2.Size = new System.Drawing.Size(19, 25);
            this.label_colon2.TabIndex = 11;
            this.label_colon2.Text = ":";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // label_colon4
            // 
            this.label_colon4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_colon4.AutoSize = true;
            this.label_colon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_colon4.Location = new System.Drawing.Point(172, 265);
            this.label_colon4.Name = "label_colon4";
            this.label_colon4.Size = new System.Drawing.Size(19, 25);
            this.label_colon4.TabIndex = 13;
            this.label_colon4.Text = ":";
            // 
            // label_colon6
            // 
            this.label_colon6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_colon6.AutoSize = true;
            this.label_colon6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_colon6.Location = new System.Drawing.Point(172, 370);
            this.label_colon6.Name = "label_colon6";
            this.label_colon6.Size = new System.Drawing.Size(19, 25);
            this.label_colon6.TabIndex = 17;
            this.label_colon6.Text = ":";
            // 
            // label_Copy
            // 
            this.label_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Copy.AutoSize = true;
            this.label_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Copy.Location = new System.Drawing.Point(103, 370);
            this.label_Copy.Name = "label_Copy";
            this.label_Copy.Size = new System.Drawing.Size(63, 25);
            this.label_Copy.TabIndex = 16;
            this.label_Copy.Text = "Copy";
            this.label_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_colon3
            // 
            this.label_colon3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_colon3.AutoSize = true;
            this.label_colon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_colon3.Location = new System.Drawing.Point(172, 216);
            this.label_colon3.Name = "label_colon3";
            this.label_colon3.Size = new System.Drawing.Size(19, 25);
            this.label_colon3.TabIndex = 12;
            this.label_colon3.Text = ":";
            // 
            // label_Page
            // 
            this.label_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Page.AutoSize = true;
            this.label_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Page.Location = new System.Drawing.Point(104, 317);
            this.label_Page.Name = "label_Page";
            this.label_Page.Size = new System.Drawing.Size(62, 25);
            this.label_Page.TabIndex = 14;
            this.label_Page.Text = "Page";
            this.label_Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_colon5
            // 
            this.label_colon5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_colon5.AutoSize = true;
            this.label_colon5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_colon5.Location = new System.Drawing.Point(172, 312);
            this.label_colon5.Name = "label_colon5";
            this.label_colon5.Size = new System.Drawing.Size(19, 25);
            this.label_colon5.TabIndex = 15;
            this.label_colon5.Text = ":";
            // 
            // button_AddBook
            // 
            this.button_AddBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AddBook.AutoSize = true;
            this.button_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AddBook.Location = new System.Drawing.Point(48, 436);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(175, 48);
            this.button_AddBook.TabIndex = 18;
            this.button_AddBook.Text = "Add Book";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // mst_ISBN
            // 
            this.mst_ISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mst_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mst_ISBN.Location = new System.Drawing.Point(197, 106);
            this.mst_ISBN.Mask = "00000";
            this.mst_ISBN.Name = "mst_ISBN";
            this.mst_ISBN.Size = new System.Drawing.Size(151, 30);
            this.mst_ISBN.TabIndex = 19;
            // 
            // mst_BookName
            // 
            this.mst_BookName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mst_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mst_BookName.Location = new System.Drawing.Point(197, 157);
            this.mst_BookName.Name = "mst_BookName";
            this.mst_BookName.Size = new System.Drawing.Size(151, 30);
            this.mst_BookName.TabIndex = 20;
            // 
            // mst_Author
            // 
            this.mst_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mst_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mst_Author.Location = new System.Drawing.Point(197, 211);
            this.mst_Author.Name = "mst_Author";
            this.mst_Author.Size = new System.Drawing.Size(151, 30);
            this.mst_Author.TabIndex = 21;
            // 
            // mst_Category
            // 
            this.mst_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mst_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mst_Category.Location = new System.Drawing.Point(197, 260);
            this.mst_Category.Name = "mst_Category";
            this.mst_Category.Size = new System.Drawing.Size(151, 30);
            this.mst_Category.TabIndex = 22;
            // 
            // mst_Page
            // 
            this.mst_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mst_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mst_Page.Location = new System.Drawing.Point(197, 312);
            this.mst_Page.Mask = "00000";
            this.mst_Page.Name = "mst_Page";
            this.mst_Page.Size = new System.Drawing.Size(151, 30);
            this.mst_Page.TabIndex = 23;
            this.mst_Page.ValidatingType = typeof(int);
            // 
            // mst_Copy
            // 
            this.mst_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mst_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mst_Copy.Location = new System.Drawing.Point(197, 365);
            this.mst_Copy.Mask = "00000";
            this.mst_Copy.Name = "mst_Copy";
            this.mst_Copy.Size = new System.Drawing.Size(151, 30);
            this.mst_Copy.TabIndex = 24;
            this.mst_Copy.ValidatingType = typeof(int);
            // 
            // button_DeleteBook
            // 
            this.button_DeleteBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_DeleteBook.AutoSize = true;
            this.button_DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_DeleteBook.Location = new System.Drawing.Point(254, 436);
            this.button_DeleteBook.Name = "button_DeleteBook";
            this.button_DeleteBook.Size = new System.Drawing.Size(165, 48);
            this.button_DeleteBook.TabIndex = 26;
            this.button_DeleteBook.Text = "Delete Book";
            this.button_DeleteBook.UseVisualStyleBackColor = true;
            this.button_DeleteBook.Click += new System.EventHandler(this.button_DeleteBook_Click);
            // 
            // label_Information
            // 
            this.label_Information.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Information.AutoSize = true;
            this.label_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Information.Location = new System.Drawing.Point(12, 9);
            this.label_Information.Name = "label_Information";
            this.label_Information.Size = new System.Drawing.Size(604, 50);
            this.label_Information.TabIndex = 27;
            this.label_Information.Text = "To add a book, enter all the information. \r\nTo delete a book, enter only the ISBN" +
    " of the book you want to delete.";
            this.label_Information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox.Location = new System.Drawing.Point(530, 62);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(340, 479);
            this.richTextBox.TabIndex = 36;
            this.richTextBox.Text = "";
            // 
            // button_ShowAllBooks
            // 
            this.button_ShowAllBooks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ShowAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ShowAllBooks.Location = new System.Drawing.Point(48, 493);
            this.button_ShowAllBooks.Name = "button_ShowAllBooks";
            this.button_ShowAllBooks.Size = new System.Drawing.Size(175, 48);
            this.button_ShowAllBooks.TabIndex = 35;
            this.button_ShowAllBooks.Text = "Show All Books";
            this.button_ShowAllBooks.UseVisualStyleBackColor = true;
            this.button_ShowAllBooks.Click += new System.EventHandler(this.button_ShowAllBooks_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button_ShowAllBooks);
            this.Controls.Add(this.label_Information);
            this.Controls.Add(this.button_DeleteBook);
            this.Controls.Add(this.mst_Copy);
            this.Controls.Add(this.mst_Page);
            this.Controls.Add(this.mst_Category);
            this.Controls.Add(this.mst_Author);
            this.Controls.Add(this.mst_BookName);
            this.Controls.Add(this.mst_ISBN);
            this.Controls.Add(this.button_AddBook);
            this.Controls.Add(this.label_colon6);
            this.Controls.Add(this.label_Copy);
            this.Controls.Add(this.label_colon5);
            this.Controls.Add(this.label_Page);
            this.Controls.Add(this.label_colon4);
            this.Controls.Add(this.label_colon3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_colon2);
            this.Controls.Add(this.label_colon);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_BookName);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.button_Main);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookForm_FormClosed);
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Main;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_BookName;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_colon;
        private System.Windows.Forms.Label label_colon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_colon4;
        private System.Windows.Forms.Label label_colon6;
        private System.Windows.Forms.Label label_Copy;
        private System.Windows.Forms.Label label_colon3;
        private System.Windows.Forms.Label label_Page;
        private System.Windows.Forms.Label label_colon5;
        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.MaskedTextBox mst_ISBN;
        private System.Windows.Forms.MaskedTextBox mst_BookName;
        private System.Windows.Forms.MaskedTextBox mst_Author;
        private System.Windows.Forms.MaskedTextBox mst_Category;
        private System.Windows.Forms.MaskedTextBox mst_Page;
        private System.Windows.Forms.MaskedTextBox mst_Copy;
        private System.Windows.Forms.Button button_DeleteBook;
        private System.Windows.Forms.Label label_Information;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button button_ShowAllBooks;
    }
}