using System;

namespace BookStoreApplication
{
    public class BookUtility
    {
        private Book _book;

        public BookUtility(Book book)
        {
            // TODO: Assign book object
            _book = book;
        }

        public void GetBookDetails()
        {
            // TODO:
            // Print format:
            // Details: <BookId> <Title> <Price> <Stock>
            Console.WriteLine($"<BookId>:{_book.BookID} <Title>:{_book.BookTitle} <Price>:{_book.Price} <Stock>:{_book.Stock}");
        }

        public void UpdateBookPrice(int newPrice)
        {
            // TODO:
            // Validate new price
            // Update price
            // Print: Updated Price: <newPrice>
            if (!_book.Price.Equals(newPrice))
            {
                _book.Price = newPrice;
            }
            else
            {
                throw new ArgumentException("Price already exists");
            }
            Console.WriteLine($"Updated Price: {_book.Price}");
        }

        public void UpdateBookStock(int newStock)
        {
            // TODO:
            // Validate new stock
            // Update stock
            // Print: Updated Stock: <newStock>

            if (!_book.Stock.Equals(newStock))
            {
                _book.Stock = newStock;
            }
            else
            {
                throw new ArgumentException("Stock already exists");
            }
            Console.WriteLine($"Updated Stock: {_book.Stock}");
        }
    }
}
