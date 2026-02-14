using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            Console.WriteLine("Input: id title price stock");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            string id = parts[0] ;
            string title = parts[1];
            int price = int.Parse(parts[2]);
            int stock = int.Parse(parts[3]);

            Book book = new Book
            {
                BookID = id,
                BookTitle = title,
                Price = price,
                Stock = stock
            };

            BookUtility utility = new BookUtility(book);

            while (true)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit

                int choice = Int32.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                        // TODO:
                        // Read new price
                        // Call UpdateBookPrice()
                        Console.Write("Enter new Price: ");
                        int newPrice = Int32.Parse(Console.ReadLine());
                        utility.UpdateBookPrice(newPrice);
                        break;

                    case 3:
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        Console.Write("Enter new stock");
                        int newStock = Int32.Parse(Console.ReadLine());
                        utility.UpdateBookStock(newStock);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        // TODO: Handle invalid choice
                        Console.WriteLine("Inavlid Choice");
                        return;
                }
            }
        }
    }
}
