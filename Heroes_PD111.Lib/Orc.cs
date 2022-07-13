namespace Heroes_PD111.Lib;

public abstract class Orc : Hero
{
    protected Orc(string name) : base(name)
    {
        _health = 150;
        _damage = 150;
    }
}
