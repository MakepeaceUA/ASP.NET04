
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public static class BookService
    {
        private static List<Book> Books { get; } = new List<Book>
        {
            new Book { Id = 1, Title = "Title1", Author = "Author1", Genre = "Genre" },
            new Book { Id = 2, Title = "Title2", Author = "Author2", Genre = "Genre" },
            new Book { Id = 3, Title = "Title3", Author = "Author3", Genre = "Genre" }
        };

        public static List<Book> GetAll() => Books;

        public static Book? Get(int id) => Books.FirstOrDefault(b => b.Id == id);

        public static void Add(Book book)
        {
            var nextId = Books.Max(b => b.Id) + 1;
            book.Id = nextId;
            Books.Add(book);
        }
    }
}
