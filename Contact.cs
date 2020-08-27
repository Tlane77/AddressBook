using System;
using System.Collections.Generic;

namespace AddressBook
{

    public class Contact
    {
        /*
            1. Add the required classes to make the following code compile.
            HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

            2. Run the program and observe the exception.

            3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
                Print meaningful error messages in the catch blocks.
        */

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName}{LastName}"; }

            public string Email { get; set; }

            public string Address { get; set; }

            public Dictionary<string, Contact> ContactList { get; set; }
        }

    }