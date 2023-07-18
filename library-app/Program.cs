using LibrarySystem.Models;
using LibrarySystem.Actions;

using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book { Title = "Book 1", Author = "Author 1", IsAvailable = true };
        Book book2 = new Book { Title = "Book 2", Author = "Author 2", IsAvailable = false };
        Book book3 = new Book { Title = "Book 3", Author = "Author 3", IsAvailable = true };

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("Welcome to the Library System!");

        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                CustomerActions.PerformActions(library);
            }
            else if (input == "2")
            {
                AdminActions.PerformActions(library);
            }
            else if (input == "3")
            {
                Console.WriteLine("Thank you for using the Library System. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
