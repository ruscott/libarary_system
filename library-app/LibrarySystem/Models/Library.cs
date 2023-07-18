namespace LibrarySystem.Models
{

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetBooks()
    {
        return books;
    }

    public Book? GetBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;

        }
    public static void PrintBooks(List<Book> books)
    {
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, IsAvailable: {book.IsAvailable}");
        }
    }
}
}