namespace pylek;

public class Icon
{
    public string Name { get; }
    public string FilePath { get; }

    public Icon(string name, string filePath)
    {
        Name = name;
        FilePath = filePath;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Wyświetlam ikonę '{Name}' z pliku '{FilePath}' na pozycji ({x}, {y})");
    }
}