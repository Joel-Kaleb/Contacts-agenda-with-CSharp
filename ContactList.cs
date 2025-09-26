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

        public string RemoveLastContact()
        {
            if (this.Contacts.Count == 0)
            {
                return string.Empty;
            }
            string lastContact = this.Contacts[Contacts.Count - 1].Name;
            this.Contacts.RemoveAt(Contacts.Count - 1);
            return lastContact;
        }

        public bool FindContactByName(string name)
        {
            name = Contact.CapitalizedFirstLetter(name);
            foreach (var contact in this.Contacts)
            {
                if (contact.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
