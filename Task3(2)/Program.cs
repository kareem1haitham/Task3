namespace Task3_2_
{
    class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SearchBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Availability} Is found");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
        public void BorrowBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    if (book.Availability)
                    {
                        book.Availability = false;
                        Console.WriteLine($"You borrowed: {book.Title}");
                    }
                    else
                    {
                        Console.WriteLine("This book is not available.");
                    }
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        public void ReturnBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    book.Availability = true;
                    Console.WriteLine($"You returned: {book.Title}");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }


    }
    class Book
    { 
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; } 
        public Book(string title, string author, string iSBN )
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availability = true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565" ));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.SearchBook("1984");

            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();
        }


    }
}
