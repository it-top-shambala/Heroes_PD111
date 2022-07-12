namespace Heroes_PD111.Lib;

public abstract class Human : Hero
{
    protected Human(string name) : base(name)
    {
        Health = 100;
        Damage = 100;
    }
}
