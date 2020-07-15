using System;
using Xunit;
using static Lab08PhilsLendingLibrary.Program;
using Lab08PhilsLendingLibrary.Classes;

namespace Lab08PhilsLendingLibraryUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddABook()
        {
            // Arrange
            Library<Book> Library = new Library<Book>();
            Book thisBook = new Book("Top Gun", "Bob", "Smith");
            //Act
            Library.Add(thisBook);
            //Assert


        }
    }
}
