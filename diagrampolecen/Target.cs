namespace diagrampolecen;

public class Target
{
    public int Health { get; set; } = 200;
    public virtual void ReceiveDamage(Damage damage)
    {
        Health -= damage.Amount;
    }
    public virtual void ReceiveShield(Shield shield) { }
}