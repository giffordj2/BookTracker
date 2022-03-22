using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace BookTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fileName = "recommendedBooks.json";
            string jsonData = File.ReadAllText(fileName);
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(jsonData)
                      ?? new List<Book>();
            UserInput userInput = new UserInput();
            string userInputString;

            var options = new JsonSerializerOptions { WriteIndented = true };

            do
            {
                Console.WriteLine("What would you like to do?(Please enter a number)\n1. Reccomend a book\n2. See reccomended books\n3. Exit");
                userInputString = userInput.GetInput();
                while (!IsValidSelection(userInputString))
                {
                    Console.WriteLine("Please enter a valid selection");
                    Console.WriteLine("What would you like to do?(Please enter a number)\n1. Reccomend a book\n2. See reccomended books\n3. Exit");
                    userInputString = userInput.GetInput();
                }

                switch (userInputString)
                {
                    case "1":
                        books.Add(GetBookInfo(userInput));
                        break;
                    case "2":
                        DisplayBooks(books);
                        break;
                    default:
                        break;
                }
            } while (userInputString != "3");

            string jsonString = JsonSerializer.Serialize(books, options);
            File.WriteAllText(fileName, jsonString);
        }

        public static Book GetBookInfo(IUserInput input)
        {
            Console.WriteLine("What is the title of the book?");
            string bookTitle = input.GetTitleInput();

            while (!IsValidInput(bookTitle))
            {
                Console.WriteLine("Please enter the title of the book.");
                bookTitle = input.GetTitleInput();
            }

            Console.WriteLine("Who is the author of the book?");
            string bookAuthor = input.GetAuthorInput();

            while (!IsValidInput(bookAuthor))
            {
                Console.WriteLine("Please enter the author of the book.");
                bookAuthor = input.GetAuthorInput();
            }

            Console.WriteLine("What genre is this book considered?");
            string bookGenre = input.GetGenreInput();

            while (!IsValidInput(bookGenre))
            {
                Console.WriteLine("Please enter the genre of the book.");
                bookGenre = input.GetGenreInput();
            }

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

        public static bool IsValidSelection(string input)
        {
            string pattern = @"[1-3]";
            return Regex.Match(input, pattern).Success;
        }

        public static bool IsValidInput(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
