using LibrarySystem.Models;
using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Library class
            Library library = new Library();

            // Create some books
            Book book1 = new Book { Title = "Book 1", Author = "Author 1", IsAvailable = true };
            Book book2 = new Book { Title = "Book 2", Author = "Author 2", IsAvailable = false };
            Book book3 = new Book { Title = "Book 3", Author = "Author 3", IsAvailable = true };

            // Add the books to the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Display the books in the library
            Console.WriteLine("Books in the library:");
            foreach (Book book in library.GetBooks())
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, IsAvailable: {book.IsAvailable}");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }