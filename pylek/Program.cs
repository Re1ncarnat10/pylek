using pylek;

class Program
{
    static void Main()
    {
        var factory = new IconFactory();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== System zarządzania ikonami ===");
            Console.WriteLine("1. Dodaj i wyświetl ikonę");
            Console.WriteLine("2. Pokaż wszystkie ikony");
            Console.WriteLine("0. Wyjdź");
            Console.Write("Wybierz opcję: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Podaj nazwę ikony: ");
                var name = Console.ReadLine();
                Console.Write("Podaj rozmiar ikony: ");
                var sizeInput = Console.ReadLine();

                if (!int.TryParse(sizeInput, out int size))
                {
                    Console.WriteLine("Nieprawidłowy rozmiar. Naciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                    continue;
                }

                var icon = factory.GetIcon(name, size);
                icon.Display();

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine($"Liczba unikalnych ikon: {factory.IconCount}");
                factory.DisplayAllIcons();

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
            else if (choice == "0")
            {
                break;
            }
        }
    }
}