using Lab08PhilsLendingLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int NumberOfPages { get; set; }
        public Genres Genre { get; set; }

        public Book(string title, string firstName, string lastName)
        {
            Author = new Author(firstName, lastName);
            Title = title;
        }

        public enum Genres : byte
        {
            fiction = 1,
            nonfiction,
            fantasy,
            scifi,
            historic
        };
    }
}
