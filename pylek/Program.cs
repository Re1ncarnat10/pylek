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
            Console.WriteLine("2. Pokaż liczbę unikalnych ikon");
            Console.WriteLine("0. Wyjdź");
            Console.Write("Wybierz opcję: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Podaj nazwę ikony: ");
                var name = Console.ReadLine();
                Console.Write("Podaj ścieżkę do pliku: ");
                var filePath = Console.ReadLine();

                var icon = factory.GetIcon(name, filePath);
                icon.Display(0, 0);

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine($"Liczba unikalnych ikon: {factory.IconCount}");
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