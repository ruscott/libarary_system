namespace LibrarySystem.Actions
{

using LibrarySystem.Models;
using System;

class CustomerActions
{
    public static void PerformActions(Library library)
    {
        Console.WriteLine("Welcome, customer!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Check In a Book");
        Console.WriteLine("2. Check Out a Book");

        string customerOption = Console.ReadLine();

        if (customerOption == "1")
        {
            Console.WriteLine("Books in the library:");
            Library.PrintBooks(library.GetBooks());

            Console.WriteLine("Enter the title of the book you want to check in:");
            string title = Console.ReadLine();
            Book selectedBook = library.GetBookByTitle(title);

            if (selectedBook != null && !selectedBook.IsAvailable)
            {
                selectedBook.IsAvailable = true;
                Console.WriteLine($"Book '{selectedBook.Title}' has been checked in successfully.");
            }
            else
            {
                Console.WriteLine("Book not found or already checked in.");
            }
        }
        else if (customerOption == "2")
        {
            Console.WriteLine("Books in the library:");
            Library.PrintBooks(library.GetBooks());

            Console.WriteLine("Enter the title of the book you want to check out:");
            string title = Console.ReadLine();
            Book selectedBook = library.GetBookByTitle(title);

            if (selectedBook != null && selectedBook.IsAvailable)
            {
                selectedBook.IsAvailable = false;
                Console.WriteLine($"Book '{selectedBook.Title}' has been checked out successfully.");
            }
            else
            {
                Console.WriteLine("Book not found or already checked out.");
            }
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }

    
}}
