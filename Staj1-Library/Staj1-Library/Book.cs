using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Staj1_Library
{
    //Kitap sınıfı
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public int page { get; set; }
        public int ISBN { get; set; }
        public int copy {  get; set; }
        public int borrowed { get; set; }

        public Book(string title, string author, string category, int page, int ISBN, int copy)
        {
            this.title = title;
            this.author = author;
            this.category = category;
            this.page = page;
            this.ISBN = ISBN;
            this.copy = copy;

            this.borrowed = 0;
        }
    }
}