using Heroes_PD111.Lib.Base;

namespace Heroes_PD111.Lib.Human;

public class HumanWarrior : Human, IWarrior
{
    public HumanWarrior(string name) : base(name)
    {
    }

    public void WarriorAttack(Hero enemy)
    {
        enemy.GetDamage(Damage);
    }
}
