using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
    }
}
