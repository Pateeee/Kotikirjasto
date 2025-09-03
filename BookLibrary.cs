using System;
using System.Collections.Generic;
using System.Linq;

namespace KirjalistaApp
{
    public class BookLibrary
    {
        private readonly List<Book> _books = new();

        public void AddBook(string title, string author, int year, string genre)
        {
            _books.Add(new Book(title, author, year, genre));
        }

        public void RemoveBook(int index)
        {
            if (index >= 0 && index < _books.Count)
                _books.RemoveAt(index);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public IEnumerable<Book> GetBooksByGenre(string genre)
        {
            return _books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Book> SearchBooks(string query)
        {
            return _books.Where(b =>
                b.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                b.Author.Contains(query, StringComparison.OrdinalIgnoreCase));
        }
    }
}