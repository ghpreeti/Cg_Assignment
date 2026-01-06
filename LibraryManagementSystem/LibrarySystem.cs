using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class LibrarySystem : ILibrarySystem
    {
        private Dictionary<IBook, int> _books = null;

        private Dictionary<IBook, int> books = new Dictionary<IBook, int>();

        // Add book with quantity
        public void AddBook(IBook book, int quantity)
        {
            if (book == null || quantity <= 0)
                throw new ArgumentException("Invalid book or quantity");

            if (books.ContainsKey(book))
                books[book] += quantity;
            else
                books.Add(book, quantity);
        }

        // Remove book quantity
        public void RemoveBook(IBook book, int quantity)
        {
            if (book == null || quantity <= 0)
                throw new ArgumentException("Invalid book or quantity");

            if (books.ContainsKey(book))
            {
                books[book] -= quantity;

                if (books[book] <= 0)
                    books.Remove(book);
            }
        }

        // Total price of all books
        public int CalculateTotal()
        {
            return books.Sum(b => b.Key.Price * b.Value);
        }

        // Category → total price
        public List<(string, int)> CategoryTotalPrice()
        {
            return books
                .GroupBy(b => b.Key.Category)
                .Select(g => (g.Key, g.Sum(x => x.Key.Price * x.Value)))
                .ToList();
        }

        // Book title, quantity, price
        public List<(string, int, int)> BooksInfo()
        {
            return books
                .Select(b => (b.Key.Title, b.Value, b.Key.Price))
                .ToList();
        }

        // Category, Author, count
        public List<(string, string, int)> CategoryAndAuthorWithCount()
        {
            return books
                .GroupBy(b => new { b.Key.Category, b.Key.Author })
                .Select(g => (g.Key.Category, g.Key.Author, g.Sum(x => x.Value)))
                .ToList();
        }
    }
}
