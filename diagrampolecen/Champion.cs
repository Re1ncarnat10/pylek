namespace diagrampolecen;

public class Champion
{
    public string Name { get; set; }
    public Movement Movement { get; set; }

    public Champion(string name)
    {
        Name = name;
        Movement = new Movement();
    }
}