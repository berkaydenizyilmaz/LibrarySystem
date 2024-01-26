namespace Staj1_Library
{
    partial class MainMenu
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
            this.label_Title = new System.Windows.Forms.Label();
            this.button_DeleteAddBook = new System.Windows.Forms.Button();
            this.button_Library = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Title.Location = new System.Drawing.Point(148, 38);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(319, 38);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Weltome To Library";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_DeleteAddBook
            // 
            this.button_DeleteAddBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_DeleteAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_DeleteAddBook.Location = new System.Drawing.Point(191, 200);
            this.button_DeleteAddBook.Name = "button_DeleteAddBook";
            this.button_DeleteAddBook.Size = new System.Drawing.Size(241, 48);
            this.button_DeleteAddBook.TabIndex = 1;
            this.button_DeleteAddBook.Text = "Add/Delete Book";
            this.button_DeleteAddBook.UseVisualStyleBackColor = true;
            this.button_DeleteAddBook.Click += new System.EventHandler(this.button_BookAddRemove_Click);
            // 
            // button_Library
            // 
            this.button_Library.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Library.Location = new System.Drawing.Point(191, 128);
            this.button_Library.Name = "button_Library";
            this.button_Library.Size = new System.Drawing.Size(241, 48);
            this.button_Library.TabIndex = 2;
            this.button_Library.Text = "Library";
            this.button_Library.UseVisualStyleBackColor = true;
            this.button_Library.Click += new System.EventHandler(this.button_Library_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.button_Library);
            this.Controls.Add(this.button_DeleteAddBook);
            this.Controls.Add(this.label_Title);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_DeleteAddBook;
        private System.Windows.Forms.Button button_Library;
    }
}

