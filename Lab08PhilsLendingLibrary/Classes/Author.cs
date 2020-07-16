using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08PhilsLendingLibrary.Classes
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Author Constructor
        /// </summary>
        /// <param name="firstName">A string for the first name</param>
        /// <param name="lastName">A string for the last name</param>
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// First name Getter
        /// </summary>
        /// <returns>Returns a string</returns>
        public string GetFirstName()
        {
            return FirstName;
        }

        /// <summary>
        /// First Name Setter
        /// </summary>
        /// <param name="firstName">Takes a string</param>
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        /// <summary>
        /// Last name Getter
        /// </summary>
        /// <returns>Returns a string</returns>
        public string GetLastName()
        {
            return LastName;
        }

        /// <summary>
        /// Last Name Setter
        /// </summary>
        /// <param name="firstName">Takes a string</param>
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
    }
}
