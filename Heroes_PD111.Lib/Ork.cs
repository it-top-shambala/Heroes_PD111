namespace Heroes_PD111.Lib;

public abstract class Ork : Hero
{
    protected Ork(string name) : base(name)
    {
        Health = 150;
        Damage = 150;
    }
}
