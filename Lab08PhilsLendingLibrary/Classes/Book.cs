using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public Book(string title, string firstName, string lastName)
        {
            Author = new Author(firstName, lastName);
            Title = title;
        }
    }
}
