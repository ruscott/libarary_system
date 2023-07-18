namespace LibrarySystem.Actions
{

using LibrarySystem.Models;
using System;

class AdminActions
{
    public static void PerformActions(Library library)
    {
        Console.WriteLine("Welcome, admin!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Add a Book");
        Console.WriteLine("2. Remove a Book");

        string adminOption = Console.ReadLine();

        if (adminOption == "1")
        {
            Console.WriteLine("Enter the title of the book you want to add:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the author of the book:");
            string author = Console.ReadLine();

            Book newBook = new Book { Title = title, Author = author, IsAvailable = true };
            library.AddBook(newBook);

            Console.WriteLine($"Book '{newBook.Title}' by {newBook.Author} has been added to the library.");
        }
        else if (adminOption == "2")
        {
            Console.WriteLine("Books in the library:");
            Library.PrintBooks(library.GetBooks());

            Console.WriteLine("Enter the title of the book you want to remove:");
            string title = Console.ReadLine();
            Book selectedBook = library.GetBookByTitle(title);

            if (selectedBook != null)
            {
                // library.RemoveBook(selectedBook);
                Console.WriteLine($"Book '{selectedBook.Title}' by {selectedBook.Author} has been removed from the library.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
}
}