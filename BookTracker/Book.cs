using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker
{
    public class Book
    {
        public Book() { }
        public Book(string bookTitle, string bookAuthor, string bookGenre)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Genre = bookGenre;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
