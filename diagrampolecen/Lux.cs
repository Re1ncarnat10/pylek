namespace diagrampolecen;

public class Lux : Champion
{
    public LightBinding LightBinding { get; set; }
    public PrismaticBarrier PrismaticBarrier { get; set; }

    public Lux() : base("Lux")
    {
        LightBinding = new LightBinding();
        PrismaticBarrier = new PrismaticBarrier();
    }
}