using System;
using Xunit;
using static Lab08PhilsLendingLibrary.Program;
using Lab08PhilsLendingLibrary.Classes;

namespace Lab08PhilsLendingLibraryUnitTests
{
    public class LendingLibraryTests
    {
        [Fact]
        public void CanAddABook()
        {
            // Arrange
            Library<Book> Library = new Library<Book>();
            Book thisBook = new Book("Top Gun", "Bob", "Smith", (Genre)1);
            //Act
            Library.Add(thisBook);
            Book[] testBook = new Book[1];
            foreach (Book book in Library)
            {
                testBook[0] = book;
            }

            //Assert
            Assert.Equal(thisBook, testBook[0]);
        }

        [Fact]
        public void CanRemoveBookFromLibrary()
        {
            // Arrange
            Library<Book> Library = new Library<Book>();
            Library.Add(new Book("Mission Impossible", "Peter", "Barsocchini", (Genre)1));
            Library.Add(new Book("Short Victorious War", "David", "Webb", (Genre)5));
            Library.Add(new Book("Lord Of Chaos", "Robert", "Jordan", (Genre)4));
            Library.Add(new Book("Harry Potter", "JK", "Rowling", (Genre)4));
            //Act
            Book[] bookArray = new Book[4];

            int counter = 0;
            foreach (Book book in Library)
            {
                bookArray[counter++] = book;
            }
            Book removedBook = Library.Remove(1);

            Assert.Equal(bookArray[0], removedBook);

        }

        [Fact]
        public void CannotRemoveABookThatDoesntExist()
        {
            Library<Book> Library = new Library<Book>();
            Library.Add(new Book("Mission Impossible", "Peter", "Barsocchini", (Genre)1));
            Library.Add(new Book("Short Victorious War", "David", "Webb", (Genre)5));
            Library.Add(new Book("Lord Of Chaos", "Robert", "Jordan", (Genre)4));

            Exception e = Assert.Throws<System.Exception>(() => Library.Remove(4));

            string expected = "That book does not exist";

            Assert.Equal(expected, e.Message);
        }

        [Fact]
        public void GetAuthorFirstName()
        {
            Author author = new Author("Tom", "Hanks");

            string expected = "Tom";
            string outputFromMethod = author.GetFirstName();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void GetAuthorLastName()
        {
            Author author = new Author("Tom", "Hanks");

            string expected = "Hanks";
            string outputFromMethod = author.GetLastName();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void SetAuthorFirstName()
        {
            Author author = new Author("Tom", "Hanks");

            string expected = "Bob";
            author.SetFirstName("Bob");
            string outputFromMethod = author.GetFirstName();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void SetAuthorLastName()
        {
            Author author = new Author("Tom", "Hanks");

            string expected = "Rogers";
            author.SetFirstName("Rogers");
            string outputFromMethod = author.GetFirstName();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void GetBookTitle()
        {
            Book thisBook = new Book("Top Gun", "Bob", "Smith", (Genre)6);
            string expected = "Top Gun";
            string outputFromMethod = thisBook.GetTitle();

            Assert.Equal(expected, outputFromMethod);

        }

        [Fact]
        public void SetBookTitle()
        {
            Book thisBook = new Book("Top Gun", "Bob", "Smith", (Genre)6);
            thisBook.SetTitle("Lamnda");
            string expected = "Lamnda";
            string outputFromMethod = thisBook.GetTitle();
            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void GetBookAuthor()
        {
            Book thisBook = new Book("Top Gun", "Bob", "Smith", (Genre)6);
            string expected = "Bob";
            string outputFromMethod = thisBook.Author.GetFirstName();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void SetBookAuthor()
        {
            Book thisBook = new Book("Top Gun", "Bob", "Smith", (Genre)6);
            Author author = new Author("Tom", "Hanks");
            string expected = "Tom";

            thisBook.SetAuthor(author);
            string outputFromMethod = thisBook.Author.GetFirstName();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void AccurateCoutOfBooksInLibrary()
        {
            Library<Book> Library = new Library<Book>();
            Library.Add(new Book("Mission Impossible", "Peter", "Barsocchini", (Genre)1));
            Library.Add(new Book("Short Victorious War", "David", "Webb", (Genre)5));
            Library.Add(new Book("Lord Of Chaos", "Robert", "Jordan", (Genre)4));

            int expected = 3;

            int outputFromMethod = Library.Count();

            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void GetItemsReturnsAllItems()
        {
            Library<Book> Library = new Library<Book>();
            Library.Add(new Book("Mission Impossible", "Peter", "Barsocchini", (Genre)1));
            Library.Add(new Book("Short Victorious War", "David", "Webb", (Genre)5));
            Library.Add(new Book("Lord Of Chaos", "Robert", "Jordan", (Genre)4));

            Book[] bookArray = new Book[3];

            int counter = 0;
            foreach (Book book in Library)
            {
                bookArray[counter++] = book;
            }

            Book[] gottenItems = Library.GetItems();

            Assert.Equal(bookArray, gottenItems);
        }
    }
}
