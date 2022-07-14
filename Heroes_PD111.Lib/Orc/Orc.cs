using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.Lib.Orc;

public abstract class Orc : Hero
{
    protected Orc(string name) : base(name)
    {
        _health = 150;
        _damage = 150;
    }
}
