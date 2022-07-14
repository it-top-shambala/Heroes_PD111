using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.Lib.Human;

public abstract class Human : Hero
{
    protected Human(string name) : base(name)
    {
        _health = 100;
        _damage = 100;
    }
}
