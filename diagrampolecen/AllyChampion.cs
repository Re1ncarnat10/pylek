namespace diagrampolecen;

public class AllyChampion : Target
{
    public string Name { get; set; }
    public Shield Shield { get; set; }

    public AllyChampion(string name)
    {
        Name = name;
    }

    public override void ReceiveShield(Shield shield)
    {
        Shield = shield;
    }
}