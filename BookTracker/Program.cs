using System;

namespace BookTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = GetBookInfo();
            Console.WriteLine("The book title is " + book.Title);
        }

        public static Book GetBookInfo()
        {
            Console.WriteLine("What is the title of the book?");
            string bookTitle = Console.ReadLine();

            Console.WriteLine("Whos is the author of the book?");
            string bookAuthor = Console.ReadLine();

            Console.WriteLine("What genre is this book considered?");
            string bookGenre = Console.ReadLine();

            return new Book(bookTitle, bookAuthor, bookGenre);
        }
    }
}
