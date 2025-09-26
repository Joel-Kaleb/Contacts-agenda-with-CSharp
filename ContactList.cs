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
            if (this.Contacts.Count == 0) 
            {
                Console.WriteLine("No hay contactos registrados");
                return; 
            }
            foreach (var contact in this.Contacts)
            {
                Console.WriteLine(contact.ToString() + "\n");
            }
        }

        public void PrintInReverseOrder()
        {
            if (this.Contacts.Count == 0)
            {
                Console.WriteLine("No hay contactos registrados");
                return;
            }
            for (int i = this.Contacts.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.Contacts[i].ToString() + "\n");
            }
        }

        private void SortContactsByName()
        {
            this.Contacts.Sort();
        }

        public void AddContact(Contact other)
        {
            if (this.Contacts.Contains(other))
            {
                throw new ArgumentException($"El contacto {other.Name} {other.LastName} " +
                    $"ya existe en la agenda.");
            }
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
