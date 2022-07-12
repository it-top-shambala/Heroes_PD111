namespace Heroes_PD111.Lib;

public abstract class Orc : Hero
{
    protected Orc(string name) : base(name)
    {
        Health = 150;
        Damage = 150;
    }
}
