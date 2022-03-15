using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace BookTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "recommendedBooks.json";
            string jsonData = File.ReadAllText(fileName);
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(jsonData)
                      ?? new List<Book>();
            string userInput;

            var options = new JsonSerializerOptions { WriteIndented = true };

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

            string jsonString = JsonSerializer.Serialize(books, options);
            File.WriteAllText(fileName, jsonString);
        }

        public static Book GetBookInfo()
        {
            Console.WriteLine("What is the title of the book?");
            string bookTitle = Console.ReadLine();

            Console.WriteLine("Who is the author of the book?");
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
            Console.WriteLine("\n");
        }
    }
}
