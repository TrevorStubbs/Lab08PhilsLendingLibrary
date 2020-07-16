using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Book
    {
        private string v1;
        private string v2;
        private string v3;
        private int v4;

        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }

        /// <summary>
        /// Book Class Constructor
        /// </summary>
        /// <param name="title">String for the title</param>
        /// <param name="firstName">String for the First name</param>
        /// <param name="lastName">String for the last name</param>
        public Book(string title, string firstName, string lastName, Genre genre)
        {
            Author = new Author(firstName, lastName);
            Title = title;
            Genre = genre;
        }

        /// <summary>
        /// Title property getter
        /// </summary>
        /// <returns>returns a string</returns>
        public string GetTitle()
        {
            return Title;
        }

        /// <summary>
        /// Book title setter
        /// </summary>
        /// <param name="title">Takes in a string</param>
        public void SetTitle(string title)
        {
            Title = title;
        }

        /// <summary>
        /// Author property getter
        /// </summary>
        /// <returns>returns an Author object</returns>
        public Author GetAuthor()
        {
            return Author;
        }

        /// <summary>
        /// Author object setter
        /// </summary>
        /// <param name="author">Take in an author object</param>
        public void SetAuthor(Author author)
        {
            Author = author;
        }

        public Genre GetGenre()
        {
            return Genre;
        }

        public void SetGenre(Genre genre)
        {
            Genre = genre;
        }

    }
}
