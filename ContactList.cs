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
    }
}
