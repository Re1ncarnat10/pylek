namespace diagrampolecen;

public class LightBinding : Command
{
    public Damage Damage { get; set; }

    public LightBinding()
    {
        Damage = new Damage(100);
    }

    public override void Execute()
    {
        Target?.ReceiveDamage(Damage);
    }
}