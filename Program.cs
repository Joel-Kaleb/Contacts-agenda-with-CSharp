namespace DraftAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputUser;
            string input;
            do
            {
                ShowMenu();
                input = Console.ReadLine();
                switch (input)
                {
                }

            }while (!int.TryParse(input, out inputUser) || inputUser != 5);
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
    }
}
