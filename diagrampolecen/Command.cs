namespace diagrampolecen;

public abstract class Command
{
    public Target Target { get; set; }
    public abstract void Execute();
}