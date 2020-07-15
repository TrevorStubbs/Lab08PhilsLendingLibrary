using Lab08PhilsLendingLibrary.Classes;
using System;
using System.Collections.Generic;

namespace Lab08PhilsLendingLibrary
{
    public class Program
    {
        static Library<Book> Library { get; set; }
        static List<Book> BookBag { get; set; }

        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new List<Book>();

            LoadInitialBooks();
            UserInterface();
            Console.ReadLine(); // remove
        }

        static void LoadInitialBooks()
        {
            Library.Add(new Book("Mission Impossible", "Peter", "Barsocchini"));
            Library.Add(new Book("Short Victorious War", "David", "Webb"));
            Library.Add(new Book("Lord Of Chaos", "Robert", "Jordan"));
            Library.Add(new Book("Harry Potter", "JK", "Rowling"));
            Library.Add(new Book("Lord of the Rings", "JRR", "Tolkien"));            
        }

        static void UserInterface()
        {
            Console.WriteLine("Welcome to Phil's Lending library");
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                ShowMenu();

                string userString = Console.ReadLine();
                int.TryParse(userString, out int userInput);               

                switch (userInput)
                {
                    case 1:
                        ViewAllBooks();
                        break;
                    case 2:
                        AddABook();
                        break;
                    case 3:
                        // BorrowABook();
                        break;
                    case 4:
                        // ReturnABook();
                        break;
                    case 5:
                        // ViewBookBag();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using Phil's Lending Library");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection");
                        break;
                }                
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View all Books");
            Console.WriteLine("2. Add a Book");
            Console.WriteLine("3. Borrow a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. View Book Bag");
            Console.WriteLine("6. Exit");
        }

        public static void ViewAllBooks()
        {
            Book[] books = Library.GetItems();

            int counter = 1;

            foreach (Book book in books)
            {
                Console.WriteLine($"{counter++}. {book.Title}, written by {book.Author.FirstName} {book.Author.LastName}");                
            }
        }

        public static void AddABook()
        {
            Console.WriteLine("Lets add a new book to the library.");
            Console.WriteLine("What is the Title of the book you want to add?");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("What is the First Name of the book's author?");
            string bookFirst = Console.ReadLine();
            Console.WriteLine("What is the Last Name of the book's author?");
            string bookLast = Console.ReadLine();

            Book thisBook = new Book(bookTitle, bookFirst, bookLast);

            Library.Add(thisBook);

            Console.WriteLine();

            Console.WriteLine($"You have added {thisBook.Title}");
        }


    }
}
