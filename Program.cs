using System;
using static System.Console;

namespace Lab_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            ReferenceBook r = new ReferenceBook("R");
            TextBook t = new TextBook("T");

            WriteLine("Enter the ID string of the reference book: ");
            r.id_string = ReadLine();
            WriteLine("Enter the Author of the reference book: ");
            r.Author = ReadLine();
            WriteLine("Enter the Title of the reference book: ");
            r.BookTitle = ReadLine();

            WriteLine("Enter the ID string of the textbook: ");
            t.id_string = ReadLine();
            WriteLine("Enter the Author of the textbook: ");
            t.Author = ReadLine();
            WriteLine("Enter the Title of textbook: ");
            t.BookTitle = ReadLine();

            DisplayBook(r);
            DisplayBook(t);
        }
        public static void DisplayBook(Book output)
        {
            WriteLine(output.BookTitle + " written by " + output.Author + " with ID string " + output.id_string + ": " + output.Message());
        }
    }
    abstract class Book
    {
        private string author;
        private string booktitle;
        private string idstring;
        public Book(string id)
        {
            idstring = id;
        }
        public string id_string
        {
            get
            {
                return idstring;
            }
            set
            {
                idstring = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string BookTitle
        {
            get
            {
                return booktitle;
            }
            set
            {
                booktitle = value;
            }
        }
        public abstract string Message();
    }
    class ReferenceBook : Book
    {
        public ReferenceBook(string id) : base(id)
        {
        }
        public override string Message()
        {
            return "Sell 12 months per year";
        }
    }
    class TextBook : Book
    {
        public TextBook(string id_string) : base(id_string)
        {
        }
        public override string Message()
        {
            return "Sell Summer months";
        }
    }
}