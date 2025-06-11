namespace diagrampolecen;

public class PrismaticBarrier : Command
{
    public Shield Shield { get; set; }

    public PrismaticBarrier()
    {
        Shield = new Shield(50);
    }

    public override void Execute()
    {
        if (Target is AllyChampion ally)
        {
            ally.ReceiveShield(Shield);
        }
    }
}