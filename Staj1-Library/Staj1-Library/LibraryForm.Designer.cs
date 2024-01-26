namespace Staj1_Library
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.button_Main = new System.Windows.Forms.Button();
            this.label_Information = new System.Windows.Forms.Label();
            this.button_ShowAllBooks = new System.Windows.Forms.Button();
            this.button_SearchBook = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Borrow = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_ShowAllBrowedBooks = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_DateInfo = new System.Windows.Forms.Label();
            this.button_ShowOverdueBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Main
            // 
            this.button_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Main.AutoSize = true;
            this.button_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Main.Location = new System.Drawing.Point(144, 481);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(159, 60);
            this.button_Main.TabIndex = 4;
            this.button_Main.Text = "Main Menu";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // label_Information
            // 
            this.label_Information.AutoSize = true;
            this.label_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Information.Location = new System.Drawing.Point(12, 25);
            this.label_Information.Name = "label_Information";
            this.label_Information.Size = new System.Drawing.Size(397, 72);
            this.label_Information.TabIndex = 7;
            this.label_Information.Text = resources.GetString("label_Information.Text");
            this.label_Information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ShowAllBooks
            // 
            this.button_ShowAllBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ShowAllBooks.AutoSize = true;
            this.button_ShowAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ShowAllBooks.Location = new System.Drawing.Point(241, 264);
            this.button_ShowAllBooks.Name = "button_ShowAllBooks";
            this.button_ShowAllBooks.Size = new System.Drawing.Size(159, 48);
            this.button_ShowAllBooks.TabIndex = 27;
            this.button_ShowAllBooks.Text = "Show All Books";
            this.button_ShowAllBooks.UseVisualStyleBackColor = true;
            this.button_ShowAllBooks.Click += new System.EventHandler(this.button_ShowAllBooks_Click);
            // 
            // button_SearchBook
            // 
            this.button_SearchBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SearchBook.AutoSize = true;
            this.button_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SearchBook.Location = new System.Drawing.Point(41, 264);
            this.button_SearchBook.Name = "button_SearchBook";
            this.button_SearchBook.Size = new System.Drawing.Size(159, 48);
            this.button_SearchBook.TabIndex = 28;
            this.button_SearchBook.Text = "Search Book";
            this.button_SearchBook.UseVisualStyleBackColor = true;
            this.button_SearchBook.Click += new System.EventHandler(this.button_SearchBook_Click);
            // 
            // button_Return
            // 
            this.button_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Return.AutoSize = true;
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Return.Location = new System.Drawing.Point(241, 332);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(159, 48);
            this.button_Return.TabIndex = 29;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Borrow
            // 
            this.button_Borrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Borrow.AutoSize = true;
            this.button_Borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Borrow.Location = new System.Drawing.Point(41, 332);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(159, 48);
            this.button_Borrow.TabIndex = 30;
            this.button_Borrow.Text = "Borrow";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox.Location = new System.Drawing.Point(90, 191);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(249, 30);
            this.textBox.TabIndex = 31;
            // 
            // button_ShowAllBrowedBooks
            // 
            this.button_ShowAllBrowedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ShowAllBrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ShowAllBrowedBooks.Location = new System.Drawing.Point(41, 402);
            this.button_ShowAllBrowedBooks.Name = "button_ShowAllBrowedBooks";
            this.button_ShowAllBrowedBooks.Size = new System.Drawing.Size(159, 60);
            this.button_ShowAllBrowedBooks.TabIndex = 32;
            this.button_ShowAllBrowedBooks.Text = "Show All \r\nBrowed Books";
            this.button_ShowAllBrowedBooks.UseVisualStyleBackColor = true;
            this.button_ShowAllBrowedBooks.Click += new System.EventHandler(this.button_ShowAllBrowedBooks_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox.Location = new System.Drawing.Point(443, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(427, 529);
            this.richTextBox.TabIndex = 34;
            this.richTextBox.Text = "";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Date.Location = new System.Drawing.Point(150, 131);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(50, 25);
            this.label_Date.TabIndex = 35;
            this.label_Date.Text = "date";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DateInfo
            // 
            this.label_DateInfo.AutoSize = true;
            this.label_DateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_DateInfo.Location = new System.Drawing.Point(85, 131);
            this.label_DateInfo.Name = "label_DateInfo";
            this.label_DateInfo.Size = new System.Drawing.Size(59, 25);
            this.label_DateInfo.TabIndex = 36;
            this.label_DateInfo.Text = "Date:";
            this.label_DateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ShowOverdueBooks
            // 
            this.button_ShowOverdueBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ShowOverdueBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ShowOverdueBooks.Location = new System.Drawing.Point(241, 402);
            this.button_ShowOverdueBooks.Name = "button_ShowOverdueBooks";
            this.button_ShowOverdueBooks.Size = new System.Drawing.Size(159, 60);
            this.button_ShowOverdueBooks.TabIndex = 37;
            this.button_ShowOverdueBooks.Text = "Show Overdue Books";
            this.button_ShowOverdueBooks.UseVisualStyleBackColor = true;
            this.button_ShowOverdueBooks.Click += new System.EventHandler(this.button_ShowOverdueBooks_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button_ShowOverdueBooks);
            this.Controls.Add(this.label_DateInfo);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button_ShowAllBrowedBooks);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_Borrow);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_SearchBook);
            this.Controls.Add(this.button_ShowAllBooks);
            this.Controls.Add(this.label_Information);
            this.Controls.Add(this.button_Main);
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Library_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Main;
        private System.Windows.Forms.Label label_Information;
        private System.Windows.Forms.Button button_SearchBook;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_ShowAllBrowedBooks;
        private System.Windows.Forms.Button button_ShowAllBooks;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_DateInfo;
        private System.Windows.Forms.Button button_ShowOverdueBooks;
    }
}