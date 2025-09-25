using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftAgenda
{
    internal class ContactList
    {
        private List<Contact> Contacts { get; set; }

        public ContactList() 
        { 
            this.Contacts = new List<Contact>(); 
        }

        public void DisplayContacts()
        {
            foreach (var contact in this.Contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        public void PrintInReverseOrder()
        {
            for (int i = this.Contacts.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.Contacts[i].ToString());
            }
        }

        private void SortContactsByName()
        {
            this.Contacts.Sort();
        }

        public void AddContact(Contact other)
        {
            this.Contacts.Add(other);
            SortContactsByName();
        }
    }
}
