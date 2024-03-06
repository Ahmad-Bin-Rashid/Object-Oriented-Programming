using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Book
    {
        private string title;
        private int pages;
        private Author author;

        public Book(string title, int pages, string name)
        {
            this.title = title;
            this.pages = pages;
            this.author = new Author(name);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Book Title: {title}\tNo of Pages: {pages}\t Author Name: {author.GetName()}");
        }
    }


    class Author
    {
        private string name;

        public Author(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("My Book", 100, "Ahmad");
            Book b2 = new Book("Theory of Life", 630, "Unknown");
            
            b1.PrintDetails();
            b2.PrintDetails();
            Console.ReadKey();
        }
    }
}
