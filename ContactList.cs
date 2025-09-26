namespace DraftAgenda
{
    internal class ContactList
    {
        private List<Contact> _contacts { get; set; }

        public ContactList() 
        { 
            this._contacts = new List<Contact>(); 
        }

        public void DisplayContacts()
        {
            if (this._contacts.Count == 0) 
            {
                Console.WriteLine("No hay contactos registrados");
                return; 
            }
            foreach (var contact in this._contacts)
            {
                Console.WriteLine(contact.ToString() + "\n");
            }
        }

        public void PrintInReverseOrder()
        {
            if (this._contacts.Count == 0)
            {
                Console.WriteLine("No hay contactos registrados");
                return;
            }
            for (int i = this._contacts.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this._contacts[i].ToString() + "\n");
            }
        }

        private void SortContactsByName()
        {
            this._contacts.Sort();
        }

        public void AddContact(Contact other)
        {
            if (this._contacts.Contains(other))
            {
                throw new ArgumentException($"El contacto {other.Name} {other.LastName} " +
                    $"ya existe en la agenda.");
            }
            this._contacts.Add(other);
            SortContactsByName();
        }

        public string RemoveLastContact()
        {
            if (this._contacts.Count == 0)
            {
                return string.Empty;
            }
            string lastContact = this._contacts[_contacts.Count - 1].Name;
            this._contacts.RemoveAt(_contacts.Count - 1);
            return lastContact;
        }

        public bool FindContactByName(string name)
        {
            name = Contact.CapitalizedFirstLetter(name);
            foreach (var contact in this._contacts)
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
