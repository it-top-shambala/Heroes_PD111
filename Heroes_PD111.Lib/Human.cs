namespace Heroes_PD111.Lib;

public abstract class Human : Hero
{
    protected Human(string name) : base(name)
    {
        _health = 100;
        _damage = 100;
    }
}
