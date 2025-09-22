namespace DraftAgenda
{
    internal class Contact //: IComparable<Contact>
    {
        public string Name { get; set; }
        public string LastName { get; set; }    
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
        public Contact(string name, string lastName) : this(name)  
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("El apellido no puede estar vacío.");
            }
            LastName = lastName;
        }
        public Contact(string name, string lastName,string phoneNumber) : this(name, lastName)
        {
            if (!long.TryParse(phoneNumber, out _))
            {
                throw new ArgumentException("El teléfono debe de ser un número válido");
            }
            PhoneNumber = phoneNumber;
        }
        public Contact(string name, string lastName,string phoneNumber, string email) : this(name, lastName, phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }
            Email = email;
        }
    }
}
