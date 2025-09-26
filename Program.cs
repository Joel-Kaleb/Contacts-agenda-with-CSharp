namespace DraftAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputUser;
            string input;
            ContactList agenda = new ContactList();
            do
            {
                ShowMenu();
                input = Console.ReadLine();

                if (int.TryParse(input, out inputUser))
                {
                    switch (inputUser)
                    {
                        case 1:
                            ViewContacts(agenda);
                            break;
                        case 2:
                            AddContact(agenda);
                            break;
                        case 3:
                            DeleteLastContact(agenda);
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("La opción no es valida, precione enter para continuar");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número. Presione Enter.");
                    Console.ReadLine();
                }

            }while (inputUser != 5);
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Agenda de Contactos");
            Console.WriteLine("1. Ver Contactos");
            Console.WriteLine("2. Agregar Contacto");
            Console.WriteLine("3. Borrar Último Contacto");
            Console.WriteLine("4. Buscar Contacto Por Nombre");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void ViewContacts(ContactList agenda)
        {
            Console.Clear();
            Console.WriteLine("1. Mostrar orden ascendente");
            Console.WriteLine("2. Mostrar orden descendente");
            Console.WriteLine("3. Volver a menú principal");
            Console.Write("Seleccione una opción: ");
            string input = Console.ReadLine();
            int inputNumber;

            if (int.TryParse(input, out inputNumber) && (inputNumber >= 1 && inputNumber <= 3))
            {
                Console.Clear();
                if (inputNumber == 1)
                {
                    agenda.DisplayContacts();
                }
                else if(inputNumber == 2) 
                {
                    agenda.PrintInReverseOrder();
                }
                else if(inputNumber == 3)
                {
                    return;
                }

                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("La opción ingresada no es valida, volviendo al menú principal," +
                    "precione enter para continuar");
                Console.ReadLine();
                return;
            }
        }

        static void AddContact(ContactList agenda)
        {
            string name, lastName, phone, email;

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("--- AGREGAR CONTACTO ---");

                    Console.Write("Ingresa el nombre del contacto: ");
                    name = Console.ReadLine();

                    Console.Write("Ingresa el apellido del contacto: ");
                    lastName = Console.ReadLine();

                    Console.Write("Ingresa el teléfono del contacto: ");
                    phone = Console.ReadLine();

                    Console.Write("Ingresa el Email del contacto: ");
                    email = Console.ReadLine();

                    Contact newContact = new Contact(name, lastName, phone, email);

                    agenda.AddContact(newContact);

                    Console.WriteLine("\n¡Contacto agregado exitosamente! Presiona Enter.");
                    Console.ReadLine();

                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.Clear();
                    Console.WriteLine("--- ERROR DE VALIDACIÓN ---");
                    Console.WriteLine(ex.Message); 
                    Console.WriteLine("\nPresiona Enter para intentar de nuevo...");
                    Console.ReadLine();
                }
            }
        }

        static void DeleteLastContact(ContactList agenda)
        {
            Console.Clear();
            string lastContactName = agenda.RemoveLastContact();
            if (string.IsNullOrEmpty(lastContactName))
            {
                Console.WriteLine("No hay contactos registrados");
            }
            else
            {
                Console.WriteLine($"El contacto {lastContactName} fue borrado existosamente");
            }
            Console.WriteLine("\nPrecione enter para continuar...");
            Console.ReadLine();
        }
    }
}
