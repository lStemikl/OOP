using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Book
    {
        public string author, title;
        private int pageCount;
        public bool collection;

        public Book()
        {
            this.author = "Анджей Сапковский";
            this.title = "Ведьмак";
            this.pageCount = 1364;
            this.collection = true;
        }
        public Book(string author, string title, int pageCount, bool collection)
        {
            this.author = author;
            this.title = title;
            this.pageCount = pageCount;
            this.collection = collection;
        }
        public Book(string author, string title, int pageCount)
        {
            this.author = author;
            this.title = title;
            this.pageCount = pageCount;
            this.collection = false;
        }
    }
}
