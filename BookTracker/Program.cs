using System;
using System.Collections.Generic;

namespace BookTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            string userInput;

            do
            {
                Console.WriteLine("What would you like to do?\n1. Reccomend a book\n2. See reccomended books\n3. Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        books.Add(GetBookInfo());
                        break;
                    case "2":
                        DisplayBooks(books);
                        break;
                    default:
                        break;
                }
            } while (userInput != "3");
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

        public static void DisplayBooks(List<Book> books)
        {
            books.ForEach(PrintBook);
        }

        public static void PrintBook(Book book)
        {
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Genre: " + book.Genre);
        }
    }
}
