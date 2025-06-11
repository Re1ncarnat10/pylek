namespace pylek;

public class Icon
{
    public string Name { get; }
    public int Size { get; }

    public Icon(string name, int size)
    {
        Name = name;
        Size = size;
        Console.WriteLine($"Tworzenie ikony: {name}, rozmiar: {size}");
    }

    public void Display()
    {
        Console.WriteLine($"Wyświetlanie ikony: {Name}, rozmiar: {Size}");
    }
}