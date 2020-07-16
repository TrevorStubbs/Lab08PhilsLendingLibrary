using Lab08PhilsLendingLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab08PhilsLendingLibrary
{
    public class Program
    {
        static Library<Book> Library { get; set; }
        static List<Book> BookBag { get; set; }

        /// <summary>
        /// Main insertion into the program. It loads the inital books then starts the user interface.
        /// </summary>
        /// <param name="args">Magic</param>
        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new List<Book>();

            LoadInitialBooks();
            UserInterface();
        }

        /// <summary>
        /// This sets up the library with a few books
        /// </summary>
        static void LoadInitialBooks()
        {
            Library.Add(new Book("Mission Impossible", "Peter", "Barsocchini")); 
            Library.Add(new Book("Short Victorious War", "David", "Webb"));
            Library.Add(new Book("Lord Of Chaos", "Robert", "Jordan"));
            Library.Add(new Book("Harry Potter", "JK", "Rowling"));
            Library.Add(new Book("Lord of the Rings", "JRR", "Tolkien"));
        }

        /// <summary>
        /// This is the main user interface. 
        /// </summary>
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
                        BorrowABook();
                        break;
                    case 4:
                        ReturnABook();
                        break;
                    case 5:
                        ViewBookBag();
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

        /// <summary>
        /// This is a helper function for the user interface.
        /// It displays the posible options for the user.
        /// </summary>
        static void ShowMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View all Books in the Library");
            Console.WriteLine("2. Add a Book");
            Console.WriteLine("3. Borrow a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. View Book Bag");
            Console.WriteLine("6. Exit");
        }

        /// <summary>
        /// This calls the GetItems method from the library and displays them for the user
        /// </summary>
        public static void ViewAllBooks()
        {
            Book[] books = Library.GetItems();

            int counter = 1;

            foreach (Book book in books)
            {
                Console.WriteLine($"{counter++}. {book.Title}, written by {book.Author.FirstName} {book.Author.LastName}");                
            }
        }

        /// <summary>
        /// This method allows the user to add a book to the library.
        /// </summary>
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

        /// <summary>
        /// This method shows the user all the books in the library and allows them to select one.
        /// Once its selected its pulled out of the library and added to users bookbag.
        /// </summary>
        public static void BorrowABook()
        {
            ViewAllBooks();
            Console.WriteLine("Please type in the book's number to check it out.");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int bookNumber);
            if(bookNumber > Library.Count())
            {
                Console.WriteLine("I am sorry that is not a valid choice");
                BorrowABook();
                return;
            }
            Book removedBook = Library.Remove(bookNumber);
            BookBag.Add(removedBook);
            Console.WriteLine($"{removedBook.Title} is now in your book bag.");
        }

        /// <summary>
        /// This allows the user to take abook out of thier bag and put it back into the library.
        /// </summary>
        public static void ReturnABook()
        {
            // Based off of Amanda's ReturnBook() method.            
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            Console.WriteLine("What book would you like to return?");
            int counter = 1;
            foreach (Book book in BookBag)
            {
                books.Add(counter, book);
                Console.WriteLine($"{counter++}. {book.Title}, written by {book.Author.FirstName} {book.Author.LastName}");
            }

            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int numberSelected);
            books.TryGetValue(numberSelected, out Book returnedBook);
            BookBag.Remove(returnedBook);
            Library.Add(returnedBook);

        }

        /// <summary>
        /// This allows the user to see all their book in their book bag. 
        /// </summary>
        public static void ViewBookBag()
        {
            Console.WriteLine("Here are the books in your bag.");
            int counter = 1;
            foreach(Book book in BookBag)
            {
                Console.WriteLine($"{counter++}. {book.Title}, written by {book.Author.FirstName} {book.Author.LastName}");
            }
        }
    }
}
