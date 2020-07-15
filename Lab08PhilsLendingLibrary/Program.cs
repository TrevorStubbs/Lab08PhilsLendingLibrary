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

            // LoadInitialBooks();
            UserInterface();
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
                        // ViewAllBooks();
                        break;
                    case 2:
                        // AddABook();
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
    }
}
