using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftAgenda
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
            Name = name;
        }
        public Contact(string name, string phoneNumber) : this(name)
        {
            if (!long.TryParse(phoneNumber, out _))
            {
                throw new ArgumentException("El teléfono debe de ser un número válido");
            }
            PhoneNumber = phoneNumber;
        }
        public Contact(string name, string phoneNumber, string email) : this(name, phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }
            Email = email;
        }
    }
}
