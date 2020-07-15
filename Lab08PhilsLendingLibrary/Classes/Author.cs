using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Author
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
