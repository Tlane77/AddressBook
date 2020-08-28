using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> ContactList { get; set; }
        /*
            1. Add the required classes to make the following code compile.
            HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

            2. Run the program and observe the exception.

            3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
                Print meaningful error messages in the catch blocks.
        */

        //Constructor look like functions but always named after a class. (no static or void modifiers on it)

        public AddressBook()
        {
            ContactList = new Dictionary<string, Contact>();
        }
        // Create an AddressBook and add some contacts to it

        public void AddContact(Contact NewContact)
        {
            ContactList.Add(NewContact.Email, NewContact);
        }

        public Contact GetByEmail(string email)
        {
            return ContactList[email];
        }
    }
}