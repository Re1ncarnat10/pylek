using diagrampolecen;

class Program
{
    static void Main(string[] args)
    {
        Lux lux = new Lux();
        AllyChampion ally = new AllyChampion("Garen");
        Target enemy = new Target();

        lux.LightBinding.Target = enemy;
        lux.LightBinding.Execute();

        lux.PrismaticBarrier.Target = ally;
        lux.PrismaticBarrier.Execute();

        Console.WriteLine($"Enemy health: {enemy.Health}");
    }
}