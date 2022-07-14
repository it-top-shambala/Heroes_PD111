using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.Lib.Orc;

public class OrcWarrior : Orc, IWarrior
{
    public OrcWarrior(string name) : base(name)
    {
    }

    public void WarriorAttack(Hero enemy)
    {
        enemy.GetDamage(Damage);
    }
}
